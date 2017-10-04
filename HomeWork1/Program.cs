using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1.Samig
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа 1
            Console.WriteLine("Введите свое имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + name + " " + surname);

            //Программа 2
            // ----
            Console.WriteLine("Введите два числа");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Сумма двух чисел равна: " + c);
            Console.ReadKey();
        }
    }
}
