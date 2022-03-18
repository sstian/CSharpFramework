using System.Collections;
using System.Windows.Forms;

namespace ListViewExplorer {
    // 6. 定义比较器
    public class MyListItemSorter : IComparer {
        private bool asc = true;

        public MyListItemSorter(bool asc) {
            this.asc = asc;
        }

        public int Compare(object x, object y) {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;

            // Tag: 每一项关联的数据
            MyListItemTag tag1 = (MyListItemTag)item1.Tag;
            MyListItemTag tag2 = (MyListItemTag)item2.Tag;

            // 目录在前，文件在后
            if (tag1.type != tag2.type)
                return CompareInt(false, tag1.type, tag2.type);
            // 按名字比较
            return CompareStringIgnoreCase(this.asc, tag1.name, tag2.name);
        }

        // 比较Bool值
        private int CompareBool(bool asc, bool x, bool y) {
            int xx = x ? 1 : 0;
            int yy = y ? 1 : 0;
            return CompareInt(asc, xx, yy);
        }

        // 比较Int值
        private int CompareInt(bool asc, int x, int y) {
            return (asc ? x - y : y - x);
        }

        // 比较String值
        private int CompareString(bool asc, string x, string y) {
            return (asc ? x.CompareTo(y) : y.CompareTo(x));
        }

        // 比较String值，不区分大小写
        private int CompareStringIgnoreCase(bool asc, string x, string y) {
            return CompareString(asc, x.ToLower(), y.ToLower());
        }
    }
}