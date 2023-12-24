using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Employment
    {
        static public DataTable dtemployment = new DataTable();
        static public void GetEmployment()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM employment";
                dtemployment.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtemployment);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
