using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    class Print
    {
        public void Pr<T>(T obj)
        {
            Console.WriteLine(obj);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Print();
            int b = 55;
            string s = "Hello world";
            a.Pr(b);
            a.Pr(s);
        }
    }
}
