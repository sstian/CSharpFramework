using System;

namespace ListViewExplorer {
    // 5. 定义数据项
    public class MyListItemTag {
        public int type = 0;    // 0 - 文件； 1 - 文件夹
        public string path;
        public string name;
        public DateTime time;
        public long size = -1;
        public string ext;
    }
}