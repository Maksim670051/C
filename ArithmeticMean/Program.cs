using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            float b = float.Parse(Console.ReadLine());

            float result = (a + b) / 2;
            Console.WriteLine("Среднее арфметическое: " + result);
        }
    }
}
