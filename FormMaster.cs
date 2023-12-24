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
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void FormMaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            Users.GetUsers();
            dataGridView1.DataSource = Users.dtusers;
            Employment.GetEmployment();
            dataGridView1.DataSource = Employment.dtemployment;
            Training.GetTraning();
            dataGridView1.DataSource = Training.dttaraining;
        }
    }
}
