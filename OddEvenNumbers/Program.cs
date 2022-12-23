using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начало:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец:");
            int end = int.Parse(Console.ReadLine());

            int countEven = 0, 
                countOdd = 0, 
                sumEven = 0, 
                sumOdd = 0;

            if (start >= end)
                Console.WriteLine("Начало не может быть меньше конца!!!");
            else
                while (start < end)
                {
                    if (start % 2 == 0)
                    {
                        countEven++;
                        sumEven += start;
                    }
                    else
                    {
                        countOdd++;
                        sumOdd += start;
                    }
                    start++;
                }
            Console.WriteLine("Сумма чётных чисел: " + sumEven);
            Console.WriteLine("Сумма нечётных чисел: " + sumOdd);
            Console.WriteLine("Количество чётных чисел: " + countEven);
            Console.WriteLine("Количество нечётных чисел: " + countOdd);
        }
    }
}
