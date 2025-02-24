using System.Linq;

namespace nAudioTest
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
        private System.Windows.Forms.CheckBox[] cbNoiseArray;
        private void InitializeCheckBoxes()
{
    cbNoiseArray = new System.Windows.Forms.CheckBox[8];

    for (int i = 0; i < cbNoiseArray.Length; i++)
    {
        cbNoiseArray[i] = new System.Windows.Forms.CheckBox();
        // Add any additional initialization logic here if needed
    }
}
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("6");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("7");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("8");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.vsInput1 = new NAudio.Gui.VolumeSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vsInput2 = new NAudio.Gui.VolumeSlider();
            this.vsInput3 = new NAudio.Gui.VolumeSlider();
            this.vsInput4 = new NAudio.Gui.VolumeSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.rbPreset3 = new System.Windows.Forms.RadioButton();
            this.rbPreset2 = new System.Windows.Forms.RadioButton();
            this.rbPreset1 = new System.Windows.Forms.RadioButton();
            this.tbPath14 = new System.Windows.Forms.TextBox();
            this.tbPath3 = new System.Windows.Forms.TextBox();
            this.tbPath2 = new System.Windows.Forms.TextBox();
            this.tbPath1 = new System.Windows.Forms.TextBox();
            this.btnSel4 = new System.Windows.Forms.Button();
            this.btnSel3 = new System.Windows.Forms.Button();
            this.btnSel2 = new System.Windows.Forms.Button();
            this.btnSel1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_Random = new System.Windows.Forms.Panel();
            this.lv_Random = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Random = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTestFolderOpen = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.vsInput6 = new NAudio.Gui.VolumeSlider();
            this.vsInput5 = new NAudio.Gui.VolumeSlider();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbPreset = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.tbSource = new System.Windows.Forms.TabControl();
            this.tpSource = new System.Windows.Forms.TabPage();
            this.tpLine = new System.Windows.Forms.TabPage();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.cbChSel = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.vsCH8 = new NAudio.Gui.VolumeSlider();
            this.vsCH7 = new NAudio.Gui.VolumeSlider();
            this.vsCH6 = new NAudio.Gui.VolumeSlider();
            this.vsCH5 = new NAudio.Gui.VolumeSlider();
            this.vsCH4 = new NAudio.Gui.VolumeSlider();
            this.vsCH3 = new NAudio.Gui.VolumeSlider();
            this.vsCH2 = new NAudio.Gui.VolumeSlider();
            this.vsCH1 = new NAudio.Gui.VolumeSlider();
            this.lbTestFolderPath = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLineInput = new System.Windows.Forms.ComboBox();
            this.cb_allRandom = new System.Windows.Forms.CheckBox();
            this.cb_clockwise = new System.Windows.Forms.CheckBox();
            this.gb_routineCount = new System.Windows.Forms.GroupBox();
            this.tb_RoutineCount = new System.Windows.Forms.TextBox();
            this.lb_routineCount = new System.Windows.Forms.Label();
            this.gb_stimulationTime = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_StimulationTimeWait = new System.Windows.Forms.TextBox();
            this.tb_StimulationTime = new System.Windows.Forms.TextBox();
            this.lb_stimulationTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_testtime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbOption = new System.Windows.Forms.GroupBox();
            this.gbSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pn_Random.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.gbMode.SuspendLayout();
            this.tbSource.SuspendLayout();
            this.tpSource.SuspendLayout();
            this.tpLine.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.gb_routineCount.SuspendLayout();
            this.gb_stimulationTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox9.Location = new System.Drawing.Point(5, 126);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(105, 20);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "Source.B";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox11.Location = new System.Drawing.Point(5, 126);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(105, 20);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "Source.B";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox15.Location = new System.Drawing.Point(5, 126);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(105, 20);
            this.checkBox15.TabIndex = 5;
            this.checkBox15.Text = "Source.B";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox17.Location = new System.Drawing.Point(5, 155);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(107, 20);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "Source.C";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox19.Location = new System.Drawing.Point(5, 155);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(107, 20);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "Source.C";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox23.Location = new System.Drawing.Point(5, 155);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(107, 20);
            this.checkBox23.TabIndex = 5;
            this.checkBox23.Text = "Source.C";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox25.Location = new System.Drawing.Point(5, 184);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(106, 20);
            this.checkBox25.TabIndex = 1;
            this.checkBox25.Text = "Source.D";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox27.Location = new System.Drawing.Point(5, 184);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(106, 20);
            this.checkBox27.TabIndex = 2;
            this.checkBox27.Text = "Source.D";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox31.Location = new System.Drawing.Point(5, 184);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(106, 20);
            this.checkBox31.TabIndex = 5;
            this.checkBox31.Text = "Source.D";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // vsInput1
            // 
            this.vsInput1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsInput1.Location = new System.Drawing.Point(188, 25);
            this.vsInput1.Name = "vsInput1";
            this.vsInput1.Size = new System.Drawing.Size(259, 25);
            this.vsInput1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 8);
            this.progressBar1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 20);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // vsInput2
            // 
            this.vsInput2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsInput2.Location = new System.Drawing.Point(188, 56);
            this.vsInput2.Name = "vsInput2";
            this.vsInput2.Size = new System.Drawing.Size(259, 25);
            this.vsInput2.TabIndex = 24;
            // 
            // vsInput3
            // 
            this.vsInput3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsInput3.Location = new System.Drawing.Point(188, 87);
            this.vsInput3.Name = "vsInput3";
            this.vsInput3.Size = new System.Drawing.Size(259, 25);
            this.vsInput3.TabIndex = 25;
            // 
            // vsInput4
            // 
            this.vsInput4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsInput4.Location = new System.Drawing.Point(188, 118);
            this.vsInput4.Name = "vsInput4";
            this.vsInput4.Size = new System.Drawing.Size(259, 25);
            this.vsInput4.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "출력장치 선택";
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.label11);
            this.gbSetting.Controls.Add(this.label10);
            this.gbSetting.Controls.Add(this.label9);
            this.gbSetting.Controls.Add(this.label8);
            this.gbSetting.Controls.Add(this.vsInput4);
            this.gbSetting.Controls.Add(this.vsInput3);
            this.gbSetting.Controls.Add(this.progressBar4);
            this.gbSetting.Controls.Add(this.progressBar3);
            this.gbSetting.Controls.Add(this.vsInput2);
            this.gbSetting.Controls.Add(this.progressBar2);
            this.gbSetting.Controls.Add(this.vsInput1);
            this.gbSetting.Controls.Add(this.progressBar1);
            this.gbSetting.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.gbSetting.Location = new System.Drawing.Point(6, 184);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(453, 156);
            this.gbSetting.TabIndex = 28;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "input dB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label11.Location = new System.Drawing.Point(59, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 47;
            this.label11.Text = "Source.D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label10.Location = new System.Drawing.Point(59, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "Source.C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label9.Location = new System.Drawing.Point(59, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 12);
            this.label9.TabIndex = 47;
            this.label9.Text = "Source.B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label8.Location = new System.Drawing.Point(59, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "Source.A";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 135);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(176, 8);
            this.progressBar4.TabIndex = 30;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 104);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(176, 8);
            this.progressBar3.TabIndex = 29;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 73);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(176, 8);
            this.progressBar2.TabIndex = 28;
            // 
            // cbStart
            // 
            this.cbStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbStart.BackColor = System.Drawing.Color.PaleGreen;
            this.cbStart.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStart.Location = new System.Drawing.Point(775, 675);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(464, 66);
            this.cbStart.TabIndex = 43;
            this.cbStart.Text = "TEST START";
            this.cbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStart.UseVisualStyleBackColor = false;
            this.cbStart.CheckedChanged += new System.EventHandler(this.cbStart_CheckedChanged);
            // 
            // rbPreset3
            // 
            this.rbPreset3.AutoSize = true;
            this.rbPreset3.Enabled = false;
            this.rbPreset3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.rbPreset3.Location = new System.Drawing.Point(214, 25);
            this.rbPreset3.Name = "rbPreset3";
            this.rbPreset3.Size = new System.Drawing.Size(97, 16);
            this.rbPreset3.TabIndex = 41;
            this.rbPreset3.Text = "preset #3";
            this.rbPreset3.UseVisualStyleBackColor = true;
            // 
            // rbPreset2
            // 
            this.rbPreset2.AutoSize = true;
            this.rbPreset2.Enabled = false;
            this.rbPreset2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.rbPreset2.Location = new System.Drawing.Point(111, 25);
            this.rbPreset2.Name = "rbPreset2";
            this.rbPreset2.Size = new System.Drawing.Size(97, 16);
            this.rbPreset2.TabIndex = 40;
            this.rbPreset2.Text = "preset #2";
            this.rbPreset2.UseVisualStyleBackColor = true;
            // 
            // rbPreset1
            // 
            this.rbPreset1.AutoSize = true;
            this.rbPreset1.Enabled = false;
            this.rbPreset1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.rbPreset1.Location = new System.Drawing.Point(8, 25);
            this.rbPreset1.Name = "rbPreset1";
            this.rbPreset1.Size = new System.Drawing.Size(97, 16);
            this.rbPreset1.TabIndex = 39;
            this.rbPreset1.Text = "preset #1";
            this.rbPreset1.UseVisualStyleBackColor = true;
            // 
            // tbPath14
            // 
            this.tbPath14.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.tbPath14.Location = new System.Drawing.Point(83, 132);
            this.tbPath14.Name = "tbPath14";
            this.tbPath14.Size = new System.Drawing.Size(302, 21);
            this.tbPath14.TabIndex = 38;
            // 
            // tbPath3
            // 
            this.tbPath3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.tbPath3.Location = new System.Drawing.Point(83, 105);
            this.tbPath3.Name = "tbPath3";
            this.tbPath3.Size = new System.Drawing.Size(302, 21);
            this.tbPath3.TabIndex = 37;
            // 
            // tbPath2
            // 
            this.tbPath2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.tbPath2.Location = new System.Drawing.Point(83, 78);
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.Size = new System.Drawing.Size(302, 21);
            this.tbPath2.TabIndex = 36;
            // 
            // tbPath1
            // 
            this.tbPath1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.tbPath1.Location = new System.Drawing.Point(83, 51);
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.Size = new System.Drawing.Size(302, 21);
            this.tbPath1.TabIndex = 35;
            // 
            // btnSel4
            // 
            this.btnSel4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSel4.Location = new System.Drawing.Point(391, 132);
            this.btnSel4.Name = "btnSel4";
            this.btnSel4.Size = new System.Drawing.Size(56, 23);
            this.btnSel4.TabIndex = 34;
            this.btnSel4.Text = "open";
            this.btnSel4.UseVisualStyleBackColor = true;
            // 
            // btnSel3
            // 
            this.btnSel3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSel3.Location = new System.Drawing.Point(391, 104);
            this.btnSel3.Name = "btnSel3";
            this.btnSel3.Size = new System.Drawing.Size(56, 23);
            this.btnSel3.TabIndex = 33;
            this.btnSel3.Text = "open";
            this.btnSel3.UseVisualStyleBackColor = true;
            // 
            // btnSel2
            // 
            this.btnSel2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSel2.Location = new System.Drawing.Point(391, 78);
            this.btnSel2.Name = "btnSel2";
            this.btnSel2.Size = new System.Drawing.Size(56, 23);
            this.btnSel2.TabIndex = 32;
            this.btnSel2.Text = "open";
            this.btnSel2.UseVisualStyleBackColor = true;
            // 
            // btnSel1
            // 
            this.btnSel1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSel1.Location = new System.Drawing.Point(391, 51);
            this.btnSel1.Name = "btnSel1";
            this.btnSel1.Size = new System.Drawing.Size(56, 23);
            this.btnSel1.TabIndex = 31;
            this.btnSel1.Text = "open";
            this.btnSel1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rbPreset1);
            this.groupBox2.Controls.Add(this.btnSel1);
            this.groupBox2.Controls.Add(this.rbPreset3);
            this.groupBox2.Controls.Add(this.btnSel2);
            this.groupBox2.Controls.Add(this.rbPreset2);
            this.groupBox2.Controls.Add(this.btnSel3);
            this.groupBox2.Controls.Add(this.btnSel4);
            this.groupBox2.Controls.Add(this.tbPath14);
            this.groupBox2.Controls.Add(this.tbPath1);
            this.groupBox2.Controls.Add(this.tbPath3);
            this.groupBox2.Controls.Add(this.tbPath2);
            this.groupBox2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 172);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(373, 22);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "Source.D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "Source.C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "Source.B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "Source.A";
            // 
            // pn_Random
            // 
            this.pn_Random.Controls.Add(this.lv_Random);
            this.pn_Random.Controls.Add(this.lb_Random);
            this.pn_Random.Location = new System.Drawing.Point(1248, 43);
            this.pn_Random.Name = "pn_Random";
            this.pn_Random.Size = new System.Drawing.Size(107, 607);
            this.pn_Random.TabIndex = 78;
            // 
            // lv_Random
            // 
            this.lv_Random.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lv_Random.Cursor = System.Windows.Forms.Cursors.Default;
            this.lv_Random.Font = new System.Drawing.Font("새굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_Random.GridLines = true;
            this.lv_Random.HideSelection = false;
            this.lv_Random.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.lv_Random.Location = new System.Drawing.Point(28, 60);
            this.lv_Random.MultiSelect = false;
            this.lv_Random.Name = "lv_Random";
            this.lv_Random.Scrollable = false;
            this.lv_Random.Size = new System.Drawing.Size(46, 520);
            this.lv_Random.TabIndex = 67;
            this.lv_Random.UseCompatibleStateImageBehavior = false;
            this.lv_Random.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 80;
            // 
            // lb_Random
            // 
            this.lb_Random.AutoSize = true;
            this.lb_Random.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_Random.Location = new System.Drawing.Point(3, 9);
            this.lb_Random.Name = "lb_Random";
            this.lb_Random.Size = new System.Drawing.Size(102, 42);
            this.lb_Random.TabIndex = 55;
            this.lb_Random.Text = "Random\r\nOrder\r\n";
            this.lb_Random.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox25);
            this.groupBox10.Controls.Add(this.checkBox17);
            this.groupBox10.Controls.Add(this.checkBox9);
            this.groupBox10.Controls.Add(this.checkBox1);
            this.groupBox10.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox10.Location = new System.Drawing.Point(332, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(112, 212);
            this.groupBox10.TabIndex = 30;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "CH1";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackgroundImage = global::nAudioTest.Properties.Resources.spkOff;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 100);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox27);
            this.groupBox4.Controls.Add(this.checkBox19);
            this.groupBox4.Controls.Add(this.checkBox11);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox4.Location = new System.Drawing.Point(657, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 212);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CH3";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox3.BackgroundImage")));
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox3.Location = new System.Drawing.Point(6, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(100, 100);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox31);
            this.groupBox8.Controls.Add(this.checkBox23);
            this.groupBox8.Controls.Add(this.checkBox15);
            this.groupBox8.Controls.Add(this.checkBox7);
            this.groupBox8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox8.Location = new System.Drawing.Point(10, 384);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(112, 212);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "CH7";
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox7.BackgroundImage")));
            this.checkBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox7.Location = new System.Drawing.Point(6, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(100, 100);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "\r\n";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox32);
            this.groupBox9.Controls.Add(this.checkBox24);
            this.groupBox9.Controls.Add(this.checkBox16);
            this.groupBox9.Controls.Add(this.checkBox8);
            this.groupBox9.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox9.Location = new System.Drawing.Point(42, 140);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(112, 212);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "CH8";
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox32.Location = new System.Drawing.Point(5, 184);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(106, 20);
            this.checkBox32.TabIndex = 4;
            this.checkBox32.Text = "Source.D";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox24.Location = new System.Drawing.Point(5, 155);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(107, 20);
            this.checkBox24.TabIndex = 4;
            this.checkBox24.Text = "Source.C";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox16.Location = new System.Drawing.Point(5, 126);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(105, 20);
            this.checkBox16.TabIndex = 4;
            this.checkBox16.Text = "Source.B";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox8.BackgroundImage")));
            this.checkBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox8.Location = new System.Drawing.Point(6, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(100, 100);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "\r\n";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox28);
            this.groupBox5.Controls.Add(this.checkBox20);
            this.groupBox5.Controls.Add(this.checkBox12);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox5.Location = new System.Drawing.Point(624, 628);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 212);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CH4";
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox28.Location = new System.Drawing.Point(5, 184);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(106, 20);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Text = "Source.D";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox20.Location = new System.Drawing.Point(5, 155);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(107, 20);
            this.checkBox20.TabIndex = 6;
            this.checkBox20.Text = "Source.C";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox12.Location = new System.Drawing.Point(5, 126);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(105, 20);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Source.B";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox4.BackgroundImage")));
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox4.Location = new System.Drawing.Point(6, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(100, 100);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "\r\n";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox21);
            this.groupBox6.Controls.Add(this.checkBox13);
            this.groupBox6.Controls.Add(this.checkBox29);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox6.Location = new System.Drawing.Point(332, 777);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(112, 212);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CH5";
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox21.Location = new System.Drawing.Point(5, 155);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(107, 20);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "Source.C";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox13.Location = new System.Drawing.Point(5, 126);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(105, 20);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Text = "Source.B";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox29.Location = new System.Drawing.Point(5, 184);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(106, 20);
            this.checkBox29.TabIndex = 8;
            this.checkBox29.Text = "Source.D";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox5.BackgroundImage")));
            this.checkBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox5.Location = new System.Drawing.Point(6, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 100);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "\r\n";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox26);
            this.groupBox3.Controls.Add(this.checkBox18);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox3.Location = new System.Drawing.Point(624, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 212);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CH2";
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox26.Location = new System.Drawing.Point(5, 183);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(106, 20);
            this.checkBox26.TabIndex = 7;
            this.checkBox26.Text = "Source.D";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox18.Location = new System.Drawing.Point(5, 155);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(107, 20);
            this.checkBox18.TabIndex = 7;
            this.checkBox18.Text = "Source.C";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 100);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox10.Location = new System.Drawing.Point(5, 126);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(105, 20);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Source.B";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox22);
            this.groupBox7.Controls.Add(this.checkBox14);
            this.groupBox7.Controls.Add(this.checkBox30);
            this.groupBox7.Controls.Add(this.checkBox6);
            this.groupBox7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.groupBox7.Location = new System.Drawing.Point(42, 628);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(112, 212);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CH6";
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox22.Location = new System.Drawing.Point(5, 155);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(107, 20);
            this.checkBox22.TabIndex = 3;
            this.checkBox22.Text = "Source.C";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox14.Location = new System.Drawing.Point(5, 126);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(105, 20);
            this.checkBox14.TabIndex = 3;
            this.checkBox14.Text = "Source.B";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.checkBox30.Location = new System.Drawing.Point(5, 184);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(106, 20);
            this.checkBox30.TabIndex = 3;
            this.checkBox30.Text = "Source.D";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox6.BackgroundImage")));
            this.checkBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox6.Location = new System.Drawing.Point(6, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(100, 100);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "\r\n";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::nAudioTest.Properties.Resources.programLogo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(905, 747);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 225);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::nAudioTest.Properties.Resources.back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnTestFolderOpen
            // 
            this.btnTestFolderOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTestFolderOpen.AutoSize = true;
            this.btnTestFolderOpen.Location = new System.Drawing.Point(116, 55);
            this.btnTestFolderOpen.Name = "btnTestFolderOpen";
            this.btnTestFolderOpen.Size = new System.Drawing.Size(51, 22);
            this.btnTestFolderOpen.TabIndex = 37;
            this.btnTestFolderOpen.Text = "open";
            this.btnTestFolderOpen.UseVisualStyleBackColor = true;
            this.btnTestFolderOpen.CheckedChanged += new System.EventHandler(this.btnTestFolderOpen_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.progressBar5);
            this.groupBox11.Controls.Add(this.progressBar6);
            this.groupBox11.Controls.Add(this.vsInput6);
            this.groupBox11.Controls.Add(this.vsInput5);
            this.groupBox11.Location = new System.Drawing.Point(9, 14);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(450, 104);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Line Input";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label22.Location = new System.Drawing.Point(59, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 12);
            this.label22.TabIndex = 50;
            this.label22.Text = "Source.B";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.label23.Location = new System.Drawing.Point(59, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 12);
            this.label23.TabIndex = 51;
            this.label23.Text = "Source.A";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(6, 75);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(176, 8);
            this.progressBar5.TabIndex = 49;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(6, 44);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(176, 8);
            this.progressBar6.TabIndex = 48;
            // 
            // vsInput6
            // 
            this.vsInput6.Location = new System.Drawing.Point(188, 60);
            this.vsInput6.Name = "vsInput6";
            this.vsInput6.Size = new System.Drawing.Size(259, 25);
            this.vsInput6.TabIndex = 31;
            // 
            // vsInput5
            // 
            this.vsInput5.Location = new System.Drawing.Point(188, 29);
            this.vsInput5.Name = "vsInput5";
            this.vsInput5.Size = new System.Drawing.Size(259, 25);
            this.vsInput5.TabIndex = 29;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbManual);
            this.gbMode.Controls.Add(this.rbPreset);
            this.gbMode.Controls.Add(this.rbRandom);
            this.gbMode.Controls.Add(this.rbSerial);
            this.gbMode.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.gbMode.Location = new System.Drawing.Point(775, 404);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(464, 56);
            this.gbMode.TabIndex = 49;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "MODE";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.rbManual.Location = new System.Drawing.Point(253, 26);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(86, 19);
            this.rbManual.TabIndex = 47;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbPreset
            // 
            this.rbPreset.AutoSize = true;
            this.rbPreset.Enabled = false;
            this.rbPreset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.rbPreset.Location = new System.Drawing.Point(377, 25);
            this.rbPreset.Name = "rbPreset";
            this.rbPreset.Size = new System.Drawing.Size(80, 19);
            this.rbPreset.TabIndex = 46;
            this.rbPreset.Text = "Preset";
            this.rbPreset.UseVisualStyleBackColor = true;
            this.rbPreset.CheckedChanged += new System.EventHandler(this.rbPreset_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.rbRandom.Location = new System.Drawing.Point(115, 25);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(90, 19);
            this.rbRandom.TabIndex = 45;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbRandom_CheckedChanged);
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Font = new System.Drawing.Font("휴먼둥근헤드라인", 10F);
            this.rbSerial.Location = new System.Drawing.Point(6, 26);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(74, 19);
            this.rbSerial.TabIndex = 44;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            this.rbSerial.CheckedChanged += new System.EventHandler(this.rbSerial_CheckedChanged);
            // 
            // tbSource
            // 
            this.tbSource.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tbSource.Controls.Add(this.tpSource);
            this.tbSource.Controls.Add(this.tpLine);
            this.tbSource.Controls.Add(this.tpSetting);
            this.tbSource.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.tbSource.Location = new System.Drawing.Point(769, 18);
            this.tbSource.Name = "tbSource";
            this.tbSource.SelectedIndex = 0;
            this.tbSource.Size = new System.Drawing.Size(473, 380);
            this.tbSource.TabIndex = 47;
            this.tbSource.TabStop = false;
            this.tbSource.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpSource
            // 
            this.tpSource.Controls.Add(this.groupBox2);
            this.tpSource.Controls.Add(this.gbSetting);
            this.tpSource.Location = new System.Drawing.Point(4, 25);
            this.tpSource.Name = "tpSource";
            this.tpSource.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSource.Size = new System.Drawing.Size(465, 351);
            this.tpSource.TabIndex = 0;
            this.tpSource.Text = "Source";
            this.tpSource.UseVisualStyleBackColor = true;
            // 
            // tpLine
            // 
            this.tpLine.Controls.Add(this.groupBox11);
            this.tpLine.Location = new System.Drawing.Point(4, 25);
            this.tpLine.Name = "tpLine";
            this.tpLine.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpLine.Size = new System.Drawing.Size(465, 351);
            this.tpLine.TabIndex = 1;
            this.tpLine.Text = "Line Input";
            this.tpLine.UseVisualStyleBackColor = true;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.label21);
            this.tpSetting.Controls.Add(this.cbChSel);
            this.tpSetting.Controls.Add(this.label20);
            this.tpSetting.Controls.Add(this.label19);
            this.tpSetting.Controls.Add(this.label18);
            this.tpSetting.Controls.Add(this.label17);
            this.tpSetting.Controls.Add(this.label16);
            this.tpSetting.Controls.Add(this.label15);
            this.tpSetting.Controls.Add(this.label14);
            this.tpSetting.Controls.Add(this.label13);
            this.tpSetting.Controls.Add(this.vsCH8);
            this.tpSetting.Controls.Add(this.vsCH7);
            this.tpSetting.Controls.Add(this.vsCH6);
            this.tpSetting.Controls.Add(this.vsCH5);
            this.tpSetting.Controls.Add(this.vsCH4);
            this.tpSetting.Controls.Add(this.vsCH3);
            this.tpSetting.Controls.Add(this.vsCH2);
            this.tpSetting.Controls.Add(this.vsCH1);
            this.tpSetting.Controls.Add(this.lbTestFolderPath);
            this.tpSetting.Controls.Add(this.label12);
            this.tpSetting.Controls.Add(this.label6);
            this.tpSetting.Controls.Add(this.cbLineInput);
            this.tpSetting.Controls.Add(this.label1);
            this.tpSetting.Controls.Add(this.btnTestFolderOpen);
            this.tpSetting.Controls.Add(this.comboBox1);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Size = new System.Drawing.Size(465, 351);
            this.tpSetting.TabIndex = 2;
            this.tpSetting.Text = "Setting";
            this.tpSetting.UseVisualStyleBackColor = true;
            this.tpSetting.Click += new System.EventHandler(this.tpSetting_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(321, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 59;
            this.label21.Text = "채널 선택";
            // 
            // cbChSel
            // 
            this.cbChSel.FormattingEnabled = true;
            this.cbChSel.Items.AddRange(new object[] {
            "4",
            "5",
            "8"});
            this.cbChSel.Location = new System.Drawing.Point(386, 97);
            this.cbChSel.Name = "cbChSel";
            this.cbChSel.Size = new System.Drawing.Size(41, 20);
            this.cbChSel.TabIndex = 58;
            this.cbChSel.Text = "8";
            this.cbChSel.SelectedIndexChanged += new System.EventHandler(this.cbChSel_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 323);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 57;
            this.label20.Text = "SPK.CH8";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 292);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 56;
            this.label19.Text = "SPK.CH7";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 55;
            this.label18.Text = "SPK.CH6";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 54;
            this.label17.Text = "SPK.CH5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 53;
            this.label16.Text = "SPK.CH4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 52;
            this.label15.Text = "SPK.CH3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 51;
            this.label14.Text = "SPK.CH2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 50;
            this.label13.Text = "SPK.CH1";
            // 
            // vsCH8
            // 
            this.vsCH8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH8.Location = new System.Drawing.Point(98, 317);
            this.vsCH8.Name = "vsCH8";
            this.vsCH8.Size = new System.Drawing.Size(177, 25);
            this.vsCH8.TabIndex = 49;
            // 
            // vsCH7
            // 
            this.vsCH7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH7.Location = new System.Drawing.Point(98, 286);
            this.vsCH7.Name = "vsCH7";
            this.vsCH7.Size = new System.Drawing.Size(177, 25);
            this.vsCH7.TabIndex = 48;
            // 
            // vsCH6
            // 
            this.vsCH6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH6.Location = new System.Drawing.Point(98, 255);
            this.vsCH6.Name = "vsCH6";
            this.vsCH6.Size = new System.Drawing.Size(177, 25);
            this.vsCH6.TabIndex = 47;
            // 
            // vsCH5
            // 
            this.vsCH5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH5.Location = new System.Drawing.Point(98, 224);
            this.vsCH5.Name = "vsCH5";
            this.vsCH5.Size = new System.Drawing.Size(177, 25);
            this.vsCH5.TabIndex = 46;
            // 
            // vsCH4
            // 
            this.vsCH4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH4.Location = new System.Drawing.Point(98, 193);
            this.vsCH4.Name = "vsCH4";
            this.vsCH4.Size = new System.Drawing.Size(177, 25);
            this.vsCH4.TabIndex = 45;
            // 
            // vsCH3
            // 
            this.vsCH3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH3.Location = new System.Drawing.Point(98, 162);
            this.vsCH3.Name = "vsCH3";
            this.vsCH3.Size = new System.Drawing.Size(177, 25);
            this.vsCH3.TabIndex = 44;
            // 
            // vsCH2
            // 
            this.vsCH2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH2.Location = new System.Drawing.Point(98, 131);
            this.vsCH2.Name = "vsCH2";
            this.vsCH2.Size = new System.Drawing.Size(177, 25);
            this.vsCH2.TabIndex = 43;
            // 
            // vsCH1
            // 
            this.vsCH1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.vsCH1.Location = new System.Drawing.Point(98, 100);
            this.vsCH1.Name = "vsCH1";
            this.vsCH1.Size = new System.Drawing.Size(177, 25);
            this.vsCH1.TabIndex = 42;
            // 
            // lbTestFolderPath
            // 
            this.lbTestFolderPath.AutoSize = true;
            this.lbTestFolderPath.Font = new System.Drawing.Font("휴먼둥근헤드라인", 7F);
            this.lbTestFolderPath.Location = new System.Drawing.Point(6, 78);
            this.lbTestFolderPath.Name = "lbTestFolderPath";
            this.lbTestFolderPath.Size = new System.Drawing.Size(60, 11);
            this.lbTestFolderPath.TabIndex = 41;
            this.lbTestFolderPath.Text = "TEST 폴더";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 12);
            this.label12.TabIndex = 40;
            this.label12.Text = "TEST 폴더 경로:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "입력장치 선택";
            // 
            // cbLineInput
            // 
            this.cbLineInput.FormattingEnabled = true;
            this.cbLineInput.Location = new System.Drawing.Point(241, 30);
            this.cbLineInput.Name = "cbLineInput";
            this.cbLineInput.Size = new System.Drawing.Size(218, 20);
            this.cbLineInput.TabIndex = 38;
            this.cbLineInput.SelectedIndexChanged += new System.EventHandler(this.cbLineInput_SelectedIndexChanged);
            this.cbLineInput.Click += new System.EventHandler(this.cbLineInput_Click);
            // 
            // cb_allRandom
            // 
            this.cb_allRandom.AutoSize = true;
            this.cb_allRandom.Checked = true;
            this.cb_allRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_allRandom.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_allRandom.Location = new System.Drawing.Point(125, 25);
            this.cb_allRandom.Name = "cb_allRandom";
            this.cb_allRandom.Size = new System.Drawing.Size(115, 17);
            this.cb_allRandom.TabIndex = 73;
            this.cb_allRandom.Text = "All Random";
            this.cb_allRandom.UseVisualStyleBackColor = true;
            this.cb_allRandom.CheckedChanged += new System.EventHandler(this.cb_allRandom_CheckedChanged);
            // 
            // cb_clockwise
            // 
            this.cb_clockwise.AutoSize = true;
            this.cb_clockwise.Checked = true;
            this.cb_clockwise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_clockwise.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cb_clockwise.Location = new System.Drawing.Point(6, 25);
            this.cb_clockwise.Name = "cb_clockwise";
            this.cb_clockwise.Size = new System.Drawing.Size(113, 17);
            this.cb_clockwise.TabIndex = 72;
            this.cb_clockwise.Text = "Clock Wise";
            this.cb_clockwise.UseVisualStyleBackColor = true;
            // 
            // gb_routineCount
            // 
            this.gb_routineCount.AutoSize = true;
            this.gb_routineCount.Controls.Add(this.tb_RoutineCount);
            this.gb_routineCount.Controls.Add(this.lb_routineCount);
            this.gb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.gb_routineCount.Location = new System.Drawing.Point(775, 576);
            this.gb_routineCount.Name = "gb_routineCount";
            this.gb_routineCount.Size = new System.Drawing.Size(190, 93);
            this.gb_routineCount.TabIndex = 71;
            this.gb_routineCount.TabStop = false;
            this.gb_routineCount.Text = "Routine Count";
            // 
            // tb_RoutineCount
            // 
            this.tb_RoutineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F);
            this.tb_RoutineCount.Location = new System.Drawing.Point(82, 33);
            this.tb_RoutineCount.Name = "tb_RoutineCount";
            this.tb_RoutineCount.Size = new System.Drawing.Size(32, 35);
            this.tb_RoutineCount.TabIndex = 44;
            this.tb_RoutineCount.Text = "2";
            this.tb_RoutineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_routineCount
            // 
            this.lb_routineCount.AutoSize = true;
            this.lb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20F);
            this.lb_routineCount.Location = new System.Drawing.Point(76, 19);
            this.lb_routineCount.Name = "lb_routineCount";
            this.lb_routineCount.Size = new System.Drawing.Size(0, 28);
            this.lb_routineCount.TabIndex = 41;
            // 
            // gb_stimulationTime
            // 
            this.gb_stimulationTime.AutoSize = true;
            this.gb_stimulationTime.Controls.Add(this.label7);
            this.gb_stimulationTime.Controls.Add(this.tb_StimulationTimeWait);
            this.gb_stimulationTime.Controls.Add(this.tb_StimulationTime);
            this.gb_stimulationTime.Controls.Add(this.lb_stimulationTime);
            this.gb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.gb_stimulationTime.Location = new System.Drawing.Point(775, 475);
            this.gb_stimulationTime.Name = "gb_stimulationTime";
            this.gb_stimulationTime.Size = new System.Drawing.Size(190, 93);
            this.gb_stimulationTime.TabIndex = 70;
            this.gb_stimulationTime.TabStop = false;
            this.gb_stimulationTime.Text = "Stimulation Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20F);
            this.label7.Location = new System.Drawing.Point(90, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 28);
            this.label7.TabIndex = 43;
            this.label7.Text = "/";
            // 
            // tb_StimulationTimeWait
            // 
            this.tb_StimulationTimeWait.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F);
            this.tb_StimulationTimeWait.Location = new System.Drawing.Point(119, 33);
            this.tb_StimulationTimeWait.Name = "tb_StimulationTimeWait";
            this.tb_StimulationTimeWait.Size = new System.Drawing.Size(32, 35);
            this.tb_StimulationTimeWait.TabIndex = 42;
            this.tb_StimulationTimeWait.Text = "2";
            this.tb_StimulationTimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_StimulationTimeWait.TextChanged += new System.EventHandler(this.tb_StimulationTimeWait_TextChanged);
            // 
            // tb_StimulationTime
            // 
            this.tb_StimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F);
            this.tb_StimulationTime.Location = new System.Drawing.Point(52, 33);
            this.tb_StimulationTime.Name = "tb_StimulationTime";
            this.tb_StimulationTime.Size = new System.Drawing.Size(32, 35);
            this.tb_StimulationTime.TabIndex = 41;
            this.tb_StimulationTime.Text = "1";
            this.tb_StimulationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_StimulationTime.TextChanged += new System.EventHandler(this.tb_StimulationTime_TextChanged);
            // 
            // lb_stimulationTime
            // 
            this.lb_stimulationTime.AutoSize = true;
            this.lb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_stimulationTime.Location = new System.Drawing.Point(72, 38);
            this.lb_stimulationTime.Name = "lb_stimulationTime";
            this.lb_stimulationTime.Size = new System.Drawing.Size(0, 21);
            this.lb_stimulationTime.TabIndex = 40;
            this.lb_stimulationTime.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(773, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 3);
            this.panel4.TabIndex = 74;
            // 
            // lb_testtime
            // 
            this.lb_testtime.AutoSize = true;
            this.lb_testtime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 52F);
            this.lb_testtime.Location = new System.Drawing.Point(6, 40);
            this.lb_testtime.Name = "lb_testtime";
            this.lb_testtime.Size = new System.Drawing.Size(257, 73);
            this.lb_testtime.TabIndex = 76;
            this.lb_testtime.Text = "00:00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_testtime);
            this.groupBox1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.groupBox1.Location = new System.Drawing.Point(971, 475);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 140);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Time";
            // 
            // gbOption
            // 
            this.gbOption.Controls.Add(this.cb_allRandom);
            this.gbOption.Controls.Add(this.cb_clockwise);
            this.gbOption.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.gbOption.Location = new System.Drawing.Point(971, 621);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(268, 48);
            this.gbOption.TabIndex = 79;
            this.gbOption.TabStop = false;
            this.gbOption.Text = "Option";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 979);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.pn_Random);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gb_routineCount);
            this.Controls.Add(this.gb_stimulationTime);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SHiNS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSetting.ResumeLayout(false);
            this.gbSetting.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pn_Random.ResumeLayout(false);
            this.pn_Random.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.tbSource.ResumeLayout(false);
            this.tpSource.ResumeLayout(false);
            this.tpLine.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.gb_routineCount.ResumeLayout(false);
            this.gb_routineCount.PerformLayout();
            this.gb_stimulationTime.ResumeLayout(false);
            this.gb_stimulationTime.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOption.ResumeLayout(false);
            this.gbOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox31;
        private NAudio.Gui.VolumeSlider vsInput1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private NAudio.Gui.VolumeSlider vsInput2;
        private NAudio.Gui.VolumeSlider vsInput3;
        private NAudio.Gui.VolumeSlider vsInput4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.TextBox tbPath2;
        private System.Windows.Forms.TextBox tbPath1;
        private System.Windows.Forms.Button btnSel4;
        private System.Windows.Forms.Button btnSel3;
        private System.Windows.Forms.Button btnSel2;
        private System.Windows.Forms.Button btnSel1;
        public System.Windows.Forms.ProgressBar progressBar4;
        public System.Windows.Forms.ProgressBar progressBar3;
        public System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox tbPath14;
        private System.Windows.Forms.TextBox tbPath3;
        private System.Windows.Forms.RadioButton rbPreset3;
        private System.Windows.Forms.RadioButton rbPreset2;
        private System.Windows.Forms.RadioButton rbPreset1;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox btnTestFolderOpen;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbPreset;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.TabControl tbSource;
        private System.Windows.Forms.TabPage tpSource;
        private System.Windows.Forms.TabPage tpLine;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLineInput;
        private NAudio.Gui.VolumeSlider vsInput6;
        private NAudio.Gui.VolumeSlider vsInput5;
        private System.Windows.Forms.CheckBox cb_allRandom;
        private System.Windows.Forms.CheckBox cb_clockwise;
        public System.Windows.Forms.GroupBox gb_routineCount;
        private System.Windows.Forms.TextBox tb_RoutineCount;
        public System.Windows.Forms.Label lb_routineCount;
        public System.Windows.Forms.GroupBox gb_stimulationTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_StimulationTimeWait;
        private System.Windows.Forms.TextBox tb_StimulationTime;
        public System.Windows.Forms.Label lb_stimulationTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTestFolderPath;
        private NAudio.Gui.VolumeSlider vsCH8;
        private NAudio.Gui.VolumeSlider vsCH7;
        private NAudio.Gui.VolumeSlider vsCH6;
        private NAudio.Gui.VolumeSlider vsCH5;
        private NAudio.Gui.VolumeSlider vsCH4;
        private NAudio.Gui.VolumeSlider vsCH3;
        private NAudio.Gui.VolumeSlider vsCH2;
        private NAudio.Gui.VolumeSlider vsCH1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_testtime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pn_Random;
        private System.Windows.Forms.ListView lv_Random;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lb_Random;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbChSel;
        private System.Windows.Forms.GroupBox gbOption;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ProgressBar progressBar5;
        public System.Windows.Forms.ProgressBar progressBar6;
    }
}

