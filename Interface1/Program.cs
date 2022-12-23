using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{

    interface Game3d
    {
        void Open(Game3d Game3d);
    }

    interface Game2d
    {
        void Open(Game2d Game2d);
    }

    class TheWitcher: Game3d, Game2d
    {
        void Game2d.Open(Game2d Game2d)
        {
            Console.WriteLine("Them witcher");
        }

        void Game3d.Open(Game3d Game3d)
        {
            Console.WriteLine("The wotcher");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var one = new TheWitcher();
        }
    }
}
