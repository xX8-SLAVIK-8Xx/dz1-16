using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7_5
{
    internal class Program
    {
        static void LuckySixDigitNumber(int number)
        {
            var num1 = number / 1000;
            int[] variable = new int[3];
            variable[0] =  num1 / 100;
            variable[1] = (num1 / 10) % 10;
            variable[2] =  num1 % 10;
            var summ = variable[0] + variable[1] + variable[2];

            var num2 = number - (num1 * 1000);
            int[] variable2 = new int[3];
            variable2[0] =  num2 / 100;
            variable2[1] = (num2 / 10) % 10;
            variable2[2] =  num2 % 10;
            var summ1 = variable2[0] + variable2[1] + variable2[2];

                 if (summ == summ1) Console.WriteLine($"Число :" + num1 + num2 + " счастливое   ");
            else if (summ != summ1) Console.WriteLine($"Число :" + num1 + num2 + " не счастливое");

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 5. Написать функцию, определяющую, является ли «счастливым» шестизначное число.\n");
                try
                {
                    var rezalt = Convert.ToInt32(Console.ReadLine());

                    if (100000 <= rezalt && rezalt <= 999999)
                    {
                        LuckySixDigitNumber(rezalt);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"\nОшибка !                                   \n" +
                                          $"Число \"{rezalt}\" не является шести значным \n" +
                                          $"Укажите шести значное число                  \n" +
                                          $"Нажмите Enter чтоб продолжить                  ");
                        Console.ReadLine();

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ! укажите шести значное число ");
                    Console.ReadLine();

                }
            }


        }
    }
}
