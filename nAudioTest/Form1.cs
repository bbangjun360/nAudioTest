using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        Mp3Player[ , ] Stimul = new Mp3Player[4, 8];
        Thread[ , ] ThreadStimul = new Thread[4, 8];
        CheckBox[,] _checkboxes = new CheckBox[4, 8];
        GroupBox[] _groupBoxes; 

        String[] strStimulDir = 
        {
            @"C:/Users/김병준/Desktop/test.wav",
            @"C:/Users/김병준/Desktop/beep1.wav",
            @"C:/Users/김병준/Desktop/beep2.wav",
            @"C:/Users/김병준/Desktop/beep3.wav"
        };
        public Form1()
        {
            InitializeComponent();
            _groupBoxes = new GroupBox[4] { gbNoise, gbStimulA, gbStimulB, gbStimulC};

            for (int i = 0; i < Stimul.GetLength(0); i++)
            {
                for (int j = 0; j < Stimul.GetLength(1); j++)
                {
                    int localI = i;
                    int localJ = j;
                    Stimul[i, j] = new Mp3Player(j, 0, 50);
                    ThreadStimul[i, j] = new Thread(() => Stimul[localI, localJ].StopAndPlay(strStimulDir[localI]));
                    foreach (Control cb in _groupBoxes[localI].Controls.OfType<CheckBox>())
                    {
                        _checkboxes[localI, localJ] = (CheckBox)cb;
                        _checkboxes[localI, localJ].CheckedChanged += (sender, e) => { cbEventHandler(sender, e, localI, localJ); };

                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Stimul.GetLength(0); i++)
            {
                for (int j = 0; j < Stimul.GetLength(1); j++)
                {
                    Stimul[i, j].outputDevice.Volume = 0.5f;
                    try
                    {
                        ThreadStimul[i, j].Start();

                        Console.WriteLine(i.ToString() + "-" + j.ToString() + "  SUCC");
                    }
                    catch {
                        Console.WriteLine(i.ToString() + "-" + j.ToString() +"  ERROR");
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Stimul.GetLength(0); i++)
            {
                for (int j = 0; j < Stimul.GetLength(1); j++)
                {
                    Stimul[i, j].outputDevice.Volume = 0.5f;
                    ThreadStimul[i, j].Abort();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbEventHandler(object sender, EventArgs e, int nGroup, int nCH)
        {
            CheckBox cbTemp = (CheckBox)sender;
            int ch = Int32.Parse(cbTemp.Text.Substring(2));
            
            if (cbTemp.Checked)
            { 
                Stimul[nGroup, ch-1]._audioFile.Volume = 0.5f;
            }
            else
            {
                Stimul[nGroup, ch-1]._audioFile.Volume = 0.0f;
            }
        }
    }
}