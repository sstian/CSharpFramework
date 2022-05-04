using System.Windows;

namespace NotifyIconDemo {
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application {
        private NotifyIconWrapper notifyIconWrapper;

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            this.notifyIconWrapper = new NotifyIconWrapper();
        }

        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);

            this.notifyIconWrapper.Dispose();
        }
    }
}
