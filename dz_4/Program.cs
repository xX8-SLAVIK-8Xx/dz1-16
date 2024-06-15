using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_4
{
    enum Operator
    {
        Plus = '+',
        Мinus = '-',
        Multiply = '*',
        Divide = '/'
    }
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Условие dz №4  #1\r\n" +
                           "                1.Написать программу - калькулятор.\r\n" +
                           "                Пользователь вводит два числа и\r\n" +
                           "                выбирает арифметическое действие.\r\n" +
                           "                Вывести на экран результат.\n\n" +
                           "                Для проверки ошибок              :\r\n" +
                           "                Пишем такие значения             :\r\n" +
                           "                1)ошибка:делить на ноль нельзя   :2,0,/,\r\n" +
                           "                2)ошибка:не известный символ     :1,1,любой символ(№)(@)(#)\r\n" +
                           "                3)не корректное значения         :1,(любой текст )\r\n" +
                           "                4)не корректное значения         :(любой текст )\r\n" +
                           "                5)не корректное значения         :1,1, (любой текст )\n\n");

                double action1, action;
               
                Operator Аction;

                try
                {
                    Console.Write("Калькулятор\n" +
                                  "Укажете первое число:");
                    action1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Укажете второе число:");
                    action = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка !: Укажите число");
                    Console.ReadKey();
                    continue;
                    throw;
                }
                try
                {
                    Console.WriteLine("Выберете действие :+ - * /");
                   
                    Аction = (Operator)Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка !: Укажите:+ - * / ");
                    Console.ReadKey();
                    continue;
                    throw;
                }

                switch (Аction)
                {
                    case Operator.Plus:
                        Console.WriteLine($"{action1}+{action}={action1 + action}");
                        break;
                    case Operator.Мinus:
                        Console.WriteLine($"{action1}-{action}={action1 - action}");
                        break;
                    case Operator.Multiply:
                        Console.WriteLine($"{action1}*{action}={action1 * action}");
                        break;
                    case Operator.Divide:
                        if
                            (action == 0) Console.WriteLine("На ноль не делится ");
                        else
                            Console.WriteLine($"{action1}/{action}={action1 / action}");
                        break;
                    default:
                        Console.WriteLine($"Ошибка ! Не известный оперант :'{(char)Аction}'");
                        break;
                }
                Console.ReadKey();


            }

            

            ;
        }

    }
}





////НЕ ПРАВИЛЬНЫЙ КОД 
//
//
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace dz_4
//{
//    internal class Program
//    {
//        enum Оператор
//        {
//            Плюс = '+',
//            Минус = '-',
//            Умнжить = '*',
//            Делить = '/'
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Условие dz #1\r\n" +
//                           "                1.Написать программу - калькулятор.\r\n" +
//                           "                Пользователь вводит два числа и\r\n" +
//                           "                выбирает арифметическое действие.\r\n" +
//                           "                Вывести на экран результат.\n");
//            double число1, число2;
//            char действие;
//            char в;
//            while (true)
//            {
//                try
//                {
//                    Console.Write("Укажете первое число:");
//                    число1 = Convert.ToInt32(Console.ReadLine());
//                    Console.Write("Укажете второе число:");
//                    число2 = Convert.ToInt32(Console.ReadLine());
//                    Console.WriteLine("Выберете действие :+ - * /");
//                    действие = (Оператор)char.Parse(Console.ReadLine());
//                }
//                catch (Exception)
//                {

//                    throw;
//                }

//                switch (действие)
//                {
//                    case Оператор.Плюс:
//                        Console.WriteLine($"{число1}+{число2}={число1 + число2}");
//                        break;
//                    case Оператор.Минус:
//                        Console.WriteLine($"{число1}-{число2}={число1 - число2}");
//                        break;
//                    case Оператор.Умнжить:
//                        Console.WriteLine($"{число1}*{число2}={число1 * число2}");
//                        break;
//                    case Оператор.Делить:
//                        if
//                            (число2 == 0) Console.WriteLine("На ноль не делится ");
//                        else
//                            Console.WriteLine($"{число1}/{число2}={число1 / число2}");
//                        break;
//                    default:
//                        Console.WriteLine("Ошибка ! Не известное действие:");
//                        break;
//                }
//                Console.ReadKey();
//            }

//            //использую для проверки кода :)
//            //(https://www.youtube.com/watch?v=4aL0YVKt880&list=PLQOaTSbfxUtD6kMmAYc8Fooqya3pjLs1N&index=20&ab_channel=%23SimpleCode)


//            //while (true)//начало цыкла 
//            //{
//            //    Console.Clear();//очищает всё прошлое  что был в консоли перед начало цыкла 
//            //    continue; 
//            //}//конец цыкла 
//            // var действие = (Оператор)Convert.ToChar(Console.ReadLine());  


//        }

//    }
//}