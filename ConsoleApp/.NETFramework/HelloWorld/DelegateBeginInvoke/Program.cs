using System;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateBeginInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Red };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Blue };

            Action action1 = new Action(stu1.doHomework);
            Action action2 = new Action(stu2.doHomework);
            Action action3 = new Action(stu3.doHomework);

            // 间接同步调用：多播委托
            //action1 += action2;
            //action1 += action3;
            //action1.Invoke();

            // 隐式异步调用：委托的BeginInvoke()
            //action1.BeginInvoke(null, null);
            //action2.BeginInvoke(null, null);
            //action3.BeginInvoke(null, null);

            // 显式异步调用：Thread
            //Thread thread1 = new Thread(new ThreadStart(stu1.doHomework));
            //Thread thread2 = new Thread(new ThreadStart(stu2.doHomework));
            //Thread thread3 = new Thread(new ThreadStart(stu3.doHomework));
            //thread1.Start();
            //thread2.Start();
            //thread3.Start();

            // 显式异步调用：Task
            Task task1 = new Task(new Action(stu1.doHomework));
            Task task2 = new Task(new Action(stu1.doHomework));
            Task task3 = new Task(new Action(stu1.doHomework));
            task1.Start();
            task2.Start();
            task3.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }

        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void doHomework()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} is doing howework during {1} hour(s).",
                    this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
