using System;

namespace ClassDemo {
    class Program {
        static void Main(string[] args) {
            // 获取类型
            Type type = typeof(Student);
            // 1 反射创建实例
            object o = Activator.CreateInstance(type, 1, "Jack");
            Student stu = o as Student;
            Console.WriteLine($"I am {stu.Name}.");
            // 2 动态类型
            dynamic stu2 = Activator.CreateInstance(type, 2, "Tom");
            Console.WriteLine($"I am {stu2.Name}.");

            // 静态属性
            Student stu3 = new Student(3, "Tim");
            stu.Report();
            Console.WriteLine($"Student.Amount = {Student.Amount}");
            //I am Jack.
            //I am Tom.
            //Student.Report(): I'm student #1, named Jack.
            //Student.Amount = 103
            //Student.~Student(): Bye bye student #3: Tim.
            //Student.~Student(): Bye bye student #1: Jack.
            //Student.~Student(): Bye bye student #2: Tom.
        }
    }

    class Student {
        public int ID { get; set; }
        public string Name { get; set; }
        
        // 静态属性
        public static int Amount { get; set; }
        // 静态构造器
        static Student() {
            Student.Amount = 100;
        }

        public Student(int id, string name) {
            this.ID = id;
            this.Name = name;
            Amount++;
        }

        // 析构器
        ~Student() {
            Console.WriteLine($"Student.~Student(): Bye bye student #{this.ID}: {this.Name}.");
            Amount--;
        }

        public void Report() {
            Console.WriteLine($"Student.Report(): I'm student #{this.ID}, named {this.Name}.");
        }
    }
}
