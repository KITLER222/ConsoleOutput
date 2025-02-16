using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("введите первое число"); 
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите третье число");
            int number3 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2 + number3;

            Console.WriteLine($"сумма трех чисел равна {sum}");
            Console.ReadKey();
        }
    }
}
