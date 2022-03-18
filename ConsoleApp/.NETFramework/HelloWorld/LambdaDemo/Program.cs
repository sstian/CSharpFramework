using System;

namespace LambdaDemo {
    class Program {
        static void Main(string[] args) {
            //DoSomeFunc<int>((a, b) => { return a * b; }, 100, 200);
            // 泛型委托参数类型推导 + Lambda表达式
            DoSomeFunc((a, b) => a * b, 100, 200.3);
            // 20030
        }

        // 泛型方法 + 泛型委托参数 + 泛型参数
        static void DoSomeFunc<T>(Func<T, T, T> func, T x, T y) {
            T res = func(x, y);
            Console.WriteLine(res);
        }
    }
}
