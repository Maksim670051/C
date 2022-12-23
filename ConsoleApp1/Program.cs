using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //================================================================================================================================================
            //Console.WriteLine("Введите что-нибудь:");
            //string a = Console.ReadLine();
            //Console.WriteLine(a);
            //================================================================================================================================================
            //Console.WriteLine("Введите первое число:");
            //string a = Console.ReadLine();
            //Console.WriteLine("Введите второе число:");
            //String b = Console.ReadLine();

            //int a1 = Convert.ToInt32(a);
            //int b1 = Convert.ToInt32(b);
            //int result1 = a1 + b1;

            //int a1 = int.Parse(a);
            //int b1 = int.Parse(b);
            //int result1 = a1 + b1;

            //int a1, b1;
            //bool a2 = int.TryParse(a, out a1);
            //bool b2 = int.TryParse(b, out b1);
            //int result1 = a1 + b1;
            //Console.WriteLine(a2 + " " + b2);

            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = "."
            //};
            //float a1 = float.Parse(a, numberFormatInfo);
            //float b1 = float.Parse(b, numberFormatInfo);
            //float result1 = a1 + b1;

            //Console.WriteLine("Результат 1:" + result1);
            //================================================================================================================================================
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //float result = (float)a / b;
            //Console.WriteLine(result);
            //================================================================================================================================================
            //for(int i = 0, j = 2;i < 100; i++, j *= 2)
            //{
            //    if (i == 10)
            //        continue;
            //    else if (i == 20)
            //        break;
            //    Console.WriteLine("J: " + j);
            //    Console.WriteLine("I: " + i);
            //}
            //================================================================================================================================================
            //int[] array = new int[5];
            //int[] newArray = new int[] { 1, 2, 3, 4, 5 };
            //int[] array2 = { 1, 2, 3, 4, 5 };
            //int[] newArray2 = Enumerable.Repeat(1, 5).ToArray();
            //int[] array3 = Enumerable.Range(1, 5).ToArray();
            //Console.WriteLine(array3[0]);
            //================================================================================================================================================
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //Console.WriteLine(array.Min()); //минимальное
            //Console.WriteLine(array.Max()); //максимальное
            //Console.WriteLine(array.Sum()); //сумма
            //Console.WriteLine(array.Where(i => i % 2 == 0).Sum()); // Условие
            //Console.WriteLine(array.Distinct().ToArray()); //убрать повторяющиеся и преобразовать в массив
            //Console.WriteLine(array.OrderBy(i=>i).ToArray()); //сортировка в порядке возрастания
            //Console.WriteLine(array.OrderByDescending(i => i).ToArray()); //сортировка в порядке убывания
            //Console.WriteLine(array.Where(i => i == 0).First()); //первый элемент равный 0 (FirstOrDefault() - не выдаёт исключение)
            //================================================================================================================================================
            //int[] array = {1,2,3,4,5};
            //Console.WriteLine(array[1]);
            //int[] array2 = array[1..4]; // диапазоны
            //string str = "hello world!!!";
            //Console.WriteLine(str[4]);
            //================================================================================================================================================
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, };
            //foreach(var item in array)
            //    Console.WriteLine(item);
            //================================================================================================================================================
            //int[,] array =
            //{
            //    {1,2,3,4,5 },
            //    {1,2,3,4,5 },
            //    {1,2,3,4,5 },
            //    {1,2,3,4,5 },
            //    {1,2,3,4,5 }
            //};
            //Console.WriteLine(array.GetLength(0));
            //Console.WriteLine(array.GetLength(1));
            //Console.WriteLine(array.Rank);
            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] array = new int[2, 3];

            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //        array[i, j] = int.Parse(Console.ReadLine());
            //}
            //foreach(var item in array)
            //    Console.WriteLine(item);
            //================================================================================================================================================
            //int[,,] array =
            //{
            //    {
            //        {1,2,3},
            //        {1,2,3}
            //    },
            //    {
            //        {1,2,3},
            //        {1,2,3}
            //    },
            //    {
            //        {1,2,3},
            //        {1,2,3}
            //    },
            //};
            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        for(int k = 0; k < array.GetLength(2); k++)
            //            Console.Write(array[i, j, k] + "\t");
            //        Console.WriteLine();
            //    }
            //}
            //================================================================================================================================================
            //string array = null;
            //string result = array ?? "gg";
            //Console.WriteLine(result + " " + array);
            //================================================================================================================================================
            //Colors color = Colors.White;
            //string a = "Red";
            //Console.WriteLine(Enum.Parse(typeof(Colors), a).GetHashCode());
            //Console.WriteLine(color.GetHashCode());

            //var values = Enum.GetValues(typeof(Colors));
            //foreach (var item in values)
            //    Console.WriteLine(item);
            //================================================================================================================================================

        }

        enum Colors: byte
        {
            Red,
            Green,
            Blue,
            Yellow,
            Black,
            White
        }
    }
}
