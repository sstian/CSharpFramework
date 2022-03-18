using BabyStroller.SDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace BabyStroller.App {
    class Program {
        static void Main(string[] args) {
            // 加载扩展程序集
            // Console.WriteLine(Environment.CurrentDirectory);
            // D:\Develop\CSharpSolutions\ConsoleApp\.NETCore\BabyStroller\BabyStroller.App\bin\Debug\netcoreapp3.1
            string folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            string[] filePaths = Directory.GetFiles(folder);
            var animalTypes = new List<Type>();
            foreach (var filePath in filePaths) {
                Assembly assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(filePath);
                Type[] types = assembly.GetTypes();
                foreach (var type in types) {
                    if (type.GetInterfaces().Contains(typeof(IAnimal))
                        && !type.GetCustomAttributes(false).Any(a => a.GetType() == typeof(UnfinishedAttribute))) {
                        animalTypes.Add(type);
                    }
                }
            }

            // 主程序循环
            while (true) {
                for (int i = 0; i < animalTypes.Count; i++) {
                    Console.WriteLine($"{i + 1}. {animalTypes[i].Name}");
                }
                Console.WriteLine("====================");
                Console.WriteLine("Please choose animal:");
                int index = int.Parse(Console.ReadLine());
                if (index > animalTypes.Count || index < 1) {
                    Console.WriteLine("No such an animal. Try again.");
                    continue;
                }

                Console.WriteLine("How many times?");
                int times = int.Parse(Console.ReadLine());
                Type type = animalTypes[index - 1];
                object obj = Activator.CreateInstance(type);
                MethodInfo mi = type.GetMethod("Voice");
                mi.Invoke(obj, new object[] { times });
            }
        }
    }
}
