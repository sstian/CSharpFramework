namespace StudentInfoEditor {
    class Student {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }

        public Student() {
        }

        public Student(int iD, string name, bool sex, string phone) {
            ID = iD;
            Name = name;
            Sex = sex;
            Phone = phone;
        }
    }
}

