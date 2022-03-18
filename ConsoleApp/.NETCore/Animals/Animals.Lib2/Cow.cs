using BabyStroller.SDK;
using System;

namespace Animals.Lib {
    public class Cow : IAnimal {
        public void Voice(int times) {
            for (int i = 0; i < times; i++) {
                Console.WriteLine("Cow.Voice(): Moo");
            }
        }
    }
}
