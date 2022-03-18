using Newtonsoft.Json;
using St.Common;
using System;
using System.Text;
using System.Windows.Forms;

namespace StudentInfoEditor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            sexField.Items.Add("女");
            sexField.Items.Add("男");

            LoadData();
        }

        private void LoadData() {
            // 读取文件，转成JSON，界面显示
            string content = TextFile.Read(@"data\student.json", Encoding.UTF8);
            // Student student = (Student)JsonConvert.DeserializeObject(content, typeof(Student));
            Student student = JsonConvert.DeserializeObject<Student>(content);
            Console.WriteLine(student);
            idField.Text = student.ID.ToString();
            nameField.Text = student.Name;
            sexField.Text = (student.Sex ? "男" : "女");
            phoneField.Text = student.Phone;
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            Student student = new Student();
            student.ID = Convert.ToInt32(idField.Text.Trim());
            student.Name = nameField.Text.Trim();
            student.Sex = (sexField.SelectedIndex == 1);
            student.Phone = phoneField.Text.Trim();

            // JSON支持：Newtonsoft.Json
            string jsonStr = JsonConvert.SerializeObject(student, Formatting.Indented);
            TextFile.Write(@"data\student.json", jsonStr, Encoding.UTF8);
            MessageBox.Show("操作成功");
        }
    }
}
