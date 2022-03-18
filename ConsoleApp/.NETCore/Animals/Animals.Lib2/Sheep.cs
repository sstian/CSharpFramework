using BabyStroller.SDK;
using System;

namespace Animals.Lib {

    [Unfinished]
    public class Sheep : IAnimal {
        public void Voice(int times) {
            for (int i = 0; i < times; i++) {
                Console.WriteLine("Sheep.Voice(): Baa");
            }
        }
    }
}
