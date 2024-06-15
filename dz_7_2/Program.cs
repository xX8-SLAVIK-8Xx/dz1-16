using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7_2
{
    internal class Program
    {       
        
        static int SumOfNumbersInRange(int num1,int num2) 
        {
            if (num1 > num2)
            {
                int[] number = new int[2];
                number[0] = num2;
                number[1] = num1;

                int[] rezalt = new int[number[1]];
                var p = 1;
                for (int i = 0; rezalt[i] < number[1];)
                {
                    rezalt[i] += p;
                    p++;
                    i++;
                    if (i == number[1]) break;

                }
                var o = 0;
                for (int i = 0; i < number[1]; i++)
                {
                    o = rezalt[i] + o;
                }
                return o;
            }
            else
            {
                int[] number = new int[2];
                number[0] = num1;
                number[1] = num2;

                int[] rezalt = new int[number[1]];
                var p = 1;
                for (int i = 0; rezalt[i] < number[1];)
                {
                    rezalt[i] += p;
                    p++;
                    i++;
                    if (i == number[1]) break;

                }
                var o = 0;
                for (int i = 0; i < number[1]; i++)
                {
                    o = rezalt[i] + o;
                }
                return o;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {Console.Clear();
                try
                {
                    Console.WriteLine("Задание 2.\n" +
                    "Написать функцию, которая получает в качестве параметров 2 целых числа\n" +
                    "и возвращает сумму чисел из диапазона между ними.\n\n");

                    Console.Write("Введите первое число диапазона :");
                    var numm = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число диапазона :");
                    var num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Сумма чисел ="+SumOfNumbersInRange(numm, num1));

                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                    Console.ReadLine();
                   
                }        


            }
             
        }
    }
}
