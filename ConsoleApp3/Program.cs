using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Student
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _date;

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public Student(string firstName, string lastName, string email, DateTime date) : this(firstName, lastName)
        {
            _date = date;
            _email = email;
        }

        public void Print()
        {
            Console.Write($"Имя: {_firstName}\nФамилия: {_lastName}\nEmail: {_email}\nДата регистрации: {_date}\n\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student Ivan = new Student("Иван", "Первов");
            Ivan.Print();

            var Maksim = new Student("Максим","Шмыголь","shcool.227@gmail.com",new DateTime(2022,12,5));
            Maksim.Print();
        }
    }
}
