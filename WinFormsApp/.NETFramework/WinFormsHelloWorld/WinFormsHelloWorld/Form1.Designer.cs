namespace WinFormsHelloWorld {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "倒计时";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "本场距离结束还有";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHour
            // 
            this.textBoxHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHour.CausesValidation = false;
            this.textBoxHour.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxHour.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxHour.ForeColor = System.Drawing.Color.White;
            this.textBoxHour.HideSelection = false;
            this.textBoxHour.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxHour.Location = new System.Drawing.Point(128, 189);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.ReadOnly = true;
            this.textBoxHour.ShortcutsEnabled = false;
            this.textBoxHour.Size = new System.Drawing.Size(33, 33);
            this.textBoxHour.TabIndex = 2;
            this.textBoxHour.TabStop = false;
            this.textBoxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMinute.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxMinute.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMinute.ForeColor = System.Drawing.Color.White;
            this.textBoxMinute.Location = new System.Drawing.Point(167, 189);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.ReadOnly = true;
            this.textBoxMinute.Size = new System.Drawing.Size(33, 33);
            this.textBoxMinute.TabIndex = 3;
            this.textBoxMinute.TabStop = false;
            this.textBoxMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSecond.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxSecond.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSecond.ForeColor = System.Drawing.Color.White;
            this.textBoxSecond.Location = new System.Drawing.Point(206, 189);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.ReadOnly = true;
            this.textBoxSecond.Size = new System.Drawing.Size(33, 33);
            this.textBoxSecond.TabIndex = 4;
            this.textBoxSecond.TabStop = false;
            this.textBoxSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(402, 318);
            this.Controls.Add(this.textBoxSecond);
            this.Controls.Add(this.textBoxMinute);
            this.Controls.Add(this.textBoxHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxSecond;
    }
}

