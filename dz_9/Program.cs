using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_9
{
    internal class Program
    {
        public static int[] RandomArrayNumbers(int array_size)         //  действие: 1 Генерируем рандомные числа 
        {
            const int from = 0, up_to = 100;
            var massif = new int[array_size];
            var random = new Random();

            for (int i = 0; i < array_size; i++)
            {
                massif[i] = random.Next(from, up_to);
            }

            return massif;
        }
        public static void OutputtingAnArrayToTheScreen(int[] massif)  //  действие: 2 Выводим масив на экран

        {
            foreach (var item in massif)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

        }
                                                                       //  действие: 4 Выводим перебранный масив на экран

        public static void BubbleSort(int[] massif)                    //  действие: 3 Сортеруем масив 
        {

            for (int i = 0; i < massif.Length; i++)//проходимся по длине масива 
            {
                for (int j = 0; j < massif.Length - i - 1; j++)
                {
                    if (massif[j] > massif[j + 1])
                    {
                        //swap (меняем значение без потери)
                        var temporary_storage = massif[j];
                        massif[j] = massif[j + 1];
                        massif[j + 1] = temporary_storage;
                    }
                }

            }
        }
        public static void Main()                                      //  точка входа в программу
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();

                try
                {
                    Console.WriteLine("Создать массив на 30 чисел и заполнить случайными числами от 1 до 100.\n" +
                                    "Отсортировать алгоритм пузырчатой ​​сортировки.\n" +
                                    "Разобраться как работает, пробеспокоить и написать самостоятельно, не списывая.\n" +
                                    "Прогробить и разобраться с другими алгоритмами, рассмотренными на уроке.\n" +
                                    "FYI: обязательно написать сортировку пузырьком, добавить комментарии с пояснениями на каждой строке.\n" +
                                    "Дополнительно – добавить комментарии с пояснениями другой сортировкой, рассмотренной на уроке.\n\n");
                    Console.Write("Укажите количество элементов в масиве в диапазоне int :");
                    var massif = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n\n");
                    var my_massif = RandomArrayNumbers(massif);
                    OutputtingAnArrayToTheScreen(my_massif);
                    BubbleSort(my_massif);
                    OutputtingAnArrayToTheScreen(my_massif);

                    Console.WriteLine($"\n" +
                                     $"\nЗаново нажмите:1 " +
                                     $"\nВыйти  нажмите:2 ");
                    var p = Convert.ToInt32(Console.ReadLine());
                    if (p == 2) break;
                    Console.ReadLine();

                }
                catch
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
