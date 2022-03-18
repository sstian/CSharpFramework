namespace ListViewExplorer {
    partial class Form {
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuViewLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuViewSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuViewList = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar2 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuViewTile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuView});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuViewLargeIcon,
            this.menuViewSmallIcon,
            this.menuViewList,
            this.menuViewDetails,
            this.menuViewTile});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 21);
            this.menuView.Text = "显示";
            // 
            // menuViewLargeIcon
            // 
            this.menuViewLargeIcon.Name = "menuViewLargeIcon";
            this.menuViewLargeIcon.Size = new System.Drawing.Size(180, 22);
            this.menuViewLargeIcon.Text = "大图标";
            this.menuViewLargeIcon.Click += new System.EventHandler(this.menuViewLargeIcon_Click);
            // 
            // menuViewSmallIcon
            // 
            this.menuViewSmallIcon.Name = "menuViewSmallIcon";
            this.menuViewSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.menuViewSmallIcon.Text = "小图标";
            this.menuViewSmallIcon.Click += new System.EventHandler(this.menuViewSmallIcon_Click);
            // 
            // menuViewList
            // 
            this.menuViewList.Name = "menuViewList";
            this.menuViewList.Size = new System.Drawing.Size(180, 22);
            this.menuViewList.Text = "列表";
            this.menuViewList.Click += new System.EventHandler(this.menuViewList_Click);
            // 
            // menuViewDetails
            // 
            this.menuViewDetails.Name = "menuViewDetails";
            this.menuViewDetails.Size = new System.Drawing.Size(180, 22);
            this.menuViewDetails.Text = "详细信息";
            this.menuViewDetails.Click += new System.EventHandler(this.menuViewDetails_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuView,
            this.contextMenuRename});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(113, 48);
            // 
            // contextMenuView
            // 
            this.contextMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuViewLargeIcon,
            this.contextMenuViewSmallIcon,
            this.contextMenuViewList,
            this.contextMenuViewDetails,
            this.contextMenuViewTile});
            this.contextMenuView.Name = "contextMenuView";
            this.contextMenuView.Size = new System.Drawing.Size(180, 22);
            this.contextMenuView.Text = "显示";
            // 
            // contextMenuViewLargeIcon
            // 
            this.contextMenuViewLargeIcon.Name = "contextMenuViewLargeIcon";
            this.contextMenuViewLargeIcon.Size = new System.Drawing.Size(180, 22);
            this.contextMenuViewLargeIcon.Text = "大图标";
            this.contextMenuViewLargeIcon.Click += new System.EventHandler(this.menuViewLargeIcon_Click);
            // 
            // contextMenuViewSmallIcon
            // 
            this.contextMenuViewSmallIcon.Name = "contextMenuViewSmallIcon";
            this.contextMenuViewSmallIcon.Size = new System.Drawing.Size(180, 22);
            this.contextMenuViewSmallIcon.Text = "小图标";
            this.contextMenuViewSmallIcon.Click += new System.EventHandler(this.menuViewSmallIcon_Click);
            // 
            // contextMenuViewList
            // 
            this.contextMenuViewList.Name = "contextMenuViewList";
            this.contextMenuViewList.Size = new System.Drawing.Size(180, 22);
            this.contextMenuViewList.Text = "列表";
            this.contextMenuViewList.Click += new System.EventHandler(this.menuViewList_Click);
            // 
            // contextMenuViewDetails
            // 
            this.contextMenuViewDetails.Name = "contextMenuViewDetails";
            this.contextMenuViewDetails.Size = new System.Drawing.Size(180, 22);
            this.contextMenuViewDetails.Text = "详细信息";
            this.contextMenuViewDetails.Click += new System.EventHandler(this.menuViewDetails_Click);
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 358);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_AfterLabelEdit);
            this.listView.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView_BeforeLabelEdit);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar2});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel.Text = "Hurry up!";
            this.toolStripStatusLabel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripProgressBar2
            // 
            this.toolStripProgressBar2.Name = "toolStripProgressBar2";
            this.toolStripProgressBar2.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar2.ToolTipText = "I am Spider Man";
            this.toolStripProgressBar2.Value = 70;
            // 
            // menuViewTile
            // 
            this.menuViewTile.Name = "menuViewTile";
            this.menuViewTile.Size = new System.Drawing.Size(180, 22);
            this.menuViewTile.Text = "平铺";
            this.menuViewTile.Click += new System.EventHandler(this.menuViewTile_Click);
            // 
            // contextMenuViewTile
            // 
            this.contextMenuViewTile.Name = "contextMenuViewTile";
            this.contextMenuViewTile.Size = new System.Drawing.Size(180, 22);
            this.contextMenuViewTile.Text = "平铺";
            this.contextMenuViewTile.Click += new System.EventHandler(this.menuViewTile_Click);
            // 
            // contextMenuRename
            // 
            this.contextMenuRename.Name = "contextMenuRename";
            this.contextMenuRename.Size = new System.Drawing.Size(180, 22);
            this.contextMenuRename.Text = "重命名";
            this.contextMenuRename.Click += new System.EventHandler(this.contextMenuRename_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "ListViewExplorer";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem menuViewSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem menuViewList;
        private System.Windows.Forms.ToolStripMenuItem menuViewDetails;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem contextMenuView;
        private System.Windows.Forms.ToolStripMenuItem contextMenuViewLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem contextMenuViewSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem contextMenuViewList;
        private System.Windows.Forms.ToolStripMenuItem contextMenuViewDetails;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar2;
        private System.Windows.Forms.ToolStripMenuItem menuViewTile;
        private System.Windows.Forms.ToolStripMenuItem contextMenuViewTile;
        private System.Windows.Forms.ToolStripMenuItem contextMenuRename;
    }
}

