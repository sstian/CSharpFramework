using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WinFormsHelloWorld {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.CountDown();

            lab();
        }

        // 倒计时
        public void CountDown() {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            var inputTime = DateTime.Parse("2022-01-07 23:00:00");
            var nowTime = DateTime.Now;
            TimeSpan timeSpan = inputTime - nowTime;

            int hours = (int)timeSpan.TotalHours;
            int minutes = timeSpan.Minutes;
            int seconds = timeSpan.Seconds;
            this.textBoxHour.Text = hours.ToString();
            this.textBoxMinute.Text = minutes.ToString();
            this.textBoxSecond.Text = seconds.ToString();
        }

        public void lab() {
            string dateTimeStr = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            // "2022-01-06 20-40-18"

            Point point = new Point();
            Size size = new Size();
        }
    }
}
