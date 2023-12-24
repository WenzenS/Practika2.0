using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Status
    {
        static public DataTable dtuser = new DataTable();
        static public void GetUsers()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM user";
                dtuser.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtuser);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
