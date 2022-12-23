using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindItem
{
    internal class Program
    {
        static int FindItem(int[] array, int item)
        {
            int index = -1;

            for(int i = 0; i < array.Length; i++)
                if (array[i] == item)
                {
                    index = i;
                    break;
                };

            return index;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };

            Console.Write("Введите элемент: ");
            int item = int.Parse(Console.ReadLine());

            int index = FindItem(array, item);
            Console.WriteLine("Inedx: " + index);
        }
    }
}
