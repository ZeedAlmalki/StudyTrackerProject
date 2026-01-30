using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTracker
{
    public partial class StudyTracker : Form
    {
        public StudyTracker()
        {
            InitializeComponent();
        }
        uint Time = 0;
        int Seconds = 0;
        int Minutes = 0;
        int Hours = 0;
        string BaseTime = "";
        string StudyingFor = "";
        bool isOff;
        bool isOn;
        bool HasBeenStarted = false;

        bool isValid()
        {

            if (!maskedTextBoxTimer.MaskCompleted)
            {
                MessageBox.Show("Please Fill The Timer");
                return false;
            }

            if (txtStudyFor.Text == string.Empty)
            {
                MessageBox.Show("Please Enter The Thing You Study For");
                return false;
            }

            return true;
        }

        void SetTime()
        {

            Hours = Convert.ToInt32(maskedTextBoxTimer.Text.Substring(0, 1));
            Minutes = Convert.ToInt32(maskedTextBoxTimer.Text.Substring(2, 2));
            Seconds = Convert.ToInt32(maskedTextBoxTimer.Text.Substring(5, 2));
        }

        string getStudyingFor()
        {
            return txtStudyFor.Text;
        }

        void TimeCorrection(bool isType1 = true)
        {
            if (isType1)
            { 
            string stSecond = Convert.ToString(Seconds);
            if (Seconds <= 9)
            {

                stSecond = "0" + Seconds;
            }

            string stMinute = Convert.ToString(Minutes);
            if (Minutes <= 9)
            {

                stMinute = "0" + stMinute;
            }

            BaseTime = (Hours + ":" + stMinute + ":" + stSecond);

            }
            else
            {
                string stSecondsOfTimer = SecondsOfTimer.ToString();
                string stMinuteOfTimer = MinutesOfTimer.ToString();
                if (SecondsOfTimer <= 9)
                {

                    stSecondsOfTimer = "0" + stSecondsOfTimer;
                }

                if (MinutesOfTimer <= 9)
                {

                    stMinuteOfTimer = "0" + stMinuteOfTimer;
                }

                lblTimer.Text = (HoursOfTimer + ":" + stMinuteOfTimer + ":" + stSecondsOfTimer);
            }
        }

        void setSetteingsOfIsStart()
        {
            isOff = false;
            TimerStudyTracker.Enabled = true;
            HasBeenStarted = true;
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            //= Convert.ToInt32(txtBoxTimer.Text);

            if (isOn)
                return;

            if (!isValid())
                return;

            isOn = true;
          

            if (!HasBeenStarted)
            {
                StudyingFor = getStudyingFor();
                SetTime();
                TimeCorrection();
                StartAt = FullDate(DateTime.Now);
            }
            setSetteingsOfIsStart();
        }

        string StartAt = "";
        string EndAt = "";
        int SecondsOfTimer = 0;
        int MinutesOfTimer = 0;
        int HoursOfTimer = 0;

        bool CheckIfTimerCompleted()
        {
            if (SecondsOfTimer == Convert.ToInt32(Seconds) && (MinutesOfTimer == Convert.ToInt32(Minutes) && (HoursOfTimer == Convert.ToInt32(Hours))))
            {
                TimerStudyTracker.Enabled = false;
                niStudyTracker.BalloonTipText = "Timer Completed!";
                niStudyTracker.BalloonTipTitle = "Study Tracker";
                niStudyTracker.ShowBalloonTip(3000);
                SaveData();
                return true;
            }

            return false;
        }

        void CounterOfTimer()
        {
            SecondsOfTimer++;

            if (SecondsOfTimer == 60)
            {
                MinutesOfTimer++;
                SecondsOfTimer = 0;
            }

            if (MinutesOfTimer == 60)
            {
                HoursOfTimer++;
                MinutesOfTimer = 0;
                SecondsOfTimer = 0;
            }
        }

        bool CheckIfReachTheMaximumTime()
        {
            if (HoursOfTimer == 9 && MinutesOfTimer == 59 && SecondsOfTimer == 59)
            {
                TimerStudyTracker.Enabled = false;
                MessageBox.Show("You Completed 9 Hours and 59 Minutes And 59 Seconds, The maximum of the Program");
                SaveData();
                return true;
            }
            return false;
        }
        private void TimerStudyTracker_Tick(object sender, EventArgs e)
        {
            if (CheckIfTimerCompleted())
                return;

            CounterOfTimer();

            if (CheckIfReachTheMaximumTime())
                return;

            TimeCorrection(false);

        }

        void setSetteingsOfIsOff()
        {
            TimerStudyTracker.Enabled = false;
            isOff = true;
        }

        private void btnOffTimer_Click(object sender, EventArgs e)
        {
            if (!IsStart())
                return;

            isOn = false;
            if (isOff == true)
            {
                MessageBox.Show("Timer Is Stopped");
                return;
            }

            setSetteingsOfIsOff();
            MessageBox.Show("Timer Has Been Stopped");
            return;
        }

        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTimer.SelectedTab = tabPage2;
            StatusSize();
        }

        static string FilePath = @"D:\Course 14 C#\StudyTracker\StudyTimerInfo.txt";

        ListViewItem AddItemsByParts(string[] parts)
        {
            ListViewItem item = new ListViewItem(parts[0].ToString());
            item.SubItems.Add(parts[1].ToString());
            item.SubItems.Add(parts[2].ToString());
            item.SubItems.Add(parts[3].ToString());
            item.SubItems.Add(parts[4].ToString());

            return item;
        }

        void DefaultSize()
        {
            this.Size = new Size(423, 454);
        }
        
        void StatusSize()
        {
            this.Size = new Size(1125, 726);
        }

        private void tbTimer_Click(object sender, EventArgs e)
        {
            if (tbTimer.SelectedTab == tabPage2)
            {
                listViewAboutStatus.Items.Clear();
                string[] Lines = new string[] { };
                StatusSize();

                Lines = File.ReadAllLines(FilePath);

                foreach(string Line in Lines)
                {
                    string[] parts = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    listViewAboutStatus.Items.Add(AddItemsByParts(parts));
                }
            }
            else if (tbTimer.SelectedTab == tabPage1)
            {
                DefaultSize();
            }

        }


        string FullDate(DateTime dt)
        {

            return dt.Year.ToString() + "/" + dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Hour.ToString() + ":" + dt.Minute.ToString();
        }


        bool IsStart()
        {
            if (!(HasBeenStarted))
            {
                MessageBox.Show("You Haven't Started The Timer Yet!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        string AllDataText()
        {
            return lblTimer.Text + "#//#" + BaseTime + "#//#" + StudyingFor + "#//#" + StartAt + "#//#" + EndAt + Environment.NewLine;
        }

        void SaveData()
        {
            EndAt = FullDate(DateTime.Now);
            File.AppendAllText(FilePath, AllDataText());
            this.Close();
        }


        void SaveDataAfterAsk()
        {
            if (MessageBox.Show("Are You Sure ? You Will Close The Form", "Close The Form", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                SaveData();
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsStart())
                return;

            SaveDataAfterAsk();
          
        }
    }
}