using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AnimationCompositionTargetRendering {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        // 定义一系列描述矩形的变量
        private List<EllipseInfo> ellipses = new List<EllipseInfo>();
        private int minStartingSpeed = 1;
        private int maxStartingSpeed = 50;
        private double accelerationY = 0.1;
        private double speedRatio = 0.1;
        private int minEllipses = 20;
        private int maxEllipses = 100;
        private int ellipseRadius = 10;
        private bool rendering = false;

        public class EllipseInfo {
            public Ellipse Ellipse { get; set; }
            public double VelocityY { get; set; }

            public EllipseInfo(Ellipse ellipse, double velocityY) {
                Ellipse = ellipse ?? throw new ArgumentNullException(nameof(ellipse));
                VelocityY = velocityY;
            }
        }

        private void Start_Click(object sender, RoutedEventArgs e) {
            if(!this.rendering) {
                this.ellipses.Clear();
                this.canvas.Children.Clear();
                CompositionTarget.Rendering += RenderFrame;
                this.rendering = true;
            }
        }

        private void RenderFrame(object sender, EventArgs e) {
            if(this.ellipses.Count == 0) {
                // 动画刚开始，创建椭圆
                int canvasWidth = (int)(this.canvas.ActualWidth);
                Random random = new Random();
                // 随机产生椭圆的数量
                int ellipseCount = random.Next(this.minEllipses, this.maxEllipses);
                for (int i = 0; i < ellipseCount; i++) {
                    Ellipse ellipse = new Ellipse();
                    ellipse.Fill = Brushes.LimeGreen;
                    ellipse.Width = this.ellipseRadius;
                    ellipse.Height = this.ellipseRadius;
                    Canvas.SetLeft(ellipse, random.Next(0, canvasWidth));
                    Canvas.SetTop(ellipse, 0);
                    this.canvas.Children.Add(ellipse);
                    EllipseInfo ellipseInfo = new EllipseInfo(
                        ellipse, 
                        this.speedRatio * random.Next(this.minStartingSpeed, this.maxStartingSpeed));
                    this.ellipses.Add(ellipseInfo);
                }
            } else {
                for (int i = 0; i < this.ellipses.Count; i++) {
                    EllipseInfo ellipseInfo = this.ellipses[i];
                    double top = Canvas.GetTop(ellipseInfo.Ellipse);
                    Canvas.SetTop(ellipseInfo.Ellipse, top + ellipseInfo.VelocityY);
                    if (top >= (this.canvas.ActualHeight - this.ellipseRadius * 2 - 10)) {
                        this.ellipses.Remove(ellipseInfo);
                    } else {
                        ellipseInfo.VelocityY += this.accelerationY;
                    }
                    if (this.ellipses.Count == 0) {
                        this.StopRendering();
                    }
                }
            }
        }

        private void StopRendering() {
            CompositionTarget.Rendering -= RenderFrame;
            this.rendering = false;
        }

        private void Stop_Click(object sender, RoutedEventArgs e) {
            this.StopRendering();
        }
    }
}
