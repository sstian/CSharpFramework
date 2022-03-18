using System;

namespace InterfaceImplementExplicit {
    class Program {
        static void Main(string[] args) {
            IKiller killer = new WarmKiller();
            killer.Kill();

            //var wk = (WarmKiller)killer;
            //var wk = killer as WarmKiller;
            //var wk = (IGentleman)killer;
            var wk = killer as IGentleman;
            wk.Love();
            //I will kill that enemy.
            //I will you love you for ever...
        }
    }

    interface IGentleman {
        void Love();
    }

    interface IKiller {
        void Kill();
    }

    // 具体类实现多接口
    // 这个杀手不太冷
    class WarmKiller : IGentleman, IKiller {
        public void Love() {
            Console.WriteLine("I will you love you for ever...");
        }

        // 显式实现方法，被父类引用方可调之
        // Ikiller killer = new WarmKiller(); killer.kill();
        void IKiller.Kill() {
            Console.WriteLine("I will kill that enemy.");
        }
    }
}
