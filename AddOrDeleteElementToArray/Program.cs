using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrDeleteElementToArray
{
    internal class Program
    {
        static void EditArray(ref int[] array, int index, int element)
        {
            if(index != -1 && index != -2)
            {
                if (index > array.Length - 1)
                {
                    int[] newArray = new int[index + 1];

                    for(int i = 0; i < array.Length; i++)
                        newArray[i] = array[i];

                    newArray[index] = element;

                    array = newArray;
                }
                else
                    array[index] = element;
            }
            else
            {
                int[] newArray = new int[array.Length + 1];

                if (index == -1)
                {
                    newArray[0] = element;
                    for(int i = 0; i < array.Length; i++)
                        newArray[i + 1] = array[i];
                }
                else
                {
                    newArray[array.Length] = element;
                    for (int i = 0; i < array.Length; i++)
                        newArray[i] = array[i];
                }

                array = newArray;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите элемент для добавления: ");
            int element = int.Parse(Console.ReadLine());

            Console.Write("Куда добавить элемент (начало -1; конец -2; или индекс)");
            int index = int.Parse(Console.ReadLine());

            int[] array = {1,2,3,4,5};

            EditArray(ref array, index, element);

            foreach(var item in array)
                Console.WriteLine(item + " ");
        }
    }
}
