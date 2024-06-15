using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int length=0;

            for (int U = 0; U == length; U++)
            {

                try
                {


                    Console.Clear();
                    int[] dz_ = new int[2];


                    Console.WriteLine("Выберете dz" +
                                   "\n1)dz_5_1" +
                                   "\n2)dz_5_2" +
                                   "\n3)Exit");
                    var a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1) { dz_[0]++; }
                    if (a == 2) { dz_[1]++; }
                    if (a == 3) { length++; }

                    for (int r = 0; r < dz_[0]; r++)

                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("1.Пользователь вводит с клавиатуры два числа\r\n (начало и конец диапазона).\r\n Нужно вывести на экран:\r\n Все числа диапазона;\r\n Все числа диапазона в нисходящем порядке;\r\n Все числа, кратные 7;\r\n Количество чисел, кратных 5.");




                            Console.Write("\n\nУкажите первое число диапазон от :  ");
                            var number1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Укажите второе число диапазон до :  ");
                            var number2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\n");
                            var number1_1 = number1;
                            int number2_2 = number2;
                            var five_counter = 0;
                            for (; number1_1 <= number2_2; number1_1++) Console.Write(number1_1 + " ");
                            Console.WriteLine();
                            number1_1 = number1;
                            number2_2 = number2;
                            for (; number1_1 <= number2_2; number2_2--) Console.Write(number2_2 + " ");
                            number2_2 = number2;
                            Console.Write("\n\n\nЧисла кратные семи             :");
                            for (int i = 7; i <= number2_2; i += 7)
                            {
                                Console.Write(i + " ");
                            }
                            for (int i = 5; i <= number2_2; i += 5)
                            {
                                ++five_counter;
                            }
                            Console.WriteLine($"\nКоличество чисел, кратных пяти :{five_counter}\n\n");
                            Console.WriteLine("Выйти нажмите      :1\n" +
                                              "Продолжить нажмите :2");
                            var p = Convert.ToInt32(Console.ReadLine());
                            if (p == 1) { dz_[0] = 0; r = 0; continue; }
                            dz_[0]++;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Ошибка!не известное дейстаие:\n" +
                                              $"Вийти нажмите               :Enter ");
                            Console.ReadLine();

                            dz_[0] = 0; r = 0; continue;

                            throw;
                        }
                    }
                    for (int d = 0; d < dz_[1]; d++)
                    {
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("2. \n" +
                                              "Пользователь вводит с клавиатуры два числа.\r\n" +
                                              "Нужно сосчитать отдельно сумму четных,нечетных и чисел,\r\n" +
                                              "кратных 9 в указанном диапазоне,\r\n" +
                                              "а также среднеарифметическое для каждой группы.\n\n");


                            Console.Write("Укажите первое число диапазон от :  ");
                            decimal number1 = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Укажите второе число диапазон до :  ");
                            decimal number2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n\n");
                            decimal number1_1 = number1;
                            decimal number2_2 = number2;

                            decimal Counter_with_no_remainder = 0;
                            decimal Counter_with_remainder = 0;
                            decimal Counter_of_numbers_multiples_of9 = 0;

                            decimal amount_without_balance = 0;
                            decimal amount_with_remaining_balance = 0;
                            decimal sum_of_multiples_of9 = 0;
                            //Средние арефметическое переменные 

                            decimal Arithmetic_averages_of_even_numbers = 0;
                            decimal Arithmetic_averages_of_non_even_numbers = 0;
                            decimal Average_arethmetic_multiples_of9 = 0;

                            for (; number1_1 <= number2_2; number1_1++)
                            {
                                var rezalt = number1_1 % 2;
                                if (rezalt == 0)
                                {
                                    amount_without_balance += number1_1;
                                    Counter_with_no_remainder++;

                                }
                                if (rezalt == 1)
                                {
                                    amount_with_remaining_balance += number1_1;
                                    Counter_with_remainder++;
                                }
                            }
                            Arithmetic_averages_of_even_numbers = amount_without_balance / Counter_with_no_remainder;
                            Arithmetic_averages_of_non_even_numbers = amount_with_remaining_balance / Counter_with_remainder;

                            Console.Write("\n\n\nЧисла кратные девяти             =");
                            for (int i = 9; i <= number2_2; i += 9)
                            {
                                ++Counter_of_numbers_multiples_of9;
                                sum_of_multiples_of9 += i;
                                Console.Write(i + " ");
                            }
                            Average_arethmetic_multiples_of9 = sum_of_multiples_of9 / Counter_of_numbers_multiples_of9;
                            Console.WriteLine($"\n" +
                                              $"Количество чисел кратное девяти  ={Counter_of_numbers_multiples_of9}\n" +
                                              $"Cумма чисел кратное девяти       ={sum_of_multiples_of9}\n" +
                                              $"Средние арефметическое кратное9  ={Average_arethmetic_multiples_of9}");


                            var сумма_парных = Counter_with_no_remainder * Counter_with_no_remainder;
                            var сумма_не_парных = Counter_with_remainder * Counter_with_remainder;


                            Console.WriteLine("\n\n" +
                                              $"Количество парных                ={Counter_with_no_remainder}\n" +
                                              $"Cумма парных                     ={amount_without_balance}\n" +
                                              $"Средние_арефметическое_четных    ={Arithmetic_averages_of_even_numbers}\n\n\n" +

                                              $"Количество не парных             ={Counter_with_remainder}\n" +
                                              $"Сумма не парных                  ={amount_with_remaining_balance}\n" +
                                              $"Средние арефметическое не четных ={Arithmetic_averages_of_non_even_numbers}\n\n");



                            Console.WriteLine("\n\n" +
                                              "Выйти нажмите      :1\n" +
                                              "Продолжить нажмите :2");
                            var p = Convert.ToInt32(Console.ReadLine());
                            if (p == 1) { dz_[1] = 0; d = 0; continue; }
                            dz_[1]++;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"Ошибка!не известное дейстаие:\n" +
                                              $"Вийти нажмите               :Enter ");
                            Console.ReadLine();
                            dz_[1]++; d = 0; continue;

                            throw;
                        }
                    }


                    length++;
                }
                catch (Exception)
                {
                   
                    length++;
                   
                }
            }                 

            
        }
    }
}
