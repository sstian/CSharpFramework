using System.Windows;

namespace PageDemo {
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application {
        private void Application_NavigationFailed(object sender, System.Windows.Navigation.NavigationFailedEventArgs e) {
            if (e.Exception is System.Net.WebException) {
                MessageBox.Show("Website " + e.Uri.ToString() + " cannot be reached.");
                e.Handled = true;
            }
        }
    }
}
