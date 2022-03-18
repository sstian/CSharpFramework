using System;

namespace EnumDemo {
    class Program {
        static void Main(string[] args) {
            Person person = new Person() {
                Name = "Jack",
                Level = Level.Boss,  
                // Level = (Level)200,              // int -> enum
                Skill = Skill.Drive | Skill.Cook | Skill.Program
            };
            Console.WriteLine(person.Level);
            Console.WriteLine((int)person.Level);   // enum -> int
            Console.WriteLine(person.Skill);
            // 比特位的判断
            Console.WriteLine((person.Skill & Skill.Cook) == Skill.Cook);
            Console.WriteLine((person.Skill & Skill.Cook) > 0);
            //Boss
            //200
            //7
            //True
            //True
        }
    }

    enum Level {
        Employee = 100,
        Manager,
        Boss = 200,
        BigBoss,
    }

    // 枚举 比特位用法
    enum Skill {
        Drive = 1,
        Cook = 2,
        Program = 4,
        Teach = 8,
    }

    class Person {
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }
}
