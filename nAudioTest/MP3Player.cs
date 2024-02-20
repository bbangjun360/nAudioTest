using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Gui;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace nAudioTest
{
    public class Mp3Player
    {
        public WaveOutEvent outputDevice = new WaveOutEvent();
        public AudioFileReader _audioFile;
        public PanningSampleProvider panner;

        public int nDeviceNum = -1;          //재생장치 선택 변수
        public float nAudioFileVol = 0;       //플레이어 볼륨
        public int nOutputDeviceVol = 0;    //출력 볼륨
        public float nPannerValue = 0.0f;        //패닝값 저장용 L/R (-1.0f ~ 1.0f) 
        public float nMeterVol = 0.0f;
        public Mp3Player(int nCH, int nDeviceNum,  int nOutputVolume)   //출력 장치 번호, 플레이어 볼륨, 출력 볼륨
        {
            this.nDeviceNum = nDeviceNum;
            if (nCH %2 == 0)
            {
                nPannerValue = -1.0f; // pan fully left
            }
            else
            {
                nPannerValue = 1.0f; // pan fully right
            }
            if (nOutputVolume < 100) { outputDevice.Volume = nOutputVolume / 100f; }
                else { outputDevice.Volume = 100 / 100f; }

            
        }
        
        public void StopAndPlay(String filename)
        {
            try
            {
                StopAudio();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\twhile stoppint audio, error Occure");
            }
            try
            {
                outputDevice.DeviceNumber = nDeviceNum;
                PlayAudio(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\twhile stoppint audio, error Occure");
            }
        }

        private void PlayAudio(string filePath)
        {
            if (File.Exists(filePath))
            {
                //Console.WriteLine($"Playing: {Path.GetFileName(filePath)}");
                using (_audioFile = new AudioFileReader(filePath))
                {
                    _audioFile.Volume = nAudioFileVol;
                    var monofile = new StereoToMonoSampleProvider(_audioFile);
                    panner = new PanningSampleProvider(monofile);
                    panner.PanStrategy = new SquareRootPanStrategy();
                    panner.Pan = nPannerValue; // pan fully left
                    outputDevice.Init(panner);
                    //metering = new MeteringSampleProvider(panner);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        public void StopAudio()
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing)    //재생중인 출력 있으면 멈추고 Dispose
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }
            //if(_audioFile.CanRead) // 읽어져있는 audiofile 있으면 삭제
            //{
            //    _audioFile.Dispose();
            //    _audioFile = null;
            //}
        }
    }
}
