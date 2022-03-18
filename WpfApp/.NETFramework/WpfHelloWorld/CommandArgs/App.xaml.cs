using System.Windows;
using System.IO;

namespace CommandArgs {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private void Application_Startup(object sender, StartupEventArgs e) {
            MainWindow window = new MainWindow();
            if (e.Args.Length > 0) {
                string filePath = e.Args[0];
                if (File.Exists(filePath)) {
                    window.LoadFile(filePath);
                }
            }
            window.Show();
        }
    }
}
