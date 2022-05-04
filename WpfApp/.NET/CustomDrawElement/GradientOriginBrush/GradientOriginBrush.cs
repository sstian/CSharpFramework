using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace CustomDrawElement {
    public class GradientOriginBrush : FrameworkElement {

        // 定义属性
        public static DependencyProperty BackgroundColorProperty;
        static GradientOriginBrush() {
            var metadata = new FrameworkPropertyMetadata(Colors.YellowGreen);
            metadata.AffectsRender = true;
            BackgroundColorProperty = DependencyProperty.Register(
                "BackgroundColor", typeof(Color), typeof(GradientOriginBrush), metadata
                );
        }
        public Color BackgroundColor {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        // 捕获鼠标状态
        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
            this.InvalidateVisual();
        }
        protected override void OnMouseLeave(MouseEventArgs e) {
            base.OnMouseLeave(e);
            this.InvalidateVisual();
        }

        // 重写渲染
        protected override void OnRender(DrawingContext drawingContext) {
            base.OnRender(drawingContext);
            Rect bounds = new Rect(0, 0, base.ActualWidth, base.ActualHeight);
            drawingContext.DrawRectangle(GetForegroundBrush(), null, bounds);
        }
        private Brush GetForegroundBrush() {
            if (!IsMouseOver) {
                return new SolidColorBrush(BackgroundColor);
            }
            var brush = new RadialGradientBrush(Colors.White, BackgroundColor);
            Point absoluteGradientOrigin = Mouse.GetPosition(this);
            Point relativeGradientOrigin = new Point(
                absoluteGradientOrigin.X / base.ActualWidth,
                absoluteGradientOrigin.Y / base.ActualHeight
                );
            brush.GradientOrigin = relativeGradientOrigin;
            brush.Center = relativeGradientOrigin;
            return brush;
        }
    }
}
