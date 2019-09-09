using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA2
{
    public partial class frmJet : Form
    {
        BindingSource bs = new BindingSource();
        public void Bind(List<Jets> jb)
        {
            jb = DataHandler.GetJet();
            bs.DataSource = jb;
            dgvDisp.DataSource = bs;
        } //method to bind data to datagridview

        public frmJet()
        {
            InitializeComponent();
        }
        #region DoubleClick
        private void btnAddA_Click(object sender, EventArgs e)
        {
            this.Size = new Size(934, 374);
        }
        private void gbAir_Enter(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdd fra = new frmAdd();
                fra.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        } //displays the form to add a jet to the database
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(934, 635);
                gbUpdate.Visible = true;
                List<Jets> ju = new List<Jets>();
                ju = DataHandler.GetJet();
                Bind(ju);
                txtIDU.DataBindings.Add("Text", bs, "JetID");
                txtUName.DataBindings.Add("Text", bs, "Name");
                txtUSpeed.DataBindings.Add("Text", bs, "TopSpeed");
                txtUFuel.DataBindings.Add("Text", bs, "FuelTankSize");
                txtUAltitude.DataBindings.Add("Text", bs, "MaximumAltitude");
                txtWeapons.DataBindings.Add("Text", bs, "TypeOfWeapons");
                txtUInvent.DataBindings.Add("Text", bs, "InventoryCapacity");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        } //displays the update group box, allows you to choose a jet to update and fills in the textboxes

        private void btnSim_Click(object sender, EventArgs e)
        {
            try
            {
                frmSimulation frs = new frmSimulation();
                frs.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        } //shows the simulation form

        private void btnUP_Click(object sender, EventArgs e)
        {
            try
            {
                Jets jn = new Jets();
                jn.JetID = txtIDU.Text;
                jn.Name = txtUName.Text;
                jn.TopSpeed = txtUSpeed.Text;
                jn.MaximumAltitude = txtUAltitude.Text;
                jn.TypeOfWeapons = txtWeapons.Text;
                jn.InventoryCapacity = txtUInvent.Text;
                jn.FuelTankSize = txtUFuel.Text;

                DataHandler dh = new DataHandler();
                dh.Update(jn);

                DialogResult up= MessageBox.Show("Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (up==DialogResult.OK)
                {
                    gbUpdate.Visible = false;
                    txtIDU.DataBindings.Clear();
                    txtUName.DataBindings.Clear();
                    txtUAltitude.DataBindings.Clear();
                    txtUFuel.DataBindings.Clear();
                    txtUInvent.DataBindings.Clear();
                    txtWeapons.DataBindings.Clear();
                    txtUSpeed.DataBindings.Clear();
                }

                List<Jets> jet = new List<Jets>();
                Bind(jet);
                this.Size = new Size(929, 415);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        } //Updates the relevant jet's information in the database using the info supplied in the textboxes

        private void frmJet_Load(object sender, EventArgs e)
        {
            try
            {
                this.Size = new Size(929, 415);
                List<Jets> jet = new List<Jets>();
                Bind(jet);
                gbSearch.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        } //FormLoad

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Exits the Application

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var current = (Jets)bs.Current;
                DataHandler dh = new DataHandler();
                dh.DeleteJet(current.Name);
                List<Jets> jd = new List<Jets>();
                jd = DataHandler.GetJet();
                Bind(jd);
                MessageBox.Show("Removed", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        } //Deletes/removes the jet chosen from the datagridview and database

        private void btnSS_Click(object sender, EventArgs e)
        {
            try
            {
                List<Jets> jd = new List<Jets>();
                jd = DataHandler.GetJet();
                foreach (var item in jd)
                {
                    if (item.Name == txtName.Text)
                    {
                        DialogResult dr = MessageBox.Show("ID: " + item.JetID + "\nName: " + item.Name + "\nTop Speed: " + item.TopSpeed + " m/s", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            txtName.Clear();
                            this.Size = new Size(929, 415);
                            gbSearch.Visible = false;
                            gbUpdate.Visible = false;
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        } //Searches through the list of Jets from the database and displays information for the one you searched for

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbSearch.Visible = true;
            gbUpdate.Visible = false;
            this.Size = new Size(934, 635);
        } //makes the search groupbox visible
    }
}
