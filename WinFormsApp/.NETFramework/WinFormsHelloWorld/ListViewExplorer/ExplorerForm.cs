using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ListViewExplorer {
    public partial class Form : System.Windows.Forms.Form {
        // 当前排序
        private readonly string SORT_ASC = "Sort_ASC";
        private readonly string SORT_DSC = "Sort_DSC";
        private bool asc = true;

        // 当前鼠标点击的项
        private ListViewItem mouseClickItem;

        public Form() {
            InitializeComponent();
            this.InitListView();
            this.LoadDir(new DirectoryInfo(@"E:\学习"));
        }

        private void InitListView() {
            // 设置显示模式，整行选中
            this.listView.View = View.Details;
            this.UpdateViewItemChecked();
            this.listView.FullRowSelect = true;
            this.listView.LabelEdit = true;
            // 设置列名，宽度-2表示自动调整
            this.listView.Columns.Add("文件名", -2, HorizontalAlignment.Left);
            this.listView.Columns.Add("修改日期", 150, HorizontalAlignment.Left);
            this.listView.Columns.Add("类型", 100, HorizontalAlignment.Left);
            this.listView.Columns.Add("大小", -2, HorizontalAlignment.Left);
            //// 添加数据项，设置子项
            //var item = new ListViewItem("C#学习指南", 0);
            //item.SubItems.Add("2022-01-25 14:20");
            //item.SubItems.Add("PDF");
            //item.SubItems.Add("192 KB");
            //this.listView.Items.Add(item);

            // 创建ImageList，添加图标
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(16, 16);
            imageList.Images.Add(Properties.Resources.file);
            imageList.Images.Add(Properties.Resources.folder);
            this.listView.SmallImageList = imageList;

            ImageList imageList2 = new ImageList();
            imageList2.ImageSize = new Size(64, 64);
            imageList2.Images.Add(Properties.Resources.file);
            imageList2.Images.Add(Properties.Resources.folder);
            this.listView.LargeImageList = imageList2;

            // 1. 添加图片资源
            // 2. 加入排序图标到列标题
            // public void ImageList.ImageCollection.Add(string key, Image image);
            imageList.Images.Add(this.SORT_ASC, Properties.Resources.sort_up);
            imageList.Images.Add(this.SORT_DSC, Properties.Resources.sort_down);
            this.listView.Columns[0].ImageKey = this.SORT_ASC;
        }

        private void LoadDir(DirectoryInfo dir) {
            // 子目录
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (var d in subDirs) {
                if ((d.Attributes & FileAttributes.Hidden) > 0)
                    continue;
                var tag = new MyListItemTag();
                tag.path = d.FullName;
                tag.name = d.Name;
                tag.time = d.LastWriteTime;
                tag.type = 1;
                tag.size = -1;
                tag.ext = "文件夹";
                this.AddListItem(tag);
            }
            // 子文件
            FileInfo[] subFiles = dir.GetFiles();
            foreach (var f in subFiles) {
                if ((f.Attributes & FileAttributes.Hidden) > 0)
                    continue;
                var tag = new MyListItemTag();
                tag.path = f.FullName;
                tag.name = f.Name;
                tag.time = f.LastWriteTime;
                tag.type = 0;
                tag.size = f.Length;
                tag.ext = f.Extension.ToUpper();
                this.AddListItem(tag);
            }
        }

        private void AddListItem(MyListItemTag tag) {
            // 文件/文件夹 图标
            int imageIndex = 0;
            if (tag.type == 1) {
                imageIndex = 1;
            }
            var item = new ListViewItem(tag.name, imageIndex);
            item.Tag = tag;

            // 时间
            item.SubItems.Add(tag.time.ToString("yyyy:MM:dd hh:mm"));
            // 类型
            item.SubItems.Add(tag.ext);
            // 文件大小
            long size = tag.size;
            string sizeStr = "";
            if (size < 0)
                sizeStr = "";
            else if (size < 1000)
                sizeStr = size + " B";
            else if (size < 1000000)
                sizeStr = size / 1000 + " KB";
            else if (size < 1000000000)
                sizeStr = size / 1000000 + " MB";
            else
                sizeStr = size / 1000000000 + " GB";
            item.SubItems.Add(sizeStr);
            this.listView.Items.Add(item);
        }

        private void UpdateViewItemChecked() {
            View view = this.listView.View;
            // 显示 菜单
            this.menuViewLargeIcon.Checked = (view == View.LargeIcon);
            this.menuViewSmallIcon.Checked = (view == View.SmallIcon);
            this.menuViewList.Checked = (view == View.List);
            this.menuViewDetails.Checked = (view == View.Details);
            this.menuViewTile.Checked = (view == View.Tile);
            // 显示 右键菜单
            this.contextMenuViewLargeIcon.Checked = (view == View.LargeIcon);
            this.contextMenuViewSmallIcon.Checked = (view == View.SmallIcon);
            this.contextMenuViewList.Checked = (view == View.List);
            this.contextMenuViewDetails.Checked = (view == View.Details);
            this.contextMenuViewTile.Checked = (view == View.Tile);
        }

        private void menuViewLargeIcon_Click(object sender, EventArgs e) {
            this.listView.View = View.LargeIcon;
            this.UpdateViewItemChecked();
        }

        private void menuViewSmallIcon_Click(object sender, EventArgs e) {
            this.listView.View = View.SmallIcon;
            this.UpdateViewItemChecked();
        }

        private void menuViewList_Click(object sender, EventArgs e) {
            this.listView.View = View.List;
            this.UpdateViewItemChecked();
        }

        private void menuViewDetails_Click(object sender, EventArgs e) {
            this.listView.View = View.Details;
            this.UpdateViewItemChecked();
        }

        private void menuViewTile_Click(object sender, EventArgs e) {
            this.listView.View = View.Tile;
            this.UpdateViewItemChecked();
        }

        // 鼠标右键点击，快捷菜单
        private void listView_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ListViewItem item = this.listView.GetItemAt(e.X, e.Y);
                // 重命名 1.
                this.mouseClickItem = item;
                this.contextMenuRename.Enabled = (item != null);
                // 根据当前的显示模式，设置菜单项的状态
                this.UpdateViewItemChecked();
                this.contextMenuStrip.Show(this.listView, e.Location);
            }
        }

        // 3. 添加 ColumnClick 事件，仅处理第一列
        private void listView_ColumnClick(object sender, ColumnClickEventArgs e) {
            if (e.Column == 0) {
                this.asc = !this.asc;
                if (this.asc) {
                    // 4. 排序
                    this.listView.ListViewItemSorter = new MyListItemSorter(true);
                    this.listView.Sort();
                    this.listView.Columns[0].ImageKey = this.SORT_ASC;
                } else {
                    this.listView.ListViewItemSorter = new MyListItemSorter(false);
                    this.listView.Sort();
                    this.listView.Columns[0].ImageKey = this.SORT_DSC;
                }
            }
        }

        // // 重命名 2.
        private void contextMenuRename_Click(object sender, EventArgs e) {
            this.mouseClickItem.BeginEdit();
        }

        private void listView_BeforeLabelEdit(object sender, LabelEditEventArgs e) {

        }

        // // 重命名 3.
        private void listView_AfterLabelEdit(object sender, LabelEditEventArgs e) {
            int index = e.Item;     // 当前项的索引
            string label = e.Label; // 新输入的文本
            // 检查是否冲突
            int count = this.listView.Items.Count;
            for (int i = 0; i < count; i++) {
                if (index == i)
                    continue;
                if (label == this.listView.Items[i].Text) {
                    e.CancelEdit = true;
                    MessageBox.Show("名字重复！", "提示");
                    return;
                }
            }
            // 接受此输入
            e.CancelEdit = false;
            // 更新数据...
        }
    }
}
