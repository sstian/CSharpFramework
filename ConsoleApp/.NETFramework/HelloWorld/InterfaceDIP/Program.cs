using System;

namespace InterfaceDIP {
    class Program {
        static void Main(string[] args) {
            var nokiaUser = new PhoneUser(new NokiaPhone());
            nokiaUser.UsePhone();
            var ericssonUser = new PhoneUser(new EricssonPhone());
            ericssonUser.UsePhone();
            //NokiaPhone.Dial(); Nokia is calling...
            //NokiaPhone.Pickup(); Hello. This is Nokia.
            //NokiaPhone.Send(); Nokia message ring...
            //NokiaPhone.Receive(); Hello. How are you?
            //EricssonPhone.Dial(); EricssonPhone is calling...
            //EricssonPhone.Pickup(); Hello. This is EricssonPhone.
            //EricssonPhone.Send(); EricssonPhone message ring...
            //EricssonPhone.Receive(); Hello. How do you do?
        }
    }

    class PhoneUser {
        private IPhone _phone;
        public PhoneUser(IPhone phone) {
            this._phone = phone;
        }

        public void UsePhone() {
            this._phone.Dial();
            this._phone.Pickup();
            this._phone.Send();
            this._phone.Receive();
        }
    }

    interface IPhone {
        // 打电话
        void Dial();
        // 接电话
        void Pickup();
        // 发消息
        void Send();
        // 收消息
        void Receive();
    }

    class NokiaPhone : IPhone {
        public void Dial() {
            Console.WriteLine("NokiaPhone.Dial(); Nokia is calling...");
        }

        public void Pickup() {
            Console.WriteLine("NokiaPhone.Pickup(); Hello. This is Nokia.");
        }

        public void Send() {
            Console.WriteLine("NokiaPhone.Send(); Nokia message ring...");
        }

        public void Receive() {
            Console.WriteLine("NokiaPhone.Receive(); Hello. How are you?");
        }
    }

    class EricssonPhone : IPhone {
        public void Dial() {
            Console.WriteLine("EricssonPhone.Dial(); EricssonPhone is calling...");
        }

        public void Pickup() {
            Console.WriteLine("EricssonPhone.Pickup(); Hello. This is EricssonPhone.");
        }

        public void Send() {
            Console.WriteLine("EricssonPhone.Send(); EricssonPhone message ring...");
        }

        public void Receive() {
            Console.WriteLine("EricssonPhone.Receive(); Hello. How do you do?");
        }
    }
}
