using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            frmSimulation frs = new frmSimulation();
            frs.Show();
            this.Hide();
        }

        private void btnJet_Click(object sender, EventArgs e)
        {
            frmJet frj = new frmJet();
            frj.Show();
            this.Hide();
        }
    }
}
