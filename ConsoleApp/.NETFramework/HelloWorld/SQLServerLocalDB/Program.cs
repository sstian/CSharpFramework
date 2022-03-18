using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLServerLocalDB {
    class Program {
        static void Main(string[] args) {
            var dbContext = new Entities();
            int count = dbContext.Book.Count();
            Console.WriteLine(count);

            List<Book> list = dbContext.Book
                .Where(book => book.Name.Contains("C#")).ToList();
            foreach (var item in list) {
                Console.WriteLine($"{item.ID}, {item.Name}, {item.Price}");
            }
        }
    }
}
