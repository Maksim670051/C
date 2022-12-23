using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsMethods
{
    static class MyClass
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }
    }
}
