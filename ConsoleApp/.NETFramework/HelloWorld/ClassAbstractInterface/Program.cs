using System;

namespace ClassAbstractInterface {
    class Program {
        static void Main(string[] args) {
            IVehicle iv = new Car();
            iv.Run();
            iv.Fill();
            iv.Stop();
            //Car is Running
            //Pay and fill...
            //Stopped.
        }
    }

    // 接口
    // 方法为public abstract, 但需要去掉
    interface IVehicle {
        void Fill();
        void Stop();
        void Run();
    }

    // 抽象类
    // 实现 接口
    abstract class Vehicle : IVehicle {
        // 实现接口中的方法
        public void Fill() {
            Console.WriteLine("Pay and fill...");
        }

        // 实现接口中的方法
        public void Stop() {
            Console.WriteLine("Stopped.");
        }

        // 声明接口中的抽象方法，延迟到子类实现
        public abstract void Run();
    }

    // 具体类
    class Car : Vehicle {
        public override void Run() {
            Console.WriteLine("Car is Running");
        }
    }
}
