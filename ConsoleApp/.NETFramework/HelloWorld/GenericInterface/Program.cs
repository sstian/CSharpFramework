namespace GenericInterface {
    class Program {
        static void Main(string[] args) {
            Student<int> stu = new Student<int>();
            stu.ID = 101;
            stu.Name = "Tim";

            Student<ulong> stu2 = new Student<ulong>();
            stu2.ID = 102;
            stu.Name = "Jack";

            ULongStudent stu3 = new ULongStudent();
            stu3.ID = 100001;
            stu3.Name = "Tom";
        }
    }

    interface IUnique<TID> {
        TID ID { get; set; }
    }

    // 实现泛型接口的类也是泛型类
    class Student<TID> : IUnique<TID> {
        public TID ID { get; set; }
        public string  Name { get; set; }
    }

    // 实现泛型特化接口的类是特化类
    class ULongStudent : IUnique<ulong> {
        public ulong ID { get; set; }
        public string Name { get; set; }
    }

}
