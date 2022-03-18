using BabyStroller.SDK;
using System;

namespace Animals.Lib {
    public class Cat : IAnimal {
        public void Voice(int times) {
            for (int i = 0; i < times; i++) {
                Console.WriteLine("Cat.Voice(): Meow");
            }
        }
    }
}
