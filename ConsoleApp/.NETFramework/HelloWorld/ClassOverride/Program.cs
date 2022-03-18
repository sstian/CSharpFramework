using System;

namespace ClassOverride {
    class Program {
        static void Main(string[] args) {
            Vehicle v = new RaseCar();
            v.Run();
            Console.WriteLine($"Speed = {v.Speed}");
            //Car is running.
            //Speed = 200
        }
    }

    class Vehicle {
        private int _speed;
        // 属性也可被重写
        public virtual int Speed {
            get { return _speed; }
            set { _speed = value; }
        }

        public virtual void Run() {
            Console.WriteLine("Vehicle is running.");
            this._speed = 100;
        }
    }

    class Car : Vehicle {
        private int _rpm;
        // 属性也可被重写
        public override int Speed {
            get { return _rpm / 100; }
            set { _rpm = value * 100; }
        }

        public override void Run() {
            Console.WriteLine("Car is running.");
            this._rpm = 20000;
        }
    }

    class RaseCar : Car {
        // public void Run()
        public new void Run() {
            Console.WriteLine("RaseCar is running.");
        }
    }
}
