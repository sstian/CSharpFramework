using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PageFunctionDemo {
    /// <summary>
    /// PageFunction1.xaml 的交互逻辑
    /// </summary>
    public partial class PageFunction1 : PageFunction<Product> {
        public PageFunction1() {
            InitializeComponent();
        }

        private void linkOK_Click(object sender, RoutedEventArgs e) {
            ListBoxItem item = (ListBoxItem)listProducts.SelectedItem;
            Product product = new Product(item.Content.ToString());
            OnReturn(new ReturnEventArgs<Product>(product));
        }

        private void linkCancel_Click(object sender, RoutedEventArgs e) {
            OnReturn(null);
        }
    }

    public class Product {
        public string Name { get; set; }

        public Product(string name) {
            Name = name;
        }
    }
}
