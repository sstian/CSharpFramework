using System;

namespace ClassInherit {
    class Program {
        static void Main(string[] args) {
            Car car = new Car("Tim");
            Console.WriteLine(car.Owner);
            // Tim
        }
    }

    class Vehicle {
        public string Owner { get; set; }

        public Vehicle(string owner) {
            this.Owner = owner;
        }
    }

    class Car : Vehicle {
        public Car() : base("N/A") {
        }

        public Car(string owner) : base(owner) {
        }
    }
}
