namespace StudentInfoEditor {
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.idField = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.sexField = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.idField, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSex, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameField, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.phoneField, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.sexField, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.80723F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.19277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // idField
            // 
            this.idField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idField.Location = new System.Drawing.Point(70, 10);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(200, 21);
            this.idField.TabIndex = 1;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelId.Location = new System.Drawing.Point(23, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 41);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "学号";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(23, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 39);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "姓名";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSex.Location = new System.Drawing.Point(23, 80);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(41, 37);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "性别";
            this.labelSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPhone.Location = new System.Drawing.Point(23, 117);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 39);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "手机号";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameField
            // 
            this.nameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameField.Location = new System.Drawing.Point(70, 50);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(200, 21);
            this.nameField.TabIndex = 5;
            // 
            // phoneField
            // 
            this.phoneField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneField.Location = new System.Drawing.Point(70, 126);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(200, 21);
            this.phoneField.TabIndex = 7;
            // 
            // sexField
            // 
            this.sexField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexField.FormattingEnabled = true;
            this.sexField.Location = new System.Drawing.Point(70, 88);
            this.sexField.Name = "sexField";
            this.sexField.Size = new System.Drawing.Size(200, 20);
            this.sexField.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(281, 195);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 35);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInfoEditor.Properties.Resources.img_blue;
            this.ClientSize = new System.Drawing.Size(405, 242);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox sexField;
    }
}

