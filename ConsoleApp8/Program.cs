using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    interface Point
    {
        void Print() { };
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
        }
    }
}
