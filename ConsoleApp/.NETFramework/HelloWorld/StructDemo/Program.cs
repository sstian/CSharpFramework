using System;

namespace StructDemo {
    class Program {
        static void Main(string[] args) {
            Student stu = new Student() { ID = 101, Name = "Tim" };
            // 装箱：值类型 -> 引用类型，栈空间 -> 堆空间
            object obj = stu;
            // 拆箱：引用类型 -> 值类型，堆空间 -> 栈空间
            Student stu2 = (Student)obj;
            Console.WriteLine($"Student #{stu2.ID} name: {stu2.Name}.");
            stu2.Speak();

            Student stu3 = new Student(103, "Jack");
            stu3.Speak();
            //Student #101 name: Tim.
            //I'm student #101 name: Tim.
            //I'm student #103 name: Jack.
        }
    }

    interface ISpeak {
        void Speak();
    }

    // 结构体是值类型
    // 结构体可以实现接口，但不能派生类
    struct Student : ISpeak {
        // 结构体可以有带参构造函数，但不能有无参构造函数
        public Student(int id, string name) {
            this.ID = id;
            this.Name = name;
        }

        public int ID { get; set; }
        public string  Name { get; set; }

        public void Speak() {
            Console.WriteLine($"I'm student #{ID} name: {Name}.");
        }
    }
}
