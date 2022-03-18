using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomUserControl {
    public partial class SerchBox : UserControl {
        public SerchBox() {
            InitializeComponent();
        }

        // 自定义属性
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("搜索文本")]
        public string SearchText {
            get { return edit.Text; }
            set { edit.Text = value; }
        }

        // 重写属性
        public override string Text {
            get => edit.Text;
            set => edit.Text = value;
        }

        // 自定义事件
        public event EventHandler SearchEvent;
        // 当点击按钮时，触发自定义事件
        private void search_Click(object sender, EventArgs e) {
            SearchEvent?.Invoke(this, e);
        }
    }
}
