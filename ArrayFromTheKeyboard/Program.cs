using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFromTheKeyboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            //Entering an array
            for (int i = 0; i < array.Length; i++)
                array[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
            Console.WriteLine("===================================================================");

            //Array output
            for (int i = array.Length - 1; i >= 0; i--)
                Console.WriteLine(array[i]);
            Console.WriteLine("===================================================================");

            //Even numbers
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    count++;
            }
            Console.WriteLine("Even numbers: " + count);

            //Min numbers
            int min = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                    min = array[i];
            }
            Console.WriteLine("Min numbers: " + min);
        }
    }
}
