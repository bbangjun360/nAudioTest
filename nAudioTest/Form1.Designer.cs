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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbNoise = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.gbStimulA = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.gbStimulB = new System.Windows.Forms.GroupBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.gbStimulC = new System.Windows.Forms.GroupBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.volumeSlider2 = new NAudio.Gui.VolumeSlider();
            this.volumeSlider3 = new NAudio.Gui.VolumeSlider();
            this.volumeSlider4 = new NAudio.Gui.VolumeSlider();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.gbNoise.SuspendLayout();
            this.gbStimulA.SuspendLayout();
            this.gbStimulB.SuspendLayout();
            this.gbStimulC.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbNoise
            // 
            this.gbNoise.Controls.Add(this.checkBox1);
            this.gbNoise.Controls.Add(this.checkBox7);
            this.gbNoise.Controls.Add(this.checkBox2);
            this.gbNoise.Controls.Add(this.checkBox6);
            this.gbNoise.Controls.Add(this.checkBox8);
            this.gbNoise.Controls.Add(this.checkBox3);
            this.gbNoise.Controls.Add(this.checkBox5);
            this.gbNoise.Controls.Add(this.checkBox4);
            this.gbNoise.Location = new System.Drawing.Point(12, 64);
            this.gbNoise.Name = "gbNoise";
            this.gbNoise.Size = new System.Drawing.Size(907, 47);
            this.gbNoise.TabIndex = 9;
            this.gbNoise.TabStop = false;
            this.gbNoise.Text = "Noise";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "ch1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(732, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(44, 16);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "ch7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(127, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(44, 16);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "ch2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(611, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(44, 16);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "ch6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(853, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(44, 16);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "ch8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(248, 20);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(44, 16);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "ch3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(490, 20);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(44, 16);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "ch5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(369, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(44, 16);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "ch4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // gbStimulA
            // 
            this.gbStimulA.Controls.Add(this.checkBox9);
            this.gbStimulA.Controls.Add(this.checkBox11);
            this.gbStimulA.Controls.Add(this.checkBox10);
            this.gbStimulA.Controls.Add(this.checkBox12);
            this.gbStimulA.Controls.Add(this.checkBox13);
            this.gbStimulA.Controls.Add(this.checkBox14);
            this.gbStimulA.Controls.Add(this.checkBox15);
            this.gbStimulA.Controls.Add(this.checkBox16);
            this.gbStimulA.Location = new System.Drawing.Point(13, 117);
            this.gbStimulA.Name = "gbStimulA";
            this.gbStimulA.Size = new System.Drawing.Size(906, 47);
            this.gbStimulA.TabIndex = 10;
            this.gbStimulA.TabStop = false;
            this.gbStimulA.Text = "StimulA";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 20);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(44, 16);
            this.checkBox9.TabIndex = 1;
            this.checkBox9.Text = "ch1";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(248, 20);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(44, 16);
            this.checkBox11.TabIndex = 7;
            this.checkBox11.Text = "ch3";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(127, 20);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(44, 16);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "ch2";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(369, 20);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(44, 16);
            this.checkBox12.TabIndex = 6;
            this.checkBox12.Text = "ch4";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(490, 20);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(44, 16);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Text = "ch5";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(611, 20);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(44, 16);
            this.checkBox14.TabIndex = 3;
            this.checkBox14.Text = "ch6";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(732, 20);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(44, 16);
            this.checkBox15.TabIndex = 5;
            this.checkBox15.Text = "ch7";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(853, 20);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(44, 16);
            this.checkBox16.TabIndex = 4;
            this.checkBox16.Text = "ch8";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // gbStimulB
            // 
            this.gbStimulB.Controls.Add(this.checkBox17);
            this.gbStimulB.Controls.Add(this.checkBox18);
            this.gbStimulB.Controls.Add(this.checkBox19);
            this.gbStimulB.Controls.Add(this.checkBox20);
            this.gbStimulB.Controls.Add(this.checkBox21);
            this.gbStimulB.Controls.Add(this.checkBox22);
            this.gbStimulB.Controls.Add(this.checkBox23);
            this.gbStimulB.Controls.Add(this.checkBox24);
            this.gbStimulB.Location = new System.Drawing.Point(13, 170);
            this.gbStimulB.Name = "gbStimulB";
            this.gbStimulB.Size = new System.Drawing.Size(906, 47);
            this.gbStimulB.TabIndex = 11;
            this.gbStimulB.TabStop = false;
            this.gbStimulB.Text = "StimulB";
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(6, 20);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(44, 16);
            this.checkBox17.TabIndex = 1;
            this.checkBox17.Text = "ch1";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(127, 20);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(44, 16);
            this.checkBox18.TabIndex = 7;
            this.checkBox18.Text = "ch2";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(248, 20);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(44, 16);
            this.checkBox19.TabIndex = 2;
            this.checkBox19.Text = "ch3";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(369, 20);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(44, 16);
            this.checkBox20.TabIndex = 6;
            this.checkBox20.Text = "ch4";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(490, 20);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(44, 16);
            this.checkBox21.TabIndex = 8;
            this.checkBox21.Text = "ch5";
            this.checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(611, 20);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(44, 16);
            this.checkBox22.TabIndex = 3;
            this.checkBox22.Text = "ch6";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(732, 20);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(44, 16);
            this.checkBox23.TabIndex = 5;
            this.checkBox23.Text = "ch7";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(853, 20);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(44, 16);
            this.checkBox24.TabIndex = 4;
            this.checkBox24.Text = "ch8";
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // gbStimulC
            // 
            this.gbStimulC.Controls.Add(this.checkBox25);
            this.gbStimulC.Controls.Add(this.checkBox26);
            this.gbStimulC.Controls.Add(this.checkBox27);
            this.gbStimulC.Controls.Add(this.checkBox28);
            this.gbStimulC.Controls.Add(this.checkBox31);
            this.gbStimulC.Controls.Add(this.checkBox32);
            this.gbStimulC.Controls.Add(this.checkBox29);
            this.gbStimulC.Controls.Add(this.checkBox30);
            this.gbStimulC.Location = new System.Drawing.Point(12, 223);
            this.gbStimulC.Name = "gbStimulC";
            this.gbStimulC.Size = new System.Drawing.Size(907, 47);
            this.gbStimulC.TabIndex = 11;
            this.gbStimulC.TabStop = false;
            this.gbStimulC.Text = "StimulC";
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(6, 20);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(44, 16);
            this.checkBox25.TabIndex = 1;
            this.checkBox25.Text = "ch1";
            this.checkBox25.UseVisualStyleBackColor = true;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(127, 20);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(44, 16);
            this.checkBox26.TabIndex = 7;
            this.checkBox26.Text = "ch2";
            this.checkBox26.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(248, 20);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(44, 16);
            this.checkBox27.TabIndex = 2;
            this.checkBox27.Text = "ch3";
            this.checkBox27.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(369, 20);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(44, 16);
            this.checkBox28.TabIndex = 6;
            this.checkBox28.Text = "ch4";
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(732, 20);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(44, 16);
            this.checkBox31.TabIndex = 5;
            this.checkBox31.Text = "ch7";
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(853, 20);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(44, 16);
            this.checkBox32.TabIndex = 4;
            this.checkBox32.Text = "ch8";
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(490, 20);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(44, 16);
            this.checkBox29.TabIndex = 8;
            this.checkBox29.Text = "ch5";
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(611, 20);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(44, 16);
            this.checkBox30.TabIndex = 3;
            this.checkBox30.Text = "ch6";
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(925, 84);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider1.TabIndex = 20;
            this.volumeSlider1.VolumeChanged += new System.EventHandler(this.volumeSlider1_VolumeChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(111, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // volumeSlider2
            // 
            this.volumeSlider2.Location = new System.Drawing.Point(925, 137);
            this.volumeSlider2.Name = "volumeSlider2";
            this.volumeSlider2.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider2.TabIndex = 24;
            // 
            // volumeSlider3
            // 
            this.volumeSlider3.Location = new System.Drawing.Point(925, 190);
            this.volumeSlider3.Name = "volumeSlider3";
            this.volumeSlider3.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider3.TabIndex = 25;
            // 
            // volumeSlider4
            // 
            this.volumeSlider4.Location = new System.Drawing.Point(925, 243);
            this.volumeSlider4.Name = "volumeSlider4";
            this.volumeSlider4.Size = new System.Drawing.Size(96, 16);
            this.volumeSlider4.TabIndex = 26;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 20);
            this.comboBox2.TabIndex = 28;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(140, 35);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(111, 23);
            this.progressBar2.TabIndex = 27;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(261, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(111, 20);
            this.comboBox3.TabIndex = 30;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(261, 35);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(111, 23);
            this.progressBar3.TabIndex = 29;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(382, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(111, 20);
            this.comboBox4.TabIndex = 32;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(382, 35);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(111, 23);
            this.progressBar4.TabIndex = 31;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(503, 9);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(111, 20);
            this.comboBox5.TabIndex = 34;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(503, 35);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(111, 23);
            this.progressBar5.TabIndex = 33;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(623, 9);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(111, 20);
            this.comboBox6.TabIndex = 36;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(623, 35);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(111, 23);
            this.progressBar6.TabIndex = 35;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(744, 9);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(111, 20);
            this.comboBox7.TabIndex = 38;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(744, 35);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(111, 23);
            this.progressBar7.TabIndex = 37;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(866, 9);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(111, 20);
            this.comboBox8.TabIndex = 40;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(866, 35);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(111, 23);
            this.progressBar8.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 321);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.progressBar8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.progressBar7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.progressBar6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.volumeSlider4);
            this.Controls.Add(this.volumeSlider3);
            this.Controls.Add(this.volumeSlider2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.gbStimulB);
            this.Controls.Add(this.gbStimulC);
            this.Controls.Add(this.gbStimulA);
            this.Controls.Add(this.gbNoise);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "4input-8output test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbNoise.ResumeLayout(false);
            this.gbNoise.PerformLayout();
            this.gbStimulA.ResumeLayout(false);
            this.gbStimulA.PerformLayout();
            this.gbStimulB.ResumeLayout(false);
            this.gbStimulB.PerformLayout();
            this.gbStimulC.ResumeLayout(false);
            this.gbStimulC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbNoise;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox gbStimulA;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.GroupBox gbStimulB;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.GroupBox gbStimulC;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox32;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private NAudio.Gui.VolumeSlider volumeSlider2;
        private NAudio.Gui.VolumeSlider volumeSlider3;
        private NAudio.Gui.VolumeSlider volumeSlider4;
        private System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ComboBox comboBox3;
        public System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ComboBox comboBox5;
        public System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ComboBox comboBox6;
        public System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ComboBox comboBox7;
        public System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ComboBox comboBox8;
        public System.Windows.Forms.ProgressBar progressBar8;
    }
}

