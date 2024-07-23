using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace my_game_normal
{
    internal class Program
    {
        static void ОтрисовкаКарты(in int ширена, in int высота)
        {
            //ширена = 70; //ширена 
            //высота = 35; //высота 
            try
            {
                // Устанавливаем кодировку UTF-8 для вывода
                // Console.OutputEncoding = Encoding.UTF8;

                char полый_квадрат = '\u25A0'; // Черный квадрат U+25A0
                char полный_блок = '\u2588';// Полный блок U+2588

                const string whitespaces = " ";


                if (ширена <= 0 || высота <= 0)
                {
                    throw new Exception("Incorrect width or height");
                }

                for (int x = 1; x <= высота; x++)
                {
                    if (x == 1 || x == высота)
                    {
                        for (int i = 0; i < ширена; i++)
                        {
                            Console.Write(полый_квадрат);
                        }
                    }
                    else
                    {
                        Console.Write(полный_блок);

                        for (int p = 0; p < ширена - 2; p++)
                        {
                            Console.Write(whitespaces);
                        }

                        Console.Write(полный_блок);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ПередвижениеИгрока(in int ширена, in int высота)
        {
            //int ширена = 100; //ширена 
            //int высота = 50;//высота 
            // Начальные координаты игрока
            int playerX = 1;
            int playerY = 1;

            // Основной игровой цикл
            while (true)
            {
                //Console.Clear(); // Очищаем консоль для обновления экрана

                // Рисуем игрока на текущих координатах
                Console.SetCursorPosition(playerX, playerY);
                Console.Write('\u25A0');

                // Выводим инструкции для пользователя
                Console.SetCursorPosition(0, высота + 1);
                Console.WriteLine("Используйте стрелки для перемещения (для выхода нажмите Esc)\n" +
                                  "Cтрельба Enter");

                // Ожидаем ввода от пользователя
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // Обработка ввода пользователя
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar://стрельба 
                        {
                            Console.Beep(50, 40);
                            Console.SetCursorPosition(playerX, playerY);
                            for (int i = 0; i < 10; i++)
                            {


                                // Выводим символ в новых координатах
                                Console.SetCursorPosition(playerX + i, playerY);
                                Console.WriteLine("0"); // символ выстрела 

                                // Задержка для создания анимации
                                Thread.Sleep(10); // Можете изменить продолжительность задержки по вашему желанию
                            }
                            Console.SetCursorPosition(playerX, playerY);
                            for (int i = 0; i < 10; i++)
                            {


                                // Выводим символ в новых координатах
                                Console.SetCursorPosition(playerX + i, playerY);
                                Console.Write(" "); // символ выстрела 

                                // Задержка для создания анимации
                                Thread.Sleep(10); // Можете изменить продолжительность задержки по вашему желанию
                            }

                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (playerX > 1)                                //проверка чтоб не выходил за пределы карты 
                        {
                            Console.SetCursorPosition(playerX, playerY);//Стераем прошлую позицыю игрока 
                            Console.Write(" ");
                            playerX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (playerX < ширена - 2)                       //проверка чтоб не выходил за пределы карты 
                        {
                            Console.SetCursorPosition(playerX, playerY);//Стераем прошлую позицыю игрока 
                            Console.Write(" ");
                            playerX++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (playerY > 1)                                //проверка чтоб не выходил за пределы карты 
                        {
                            Console.SetCursorPosition(playerX, playerY);//Стераем прошлую позицыю игрока 
                            Console.Write(" ");
                            playerY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (playerY < высота - 2)                       //проверка чтоб не выходил за пределы карты 
                        {
                            Console.SetCursorPosition(playerX, playerY);//Стераем прошлую позицыю игрока 
                            Console.Write(" ");
                            playerY++;
                        }

                        break;
                    case ConsoleKey.Escape:
                        return; // Выход из программы при нажатии Esc
                }
            }

        }
        static void Main(string[] args)
        {
            int width = 50; //ширена 
            int height = 25; //высота 
            ОтрисовкаКарты(width, height);
            ПередвижениеИгрока(width, height);



        }



    }

}
