using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HeapExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Window> windowList;
        private void buttonConsumer_Click(object sender, RoutedEventArgs e)
        {
            windowList = new List<Window>();
            for(int i = 0; i < 15000; i++)
            {
                Window window = new Window();
                windowList.Add(window);
            }
        }

        private void buttonRelease_Click(object sender, RoutedEventArgs e)
        {
            windowList.Clear();
        }
    }
}
