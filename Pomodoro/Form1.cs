using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Pomodoro
{
    public partial class formPomodorro: Form
    {
        private uint wT = 25;
        private uint bT = 5;

        private System.Timers.Timer timer;
        private TimeSpan workTime;
        private TimeSpan breakTime;
        private TimeSpan remainingTime;
        private bool isWorkTime = true;
        private bool isBreakTime = false;

        private enum TimerState { Stopped, Running, Paused }
        private TimerState currentState = TimerState.Stopped;

        public formPomodorro()
        {
            InitializeComponent();

            workTime = TimeSpan.FromMinutes(wT);
            breakTime = TimeSpan.FromMinutes(bT);

            lblWork.Text = wT.ToString();
            lblBreak.Text = bT.ToString();
            lblTime.Text = wT.ToString();

            InitializeTimer();
            UpdateTimeDisplay();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer(1000); // odliczanie co 1 s
            timer.Elapsed += TimerElapsed;
            timer.AutoReset = true;
        }

        private void UpdateTimeDisplay()
        {
            lblTime.Text = remainingTime.ToString(@"mm\:ss");
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                Invoke(new Action(UpdateTimeDisplay));
            }
            else
            {
                timer.Stop();
                SwitchTimerMode();
            }
        }

        private void SwitchTimerMode()
        {
            isWorkTime = !isWorkTime;
            isBreakTime = !isBreakTime;
            UpdateTimeDisplay();
            timer.Start();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case TimerState.Stopped:
                    StartTimer();
                    break;
                case TimerState.Running:
                    PauseTimer();
                    break;
                case TimerState.Paused:
                    ResumeTimer();
                    break;
            }
        }
        private void StartTimer()
        {
            remainingTime = workTime;
            timer.Start();
            currentState = TimerState.Running;
            btnStartStop.Text = "Pause";
            DisableButtons();
        }

        private void PauseTimer()
        {
            timer.Stop();
            currentState = TimerState.Paused;
            btnStartStop.Text = "Resume";
            EnableButtons();
        }

        private void ResumeTimer()
        {
            timer.Start();
            currentState = TimerState.Running;
            btnStartStop.Text = "Pause";
            DisableButtons();
        }

        private void DisableButtons()
        {
            btnWTUp.Enabled = false;
            btnWTDown.Enabled = false;
            btnBTUp.Enabled = false;
            btnBTDown.Enabled = false;
        }
        private void EnableButtons()
        {
            btnWTUp.Enabled = true;
            btnWTDown.Enabled = true;
            btnBTUp.Enabled = true;
            btnBTDown.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wT++;
            if (wT < 59)
            {
                workTime = TimeSpan.FromMinutes(wT);
                lblWork.Text = wT.ToString();
                btnWTUp.Enabled = true;
                btnWTDown.Enabled = true;

            }
            else
            {
                lblWork.Text = wT.ToString();
                btnWTUp.Enabled = false;
                btnWTDown.Enabled = true;
            }
        }

        private void btnWTDown_Click(object sender, EventArgs e)
        {
            wT--;
            if (wT > 1)
            {
                workTime = TimeSpan.FromMinutes(wT);
                lblWork.Text = wT.ToString();
                btnWTUp.Enabled = true;
                btnWTDown.Enabled = true;
            }
            else
            {
                lblWork.Text = wT.ToString();
                btnWTUp.Enabled = true;
                btnWTDown.Enabled = false;
            }
        }

        private void btnBTUp_Click(object sender, EventArgs e)
        {
            bT++;
            if (bT < 59)
            {
                breakTime = TimeSpan.FromMinutes(bT);
                lblBreak.Text = bT.ToString();
                btnBTUp.Enabled = true;
                btnBTDown.Enabled = true;
            }
            else
            {
                lblBreak.Text = bT.ToString();
                btnBTUp.Enabled = false;
                btnBTDown.Enabled = true;
            }
        }

        private void btnBTDown_Click(object sender, EventArgs e)
        {
            bT--;
            if (bT > 1)
            {
                breakTime = TimeSpan.FromMinutes(bT);
                lblBreak.Text = bT.ToString();
                btnBTUp.Enabled = true;
                btnBTDown.Enabled = true;
            }
            else
            {
                // --bT;
                lblBreak.Text = bT.ToString();
                btnBTUp.Enabled = true;
                btnBTDown.Enabled = false;
            }
        }
    }
}
