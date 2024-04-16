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
using System.Windows.Forms.VisualStyles;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        public MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

        CheckBox[,] _checkboxes;
        Button[] buttons;
        //GroupBox[] _groupBoxes;
        TextBox[] textBoxes;
        String[] strDir = new String[4];
        VolumeSlider[] volumesliders;
        AudioFileReader[,] audioFileReaderMixers;
        MultiplexingSampleProvider mixer;
        StereoToMonoSampleProvider[] mixedmonofiles;
        VolumeSampleProvider[] volumeSampleProviders1;
        AsioOut asioOut;
        MixingSampleProvider[] mixingSampleProviders = new MixingSampleProvider[8];
        float[] fVolume = new float[4] { 0.5f, 0.5f, 0.5f, 0.5f };
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
            //_groupBoxes = new GroupBox[4] { gbNoise, gbStimulA, gbStimulB, gbStimulC };
            _checkboxes = new CheckBox[4, 8] { {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7,checkBox8},
                {checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16 },
                {checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24 },
                {checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31,checkBox32 } };
            buttons = new Button[4] { btnSel1, btnSel2, btnSel3, btnSel4 };
            textBoxes = new TextBox[4] { textBox1, textBox2, textBox3, textBox4 };
            volumesliders = new VolumeSlider[4] {volumeSlider1, volumeSlider2, volumeSlider3, volumeSlider4 };
            
            audioFileReaderMixers = new AudioFileReader[8,4];
            mixedmonofiles = new StereoToMonoSampleProvider[8];

            // ASIO 드라이버  확인용
            var asioDriverNames = AsioOut.GetDriverNames();
            comboBox1.Items.AddRange(asioDriverNames.ToArray());
            comboBox1.SelectedIndex = 0;

            // mp3 파일 불러오는용
            //int nLocalDirIndex = System.Windows.Forms.Application.StartupPath.IndexOf("bin");
            //string strLocalDir = System.Windows.Forms.Application.StartupPath.Substring(0, nLocalDirIndex) + @"bin\music\";
            strDir[0] = Properties.Settings.Default.path1;
            strDir[1] = Properties.Settings.Default.path2;
            strDir[2] = Properties.Settings.Default.path3;
            strDir[3] = Properties.Settings.Default.path4;
            textBoxes[0].Text = strDir[0].Split('\\')[strDir[0].Split('\\').Length - 1];
            textBoxes[1].Text = strDir[1].Split('\\')[strDir[1].Split('\\').Length - 1];
            textBoxes[2].Text = strDir[2].Split('\\')[strDir[2].Split('\\').Length - 1];
            textBoxes[3].Text = strDir[3].Split('\\')[strDir[3].Split('\\').Length - 1];

            for (int i = 0; i < strStimulDir.Length; i++)
            {
                //strDir[i] = strLocalDir + strStimulDir[i];
                //textBoxes[i].Text = strDir[i].Split('\\')[strDir[i].Split('\\').Length - 1];
            }
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
            for(int i = 0; i <4; i++)
            {
                volumesliders[i].Volume = fVolume[i];
                volumesliders[i].VolumeChanged += (sender, e) => { vsEventHandler(sender, e); };
            }
            foreach(Button button in buttons)
            {
                button.Click += (sender, e) => { btnEventHandler(sender, e); };
            }

            //audioMaker();
            
        }
        private void audioMaker()
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    audioFileReaderMixers[j, i] = new AudioFileReader(strDir[i]);
                    audioFileReaderMixers[j, i].Volume = 0.0f;
                }
                Console.WriteLine("audio #" + i + ": " + audioFileReaderMixers[0, i].WaveFormat);
            }
            for (int i = 0; i < 8; i++)
            {
                if(mixingSampleProviders[i] != null)
                {
                    mixingSampleProviders[i].RemoveAllMixerInputs();
                }
                mixedmonofiles[i] = null;
                mixingSampleProviders[i] = new MixingSampleProvider(new[] { audioFileReaderMixers[i, 0], audioFileReaderMixers[i, 1], audioFileReaderMixers[i, 2], audioFileReaderMixers[i, 3] });
                mixedmonofiles[i] = new StereoToMonoSampleProvider(mixingSampleProviders[i]);
            }
            mixer = null;
            mixer = new MultiplexingSampleProvider(mixedmonofiles, 8);
            for (int i = 0; i < 8; i++)
            {
                mixer.ConnectInputToOutput(i, i);
            }
            volumeSampleProviders1 = null;
            volumeSampleProviders1 = new VolumeSampleProvider[mixer.WaveFormat.Channels];
            Console.WriteLine("mixer: "+mixer.WaveFormat.ToString());
            for (int i = 0; i < volumeSampleProviders1.Length; i++)
            {
                volumeSampleProviders1[i] = null;
                volumeSampleProviders1[i] = new VolumeSampleProvider(mixer, mixer.WaveFormat.Channels);
            }
            for (int i = 0; i < 8; i++)
            {
                volumeSampleProviders1[0][i] = 0.5f;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            asioOut.Dispose();
            asioOut = null;
            for(int i = 0; i < 8; i++)
                {
                for (int j = 0; j < 4; j++)
                {
                    audioFileReaderMixers[i, j].Dispose();
                    audioFileReaderMixers[i, j] = null;
                }
            }
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
                    audioFileReaderMixers[ch, i].Volume = fVolume[i];
                }
                else
                {
                    Console.WriteLine(_checkboxes[i, ch].Name + "-> FALSE");
                    audioFileReaderMixers[ch, i].Volume = 0.0f;
                }
            }
           /* if (nGroup == 0)
            {
                if (_checkboxes[nGroup, nCH].Checked)
                {
                    _checkboxes[nGroup, nCH].BackgroundImage = Properties.Resources.spkOn;
                }
                else
                {
                    _checkboxes[nGroup, nCH].BackgroundImage = Properties.Resources.spkOff;
                }
            }*/
        }
        private void vsEventHandler(object sender, EventArgs e)
        {
            VolumeSlider volumeSlider = (VolumeSlider)sender;
            int n = Int32.Parse(volumeSlider.Name.Replace("volumeSlider", "")) - 1;
            fVolume[n] = volumesliders[n].Volume;
            for(int i =0; i < 8; i++)
            {
                if (_checkboxes[n, i].Checked)
                {
                    audioFileReaderMixers[i, n].Volume = fVolume[n];
                }
            }
        }

        private void btnEventHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int n = Int32.Parse(button.Name.Replace("btnSel", ""))-1;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "이미지 파일|*.mp3";

            // 사용자가 파일을 선택 할 경우
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택된 파일의 경로와 이름 저장
                strDir[n] = openFileDialog.FileName;
                textBoxes[n].Text = strDir[n].Split('\\')[strDir[n].Split('\\').Length-1];
            }
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

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox33.Checked)
            {
                checkBox33.Text = "STOP";
                if (asioOut == null)
                {
                    asioOut = new AsioOut(comboBox1.SelectedIndex);
                    asioOut.PlaybackStopped += OnPlaybackStopped;
                    
                }
                if (audioFileReaderMixers[0,0] == null)
                {
                    audioMaker();
                    for(int i = 0; i<4; i++)
                    {
                        for(int j = 0; j<8; j++)
                        {
                            if (_checkboxes[i, j].Checked)
                            {
                                audioFileReaderMixers[j,i].Volume = fVolume[i];
                            }
                        }
                    }
                }
                asioOut.Init(volumeSampleProviders1[0]);
                asioOut.Play();
            }
            else
            {
                checkBox33.Text = "PLAY";
                asioOut?.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.path1 = strDir[0];
            Properties.Settings.Default.path2 = strDir[1];
            Properties.Settings.Default.path3 = strDir[2];
            Properties.Settings.Default.path4 = strDir[3];
            Properties.Settings.Default.Save();

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