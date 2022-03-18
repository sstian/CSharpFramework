using System;

// ISP 接口隔离：Interface Segregation Principle
namespace InterfaceISP {
    class Program {
        static void Main(string[] args) {
            var driver = new Driver(new Truck());
            driver.Drive();
            driver = new Driver(new HeavyTank());
            driver.Drive();
            //Truck.Run(): Truck is running...
            //HeavyTank.Run(): ka!!! ka!!! ka!!!...
        }
    }

    class Driver {
        private readonly IVehicle _vehicle;
        public Driver(IVehicle vehicle) {
            _vehicle = vehicle;
        }

        public void Drive() {
            _vehicle.Run();
        }
    }

    interface IVehicle {
        void Run();
    }

    class Car : IVehicle {
        public void Run() {
            Console.WriteLine("Car.Run(): Car is running...");
        }
    }

    class Truck : IVehicle {
        public void Run() {
            Console.WriteLine("Truck.Run(): Truck is running...");
        }
    }

    interface IWeapon {
        void Fire();
    }

    // 接口 ITank 继承接口 IVehicle & IWeapon
    interface ITank : IVehicle, IWeapon { 
        }

    class LightTank : ITank {
        public void Fire() {
            Console.WriteLine("LightTank.Fire(): Boom!");
        }

        public void Run() {
            Console.WriteLine("LightTank.Run(): ka! ka! ka! ...");
        }
    }

    class MediumTank : ITank {
        public void Fire() {
            Console.WriteLine("MediumTank.Fire(): Boom!!");
        }

        public void Run() {
            Console.WriteLine("MediumTank.Run(): ka!! ka!! ka!! ...");
        }
    }

    class HeavyTank : ITank {
        public void Fire() {
            Console.WriteLine("HeavyTank.Fire(): Boom!!!");
        }

        public void Run() {
            Console.WriteLine("HeavyTank.Run(): ka!!! ka!!! ka!!! ...");
        }
    }
}
