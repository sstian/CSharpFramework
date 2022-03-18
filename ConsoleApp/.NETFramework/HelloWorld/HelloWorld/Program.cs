using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Form
using System.Collections;
using MyLibrary;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World! - .NET Framework");

            //Form form = new Form();
            //form.ShowDialog();

            //System.Windows.Window window = new System.Windows.Window();
            //window.ShowDialog();

            //double result = Calculator.Add(1.2, 2.3);
            //Console.WriteLine(result);

            //int sum = Calculator.SumFrom1ToX(100);
            //Console.WriteLine(sum);

            //BadGuy bg = new BadGuy();
            //// bg.StackOverflow();
            //bg.StackOverflowWithUnsafeBlock();

            //Student stu = new Student();
            //Console.WriteLine(stu.id);
            //Console.WriteLine(stu.name);

            //Type type = typeof(int);
            //Console.WriteLine(type.FullName);
            //Console.WriteLine(type.Namespace);
            //Console.WriteLine(type.Name);
            //foreach (var method in type.GetMethods())
            //{
            //    Console.WriteLine(method.Name);
            //}
            //Console.WriteLine(type.GetMethods().Length);
            ////System.Int32
            ////System
            ////Int32
            ////CompareTo
            ////CompareTo
            ////Equals
            ////Equals
            ////GetHashCode
            ////ToString
            ////ToString
            ////ToString
            ////ToString
            ////Parse
            ////Parse
            ////Parse
            ////Parse
            ////TryParse
            ////TryParse
            ////GetTypeCode
            ////GetType
            ////17

            //int a = default(int);
            //Console.WriteLine(a); // 0

            //Form form = new Form() { Text = "Hello", FormBorderStyle = FormBorderStyle.SizableToolWindow };
            //form.ShowDialog();

            //new Form() { Text = "HHH" }.ShowDialog();

            //var person = new { Name = "Mr.OK", Age = 20 };
            //Console.WriteLine(person.GetType().FullName);
            //// <>f__AnonymousType0`2[[System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]

            //Professor prof = new Professor();
            //prof.Report();
            //CSProfessor csProf = new CSProfessor();
            //csProf.Report();
            //// I am a professor
            //// I am a CS professor

            //uint x = uint.MaxValue;
            //string binStr = Convert.ToString(x, 2);
            //Console.WriteLine(binStr);
            //try
            //{
            //    uint y = checked(x + 1);  // 11111111111111111111111111111111
            //    // uint y = unchecked(x + 1);  // 0
            //    Console.WriteLine(y);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine(ex);
            //}

            //checked // unchecked
            //{
            //    try
            //    {
            //        uint y = x + 1;
            //        Console.WriteLine(y);
            //    }
            //    catch (OverflowException ex)
            //    {
            //        Console.WriteLine(ex);
            //    }
            //}

            //unsafe
            //{
            //    int x = sizeof(User);
            //    Console.WriteLine(x);  // 16

            //    User user;
            //    user.id = 1;
            //    user.score = 99;
            //    User* pUser = &user;
            //    pUser->score = 100;
            //    (*pUser).score = 999;
            //    Console.WriteLine(user.score);  // 999
            //}

            //Student stu = new Student(null);
            //Console.WriteLine(stu.name);
            //// 未经处理的异常:  System.ArgumentException: name cannot be null or empty

            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //int x = Convert.ToInt32(str1);
            //int y = Convert.ToInt32(str2);
            //Console.WriteLine(x + y);

            //double x = System.Convert.ToDouble(text1);
            //double y = System.Convert.ToDouble(text2);
            //double x2 = double.Parse(text1);
            //double y2 = double.Parse(text2);
            //double.TryParse(text1, result);
            //double result = x + y;
            //string text3 = result.ToString();

            //Stone stone = new Stone();
            //stone.age = 50000;
            //Monkey sunwukong = (Monkey)stone;
            //// Monkey sunwukong = stone;
            //Console.WriteLine(sunwukong.age);  // 100

            //double a = double.PositiveInfinity;
            //double b = double.NegativeInfinity;

            //Nullable<int> x = null;
            //Console.WriteLine(x.HasValue);  // False

            //int[] intArray = new int[] { 1, 2, 3 };
            //// List<int> intList = new List<int>() { 1, 2, 3 };
            //IEnumerator enumerator = intArray.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //foreach (var item in intArray)
            //{
            //    Console.WriteLine(item);
            //}

            //Employee employee = new Employee();
            //employee.Age = 20;
            //Console.WriteLine(employee.Age);
            //Console.WriteLine(Employee.Account);
            //Console.WriteLine($"you are {employee.Age} years old.");

            //var values = Enumerable.Range(0, 5).ToArray();
            //foreach (var value in values) {
            //    Console.Write($"{value} ");
            //}
            //// 0 1 2 3 4 

            string text = "3.14";
            string text2 = "3.14aaa";
            //double res = 0.0; 
            //double.TryParse(text, out res);
            double.TryParse(text, out double result);
            Console.WriteLine(result);  // 3.14
            double.TryParse(text2, out result);
            Console.WriteLine(result);  // 0
        }

        class BadGuy
        {
            // method 1
            public unsafe void StackOverflow()
            {
                int* p = stackalloc int[9999999];
            }
            // method 2
            public void StackOverflowWithUnsafeBlock()
            {
                unsafe
                {
                    int* p = stackalloc int[9999999];
                }
            }
        }

        class Student
        {
            public Student(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentException("name cannot be null or empty");
                }
                this.name = name;
            }
            public int id;
            public string name;
        }
    
        class Professor
        {
            public void Report()
            {
                Console.WriteLine("I am a professor");
            }
        }
    
        class CSProfessor : Professor
        {
            new public void Report()
            {
                Console.WriteLine("I am a CS professor");
            }
        }

        struct User
        {
            public int id;
            public long score;
        }

        class Stone
        {
            public int age;
            public static explicit operator Monkey(Stone stone)
            {
                Monkey monkey = new Monkey();
                monkey.age = stone.age / 500;
                return monkey;
            }
        }
        class Monkey
        {
            public int age;
        }

        class Employee
        {
            public int Age { get; set; }
            public const int Account = 100;
            
        }
    }
}
