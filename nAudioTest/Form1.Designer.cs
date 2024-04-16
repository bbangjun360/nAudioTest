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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
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
            this.cbCH1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox34 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.cbCH1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 92);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(69, 16);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "Noise.A";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 92);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(69, 16);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "Noise.A";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(6, 92);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(69, 16);
            this.checkBox15.TabIndex = 5;
            this.checkBox15.Text = "Noise.A";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(6, 114);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(69, 16);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "Noise.B";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(6, 114);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(69, 16);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "Nosie.B";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(6, 114);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(69, 16);
            this.checkBox23.TabIndex = 5;
            this.checkBox23.Text = "Nosie.B";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(6, 136);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(70, 16);
            this.checkBox25.TabIndex = 1;
            this.checkBox25.Text = "Noise.C";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(6, 136);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(70, 16);
            this.checkBox27.TabIndex = 2;
            this.checkBox27.Text = "Noise.C";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(6, 136);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(70, 16);
            this.checkBox31.TabIndex = 5;
            this.checkBox31.Text = "Noise.C";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(353, 48);
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
            this.progressBar1.Location = new System.Drawing.Point(216, 41);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(131, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // volumeSlider2
            // 
            this.volumeSlider2.Location = new System.Drawing.Point(353, 77);
            this.volumeSlider2.Name = "volumeSlider2";
            this.volumeSlider2.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider2.TabIndex = 24;
            // 
            // volumeSlider3
            // 
            this.volumeSlider3.Location = new System.Drawing.Point(353, 106);
            this.volumeSlider3.Name = "volumeSlider3";
            this.volumeSlider3.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider3.TabIndex = 25;
            // 
            // volumeSlider4
            // 
            this.volumeSlider4.Location = new System.Drawing.Point(353, 135);
            this.volumeSlider4.Name = "volumeSlider4";
            this.volumeSlider4.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider4.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "출력장치 선택";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox34);
            this.groupBox1.Controls.Add(this.checkBox33);
            this.groupBox1.Controls.Add(this.volumeSlider4);
            this.groupBox1.Controls.Add(this.volumeSlider3);
            this.groupBox1.Controls.Add(this.progressBar4);
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.volumeSlider2);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.volumeSlider1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(647, 617);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 174);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설정";
            // 
            // checkBox33
            // 
            this.checkBox33.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox33.BackColor = System.Drawing.Color.PaleGreen;
            this.checkBox33.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox33.Location = new System.Drawing.Point(6, 70);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(95, 81);
            this.checkBox33.TabIndex = 43;
            this.checkBox33.Text = "PLAY";
            this.checkBox33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox33.UseVisualStyleBackColor = false;
            this.checkBox33.CheckedChanged += new System.EventHandler(this.checkBox33_CheckedChanged);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(216, 128);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(131, 23);
            this.progressBar4.TabIndex = 30;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(216, 99);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(131, 23);
            this.progressBar3.TabIndex = 29;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(216, 70);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(131, 23);
            this.progressBar2.TabIndex = 28;
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
            this.textBox4.Location = new System.Drawing.Point(6, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(365, 21);
            this.textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(365, 21);
            this.textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 21);
            this.textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 21);
            this.textBox1.TabIndex = 35;
            // 
            // btnSel4
            // 
            this.btnSel4.Location = new System.Drawing.Point(377, 127);
            this.btnSel4.Name = "btnSel4";
            this.btnSel4.Size = new System.Drawing.Size(75, 23);
            this.btnSel4.TabIndex = 34;
            this.btnSel4.Text = "열기";
            this.btnSel4.UseVisualStyleBackColor = true;
            // 
            // btnSel3
            // 
            this.btnSel3.Location = new System.Drawing.Point(377, 98);
            this.btnSel3.Name = "btnSel3";
            this.btnSel3.Size = new System.Drawing.Size(75, 23);
            this.btnSel3.TabIndex = 33;
            this.btnSel3.Text = "열기";
            this.btnSel3.UseVisualStyleBackColor = true;
            // 
            // btnSel2
            // 
            this.btnSel2.Location = new System.Drawing.Point(377, 69);
            this.btnSel2.Name = "btnSel2";
            this.btnSel2.Size = new System.Drawing.Size(75, 23);
            this.btnSel2.TabIndex = 32;
            this.btnSel2.Text = "열기";
            this.btnSel2.UseVisualStyleBackColor = true;
            // 
            // btnSel1
            // 
            this.btnSel1.Location = new System.Drawing.Point(377, 40);
            this.btnSel1.Name = "btnSel1";
            this.btnSel1.Size = new System.Drawing.Size(75, 23);
            this.btnSel1.TabIndex = 31;
            this.btnSel1.Text = "열기";
            this.btnSel1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(647, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 161);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "음원";
            // 
            // cbCH1
            // 
            this.cbCH1.Controls.Add(this.checkBox25);
            this.cbCH1.Controls.Add(this.checkBox17);
            this.cbCH1.Controls.Add(this.checkBox9);
            this.cbCH1.Controls.Add(this.checkBox1);
            this.cbCH1.Location = new System.Drawing.Point(280, 11);
            this.cbCH1.Name = "cbCH1";
            this.cbCH1.Size = new System.Drawing.Size(78, 160);
            this.cbCH1.TabIndex = 30;
            this.cbCH1.TabStop = false;
            this.cbCH1.Text = "CH1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox27);
            this.groupBox4.Controls.Add(this.checkBox19);
            this.groupBox4.Controls.Add(this.checkBox11);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Location = new System.Drawing.Point(553, 323);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(78, 160);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CH3";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBox31);
            this.groupBox8.Controls.Add(this.checkBox23);
            this.groupBox8.Controls.Add(this.checkBox15);
            this.groupBox8.Controls.Add(this.checkBox7);
            this.groupBox8.Location = new System.Drawing.Point(12, 324);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(78, 160);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "CH7";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox32);
            this.groupBox9.Controls.Add(this.checkBox24);
            this.groupBox9.Controls.Add(this.checkBox16);
            this.groupBox9.Controls.Add(this.checkBox8);
            this.groupBox9.Location = new System.Drawing.Point(55, 104);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(78, 160);
            this.groupBox9.TabIndex = 33;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "CH8";
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(6, 136);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(70, 16);
            this.checkBox32.TabIndex = 4;
            this.checkBox32.Text = "Noise.C";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(6, 114);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(69, 16);
            this.checkBox24.TabIndex = 4;
            this.checkBox24.Text = "Nosie.B";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(6, 92);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(69, 16);
            this.checkBox16.TabIndex = 4;
            this.checkBox16.Text = "Noise.A";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox28);
            this.groupBox5.Controls.Add(this.checkBox20);
            this.groupBox5.Controls.Add(this.checkBox12);
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Location = new System.Drawing.Point(517, 544);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(78, 160);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CH4";
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(6, 136);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(70, 16);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Text = "Noise.C";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(6, 114);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(69, 16);
            this.checkBox20.TabIndex = 6;
            this.checkBox20.Text = "Nosie.B";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(6, 92);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(69, 16);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "Noise.A";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox21);
            this.groupBox6.Controls.Add(this.checkBox13);
            this.groupBox6.Controls.Add(this.checkBox29);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Location = new System.Drawing.Point(280, 640);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(78, 160);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CH5";
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(6, 114);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(69, 16);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "Nosie.B";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(6, 92);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(69, 16);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Text = "Noise.A";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(6, 136);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(70, 16);
            this.checkBox29.TabIndex = 8;
            this.checkBox29.Text = "Noise.C";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox26);
            this.groupBox3.Controls.Add(this.checkBox18);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox10);
            this.groupBox3.Location = new System.Drawing.Point(517, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(78, 160);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CH2";
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(6, 136);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(70, 16);
            this.checkBox26.TabIndex = 7;
            this.checkBox26.Text = "Noise.C";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(6, 114);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(69, 16);
            this.checkBox18.TabIndex = 7;
            this.checkBox18.Text = "Nosie.B";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 92);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(69, 16);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Noise.A";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBox22);
            this.groupBox7.Controls.Add(this.checkBox14);
            this.groupBox7.Controls.Add(this.checkBox30);
            this.groupBox7.Controls.Add(this.checkBox6);
            this.groupBox7.Location = new System.Drawing.Point(55, 544);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(78, 160);
            this.groupBox7.TabIndex = 33;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CH6";
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(6, 114);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(69, 16);
            this.checkBox22.TabIndex = 3;
            this.checkBox22.Text = "Nosie.B";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(6, 92);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(69, 16);
            this.checkBox14.TabIndex = 3;
            this.checkBox14.Text = "Noise.A";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(6, 136);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(70, 16);
            this.checkBox30.TabIndex = 3;
            this.checkBox30.Text = "Noise.C";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::nAudioTest.Properties.Resources.programLogo1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(718, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox2.BackgroundImage")));
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 66);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox6.BackgroundImage")));
            this.checkBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox6.Location = new System.Drawing.Point(6, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(66, 66);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "\r\n";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox8.BackgroundImage")));
            this.checkBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox8.Location = new System.Drawing.Point(6, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(66, 66);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "\r\n";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox7.BackgroundImage")));
            this.checkBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox7.Location = new System.Drawing.Point(6, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(66, 66);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "\r\n";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox5.BackgroundImage")));
            this.checkBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox5.Location = new System.Drawing.Point(6, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(66, 66);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "\r\n";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox3.BackgroundImage")));
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox3.Location = new System.Drawing.Point(6, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 66);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox4.BackgroundImage")));
            this.checkBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox4.Location = new System.Drawing.Point(6, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(66, 66);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "\r\n";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackgroundImage = global::nAudioTest.Properties.Resources.spkOff;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 66);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::nAudioTest.Properties.Resources.CircleChair0deg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox34
            // 
            this.checkBox34.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox34.BackColor = System.Drawing.Color.LightSalmon;
            this.checkBox34.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox34.Location = new System.Drawing.Point(115, 70);
            this.checkBox34.Name = "checkBox34";
            this.checkBox34.Size = new System.Drawing.Size(95, 81);
            this.checkBox34.TabIndex = 44;
            this.checkBox34.Text = "STOP";
            this.checkBox34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox34.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 803);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cbCH1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "4input-8output test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cbCH1.ResumeLayout(false);
            this.cbCH1.PerformLayout();
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.CheckBox checkBox33;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox cbCH1;
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
        private System.Windows.Forms.CheckBox checkBox34;
    }
}

