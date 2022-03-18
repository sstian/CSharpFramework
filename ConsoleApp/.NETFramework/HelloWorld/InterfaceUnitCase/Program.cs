using System;

namespace InterfaceUnitCase {
    class Program {
        static void Main(string[] args) {
            var deskFan = new DeskFan(new PowerSupply());
            Console.WriteLine(deskFan.Work());
            //Warning!
        }
    }

    public interface IPowerSupply {
        int GetPower();
    }

    public class PowerSupply : IPowerSupply {
        public int GetPower() {
            return 210;
        }
    }

    public class DeskFan {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply) {
            this._powerSupply = powerSupply;
        }

        public string Work() {
            int power = this._powerSupply.GetPower();
            if (power <= 0) {
                return "Won't work.";
            } else if (power < 100) {
                return "Slow.";
            } else if (power < 200) {
                return "Work fine.";
            } else {
                return "Warning!";
            }
        }
    }
}
