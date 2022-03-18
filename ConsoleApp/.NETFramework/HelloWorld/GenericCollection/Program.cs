using System;
using System.Collections.Generic;

namespace GenericCollection {
    class Program {
        static void Main(string[] args) {
            IList<int> list = new List<int>();
            for (int i = 0; i < 3; i++) {
                list.Add(i+1);
            }

            foreach (var item in list) {
                Console.WriteLine(item);
            }
            //1
            //2
            //3

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "Tim";
            dict[2] = "Jack";
            Console.WriteLine($"Student #1 is {dict[1]}");
            Console.WriteLine($"Student #2 is {dict[2]}");
            //Student #1 is Tim
            //Student #2 is Jack
        }
    }
}
