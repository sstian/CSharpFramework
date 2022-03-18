namespace MyCalendar {
    partial class Form1 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.myCalendar1 = new MyCalendar.StCalendar();
            this.SuspendLayout();
            // 
            // myCalendar1
            // 
            this.myCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myCalendar1.BackColor = System.Drawing.Color.White;
            this.myCalendar1.Location = new System.Drawing.Point(62, 50);
            this.myCalendar1.MaximumSize = new System.Drawing.Size(280, 280);
            this.myCalendar1.MinimumSize = new System.Drawing.Size(280, 280);
            this.myCalendar1.Name = "myCalendar1";
            this.myCalendar1.Size = new System.Drawing.Size(280, 280);
            this.myCalendar1.TabIndex = 0;
            this.myCalendar1.Text = "myCalendar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.myCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyCalendar.StCalendar myCalendar1;
    }
}

