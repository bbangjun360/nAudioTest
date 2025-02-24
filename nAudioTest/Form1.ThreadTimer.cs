using Microsoft.VisualBasic.Compatibility.VB6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace nAudioTest
{
    public partial class Form1 : Form
    {
        System.Threading.Timer TESTTIME_ThreadTimer;
        System.Threading.Timer StimulationTime_ThreadTimer;
        System.Threading.Timer StimulationTimeWait_ThreadTimer;
        delegate void TimerEventFiredDelegate_TESTTIME();
        delegate void TimerEventFiredDelegate_StimulationTime();
        delegate void TimerEventFiredDelegate_StimulationTimeWait();

        long testtime_time = 0;
        int stimulationTime_time = 0;
        int stimulationTimeWait_time = 0;
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
        private void TESTTIME_timerWork()
        {
            testtime_time += 1;                                                                      //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            lb_testtime.Text = (testtime_time / 60).ToString("00") + ":" + (testtime_time % 60).ToString("00");    //남은 시간 uint -> String으로 변환하는 작업
        }
        bool bSpkOn = false;
        private void StimulationTime_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            if (cbStart.Checked)
            {
                if (rbPreset.Checked)
                {
                }
                else // rbManual.
                {
                    if (stimulationTime_time == 0)
                    {
                        bSpkOn = true;
                        modeSelector();
                    }
                    else if (stimulationTime_time == Int32.Parse(Properties.Settings.Default.save_tb_stimulationTime))
                    {
                        bSpkOn = false;
                        modeSelector();
                        StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        stimulationTimeWait_time = 0;
                        StimulationTimeWait_ThreadTimer.Change(0, 1000);
                    }
                }
                stimulationTime_time += 1;
            }  
        }
        private void StimulationTimeWait_timerWork()
        {                                                                   //초 마다 타이머 함수 실행되면 -1해 남은시간 줄여줌
            if (cbStart.Checked)
            {
                if (rbPreset.Checked)
                {
                    //
                }
                else
                {
                    if (stimulationTimeWait_time == Int32.Parse(Properties.Settings.Default.save_tb_stimulationTimeWait))
                    {
                        currentCh++;
                        if (currentCh == Properties.Settings.Default.save_ch_sel) // 선택된 채널의 총 개수와 현재 채널 개수가 같은 경우 routine cnt -1 & 랜덤 arr 다시돌림
                        {
                            currentCh = 0;
                            routineCountChk++;
                            tb_RoutineCount.Text = (Int32.Parse(tb_RoutineCount.Text) - 1).ToString();
                            rndArrMaker();
                        }
                        else
                        {
                            //
                        }

                        StimulationTimeWait_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                        
                        if (routineCountChk < Int32.Parse(Properties.Settings.Default.save_tb_routineTime))
                        {
                            stimulationTime_time = 0;
                            StimulationTime_ThreadTimer.Change(0, 1000);
                        }
                        else//routine 카운트 끝
                        {
                            TestStop();
                        }
                    }
                }
                stimulationTimeWait_time += 1;
            }
        }
        //mode 관련 함수
        int currentCh = 0;
        int routineCountChk = 0;
        int randomvalue = 1;
        int routineCntSum = 0;
        int currentChSaved = 0;
        private void modeSelector()
        {
           if (rbPreset.Checked)
            {
               //
            }
            else if (rbManual.Checked) // stimuation 타이머 종료
            {
                StimulationTime_ThreadTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            }
            else //rbSerial, rbRandom
            {
                if (routineCountChk < Int32.Parse(Properties.Settings.Default.save_tb_routineTime))
                {
                    int OnCH = 0;
                    if (rbSerial.Checked)
                    {
                        if (cb_clockwise.Checked) OnCH = currentCh;//시계방향 회전시
                        else OnCH = Properties.Settings.Default.save_ch_sel - currentCh - 1;//반시계 방향 회전시
                    }
                    else if (rbRandom.Checked)
                    {
                        OnCH = randomArray[currentCh] - 1;
                        lv_Random.Items[currentCh].Selected = true;
                    }
                    if (bSpkOn)
                    {
                        Console.WriteLine(_checkboxes[SOURCE1, OnCH].Name + "-> TRUE");
                        _checkboxes[SOURCE1, OnCH].BackgroundImage = Properties.Resources.spkOn;
                        if (tbSource.SelectedTab == this.tpSource) audioFileReaderMixers[OnCH, SOURCE1].Volume = fVolume[SOURCE1];
                        if (tbSource.SelectedTab == this.tpLine) stereoToMono[OnCH].LeftVolume = fLineVolume[SOURCE1];
                    }
                    else if(!bSpkOn)
                    {
                        Console.WriteLine(_checkboxes[SOURCE1, OnCH].Name + "-> FALSE");
                        _checkboxes[SOURCE1, OnCH].BackgroundImage = Properties.Resources.spkOff;
                        if (tbSource.SelectedTab == this.tpSource) audioFileReaderMixers[OnCH, SOURCE1].Volume = 0.0f;
                        if (tbSource.SelectedTab == this.tpLine) stereoToMono[OnCH].LeftVolume = 0.0f;
                    }
                }
                else
                {   // routineCount 끝나면 종료
                    TestStop();
                }
            }
        }
        public void TimerResetandStart()
        {
            tb_StimulationTime.Enabled = false;
            tb_StimulationTimeWait.Enabled = false;
            tb_RoutineCount.Enabled = false;

            lb_testtime.Text = "00:00";
            testtime_time = -1;
            stimulationTime_time = 0;
            stimulationTimeWait_time = 0;
            TESTTIME_ThreadTimer.Change(0, 1000);
            StimulationTime_ThreadTimer.Change(0, 1000);

            Properties.Settings.Default.save_tb_routineTime = tb_RoutineCount.Text;
            Properties.Settings.Default.Save();
        }
        int[] randomArray;
        public void rndArrMaker()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            switch (Properties.Settings.Default.save_ch_sel)
            {
                case 4: randomArray = new int[] { 1, 2, 3, 4 }; break;
                case 5: randomArray = new int[] { 1, 2, 3, 4, 5 }; break;
                case 8:
                default: randomArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; break;
            }
            if (cb_allRandom.Checked) //1~n 사이 꼭 한번씩은 나와야 함
            {
                for (int i = randomArray.Length - 1; i > 0; i--)// Fisher-Yates shuffle 알고리즘 적용
                {
                    int j = rnd.Next(i + 1); // 0에서 i(포함) 사이의 랜덤 인덱스 선택                           
                    int temp = randomArray[i]; // numbers[i]와 numbers[j]의 값 교환
                    randomArray[i] = randomArray[j];
                    randomArray[j] = temp;
                }
            }
            else //1~n 사이 무작위 랜덤 
            {
                for(int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = rnd.Next(1, randomArray.Length+1);
                }
            }
            
            for (int i = 0; i < Properties.Settings.Default.save_ch_sel; i++)
                lv_Random.Items[i].Text = randomArray[i].ToString();
            for (int i = Properties.Settings.Default.save_ch_sel; i < 8; i++)
                lv_Random.Items[i].Text = "";
        }
        
    }
}
