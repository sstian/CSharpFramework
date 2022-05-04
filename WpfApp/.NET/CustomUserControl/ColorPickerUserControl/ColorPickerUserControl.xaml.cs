using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomUserControl {
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class ColorPickerUserControl : UserControl {
        public ColorPickerUserControl() {
            InitializeComponent();
        }

        // 包装成依赖项属性
        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;

        // 注册依赖项属性
        static ColorPickerUserControl() {
            ColorProperty = DependencyProperty.Register(
                "Color", 
                typeof(Color), 
                typeof(ColorPickerUserControl), 
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged))
                );
            RedProperty = DependencyProperty.Register(
                "Red", 
                typeof(byte), 
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorRGBChanged))
                );
            GreenProperty = DependencyProperty.Register(
                "Green", 
                typeof(byte), 
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorRGBChanged))
                );
            BlueProperty = DependencyProperty.Register(
                "Blue", 
                typeof(byte), 
                typeof(ColorPickerUserControl),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorRGBChanged))
                );
        }

        // 定义属性，供使用
        public Color Color { 
            get { return (Color)GetValue(ColorProperty); } 
            set { SetValue(ColorProperty, value); }
        }
        public byte Red {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }
        public byte Green {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }
        public byte Blue {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }

        private static void OnColorRGBChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var colorPicker = (ColorPickerUserControl)d;
            Color color = colorPicker.Color;
            if (e.Property == RedProperty) {
                color.R = (byte)e.NewValue;
            } else if (e.Property == GreenProperty) {
                color.G = (byte)e.NewValue;
            } else if (e.Property == BlueProperty) {
                color.B = (byte)e.NewValue;
            }
            colorPicker.Color = color;
        }

        private static void OnColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            var colorPicker = (ColorPickerUserControl)d;
            Color oldColor = (Color)e.OldValue;
            Color newColor = (Color)e.NewValue;

            colorPicker.Red = newColor.R;
            colorPicker.Green = newColor.G;
            colorPicker.Blue = newColor.B;
            colorPicker.OnColorChanged(oldColor, newColor);
        }

        private void OnColorChanged(Color oldValue, Color newValue) {
            var args = new RoutedPropertyChangedEventArgs<Color>(oldValue, newValue);
            args.RoutedEvent = ColorChangedEvent;
            RaiseEvent(args);
        }

        // 包装成路由事件并注册
        public static readonly RoutedEvent ColorChangedEvent = 
            EventManager.RegisterRoutedEvent(
                "ColorChanged", 
                RoutingStrategy.Bubble, 
                typeof(RoutedPropertyChangedEventHandler<Color>), 
                typeof(ColorPickerUserControl)
                );

        // 定义事件，供使用
        public event RoutedPropertyChangedEventHandler<Color> ColorChanged {
            add { AddHandler(ColorChangedEvent, value); }
            remove { RemoveHandler(ColorChangedEvent, value); }
        }
    }
}