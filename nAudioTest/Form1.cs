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
using NAudio.Gui;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        public MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

        CheckBox[,] _checkboxes;

        GroupBox[] _groupBoxes;
        TextBox[] textBoxes;
        VolumeSlider[] volumesliders;
        AudioFileReader[,] audioFileReaderMixers;
        MultiplexingSampleProvider mixer;
        StereoToMonoSampleProvider[] mixedmonofiles;
        VolumeSampleProvider[] volumeSampleProviders1;
        AsioOut asioOut;
        MixingSampleProvider[] mixingSampleProviders = new MixingSampleProvider[8];
        String[] strStimulDir = 
        {
            "Noise.mp3",
            "B.mp3",
            "C.mp3",
            "D.mp3"
        };
        public Form1()
        {
            InitializeComponent();

            // 컨트롤들 배열로 묶기
            _groupBoxes = new GroupBox[4] { gbNoise, gbStimulA, gbStimulB, gbStimulC };
            _checkboxes = new CheckBox[4, 8] { {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7,checkBox8},
                {checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16 },
                {checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24 },
                {checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31,checkBox32 } };
                   
            textBoxes = new TextBox[4] { textBox1, textBox2, textBox3, textBox4 };
            volumesliders = new VolumeSlider[4] {volumeSlider1, volumeSlider2, volumeSlider3, volumeSlider4 };
            
            audioFileReaderMixers = new AudioFileReader[8,4];
            mixedmonofiles = new StereoToMonoSampleProvider[8];

            // ASIO 드라이버  확인용
            var asioDriverNames = AsioOut.GetDriverNames();
            comboBox1.Items.AddRange(asioDriverNames.ToArray());
            comboBox1.SelectedIndex = 0;

            // mp3 파일 불러오는용
            int nLocalDirIndex = System.Windows.Forms.Application.StartupPath.IndexOf("bin");
            string strLocalDir = System.Windows.Forms.Application.StartupPath.Substring(0,nLocalDirIndex) + @"bin\music\";
            for (int i = 0; i < strStimulDir.Length; i++)
            {
                strStimulDir[i] = strLocalDir + strStimulDir[i];
                textBoxes[i].Text = strStimulDir[i];

                for(int j = 0; j < 8; j++)
                {
                    audioFileReaderMixers[j,i] = new AudioFileReader(strStimulDir[i]);
                    audioFileReaderMixers[j,i].Volume = 0.0f;
                }
                
                //volumesliders[i].VolumeChanged += (sender, e) => { vsEventHandler(sender, e); };
            }
            for(int i = 0; i < 8; i++)
            {
                mixingSampleProviders[i] = new MixingSampleProvider(new[] { audioFileReaderMixers[i,0], audioFileReaderMixers[i,1], audioFileReaderMixers[i, 2], audioFileReaderMixers[i, 3] });
                mixedmonofiles[i] = new StereoToMonoSampleProvider(mixingSampleProviders[i]);
            }

            mixer = new MultiplexingSampleProvider(mixedmonofiles, 8);
            for(int i = 0;i< 8;i++)
            {
                mixer.ConnectInputToOutput(i, i);
            }
            
            volumeSampleProviders1 = new VolumeSampleProvider[mixer.WaveFormat.Channels];
            for (int i = 0; i < volumeSampleProviders1.Length; i++)
            {
                volumeSampleProviders1[i] = new VolumeSampleProvider(mixer, mixer.WaveFormat.Channels);
            }
            for (int i = 0; i < 8; i++)
            {
                volumeSampleProviders1[0][i] = 0.5f;
            }
            asioOut = new AsioOut();
            asioOut.Init(volumeSampleProviders1[0]);
            // 체크박스 이벤트 핸들러 세팅용
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int localI = i;
                    int localJ = j;
                     _checkboxes[localI, localJ].CheckedChanged += (sender, e) => { cbEventHandler(sender, e, localI, localJ); };
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asioOut.Play();
            //asioOut2.Play();
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)  
        {
            asioOut.Stop(); //asioOut2.Stop();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbEventHandler(object sender, EventArgs e, int nGroup, int nCH)
        {
            CheckBox cbTemp = (CheckBox)sender;
            int ch = Int32.Parse(cbTemp.Text.Substring(2)) - 1;
            for(int i = 0; i < 4; i++)
            {
                if (_checkboxes[i, ch].Checked)
                {
                    Console.WriteLine(_checkboxes[i, ch].Name + "-> TRUE");
                    audioFileReaderMixers[ch, i].Volume = 0.7f;
                }
                else
                {
                    Console.WriteLine(_checkboxes[i, ch].Name + "-> FALSE");
                    audioFileReaderMixers[ch, i].Volume = 0.0f;
                }
            }


        }
        private void vsEventHandler(object sender, EventArgs e)
        {
            VolumeSlider volumeSlider = (VolumeSlider)sender;
            //Console.WriteLine(volumeSlider.Name.Replace("volumeSlider", ""));
            int n = Int32.Parse(volumeSlider.Name.Replace("volumeSlider", "")) - 1;
            //audioFileReaders[n].Volume = volumesliders[n].Volume;
            //audioFileReaderMixers[n].Volume = volumesliders[n].Volume; ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null) 
            {
                //MMDevice[] device = new MMDevice[8]; 
                //device[0] = (MMDevice)comboBox1.SelectedItem;
                //progressBar1.Value = (int)(Math.Round(device[0].AudioMeterInformation.MasterPeakValue * 100));
                

            }
        }
    }

    class VolumeSampleProvider : ISampleProvider
    {
        private readonly ISampleProvider sourceProvider;
        private readonly float[] channelVolumes;

        public VolumeSampleProvider(ISampleProvider sourceProvider, int channelCount)
        {
            this.sourceProvider = sourceProvider;
            this.channelVolumes = new float[channelCount];
            for (int i = 0; i < channelCount; i++)
            {
                this.channelVolumes[i] = 1.0f; // Initial volume for each channel (1.0 is full volume)
            }
        }

        public float this[int channel]
        {
            get { return channelVolumes[channel]; }
            set { channelVolumes[channel] = Math.Max(0.0f, Math.Min(1.0f, value)); }
        }

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = sourceProvider.Read(buffer, offset, count);

            // Apply volume adjustment for each channel
            for (int i = 0; i < samplesRead; i++)
            {
                int channel = i % sourceProvider.WaveFormat.Channels;
                buffer[offset + i] *= channelVolumes[channel];
            }

            return samplesRead;
        }

        public WaveFormat WaveFormat => sourceProvider.WaveFormat;
    }
    public class AudioMixer : ISampleProvider
    {
        private readonly ISampleProvider[] inputProviders;

        public WaveFormat WaveFormat => inputProviders[0].WaveFormat;

        public AudioMixer(params ISampleProvider[] inputProviders)
        {
            this.inputProviders = inputProviders;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            int bytesRead = 0;

            foreach (var provider in inputProviders)
            {
                bytesRead += provider.Read(buffer, offset + bytesRead, count - bytesRead);
                if (bytesRead == count)
                    break;
            }

            return bytesRead;
        }
    }
}