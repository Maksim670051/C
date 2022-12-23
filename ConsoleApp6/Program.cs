using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    abstract class Gun
    {
        abstract public void Fire();
        abstract protected int Damage { get; }

        public void Info()
        {
            Console.WriteLine($"{GetType().Name} : {Damage}");
        }
    }

    class A: Gun
    {
        protected override int Damage { get { return 20; } }
        public override void Fire()
        {
            Console.WriteLine("Пиу пиу");
            Info();
        }
    }

    class B: Gun
    {
        protected override int Damage { get { return 5;} }
        public override void Fire()
        {
            Console.WriteLine("Бах бах");
            Info();
        }
    }

    class Player
    {
        public void Fire(Gun gun)
        {
            gun.Fire();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Fire(new A());
            player.Fire(new B());
        }
    }
}
