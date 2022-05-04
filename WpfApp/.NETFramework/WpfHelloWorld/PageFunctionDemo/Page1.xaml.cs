using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PageFunctionDemo {
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page {
        public Page1() {
            InitializeComponent();
        }

        private void selectProduct_Click(object sender, RoutedEventArgs e) {
            PageFunction1 pageFunction1 = new PageFunction1();
            pageFunction1.Return += new ReturnEventHandler<Product>(PageFunction1_Return);
            this.NavigationService.Navigate(pageFunction1);
        }

        private void PageFunction1_Return(object sender, ReturnEventArgs<Product> e) {
            if (e != null) {
                this.labelStatus.Content = "Your choose: " + e.Result.Name;
            }
        }
    }
}
