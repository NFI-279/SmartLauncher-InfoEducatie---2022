namespace Artemis
{
    partial class ultrasoundsensor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.skeetGroupBox2 = new SkeetFramework.SkeetGroupBox();
            this.skeetGroupBox4 = new SkeetFramework.SkeetGroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.shadowLabel26 = new SkeetFramework.shadowLabel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.shadowLabel25 = new SkeetFramework.shadowLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.ToggleWaterPump = new SkeetFramework.SkeetToggle();
            this.skeetGroupBox3 = new SkeetFramework.SkeetGroupBox();
            this.shadowLabel5 = new SkeetFramework.shadowLabel();
            this.shadowLabel6 = new SkeetFramework.shadowLabel();
            this.shadowLabel22 = new SkeetFramework.shadowLabel();
            this.shadowLabel24 = new SkeetFramework.shadowLabel();
            this.shadowLabel23 = new SkeetFramework.shadowLabel();
            this.shadowLabel21 = new SkeetFramework.shadowLabel();
            this.shadowLabel20 = new SkeetFramework.shadowLabel();
            this.shadowLabel19 = new SkeetFramework.shadowLabel();
            this.shadowLabel17 = new SkeetFramework.shadowLabel();
            this.shadowLabel18 = new SkeetFramework.shadowLabel();
            this.shadowLabel15 = new SkeetFramework.shadowLabel();
            this.shadowLabel16 = new SkeetFramework.shadowLabel();
            this.shadowLabel9 = new SkeetFramework.shadowLabel();
            this.shadowLabel10 = new SkeetFramework.shadowLabel();
            this.shadowLabel13 = new SkeetFramework.shadowLabel();
            this.shadowLabel12 = new SkeetFramework.shadowLabel();
            this.shadowLabel11 = new SkeetFramework.shadowLabel();
            this.shadowLabel7 = new SkeetFramework.shadowLabel();
            this.shadowLabel8 = new SkeetFramework.shadowLabel();
            this.shadowLabel4 = new SkeetFramework.shadowLabel();
            this.shadowLabel3 = new SkeetFramework.shadowLabel();
            this.skeetGroupBox1 = new SkeetFramework.SkeetGroupBox();
            this.labelPortState = new SkeetFramework.shadowLabel();
            this.shadowLabel2 = new SkeetFramework.shadowLabel();
            this.butonDeschiderePort = new SkeetFramework.SkeetToggle();
            this.ComboBoxBaudRate = new SkeetFramework.SkeetComboBox();
            this.shadowLabel1 = new SkeetFramework.shadowLabel();
            this.comboBoxPortList = new SkeetFramework.SkeetComboBox();
            this.shadowLabel14 = new SkeetFramework.shadowLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.skeetGroupBox2.SuspendLayout();
            this.skeetGroupBox4.SuspendLayout();
            this.skeetGroupBox3.SuspendLayout();
            this.skeetGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // skeetGroupBox2
            // 
            this.skeetGroupBox2.Controls.Add(this.skeetGroupBox4);
            this.skeetGroupBox2.Controls.Add(this.ToggleWaterPump);
            this.skeetGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox2.Location = new System.Drawing.Point(346, 339);
            this.skeetGroupBox2.Name = "skeetGroupBox2";
            this.skeetGroupBox2.Size = new System.Drawing.Size(439, 192);
            this.skeetGroupBox2.TabIndex = 57;
            this.skeetGroupBox2.TabStop = false;
            this.skeetGroupBox2.Text = "Information";
            // 
            // skeetGroupBox4
            // 
            this.skeetGroupBox4.Controls.Add(this.button3);
            this.skeetGroupBox4.Controls.Add(this.shadowLabel26);
            this.skeetGroupBox4.Controls.Add(this.textBox4);
            this.skeetGroupBox4.Controls.Add(this.shadowLabel25);
            this.skeetGroupBox4.Controls.Add(this.button1);
            this.skeetGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox4.Location = new System.Drawing.Point(20, 53);
            this.skeetGroupBox4.Name = "skeetGroupBox4";
            this.skeetGroupBox4.Size = new System.Drawing.Size(398, 129);
            this.skeetGroupBox4.TabIndex = 43;
            this.skeetGroupBox4.TabStop = false;
            this.skeetGroupBox4.Text = "Irrigation";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(65)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(284, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 37);
            this.button3.TabIndex = 62;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // shadowLabel26
            // 
            this.shadowLabel26.AutoSize = true;
            this.shadowLabel26.EnableShadow = false;
            this.shadowLabel26.ForeColor = System.Drawing.Color.White;
            this.shadowLabel26.Location = new System.Drawing.Point(314, 36);
            this.shadowLabel26.Name = "shadowLabel26";
            this.shadowLabel26.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel26.ShadowOffset = 1;
            this.shadowLabel26.Size = new System.Drawing.Size(21, 15);
            this.shadowLabel26.TabIndex = 61;
            this.shadowLabel26.Text = "ml";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(104)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Location = new System.Drawing.Point(190, 37);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 14);
            this.textBox4.TabIndex = 60;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress_1);
            // 
            // shadowLabel25
            // 
            this.shadowLabel25.AutoSize = true;
            this.shadowLabel25.EnableShadow = false;
            this.shadowLabel25.ForeColor = System.Drawing.Color.White;
            this.shadowLabel25.Location = new System.Drawing.Point(19, 36);
            this.shadowLabel25.Name = "shadowLabel25";
            this.shadowLabel25.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel25.ShadowOffset = 1;
            this.shadowLabel25.Size = new System.Drawing.Size(152, 15);
            this.shadowLabel25.TabIndex = 59;
            this.shadowLabel25.Text = "Amount of water to irrigate ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(22, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 56;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ToggleWaterPump
            // 
            this.ToggleWaterPump.BackColor = System.Drawing.Color.Transparent;
            this.ToggleWaterPump.Checked = false;
            this.ToggleWaterPump.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ToggleWaterPump.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.ToggleWaterPump.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ToggleWaterPump.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.ToggleWaterPump.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleWaterPump.Location = new System.Drawing.Point(22, 25);
            this.ToggleWaterPump.Name = "ToggleWaterPump";
            this.ToggleWaterPump.Size = new System.Drawing.Size(161, 22);
            this.ToggleWaterPump.TabIndex = 42;
            this.ToggleWaterPump.Text = "Water pump status";
            // 
            // skeetGroupBox3
            // 
            this.skeetGroupBox3.Controls.Add(this.shadowLabel5);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel6);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel22);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel24);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel23);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel21);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel20);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel19);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel17);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel18);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel15);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel16);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel9);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel10);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel13);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel12);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel11);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel7);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel8);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel4);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel3);
            this.skeetGroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skeetGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox3.Location = new System.Drawing.Point(18, 19);
            this.skeetGroupBox3.Name = "skeetGroupBox3";
            this.skeetGroupBox3.Size = new System.Drawing.Size(501, 314);
            this.skeetGroupBox3.TabIndex = 10;
            this.skeetGroupBox3.TabStop = false;
            this.skeetGroupBox3.Text = "Water Tank Data";
            // 
            // shadowLabel5
            // 
            this.shadowLabel5.AutoSize = true;
            this.shadowLabel5.EnableShadow = false;
            this.shadowLabel5.ForeColor = System.Drawing.Color.White;
            this.shadowLabel5.Location = new System.Drawing.Point(457, 274);
            this.shadowLabel5.Name = "shadowLabel5";
            this.shadowLabel5.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel5.ShadowOffset = 1;
            this.shadowLabel5.Size = new System.Drawing.Size(24, 15);
            this.shadowLabel5.TabIndex = 62;
            this.shadowLabel5.Text = "cm";
            // 
            // shadowLabel6
            // 
            this.shadowLabel6.AutoSize = true;
            this.shadowLabel6.EnableShadow = true;
            this.shadowLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel6.Location = new System.Drawing.Point(358, 275);
            this.shadowLabel6.Name = "shadowLabel6";
            this.shadowLabel6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel6.ShadowOffset = 1;
            this.shadowLabel6.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel6.TabIndex = 61;
            this.shadowLabel6.Text = "UNKNOWN";
            // 
            // shadowLabel22
            // 
            this.shadowLabel22.AutoSize = true;
            this.shadowLabel22.EnableShadow = false;
            this.shadowLabel22.ForeColor = System.Drawing.Color.White;
            this.shadowLabel22.Location = new System.Drawing.Point(25, 274);
            this.shadowLabel22.Name = "shadowLabel22";
            this.shadowLabel22.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel22.ShadowOffset = 1;
            this.shadowLabel22.Size = new System.Drawing.Size(115, 15);
            this.shadowLabel22.TabIndex = 60;
            this.shadowLabel22.Text = "Water temperature :";
            // 
            // shadowLabel24
            // 
            this.shadowLabel24.AutoSize = true;
            this.shadowLabel24.EnableShadow = true;
            this.shadowLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel24.Location = new System.Drawing.Point(358, 36);
            this.shadowLabel24.Name = "shadowLabel24";
            this.shadowLabel24.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel24.ShadowOffset = 1;
            this.shadowLabel24.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel24.TabIndex = 59;
            this.shadowLabel24.Text = "UNKNOWN";
            // 
            // shadowLabel23
            // 
            this.shadowLabel23.AutoSize = true;
            this.shadowLabel23.EnableShadow = true;
            this.shadowLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel23.Location = new System.Drawing.Point(358, 76);
            this.shadowLabel23.Name = "shadowLabel23";
            this.shadowLabel23.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel23.ShadowOffset = 1;
            this.shadowLabel23.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel23.TabIndex = 58;
            this.shadowLabel23.Text = "UNKNOWN";
            // 
            // shadowLabel21
            // 
            this.shadowLabel21.AutoSize = true;
            this.shadowLabel21.EnableShadow = true;
            this.shadowLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel21.Location = new System.Drawing.Point(358, 194);
            this.shadowLabel21.Name = "shadowLabel21";
            this.shadowLabel21.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel21.ShadowOffset = 1;
            this.shadowLabel21.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel21.TabIndex = 56;
            this.shadowLabel21.Text = "UNKNOWN";
            // 
            // shadowLabel20
            // 
            this.shadowLabel20.AutoSize = true;
            this.shadowLabel20.EnableShadow = true;
            this.shadowLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel20.Location = new System.Drawing.Point(358, 154);
            this.shadowLabel20.Name = "shadowLabel20";
            this.shadowLabel20.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel20.ShadowOffset = 1;
            this.shadowLabel20.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel20.TabIndex = 55;
            this.shadowLabel20.Text = "UNKNOWN";
            // 
            // shadowLabel19
            // 
            this.shadowLabel19.AutoSize = true;
            this.shadowLabel19.EnableShadow = true;
            this.shadowLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel19.Location = new System.Drawing.Point(358, 114);
            this.shadowLabel19.Name = "shadowLabel19";
            this.shadowLabel19.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel19.ShadowOffset = 1;
            this.shadowLabel19.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel19.TabIndex = 54;
            this.shadowLabel19.Text = "UNKNOWN";
            // 
            // shadowLabel17
            // 
            this.shadowLabel17.AutoSize = true;
            this.shadowLabel17.EnableShadow = false;
            this.shadowLabel17.ForeColor = System.Drawing.Color.White;
            this.shadowLabel17.Location = new System.Drawing.Point(458, 194);
            this.shadowLabel17.Name = "shadowLabel17";
            this.shadowLabel17.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel17.ShadowOffset = 1;
            this.shadowLabel17.Size = new System.Drawing.Size(24, 15);
            this.shadowLabel17.TabIndex = 53;
            this.shadowLabel17.Text = "cm";
            // 
            // shadowLabel18
            // 
            this.shadowLabel18.AutoSize = true;
            this.shadowLabel18.EnableShadow = false;
            this.shadowLabel18.ForeColor = System.Drawing.Color.White;
            this.shadowLabel18.Location = new System.Drawing.Point(25, 194);
            this.shadowLabel18.Name = "shadowLabel18";
            this.shadowLabel18.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel18.ShadowOffset = 1;
            this.shadowLabel18.Size = new System.Drawing.Size(73, 15);
            this.shadowLabel18.TabIndex = 51;
            this.shadowLabel18.Text = "Water depth";
            // 
            // shadowLabel15
            // 
            this.shadowLabel15.AutoSize = true;
            this.shadowLabel15.EnableShadow = false;
            this.shadowLabel15.ForeColor = System.Drawing.Color.White;
            this.shadowLabel15.Location = new System.Drawing.Point(458, 154);
            this.shadowLabel15.Name = "shadowLabel15";
            this.shadowLabel15.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel15.ShadowOffset = 1;
            this.shadowLabel15.Size = new System.Drawing.Size(24, 15);
            this.shadowLabel15.TabIndex = 49;
            this.shadowLabel15.Text = "cm";
            // 
            // shadowLabel16
            // 
            this.shadowLabel16.AutoSize = true;
            this.shadowLabel16.EnableShadow = false;
            this.shadowLabel16.ForeColor = System.Drawing.Color.White;
            this.shadowLabel16.Location = new System.Drawing.Point(25, 154);
            this.shadowLabel16.Name = "shadowLabel16";
            this.shadowLabel16.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel16.ShadowOffset = 1;
            this.shadowLabel16.Size = new System.Drawing.Size(105, 15);
            this.shadowLabel16.TabIndex = 47;
            this.shadowLabel16.Text = "Critical water level";
            // 
            // shadowLabel9
            // 
            this.shadowLabel9.AutoSize = true;
            this.shadowLabel9.EnableShadow = false;
            this.shadowLabel9.ForeColor = System.Drawing.Color.White;
            this.shadowLabel9.Location = new System.Drawing.Point(458, 114);
            this.shadowLabel9.Name = "shadowLabel9";
            this.shadowLabel9.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel9.ShadowOffset = 1;
            this.shadowLabel9.Size = new System.Drawing.Size(21, 15);
            this.shadowLabel9.TabIndex = 45;
            this.shadowLabel9.Text = "ml";
            // 
            // shadowLabel10
            // 
            this.shadowLabel10.AutoSize = true;
            this.shadowLabel10.EnableShadow = false;
            this.shadowLabel10.ForeColor = System.Drawing.Color.White;
            this.shadowLabel10.Location = new System.Drawing.Point(25, 114);
            this.shadowLabel10.Name = "shadowLabel10";
            this.shadowLabel10.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel10.ShadowOffset = 1;
            this.shadowLabel10.Size = new System.Drawing.Size(132, 15);
            this.shadowLabel10.TabIndex = 43;
            this.shadowLabel10.Text = "Available water volume";
            // 
            // shadowLabel13
            // 
            this.shadowLabel13.AutoSize = true;
            this.shadowLabel13.EnableShadow = false;
            this.shadowLabel13.ForeColor = System.Drawing.Color.White;
            this.shadowLabel13.Location = new System.Drawing.Point(457, 234);
            this.shadowLabel13.Name = "shadowLabel13";
            this.shadowLabel13.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel13.ShadowOffset = 1;
            this.shadowLabel13.Size = new System.Drawing.Size(24, 15);
            this.shadowLabel13.TabIndex = 34;
            this.shadowLabel13.Text = "cm";
            // 
            // shadowLabel12
            // 
            this.shadowLabel12.AutoSize = true;
            this.shadowLabel12.EnableShadow = true;
            this.shadowLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel12.Location = new System.Drawing.Point(358, 235);
            this.shadowLabel12.Name = "shadowLabel12";
            this.shadowLabel12.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel12.ShadowOffset = 1;
            this.shadowLabel12.Size = new System.Drawing.Size(71, 15);
            this.shadowLabel12.TabIndex = 33;
            this.shadowLabel12.Text = "UNKNOWN";
            // 
            // shadowLabel11
            // 
            this.shadowLabel11.AutoSize = true;
            this.shadowLabel11.EnableShadow = false;
            this.shadowLabel11.ForeColor = System.Drawing.Color.White;
            this.shadowLabel11.Location = new System.Drawing.Point(25, 234);
            this.shadowLabel11.Name = "shadowLabel11";
            this.shadowLabel11.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel11.ShadowOffset = 1;
            this.shadowLabel11.Size = new System.Drawing.Size(179, 15);
            this.shadowLabel11.TabIndex = 32;
            this.shadowLabel11.Text = "Current distance to water level : ";
            // 
            // shadowLabel7
            // 
            this.shadowLabel7.AutoSize = true;
            this.shadowLabel7.EnableShadow = false;
            this.shadowLabel7.ForeColor = System.Drawing.Color.White;
            this.shadowLabel7.Location = new System.Drawing.Point(459, 74);
            this.shadowLabel7.Name = "shadowLabel7";
            this.shadowLabel7.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel7.ShadowOffset = 1;
            this.shadowLabel7.Size = new System.Drawing.Size(21, 15);
            this.shadowLabel7.TabIndex = 28;
            this.shadowLabel7.Text = "ml";
            // 
            // shadowLabel8
            // 
            this.shadowLabel8.AutoSize = true;
            this.shadowLabel8.EnableShadow = false;
            this.shadowLabel8.ForeColor = System.Drawing.Color.White;
            this.shadowLabel8.Location = new System.Drawing.Point(25, 74);
            this.shadowLabel8.Name = "shadowLabel8";
            this.shadowLabel8.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel8.ShadowOffset = 1;
            this.shadowLabel8.Size = new System.Drawing.Size(179, 15);
            this.shadowLabel8.TabIndex = 26;
            this.shadowLabel8.Text = "Amount of water needed to refill";
            // 
            // shadowLabel4
            // 
            this.shadowLabel4.AutoSize = true;
            this.shadowLabel4.EnableShadow = false;
            this.shadowLabel4.ForeColor = System.Drawing.Color.White;
            this.shadowLabel4.Location = new System.Drawing.Point(459, 34);
            this.shadowLabel4.Name = "shadowLabel4";
            this.shadowLabel4.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel4.ShadowOffset = 1;
            this.shadowLabel4.Size = new System.Drawing.Size(21, 15);
            this.shadowLabel4.TabIndex = 22;
            this.shadowLabel4.Text = "ml";
            // 
            // shadowLabel3
            // 
            this.shadowLabel3.AutoSize = true;
            this.shadowLabel3.EnableShadow = false;
            this.shadowLabel3.ForeColor = System.Drawing.Color.White;
            this.shadowLabel3.Location = new System.Drawing.Point(24, 34);
            this.shadowLabel3.Name = "shadowLabel3";
            this.shadowLabel3.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel3.ShadowOffset = 1;
            this.shadowLabel3.Size = new System.Drawing.Size(81, 15);
            this.shadowLabel3.TabIndex = 20;
            this.shadowLabel3.Text = "Tank capacity";
            // 
            // skeetGroupBox1
            // 
            this.skeetGroupBox1.Controls.Add(this.labelPortState);
            this.skeetGroupBox1.Controls.Add(this.shadowLabel2);
            this.skeetGroupBox1.Controls.Add(this.butonDeschiderePort);
            this.skeetGroupBox1.Controls.Add(this.ComboBoxBaudRate);
            this.skeetGroupBox1.Controls.Add(this.shadowLabel1);
            this.skeetGroupBox1.Controls.Add(this.comboBoxPortList);
            this.skeetGroupBox1.Controls.Add(this.shadowLabel14);
            this.skeetGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox1.Location = new System.Drawing.Point(18, 400);
            this.skeetGroupBox1.Name = "skeetGroupBox1";
            this.skeetGroupBox1.Size = new System.Drawing.Size(312, 131);
            this.skeetGroupBox1.TabIndex = 1;
            this.skeetGroupBox1.TabStop = false;
            this.skeetGroupBox1.Text = "COM Port Settings";
            // 
            // labelPortState
            // 
            this.labelPortState.AutoSize = true;
            this.labelPortState.EnableShadow = true;
            this.labelPortState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.labelPortState.Location = new System.Drawing.Point(188, 104);
            this.labelPortState.Name = "labelPortState";
            this.labelPortState.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.labelPortState.ShadowOffset = 1;
            this.labelPortState.Size = new System.Drawing.Size(71, 15);
            this.labelPortState.TabIndex = 20;
            this.labelPortState.Text = "UNKNOWN";
            // 
            // shadowLabel2
            // 
            this.shadowLabel2.AutoSize = true;
            this.shadowLabel2.EnableShadow = false;
            this.shadowLabel2.ForeColor = System.Drawing.Color.White;
            this.shadowLabel2.Location = new System.Drawing.Point(156, 83);
            this.shadowLabel2.Name = "shadowLabel2";
            this.shadowLabel2.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel2.ShadowOffset = 1;
            this.shadowLabel2.Size = new System.Drawing.Size(144, 15);
            this.shadowLabel2.TabIndex = 19;
            this.shadowLabel2.Text = "Selected Port is currently ";
            // 
            // butonDeschiderePort
            // 
            this.butonDeschiderePort.BackColor = System.Drawing.Color.Transparent;
            this.butonDeschiderePort.Checked = false;
            this.butonDeschiderePort.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.butonDeschiderePort.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.butonDeschiderePort.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.butonDeschiderePort.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.butonDeschiderePort.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.butonDeschiderePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonDeschiderePort.Location = new System.Drawing.Point(157, 55);
            this.butonDeschiderePort.Name = "butonDeschiderePort";
            this.butonDeschiderePort.Size = new System.Drawing.Size(141, 23);
            this.butonDeschiderePort.TabIndex = 18;
            this.butonDeschiderePort.Text = "Change Port State";
            this.butonDeschiderePort.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.butonDeschiderePort_CheckedChanged);
            // 
            // ComboBoxBaudRate
            // 
            this.ComboBoxBaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Down",
            "Up",
            "Zero",
            "Fake down",
            "Fake up",
            "Fake zero"});
            this.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.ComboBoxBaudRate.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.ComboBoxBaudRate.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.ComboBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White;
            this.ComboBoxBaudRate.FormattingEnabled = true;
            this.ComboBoxBaudRate.ItemHeight = 18;
            this.ComboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.ComboBoxBaudRate.Location = new System.Drawing.Point(16, 89);
            this.ComboBoxBaudRate.Name = "ComboBoxBaudRate";
            this.ComboBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.ComboBoxBaudRate.TabIndex = 17;
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.AutoSize = true;
            this.shadowLabel1.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel1.EnableShadow = false;
            this.shadowLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(158)))), ((int)(((byte)(207)))));
            this.shadowLabel1.Location = new System.Drawing.Point(15, 72);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel1.ShadowOffset = 1;
            this.shadowLabel1.Size = new System.Drawing.Size(65, 16);
            this.shadowLabel1.TabIndex = 16;
            this.shadowLabel1.Text = "Baud rate";
            // 
            // comboBoxPortList
            // 
            this.comboBoxPortList.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Down",
            "Up",
            "Zero",
            "Fake down",
            "Fake up",
            "Fake zero"});
            this.comboBoxPortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.comboBoxPortList.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.comboBoxPortList.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.comboBoxPortList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxPortList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBoxPortList.ForeColor = System.Drawing.Color.White;
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.ItemHeight = 18;
            this.comboBoxPortList.Items.AddRange(new object[] {
            ""});
            this.comboBoxPortList.Location = new System.Drawing.Point(14, 42);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPortList.TabIndex = 15;
            this.comboBoxPortList.DropDown += new System.EventHandler(this.comboBoxPortList_DropDown);
            this.comboBoxPortList.SelectedIndexChanged += new System.EventHandler(this.comboBoxPortList_SelectedIndexChanged);
            // 
            // shadowLabel14
            // 
            this.shadowLabel14.AutoSize = true;
            this.shadowLabel14.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel14.EnableShadow = false;
            this.shadowLabel14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(158)))), ((int)(((byte)(207)))));
            this.shadowLabel14.Location = new System.Drawing.Point(13, 25);
            this.shadowLabel14.Name = "shadowLabel14";
            this.shadowLabel14.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel14.ShadowOffset = 1;
            this.shadowLabel14.Size = new System.Drawing.Size(64, 16);
            this.shadowLabel14.TabIndex = 14;
            this.shadowLabel14.Text = "COM Port";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartA1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(522, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartA1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(278, 338);
            this.chart1.TabIndex = 58;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            title1.Name = "Title1";
            title1.Text = "Soil humidity";
            this.chart1.Titles.Add(title1);
            // 
            // ultrasoundsensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.skeetGroupBox2);
            this.Controls.Add(this.skeetGroupBox3);
            this.Controls.Add(this.skeetGroupBox1);
            this.Name = "ultrasoundsensor";
            this.Size = new System.Drawing.Size(803, 556);
            this.skeetGroupBox2.ResumeLayout(false);
            this.skeetGroupBox4.ResumeLayout(false);
            this.skeetGroupBox4.PerformLayout();
            this.skeetGroupBox3.ResumeLayout(false);
            this.skeetGroupBox3.PerformLayout();
            this.skeetGroupBox1.ResumeLayout(false);
            this.skeetGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkeetFramework.SkeetGroupBox skeetGroupBox1;
        private SkeetFramework.shadowLabel labelPortState;
        private SkeetFramework.shadowLabel shadowLabel2;
        private SkeetFramework.SkeetToggle butonDeschiderePort;
        private SkeetFramework.SkeetComboBox ComboBoxBaudRate;
        private SkeetFramework.shadowLabel shadowLabel1;
        private SkeetFramework.SkeetComboBox comboBoxPortList;
        private SkeetFramework.shadowLabel shadowLabel14;
        private System.IO.Ports.SerialPort serialPort1;
        private SkeetFramework.SkeetGroupBox skeetGroupBox3;
        private SkeetFramework.shadowLabel shadowLabel3;
        private SkeetFramework.shadowLabel shadowLabel4;
        private SkeetFramework.shadowLabel shadowLabel7;
        private SkeetFramework.shadowLabel shadowLabel8;
        private SkeetFramework.shadowLabel shadowLabel13;
        private SkeetFramework.shadowLabel shadowLabel12;
        private SkeetFramework.shadowLabel shadowLabel11;
        private SkeetFramework.SkeetToggle ToggleWaterPump;
        private SkeetFramework.shadowLabel shadowLabel17;
        private SkeetFramework.shadowLabel shadowLabel18;
        private SkeetFramework.shadowLabel shadowLabel15;
        private SkeetFramework.shadowLabel shadowLabel16;
        private SkeetFramework.shadowLabel shadowLabel9;
        private SkeetFramework.shadowLabel shadowLabel10;
        private System.Windows.Forms.Button button1;
        private SkeetFramework.SkeetGroupBox skeetGroupBox2;
        private SkeetFramework.SkeetGroupBox skeetGroupBox4;
        private SkeetFramework.shadowLabel shadowLabel21;
        private SkeetFramework.shadowLabel shadowLabel20;
        private SkeetFramework.shadowLabel shadowLabel19;
        private SkeetFramework.shadowLabel shadowLabel26;
        private System.Windows.Forms.TextBox textBox4;
        private SkeetFramework.shadowLabel shadowLabel25;
        private System.Windows.Forms.Button button3;
        private SkeetFramework.shadowLabel shadowLabel24;
        private SkeetFramework.shadowLabel shadowLabel23;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SkeetFramework.shadowLabel shadowLabel5;
        private SkeetFramework.shadowLabel shadowLabel6;
        private SkeetFramework.shadowLabel shadowLabel22;
    }
}
