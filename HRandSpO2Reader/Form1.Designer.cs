namespace HRandSpO2Reader
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.max30102RawChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.formMain2Panel = new System.Windows.Forms.Panel();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.exampleSamplePictureBox = new System.Windows.Forms.PictureBox();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.hrResultLabel = new System.Windows.Forms.Label();
            this.hrLabel = new System.Windows.Forms.Label();
            this.spo2Label = new System.Windows.Forms.Label();
            this.spoResultLabel = new System.Windows.Forms.Label();
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.patianStoryLabel = new System.Windows.Forms.Label();
            this.patientStory = new System.Windows.Forms.TextBox();
            this.hesCode = new System.Windows.Forms.TextBox();
            this.hesCodeLabel = new System.Windows.Forms.Label();
            this.ganderLabel = new System.Windows.Forms.Label();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.numericMonth = new System.Windows.Forms.NumericUpDown();
            this.numericDay = new System.Windows.Forms.NumericUpDown();
            this.idNumber = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.calculationLabel = new System.Windows.Forms.Label();
            this.calculationProgressBar = new System.Windows.Forms.ProgressBar();
            this.getSampleButton = new System.Windows.Forms.Button();
            this.form1PortPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.portStateLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.portStateProgressBar = new System.Windows.Forms.ProgressBar();
            this.portClose = new System.Windows.Forms.Button();
            this.portOpen = new System.Windows.Forms.Button();
            this.stopBit = new System.Windows.Forms.Label();
            this.parityBit = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.boudRadesLabel = new System.Windows.Forms.Label();
            this.ComPortLabel = new System.Windows.Forms.Label();
            this.stopBitcomboBox = new System.Windows.Forms.ComboBox();
            this.parityBitcomboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.boudRadescomboBox = new System.Windows.Forms.ComboBox();
            this.comPortcomboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.max30102RawChart)).BeginInit();
            this.formMain2Panel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleSamplePictureBox)).BeginInit();
            this.informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).BeginInit();
            this.form1PortPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawTextBox
            // 
            this.rawTextBox.Location = new System.Drawing.Point(32, 20);
            this.rawTextBox.Multiline = true;
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(65, 306);
            this.rawTextBox.TabIndex = 0;
            // 
            // max30102RawChart
            // 
            chartArea7.Name = "ChartArea1";
            this.max30102RawChart.ChartAreas.Add(chartArea7);
            legend7.MaximumAutoSize = 80F;
            legend7.Name = "Legend1";
            this.max30102RawChart.Legends.Add(legend7);
            this.max30102RawChart.Location = new System.Drawing.Point(12, 368);
            this.max30102RawChart.MinimumSize = new System.Drawing.Size(1050, 454);
            this.max30102RawChart.Name = "max30102RawChart";
            this.max30102RawChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Series2";
            this.max30102RawChart.Series.Add(series13);
            this.max30102RawChart.Series.Add(series14);
            this.max30102RawChart.Size = new System.Drawing.Size(1050, 454);
            this.max30102RawChart.SuppressExceptions = true;
            this.max30102RawChart.TabIndex = 1;
            this.max30102RawChart.Text = "chart1";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM8";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialReciever);
            // 
            // timer1
            // 
            this.timer1.Interval = 14400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1600;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // formMain2Panel
            // 
            this.formMain2Panel.Controls.Add(this.picturePanel);
            this.formMain2Panel.Controls.Add(this.hrResultLabel);
            this.formMain2Panel.Controls.Add(this.hrLabel);
            this.formMain2Panel.Controls.Add(this.spo2Label);
            this.formMain2Panel.Controls.Add(this.spoResultLabel);
            this.formMain2Panel.Controls.Add(this.informationGroupBox);
            this.formMain2Panel.Controls.Add(this.calculationLabel);
            this.formMain2Panel.Controls.Add(this.calculationProgressBar);
            this.formMain2Panel.Controls.Add(this.getSampleButton);
            this.formMain2Panel.Controls.Add(this.max30102RawChart);
            this.formMain2Panel.Controls.Add(this.rawTextBox);
            this.formMain2Panel.Enabled = false;
            this.formMain2Panel.Location = new System.Drawing.Point(0, 81);
            this.formMain2Panel.Name = "formMain2Panel";
            this.formMain2Panel.Size = new System.Drawing.Size(1071, 831);
            this.formMain2Panel.TabIndex = 4;
            // 
            // picturePanel
            // 
            this.picturePanel.Controls.Add(this.exampleSamplePictureBox);
            this.picturePanel.Controls.Add(this.exampleLabel);
            this.picturePanel.Location = new System.Drawing.Point(55, 382);
            this.picturePanel.MinimumSize = new System.Drawing.Size(968, 419);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(968, 419);
            this.picturePanel.TabIndex = 10;
            this.picturePanel.Visible = false;
            // 
            // exampleSamplePictureBox
            // 
            this.exampleSamplePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.exampleSamplePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("exampleSamplePictureBox.Image")));
            this.exampleSamplePictureBox.Location = new System.Drawing.Point(68, 45);
            this.exampleSamplePictureBox.MinimumSize = new System.Drawing.Size(786, 245);
            this.exampleSamplePictureBox.Name = "exampleSamplePictureBox";
            this.exampleSamplePictureBox.Size = new System.Drawing.Size(862, 245);
            this.exampleSamplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exampleSamplePictureBox.TabIndex = 10;
            this.exampleSamplePictureBox.TabStop = false;
            // 
            // exampleLabel
            // 
            this.exampleLabel.AutoSize = true;
            this.exampleLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exampleLabel.Font = new System.Drawing.Font("Ebrima", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exampleLabel.ForeColor = System.Drawing.Color.Red;
            this.exampleLabel.Location = new System.Drawing.Point(266, 329);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(346, 65);
            this.exampleLabel.TabIndex = 11;
            this.exampleLabel.Text = "Example Graph";
            // 
            // hrResultLabel
            // 
            this.hrResultLabel.AutoSize = true;
            this.hrResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hrResultLabel.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrResultLabel.Location = new System.Drawing.Point(180, 122);
            this.hrResultLabel.Name = "hrResultLabel";
            this.hrResultLabel.Size = new System.Drawing.Size(2, 36);
            this.hrResultLabel.TabIndex = 8;
            // 
            // hrLabel
            // 
            this.hrLabel.AutoSize = true;
            this.hrLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hrLabel.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrLabel.Location = new System.Drawing.Point(105, 122);
            this.hrLabel.Name = "hrLabel";
            this.hrLabel.Size = new System.Drawing.Size(64, 36);
            this.hrLabel.TabIndex = 8;
            this.hrLabel.Text = "HR=";
            this.hrLabel.Click += new System.EventHandler(this.label12_Click);
            // 
            // spo2Label
            // 
            this.spo2Label.AutoSize = true;
            this.spo2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spo2Label.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spo2Label.Location = new System.Drawing.Point(105, 20);
            this.spo2Label.Name = "spo2Label";
            this.spo2Label.Size = new System.Drawing.Size(109, 36);
            this.spo2Label.TabIndex = 8;
            this.spo2Label.Text = "SpO2=%";
            // 
            // spoResultLabel
            // 
            this.spoResultLabel.AutoSize = true;
            this.spoResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spoResultLabel.Font = new System.Drawing.Font("Roboto Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spoResultLabel.Location = new System.Drawing.Point(220, 20);
            this.spoResultLabel.Name = "spoResultLabel";
            this.spoResultLabel.Size = new System.Drawing.Size(2, 36);
            this.spoResultLabel.TabIndex = 8;
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Controls.Add(this.buttonSubmit);
            this.informationGroupBox.Controls.Add(this.patianStoryLabel);
            this.informationGroupBox.Controls.Add(this.patientStory);
            this.informationGroupBox.Controls.Add(this.hesCode);
            this.informationGroupBox.Controls.Add(this.hesCodeLabel);
            this.informationGroupBox.Controls.Add(this.ganderLabel);
            this.informationGroupBox.Controls.Add(this.dateOfBirthLabel);
            this.informationGroupBox.Controls.Add(this.numericYear);
            this.informationGroupBox.Controls.Add(this.numericMonth);
            this.informationGroupBox.Controls.Add(this.numericDay);
            this.informationGroupBox.Controls.Add(this.idNumber);
            this.informationGroupBox.Controls.Add(this.fullName);
            this.informationGroupBox.Controls.Add(this.comboGender);
            this.informationGroupBox.Controls.Add(this.idLabel);
            this.informationGroupBox.Controls.Add(this.labelName);
            this.informationGroupBox.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.informationGroupBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.informationGroupBox.Location = new System.Drawing.Point(517, 14);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(544, 333);
            this.informationGroupBox.TabIndex = 7;
            this.informationGroupBox.TabStop = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Silver;
            this.buttonSubmit.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSubmit.Location = new System.Drawing.Point(442, 278);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 34);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // patianStoryLabel
            // 
            this.patianStoryLabel.AutoSize = true;
            this.patianStoryLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.patianStoryLabel.Location = new System.Drawing.Point(33, 204);
            this.patianStoryLabel.Name = "patianStoryLabel";
            this.patianStoryLabel.Size = new System.Drawing.Size(382, 20);
            this.patianStoryLabel.TabIndex = 9;
            this.patianStoryLabel.Text = "Have you had an illness recently?Write down briefly.";
            // 
            // patientStory
            // 
            this.patientStory.Location = new System.Drawing.Point(36, 231);
            this.patientStory.Multiline = true;
            this.patientStory.Name = "patientStory";
            this.patientStory.Size = new System.Drawing.Size(400, 81);
            this.patientStory.TabIndex = 8;
            // 
            // hesCode
            // 
            this.hesCode.Location = new System.Drawing.Point(36, 174);
            this.hesCode.Name = "hesCode";
            this.hesCode.Size = new System.Drawing.Size(171, 28);
            this.hesCode.TabIndex = 7;
            // 
            // hesCodeLabel
            // 
            this.hesCodeLabel.AutoSize = true;
            this.hesCodeLabel.Location = new System.Drawing.Point(32, 148);
            this.hesCodeLabel.Name = "hesCodeLabel";
            this.hesCodeLabel.Size = new System.Drawing.Size(95, 24);
            this.hesCodeLabel.TabIndex = 6;
            this.hesCodeLabel.Text = "HES Code";
            // 
            // ganderLabel
            // 
            this.ganderLabel.AutoSize = true;
            this.ganderLabel.Location = new System.Drawing.Point(272, 106);
            this.ganderLabel.Name = "ganderLabel";
            this.ganderLabel.Size = new System.Drawing.Size(74, 24);
            this.ganderLabel.TabIndex = 5;
            this.ganderLabel.Text = "Gander";
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(272, 33);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(127, 24);
            this.dateOfBirthLabel.TabIndex = 5;
            this.dateOfBirthLabel.Text = "Date Of Birth";
            // 
            // numericYear
            // 
            this.numericYear.Location = new System.Drawing.Point(394, 60);
            this.numericYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(69, 28);
            this.numericYear.TabIndex = 4;
            this.numericYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericMonth
            // 
            this.numericMonth.Location = new System.Drawing.Point(335, 60);
            this.numericMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMonth.Name = "numericMonth";
            this.numericMonth.Size = new System.Drawing.Size(53, 28);
            this.numericMonth.TabIndex = 4;
            this.numericMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericDay
            // 
            this.numericDay.Location = new System.Drawing.Point(276, 60);
            this.numericDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDay.Name = "numericDay";
            this.numericDay.Size = new System.Drawing.Size(53, 28);
            this.numericDay.TabIndex = 4;
            this.numericDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // idNumber
            // 
            this.idNumber.Location = new System.Drawing.Point(36, 113);
            this.idNumber.Name = "idNumber";
            this.idNumber.Size = new System.Drawing.Size(171, 28);
            this.idNumber.TabIndex = 3;
            // 
            // fullName
            // 
            this.fullName.Location = new System.Drawing.Point(36, 57);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(171, 28);
            this.fullName.TabIndex = 2;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(276, 133);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(112, 31);
            this.comboGender.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(33, 88);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(102, 24);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Id Number";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 24);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name and Surneame";
            // 
            // calculationLabel
            // 
            this.calculationLabel.AutoSize = true;
            this.calculationLabel.Location = new System.Drawing.Point(105, 309);
            this.calculationLabel.Name = "calculationLabel";
            this.calculationLabel.Size = new System.Drawing.Size(89, 17);
            this.calculationLabel.TabIndex = 6;
            this.calculationLabel.Text = "Calculating...";
            this.calculationLabel.Visible = false;
            // 
            // calculationProgressBar
            // 
            this.calculationProgressBar.Location = new System.Drawing.Point(105, 275);
            this.calculationProgressBar.Name = "calculationProgressBar";
            this.calculationProgressBar.Size = new System.Drawing.Size(329, 31);
            this.calculationProgressBar.TabIndex = 5;
            this.calculationProgressBar.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // getSampleButton
            // 
            this.getSampleButton.BackColor = System.Drawing.Color.Silver;
            this.getSampleButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getSampleButton.Location = new System.Drawing.Point(105, 213);
            this.getSampleButton.Name = "getSampleButton";
            this.getSampleButton.Size = new System.Drawing.Size(131, 48);
            this.getSampleButton.TabIndex = 4;
            this.getSampleButton.Text = "New Sample";
            this.getSampleButton.UseVisualStyleBackColor = false;
            this.getSampleButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // form1PortPanel
            // 
            this.form1PortPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.form1PortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.form1PortPanel.Controls.Add(this.refreshButton);
            this.form1PortPanel.Controls.Add(this.portStateLabel);
            this.form1PortPanel.Controls.Add(this.applyButton);
            this.form1PortPanel.Controls.Add(this.portStateProgressBar);
            this.form1PortPanel.Controls.Add(this.portClose);
            this.form1PortPanel.Controls.Add(this.portOpen);
            this.form1PortPanel.Controls.Add(this.stopBit);
            this.form1PortPanel.Controls.Add(this.parityBit);
            this.form1PortPanel.Controls.Add(this.dataBitsLabel);
            this.form1PortPanel.Controls.Add(this.boudRadesLabel);
            this.form1PortPanel.Controls.Add(this.ComPortLabel);
            this.form1PortPanel.Controls.Add(this.stopBitcomboBox);
            this.form1PortPanel.Controls.Add(this.parityBitcomboBox);
            this.form1PortPanel.Controls.Add(this.dataBitsComboBox);
            this.form1PortPanel.Controls.Add(this.boudRadescomboBox);
            this.form1PortPanel.Controls.Add(this.comPortcomboBox);
            this.form1PortPanel.Enabled = false;
            this.form1PortPanel.Location = new System.Drawing.Point(0, 31);
            this.form1PortPanel.Name = "form1PortPanel";
            this.form1PortPanel.Size = new System.Drawing.Size(459, 426);
            this.form1PortPanel.TabIndex = 6;
            this.form1PortPanel.Visible = false;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Silver;
            this.refreshButton.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refreshButton.Location = new System.Drawing.Point(291, 171);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 35);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // portStateLabel
            // 
            this.portStateLabel.AutoSize = true;
            this.portStateLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portStateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.portStateLabel.Location = new System.Drawing.Point(11, 394);
            this.portStateLabel.Name = "portStateLabel";
            this.portStateLabel.Size = new System.Drawing.Size(100, 24);
            this.portStateLabel.TabIndex = 6;
            this.portStateLabel.Text = "Port State";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Silver;
            this.applyButton.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.applyButton.Location = new System.Drawing.Point(352, 377);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(81, 34);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // portStateProgressBar
            // 
            this.portStateProgressBar.Location = new System.Drawing.Point(124, 394);
            this.portStateProgressBar.Name = "portStateProgressBar";
            this.portStateProgressBar.RightToLeftLayout = true;
            this.portStateProgressBar.Size = new System.Drawing.Size(152, 24);
            this.portStateProgressBar.TabIndex = 4;
            // 
            // portClose
            // 
            this.portClose.BackColor = System.Drawing.Color.Silver;
            this.portClose.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portClose.Location = new System.Drawing.Point(291, 115);
            this.portClose.Name = "portClose";
            this.portClose.Size = new System.Drawing.Size(75, 35);
            this.portClose.TabIndex = 3;
            this.portClose.Text = "Close Port";
            this.portClose.UseVisualStyleBackColor = false;
            this.portClose.Click += new System.EventHandler(this.portClose_Click);
            // 
            // portOpen
            // 
            this.portOpen.BackColor = System.Drawing.Color.Silver;
            this.portOpen.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portOpen.Location = new System.Drawing.Point(291, 52);
            this.portOpen.Name = "portOpen";
            this.portOpen.Size = new System.Drawing.Size(75, 35);
            this.portOpen.TabIndex = 3;
            this.portOpen.Text = "Open Port";
            this.portOpen.UseVisualStyleBackColor = false;
            this.portOpen.Click += new System.EventHandler(this.portOpen_Click);
            // 
            // stopBit
            // 
            this.stopBit.AutoSize = true;
            this.stopBit.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBit.ForeColor = System.Drawing.Color.DimGray;
            this.stopBit.Location = new System.Drawing.Point(15, 311);
            this.stopBit.Name = "stopBit";
            this.stopBit.Size = new System.Drawing.Size(81, 24);
            this.stopBit.TabIndex = 2;
            this.stopBit.Text = "Stop Bit";
            // 
            // parityBit
            // 
            this.parityBit.AutoSize = true;
            this.parityBit.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parityBit.ForeColor = System.Drawing.Color.DimGray;
            this.parityBit.Location = new System.Drawing.Point(15, 239);
            this.parityBit.Name = "parityBit";
            this.parityBit.Size = new System.Drawing.Size(93, 24);
            this.parityBit.TabIndex = 2;
            this.parityBit.Text = "Parity Bit";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataBitsLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dataBitsLabel.Location = new System.Drawing.Point(15, 171);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(89, 24);
            this.dataBitsLabel.TabIndex = 2;
            this.dataBitsLabel.Text = "Data Bits";
            // 
            // boudRadesLabel
            // 
            this.boudRadesLabel.AutoSize = true;
            this.boudRadesLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boudRadesLabel.ForeColor = System.Drawing.Color.DimGray;
            this.boudRadesLabel.Location = new System.Drawing.Point(5, 103);
            this.boudRadesLabel.Name = "boudRadesLabel";
            this.boudRadesLabel.Size = new System.Drawing.Size(106, 24);
            this.boudRadesLabel.TabIndex = 2;
            this.boudRadesLabel.Text = "BoudRades";
            // 
            // ComPortLabel
            // 
            this.ComPortLabel.AutoSize = true;
            this.ComPortLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComPortLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ComPortLabel.Location = new System.Drawing.Point(15, 42);
            this.ComPortLabel.Name = "ComPortLabel";
            this.ComPortLabel.Size = new System.Drawing.Size(94, 24);
            this.ComPortLabel.TabIndex = 2;
            this.ComPortLabel.Text = "ComPorts";
            // 
            // stopBitcomboBox
            // 
            this.stopBitcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitcomboBox.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBitcomboBox.FormattingEnabled = true;
            this.stopBitcomboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitcomboBox.Location = new System.Drawing.Point(124, 309);
            this.stopBitcomboBox.Name = "stopBitcomboBox";
            this.stopBitcomboBox.Size = new System.Drawing.Size(121, 30);
            this.stopBitcomboBox.TabIndex = 1;
            // 
            // parityBitcomboBox
            // 
            this.parityBitcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityBitcomboBox.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parityBitcomboBox.FormattingEnabled = true;
            this.parityBitcomboBox.Items.AddRange(new object[] {
            "None",
            "Even ",
            "Odd"});
            this.parityBitcomboBox.Location = new System.Drawing.Point(124, 237);
            this.parityBitcomboBox.Name = "parityBitcomboBox";
            this.parityBitcomboBox.Size = new System.Drawing.Size(121, 30);
            this.parityBitcomboBox.TabIndex = 1;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "8",
            "9"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(124, 169);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 30);
            this.dataBitsComboBox.TabIndex = 1;
            // 
            // boudRadescomboBox
            // 
            this.boudRadescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudRadescomboBox.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boudRadescomboBox.FormattingEnabled = true;
            this.boudRadescomboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "56000",
            "115200"});
            this.boudRadescomboBox.Location = new System.Drawing.Point(124, 105);
            this.boudRadescomboBox.Name = "boudRadescomboBox";
            this.boudRadescomboBox.Size = new System.Drawing.Size(121, 30);
            this.boudRadescomboBox.TabIndex = 0;
            this.boudRadescomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comPortcomboBox
            // 
            this.comPortcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortcomboBox.Font = new System.Drawing.Font("Roboto Condensed", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comPortcomboBox.FormattingEnabled = true;
            this.comPortcomboBox.Location = new System.Drawing.Point(124, 44);
            this.comPortcomboBox.Name = "comPortcomboBox";
            this.comPortcomboBox.Size = new System.Drawing.Size(121, 30);
            this.comPortcomboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortsToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // serialPortsToolStripMenuItem
            // 
            this.serialPortsToolStripMenuItem.Enabled = false;
            this.serialPortsToolStripMenuItem.Name = "serialPortsToolStripMenuItem";
            this.serialPortsToolStripMenuItem.Size = new System.Drawing.Size(323, 28);
            this.serialPortsToolStripMenuItem.Text = "Serial Port Configurations";
            this.serialPortsToolStripMenuItem.Click += new System.EventHandler(this.serialPortsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // resultToolStripMenuItem
            // 
            this.resultToolStripMenuItem.Enabled = false;
            this.resultToolStripMenuItem.Name = "resultToolStripMenuItem";
            this.resultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.resultToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.resultToolStripMenuItem.Text = "Information Data";
            this.resultToolStripMenuItem.Click += new System.EventHandler(this.resultToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.End)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(304, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(73, 28);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(147, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 1440;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.Control;
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.Location = new System.Drawing.Point(752, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(2, 38);
            this.time.TabIndex = 9;
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.time);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1073, 916);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 916);
            this.Controls.Add(this.form1PortPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.formMain2Panel);
            this.Controls.Add(this.mainPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1091, 963);
            this.MinimumSize = new System.Drawing.Size(1086, 963);
            this.Name = "Form1";
            this.Text = "Oximeter Monitor";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.max30102RawChart)).EndInit();
            this.formMain2Panel.ResumeLayout(false);
            this.formMain2Panel.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exampleSamplePictureBox)).EndInit();
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDay)).EndInit();
            this.form1PortPanel.ResumeLayout(false);
            this.form1PortPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart max30102RawChart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Panel form1PortPanel;
        private System.Windows.Forms.Label stopBit;
        private System.Windows.Forms.Label parityBit;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label boudRadesLabel;
        private System.Windows.Forms.Label ComPortLabel;
        private System.Windows.Forms.ComboBox stopBitcomboBox;
        private System.Windows.Forms.ComboBox parityBitcomboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox boudRadescomboBox;
        private System.Windows.Forms.ComboBox comPortcomboBox;
        private System.Windows.Forms.Button portClose;
        private System.Windows.Forms.Button portOpen;
        private System.Windows.Forms.Button getSampleButton;
        private System.Windows.Forms.ProgressBar portStateProgressBar;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label calculationLabel;
        private System.Windows.Forms.ProgressBar calculationProgressBar;
        private System.Windows.Forms.Label portStateLabel;
        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Label patianStoryLabel;
        private System.Windows.Forms.TextBox patientStory;
        private System.Windows.Forms.TextBox hesCode;
        private System.Windows.Forms.Label hesCodeLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.NumericUpDown numericMonth;
        private System.Windows.Forms.NumericUpDown numericDay;
        private System.Windows.Forms.TextBox idNumber;
        private System.Windows.Forms.TextBox fullName;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label hrResultLabel;
        private System.Windows.Forms.Label hrLabel;
        private System.Windows.Forms.Label spo2Label;
        private System.Windows.Forms.Label spoResultLabel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer5;
        public System.Windows.Forms.ToolStripMenuItem resultToolStripMenuItem;
        public System.Windows.Forms.Panel formMain2Panel;
        public System.Windows.Forms.ToolStripMenuItem serialPortsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.PictureBox exampleSamplePictureBox;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label ganderLabel;
    }
}

