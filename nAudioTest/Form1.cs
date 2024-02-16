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
using System.Net;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.CoreAudioApi;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        public MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
        Mp3Player[ , ] Stimul = new Mp3Player[4, 8];
        Thread[ , ] ThreadStimul = new Thread[4, 8];
        CheckBox[,] _checkboxes = new CheckBox[4, 8];
        GroupBox[] _groupBoxes; 

        String[] strStimulDir = 
        {
            "White_0dBFS.mp3",
            "StimulA.wav",
            "StimulB.mp3",
            "StimulC.mp3"
        };
        public Form1()
        {
            InitializeComponent();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            comboBox2.Items.AddRange(devices.ToArray());
            comboBox3.Items.AddRange(devices.ToArray());
            comboBox4.Items.AddRange(devices.ToArray());
            comboBox5.Items.AddRange(devices.ToArray());
            comboBox6.Items.AddRange(devices.ToArray());
            comboBox7.Items.AddRange(devices.ToArray());
            comboBox8.Items.AddRange(devices.ToArray());
            // ProgressBar를 생성합니다

            for (int n = -1; n < WaveOut.DeviceCount; n++)
            {
                var caps = WaveOut.GetCapabilities(n);
                Console.WriteLine($"{n}: {caps.ProductName}");
            }
            int nLocalDirIndex = System.Windows.Forms.Application.StartupPath.IndexOf("bin");
            Console.WriteLine(nLocalDirIndex);
            string strLocalDir = System.Windows.Forms.Application.StartupPath.Substring(0,nLocalDirIndex) + @"bin\music\";
            for (int i = 0; i < strStimulDir.Length; i++)
            {
                strStimulDir[i] = strLocalDir + strStimulDir[i];
                Console.WriteLine(strStimulDir[i]);
            }


            _groupBoxes = new GroupBox[4] { gbNoise, gbStimulA, gbStimulB, gbStimulC};

            for (int i = 0; i < Stimul.GetLength(0); i++)
            {
                for (int j = 0; j < Stimul.GetLength(1); j++)
                {
                    int localI = i;
                    int localJ = j;
                    Stimul[i, j] = new Mp3Player(j, -1, 100);
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
                    Stimul[i, j].outputDevice.Volume = 1.0f;
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
            Thread.Sleep(500);
            timer1.Start();
        }
        private void MeteringSampleProvider_StreamVolume(object sender, StreamVolumeEventArgs e)
        {
            // Update the volume meter (ProgressBar) on the UI thread
            BeginInvoke(new Action(() =>
            {
                int volume = (int)(e.MaxSampleValues[0] * 100); // Assuming a single channel

                // Ensure the volume value is within the ProgressBar range (0-100)
                volume = Math.Max(0, Math.Min(100, volume));

                progressBar1.Value = volume;
            }));
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            for (int i = 0; i < Stimul.GetLength(0); i++)
            {
                for (int j = 0; j < Stimul.GetLength(1); j++)
                {
                    Stimul[i, j].outputDevice.Volume = 0.0f;
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
                volumeSlider1.Volume = 1.0f;
                //Stimul[nGroup, ch-1]._audioFile.Volume = 0.5f;
            }
            else
            {
                volumeSlider1.Volume = 0.0f;
                //Stimul[nGroup, ch-1]._audioFile.Volume = 0.0f;
            }
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < 4;i++)
            {
                Stimul[0, 0]._audioFile.Volume = volumeSlider1.Volume;
                Console.WriteLine(volumeSlider1.Volume);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null) 
            {
                MMDevice[] device = new MMDevice[8]; 
                device[0] = (MMDevice)comboBox1.SelectedItem;
                device[1] = (MMDevice)comboBox2.SelectedItem;
                device[2] = (MMDevice)comboBox3.SelectedItem;
                device[3] = (MMDevice)comboBox4.SelectedItem;
                device[4] = (MMDevice)comboBox5.SelectedItem;
                device[5] = (MMDevice)comboBox6.SelectedItem;
                device[6] = (MMDevice)comboBox7.SelectedItem;
                device[7] = (MMDevice)comboBox8.SelectedItem;

                progressBar1.Value = (int)(Math.Round(device[0].AudioMeterInformation.MasterPeakValue * 100));
                progressBar2.Value = (int)(Math.Round(device[1].AudioMeterInformation.MasterPeakValue * 100));
                progressBar3.Value = (int)(Math.Round(device[2].AudioMeterInformation.MasterPeakValue * 100));
                progressBar4.Value = (int)(Math.Round(device[3].AudioMeterInformation.MasterPeakValue * 100));
                progressBar5.Value = (int)(Math.Round(device[4].AudioMeterInformation.MasterPeakValue * 100));
                progressBar6.Value = (int)(Math.Round(device[5].AudioMeterInformation.MasterPeakValue * 100));
                progressBar7.Value = (int)(Math.Round(device[6].AudioMeterInformation.MasterPeakValue * 100));
                progressBar8.Value = (int)(Math.Round(device[7].AudioMeterInformation.MasterPeakValue * 100));

            }
        }
    }
}