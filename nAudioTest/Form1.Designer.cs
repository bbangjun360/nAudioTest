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
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.volumeSlider2 = new NAudio.Gui.VolumeSlider();
            this.volumeSlider3 = new NAudio.Gui.VolumeSlider();
            this.volumeSlider4 = new NAudio.Gui.VolumeSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetting = new System.Windows.Forms.GroupBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSel4 = new System.Windows.Forms.Button();
            this.btnSel3 = new System.Windows.Forms.Button();
            this.btnSel2 = new System.Windows.Forms.Button();
            this.btnSel1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.setup = new System.Windows.Forms.CheckBox();
            this.rbSource = new System.Windows.Forms.RadioButton();
            this.rbMic = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.volumeSlider5 = new NAudio.Gui.VolumeSlider();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.volumeSlider6 = new NAudio.Gui.VolumeSlider();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbPreset = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSource = new System.Windows.Forms.TabPage();
            this.tpLine = new System.Windows.Forms.TabPage();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLineInput = new System.Windows.Forms.ComboBox();
            this.cb_allRandom = new System.Windows.Forms.CheckBox();
            this.cb_clockwise = new System.Windows.Forms.CheckBox();
            this.gb_routineCount = new System.Windows.Forms.GroupBox();
            this.tb_form1RoutineCount = new System.Windows.Forms.TextBox();
            this.lb_routineCount = new System.Windows.Forms.Label();
            this.gb_stimulationTime = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_form1StimulationTimeWait = new System.Windows.Forms.TextBox();
            this.tb_form1StimulationTime = new System.Windows.Forms.TextBox();
            this.lb_stimulationTime = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbSetting.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSource.SuspendLayout();
            this.tpLine.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.gb_routineCount.SuspendLayout();
            this.gb_stimulationTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox9.Location = new System.Drawing.Point(5, 126);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(111, 23);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "Source.B";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox11.Location = new System.Drawing.Point(5, 126);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(111, 23);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "Source.B";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox15.Location = new System.Drawing.Point(5, 126);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(111, 23);
            this.checkBox15.TabIndex = 5;
            this.checkBox15.Text = "Source.B";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox17.Location = new System.Drawing.Point(5, 155);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(112, 23);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "Source.C";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox19.Location = new System.Drawing.Point(5, 155);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(112, 23);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "Source.C";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox23.Location = new System.Drawing.Point(5, 155);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(112, 23);
            this.checkBox23.TabIndex = 5;
            this.checkBox23.Text = "Source.C";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkBox25.Location = new System.Drawing.Point(5, 184);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(111, 23);
            this.checkBox25.TabIndex = 1;
            this.checkBox25.Text = "Source.D";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox27.Location = new System.Drawing.Point(5, 184);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(111, 23);
            this.checkBox27.TabIndex = 2;
            this.checkBox27.Text = "Source.D";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox31.Location = new System.Drawing.Point(5, 184);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(111, 23);
            this.checkBox31.TabIndex = 5;
            this.checkBox31.Text = "Source.D";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(358, 32);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // volumeSlider2
            // 
            this.volumeSlider2.Location = new System.Drawing.Point(358, 61);
            this.volumeSlider2.Name = "volumeSlider2";
            this.volumeSlider2.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider2.TabIndex = 24;
            // 
            // volumeSlider3
            // 
            this.volumeSlider3.Location = new System.Drawing.Point(358, 90);
            this.volumeSlider3.Name = "volumeSlider3";
            this.volumeSlider3.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider3.TabIndex = 25;
            // 
            // volumeSlider4
            // 
            this.volumeSlider4.Location = new System.Drawing.Point(358, 119);
            this.volumeSlider4.Name = "volumeSlider4";
            this.volumeSlider4.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider4.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "출력장치 선택";
            // 
            // gbSetting
            // 
            this.gbSetting.Controls.Add(this.volumeSlider4);
            this.gbSetting.Controls.Add(this.volumeSlider3);
            this.gbSetting.Controls.Add(this.progressBar4);
            this.gbSetting.Controls.Add(this.progressBar3);
            this.gbSetting.Controls.Add(this.volumeSlider2);
            this.gbSetting.Controls.Add(this.progressBar2);
            this.gbSetting.Controls.Add(this.volumeSlider1);
            this.gbSetting.Controls.Add(this.progressBar1);
            this.gbSetting.Location = new System.Drawing.Point(3, 214);
            this.gbSetting.Name = "gbSetting";
            this.gbSetting.Size = new System.Drawing.Size(460, 156);
            this.gbSetting.TabIndex = 28;
            this.gbSetting.TabStop = false;
            this.gbSetting.Text = "ＤＢ";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(12, 112);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(315, 23);
            this.progressBar4.TabIndex = 30;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(12, 83);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(315, 23);
            this.progressBar3.TabIndex = 29;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(12, 54);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(315, 23);
            this.progressBar2.TabIndex = 28;
            // 
            // cbStart
            // 
            this.cbStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbStart.BackColor = System.Drawing.Color.PaleGreen;
            this.cbStart.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStart.Location = new System.Drawing.Point(775, 579);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(455, 95);
            this.cbStart.TabIndex = 43;
            this.cbStart.Text = "TEST START";
            this.cbStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbStart.UseVisualStyleBackColor = false;
            this.cbStart.CheckedChanged += new System.EventHandler(this.cbStart_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(249, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 16);
            this.radioButton4.TabIndex = 42;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "프리셋 #4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(168, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 16);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "프리셋 #3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(87, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 16);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "프리셋 #2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 16);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "프리셋 #1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(306, 21);
            this.textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 21);
            this.textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 21);
            this.textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 21);
            this.textBox1.TabIndex = 35;
            // 
            // btnSel4
            // 
            this.btnSel4.Location = new System.Drawing.Point(379, 138);
            this.btnSel4.Name = "btnSel4";
            this.btnSel4.Size = new System.Drawing.Size(75, 23);
            this.btnSel4.TabIndex = 34;
            this.btnSel4.Text = "열기";
            this.btnSel4.UseVisualStyleBackColor = true;
            // 
            // btnSel3
            // 
            this.btnSel3.Location = new System.Drawing.Point(379, 109);
            this.btnSel3.Name = "btnSel3";
            this.btnSel3.Size = new System.Drawing.Size(75, 23);
            this.btnSel3.TabIndex = 33;
            this.btnSel3.Text = "열기";
            this.btnSel3.UseVisualStyleBackColor = true;
            // 
            // btnSel2
            // 
            this.btnSel2.Location = new System.Drawing.Point(379, 80);
            this.btnSel2.Name = "btnSel2";
            this.btnSel2.Size = new System.Drawing.Size(75, 23);
            this.btnSel2.TabIndex = 32;
            this.btnSel2.Text = "열기";
            this.btnSel2.UseVisualStyleBackColor = true;
            // 
            // btnSel1
            // 
            this.btnSel1.Location = new System.Drawing.Point(379, 51);
            this.btnSel1.Name = "btnSel1";
            this.btnSel1.Size = new System.Drawing.Size(75, 23);
            this.btnSel1.TabIndex = 31;
            this.btnSel1.Text = "열기";
            this.btnSel1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.btnSel1);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.btnSel2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.btnSel3);
            this.groupBox2.Controls.Add(this.btnSel4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 172);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 46;
            this.label5.Text = "Source.D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 45;
            this.label4.Text = "Source.C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 44;
            this.label3.Text = "Source.B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "Source.A";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox25);
            this.groupBox10.Controls.Add(this.checkBox17);
            this.groupBox10.Controls.Add(this.checkBox9);
            this.groupBox10.Controls.Add(this.checkBox1);
            this.groupBox10.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.groupBox8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.groupBox9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.checkBox32.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox32.Location = new System.Drawing.Point(5, 184);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(111, 23);
            this.checkBox32.TabIndex = 4;
            this.checkBox32.Text = "Source.D";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox24.Location = new System.Drawing.Point(5, 155);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(112, 23);
            this.checkBox24.TabIndex = 4;
            this.checkBox24.Text = "Source.C";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox16.Location = new System.Drawing.Point(5, 126);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(111, 23);
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
            this.checkBox28.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox28.Location = new System.Drawing.Point(5, 184);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(111, 23);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Text = "Source.D";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox20.Location = new System.Drawing.Point(5, 155);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(112, 23);
            this.checkBox20.TabIndex = 6;
            this.checkBox20.Text = "Source.C";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox12.Location = new System.Drawing.Point(5, 126);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(111, 23);
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
            this.checkBox21.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox21.Location = new System.Drawing.Point(5, 155);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(112, 23);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "Source.C";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox13.Location = new System.Drawing.Point(5, 126);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(111, 23);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Text = "Source.B";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox29.Location = new System.Drawing.Point(5, 184);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(111, 23);
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
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold);
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
            this.checkBox26.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox26.Location = new System.Drawing.Point(5, 183);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(111, 23);
            this.checkBox26.TabIndex = 7;
            this.checkBox26.Text = "Source.D";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox18.Location = new System.Drawing.Point(5, 155);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(112, 23);
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
            this.checkBox10.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox10.Location = new System.Drawing.Point(5, 126);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(111, 23);
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
            this.checkBox22.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox22.Location = new System.Drawing.Point(5, 155);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(112, 23);
            this.checkBox22.TabIndex = 3;
            this.checkBox22.Text = "Source.C";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox14.Location = new System.Drawing.Point(5, 126);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(111, 23);
            this.checkBox14.TabIndex = 3;
            this.checkBox14.Text = "Source.B";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold);
            this.checkBox30.Location = new System.Drawing.Point(5, 184);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(111, 23);
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
            this.pictureBox2.Location = new System.Drawing.Point(847, 700);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 284);
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
            // setup
            // 
            this.setup.Appearance = System.Windows.Forms.Appearance.Button;
            this.setup.AutoSize = true;
            this.setup.Location = new System.Drawing.Point(410, 29);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(46, 22);
            this.setup.TabIndex = 37;
            this.setup.Text = "setup";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.CheckedChanged += new System.EventHandler(this.setup_CheckedChanged);
            // 
            // rbSource
            // 
            this.rbSource.AutoSize = true;
            this.rbSource.Location = new System.Drawing.Point(3, 3);
            this.rbSource.Name = "rbSource";
            this.rbSource.Size = new System.Drawing.Size(59, 16);
            this.rbSource.TabIndex = 38;
            this.rbSource.Text = "Souce";
            this.rbSource.UseVisualStyleBackColor = true;
            this.rbSource.CheckedChanged += new System.EventHandler(this.rbSource_CheckedChanged);
            // 
            // rbMic
            // 
            this.rbMic.AutoSize = true;
            this.rbMic.Checked = true;
            this.rbMic.Location = new System.Drawing.Point(68, 3);
            this.rbMic.Name = "rbMic";
            this.rbMic.Size = new System.Drawing.Size(78, 16);
            this.rbMic.TabIndex = 39;
            this.rbMic.TabStop = true;
            this.rbMic.Text = "Line Input";
            this.rbMic.UseVisualStyleBackColor = true;
            this.rbMic.CheckedChanged += new System.EventHandler(this.rbMic_CheckedChanged_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSource);
            this.panel1.Controls.Add(this.rbMic);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 24);
            this.panel1.TabIndex = 40;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.volumeSlider5);
            this.groupBox11.Controls.Add(this.progressBar6);
            this.groupBox11.Controls.Add(this.volumeSlider6);
            this.groupBox11.Controls.Add(this.progressBar5);
            this.groupBox11.Location = new System.Drawing.Point(9, 14);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(438, 104);
            this.groupBox11.TabIndex = 48;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Line Input";
            // 
            // volumeSlider5
            // 
            this.volumeSlider5.Location = new System.Drawing.Point(327, 66);
            this.volumeSlider5.Name = "volumeSlider5";
            this.volumeSlider5.Size = new System.Drawing.Size(96, 15);
            this.volumeSlider5.TabIndex = 31;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(6, 30);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(315, 22);
            this.progressBar6.TabIndex = 30;
            // 
            // volumeSlider6
            // 
            this.volumeSlider6.Location = new System.Drawing.Point(327, 37);
            this.volumeSlider6.Name = "volumeSlider6";
            this.volumeSlider6.Size = new System.Drawing.Size(96, 15);
            this.volumeSlider6.TabIndex = 29;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(6, 59);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(315, 22);
            this.progressBar5.TabIndex = 32;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.rbManual);
            this.groupBox12.Controls.Add(this.rbPreset);
            this.groupBox12.Controls.Add(this.rbRandom);
            this.groupBox12.Controls.Add(this.rbSerial);
            this.groupBox12.Location = new System.Drawing.Point(775, 436);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(464, 48);
            this.groupBox12.TabIndex = 49;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "MODE";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbManual.Location = new System.Drawing.Point(245, 20);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(83, 20);
            this.rbManual.TabIndex = 47;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbPreset
            // 
            this.rbPreset.AutoSize = true;
            this.rbPreset.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbPreset.Location = new System.Drawing.Point(377, 20);
            this.rbPreset.Name = "rbPreset";
            this.rbPreset.Size = new System.Drawing.Size(78, 20);
            this.rbPreset.TabIndex = 46;
            this.rbPreset.Text = "Preset";
            this.rbPreset.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbRandom.Location = new System.Drawing.Point(113, 20);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(91, 20);
            this.rbRandom.TabIndex = 45;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbSerial.Location = new System.Drawing.Point(6, 20);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(70, 20);
            this.rbSerial.TabIndex = 44;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            this.rbSerial.CheckedChanged += new System.EventHandler(this.rbSerial_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tpSource);
            this.tabControl1.Controls.Add(this.tpLine);
            this.tabControl1.Controls.Add(this.tpSetting);
            this.tabControl1.Location = new System.Drawing.Point(769, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 412);
            this.tabControl1.TabIndex = 47;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpSource
            // 
            this.tpSource.Controls.Add(this.panel1);
            this.tpSource.Controls.Add(this.groupBox2);
            this.tpSource.Controls.Add(this.gbSetting);
            this.tpSource.Location = new System.Drawing.Point(4, 25);
            this.tpSource.Name = "tpSource";
            this.tpSource.Padding = new System.Windows.Forms.Padding(3);
            this.tpSource.Size = new System.Drawing.Size(465, 383);
            this.tpSource.TabIndex = 0;
            this.tpSource.Text = "Source";
            this.tpSource.UseVisualStyleBackColor = true;
            // 
            // tpLine
            // 
            this.tpLine.Controls.Add(this.groupBox11);
            this.tpLine.Location = new System.Drawing.Point(4, 25);
            this.tpLine.Name = "tpLine";
            this.tpLine.Padding = new System.Windows.Forms.Padding(3);
            this.tpLine.Size = new System.Drawing.Size(465, 383);
            this.tpLine.TabIndex = 1;
            this.tpLine.Text = "Line Input";
            this.tpLine.UseVisualStyleBackColor = true;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.label6);
            this.tpSetting.Controls.Add(this.cbLineInput);
            this.tpSetting.Controls.Add(this.label1);
            this.tpSetting.Controls.Add(this.setup);
            this.tpSetting.Controls.Add(this.comboBox1);
            this.tpSetting.Location = new System.Drawing.Point(4, 25);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Size = new System.Drawing.Size(465, 383);
            this.tpSetting.TabIndex = 2;
            this.tpSetting.Text = "Setting";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 39;
            this.label6.Text = "입력장치 선택";
            // 
            // cbLineInput
            // 
            this.cbLineInput.FormattingEnabled = true;
            this.cbLineInput.Location = new System.Drawing.Point(15, 83);
            this.cbLineInput.Name = "cbLineInput";
            this.cbLineInput.Size = new System.Drawing.Size(377, 20);
            this.cbLineInput.TabIndex = 38;
            this.cbLineInput.SelectedIndexChanged += new System.EventHandler(this.cbLineInput_SelectedIndexChanged);
            // 
            // cb_allRandom
            // 
            this.cb_allRandom.AutoSize = true;
            this.cb_allRandom.Checked = true;
            this.cb_allRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_allRandom.Font = new System.Drawing.Font("휴먼둥근헤드라인", 8F);
            this.cb_allRandom.Location = new System.Drawing.Point(1139, 543);
            this.cb_allRandom.Name = "cb_allRandom";
            this.cb_allRandom.Size = new System.Drawing.Size(99, 15);
            this.cb_allRandom.TabIndex = 73;
            this.cb_allRandom.Text = "All Random";
            this.cb_allRandom.UseVisualStyleBackColor = true;
            // 
            // cb_clockwise
            // 
            this.cb_clockwise.AutoSize = true;
            this.cb_clockwise.Checked = true;
            this.cb_clockwise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_clockwise.Font = new System.Drawing.Font("휴먼둥근헤드라인", 8F);
            this.cb_clockwise.Location = new System.Drawing.Point(1139, 510);
            this.cb_clockwise.Name = "cb_clockwise";
            this.cb_clockwise.Size = new System.Drawing.Size(97, 15);
            this.cb_clockwise.TabIndex = 72;
            this.cb_clockwise.Text = "Clock Wise";
            this.cb_clockwise.UseVisualStyleBackColor = true;
            // 
            // gb_routineCount
            // 
            this.gb_routineCount.Controls.Add(this.tb_form1RoutineCount);
            this.gb_routineCount.Controls.Add(this.lb_routineCount);
            this.gb_routineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_routineCount.Location = new System.Drawing.Point(931, 501);
            this.gb_routineCount.Name = "gb_routineCount";
            this.gb_routineCount.Size = new System.Drawing.Size(149, 57);
            this.gb_routineCount.TabIndex = 71;
            this.gb_routineCount.TabStop = false;
            this.gb_routineCount.Text = "Routine Count";
            // 
            // tb_form1RoutineCount
            // 
            this.tb_form1RoutineCount.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1RoutineCount.Location = new System.Drawing.Point(41, 27);
            this.tb_form1RoutineCount.Name = "tb_form1RoutineCount";
            this.tb_form1RoutineCount.Size = new System.Drawing.Size(32, 24);
            this.tb_form1RoutineCount.TabIndex = 44;
            this.tb_form1RoutineCount.Text = "2";
            this.tb_form1RoutineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.gb_stimulationTime.Controls.Add(this.label7);
            this.gb_stimulationTime.Controls.Add(this.tb_form1StimulationTimeWait);
            this.gb_stimulationTime.Controls.Add(this.tb_form1StimulationTime);
            this.gb_stimulationTime.Controls.Add(this.lb_stimulationTime);
            this.gb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F);
            this.gb_stimulationTime.Location = new System.Drawing.Point(775, 501);
            this.gb_stimulationTime.Name = "gb_stimulationTime";
            this.gb_stimulationTime.Size = new System.Drawing.Size(150, 57);
            this.gb_stimulationTime.TabIndex = 70;
            this.gb_stimulationTime.TabStop = false;
            this.gb_stimulationTime.Text = "Stimulation Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F);
            this.label7.Location = new System.Drawing.Point(49, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "/";
            // 
            // tb_form1StimulationTimeWait
            // 
            this.tb_form1StimulationTimeWait.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1StimulationTimeWait.Location = new System.Drawing.Point(71, 27);
            this.tb_form1StimulationTimeWait.Name = "tb_form1StimulationTimeWait";
            this.tb_form1StimulationTimeWait.Size = new System.Drawing.Size(32, 24);
            this.tb_form1StimulationTimeWait.TabIndex = 42;
            this.tb_form1StimulationTimeWait.Text = "2";
            this.tb_form1StimulationTimeWait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_form1StimulationTime
            // 
            this.tb_form1StimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 11F);
            this.tb_form1StimulationTime.Location = new System.Drawing.Point(11, 27);
            this.tb_form1StimulationTime.Name = "tb_form1StimulationTime";
            this.tb_form1StimulationTime.Size = new System.Drawing.Size(32, 24);
            this.tb_form1StimulationTime.TabIndex = 41;
            this.tb_form1StimulationTime.Text = "1";
            this.tb_form1StimulationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_stimulationTime
            // 
            this.lb_stimulationTime.AutoSize = true;
            this.lb_stimulationTime.Font = new System.Drawing.Font("휴먼둥근헤드라인", 15F);
            this.lb_stimulationTime.Location = new System.Drawing.Point(31, 32);
            this.lb_stimulationTime.Name = "lb_stimulationTime";
            this.lb_stimulationTime.Size = new System.Drawing.Size(0, 21);
            this.lb_stimulationTime.TabIndex = 40;
            this.lb_stimulationTime.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(773, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 3);
            this.panel4.TabIndex = 74;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 1001);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cb_allRandom);
            this.Controls.Add(this.cb_clockwise);
            this.Controls.Add(this.gb_routineCount);
            this.Controls.Add(this.gb_stimulationTime);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox12);
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
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSetting.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSource.ResumeLayout(false);
            this.tpLine.ResumeLayout(false);
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.gb_routineCount.ResumeLayout(false);
            this.gb_routineCount.PerformLayout();
            this.gb_stimulationTime.ResumeLayout(false);
            this.gb_stimulationTime.PerformLayout();
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
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private NAudio.Gui.VolumeSlider volumeSlider2;
        private NAudio.Gui.VolumeSlider volumeSlider3;
        private NAudio.Gui.VolumeSlider volumeSlider4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSetting;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSel4;
        private System.Windows.Forms.Button btnSel3;
        private System.Windows.Forms.Button btnSel2;
        private System.Windows.Forms.Button btnSel1;
        public System.Windows.Forms.ProgressBar progressBar4;
        public System.Windows.Forms.ProgressBar progressBar3;
        public System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
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
        private System.Windows.Forms.CheckBox setup;
        private System.Windows.Forms.RadioButton rbSource;
        private System.Windows.Forms.RadioButton rbMic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbPreset;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSource;
        private System.Windows.Forms.TabPage tpLine;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLineInput;
        private NAudio.Gui.VolumeSlider volumeSlider5;
        public System.Windows.Forms.ProgressBar progressBar6;
        private NAudio.Gui.VolumeSlider volumeSlider6;
        public System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.CheckBox cb_allRandom;
        private System.Windows.Forms.CheckBox cb_clockwise;
        public System.Windows.Forms.GroupBox gb_routineCount;
        private System.Windows.Forms.TextBox tb_form1RoutineCount;
        public System.Windows.Forms.Label lb_routineCount;
        public System.Windows.Forms.GroupBox gb_stimulationTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_form1StimulationTimeWait;
        private System.Windows.Forms.TextBox tb_form1StimulationTime;
        public System.Windows.Forms.Label lb_stimulationTime;
        private System.Windows.Forms.Panel panel4;
    }
}

