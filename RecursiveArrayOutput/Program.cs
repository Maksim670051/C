using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveArrayOutput
{
    internal class Program
    {

        static void ArrayOutput(in int[]array, int i = 0)
        {
            if (i >= array.Length)
                return;
            Console.WriteLine(array[i]);
            i++;

            ArrayOutput(in array, i);
        }

        static int SumArrayElement(in int[]array, int sum = 0, int i = 0)
        {
            if(i >= array.Length)
                return sum;

            sum += array[i];
            i++;
            return SumArrayElement(in array, sum, i);
        }

        static int SumNumbers(int number, int sum = 0, int i = 0)
        {
            if(number < 10)
            {
                sum += number;
                return sum;
            }
            sum += number % 10;
            number /= 10;
            return SumNumbers(number, sum, i);
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ArrayOutput(in array);

            Console.WriteLine("===================================================================================");

            int sum = SumArrayElement(in array);
            Console.WriteLine(sum);

            Console.WriteLine("===================================================================================");

            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int sum2 = SumNumbers(number);
            Console.WriteLine(sum2);
        }
    }
}
