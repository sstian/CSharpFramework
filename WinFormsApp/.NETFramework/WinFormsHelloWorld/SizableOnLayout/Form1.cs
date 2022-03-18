using System.Drawing;
using System.Windows.Forms;

namespace SizableOnLayout {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        protected override void OnLayout(LayoutEventArgs levent) {
            //1. 调用父类的OnLayout(), 非必需
            base.OnLayout(levent);

            // 2. 获取窗口大小 ClientSize （仅客户区，不含标题栏）
            int width = this.ClientSize.Width;      // 464
            int height = this.ClientSize.Height;    // 281

            //3. 计算每一个控件的位置和大小
            int yOffset = 4;
            this.textBox.Location = new Point(0, yOffset);
            this.textBox.Size = new Size(width - 80, 30);
            this.button.Location = new Point(width - 80, yOffset);
            this.button.Size = new Size(80, 30);
            this.pictureBox.Location = new Point(0, 40);
            this.pictureBox.Size = new Size(width, height - yOffset - 4);
        }
    }
}
