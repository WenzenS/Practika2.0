using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika2._0
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void FormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Employment.GetEmployment();
            dataGridView1.DataSource = Employment.dtemployment;
        }
    }
}
