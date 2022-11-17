using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab1_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            int n1 = 0;
            int n2 = 0;
            int inermedian_n = 0;

            // Ввод чисел
            Console.WriteLine("Введите первое число: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Выбор операции
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("\t+: сложение");
            Console.WriteLine("\t-: вычитание");
            Console.WriteLine("\t*: умножение");
            Console.WriteLine("\t/: деление");
            Console.WriteLine("\t^: степень");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"Результат: {n1} + {n2} = " + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine($"Результат: {n1} - {n2} = " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine($"Результат: {n1} * {n2} = " + (n1 * n2));
                    break;
                case "/":
                    Console.WriteLine($"Результат: {n1} / {n2} = " + (n1 / n2));
                    break;
                case "^":
                    Console.WriteLine($"Результат: {n1} ^ {n2} = " + (n1 ^ n2));
                    break;
            }
            Console.Write("Для закрытия нажмите любую кнопку.");
            Console.ReadKey();
        }
    }
}
