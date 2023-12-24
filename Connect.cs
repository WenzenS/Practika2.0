using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Connect
    {
        static readonly string Connectbd = "server = localhost; user=root; password=1234; database=tochno";
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myconnect;
        static public MySqlCommand msCommand;

        public static bool ConnectionDB()
        {
            try
            {
                myconnect = new MySqlConnection(Connectbd);
                myconnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myconnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("База Данных не подключена");
                return false;
            }
        }
        public static void CloseDB()
        {
            myconnect.Close();
        }
        public MySqlConnection getConnection()
        {
            return myconnect;
        }
    }
}
