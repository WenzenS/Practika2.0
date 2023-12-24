using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    internal class Log
    {
        static public string Role, User;

        static public void Authorizations(string login, string password)
        {
            try
            {
                Connect.msCommand.CommandText = $"SELECT accessuser FROM user WHERE login = '{login}' AND password = '{password}'";
                Object result = Connect.msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch
            {
                Role =  User = null;
                MessageBox.Show("Ошибка авторизации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
