using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElementToArray
{
    internal class Program
    {

        static void DeleteElement(ref int[]array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for(int i = 0, j = 0; i < array.Length; i++)
            {
                if (i == index)
                    continue;
                newArray[j] = array[i];
                j++;
            }

            array = newArray;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите индекс: ");
            int index = int.Parse(Console.ReadLine());

            int[] array = { 1, 2, 3, 4, 5 };

            DeleteElement(ref array, index);

            foreach (var item in array)
                Console.Write(item + " ");
        }
    }
}
