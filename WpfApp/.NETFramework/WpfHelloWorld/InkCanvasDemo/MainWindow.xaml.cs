using System;
using System.Windows;
using System.Windows.Controls;

namespace InkCanvasDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode))) {
                this.comboBoxEditingMode.Items.Add(mode);
            }
            this.comboBoxEditingMode.SelectedIndex = 0;
        }

        private void comboBoxEditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            this.inkCanvas.EditingMode = (InkCanvasEditingMode)this.comboBoxEditingMode.SelectedItem;
        }
    }
}
