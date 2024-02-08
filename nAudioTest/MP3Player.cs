using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Dmo;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.CoreAudioApi;
using NAudio.CoreAudioApi.Interfaces;

namespace nAudioTest
{
    public class Mp3Player
    {
        public WaveOutEvent outputDevice = new WaveOutEvent();
        public AudioFileReader audioFile;
        public PanningSampleProvider panner;
        public int nDeviceNum = 0;
        public int nDeviceVolume = 10;
        public void PlayMp3(String filename)
        {
            try
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    Thread.Sleep(150);
                }
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent()
                    {
                        DeviceNumber = nDeviceNum
                    };
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (audioFile == null)
                {
                    //String strTemp = "C:\\Users\\user\\Downloads\\" + filename + ".wav";
                    Console.WriteLine(filename);
                    audioFile = new AudioFileReader(@filename);
                    outputDevice.Init(audioFile);
                    audioFile.Volume = nDeviceVolume / 100f;
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured while trying to stop the MP3: {e.Message}");
            }
        }
        public void StopAndPlay(String filename)
        {
            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
            }
            outputDevice.DeviceNumber = nDeviceNum;
            PlayAudio(filename);
        }

        private void PlayAudio(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine($"Playing: {Path.GetFileName(filePath)}");
                using (var _audioFile = new AudioFileReader(filePath))
                {
                    _audioFile.Volume = nDeviceVolume / 100f;
                    var monofile = new StereoToMonoSampleProvider(_audioFile);
                    panner = new PanningSampleProvider(monofile);
                    panner.PanStrategy = new SquareRootPanStrategy();
                    //panner.Pan = 0.0f; // pan fully left
                    outputDevice.Init(panner);
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
        public void StopMp3()
        {
            outputDevice.Stop();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            try
            {
                outputDevice.Dispose();
                outputDevice = null;
                audioFile.Dispose();
                audioFile = null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured while trying to stop the MP3: {e.Message}");
            }
        }
    }
}
