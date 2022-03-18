using System;

namespace GenericClass {
    class Program {
        static void Main(string[] args) {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "C# Language" };
            Box<Apple> appleBox = new Box<Apple>() { Cargo = apple };
            Box<Book> bookBox = new Box<Book>() { Cargo = book };
            Console.WriteLine(appleBox.Cargo.Color);
            Console.WriteLine(bookBox.Cargo.Name);
            //Red
            //C# Language
        }
    }

    class Apple {
        public string Color { get; set; }
    }

    class Book {
        public string Name { get; set; }
    }

    // 泛型类
    class Box<TCargo> {
        public TCargo Cargo { get; set; }
    }
}
