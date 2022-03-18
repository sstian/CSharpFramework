using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ReflexionDemo {
    class Program {
        static void Main(string[] args) {
            ITank tank = new HeavyTank();
            // ---------- Reflexion ----------
            Type type = tank.GetType();
            object obj = Activator.CreateInstance(type);
            MethodInfo runMi = type.GetMethod("Run");
            MethodInfo fireMi = type.GetMethod("Fire");
            runMi.Invoke(obj, null);
            fireMi.Invoke(obj, null);
            //HeavyTank.Run(): ka!!! ka!!! ka!!!...
            //HeavyTank.Fire(): Boom!!!

            // ---------- Dependency Inject
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(IVehicle), typeof(Truck));
            sc.AddScoped<Driver>();
            ServiceProvider sp = sc.BuildServiceProvider();

            ITank tank2 = sp.GetService<ITank>();
            tank2.Run();
            tank2.Fire();
            Driver driver = sp.GetService<Driver>();
            driver.Drive();
            //HeavyTank.Run(): ka!!! ka!!! ka!!! ...
            //HeavyTank.Fire(): Boom!!!
            //Truck.Run(): Truck is running...
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
