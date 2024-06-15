using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7_1_
{
    internal class Program
    {
        //Функцыя dz1
        public static int ConversionToDegree(int number, int degree)
        {
            if (degree == 0) return 1;
            //Интуитивное объяснение
            //Возведение в степень 0 можно представить как отсутствие множителей.
            //Когда мы умножаем число на себя 0 раз, это означает, что у нас нет 
            //множителей, и результат по определению должен быть 1.
            //Это также делает математические операции более удобными и последовательными.
            //Эти объяснения показывают, почему любое ненулевое число в степени 0 равно 1.
            //https://www.youtube.com/watch?v=J-gBUAUdouI&ab_channel=AlbertLavrov

            int[] numm = new int[2];

            numm[0] = number;
            numm[1] = degree;
            int[] numm1 = new int[2];
            numm1[0] = numm[0];

            for (int i = 1; i < numm[1]; i++)
            {
                numm1[0] = numm[0] * numm1[0];
            }
            return numm1[0];
        }
        static void Main(string[] args)
        {
            //Применения функции dz1
            while (true)//dz1
            {

                Console.Clear();
                try
                {
                    Console.WriteLine("Задание 1.\n" +
                                      "Написать функцию,которая принимает два параметра:\n" +
                                      "основу степени и показатель степени и вычисляет \n" +
                                      "степень числа на основе полученных данных.\n\n");
                    Console.Write("Введите число    :");
                    var num = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ввдите степеь    :");
                    var deg = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Число в степени  :" + ConversionToDegree(num, deg));
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка : Укажите число");
                    Console.ReadKey();

                }
            }      //dz1


        }
    }
}
