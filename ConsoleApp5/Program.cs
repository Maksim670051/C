using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class Point2D
    {
        private int _x { get; set; }
        private int _y { get; set; }

        public Point2D(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Print()
        {
            Console.WriteLine($"Координата x: {_x}\nКоордината y: {_y}");
        }
    }

    class Point3D : Point2D
    {
        private int _z { get; set; }

        public Point3D(int x, int y,int z):base(x, y)
        {
            _z = _z;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Коорлинана z: {_z}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dot1 = new Point2D(1, 1);
            dot1.Print();

            var dot2 = new Point3D(2, 2, 2);
            dot2.Print();

            object a = "ffffff";
            //Point3D dot3 = a as Point3D;
            if(a is Point3D dot3)
                dot3.Print();   
        }
    }
}
