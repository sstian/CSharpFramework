namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.buttonSay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(12, 12);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(258, 23);
            this.textBoxShow.TabIndex = 0;
            // 
            // buttonSay
            // 
            this.buttonSay.Location = new System.Drawing.Point(13, 42);
            this.buttonSay.Name = "buttonSay";
            this.buttonSay.Size = new System.Drawing.Size(257, 23);
            this.buttonSay.TabIndex = 1;
            this.buttonSay.Text = "Click Me";
            this.buttonSay.UseVisualStyleBackColor = true;
            this.buttonSay.Click += new System.EventHandler(this.buttonSay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSay);
            this.Controls.Add(this.textBoxShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.Button buttonSay;
    }
}

