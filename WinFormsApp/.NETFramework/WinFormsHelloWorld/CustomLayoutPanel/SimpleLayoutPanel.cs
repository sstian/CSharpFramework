using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace CustomLayoutPanel {
    class SimpleLayoutPanel : Panel {
        // 布局器
        private LayoutEngine layoutEngine = new SimpleLayoutEngine();
        public override LayoutEngine LayoutEngine {
            get { return layoutEngine; }
        }

        class SimpleLayoutEngine : LayoutEngine {
            public override bool Layout(
                object container, 
                LayoutEventArgs layoutEventArgs) {
                // 容器
                SimpleLayoutPanel panel = (SimpleLayoutPanel)container;
                int width = panel.Width;
                int height = panel.Height;

                // 去除Padding
                int x = panel.Padding.Left;
                int y = panel.Padding.Top;
                width -= panel.Padding.Left + panel.Padding.Right;
                height -= panel.Padding.Top + panel.Padding.Bottom;

                int gap = 2;
                foreach (Control control in panel.Controls) {
                    control.Location = new Point(x, y);
                    control.Size = new Size(width, control.PreferredSize.Height);
                    y += control.Size.Height + gap;
                }
                return false;
                //return base.Layout(container, layoutEventArgs);
            }
        }
    }
}
