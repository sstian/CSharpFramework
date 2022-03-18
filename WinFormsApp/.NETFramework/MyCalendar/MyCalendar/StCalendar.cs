using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MyCalendar {
    public partial class StCalendar : Control {
        public StCalendar() {
            // InitializeComponent();
            this.BackColor = Color.White;
            this.Size = new Size(280, 280);

            // 双缓冲设置，减少画面闪烁
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs pe) {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;
            int width = this.Width;
            int height = this.Height;
            var rect = new Rectangle(0, 0, width, height);

            // 平滑绘制，反锯齿
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            int x = 0;
            int y = 0;
            int sx = 40;    // 单元格宽度
            int sy = 40;    // 单元格高度
            var format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            // 两道横线
            using (var pen = new Pen(Color.DarkGray)) {
                g.DrawLine(pen, x, y, x + sx * 7, y);
                g.DrawLine(pen, x, y + sy, x + sx * 7, y + sy);
            }

            // 第一行：日、一、二、三、四、五、六
            String[] header = { "日", "一", "二", "三", "四", "五", "六" };
            using (var brush = new SolidBrush(Color.Blue)) {  
                for (int i = 0; i < header.Length; i++) {
                    var rectHeader = new Rectangle(x + i * sx, y, sx, sy);
                    g.DrawString(header[i], this.Font, brush, rectHeader, format);
                }
            }

            // 计算本月第一天是星期几
            DateTime datetime = DateTime.Now;
            int theMonth = datetime.Month;
            int theDay = datetime.Day;
            // 向前推到本月第一天的日期
            DateTime firstDate = datetime.AddDays(1 - theDay);
            // 本月第一天是星期几
            DayOfWeek weekday = firstDate.DayOfWeek;
            Console.WriteLine($"{theMonth} 1st weekday: {weekday}");

            // 往前推N天
            // Sunday=0, Monday=1, ..., Saturday=6
            int start = weekday - DayOfWeek.Sunday;
            DateTime startDate = firstDate.AddDays(0 - start);

            // 绘制6行：每月最多31天，最多以6行显示
            x = 0;
            y += sy;
            // 5行7列
            DateTime dt = startDate;
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 7; j++) {
                    bool isToday = false;
                    Color textColor = Color.Black;
                    // 判断月份是否相同
                    // 非本月，灰色
                    if (dt.Month != theMonth) {
                        textColor = Color.Gray;
                    }
                    // 当天，高亮色
                    if (dt.Month == theMonth && dt.Day == theDay) {
                        isToday = true;
                        textColor = Color.OrangeRed;
                    }

                    int day = dt.Day;
                    var rectLine = new Rectangle(x + sx * j, y + sy * i, sx, sy);
                    // 当天以高亮色显示
                    if (isToday) {
                        var rectToday = new Rectangle(rectLine.X + 3, rectLine.Y + 3, sx - 6, sy - 6);
                        var pen = new Pen(textColor, 1.5f);
                        g.DrawEllipse(pen, rectToday);
                    }
                    using (var Brush = new SolidBrush(textColor)) {
                        g.DrawString(day.ToString(), this.Font, Brush, rectLine, format);
                    }

                    // 日期+1
                    dt = dt.AddDays(1);
                }
            }
        }
    }
}
