using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Reports : Form
    {
        CrystalReport1 CR;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
           
        }

        private void viewEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            crystalReportViewer1.ReportSource = CR;
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            employeeForm E = new employeeForm();
            E.Show();
        }
    }
}
