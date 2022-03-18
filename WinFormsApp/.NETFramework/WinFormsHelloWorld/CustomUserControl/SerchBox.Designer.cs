namespace CustomUserControl {
    partial class SerchBox {
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.edit = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.edit.Location = new System.Drawing.Point(0, 0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(100, 14);
            this.edit.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Window;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search.Image = global::CustomUserControl.Properties.Resources.img_search;
            this.search.Location = new System.Drawing.Point(100, 0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(14, 14);
            this.search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search.TabIndex = 1;
            this.search.TabStop = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SerchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.search);
            this.Controls.Add(this.edit);
            this.Name = "SerchBox";
            this.Size = new System.Drawing.Size(114, 14);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edit;
        private System.Windows.Forms.PictureBox search;
    }
}
