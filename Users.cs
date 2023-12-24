using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Users
    {
        static public DataTable dtusers = new DataTable();
        static public void GetUsers()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM users";
                dtusers.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtusers);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
