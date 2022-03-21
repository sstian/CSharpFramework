using System;
using System.Windows;

namespace AnimationVisualBrush {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Storyboard_Completed(object sender, EventArgs e) {
            // 不显示元素，并且不在布局中为它保留空间
            this.rectangle.Visibility = Visibility.Collapsed;   
        }
    }
}
