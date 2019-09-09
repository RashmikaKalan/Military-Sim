using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ProjectA2
{
    public partial class frmSimulation : Form
    {
        public frmSimulation()
        {
            InitializeComponent();
        }

        #region Double
        private void button1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        int outpost = 0; //counter for outposts encountered
        int enemy = 0; //counter for enemy camps encountered
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtXC.Text);
                int y = int.Parse(txtYC.Text);
                CustomExceptionCo.Check(x, y); //checks that values entered are on the map

                if (cbOut.Checked == true)
                {
                    if (pbOut1.Visible == false)
                    {
                        pbOut1.Visible = true;
                        pbOut1.Location = new Point(x, y);
                        outpost++;
                    }
                    else if (pbOut2.Visible == false)
                    {
                        pbOut2.Visible = true;
                        pbOut2.Location = new Point(x, y);
                        outpost++;
                    }
                    else if (pbOut3.Visible == false)
                    {
                        pbOut3.Visible = true;
                        pbOut3.Location = new Point(x, y);
                        outpost++;
                    }
                    else if (pbOut4.Visible == false)
                    {
                        pbOut4.Visible = true;
                        pbOut4.Location = new Point(x, y);
                        outpost++;
                    }
                    else if (pbOut5.Visible == false)
                    {
                        pbOut5.Visible = true;
                        pbOut5.Location = new Point(x, y);
                        outpost++;
                    }
                    else
                    {
                        MessageBox.Show("No more Outposts available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (cbEC.Checked == true)
                {
                    if (pbEC1.Visible == false)
                    {
                        pbEC1.Visible = true;
                        pbEC1.Location = new Point(x, y);
                        enemy++;
                    }
                    else if (pbEC2.Visible == false)
                    {
                        pbEC2.Visible = true;
                        pbEC2.Location = new Point(x, y);
                        enemy++;
                    }
                    else if (pbEC3.Visible == false)
                    {
                        pbEC3.Visible = true;
                        pbEC3.Location = new Point(x, y);
                        enemy++;
                    }
                    else if (pbEC4.Visible == false)
                    {
                        pbEC4.Visible = true;
                        pbEC4.Location = new Point(x, y);
                        enemy++;
                    }
                    else if (pbEC5.Visible == false)
                    {
                        pbEC5.Visible = true;
                        pbEC5.Location = new Point(x, y);
                        enemy++;
                    }
                    else
                    {
                        MessageBox.Show("No more Enemy Camps available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                DialogResult r = MessageBox.Show("Would you like to add another obstacle?", "Obstacles", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    txtXC.Clear();
                    txtYC.Clear();
                    cbEC.Checked = false;
                    cbOut.Checked = false;
                }
                else
                {
                    txtXC.Clear();
                    txtYC.Clear();
                    cbEC.Checked = false;
                    cbOut.Checked = false;
                    btnAdd.Enabled = false;
                }
            }
            catch (CustomExceptionCo ex)
            {
                DialogResult er=MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (er==DialogResult.OK)
                {
                    txtXC.Clear();
                    txtYC.Clear();
                }
            } //custom exception for if the value/a value is not within the map          
        } //Places obstacles on the map

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double altitude = 0;
           
            if (pbOut1.Visible == true)
            {
                altitude = altitude + 2150;
            }
            else if (pbEC1.Visible==true)
            {
                altitude = altitude + 5000;
            }

            List<Jets> jold = new List<Jets>();
            jold = DataHandler.GetJet();
            List<Jets> jnew = new List<Jets>();

            foreach (var item in jold)
            {
                if (int.Parse(item.MaximumAltitude)>altitude)
                {
                    jnew.Add(item);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = jnew;
            dgvRec.DataSource = bs;
            txtChosen.DataBindings.Add("Text", bs, "Name");
            txtMA.DataBindings.Add("Text", bs, "MaximumAltitude");
        } // Check for the tallest obstacle and displays all the jets that fly above that altitude       

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Jets> jet = new List<Jets>();
            jet = DataHandler.GetJet();
            Jets nj = new Jets();
            double dist = 500000;
            double time = 0;
            double f = 0;
            double ic = 0;
            double damage = 0;
            foreach (var item in jet)
            {
                if (item.Name==txtChosen.Text)
                {
                    nj.JetID = item.JetID;
                    nj.Name = item.Name;
                    nj.TopSpeed = item.TopSpeed;
                    nj.InventoryCapacity = item.InventoryCapacity;
                    nj.MaximumAltitude = item.MaximumAltitude;
                    nj.TypeOfWeapons = item.TypeOfWeapons;
                    nj.FuelTankSize = item.FuelTankSize;
                    time = Math.Round((dist / double.Parse(item.TopSpeed))/60, 2);
                    f = Math.Round(dist / double.Parse(item.FuelTankSize), 2);
                    ic =Math.Round(double.Parse(txtInventory.Text),2);
                    damage = pbDamage.Value;
                    break;
                }
            }
            DataHandler.Report(nj, time, dist, f, ic, outpost, enemy, damage);
            DialogResult re = MessageBox.Show("Printed.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (re==DialogResult.OK)
            {
                frmReport frr = new frmReport();
                frr.Show();
                this.Hide();
            }           
        } //writes the report of the results of the simulation to a textfile
        double max = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            pbJet.Location = new Point(0, 0);
            gbProgress.Visible = true;
            txtJet.Text = txtChosen.Text;
            List<Jets> jet = new List<Jets>();
            jet = DataHandler.GetJet();
            int inventory = 0;
            foreach (var item in jet)
            {
                if (item.Name==txtChosen.Text)
                {
                    inventory =int.Parse(item.InventoryCapacity);
                    max = double.Parse(item.MaximumAltitude);
                    break;
                }
            }
            txtInventory.Text = inventory.ToString();
            tmrPath = new System.Windows.Forms.Timer();
            tmrPath.Tick += new EventHandler(tmrPath_Tick);
            tmrPath.Interval = 900; 
            tmrPath.Start();
        }
        int Altitude = 1000;        

        private void tmrPath_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            this.SuspendLayout();
            pbJet.Location = new Point(pbJet.Location.X + 10, pbJet.Location.Y + 10);
            pbFuel.Value -= 1;
            if (pbJet.Location.X == 20 && pbJet.Location.Y == 20)
            {
                Altitude = Altitude + 1000;
                MessageBox.Show("Mountain Range Ahead! Cruising Altitude Increasing.", "Mountains", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                if (Altitude>max)
                {
                    MessageBox.Show("Jet can not fly at that altitude", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tmrPath.Stop();
                }
                else
                {
                    txtAltitude.Text = Altitude.ToString();
                }
            }
            if (pbJet.Location.X == 160 && pbJet.Location.Y == 160)
            {
                int dam= ran.Next(0, 20);
                pbDamage.Value += (dam);
                DialogResult r= MessageBox.Show("Enemy Trenches! Drop Bombs?", "Enemy Trench", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r==DialogResult.Yes)
                {
                    double ni = double.Parse(txtInventory.Text) * 0.2;
                    txtInventory.Text = ni.ToString();
                }
            }
            if (pbJet.Location.X == 320 && pbJet.Location.Y == 320)
            {
                int dam = ran.Next(0, 40);
                pbDamage.Value += dam;
                DialogResult r = MessageBox.Show("Walls of Enemy Camp! Drop Bombs/shoot?", "Enemy Trench", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    double ni = double.Parse(txtInventory.Text) * 0.4;
                    txtInventory.Text = ni.ToString();
                }
            }
            int width = this.Width;
            if (pbJet.Location.X == 370 && pbJet.Location.Y == 370)
            {
                int dam = ran.Next(0, 50);
                tmrPath.Stop();
                pbDamage.Value += dam;
                MessageBox.Show("Enemy Camp Reached and Destroyed Successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                double ni = double.Parse(txtInventory.Text) * 0.5;
                txtInventory.Text = ni.ToString();
            }
            this.ResumeLayout();
        }

        private void frmSimulation_Load(object sender, EventArgs e)
        {
            pbJet.Location = new Point(579, 12);
        }
    }
}
