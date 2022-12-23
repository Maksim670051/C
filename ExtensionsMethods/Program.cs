using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime time = DateTime.Now;
            time.Print();
            Console.WriteLine("\n\n\n");

            var S1 = new Student("Shmygollllll");
            S1.Print();
        }
    }

    class Student
    {
        public const string NAME = "Shmygol";
        public readonly string _fname;

        public Student(string fname)
        {
            _fname = fname;
        }

        public void Print()
        {
            Console.WriteLine($"{NAME} {_fname}");
        }
    }
}
