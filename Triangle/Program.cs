using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j <= i; j++)
                    Console.Write("#");                        
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 0; i < height; i++)
            {
                for(int j = height; j != i; j--)
                    Console.Write("#");
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 1; i <= height; i++)
            {
                for(int j = height; j != 0; j--)
                {
                    if (i - j >= 0)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i = 1; i <= height; i++)
            {
                for(int j = 1; j <= height; j++)
                {
                    if (i - j <= 0)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
