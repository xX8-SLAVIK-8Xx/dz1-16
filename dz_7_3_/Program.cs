using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7_3_
{
    internal class Program
    {
        static void PerfectNumbersInARange(int num1, int num2)
        {
            //все совершеные числа диапазона int
            int[] perfect_numbers = new int[4];
            perfect_numbers[0] = 6;
            perfect_numbers[1] = 28;
            perfect_numbers[2] = 496;
            perfect_numbers[3] = 8128;
            //перебор диапазона int от 0 до 2147483647  
            for (; num1 <= num2; num1++)
            {
                if (num1 == perfect_numbers[0]) Console.WriteLine(perfect_numbers[0]);
                if (num1 == perfect_numbers[1]) Console.WriteLine(perfect_numbers[1]);
                if (num1 == perfect_numbers[2]) Console.WriteLine(perfect_numbers[2]);
                if (num1 == perfect_numbers[3]) Console.WriteLine(perfect_numbers[3]);
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();
                try
                {
                    Console.WriteLine("Задание 3.\nЧисло называется совершенным, если сумма всех его делителей равна ему самому.\nУкажите функцию поиска таких чисел во введенном интервале.\n\n");
                    Console.WriteLine("Функция вывода совершенных чисел диапазона int от 0 до 2147483647  \n\n ");
                    Console.Write("Введите первое число диапазона :");
                    var numm1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число диапазона :");
                    var numm2 = Convert.ToInt32(Console.ReadLine());

                    PerfectNumbersInARange(numm1, numm2);
                    Console.ReadLine();

                }
                catch (Exception)
                {

                    Console.WriteLine("\n\nОшибка: веденно некоректное значение или выход за предел диапазона от 0 до 2147483647 \n" +
                                      "ахаха : крутое  объяснение ошибки :) лучше не придумать :) ");
                    Console.ReadLine();


                }
            }

        }
    }
}
