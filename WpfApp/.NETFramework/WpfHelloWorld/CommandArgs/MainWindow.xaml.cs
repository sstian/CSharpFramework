using System.Windows;
using System.IO;

namespace CommandArgs {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        public void LoadFile(string path) {
            this.Content = File.ReadAllText(path);
            this.Title = path;
        }
    }
}
