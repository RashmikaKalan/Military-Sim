using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA2
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            rcbDisp.Text = File.ReadAllText(@"Report.txt");
        } //displays the report of the simulation

        private void rcbDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSimulation frs = new frmSimulation();
            frs.Show();
            this.Hide();
        }
    }
}
