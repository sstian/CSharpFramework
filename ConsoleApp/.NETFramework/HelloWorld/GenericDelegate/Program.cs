using System;

namespace GenericDelegate {
    class Program {
        static void Main(string[] args) {
            // 泛型委托 + 函数
            //Func<double, double, double> func11 = new Func<double, double, double>(Add);
            //var func12 = new Func<double, double, double>(Add);
            //Func<double, double, double> func13 = Add;

            // 泛型委托 + Lambda表达式
            //var func21 = new Func<double, double, double>((a, b) => { return a + b; });
            //Func<double, double, double> func22 = (a, b) => { return a + b; };
            Func<double, double, double> func = (a, b) => a + b;

            var result = func(10.1, 20.2);
            Console.WriteLine(result);
            //30.3
        }

        static double Add(double a, double b) {
            return a + b;
        }
    }
}

