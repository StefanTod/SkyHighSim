namespace Airtraffic_Simulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cbFrom = new System.Windows.Forms.CheckBox();
            this.cbTo = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lbBack2 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.panelNameLocation = new System.Windows.Forms.Panel();
            this.lbOrigin = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lbPlaneName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lbCargoWeight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbFuel = new System.Windows.Forms.Label();
            this.lbFlightNumber = new System.Windows.Forms.Label();
            this.lbCapacity = new System.Windows.Forms.Label();
            this.lbNrOfPsngs = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTime = new System.Windows.Forms.Panel();
            this.lbArrivalTime = new System.Windows.Forms.Label();
            this.lbDepartureTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btAdvanced = new System.Windows.Forms.Button();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.cbChangeDestination = new System.Windows.Forms.ComboBox();
            this.nUDChangeSpeed = new System.Windows.Forms.NumericUpDown();
            this.nUDChangeFuel = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tc_create = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_auto_dest = new System.Windows.Forms.ComboBox();
            this.cb_auto_orig = new System.Windows.Forms.ComboBox();
            this.btn_create_plane = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.lb_load = new System.Windows.Forms.Label();
            this.lb_destination = new System.Windows.Forms.Label();
            this.lb_origin = new System.Windows.Forms.Label();
            this.label_flight = new System.Windows.Forms.Label();
            this.nud_fuel = new System.Windows.Forms.NumericUpDown();
            this.nud_capacity = new System.Windows.Forms.NumericUpDown();
            this.lb_fuel = new System.Windows.Forms.Label();
            this.lb_capacity = new System.Windows.Forms.Label();
            this.lb_speed = new System.Windows.Forms.Label();
            this.nud_speed = new System.Windows.Forms.NumericUpDown();
            this.nud_blk_amount = new System.Windows.Forms.NumericUpDown();
            this.lb_blk_amount = new System.Windows.Forms.Label();
            this.cb_bulkCreate = new System.Windows.Forms.CheckBox();
            this.rb_cargo = new System.Windows.Forms.RadioButton();
            this.rb_passanger = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCreateAirport = new System.Windows.Forms.Button();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.numUpDownNrOfLanes = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numUpDownAirportCapacity = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_problem_create = new System.Windows.Forms.Button();
            this.lb_prob_Time_desc = new System.Windows.Forms.Label();
            this.nud_prob_min = new System.Windows.Forms.NumericUpDown();
            this.nud_prob_hour = new System.Windows.Forms.NumericUpDown();
            this.nud_prob_day = new System.Windows.Forms.NumericUpDown();
            this.tb_problem_desc = new System.Windows.Forms.TextBox();
            this.lb_problem_desc_name = new System.Windows.Forms.Label();
            this.cb_problem_airport = new System.Windows.Forms.ComboBox();
            this.lb_problem_select_name = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelDrawing = new Airtraffic_Simulator.DrawingPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelNameLocation.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDChangeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDChangeFuel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tc_create.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_blk_amount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNrOfLanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAirportCapacity)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "SkyHighSim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(234, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flights";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.cbFrom);
            this.panel1.Controls.Add(this.cbTo);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.lbBack2);
            this.panel1.Controls.Add(this.cbSearch);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 49);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(816, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Simulation speed:";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Azure;
            this.trackBar1.Location = new System.Drawing.Point(974, 3);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(269, 45);
            this.trackBar1.TabIndex = 41;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.AutoSize = true;
            this.cbFrom.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbFrom.Location = new System.Drawing.Point(383, 16);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(52, 17);
            this.cbFrom.TabIndex = 40;
            this.cbFrom.Text = "From:";
            this.cbFrom.UseVisualStyleBackColor = true;
            this.cbFrom.CheckedChanged += new System.EventHandler(this.cbFrom_CheckedChanged);
            // 
            // cbTo
            // 
            this.cbTo.AutoSize = true;
            this.cbTo.ForeColor = System.Drawing.Color.Cornsilk;
            this.cbTo.Location = new System.Drawing.Point(335, 16);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(42, 17);
            this.cbTo.TabIndex = 39;
            this.cbTo.Text = "To:";
            this.cbTo.UseVisualStyleBackColor = true;
            this.cbTo.CheckedChanged += new System.EventHandler(this.cbTo_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(440, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 24);
            this.lblSearch.TabIndex = 38;
            // 
            // lbBack2
            // 
            this.lbBack2.AutoSize = true;
            this.lbBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbBack2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBack2.Location = new System.Drawing.Point(188, 9);
            this.lbBack2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBack2.Name = "lbBack2";
            this.lbBack2.Size = new System.Drawing.Size(25, 26);
            this.lbBack2.TabIndex = 37;
            this.lbBack2.Text = "<";
            this.lbBack2.Visible = false;
            this.lbBack2.Click += new System.EventHandler(this.lbBack2_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(441, 14);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(165, 21);
            this.cbSearch.TabIndex = 35;
            this.cbSearch.Text = "Airport Name";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(612, 10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(67, 28);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btStop.Location = new System.Drawing.Point(753, 10);
            this.btStop.Margin = new System.Windows.Forms.Padding(2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(65, 32);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btStart.Location = new System.Drawing.Point(684, 10);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(65, 32);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panelNameLocation
            // 
            this.panelNameLocation.BackColor = System.Drawing.Color.SteelBlue;
            this.panelNameLocation.Controls.Add(this.lbOrigin);
            this.panelNameLocation.Controls.Add(this.label20);
            this.panelNameLocation.Controls.Add(this.label3);
            this.panelNameLocation.Controls.Add(this.lblDestination);
            this.panelNameLocation.Controls.Add(this.lbPlaneName);
            this.panelNameLocation.Controls.Add(this.label5);
            this.panelNameLocation.Location = new System.Drawing.Point(9, 63);
            this.panelNameLocation.Margin = new System.Windows.Forms.Padding(2);
            this.panelNameLocation.Name = "panelNameLocation";
            this.panelNameLocation.Size = new System.Drawing.Size(188, 98);
            this.panelNameLocation.TabIndex = 5;
            // 
            // lbOrigin
            // 
            this.lbOrigin.AutoSize = true;
            this.lbOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbOrigin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrigin.Location = new System.Drawing.Point(71, 46);
            this.lbOrigin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrigin.MaximumSize = new System.Drawing.Size(95, 0);
            this.lbOrigin.Name = "lbOrigin";
            this.lbOrigin.Size = new System.Drawing.Size(46, 17);
            this.lbOrigin.TabIndex = 11;
            this.lbOrigin.Text = "Origin";
            this.lbOrigin.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(11, 46);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 10;
            this.label20.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "To:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblDestination.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDestination.Location = new System.Drawing.Point(71, 65);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestination.MaximumSize = new System.Drawing.Size(95, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 17);
            this.lblDestination.TabIndex = 8;
            this.lblDestination.Text = "Destination";
            this.lblDestination.Visible = false;
            // 
            // lbPlaneName
            // 
            this.lbPlaneName.AutoSize = true;
            this.lbPlaneName.Enabled = false;
            this.lbPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbPlaneName.ForeColor = System.Drawing.Color.White;
            this.lbPlaneName.Location = new System.Drawing.Point(86, 11);
            this.lbPlaneName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlaneName.Name = "lbPlaneName";
            this.lbPlaneName.Size = new System.Drawing.Size(67, 34);
            this.lbPlaneName.TabIndex = 6;
            this.lbPlaneName.Text = "Name of \r\nthe plane";
            this.lbPlaneName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name:";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDetails.Controls.Add(this.lbCargoWeight);
            this.panelDetails.Controls.Add(this.label17);
            this.panelDetails.Controls.Add(this.lbFuel);
            this.panelDetails.Controls.Add(this.lbFlightNumber);
            this.panelDetails.Controls.Add(this.lbCapacity);
            this.panelDetails.Controls.Add(this.lbNrOfPsngs);
            this.panelDetails.Controls.Add(this.label10);
            this.panelDetails.Controls.Add(this.label9);
            this.panelDetails.Controls.Add(this.label8);
            this.panelDetails.Controls.Add(this.label7);
            this.panelDetails.Location = new System.Drawing.Point(9, 167);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(188, 113);
            this.panelDetails.TabIndex = 6;
            // 
            // lbCargoWeight
            // 
            this.lbCargoWeight.AutoSize = true;
            this.lbCargoWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbCargoWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCargoWeight.Location = new System.Drawing.Point(116, 49);
            this.lbCargoWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCargoWeight.Name = "lbCargoWeight";
            this.lbCargoWeight.Size = new System.Drawing.Size(88, 17);
            this.lbCargoWeight.TabIndex = 12;
            this.lbCargoWeight.Text = "cargoWeight";
            this.lbCargoWeight.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(11, 48);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Cargo weight :";
            // 
            // lbFuel
            // 
            this.lbFuel.AutoSize = true;
            this.lbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbFuel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFuel.Location = new System.Drawing.Point(119, 87);
            this.lbFuel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFuel.Name = "lbFuel";
            this.lbFuel.Size = new System.Drawing.Size(31, 17);
            this.lbFuel.TabIndex = 10;
            this.lbFuel.Text = "fuel";
            this.lbFuel.Visible = false;
            // 
            // lbFlightNumber
            // 
            this.lbFlightNumber.AutoSize = true;
            this.lbFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbFlightNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightNumber.Location = new System.Drawing.Point(119, 68);
            this.lbFlightNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFlightNumber.Name = "lbFlightNumber";
            this.lbFlightNumber.Size = new System.Drawing.Size(53, 17);
            this.lbFlightNumber.TabIndex = 10;
            this.lbFlightNumber.Text = "flightNr";
            this.lbFlightNumber.Visible = false;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbCapacity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCapacity.Location = new System.Drawing.Point(117, 16);
            this.lbCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(35, 17);
            this.lbCapacity.TabIndex = 10;
            this.lbCapacity.Text = "total";
            this.lbCapacity.Visible = false;
            // 
            // lbNrOfPsngs
            // 
            this.lbNrOfPsngs.AutoSize = true;
            this.lbNrOfPsngs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbNrOfPsngs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNrOfPsngs.Location = new System.Drawing.Point(116, 32);
            this.lbNrOfPsngs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNrOfPsngs.Name = "lbNrOfPsngs";
            this.lbNrOfPsngs.Size = new System.Drawing.Size(68, 17);
            this.lbNrOfPsngs.TabIndex = 9;
            this.lbNrOfPsngs.Text = "nrOfPsng";
            this.lbNrOfPsngs.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(11, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fuel              :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(11, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Flight number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capacity       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Passengers  :";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTime.Controls.Add(this.lbArrivalTime);
            this.panelTime.Controls.Add(this.lbDepartureTime);
            this.panelTime.Controls.Add(this.label11);
            this.panelTime.Controls.Add(this.label15);
            this.panelTime.Location = new System.Drawing.Point(7, 286);
            this.panelTime.Margin = new System.Windows.Forms.Padding(2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(188, 81);
            this.panelTime.TabIndex = 7;
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.AutoSize = true;
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbArrivalTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbArrivalTime.Location = new System.Drawing.Point(99, 44);
            this.lbArrivalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArrivalTime.MaximumSize = new System.Drawing.Size(95, 0);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(57, 17);
            this.lbArrivalTime.TabIndex = 13;
            this.lbArrivalTime.Text = "arrTime";
            this.lbArrivalTime.Visible = false;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.AutoSize = true;
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbDepartureTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDepartureTime.Location = new System.Drawing.Point(100, 7);
            this.lbDepartureTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepartureTime.MaximumSize = new System.Drawing.Size(95, 0);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(63, 17);
            this.lbDepartureTime.TabIndex = 11;
            this.lbDepartureTime.Text = "depTime";
            this.lbDepartureTime.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(4, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.MaximumSize = new System.Drawing.Size(75, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 34);
            this.label11.TabIndex = 12;
            this.label11.Text = "Arrival time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(3, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.MaximumSize = new System.Drawing.Size(85, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 34);
            this.label15.TabIndex = 11;
            this.label15.Text = "Departure time:";
            // 
            // btAdvanced
            // 
            this.btAdvanced.BackColor = System.Drawing.Color.Orange;
            this.btAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btAdvanced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdvanced.Location = new System.Drawing.Point(7, 372);
            this.btAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.btAdvanced.Name = "btAdvanced";
            this.btAdvanced.Size = new System.Drawing.Size(188, 32);
            this.btAdvanced.TabIndex = 8;
            this.btAdvanced.Text = "Advanced options";
            this.btAdvanced.UseVisualStyleBackColor = false;
            this.btAdvanced.Visible = false;
            this.btAdvanced.Click += new System.EventHandler(this.btAdvanced_Click);
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.BackColor = System.Drawing.Color.SteelBlue;
            this.panelAdvanced.Controls.Add(this.cbChangeDestination);
            this.panelAdvanced.Controls.Add(this.nUDChangeSpeed);
            this.panelAdvanced.Controls.Add(this.nUDChangeFuel);
            this.panelAdvanced.Controls.Add(this.label14);
            this.panelAdvanced.Controls.Add(this.label13);
            this.panelAdvanced.Controls.Add(this.label12);
            this.panelAdvanced.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAdvanced.Location = new System.Drawing.Point(7, 376);
            this.panelAdvanced.Margin = new System.Windows.Forms.Padding(2);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(188, 134);
            this.panelAdvanced.TabIndex = 9;
            this.panelAdvanced.Visible = false;
            // 
            // cbChangeDestination
            // 
            this.cbChangeDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChangeDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbChangeDestination.FormattingEnabled = true;
            this.cbChangeDestination.Location = new System.Drawing.Point(4, 108);
            this.cbChangeDestination.Name = "cbChangeDestination";
            this.cbChangeDestination.Size = new System.Drawing.Size(178, 21);
            this.cbChangeDestination.TabIndex = 22;
            // 
            // nUDChangeSpeed
            // 
            this.nUDChangeSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDChangeSpeed.Location = new System.Drawing.Point(5, 26);
            this.nUDChangeSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDChangeSpeed.Name = "nUDChangeSpeed";
            this.nUDChangeSpeed.Size = new System.Drawing.Size(177, 20);
            this.nUDChangeSpeed.TabIndex = 21;
            // 
            // nUDChangeFuel
            // 
            this.nUDChangeFuel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDChangeFuel.Location = new System.Drawing.Point(6, 69);
            this.nUDChangeFuel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDChangeFuel.Name = "nUDChangeFuel";
            this.nUDChangeFuel.Size = new System.Drawing.Size(177, 20);
            this.nUDChangeFuel.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(6, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Change destination:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(2, 49);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Change fuel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(4, 6);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Change speed:";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUpdate.Location = new System.Drawing.Point(5, 514);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(188, 46);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Visible = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 655);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airplaneToolStripMenuItem,
            this.airportToolStripMenuItem,
            this.problemToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.customizeToolStripMenuItem.Text = "&Create";
            // 
            // airplaneToolStripMenuItem
            // 
            this.airplaneToolStripMenuItem.Name = "airplaneToolStripMenuItem";
            this.airplaneToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.airplaneToolStripMenuItem.Text = "Airplane";
            this.airplaneToolStripMenuItem.Click += new System.EventHandler(this.airplaneToolStripMenuItem_Click);
            // 
            // airportToolStripMenuItem
            // 
            this.airportToolStripMenuItem.Name = "airportToolStripMenuItem";
            this.airportToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.airportToolStripMenuItem.Text = "Airport";
            this.airportToolStripMenuItem.Click += new System.EventHandler(this.airportToolStripMenuItem_Click);
            // 
            // problemToolStripMenuItem
            // 
            this.problemToolStripMenuItem.Name = "problemToolStripMenuItem";
            this.problemToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.problemToolStripMenuItem.Text = "Problem";
            this.problemToolStripMenuItem.Click += new System.EventHandler(this.problemToolStripMenuItem_Click);
            // 
            // tc_create
            // 
            this.tc_create.Controls.Add(this.tabPage1);
            this.tc_create.Controls.Add(this.tabPage2);
            this.tc_create.Controls.Add(this.tabPage3);
            this.tc_create.Location = new System.Drawing.Point(0, 373);
            this.tc_create.Name = "tc_create";
            this.tc_create.SelectedIndex = 0;
            this.tc_create.Size = new System.Drawing.Size(200, 245);
            this.tc_create.TabIndex = 0;
            this.tc_create.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_auto_dest);
            this.tabPage1.Controls.Add(this.cb_auto_orig);
            this.tabPage1.Controls.Add(this.btn_create_plane);
            this.tabPage1.Controls.Add(this.numericUpDown4);
            this.tabPage1.Controls.Add(this.lb_load);
            this.tabPage1.Controls.Add(this.lb_destination);
            this.tabPage1.Controls.Add(this.lb_origin);
            this.tabPage1.Controls.Add(this.label_flight);
            this.tabPage1.Controls.Add(this.nud_fuel);
            this.tabPage1.Controls.Add(this.nud_capacity);
            this.tabPage1.Controls.Add(this.lb_fuel);
            this.tabPage1.Controls.Add(this.lb_capacity);
            this.tabPage1.Controls.Add(this.lb_speed);
            this.tabPage1.Controls.Add(this.nud_speed);
            this.tabPage1.Controls.Add(this.nud_blk_amount);
            this.tabPage1.Controls.Add(this.lb_blk_amount);
            this.tabPage1.Controls.Add(this.cb_bulkCreate);
            this.tabPage1.Controls.Add(this.rb_cargo);
            this.tabPage1.Controls.Add(this.rb_passanger);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Airplane";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_auto_dest
            // 
            this.cb_auto_dest.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_auto_dest.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_auto_dest.FormattingEnabled = true;
            this.cb_auto_dest.Location = new System.Drawing.Point(68, 163);
            this.cb_auto_dest.Name = "cb_auto_dest";
            this.cb_auto_dest.Size = new System.Drawing.Size(121, 21);
            this.cb_auto_dest.TabIndex = 34;
            this.cb_auto_dest.Visible = false;
            this.cb_auto_dest.TextChanged += new System.EventHandler(this.cb_auto_dest_TextChanged_1);
            // 
            // cb_auto_orig
            // 
            this.cb_auto_orig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_auto_orig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_auto_orig.FormattingEnabled = true;
            this.cb_auto_orig.Location = new System.Drawing.Point(68, 139);
            this.cb_auto_orig.Name = "cb_auto_orig";
            this.cb_auto_orig.Size = new System.Drawing.Size(121, 21);
            this.cb_auto_orig.TabIndex = 33;
            this.cb_auto_orig.Visible = false;
            this.cb_auto_orig.SelectedIndexChanged += new System.EventHandler(this.cb_auto_orig_SelectedIndexChanged);
            // 
            // btn_create_plane
            // 
            this.btn_create_plane.Location = new System.Drawing.Point(94, 190);
            this.btn_create_plane.Name = "btn_create_plane";
            this.btn_create_plane.Size = new System.Drawing.Size(92, 23);
            this.btn_create_plane.TabIndex = 32;
            this.btn_create_plane.Text = "Create Airplane";
            this.btn_create_plane.UseVisualStyleBackColor = true;
            this.btn_create_plane.Visible = false;
            this.btn_create_plane.Click += new System.EventHandler(this.btn_create_plane_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(44, 190);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown4.TabIndex = 31;
            this.numericUpDown4.Visible = false;
            // 
            // lb_load
            // 
            this.lb_load.AutoSize = true;
            this.lb_load.Location = new System.Drawing.Point(7, 192);
            this.lb_load.Name = "lb_load";
            this.lb_load.Size = new System.Drawing.Size(31, 13);
            this.lb_load.TabIndex = 30;
            this.lb_load.Text = "Load";
            this.lb_load.Visible = false;
            // 
            // lb_destination
            // 
            this.lb_destination.AutoSize = true;
            this.lb_destination.Location = new System.Drawing.Point(6, 169);
            this.lb_destination.Name = "lb_destination";
            this.lb_destination.Size = new System.Drawing.Size(60, 13);
            this.lb_destination.TabIndex = 28;
            this.lb_destination.Text = "Destination";
            this.lb_destination.Visible = false;
            // 
            // lb_origin
            // 
            this.lb_origin.AutoSize = true;
            this.lb_origin.Location = new System.Drawing.Point(6, 147);
            this.lb_origin.Name = "lb_origin";
            this.lb_origin.Size = new System.Drawing.Size(37, 13);
            this.lb_origin.TabIndex = 27;
            this.lb_origin.Text = "Origin ";
            this.lb_origin.Visible = false;
            // 
            // label_flight
            // 
            this.label_flight.AutoSize = true;
            this.label_flight.Location = new System.Drawing.Point(0, 129);
            this.label_flight.Name = "label_flight";
            this.label_flight.Size = new System.Drawing.Size(56, 13);
            this.label_flight.TabIndex = 26;
            this.label_flight.Text = "Flight Info:";
            this.label_flight.Visible = false;
            // 
            // nud_fuel
            // 
            this.nud_fuel.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_fuel.Location = new System.Drawing.Point(104, 104);
            this.nud_fuel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_fuel.Name = "nud_fuel";
            this.nud_fuel.Size = new System.Drawing.Size(73, 20);
            this.nud_fuel.TabIndex = 25;
            this.nud_fuel.Visible = false;
            this.nud_fuel.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // nud_capacity
            // 
            this.nud_capacity.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_capacity.Location = new System.Drawing.Point(104, 58);
            this.nud_capacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_capacity.Name = "nud_capacity";
            this.nud_capacity.Size = new System.Drawing.Size(73, 20);
            this.nud_capacity.TabIndex = 24;
            this.nud_capacity.Visible = false;
            // 
            // lb_fuel
            // 
            this.lb_fuel.AutoSize = true;
            this.lb_fuel.Location = new System.Drawing.Point(8, 106);
            this.lb_fuel.Name = "lb_fuel";
            this.lb_fuel.Size = new System.Drawing.Size(68, 13);
            this.lb_fuel.TabIndex = 23;
            this.lb_fuel.Text = "Airplane Fuel";
            this.lb_fuel.Visible = false;
            // 
            // lb_capacity
            // 
            this.lb_capacity.AutoSize = true;
            this.lb_capacity.Location = new System.Drawing.Point(9, 60);
            this.lb_capacity.Name = "lb_capacity";
            this.lb_capacity.Size = new System.Drawing.Size(89, 13);
            this.lb_capacity.TabIndex = 22;
            this.lb_capacity.Text = "Airplane Capacity";
            this.lb_capacity.Visible = false;
            // 
            // lb_speed
            // 
            this.lb_speed.AutoSize = true;
            this.lb_speed.Location = new System.Drawing.Point(9, 83);
            this.lb_speed.Name = "lb_speed";
            this.lb_speed.Size = new System.Drawing.Size(79, 13);
            this.lb_speed.TabIndex = 21;
            this.lb_speed.Text = "Airplane Speed";
            this.lb_speed.Visible = false;
            // 
            // nud_speed
            // 
            this.nud_speed.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_speed.Location = new System.Drawing.Point(104, 81);
            this.nud_speed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_speed.Name = "nud_speed";
            this.nud_speed.Size = new System.Drawing.Size(73, 20);
            this.nud_speed.TabIndex = 20;
            this.nud_speed.Visible = false;
            // 
            // nud_blk_amount
            // 
            this.nud_blk_amount.Location = new System.Drawing.Point(140, 32);
            this.nud_blk_amount.Name = "nud_blk_amount";
            this.nud_blk_amount.Size = new System.Drawing.Size(48, 20);
            this.nud_blk_amount.TabIndex = 19;
            this.nud_blk_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_blk_amount.Visible = false;
            // 
            // lb_blk_amount
            // 
            this.lb_blk_amount.AutoSize = true;
            this.lb_blk_amount.Location = new System.Drawing.Point(90, 34);
            this.lb_blk_amount.Name = "lb_blk_amount";
            this.lb_blk_amount.Size = new System.Drawing.Size(49, 13);
            this.lb_blk_amount.TabIndex = 18;
            this.lb_blk_amount.Text = "Amount: ";
            this.lb_blk_amount.Visible = false;
            // 
            // cb_bulkCreate
            // 
            this.cb_bulkCreate.AutoSize = true;
            this.cb_bulkCreate.Location = new System.Drawing.Point(5, 33);
            this.cb_bulkCreate.Name = "cb_bulkCreate";
            this.cb_bulkCreate.Size = new System.Drawing.Size(86, 17);
            this.cb_bulkCreate.TabIndex = 17;
            this.cb_bulkCreate.Text = "Bulk Create |";
            this.cb_bulkCreate.UseVisualStyleBackColor = true;
            this.cb_bulkCreate.Visible = false;
            this.cb_bulkCreate.CheckedChanged += new System.EventHandler(this.cb_bulkCreate_CheckedChanged);
            // 
            // rb_cargo
            // 
            this.rb_cargo.AutoSize = true;
            this.rb_cargo.Location = new System.Drawing.Point(86, 6);
            this.rb_cargo.Name = "rb_cargo";
            this.rb_cargo.Size = new System.Drawing.Size(53, 17);
            this.rb_cargo.TabIndex = 1;
            this.rb_cargo.Text = "Cargo";
            this.rb_cargo.UseVisualStyleBackColor = true;
            this.rb_cargo.CheckedChanged += new System.EventHandler(this.rb_cargo_CheckedChanged);
            // 
            // rb_passanger
            // 
            this.rb_passanger.AutoSize = true;
            this.rb_passanger.Location = new System.Drawing.Point(5, 6);
            this.rb_passanger.Name = "rb_passanger";
            this.rb_passanger.Size = new System.Drawing.Size(75, 17);
            this.rb_passanger.TabIndex = 0;
            this.rb_passanger.Text = "Passanger";
            this.rb_passanger.UseVisualStyleBackColor = true;
            this.rb_passanger.CheckedChanged += new System.EventHandler(this.rb_passanger_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbLocation);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btCreateAirport);
            this.tabPage2.Controls.Add(this.tbAirportName);
            this.tabPage2.Controls.Add(this.numUpDownNrOfLanes);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.numUpDownAirportCapacity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Airport";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(95, 84);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(89, 20);
            this.tbLocation.TabIndex = 37;
            this.tbLocation.Text = "Click on the map";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Airport Location";
            // 
            // btCreateAirport
            // 
            this.btCreateAirport.Location = new System.Drawing.Point(91, 110);
            this.btCreateAirport.Name = "btCreateAirport";
            this.btCreateAirport.Size = new System.Drawing.Size(92, 23);
            this.btCreateAirport.TabIndex = 35;
            this.btCreateAirport.Text = "Create Airport";
            this.btCreateAirport.UseVisualStyleBackColor = true;
            this.btCreateAirport.Click += new System.EventHandler(this.btCreateAirport_Click);
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(83, 8);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(100, 20);
            this.tbAirportName.TabIndex = 34;
            // 
            // numUpDownNrOfLanes
            // 
            this.numUpDownNrOfLanes.Location = new System.Drawing.Point(111, 58);
            this.numUpDownNrOfLanes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownNrOfLanes.Name = "numUpDownNrOfLanes";
            this.numUpDownNrOfLanes.Size = new System.Drawing.Size(73, 20);
            this.numUpDownNrOfLanes.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Number of lanes";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Airport Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Airport Capacity";
            // 
            // numUpDownAirportCapacity
            // 
            this.numUpDownAirportCapacity.Location = new System.Drawing.Point(111, 32);
            this.numUpDownAirportCapacity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownAirportCapacity.Name = "numUpDownAirportCapacity";
            this.numUpDownAirportCapacity.Size = new System.Drawing.Size(73, 20);
            this.numUpDownAirportCapacity.TabIndex = 26;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_problem_create);
            this.tabPage3.Controls.Add(this.lb_prob_Time_desc);
            this.tabPage3.Controls.Add(this.nud_prob_min);
            this.tabPage3.Controls.Add(this.nud_prob_hour);
            this.tabPage3.Controls.Add(this.nud_prob_day);
            this.tabPage3.Controls.Add(this.tb_problem_desc);
            this.tabPage3.Controls.Add(this.lb_problem_desc_name);
            this.tabPage3.Controls.Add(this.cb_problem_airport);
            this.tabPage3.Controls.Add(this.lb_problem_select_name);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(192, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Problem";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_problem_create
            // 
            this.btn_problem_create.Location = new System.Drawing.Point(6, 184);
            this.btn_problem_create.Name = "btn_problem_create";
            this.btn_problem_create.Size = new System.Drawing.Size(99, 23);
            this.btn_problem_create.TabIndex = 8;
            this.btn_problem_create.Text = "Create Problem";
            this.btn_problem_create.UseVisualStyleBackColor = true;
            this.btn_problem_create.Click += new System.EventHandler(this.btn_problem_create_Click);
            // 
            // lb_prob_Time_desc
            // 
            this.lb_prob_Time_desc.AutoSize = true;
            this.lb_prob_Time_desc.Location = new System.Drawing.Point(4, 110);
            this.lb_prob_Time_desc.Name = "lb_prob_Time_desc";
            this.lb_prob_Time_desc.Size = new System.Drawing.Size(150, 13);
            this.lb_prob_Time_desc.TabIndex = 7;
            this.lb_prob_Time_desc.Text = "Days          Hours        Minutes";
            // 
            // nud_prob_min
            // 
            this.nud_prob_min.Location = new System.Drawing.Point(115, 129);
            this.nud_prob_min.Name = "nud_prob_min";
            this.nud_prob_min.Size = new System.Drawing.Size(48, 20);
            this.nud_prob_min.TabIndex = 6;
            // 
            // nud_prob_hour
            // 
            this.nud_prob_hour.Location = new System.Drawing.Point(61, 129);
            this.nud_prob_hour.Name = "nud_prob_hour";
            this.nud_prob_hour.Size = new System.Drawing.Size(48, 20);
            this.nud_prob_hour.TabIndex = 5;
            // 
            // nud_prob_day
            // 
            this.nud_prob_day.Location = new System.Drawing.Point(7, 129);
            this.nud_prob_day.Name = "nud_prob_day";
            this.nud_prob_day.Size = new System.Drawing.Size(48, 20);
            this.nud_prob_day.TabIndex = 4;
            // 
            // tb_problem_desc
            // 
            this.tb_problem_desc.Location = new System.Drawing.Point(6, 73);
            this.tb_problem_desc.Name = "tb_problem_desc";
            this.tb_problem_desc.Size = new System.Drawing.Size(179, 20);
            this.tb_problem_desc.TabIndex = 3;
            // 
            // lb_problem_desc_name
            // 
            this.lb_problem_desc_name.AutoSize = true;
            this.lb_problem_desc_name.Location = new System.Drawing.Point(6, 53);
            this.lb_problem_desc_name.Name = "lb_problem_desc_name";
            this.lb_problem_desc_name.Size = new System.Drawing.Size(92, 13);
            this.lb_problem_desc_name.TabIndex = 2;
            this.lb_problem_desc_name.Text = "Provide a problem";
            // 
            // cb_problem_airport
            // 
            this.cb_problem_airport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_problem_airport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cb_problem_airport.FormattingEnabled = true;
            this.cb_problem_airport.Location = new System.Drawing.Point(5, 22);
            this.cb_problem_airport.Name = "cb_problem_airport";
            this.cb_problem_airport.Size = new System.Drawing.Size(121, 21);
            this.cb_problem_airport.TabIndex = 1;
            // 
            // lb_problem_select_name
            // 
            this.lb_problem_select_name.AutoSize = true;
            this.lb_problem_select_name.Location = new System.Drawing.Point(4, 6);
            this.lb_problem_select_name.Name = "lb_problem_select_name";
            this.lb_problem_select_name.Size = new System.Drawing.Size(70, 13);
            this.lb_problem_select_name.TabIndex = 0;
            this.lb_problem_select_name.Text = "Select Airport";
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackgroundImage = global::Airtraffic_Simulator.Properties.Resources.europemap;
            this.panelDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDrawing.Location = new System.Drawing.Point(202, 60);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(1064, 621);
            this.panelDrawing.TabIndex = 12;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 679);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelNameLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tc_create);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.btAdvanced);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimumSize = new System.Drawing.Size(1280, 718);
            this.Name = "Form1";
            this.Text = "SkyHighSim";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelNameLocation.ResumeLayout(false);
            this.panelNameLocation.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelAdvanced.ResumeLayout(false);
            this.panelAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDChangeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDChangeFuel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tc_create.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_capacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_blk_amount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNrOfLanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAirportCapacity)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prob_day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelNameLocation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lbPlaneName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbFuel;
        private System.Windows.Forms.Label lbFlightNumber;
        private System.Windows.Forms.Label lbCapacity;
        private System.Windows.Forms.Label lbNrOfPsngs;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbArrivalTime;
        private System.Windows.Forms.Label lbDepartureTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btAdvanced;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Timer timer;
        private DrawingPanel panelDrawing;
        private System.Windows.Forms.Label lbCargoWeight;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nUDChangeSpeed;
        private System.Windows.Forms.NumericUpDown nUDChangeFuel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.TabControl tc_create;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RadioButton rb_cargo;
        private System.Windows.Forms.RadioButton rb_passanger;
        private System.Windows.Forms.Label lb_destination;
        private System.Windows.Forms.Label lb_origin;
        private System.Windows.Forms.Label label_flight;
        private System.Windows.Forms.NumericUpDown nud_fuel;
        private System.Windows.Forms.NumericUpDown nud_capacity;
        private System.Windows.Forms.Label lb_fuel;
        private System.Windows.Forms.Label lb_capacity;
        private System.Windows.Forms.Label lb_speed;
        private System.Windows.Forms.NumericUpDown nud_speed;
        private System.Windows.Forms.NumericUpDown nud_blk_amount;
        private System.Windows.Forms.Label lb_blk_amount;
        private System.Windows.Forms.CheckBox cb_bulkCreate;
        private System.Windows.Forms.Button btn_create_plane;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label lb_load;
        private System.Windows.Forms.ComboBox cbChangeDestination;
        private System.Windows.Forms.ComboBox cb_auto_dest;
        private System.Windows.Forms.ComboBox cb_auto_orig;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lbBack2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripMenuItem airplaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problemToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cb_problem_airport;
        private System.Windows.Forms.Label lb_problem_select_name;
        private System.Windows.Forms.Label lb_prob_Time_desc;
        private System.Windows.Forms.NumericUpDown nud_prob_min;
        private System.Windows.Forms.NumericUpDown nud_prob_hour;
        private System.Windows.Forms.NumericUpDown nud_prob_day;
        private System.Windows.Forms.TextBox tb_problem_desc;
        private System.Windows.Forms.Label lb_problem_desc_name;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_problem_create;
        private System.Windows.Forms.CheckBox cbFrom;
        private System.Windows.Forms.CheckBox cbTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numUpDownAirportCapacity;
        private System.Windows.Forms.NumericUpDown numUpDownNrOfLanes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.Button btCreateAirport;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
    }
}

