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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            Jets j = new Jets();
            j.JetID = txtID.Text;
            j.Name = txtName.Text;
            j.MaximumAltitude = txtAltitude.Text;
            j.TopSpeed = txtSpeed.Text;
            j.TypeOfWeapons = txtWeapns.Text;
            j.FuelTankSize = txtFuel.Text;
            j.InventoryCapacity = txtInvent.Text;
            try
            {
                DataHandler.Insert(j);
                DialogResult dr= MessageBox.Show("Inserted", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr==DialogResult.OK)
                {
                    frmJet frj = new frmJet();
                    frj.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
