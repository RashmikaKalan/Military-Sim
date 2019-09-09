namespace ProjectA2
{
    partial class frmSimulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimulation));
            this.gbObstacles = new System.Windows.Forms.GroupBox();
            this.cbEC = new System.Windows.Forms.CheckBox();
            this.cbOut = new System.Windows.Forms.CheckBox();
            this.txtXC = new System.Windows.Forms.TextBox();
            this.txtYC = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblYC = new System.Windows.Forms.Label();
            this.lblXC = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pbOut5 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRec = new System.Windows.Forms.GroupBox();
            this.txtMA = new System.Windows.Forms.TextBox();
            this.lblMA = new System.Windows.Forms.Label();
            this.txtChosen = new System.Windows.Forms.TextBox();
            this.lblChosen = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvRec = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.gbProgress = new System.Windows.Forms.GroupBox();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtJet = new System.Windows.Forms.TextBox();
            this.pbDamage = new System.Windows.Forms.ProgressBar();
            this.pbFuel = new System.Windows.Forms.ProgressBar();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblJet = new System.Windows.Forms.Label();
            this.tmrPath = new System.Windows.Forms.Timer(this.components);
            this.pnlBack = new System.Windows.Forms.Panel();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.pbMountain = new System.Windows.Forms.PictureBox();
            this.pbTrench = new System.Windows.Forms.PictureBox();
            this.pbJet = new System.Windows.Forms.PictureBox();
            this.pbEC5 = new System.Windows.Forms.PictureBox();
            this.pbEC4 = new System.Windows.Forms.PictureBox();
            this.pbEC3 = new System.Windows.Forms.PictureBox();
            this.pbEC2 = new System.Windows.Forms.PictureBox();
            this.pbEC1 = new System.Windows.Forms.PictureBox();
            this.pbOut4 = new System.Windows.Forms.PictureBox();
            this.pbOut3 = new System.Windows.Forms.PictureBox();
            this.pbOut2 = new System.Windows.Forms.PictureBox();
            this.pbOut1 = new System.Windows.Forms.PictureBox();
            this.pbWall = new System.Windows.Forms.PictureBox();
            this.gbObstacles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut5)).BeginInit();
            this.gbRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRec)).BeginInit();
            this.gbProgress.SuspendLayout();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).BeginInit();
            this.SuspendLayout();
            // 
            // gbObstacles
            // 
            this.gbObstacles.Controls.Add(this.cbEC);
            this.gbObstacles.Controls.Add(this.cbOut);
            this.gbObstacles.Controls.Add(this.txtXC);
            this.gbObstacles.Controls.Add(this.txtYC);
            this.gbObstacles.Controls.Add(this.btnAdd);
            this.gbObstacles.Controls.Add(this.lblYC);
            this.gbObstacles.Controls.Add(this.lblXC);
            this.gbObstacles.Controls.Add(this.lblType);
            this.gbObstacles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbObstacles.Location = new System.Drawing.Point(12, 12);
            this.gbObstacles.Name = "gbObstacles";
            this.gbObstacles.Size = new System.Drawing.Size(369, 178);
            this.gbObstacles.TabIndex = 1;
            this.gbObstacles.TabStop = false;
            this.gbObstacles.Text = "Add Obstacles";
            // 
            // cbEC
            // 
            this.cbEC.AutoSize = true;
            this.cbEC.Location = new System.Drawing.Point(228, 36);
            this.cbEC.Name = "cbEC";
            this.cbEC.Size = new System.Drawing.Size(117, 22);
            this.cbEC.TabIndex = 7;
            this.cbEC.Text = "Enemy Camp";
            this.cbEC.UseVisualStyleBackColor = true;
            // 
            // cbOut
            // 
            this.cbOut.AutoSize = true;
            this.cbOut.Location = new System.Drawing.Point(112, 36);
            this.cbOut.Name = "cbOut";
            this.cbOut.Size = new System.Drawing.Size(80, 22);
            this.cbOut.TabIndex = 6;
            this.cbOut.Text = "Outpost";
            this.cbOut.UseVisualStyleBackColor = true;
            // 
            // txtXC
            // 
            this.txtXC.Location = new System.Drawing.Point(112, 89);
            this.txtXC.Name = "txtXC";
            this.txtXC.Size = new System.Drawing.Size(100, 24);
            this.txtXC.TabIndex = 5;
            // 
            // txtYC
            // 
            this.txtYC.Location = new System.Drawing.Point(112, 141);
            this.txtYC.Name = "txtYC";
            this.txtYC.Size = new System.Drawing.Size(100, 24);
            this.txtYC.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(273, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblYC
            // 
            this.lblYC.AutoSize = true;
            this.lblYC.Location = new System.Drawing.Point(7, 141);
            this.lblYC.Name = "lblYC";
            this.lblYC.Size = new System.Drawing.Size(98, 18);
            this.lblYC.TabIndex = 2;
            this.lblYC.Text = "Y Coordinate:";
            // 
            // lblXC
            // 
            this.lblXC.AutoSize = true;
            this.lblXC.Location = new System.Drawing.Point(7, 89);
            this.lblXC.Name = "lblXC";
            this.lblXC.Size = new System.Drawing.Size(99, 18);
            this.lblXC.TabIndex = 1;
            this.lblXC.Text = "X Coordinate:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 37);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // pbOut5
            // 
            this.pbOut5.Image = ((System.Drawing.Image)(resources.GetObject("pbOut5.Image")));
            this.pbOut5.Location = new System.Drawing.Point(477, 12);
            this.pbOut5.Name = "pbOut5";
            this.pbOut5.Size = new System.Drawing.Size(33, 31);
            this.pbOut5.TabIndex = 10;
            this.pbOut5.TabStop = false;
            this.pbOut5.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(413, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 46);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbRec
            // 
            this.gbRec.Controls.Add(this.txtMA);
            this.gbRec.Controls.Add(this.lblMA);
            this.gbRec.Controls.Add(this.txtChosen);
            this.gbRec.Controls.Add(this.lblChosen);
            this.gbRec.Controls.Add(this.btnStart);
            this.gbRec.Controls.Add(this.dgvRec);
            this.gbRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRec.Location = new System.Drawing.Point(12, 196);
            this.gbRec.Name = "gbRec";
            this.gbRec.Size = new System.Drawing.Size(548, 307);
            this.gbRec.TabIndex = 13;
            this.gbRec.TabStop = false;
            this.gbRec.Text = "Recommended Aircraft";
            // 
            // txtMA
            // 
            this.txtMA.Location = new System.Drawing.Point(136, 267);
            this.txtMA.Name = "txtMA";
            this.txtMA.Size = new System.Drawing.Size(233, 24);
            this.txtMA.TabIndex = 20;
            // 
            // lblMA
            // 
            this.lblMA.AutoSize = true;
            this.lblMA.Location = new System.Drawing.Point(6, 270);
            this.lblMA.Name = "lblMA";
            this.lblMA.Size = new System.Drawing.Size(124, 18);
            this.lblMA.TabIndex = 19;
            this.lblMA.Text = "Maximum Altitude";
            // 
            // txtChosen
            // 
            this.txtChosen.Location = new System.Drawing.Point(136, 222);
            this.txtChosen.Name = "txtChosen";
            this.txtChosen.Size = new System.Drawing.Size(233, 24);
            this.txtChosen.TabIndex = 18;
            // 
            // lblChosen
            // 
            this.lblChosen.AutoSize = true;
            this.lblChosen.Location = new System.Drawing.Point(6, 225);
            this.lblChosen.Name = "lblChosen";
            this.lblChosen.Size = new System.Drawing.Size(114, 18);
            this.lblChosen.TabIndex = 17;
            this.lblChosen.Text = "Chosen Aircraft:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(425, 257);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 44);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvRec
            // 
            this.dgvRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRec.Location = new System.Drawing.Point(6, 23);
            this.dgvRec.Name = "dgvRec";
            this.dgvRec.Size = new System.Drawing.Size(536, 190);
            this.dgvRec.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(425, 64);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(129, 93);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Show Recommended Aircraft";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gbProgress
            // 
            this.gbProgress.Controls.Add(this.lblKG);
            this.gbProgress.Controls.Add(this.lblM);
            this.gbProgress.Controls.Add(this.txtInventory);
            this.gbProgress.Controls.Add(this.lblInventory);
            this.gbProgress.Controls.Add(this.txtAltitude);
            this.gbProgress.Controls.Add(this.txtJet);
            this.gbProgress.Controls.Add(this.pbDamage);
            this.gbProgress.Controls.Add(this.pbFuel);
            this.gbProgress.Controls.Add(this.lblAltitude);
            this.gbProgress.Controls.Add(this.btnPrint);
            this.gbProgress.Controls.Add(this.lblFuel);
            this.gbProgress.Controls.Add(this.lblDamage);
            this.gbProgress.Controls.Add(this.btnClose);
            this.gbProgress.Controls.Add(this.lblJet);
            this.gbProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProgress.Location = new System.Drawing.Point(12, 196);
            this.gbProgress.Name = "gbProgress";
            this.gbProgress.Size = new System.Drawing.Size(548, 301);
            this.gbProgress.TabIndex = 18;
            this.gbProgress.TabStop = false;
            this.gbProgress.Text = "Progress";
            this.gbProgress.Visible = false;
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(375, 199);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(33, 24);
            this.lblKG.TabIndex = 23;
            this.lblKG.Text = "Kg";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(375, 158);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(26, 24);
            this.lblM.TabIndex = 22;
            this.lblM.Text = "m";
            // 
            // txtInventory
            // 
            this.txtInventory.Location = new System.Drawing.Point(228, 199);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(141, 29);
            this.txtInventory.TabIndex = 21;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(17, 199);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(187, 24);
            this.lblInventory.TabIndex = 20;
            this.lblInventory.Text = "Remaining Inventory:";
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(228, 155);
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(141, 29);
            this.txtAltitude.TabIndex = 19;
            // 
            // txtJet
            // 
            this.txtJet.Location = new System.Drawing.Point(155, 33);
            this.txtJet.Name = "txtJet";
            this.txtJet.Size = new System.Drawing.Size(250, 29);
            this.txtJet.TabIndex = 18;
            // 
            // pbDamage
            // 
            this.pbDamage.Location = new System.Drawing.Point(155, 76);
            this.pbDamage.Name = "pbDamage";
            this.pbDamage.Size = new System.Drawing.Size(250, 23);
            this.pbDamage.TabIndex = 17;
            // 
            // pbFuel
            // 
            this.pbFuel.Location = new System.Drawing.Point(155, 114);
            this.pbFuel.Name = "pbFuel";
            this.pbFuel.Size = new System.Drawing.Size(250, 23);
            this.pbFuel.TabIndex = 4;
            this.pbFuel.Value = 100;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(17, 162);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(77, 24);
            this.lblAltitude.TabIndex = 3;
            this.lblAltitude.Text = "Altitude:";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(59, 255);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 44);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print Report\r\n";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(17, 119);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(53, 24);
            this.lblFuel.TabIndex = 2;
            this.lblFuel.Text = "Fuel:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(17, 76);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(91, 24);
            this.lblDamage.TabIndex = 1;
            this.lblDamage.Text = "Damage: ";
            // 
            // lblJet
            // 
            this.lblJet.AutoSize = true;
            this.lblJet.Location = new System.Drawing.Point(17, 36);
            this.lblJet.Name = "lblJet";
            this.lblJet.Size = new System.Drawing.Size(88, 24);
            this.lblJet.TabIndex = 0;
            this.lblJet.Text = "Jet Used:";
            // 
            // tmrPath
            // 
            this.tmrPath.Tick += new System.EventHandler(this.tmrPath_Tick);
            // 
            // pnlBack
            // 
            this.pnlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBack.BackgroundImage")));
            this.pnlBack.Controls.Add(this.pbWall);
            this.pnlBack.Controls.Add(this.pbEC5);
            this.pnlBack.Controls.Add(this.pbEC4);
            this.pnlBack.Controls.Add(this.pbEC3);
            this.pnlBack.Controls.Add(this.pbEC2);
            this.pnlBack.Controls.Add(this.pbEC1);
            this.pnlBack.Controls.Add(this.pbOut4);
            this.pnlBack.Controls.Add(this.pbOut3);
            this.pnlBack.Controls.Add(this.pbOut2);
            this.pnlBack.Controls.Add(this.pbOut1);
            this.pnlBack.Controls.Add(this.pbJet);
            this.pnlBack.Controls.Add(this.pbTrench);
            this.pnlBack.Controls.Add(this.pbMountain);
            this.pnlBack.Controls.Add(this.pbMap);
            this.pnlBack.Location = new System.Drawing.Point(581, 12);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(476, 502);
            this.pnlBack.TabIndex = 19;
            // 
            // pbMap
            // 
            this.pbMap.Image = ((System.Drawing.Image)(resources.GetObject("pbMap.Image")));
            this.pbMap.Location = new System.Drawing.Point(0, 0);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(457, 508);
            this.pbMap.TabIndex = 2;
            this.pbMap.TabStop = false;
            // 
            // pbMountain
            // 
            this.pbMountain.BackColor = System.Drawing.Color.Transparent;
            this.pbMountain.Image = ((System.Drawing.Image)(resources.GetObject("pbMountain.Image")));
            this.pbMountain.Location = new System.Drawing.Point(39, 95);
            this.pbMountain.Name = "pbMountain";
            this.pbMountain.Size = new System.Drawing.Size(179, 105);
            this.pbMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMountain.TabIndex = 33;
            this.pbMountain.TabStop = false;
            // 
            // pbTrench
            // 
            this.pbTrench.BackColor = System.Drawing.Color.Transparent;
            this.pbTrench.Image = ((System.Drawing.Image)(resources.GetObject("pbTrench.Image")));
            this.pbTrench.Location = new System.Drawing.Point(193, 194);
            this.pbTrench.Name = "pbTrench";
            this.pbTrench.Size = new System.Drawing.Size(142, 127);
            this.pbTrench.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTrench.TabIndex = 34;
            this.pbTrench.TabStop = false;
            // 
            // pbJet
            // 
            this.pbJet.BackColor = System.Drawing.Color.Transparent;
            this.pbJet.Image = ((System.Drawing.Image)(resources.GetObject("pbJet.Image")));
            this.pbJet.Location = new System.Drawing.Point(3, 109);
            this.pbJet.Name = "pbJet";
            this.pbJet.Size = new System.Drawing.Size(109, 105);
            this.pbJet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbJet.TabIndex = 35;
            this.pbJet.TabStop = false;
            // 
            // pbEC5
            // 
            this.pbEC5.Image = ((System.Drawing.Image)(resources.GetObject("pbEC5.Image")));
            this.pbEC5.Location = new System.Drawing.Point(372, 332);
            this.pbEC5.Name = "pbEC5";
            this.pbEC5.Size = new System.Drawing.Size(34, 34);
            this.pbEC5.TabIndex = 44;
            this.pbEC5.TabStop = false;
            this.pbEC5.Visible = false;
            // 
            // pbEC4
            // 
            this.pbEC4.Image = ((System.Drawing.Image)(resources.GetObject("pbEC4.Image")));
            this.pbEC4.Location = new System.Drawing.Point(234, 295);
            this.pbEC4.Name = "pbEC4";
            this.pbEC4.Size = new System.Drawing.Size(33, 31);
            this.pbEC4.TabIndex = 43;
            this.pbEC4.TabStop = false;
            this.pbEC4.Visible = false;
            // 
            // pbEC3
            // 
            this.pbEC3.Image = ((System.Drawing.Image)(resources.GetObject("pbEC3.Image")));
            this.pbEC3.Location = new System.Drawing.Point(118, 259);
            this.pbEC3.Name = "pbEC3";
            this.pbEC3.Size = new System.Drawing.Size(34, 34);
            this.pbEC3.TabIndex = 42;
            this.pbEC3.TabStop = false;
            this.pbEC3.Visible = false;
            // 
            // pbEC2
            // 
            this.pbEC2.Image = ((System.Drawing.Image)(resources.GetObject("pbEC2.Image")));
            this.pbEC2.Location = new System.Drawing.Point(63, 235);
            this.pbEC2.Name = "pbEC2";
            this.pbEC2.Size = new System.Drawing.Size(33, 31);
            this.pbEC2.TabIndex = 41;
            this.pbEC2.TabStop = false;
            this.pbEC2.Visible = false;
            // 
            // pbEC1
            // 
            this.pbEC1.Image = ((System.Drawing.Image)(resources.GetObject("pbEC1.Image")));
            this.pbEC1.Location = new System.Drawing.Point(346, 207);
            this.pbEC1.Name = "pbEC1";
            this.pbEC1.Size = new System.Drawing.Size(33, 31);
            this.pbEC1.TabIndex = 40;
            this.pbEC1.TabStop = false;
            this.pbEC1.Visible = false;
            // 
            // pbOut4
            // 
            this.pbOut4.Image = ((System.Drawing.Image)(resources.GetObject("pbOut4.Image")));
            this.pbOut4.Location = new System.Drawing.Point(169, 257);
            this.pbOut4.Name = "pbOut4";
            this.pbOut4.Size = new System.Drawing.Size(33, 31);
            this.pbOut4.TabIndex = 39;
            this.pbOut4.TabStop = false;
            this.pbOut4.Visible = false;
            // 
            // pbOut3
            // 
            this.pbOut3.Image = ((System.Drawing.Image)(resources.GetObject("pbOut3.Image")));
            this.pbOut3.Location = new System.Drawing.Point(267, 137);
            this.pbOut3.Name = "pbOut3";
            this.pbOut3.Size = new System.Drawing.Size(33, 31);
            this.pbOut3.TabIndex = 38;
            this.pbOut3.TabStop = false;
            this.pbOut3.Visible = false;
            // 
            // pbOut2
            // 
            this.pbOut2.Image = ((System.Drawing.Image)(resources.GetObject("pbOut2.Image")));
            this.pbOut2.Location = new System.Drawing.Point(249, 220);
            this.pbOut2.Name = "pbOut2";
            this.pbOut2.Size = new System.Drawing.Size(33, 31);
            this.pbOut2.TabIndex = 37;
            this.pbOut2.TabStop = false;
            this.pbOut2.Visible = false;
            // 
            // pbOut1
            // 
            this.pbOut1.Image = ((System.Drawing.Image)(resources.GetObject("pbOut1.Image")));
            this.pbOut1.Location = new System.Drawing.Point(118, 207);
            this.pbOut1.Name = "pbOut1";
            this.pbOut1.Size = new System.Drawing.Size(33, 31);
            this.pbOut1.TabIndex = 36;
            this.pbOut1.TabStop = false;
            this.pbOut1.Visible = false;
            // 
            // pbWall
            // 
            this.pbWall.BackColor = System.Drawing.Color.Transparent;
            this.pbWall.Image = ((System.Drawing.Image)(resources.GetObject("pbWall.Image")));
            this.pbWall.Location = new System.Drawing.Point(320, 320);
            this.pbWall.Name = "pbWall";
            this.pbWall.Size = new System.Drawing.Size(111, 88);
            this.pbWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWall.TabIndex = 45;
            this.pbWall.TabStop = false;
            // 
            // frmSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 515);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.gbProgress);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbRec);
            this.Controls.Add(this.pbOut5);
            this.Controls.Add(this.gbObstacles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSimulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.frmSimulation_Load);
            this.gbObstacles.ResumeLayout(false);
            this.gbObstacles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut5)).EndInit();
            this.gbRec.ResumeLayout(false);
            this.gbRec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRec)).EndInit();
            this.gbProgress.ResumeLayout(false);
            this.gbProgress.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbObstacles;
        private System.Windows.Forms.CheckBox cbEC;
        private System.Windows.Forms.CheckBox cbOut;
        private System.Windows.Forms.TextBox txtXC;
        private System.Windows.Forms.TextBox txtYC;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblYC;
        private System.Windows.Forms.Label lblXC;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.PictureBox pbOut5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbRec;
        private System.Windows.Forms.DataGridView dgvRec;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtChosen;
        private System.Windows.Forms.Label lblChosen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbProgress;
        private System.Windows.Forms.TextBox txtAltitude;
        private System.Windows.Forms.TextBox txtJet;
        private System.Windows.Forms.ProgressBar pbDamage;
        private System.Windows.Forms.ProgressBar pbFuel;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblJet;
        private System.Windows.Forms.TextBox txtMA;
        private System.Windows.Forms.Label lblMA;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Timer tmrPath;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.PictureBox pbTrench;
        private System.Windows.Forms.PictureBox pbMountain;
        private System.Windows.Forms.PictureBox pbJet;
        private System.Windows.Forms.PictureBox pbEC5;
        private System.Windows.Forms.PictureBox pbEC4;
        private System.Windows.Forms.PictureBox pbEC3;
        private System.Windows.Forms.PictureBox pbEC2;
        private System.Windows.Forms.PictureBox pbEC1;
        private System.Windows.Forms.PictureBox pbOut4;
        private System.Windows.Forms.PictureBox pbOut3;
        private System.Windows.Forms.PictureBox pbOut2;
        private System.Windows.Forms.PictureBox pbOut1;
        private System.Windows.Forms.PictureBox pbWall;
    }
}