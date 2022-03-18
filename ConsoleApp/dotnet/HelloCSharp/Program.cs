using System;
using System.IO;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = File.Create(@".\Hello.txt");
            var streamWriter = new StreamWriter(fileStream);
            streamWriter.Write("Hello World! - C#");
            streamWriter.Flush();
            streamWriter.Close();
            Console.WriteLine("Done");
        }
    }
}
