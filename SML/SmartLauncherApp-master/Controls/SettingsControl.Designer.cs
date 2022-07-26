namespace Artemis
{
    partial class SettingsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.skeetGroupBox3 = new SkeetFramework.SkeetGroupBox();
            this.skeetComboBox2 = new SkeetFramework.SkeetComboBox();
            this.shadowLabel20 = new SkeetFramework.shadowLabel();
            this.shadowLabel19 = new SkeetFramework.shadowLabel();
            this.skeetButton5 = new SkeetFramework.SkeetButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.shadowLabel18 = new SkeetFramework.shadowLabel();
            this.shadowLabel17 = new SkeetFramework.shadowLabel();
            this.skeetButton2 = new SkeetFramework.SkeetButton();
            this.skeetButton1 = new SkeetFramework.SkeetButton();
            this.skeetButton3 = new SkeetFramework.SkeetButton();
            this.shadowLabel15 = new SkeetFramework.shadowLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.shadowLabel16 = new SkeetFramework.shadowLabel();
            this.shadowLabel12 = new SkeetFramework.shadowLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shadowLabel13 = new SkeetFramework.shadowLabel();
            this.shadowLabel11 = new SkeetFramework.shadowLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.shadowLabel10 = new SkeetFramework.shadowLabel();
            this.skeetComboBox1 = new SkeetFramework.SkeetComboBox();
            this.shadowLabel9 = new SkeetFramework.shadowLabel();
            this.skeetGroupBox2 = new SkeetFramework.SkeetGroupBox();
            this.shadowLabel21 = new SkeetFramework.shadowLabel();
            this.shadowLabel22 = new SkeetFramework.shadowLabel();
            this.shadowLabel23 = new SkeetFramework.shadowLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shadowLabel8 = new SkeetFramework.shadowLabel();
            this.shadowLabel7 = new SkeetFramework.shadowLabel();
            this.shadowLabel6 = new SkeetFramework.shadowLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shadowLabel5 = new SkeetFramework.shadowLabel();
            this.shadowLabel4 = new SkeetFramework.shadowLabel();
            this.shadowLabel3 = new SkeetFramework.shadowLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skeetGroupBox1 = new SkeetFramework.SkeetGroupBox();
            this.labelPortState = new SkeetFramework.shadowLabel();
            this.shadowLabel2 = new SkeetFramework.shadowLabel();
            this.butonDeschiderePort = new SkeetFramework.SkeetToggle();
            this.ComboBoxBaudRate = new SkeetFramework.SkeetComboBox();
            this.shadowLabel1 = new SkeetFramework.shadowLabel();
            this.comboBoxPortList = new SkeetFramework.SkeetComboBox();
            this.shadowLabel14 = new SkeetFramework.shadowLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.skeetGroupBox3.SuspendLayout();
            this.skeetGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.skeetGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(632, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(2, 3);
            this.chart1.Name = "chart1";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(492, 357);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            title1.Name = "Title1";
            title1.Text = "Water Information";
            this.chart1.Titles.Add(title1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(683, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 60;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // skeetGroupBox3
            // 
            this.skeetGroupBox3.Controls.Add(this.skeetComboBox2);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel20);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel19);
            this.skeetGroupBox3.Controls.Add(this.skeetButton5);
            this.skeetGroupBox3.Controls.Add(this.textBox4);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel18);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel17);
            this.skeetGroupBox3.Controls.Add(this.skeetButton2);
            this.skeetGroupBox3.Controls.Add(this.skeetButton1);
            this.skeetGroupBox3.Controls.Add(this.skeetButton3);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel15);
            this.skeetGroupBox3.Controls.Add(this.textBox3);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel16);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel12);
            this.skeetGroupBox3.Controls.Add(this.textBox1);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel13);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel11);
            this.skeetGroupBox3.Controls.Add(this.textBox2);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel10);
            this.skeetGroupBox3.Controls.Add(this.skeetComboBox1);
            this.skeetGroupBox3.Controls.Add(this.shadowLabel9);
            this.skeetGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox3.Location = new System.Drawing.Point(482, 43);
            this.skeetGroupBox3.Name = "skeetGroupBox3";
            this.skeetGroupBox3.Size = new System.Drawing.Size(313, 297);
            this.skeetGroupBox3.TabIndex = 11;
            this.skeetGroupBox3.TabStop = false;
            // 
            // skeetComboBox2
            // 
            this.skeetComboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Down",
            "Up",
            "Zero",
            "Fake down",
            "Fake up",
            "Fake zero"});
            this.skeetComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.skeetComboBox2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.skeetComboBox2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.skeetComboBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.skeetComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skeetComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skeetComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skeetComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.skeetComboBox2.ForeColor = System.Drawing.Color.White;
            this.skeetComboBox2.FormattingEnabled = true;
            this.skeetComboBox2.ItemHeight = 18;
            this.skeetComboBox2.Items.AddRange(new object[] {
            "AUTOMATIC",
            "MANUAL"});
            this.skeetComboBox2.Location = new System.Drawing.Point(19, 253);
            this.skeetComboBox2.Name = "skeetComboBox2";
            this.skeetComboBox2.Size = new System.Drawing.Size(121, 24);
            this.skeetComboBox2.Sorted = true;
            this.skeetComboBox2.TabIndex = 86;
            this.skeetComboBox2.SelectedIndexChanged += new System.EventHandler(this.skeetComboBox2_SelectedIndexChanged);
            // 
            // shadowLabel20
            // 
            this.shadowLabel20.AutoSize = true;
            this.shadowLabel20.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel20.EnableShadow = false;
            this.shadowLabel20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(158)))), ((int)(((byte)(207)))));
            this.shadowLabel20.Location = new System.Drawing.Point(18, 234);
            this.shadowLabel20.Name = "shadowLabel20";
            this.shadowLabel20.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel20.ShadowOffset = 1;
            this.shadowLabel20.Size = new System.Drawing.Size(138, 16);
            this.shadowLabel20.TabIndex = 85;
            this.shadowLabel20.Text = "Select Irrigation mode";
            // 
            // shadowLabel19
            // 
            this.shadowLabel19.AutoSize = true;
            this.shadowLabel19.EnableShadow = false;
            this.shadowLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel19.ForeColor = System.Drawing.Color.White;
            this.shadowLabel19.Location = new System.Drawing.Point(226, 50);
            this.shadowLabel19.Name = "shadowLabel19";
            this.shadowLabel19.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel19.ShadowOffset = 1;
            this.shadowLabel19.Size = new System.Drawing.Size(26, 16);
            this.shadowLabel19.TabIndex = 84;
            this.shadowLabel19.Text = "cm";
            // 
            // skeetButton5
            // 
            this.skeetButton5.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.skeetButton5.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.skeetButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeetButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.skeetButton5.Location = new System.Drawing.Point(257, 48);
            this.skeetButton5.Name = "skeetButton5";
            this.skeetButton5.Size = new System.Drawing.Size(47, 20);
            this.skeetButton5.TabIndex = 83;
            this.skeetButton5.Text = "Update";
            this.skeetButton5.Click += new System.EventHandler(this.skeetButton5_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(104)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Location = new System.Drawing.Point(116, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 14);
            this.textBox4.TabIndex = 80;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // shadowLabel18
            // 
            this.shadowLabel18.AutoSize = true;
            this.shadowLabel18.EnableShadow = false;
            this.shadowLabel18.ForeColor = System.Drawing.Color.White;
            this.shadowLabel18.Location = new System.Drawing.Point(14, 50);
            this.shadowLabel18.Name = "shadowLabel18";
            this.shadowLabel18.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel18.ShadowOffset = 1;
            this.shadowLabel18.Size = new System.Drawing.Size(99, 15);
            this.shadowLabel18.TabIndex = 79;
            this.shadowLabel18.Text = "Water tank depth";
            // 
            // shadowLabel17
            // 
            this.shadowLabel17.AutoSize = true;
            this.shadowLabel17.EnableShadow = false;
            this.shadowLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.shadowLabel17.ForeColor = System.Drawing.Color.White;
            this.shadowLabel17.Location = new System.Drawing.Point(80, 17);
            this.shadowLabel17.Name = "shadowLabel17";
            this.shadowLabel17.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel17.ShadowOffset = 1;
            this.shadowLabel17.Size = new System.Drawing.Size(126, 16);
            this.shadowLabel17.TabIndex = 77;
            this.shadowLabel17.Text = "Application Settings";
            // 
            // skeetButton2
            // 
            this.skeetButton2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.skeetButton2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.skeetButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeetButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.skeetButton2.Location = new System.Drawing.Point(257, 195);
            this.skeetButton2.Name = "skeetButton2";
            this.skeetButton2.Size = new System.Drawing.Size(47, 20);
            this.skeetButton2.TabIndex = 76;
            this.skeetButton2.Text = "Update";
            this.skeetButton2.Click += new System.EventHandler(this.skeetButton2_Click);
            // 
            // skeetButton1
            // 
            this.skeetButton1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.skeetButton1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.skeetButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeetButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.skeetButton1.Location = new System.Drawing.Point(257, 169);
            this.skeetButton1.Name = "skeetButton1";
            this.skeetButton1.Size = new System.Drawing.Size(47, 20);
            this.skeetButton1.TabIndex = 75;
            this.skeetButton1.Text = "Update";
            this.skeetButton1.Click += new System.EventHandler(this.skeetButton1_Click);
            // 
            // skeetButton3
            // 
            this.skeetButton3.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.skeetButton3.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.skeetButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skeetButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(111)))), ((int)(((byte)(156)))));
            this.skeetButton3.Location = new System.Drawing.Point(257, 145);
            this.skeetButton3.Name = "skeetButton3";
            this.skeetButton3.Size = new System.Drawing.Size(47, 20);
            this.skeetButton3.TabIndex = 74;
            this.skeetButton3.Text = "Update";
            this.skeetButton3.Click += new System.EventHandler(this.skeetButton3_Click);
            // 
            // shadowLabel15
            // 
            this.shadowLabel15.AutoSize = true;
            this.shadowLabel15.EnableShadow = false;
            this.shadowLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel15.ForeColor = System.Drawing.Color.White;
            this.shadowLabel15.Location = new System.Drawing.Point(226, 197);
            this.shadowLabel15.Name = "shadowLabel15";
            this.shadowLabel15.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel15.ShadowOffset = 1;
            this.shadowLabel15.Size = new System.Drawing.Size(26, 16);
            this.shadowLabel15.TabIndex = 73;
            this.shadowLabel15.Text = "cm";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(104)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Location = new System.Drawing.Point(116, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 14);
            this.textBox3.TabIndex = 72;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // shadowLabel16
            // 
            this.shadowLabel16.AutoSize = true;
            this.shadowLabel16.EnableShadow = false;
            this.shadowLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.shadowLabel16.ForeColor = System.Drawing.Color.White;
            this.shadowLabel16.Location = new System.Drawing.Point(16, 199);
            this.shadowLabel16.Name = "shadowLabel16";
            this.shadowLabel16.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel16.ShadowOffset = 1;
            this.shadowLabel16.Size = new System.Drawing.Size(42, 16);
            this.shadowLabel16.TabIndex = 71;
            this.shadowLabel16.Text = "Width";
            // 
            // shadowLabel12
            // 
            this.shadowLabel12.AutoSize = true;
            this.shadowLabel12.EnableShadow = false;
            this.shadowLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel12.ForeColor = System.Drawing.Color.White;
            this.shadowLabel12.Location = new System.Drawing.Point(226, 171);
            this.shadowLabel12.Name = "shadowLabel12";
            this.shadowLabel12.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel12.ShadowOffset = 1;
            this.shadowLabel12.Size = new System.Drawing.Size(26, 16);
            this.shadowLabel12.TabIndex = 70;
            this.shadowLabel12.Text = "cm";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(104)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(116, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 69;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // shadowLabel13
            // 
            this.shadowLabel13.AutoSize = true;
            this.shadowLabel13.EnableShadow = false;
            this.shadowLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.shadowLabel13.ForeColor = System.Drawing.Color.White;
            this.shadowLabel13.Location = new System.Drawing.Point(16, 173);
            this.shadowLabel13.Name = "shadowLabel13";
            this.shadowLabel13.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel13.ShadowOffset = 1;
            this.shadowLabel13.Size = new System.Drawing.Size(48, 16);
            this.shadowLabel13.TabIndex = 68;
            this.shadowLabel13.Text = "Length";
            // 
            // shadowLabel11
            // 
            this.shadowLabel11.AutoSize = true;
            this.shadowLabel11.EnableShadow = false;
            this.shadowLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel11.ForeColor = System.Drawing.Color.White;
            this.shadowLabel11.Location = new System.Drawing.Point(226, 145);
            this.shadowLabel11.Name = "shadowLabel11";
            this.shadowLabel11.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel11.ShadowOffset = 1;
            this.shadowLabel11.Size = new System.Drawing.Size(26, 16);
            this.shadowLabel11.TabIndex = 67;
            this.shadowLabel11.Text = "cm";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(27)))), ((int)(((byte)(104)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(116, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 14);
            this.textBox2.TabIndex = 66;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // shadowLabel10
            // 
            this.shadowLabel10.AutoSize = true;
            this.shadowLabel10.EnableShadow = false;
            this.shadowLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.shadowLabel10.ForeColor = System.Drawing.Color.White;
            this.shadowLabel10.Location = new System.Drawing.Point(16, 147);
            this.shadowLabel10.Name = "shadowLabel10";
            this.shadowLabel10.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel10.ShadowOffset = 1;
            this.shadowLabel10.Size = new System.Drawing.Size(63, 16);
            this.shadowLabel10.TabIndex = 65;
            this.shadowLabel10.Text = "Diameter";
            // 
            // skeetComboBox1
            // 
            this.skeetComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "None",
            "Down",
            "Up",
            "Zero",
            "Fake down",
            "Fake up",
            "Fake zero"});
            this.skeetComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.skeetComboBox1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(63)))), ((int)(((byte)(96)))));
            this.skeetComboBox1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(66)))), ((int)(((byte)(98)))));
            this.skeetComboBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.skeetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skeetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skeetComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skeetComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.skeetComboBox1.ForeColor = System.Drawing.Color.White;
            this.skeetComboBox1.FormattingEnabled = true;
            this.skeetComboBox1.ItemHeight = 18;
            this.skeetComboBox1.Items.AddRange(new object[] {
            "Cylindrical Tank",
            "Paralelipipedic Tank"});
            this.skeetComboBox1.Location = new System.Drawing.Point(16, 107);
            this.skeetComboBox1.Name = "skeetComboBox1";
            this.skeetComboBox1.Size = new System.Drawing.Size(121, 24);
            this.skeetComboBox1.Sorted = true;
            this.skeetComboBox1.TabIndex = 64;
            this.skeetComboBox1.SelectedIndexChanged += new System.EventHandler(this.skeetComboBox1_SelectedIndexChanged_1);
            // 
            // shadowLabel9
            // 
            this.shadowLabel9.AutoSize = true;
            this.shadowLabel9.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel9.EnableShadow = false;
            this.shadowLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shadowLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(158)))), ((int)(((byte)(207)))));
            this.shadowLabel9.Location = new System.Drawing.Point(14, 88);
            this.shadowLabel9.Name = "shadowLabel9";
            this.shadowLabel9.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel9.ShadowOffset = 1;
            this.shadowLabel9.Size = new System.Drawing.Size(103, 16);
            this.shadowLabel9.TabIndex = 63;
            this.shadowLabel9.Text = "Select tank type";
            // 
            // skeetGroupBox2
            // 
            this.skeetGroupBox2.Controls.Add(this.shadowLabel21);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel22);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel23);
            this.skeetGroupBox2.Controls.Add(this.pictureBox3);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel8);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel7);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel6);
            this.skeetGroupBox2.Controls.Add(this.pictureBox2);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel5);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel4);
            this.skeetGroupBox2.Controls.Add(this.shadowLabel3);
            this.skeetGroupBox2.Controls.Add(this.pictureBox1);
            this.skeetGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.skeetGroupBox2.Location = new System.Drawing.Point(345, 400);
            this.skeetGroupBox2.Name = "skeetGroupBox2";
            this.skeetGroupBox2.Size = new System.Drawing.Size(314, 131);
            this.skeetGroupBox2.TabIndex = 8;
            this.skeetGroupBox2.TabStop = false;
            this.skeetGroupBox2.Text = "Weather inside solar greenhouse";
            // 
            // shadowLabel21
            // 
            this.shadowLabel21.AutoSize = true;
            this.shadowLabel21.EnableShadow = false;
            this.shadowLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel21.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.shadowLabel21.Location = new System.Drawing.Point(243, 100);
            this.shadowLabel21.Name = "shadowLabel21";
            this.shadowLabel21.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel21.ShadowOffset = 1;
            this.shadowLabel21.Size = new System.Drawing.Size(52, 16);
            this.shadowLabel21.TabIndex = 31;
            this.shadowLabel21.Text = "mmHg";
            // 
            // shadowLabel22
            // 
            this.shadowLabel22.AutoSize = true;
            this.shadowLabel22.EnableShadow = false;
            this.shadowLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel22.ForeColor = System.Drawing.Color.White;
            this.shadowLabel22.Location = new System.Drawing.Point(187, 100);
            this.shadowLabel22.Name = "shadowLabel22";
            this.shadowLabel22.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel22.ShadowOffset = 1;
            this.shadowLabel22.Size = new System.Drawing.Size(52, 16);
            this.shadowLabel22.TabIndex = 30;
            this.shadowLabel22.Text = "705.43";
            // 
            // shadowLabel23
            // 
            this.shadowLabel23.AutoSize = true;
            this.shadowLabel23.EnableShadow = true;
            this.shadowLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel23.Location = new System.Drawing.Point(73, 100);
            this.shadowLabel23.Name = "shadowLabel23";
            this.shadowLabel23.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel23.ShadowOffset = 1;
            this.shadowLabel23.Size = new System.Drawing.Size(62, 16);
            this.shadowLabel23.TabIndex = 29;
            this.shadowLabel23.Text = "Pressure";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SML.Properties.Resources.Atmospheric_Pressure_595b40b65ba036ed117d28da_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(23, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // shadowLabel8
            // 
            this.shadowLabel8.AutoSize = true;
            this.shadowLabel8.EnableShadow = false;
            this.shadowLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.shadowLabel8.Location = new System.Drawing.Point(243, 65);
            this.shadowLabel8.Name = "shadowLabel8";
            this.shadowLabel8.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel8.ShadowOffset = 1;
            this.shadowLabel8.Size = new System.Drawing.Size(21, 16);
            this.shadowLabel8.TabIndex = 27;
            this.shadowLabel8.Text = "%";
            // 
            // shadowLabel7
            // 
            this.shadowLabel7.AutoSize = true;
            this.shadowLabel7.EnableShadow = false;
            this.shadowLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel7.ForeColor = System.Drawing.Color.White;
            this.shadowLabel7.Location = new System.Drawing.Point(195, 65);
            this.shadowLabel7.Name = "shadowLabel7";
            this.shadowLabel7.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel7.ShadowOffset = 1;
            this.shadowLabel7.Size = new System.Drawing.Size(44, 16);
            this.shadowLabel7.TabIndex = 26;
            this.shadowLabel7.Text = "61.34";
            // 
            // shadowLabel6
            // 
            this.shadowLabel6.AutoSize = true;
            this.shadowLabel6.EnableShadow = true;
            this.shadowLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.shadowLabel6.Location = new System.Drawing.Point(73, 65);
            this.shadowLabel6.Name = "shadowLabel6";
            this.shadowLabel6.ShadowColor = System.Drawing.Color.Blue;
            this.shadowLabel6.ShadowOffset = 1;
            this.shadowLabel6.Size = new System.Drawing.Size(60, 16);
            this.shadowLabel6.TabIndex = 25;
            this.shadowLabel6.Text = "Humidity";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SML.Properties.Resources.humidity_icon_9;
            this.pictureBox2.Location = new System.Drawing.Point(23, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // shadowLabel5
            // 
            this.shadowLabel5.AutoSize = true;
            this.shadowLabel5.EnableShadow = false;
            this.shadowLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.shadowLabel5.Location = new System.Drawing.Point(239, 28);
            this.shadowLabel5.Name = "shadowLabel5";
            this.shadowLabel5.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel5.ShadowOffset = 1;
            this.shadowLabel5.Size = new System.Drawing.Size(23, 16);
            this.shadowLabel5.TabIndex = 23;
            this.shadowLabel5.Text = "°C";
            // 
            // shadowLabel4
            // 
            this.shadowLabel4.AutoSize = true;
            this.shadowLabel4.EnableShadow = false;
            this.shadowLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel4.ForeColor = System.Drawing.Color.White;
            this.shadowLabel4.Location = new System.Drawing.Point(195, 28);
            this.shadowLabel4.Name = "shadowLabel4";
            this.shadowLabel4.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel4.ShadowOffset = 1;
            this.shadowLabel4.Size = new System.Drawing.Size(44, 16);
            this.shadowLabel4.TabIndex = 22;
            this.shadowLabel4.Text = "23.57";
            // 
            // shadowLabel3
            // 
            this.shadowLabel3.AutoSize = true;
            this.shadowLabel3.EnableShadow = true;
            this.shadowLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(36)))), ((int)(((byte)(106)))));
            this.shadowLabel3.Location = new System.Drawing.Point(73, 28);
            this.shadowLabel3.Name = "shadowLabel3";
            this.shadowLabel3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(34)))), ((int)(((byte)(93)))));
            this.shadowLabel3.ShadowOffset = 1;
            this.shadowLabel3.Size = new System.Drawing.Size(86, 16);
            this.shadowLabel3.TabIndex = 21;
            this.shadowLabel3.Text = "Temperature";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SML.Properties.Resources._7adccf0dd0e13dfdaff447cb5372912b_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(23, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.skeetGroupBox1.TabIndex = 0;
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
            this.butonDeschiderePort.ColorBottom = System.Drawing.Color.Transparent;
            this.butonDeschiderePort.ColorBottom1 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(12)))), ((int)(((byte)(81)))));
            this.butonDeschiderePort.ColorTop = System.Drawing.Color.Transparent;
            this.butonDeschiderePort.ColorTop1 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(19)))), ((int)(((byte)(95)))));
            this.butonDeschiderePort.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.butonDeschiderePort.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.butonDeschiderePort.Location = new System.Drawing.Point(157, 55);
            this.butonDeschiderePort.Name = "butonDeschiderePort";
            this.butonDeschiderePort.Size = new System.Drawing.Size(141, 23);
            this.butonDeschiderePort.TabIndex = 18;
            this.butonDeschiderePort.Text = "Change Port State";
            this.butonDeschiderePort.CheckedChanged += new SkeetFramework.SkeetToggle.CheckedChangedEventHandler(this.skeetToggle2_CheckedChanged);
            // 
            // ComboBoxBaudRate
            // 
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
            this.shadowLabel1.Size = new System.Drawing.Size(66, 16);
            this.shadowLabel1.TabIndex = 16;
            this.shadowLabel1.Text = "Baud rate";
            // 
            // comboBoxPortList
            // 
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
            this.comboBoxPortList.SelectedIndexChanged += new System.EventHandler(this.skeetComboBox1_SelectedIndexChanged);
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
            this.shadowLabel14.Size = new System.Drawing.Size(65, 16);
            this.shadowLabel14.TabIndex = 14;
            this.shadowLabel14.Text = "COM Port";
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(19)))), ((int)(((byte)(53)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.skeetGroupBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skeetGroupBox2);
            this.Controls.Add(this.skeetGroupBox1);
            this.Controls.Add(this.button2);
            this.DoubleBuffered = true;
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(803, 556);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.skeetGroupBox3.ResumeLayout(false);
            this.skeetGroupBox3.PerformLayout();
            this.skeetGroupBox2.ResumeLayout(false);
            this.skeetGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.skeetGroupBox1.ResumeLayout(false);
            this.skeetGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkeetFramework.SkeetGroupBox skeetGroupBox1;
        private SkeetFramework.SkeetComboBox ComboBoxBaudRate;
        private SkeetFramework.shadowLabel shadowLabel1;
        private SkeetFramework.SkeetComboBox comboBoxPortList;
        private SkeetFramework.shadowLabel shadowLabel14;
        private System.IO.Ports.SerialPort serialPort1;
        private SkeetFramework.SkeetToggle butonDeschiderePort;
        private SkeetFramework.shadowLabel labelPortState;
        private SkeetFramework.shadowLabel shadowLabel2;
        private SkeetFramework.SkeetGroupBox skeetGroupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SkeetFramework.shadowLabel shadowLabel5;
        private SkeetFramework.shadowLabel shadowLabel4;
        private SkeetFramework.shadowLabel shadowLabel3;
        private SkeetFramework.shadowLabel shadowLabel8;
        private SkeetFramework.shadowLabel shadowLabel7;
        private SkeetFramework.shadowLabel shadowLabel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SkeetFramework.SkeetGroupBox skeetGroupBox3;
        private System.Windows.Forms.Button button2;
        private SkeetFramework.SkeetComboBox skeetComboBox1;
        private SkeetFramework.shadowLabel shadowLabel9;
        private SkeetFramework.shadowLabel shadowLabel10;
        private SkeetFramework.shadowLabel shadowLabel15;
        private System.Windows.Forms.TextBox textBox3;
        private SkeetFramework.shadowLabel shadowLabel16;
        private SkeetFramework.shadowLabel shadowLabel12;
        private System.Windows.Forms.TextBox textBox1;
        private SkeetFramework.shadowLabel shadowLabel13;
        private System.Windows.Forms.TextBox textBox2;
        private SkeetFramework.SkeetButton skeetButton2;
        private SkeetFramework.SkeetButton skeetButton1;
        private SkeetFramework.SkeetButton skeetButton3;
        private SkeetFramework.shadowLabel shadowLabel17;
        private SkeetFramework.shadowLabel shadowLabel18;
        private System.Windows.Forms.TextBox textBox4;
        private SkeetFramework.SkeetButton skeetButton5;
        private SkeetFramework.shadowLabel shadowLabel19;
        private SkeetFramework.shadowLabel shadowLabel11;
        private SkeetFramework.shadowLabel shadowLabel20;
        private SkeetFramework.shadowLabel shadowLabel21;
        private SkeetFramework.shadowLabel shadowLabel22;
        private SkeetFramework.shadowLabel shadowLabel23;
        private System.Windows.Forms.PictureBox pictureBox3;
        private SkeetFramework.SkeetComboBox skeetComboBox2;
    }
}
