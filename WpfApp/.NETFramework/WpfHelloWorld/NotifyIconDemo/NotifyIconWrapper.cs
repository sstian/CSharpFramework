using System;
using System.ComponentModel;

namespace NotifyIconDemo {
    public partial class NotifyIconWrapper : Component {
        private MainWindow window = new MainWindow();

        public NotifyIconWrapper() {
            InitializeComponent();

            this.cmdShowWindow.Click += CmdShowWindow_Click;
            this.cmdClose.Click += CmdClose_Click;
        }

        public NotifyIconWrapper(IContainer container) {
            container.Add(this);

            InitializeComponent();
        }

        private void CmdShowWindow_Click(object sender, EventArgs e) {
            if (window.WindowState == System.Windows.WindowState.Minimized) {
                window.WindowState = System.Windows.WindowState.Normal;
            }
            window.Show();
            window.Activate();
        }

        private void CmdClose_Click(object sender, EventArgs e) {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
