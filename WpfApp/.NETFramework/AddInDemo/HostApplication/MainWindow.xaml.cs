using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.AddIn.Hosting;

namespace AddInDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            string path = Environment.CurrentDirectory;
            AddInStore.Update(path);

            IList<AddInToken> tokens = AddInStore.FindAddIns(typeof(HostView.ImageProcessorHostView), path);
            this.listAddIns.ItemsSource = tokens;
        }

        private void listAddIns_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            this.cmdProcessImage.IsEnabled = (this.listAddIns.SelectedIndex != -1);
        }

        private void cmdProcessImage_Click(object sender, RoutedEventArgs e) {
            BitmapSource originalSource = (BitmapSource)this.image.Source;
            int stride = originalSource.PixelWidth * originalSource.Format.BitsPerPixel / 8;
            stride += (stride % 4) * 4;
            byte[] originalPixels = new byte[stride * originalSource.PixelHeight * originalSource.Format.BitsPerPixel / 8];

            originalSource.CopyPixels(originalPixels, stride, 0);

            AddInToken token = (AddInToken)this.listAddIns.SelectedItem;
            HostView.ImageProcessorHostView addin = token.Activate<HostView.ImageProcessorHostView>(AddInSecurityLevel.Internet);
            byte[] changedPixels = addin.ProcessImageBytes(originalPixels);

            BitmapSource newSource = BitmapSource.Create(originalSource.PixelWidth, originalSource.PixelHeight, 
                originalSource.DpiX, originalSource.DpiY,
                PixelFormats.Bgr32,BitmapPalettes.Gray256, 
                changedPixels, stride);
            this.image.Source = newSource;
        }
    }
}
