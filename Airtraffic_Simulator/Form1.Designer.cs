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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFastForward = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNameLocation = new System.Windows.Forms.Panel();
            this.lbPlaneLocation = new System.Windows.Forms.Label();
            this.lbPlaneName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
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
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbCargoWeight = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelDrawing = new Airtraffic_Simulator.DrawingPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNameLocation.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(201, 20);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(209, 22);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "SkyHighSim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(515, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Airports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(659, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Airplanes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btFastForward);
            this.panel1.Controls.Add(this.btStop);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 60);
            this.panel1.TabIndex = 4;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(419, 16);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 34);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1193, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btFastForward
            // 
            this.btFastForward.BackColor = System.Drawing.Color.Khaki;
            this.btFastForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btFastForward.Location = new System.Drawing.Point(1003, 11);
            this.btFastForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFastForward.Name = "btFastForward";
            this.btFastForward.Size = new System.Drawing.Size(155, 39);
            this.btFastForward.TabIndex = 7;
            this.btFastForward.Text = "FAST FORWARD";
            this.btFastForward.UseVisualStyleBackColor = false;
            this.btFastForward.Click += new System.EventHandler(this.btFastForward_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btStop.Location = new System.Drawing.Point(911, 11);
            this.btStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(87, 39);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "STOP";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btStart.Location = new System.Drawing.Point(819, 11);
            this.btStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(87, 39);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(629, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "|";
            // 
            // panelNameLocation
            // 
            this.panelNameLocation.BackColor = System.Drawing.Color.SteelBlue;
            this.panelNameLocation.Controls.Add(this.lbPlaneLocation);
            this.panelNameLocation.Controls.Add(this.lbPlaneName);
            this.panelNameLocation.Controls.Add(this.label6);
            this.panelNameLocation.Controls.Add(this.label5);
            this.panelNameLocation.Location = new System.Drawing.Point(12, 78);
            this.panelNameLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNameLocation.Name = "panelNameLocation";
            this.panelNameLocation.Size = new System.Drawing.Size(251, 121);
            this.panelNameLocation.TabIndex = 5;
            // 
            // lbPlaneLocation
            // 
            this.lbPlaneLocation.AutoSize = true;
            this.lbPlaneLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbPlaneLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPlaneLocation.Location = new System.Drawing.Point(115, 66);
            this.lbPlaneLocation.MaximumSize = new System.Drawing.Size(127, 0);
            this.lbPlaneLocation.Name = "lbPlaneLocation";
            this.lbPlaneLocation.Size = new System.Drawing.Size(97, 40);
            this.lbPlaneLocation.TabIndex = 8;
            this.lbPlaneLocation.Text = "Location of \r\nthe plane";
            this.lbPlaneLocation.Visible = false;
            // 
            // lbPlaneName
            // 
            this.lbPlaneName.AutoSize = true;
            this.lbPlaneName.Enabled = false;
            this.lbPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbPlaneName.ForeColor = System.Drawing.Color.White;
            this.lbPlaneName.Location = new System.Drawing.Point(115, 14);
            this.lbPlaneName.Name = "lbPlaneName";
            this.lbPlaneName.Size = new System.Drawing.Size(77, 40);
            this.lbPlaneName.TabIndex = 6;
            this.lbPlaneName.Text = "Name of \r\nthe plane";
            this.lbPlaneName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(5, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
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
            this.panelDetails.Location = new System.Drawing.Point(12, 206);
            this.panelDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(251, 139);
            this.panelDetails.TabIndex = 6;
            // 
            // lbFuel
            // 
            this.lbFuel.AutoSize = true;
            this.lbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbFuel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFuel.Location = new System.Drawing.Point(143, 107);
            this.lbFuel.Name = "lbFuel";
            this.lbFuel.Size = new System.Drawing.Size(36, 20);
            this.lbFuel.TabIndex = 10;
            this.lbFuel.Text = "fuel";
            this.lbFuel.Visible = false;
            // 
            // lbFlightNumber
            // 
            this.lbFlightNumber.AutoSize = true;
            this.lbFlightNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbFlightNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightNumber.Location = new System.Drawing.Point(147, 84);
            this.lbFlightNumber.Name = "lbFlightNumber";
            this.lbFlightNumber.Size = new System.Drawing.Size(63, 20);
            this.lbFlightNumber.TabIndex = 10;
            this.lbFlightNumber.Text = "flightNr";
            this.lbFlightNumber.Visible = false;
            // 
            // lbCapacity
            // 
            this.lbCapacity.AutoSize = true;
            this.lbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbCapacity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCapacity.Location = new System.Drawing.Point(151, 20);
            this.lbCapacity.Name = "lbCapacity";
            this.lbCapacity.Size = new System.Drawing.Size(41, 20);
            this.lbCapacity.TabIndex = 10;
            this.lbCapacity.Text = "total";
            this.lbCapacity.Visible = false;
            // 
            // lbNrOfPsngs
            // 
            this.lbNrOfPsngs.AutoSize = true;
            this.lbNrOfPsngs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbNrOfPsngs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNrOfPsngs.Location = new System.Drawing.Point(151, 40);
            this.lbNrOfPsngs.Name = "lbNrOfPsngs";
            this.lbNrOfPsngs.Size = new System.Drawing.Size(80, 20);
            this.lbNrOfPsngs.TabIndex = 9;
            this.lbNrOfPsngs.Text = "nrOfPsng";
            this.lbNrOfPsngs.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(16, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Fuel             :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(16, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Flight number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Capacity       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(15, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Passengers   :";
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTime.Controls.Add(this.lbArrivalTime);
            this.panelTime.Controls.Add(this.lbDepartureTime);
            this.panelTime.Controls.Add(this.label11);
            this.panelTime.Controls.Add(this.label15);
            this.panelTime.Location = new System.Drawing.Point(9, 352);
            this.panelTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(251, 100);
            this.panelTime.TabIndex = 7;
            this.panelTime.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTime_Paint);
            // 
            // lbArrivalTime
            // 
            this.lbArrivalTime.AutoSize = true;
            this.lbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbArrivalTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbArrivalTime.Location = new System.Drawing.Point(132, 54);
            this.lbArrivalTime.MaximumSize = new System.Drawing.Size(127, 0);
            this.lbArrivalTime.Name = "lbArrivalTime";
            this.lbArrivalTime.Size = new System.Drawing.Size(67, 20);
            this.lbArrivalTime.TabIndex = 13;
            this.lbArrivalTime.Text = "arrTime";
            this.lbArrivalTime.Visible = false;
            // 
            // lbDepartureTime
            // 
            this.lbDepartureTime.AutoSize = true;
            this.lbDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbDepartureTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDepartureTime.Location = new System.Drawing.Point(133, 9);
            this.lbDepartureTime.MaximumSize = new System.Drawing.Size(127, 0);
            this.lbDepartureTime.Name = "lbDepartureTime";
            this.lbDepartureTime.Size = new System.Drawing.Size(73, 20);
            this.lbDepartureTime.TabIndex = 11;
            this.lbDepartureTime.Text = "depTime";
            this.lbDepartureTime.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(5, 54);
            this.label11.MaximumSize = new System.Drawing.Size(100, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "Arrival time:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(4, 9);
            this.label15.MaximumSize = new System.Drawing.Size(113, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 40);
            this.label15.TabIndex = 11;
            this.label15.Text = "Departure time:";
            // 
            // btAdvanced
            // 
            this.btAdvanced.BackColor = System.Drawing.Color.Orange;
            this.btAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btAdvanced.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAdvanced.Location = new System.Drawing.Point(9, 458);
            this.btAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdvanced.Name = "btAdvanced";
            this.btAdvanced.Size = new System.Drawing.Size(251, 39);
            this.btAdvanced.TabIndex = 8;
            this.btAdvanced.Text = "Advanced options";
            this.btAdvanced.UseVisualStyleBackColor = false;
            this.btAdvanced.Click += new System.EventHandler(this.btAdvanced_Click);
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.BackColor = System.Drawing.Color.SteelBlue;
            this.panelAdvanced.Controls.Add(this.label14);
            this.panelAdvanced.Controls.Add(this.label13);
            this.panelAdvanced.Controls.Add(this.label12);
            this.panelAdvanced.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelAdvanced.Location = new System.Drawing.Point(9, 501);
            this.panelAdvanced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(251, 128);
            this.panelAdvanced.TabIndex = 9;
            this.panelAdvanced.Visible = false;
            this.panelAdvanced.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdvanced_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(5, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Change destination:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(5, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Change fuel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(5, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Change speed:";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btUpdate.Location = new System.Drawing.Point(9, 745);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(251, 57);
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
            // lbCargoWeight
            // 
            this.lbCargoWeight.AutoSize = true;
            this.lbCargoWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbCargoWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCargoWeight.Location = new System.Drawing.Point(151, 60);
            this.lbCargoWeight.Name = "lbCargoWeight";
            this.lbCargoWeight.Size = new System.Drawing.Size(103, 20);
            this.lbCargoWeight.TabIndex = 12;
            this.lbCargoWeight.Text = "cargoWeight";
            this.lbCargoWeight.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(13, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Cargo weight  :";
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackgroundImage = global::Airtraffic_Simulator.Properties.Resources.europemap;
            this.panelDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDrawing.Location = new System.Drawing.Point(269, 74);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(1419, 764);
            this.panelDrawing.TabIndex = 12;
            this.panelDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrawing_Paint);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 828);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.panelAdvanced);
            this.Controls.Add(this.btAdvanced);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelNameLocation);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1701, 875);
            this.MinimumSize = new System.Drawing.Size(1357, 875);
            this.Name = "Form1";
            this.Text = "SkyHighSim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNameLocation.ResumeLayout(false);
            this.panelNameLocation.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelAdvanced.ResumeLayout(false);
            this.panelAdvanced.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelNameLocation;
        private System.Windows.Forms.Label lbPlaneLocation;
        private System.Windows.Forms.Label lbPlaneName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btFastForward;
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
    }
}

