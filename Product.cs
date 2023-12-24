using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Product
    {
        static public DataTable dtproduct = new DataTable();
        static public void GetProduct()
        {
            try
            {
                Connect.msCommand.CommandText = "SELECT * FROM product";
                dtproduct.Clear();
                Connect.msDataAdapter.SelectCommand = Connect.msCommand;
                Connect.msDataAdapter.Fill(dtproduct);
            }
            catch
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
