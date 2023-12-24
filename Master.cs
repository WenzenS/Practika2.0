using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Master
    {
        static public DataTable dtmaster = new DataTable();
        static public void GetMaster()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM master";
                dtmaster.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtmaster);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
