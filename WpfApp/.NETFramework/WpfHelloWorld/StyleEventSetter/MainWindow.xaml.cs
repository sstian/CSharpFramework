using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace StyleEventSetter {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Element_MouseEnter(object sender, MouseEventArgs e) {
            TextBlock textBlock = sender as TextBlock;
            textBlock.Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
        }

        private void Element_MouseLeave(object sender, MouseEventArgs e) {
            TextBlock textBlock = sender as TextBlock;
            textBlock.Background = null;
        }
    }
}
