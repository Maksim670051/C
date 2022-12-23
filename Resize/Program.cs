using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resize
{
    internal class Program
    {

        static void Resize <T>(ref T[]array, ref int length)
        {
            T[] newArray = new T[length];

            for(int i = 0; i < array.Length && i != length; i++)
                newArray[i] = array[i];

            array = newArray;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите длинну массива: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = { 1, 2, 3, 4 };

            Resize(ref array, ref length);

        }
    }
}
