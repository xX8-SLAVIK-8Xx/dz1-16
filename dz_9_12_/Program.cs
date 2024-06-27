using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace dz_9_12_
{
    internal class Program
    {

        static public (bool, string) HomeТumber(string namber, ref int t1, ref int t2)
        {
            while (true)
            {
                Console.Clear();
                string verification = @"^\d{7}$";
                bool rezalt = Regex.IsMatch(namber, verification);
                if (rezalt == true)
                {

                    Console.Write($"Номер сохранен :" + rezalt + " " + namber);
                    t1++; t2++;
                    return (rezalt, namber);
                }
                else //if(результат == false)
                {

                    Console.Write($"Не верно указан номер :");
                    Console.ReadLine();
                    return (rezalt, namber);
                }

            }

        }                //1++
        static public (bool, string) MobileNumber(string mobile_number, ref int t2, ref int t3)
        {
            while (true)
            {
                Console.Clear();
                string verification = @"^\+?\d{10,12}$";
                bool rezalt = Regex.IsMatch(mobile_number, verification);
                if (rezalt)
                {
                    Console.WriteLine($"Номер сохранен :{rezalt}");
                    t2++; t3++;
                    return (rezalt, mobile_number);
                }
                else
                {
                    Console.WriteLine($"Не верно указан номер ");
                    Console.ReadLine();
                    return (false, " ");
                }
            }
        }       //2++
        static public (bool, string) Email(string email, ref int t3, ref int t4)
        {
            while (true)
            {
                Console.Clear();

                string verification = @"^[\w-\.]+@gmail\.com$";
                if (email.Length >= 5 && email.Length <= 50)
                {
                    bool rezalt = Regex.IsMatch(email, verification);
                    Console.WriteLine($"Email сохранен      : {rezalt} {email}");
                    t3++; t4++;
                    return (rezalt, email);
                }
                else
                {
                    Console.WriteLine($"Не верно указан email ");
                    Console.ReadLine();


                    return (false, " ");
                }

            }



        }                      //3++        
        static public (bool, string) FullName(string Full_name, ref int t4)
        {
            while (true)
            {
                Console.Clear();

                string verification = @"^([A-Za-zА-Яа-яЁё]{2,20})(\s{1,2}[A-Za-zА-Яа-яЁё]{2,20}){0,2}$";
                bool rezalt1 = Regex.IsMatch(Full_name, verification);
                if (rezalt1 == true)
                {
                    bool rezalt = Regex.IsMatch(Full_name, verification);
                    Console.WriteLine($"ФИО   сохранено      : {rezalt} {Full_name}");
                    t4++;
                    return (rezalt, Full_name);
                }
                else
                {
                    Console.WriteLine($"Не верно указан ФИО   ");
                    Console.ReadLine();
                    return (false, " ");
                }

            }
        }                           //4++


        static void Main(string[] args)
        {
            Console.WriteLine();
            int namber1 = 0;
            int namber2 = 1;
            int namber3 = 2;
            int namber4 = 3;

            (bool, string) true_and_namber1 = (false, " ");
            (bool, string) true_and_namber2 = (false, " ");
            (bool, string) true_and_namber3 = (false, " ");
            (bool, string) true_and_namber4 = (false, " ");




            while (true)
            {
                Console.Clear();

                Console.WriteLine("Написать валидации с помощью регулярных выражений:\n" +
                                  "-домашний номер телефона(только цифры и длина номера)\n" +
                                  "-мобильный номер телефона(только цифры, возможно наличие плюса, длина номера)\n" +
                                  "-email(наличие @, домена: gmail.com например, минимальная длина и максимальная по вашему выбору)\n" +
                                  "-ФИО клиента(3 слова, минимальная длина 2 символа, максимальная длина 20)\n\n");
                Console.WriteLine("Реквезиты             :Ctrl+C");
                Console.WriteLine("1234567               :");
                Console.WriteLine("0956282657            :");
                Console.WriteLine("example@gmail.com     :");
                Console.WriteLine("Ивин Иванович Иванов  :\n" +
                                  "Ивин Иванович         :\n" +
                                  "Ивин                  :\n\n");

                Console.WriteLine("Регестрация                      : ");

                try
                {
                    if (namber1 == 1)//2
                    {
                        Console.WriteLine("Укажите домашний  номер телефона : " + true_and_namber2);

                        if (namber2 == 3)//2
                        {
                            Console.WriteLine("Укажите мобильный номер телефона : " + true_and_namber1);
                            if (namber3 == 4)//2
                            {
                                Console.WriteLine("Укажите email                    : " + true_and_namber3);

                                if (namber4 == 5)//2
                                {
                                    Console.WriteLine("Укажите ФИО                      : " + true_and_namber4);

                                    Console.WriteLine("\n\nРегестрацыя прошла успешно       :  :)");
                                    Console.WriteLine("Эх это было сложно               :  ;)");

                                    break;

                                }
                                if (namber4 == 4)//1
                                {
                                    Console.Write("Укажите ФИО                      : ");
                                    true_and_namber4 = FullName(Console.ReadLine(), ref namber4);
                                }
                            }
                            if (namber3 == 3)//1
                            {
                                Console.Write("Укажите email                    : ");
                                true_and_namber3 = Email(Console.ReadLine(), ref namber3, ref namber4);
                            }
                        }
                        if (namber2 == 2)//1
                        {
                            Console.Write("Укажите мобильный номер телефона : ");
                            true_and_namber1 = MobileNumber(Console.ReadLine(), ref namber2, ref namber3);
                        }
                    }
                    if (namber1 == 0)//1
                    {
                        Console.Write("Укажите домашний  номер телефона : ");
                        true_and_namber2 = HomeТumber(Console.ReadLine(), ref namber1, ref namber2);
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ??? я не знаю как её решить  :)  тут не должно быть ошибок ");
                }



            }





        }
    }
}

