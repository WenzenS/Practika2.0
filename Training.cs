using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Training
    {
        static public DataTable dttaraining = new DataTable();
        static public void GetTraning()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM taraining";
                dttaraining.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dttaraining);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
