using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolOutput
{
    internal class Program
    {

        static void SymbolOutput(int count, char symbol)
        {
            for(int i = 0; i < count; i++)
                Console.Write(symbol + " ");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество символов: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());

            SymbolOutput(count, symbol);
        }
    }
}
