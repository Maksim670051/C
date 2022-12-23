using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();

                float a, b;

                try
                {
                    Console.WriteLine("Введите первое число:");
                    a = float.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    b = float.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Некорректное число!!!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите операцию : + - * /");
                string action = Console.ReadLine();

                float result;

                switch (action)
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine(result);
                        break;
                    case "*":
                        result = a * b;
                        Console.WriteLine(result);
                        break;
                    case "-":
                        result = a - b;
                        Console.WriteLine(result);
                        break;
                    case "/":
                        result = a / b;
                        Console.WriteLine(result);
                        break;
                    default:
                        Console.WriteLine("Ошибочная операция!!!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
