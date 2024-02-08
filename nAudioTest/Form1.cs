using NAudio.Wave;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Dmo;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        Mp3Player StimulCH12 = new Mp3Player();
        Mp3Player NoiseCH12 = new Mp3Player();

        public Form1()
        {
            InitializeComponent();
            StimulCH12.nDeviceVolume = 20;
            StimulCH12.outputDevice.Volume = 0.0f;
            StimulCH12.nDeviceNum = 0;

            NoiseCH12.nDeviceVolume = 20;
            NoiseCH12.outputDevice.Volume = 0.0f;
            NoiseCH12.nDeviceNum = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread stimul = new Thread(() => StimulCH12.StopAndPlay(@"C:/Users/김병준/Desktop/test.wav"));
            Thread noise = new Thread(() => NoiseCH12.StopAndPlay(@"C:/Users/김병준/Desktop/beep.wav"));
            stimul.Start();
            noise.Start();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            StimulCH12.StopMp3();
            NoiseCH12.StopMp3();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = -1.0f; // pan fully left
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = 0.0f; // pan fully left
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = 1.0f; // pan fully left
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.0f;
                StimulCH12.panner.Pan = 0.0f; // pan fully left
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = -1.0f; // pan fully left
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = 0.0f; // pan fully left
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.5f;
                StimulCH12.panner.Pan = 1.0f; // pan fully left
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                StimulCH12.outputDevice.Volume = 0.0f;
                StimulCH12.panner.Pan = 0.0f; // pan fully left
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked && !checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = -1.0f; // pan fully left
            }
            else if (checkBox16.Checked && checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = 0.0f; // pan fully left
            }
            else if (!checkBox16.Checked && checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = 1.0f; // pan fully left
            }
            else if (!checkBox16.Checked && !checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.0f;
                NoiseCH12.panner.Pan = 0.0f; // pan fully left
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked && !checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = -1.0f; // pan fully left
            }
            else if (checkBox16.Checked && checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = 0.0f; // pan fully left
            }
            else if (!checkBox16.Checked && checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.5f;
                NoiseCH12.panner.Pan = 1.0f; // pan fully left
            }
            else if (!checkBox16.Checked && !checkBox15.Checked)
            {
                NoiseCH12.outputDevice.Volume = 0.0f;
                NoiseCH12.panner.Pan = 0.0f; // pan fully left
            }
        }
    }
}