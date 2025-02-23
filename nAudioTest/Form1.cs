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
using System.Runtime;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        public MMDeviceEnumerator enumerator = new MMDeviceEnumerator();

        WaveInEvent waveSource;
        BufferedWaveProvider bufferedWaveProvider;
        BufferedWaveProvider[] bufferedWaveProviders;
        private VolumeSampleProvider[] volumeSampleProviders;
        private MultiplexingSampleProvider multiplexedProvider;
        public MixingSampleProvider mixingSampleProvider;
        ISampleProvider monoProvider;
        StereoToMonoSampleProvider[] stereoToMono;
        //ISampleProvider[] monoProviders;
        VolumeSampleProvider[] monoProviders = new VolumeSampleProvider[8];
        CheckBox[,] _checkboxes;
        Button[] buttons;
        GroupBox[] _groupBoxes;
        TextBox[] textBoxes;
        String[] strDir = new String[4];
        VolumeSlider[] volumesliders;
        VolumeSlider[] volumeslidersOutput;
        AudioFileReader[,] audioFileReaderMixers;
        MultiplexingSampleProvider mixer;
        StereoToMonoSampleProvider[] mixedmonofiles;
        VolumeSampleProvider[] volumeSampleProviders1;
        VolumeSampleProvider[] volumeSampleProviders2;
        AsioOut asioOut;
        MixingSampleProvider[] mixingSampleProviders = new MixingSampleProvider[8];
        float[] fVolume = new float[4] { 0.1f, 0.1f, 0.1f, 0.1f };
        float[,] fMicVolume = new float[8,4] { { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f },
                                               { 0.0f, 0.0f, 0.0f, 0.0f }};

        String[] strStimulDir = 
        {
            "Noise.mp3",
            "B.mp3",
            "C.mp3",
            "D.mp3"
        };

        System.Threading.Timer TESTTIME_ThreadTimer;
        System.Threading.Timer StimulationTime_ThreadTimer;
        System.Threading.Timer StimulationTimeWait_ThreadTimer;
        delegate void TimerEventFiredDelegate_TESTTIME();
        delegate void TimerEventFiredDelegate_StimulationTime();
        delegate void TimerEventFiredDelegate_StimulationTimeWait();

        public Form1()
        {
            InitializeComponent();

            TESTTIME_ThreadTimer = new System.Threading.Timer(TESTTIME_timerCallBack);
            StimulationTime_ThreadTimer = new System.Threading.Timer(StimulationTime_timerCallBack);
            StimulationTimeWait_ThreadTimer = new System.Threading.Timer(StimulationTimeWait_timerCallBack);

            TESTTIME_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);

            // 컨트롤들 배열로 묶기
            _groupBoxes = new GroupBox[8] { groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10 };
            _checkboxes = new CheckBox[4, 8] { {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7,checkBox8},
                {checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16 },
                {checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24 },
                {checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31,checkBox32 } };
            buttons = new Button[4] { btnSel1, btnSel2, btnSel3, btnSel4 };
            textBoxes = new TextBox[4] { tbPath1, tbPath2, tbPath3, tbPath14 };
            volumesliders = new VolumeSlider[4] {vsInput1, vsInput2, vsInput3, vsInput4 };
            volumeslidersOutput = new VolumeSlider[8] {vsCH1, vsCH2, vsCH3, vsCH4, vsCH5, vsCH6, vsCH7, vsCH8 };
            audioFileReaderMixers = new AudioFileReader[8,4];
            mixedmonofiles = new StereoToMonoSampleProvider[8];

            waveSource = new WaveInEvent { WaveFormat = new WaveFormat(44100, 16, 2) };
            waveSource.DeviceNumber = cbLineInput.SelectedIndex;
            waveSource.DataAvailable += OnDataAvailable;            // 마이크 데이터 처리 이벤트 등록
            // ASIO 드라이버  확인용
            var asioDriverNames = AsioOut.GetDriverNames();
            comboBox1.Items.AddRange(asioDriverNames.ToArray());
            comboBox1.SelectedIndex = Properties.Settings.Default.asio_selected_index;
            var inputDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            cbLineInput.Items.Clear();
            cbLineInput.Items.AddRange(inputDevices.ToArray());
            cbLineInput.SelectedIndex = Properties.Settings.Default.input_device_selected_index;

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
            lbTestFolderPath.Text = Properties.Settings.Default.path_test;
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
                     _checkboxes[localI, localJ].CheckedChanged += (sender, e) => { cbEventHandler(sender, e); };
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
        private void Form1_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.save_selectedmode)
            {
                case 1: rbSerial.Checked = true; break;
                case 2: rbRandom.Checked = true; break;
                case 3: rbManual.Checked = true; break;
                case 4: rbPreset.Checked = true; break;
            }
            tb_StimulationTime.Text = Properties.Settings.Default.save_tb_stimulationTime;
            tb_StimulationTimeWait.Text = Properties.Settings.Default.save_tb_stimulationTimeWait;
            tb_RoutineCount.Text = Properties.Settings.Default.save_tb_routineTime;
            cb_clockwise.Checked = Properties.Settings.Default.save_clockwise;
            cb_allRandom.Checked = Properties.Settings.Default.save_all_random;
        }
        void TESTTIME_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(TESTTIME_timerWork));
        }
        void StimulationTime_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(StimulationTime_timerWork));
        }
        void StimulationTimeWait_timerCallBack(Object state)
        {
            BeginInvoke(new TimerEventFiredDelegate_TESTTIME(StimulationTimeWait_timerWork));
        }
        long testtime_time = 0;
        int stimulationTime_time = 0;
        int stimulationTimeWait_time = 0;
        private void TESTTIME_timerWork()
        {
            testtime_time += 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_testtime.Text = (testtime_time / 60).ToString("00") + ":" + (testtime_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
        }
        private void StimulationTime_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
          
        }
        private void StimulationTimeWait_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
           
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
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            asioOut.Dispose();
            asioOut = null;
            if (!rbMic.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        audioFileReaderMixers[i, j].Dispose();
                        audioFileReaderMixers[i, j] = null;
                    }
                }
            }
            
        }
        private void cbEventHandler(object sender, EventArgs e)
        {
            CheckBox cbTemp = (CheckBox)sender;
            int num = Int32.Parse(cbTemp.Name.Substring(8));
            int ch = (num - 1)%8;
            for(int i = 0; i < 4; i++)
            {
                if (_checkboxes[i, ch].Checked)
                {
                    Console.WriteLine(_checkboxes[i, ch].Name + "-> TRUE");
                    if(!rbMic.Checked) audioFileReaderMixers[ch, i].Volume = fVolume[i];
                    if (rbMic.Checked)
                    {
                        if (i == 0) stereoToMono[ch].LeftVolume = fVolume[i];
                        if (i == 1) stereoToMono[ch].RightVolume = fVolume[i];
                    }
                }
                else
                {
                    Console.WriteLine(_checkboxes[i, ch].Name + "-> FALSE");
                    if (!rbMic.Checked) audioFileReaderMixers[ch, i].Volume = 0.0f;
                    if (rbMic.Checked)
                    {
                        if (i == 0) stereoToMono[ch].LeftVolume = 0.0f;
                        if (i == 1) stereoToMono[ch].RightVolume = 0.0f;
                    }
                       
                }
            }
            if (num <= 8)
            {
                if (_checkboxes[0, ch].Checked)
                {
                    _checkboxes[0, ch].BackgroundImage = Properties.Resources.spkOn;
                }
                else
                {
                    _checkboxes[0, ch].BackgroundImage = Properties.Resources.spkOff;
                }
            }
        }
        private void vsEventHandler(object sender, EventArgs e)
        {
            VolumeSlider volumeSlider = (VolumeSlider)sender;
            int n = Int32.Parse(volumeSlider.Name.Replace("vsInput", "")) - 1;
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

        private void cbStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStart.Checked)
            {
                lb_testtime.Text = "00:00";
                cbStart.Text = "TEST STOP";
                cbStart.BackColor = Color.Red;
                stimulationTime_time = 0;
                stimulationTimeWait_time = 0;
                TESTTIME_ThreadTimer.Change(0, 1000);
                StimulationTime_ThreadTimer.Change(0, 1000);
                if (!rbManual.Checked)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            _checkboxes[i, j].Enabled = false;
                        }
                    }
                }
                else
                {

                }
                // 음원 출력 시작
                if (asioOut == null)
                {
                    asioOut = new AsioOut(comboBox1.SelectedIndex); // ASIO 출력 장치 선택
                    asioOut.PlaybackStopped += OnPlaybackStopped; // 현재 재생중이면 정지
                }
                if (audioFileReaderMixers[0, 0] == null)
                {
                    if (rbSource.Checked)
                    {
                        audioMaker();
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 8; j++)
                            {
                                if (_checkboxes[i, j].Checked) // 만약에 사전에 체크되어 있다면 해당 채널 볼륨up
                                {
                                    audioFileReaderMixers[j, i].Volume = fVolume[i];  // 해당 채널 저장되어있는 값으로 볼륨up
                                }
                            }
                        }
                        asioOut.Init(volumeSampleProviders1[0]);
                        asioOut.Play();
                    }
                    if (rbMic.Checked)
                    {
                        //audioMakerForMicInput();
                        waveSource.StartRecording(); // 마이크 입력 시작
                        audioMakerForMicInput();
                        asioOut.Init(volumeSampleProviders2[0]); // 부동 소수점 데이터를 가져오는 믹서 초기화
                        asioOut.Play();
                    }
                }
                //timer1.Start();
            }
            else
            {
                if (!rbManual.Checked)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            _checkboxes[i, j].Enabled = true;
                        }
                    }
                }
                cbStart.Text = "PLAY";
                cbStart.BackColor = Color.PaleGreen;
                asioOut?.Stop();
                waveSource?.StopRecording(); // 마이크 입력 중지

                //timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.path1 = strDir[0];
            Properties.Settings.Default.path2 = strDir[1];
            Properties.Settings.Default.path3 = strDir[2];
            Properties.Settings.Default.path4 = strDir[3];
            Properties.Settings.Default.save_tb_stimulationTime = tb_StimulationTime.Text;
            Properties.Settings.Default.save_tb_stimulationTimeWait = tb_StimulationTimeWait.Text;
            Properties.Settings.Default.save_tb_routineTime = tb_RoutineCount.Text;
            Properties.Settings.Default.save_clockwise = cb_clockwise.Checked;
            Properties.Settings.Default.save_all_random = cb_allRandom.Checked;
            Properties.Settings.Default.Save();

        }

        private void rbSource_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void rbMic_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;

        }
        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            
            // 수신된 오디오 데이터를 버퍼에 추가
             foreach (var provider in bufferedWaveProviders)
             {
                 provider.AddSamples(e.Buffer, 0, e.BytesRecorded);
             }
        }

        private void audioMakerForMicInput()
        {
            bufferedWaveProviders = new BufferedWaveProvider[8];  //들어올 mic 파일을 8개로 분할 저장하기 위한 변수
            volumeSampleProviders = new VolumeSampleProvider[8];
            stereoToMono = new StereoToMonoSampleProvider[8];
            for (int i = 0; i < 8; i++)
            {
                bufferedWaveProviders[i] = new BufferedWaveProvider(new WaveFormat(44100, 16, 2));// waveSource의 WaveFormat을 사용하여 각 Buffer를 초기화
            }
            for (int i = 0; i < 8; i++)
            {
                stereoToMono[i] = new StereoToMonoSampleProvider(bufferedWaveProviders[i].ToSampleProvider());
                stereoToMono[i].LeftVolume = 0.0f;
                stereoToMono[i].RightVolume = 0.0f;
                // StereoToMonoSampleProvider에서 ToMono 메서드를 바로 호출하면 안됩니다. 이 클래스는 이미 모노로 처리됩니다.
                monoProviders[i] = new VolumeSampleProvider(stereoToMono[i],8);
            }
            // 8채널 멀티플렉싱 프로바이더 생성
            mixer = new MultiplexingSampleProvider(monoProviders, monoProviders.Length);

            // 모든 입력 채널을 모든 출력 채널에 연결
            for (int i = 0; i < 8; i++)
            {
                mixer.ConnectInputToOutput(i, i); // 단일 입력을 다중 출력에 연결
            }
            // 각 채널의 볼륨 설정
            volumeSampleProviders2 = new VolumeSampleProvider[8];
            for (int i = 0; i < 8; i++)
            {
                volumeSampleProviders2[i] = new VolumeSampleProvider(mixer, mixer.WaveFormat.Channels);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tbSource.SelectedIndex)
            {
                case 0:
                    checkBox17.Enabled = true;
                    checkBox18.Enabled = true;
                    checkBox19.Enabled = true;
                    checkBox20.Enabled = true;
                    checkBox21.Enabled = true;
                    checkBox22.Enabled = true;
                    checkBox23.Enabled = true;
                    checkBox24.Enabled = true;
                    checkBox25.Enabled = true;
                    checkBox26.Enabled = true;
                    checkBox27.Enabled = true;
                    checkBox28.Enabled = true;
                    checkBox29.Enabled = true; 
                    checkBox30.Enabled = true;
                    checkBox31.Enabled = true;
                    checkBox32.Enabled = true;
                    break;
                case 1:
                    checkBox17.Enabled = false;
                    checkBox18.Enabled = false;
                    checkBox19.Enabled = false;
                    checkBox20.Enabled = false;
                    checkBox21.Enabled = false;
                    checkBox22.Enabled = false;
                    checkBox23.Enabled = false;
                    checkBox24.Enabled = false;
                    checkBox25.Enabled = false;
                    checkBox26.Enabled = false;
                    checkBox27.Enabled = false;
                    checkBox28.Enabled = false;
                    checkBox29.Enabled = false;
                    checkBox30.Enabled = false;
                    checkBox31.Enabled = false;
                    checkBox32.Enabled = false;
                    break;
                case 2:
                    break;
                    default: throw new ArgumentException();
            }
        }

        private void cbLineInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            waveSource.DeviceNumber = cbLineInput.SelectedIndex;
            Properties.Settings.Default.input_device_selected_index = cbLineInput.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void rbSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSerial.Checked)
            {
                for(int i = 0; i < 8; i++)
                {
                    _checkboxes[0,i].Enabled = false;
                }
            }

        }
        private void rbRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    _checkboxes[0, i].Enabled = false;
                }
            }
        }
        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManual.Checked)
            {
                for (int i = 0; i < 8; i++)
                {
                    _checkboxes[0, i].Enabled = true;
                }
            }
        }
        private void rbPreset_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRandom.Checked)
            {
                for(int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 8; i++)
                    {
                        _checkboxes[i, j].Enabled = false;
                    }
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tpSetting_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var asioDriverNames = AsioOut.GetDriverNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(asioDriverNames.ToArray());
        }

        private void cbLineInput_Click(object sender, EventArgs e)
        {
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            cbLineInput.Items.Clear();
            cbLineInput.Items.AddRange(devices.ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.asio_selected_index = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void btnTestFolderOpen_CheckedChanged(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // 대화 상자를 사용자에게 보여줌
                DialogResult result = folderBrowserDialog.ShowDialog();

                // 폴더 선택 시 처리
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // 선택된 폴더 경로를 TextBox에 표시
                    lbTestFolderPath.Text = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.path_test = folderBrowserDialog.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            strDir[0] = Properties.Settings.Default.path_test + "\\init.mp3";
            strDir[1] = Properties.Settings.Default.path_test + "\\init.mp3";
            strDir[2] = Properties.Settings.Default.path_test + "\\init.mp3";
            strDir[3] = Properties.Settings.Default.path_test + "\\init.mp3";
            textBoxes[0].Text = strDir[0].Split('\\')[strDir[0].Split('\\').Length - 1];
            textBoxes[1].Text = strDir[1].Split('\\')[strDir[1].Split('\\').Length - 1];
            textBoxes[2].Text = strDir[2].Split('\\')[strDir[2].Split('\\').Length - 1];
            textBoxes[3].Text = strDir[3].Split('\\')[strDir[3].Split('\\').Length - 1];
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MMDevice[] device = new MMDevice[8];
                //device[0] = (AsioOut)comboBox1.SelectedItem;
                //progressBar1.Value = (int)(Math.Round(device[0].AudioMeterInformation.MasterPeakValue * 100));
                //asioOut.MasterPeakValue
            }
            
        }


        // cbStart_CheckedChanged 이벤트 핸들러는 동일하게 유지하고 마이크 관련 초기화만 추가
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