using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    //class Dot
    //{
    //    private int _x;
    //    public int _y { get; set; }
    //    public static string description;

    //    public int X 
    //    {
    //        get { return _x; }
    //        set { _x = value; }
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"X: {_x}\nY: {_y}");
    //    }
    //}

    class MyClass
    {
        private static int Counter { get; set; }

        public MyClass() 
        {
            Counter++;
        }

        public void Print()
        {
            Console.WriteLine(Counter);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var dot1 = new Dot();
            //dot1.X = 1;
            //dot1._y = 2;
            //dot1.Print();

            var myClass1 = new MyClass();
            myClass1.Print();
            new MyClass();
            new MyClass();
            new MyClass();
            var myClass2 = new MyClass();
            myClass2.Print();
        }
    }
}
