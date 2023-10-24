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
        Mp3Player PlayerSpk = new Mp3Player();
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerSpk.StopAndPlay(@"C:\Users\user\Desktop\bbangjun\HAS2_Train\wavPlayerNarr\SCN1.wav");
        }
    }
}