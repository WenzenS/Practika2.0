using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Client
    {
        static public DataTable dtclient = new DataTable();
        static public void GetClient()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM client";
                dtclient.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtclient);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
