using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_9_11
{
    internal class Program
    {
        
        
            static List<string> tasks = new List<string>();
            static void AddTask()
            {
                Console.Clear();
                Console.Write("Введите задачу: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("Задача добавлена.");
                Console.ReadLine();
            }   // добавления задачи в список   
            static void EditTask()
            {
                if (tasks.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Количество задач               :{tasks.Count}");
                    Console.WriteLine($"Первый индекс  начинается с    :0");
                    Console.WriteLine($"Последние индекс  оканчивается :{tasks.Count - 1}");
                    Console.Write     ("Укажите индекс для изменения   :");
                    var index = Convert.ToInt16(Console.ReadLine());
                    if (index >= 0 && index < tasks.Count)
                    {
                        Console.Write("Введите новый текст          :");
                        string newTask = Console.ReadLine();
                        tasks[index] = newTask;
                        Console.WriteLine("Текст изменен                :");
                    }
                    else
                    {
                        Console.WriteLine("Неверный индекс.");
                    }
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Задач нет : ");
                }
                Console.ReadLine();
            }  // изменить индекс  
            static void DeleteTask()
            {
                if (tasks.Count > 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Количество задач               :{tasks.Count}");
                    Console.WriteLine($"Первый индекс  начинается с    :0");
                    Console.WriteLine($"Последние индекс  оканчивается :{tasks.Count-1}");
                    Console.Write     ("Укажите индекс для удаления    :");

                    var index = Convert.ToInt16(Console.ReadLine());

                    if (index >= 0 && index < tasks.Count)
                    {

                        tasks.RemoveAt(index);
                        Console.WriteLine("Текст удален:");
                    }
                    else
                    {
                        Console.WriteLine("Неверный индекс:");
                        Console.ReadLine();
                    }
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Задач нет : ");
                }
                Console.ReadLine();
            }// удалить из списка 
            static void ShowTasks()
            {
                Console.Clear();
                if (tasks.Count == 0)
                {
                    Console.WriteLine("Список задач пуст.");
                }
                else
                {
                    Console.WriteLine("Список задач:");
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine(i + ") " + tasks[i]);
                    }
                }
                Console.ReadLine();
            } // паказывает все задачи  
            static void Сhoose_A_Topic()
            {
                Console.Clear();
                Console.WriteLine("Выберете тему\n" +
                                  "1) Светлая:\n" +
                                  "2) Тёмная :\n" +
                                  "3) Выйти  :");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        Console.ReadLine();
                        break;
                }
            }// :) выбрать тему  :) 



            static void Main()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Создать программу Список дел.(List)\n" +
                                      "Реализовать(отдельными функциями):\n" +
                                      "добавление задания в список задач\n" +
                                      "изменение задачи(найти по индексу)\n" +
                                      "удаление задачи(найти по индексу)\n" +
                                      "Задача представляет собой строчку(string).\n\n");

                    Console.WriteLine("1. Добавить задания");
                    Console.WriteLine("2. Изменить задания");
                    Console.WriteLine("3. Удалить  задания");
                    Console.WriteLine("4. Показать все задачи");
                    Console.WriteLine("5. Выбрать  тему ");
                    Console.WriteLine("6. Выйти");
                    Console.Write("\n\nВыберите действие указав индекс 1,2,3,4,5,6: ");

                    try
                    {
                        string choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                AddTask();
                                break;
                            case "2":
                                EditTask();
                                break;
                            case "3":
                                DeleteTask();
                                break;
                            case "4":
                                ShowTasks();
                                break;
                            case "5":
                                Сhoose_A_Topic();
                                break;
                            case "6":
                                return;
                            default:
                                Console.WriteLine("Неверный выбор, попробуйте снова.");
                                Console.ReadLine();
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка:");
                        Console.ReadLine();

                    }

                }
            }


     }

}

