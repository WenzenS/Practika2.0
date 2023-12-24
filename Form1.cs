using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    public partial class Form1 : Form
    {
        static public string loginActive;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect.ConnectionDB(); 
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {   
                Log.Authorizations(textBox1.Text, textBox2.Text);
                switch (Log.Role)
                {
                    case null:
                        {
                            MessageBox.Show("Такого аккаунта не существует!", "Проверьте данные и попробуйте снова", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case "1": 
                        { 
                            this.Hide();
                            FormMaster form = new FormMaster();
                            form.Show();
                            break;
                        }
                    case "2":
                        { 
                            this.Hide();
                            FormUser form = new FormUser();
                            form.Show();
                            break;
                        }
                }
            } 
            else
            {
                MessageBox.Show("Заполните все обязательные поля!", "Заполнение полей обязательно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
