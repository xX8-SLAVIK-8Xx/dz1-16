


Console.WriteLine("Выберете домашнию работу \n" +
                  "1)dz_#1\n" +
                  "2)dz_#2\n" +
                  "3)dz_#3\n" +
                  "nИспльзуем \"1\"\"2\"\"3\"");
var p = Convert.ToByte(Console.ReadLine());
if (1 == p)
{
    Console.WriteLine("dz_3 #1  Условие" +
        "\r\n                 Пользователь с клавиатуры вводит 5 оценок студента. " +
        "\r\n                 Определить, допущен ли студент к экзамену." +
        "\r\n                 Студент получает допуск, если его средний балл 4 балла и выше.");


    var ученик_1 = "Василий Донов";
    var ученик_2 = "Оля Полякова";
    var ученик_3 = "Влад Кличко";

    var предмет1 = "Математика";
    var предмет2 = "Физика";
    var предмет3 = "История";

    byte[] оценка = new byte[5];

    Console.WriteLine("Журнал учёта:\n" +
                 "Выберете предмет:" +
                 $"\n1){предмет1}" +
                 $"\n2){предмет2}" +
                 $"\n3){предмет3}" +
                 $"\nИспльзуем \"1\"\"2\"\"3\"");
    var выбран_предмет = Convert.ToByte(Console.ReadLine());
    if (1 == выбран_предмет)
    {
        if (true)
        {
            Console.WriteLine("\n\nВыберете ученика:" +
                             $"\n1){ученик_1}" +
                             $"\n2){ученик_2}" +
                             $"\n3){ученик_3}" +
                              "\nИспльзуем \"1\"\"2\"\"3\"");

            var выбран_ученик = Convert.ToByte(Console.ReadLine());
            if (1 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет1}\n" +
                                      $"Учащийся        :{ученик_1}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет1}\n" +
                                       $"Учащийся         :{ученик_1}\n" +
                                       $"Допущен   ");
            }
            if (2 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет1}\n" +
                                      $"Учащийся        :{ученик_2}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет1}\n" +
                                       $"Учащийся         :{ученик_2}\n" +
                                       $"Допущен   ");
            }
            if (3 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет1}\n" +
                                      $"Учащийся        :{ученик_3}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет1}\n" +
                                       $"Учащийся         :{ученик_3}\n" +
                                       $"Допущен   ");
            }

        }
    };
    if (2 == выбран_предмет)
    {
        if (true)
        {
            Console.WriteLine("\n\nВыберете ученика:" +
                             $"\n1){ученик_1}" +
                             $"\n2){ученик_2}" +
                             $"\n3){ученик_3}" +
                              "\nИспльзуем \"1\"\"2\"\"3\"");

            var выбран_ученик = Convert.ToByte(Console.ReadLine());
            if (1 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет2}\n" +
                                      $"Учащийся        :{ученик_1}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет2}\n" +
                                       $"Учащийся         :{ученик_1}\n" +
                                       $"Допущен   ");
            }
            if (2 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет2}\n" +
                                      $"Учащийся        :{ученик_2}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет2}\n" +
                                       $"Учащийся         :{ученик_2}\n" +
                                       $"Допущен   ");
            }
            if (3 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет2}\n" +
                                      $"Учащийся        :{ученик_3}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет2}\n" +
                                       $"Учащийся         :{ученик_3}\n" +
                                       $"Допущен   ");
            }
        }
    };
    if (3 == выбран_предмет)
    {
        if (true)
        {
            Console.WriteLine("\n\nВыберете ученика:" +
                             $"\n1){ученик_1}" +
                             $"\n2){ученик_2}" +
                             $"\n3){ученик_3}" +
                              "\nИспльзуем \"1\"\"2\"\"3\"");

            var выбран_ученик = Convert.ToByte(Console.ReadLine());
            if (1 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет3}\n" +
                                      $"Учащийся        :{ученик_1}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет3}\n" +
                                       $"Учащийся         :{ученик_1}\n" +
                                       $"Допущен   ");
            }
            if (2 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет3}\n" +
                                      $"Учащийся        :{ученик_2}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет3}\n" +
                                       $"Учащийся         :{ученик_2}\n" +
                                       $"Допущен   ");
            }
            if (3 == выбран_ученик)
            {
                Console.WriteLine("Сентябрь ");
                Console.WriteLine("Укажите оценки от 1 до 12:");
                Console.Write("Оценка за 09.01.2024     :");
                оценка[0] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.02.2024     :");
                оценка[1] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.03.2024     :");
                оценка[2] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.04.2024     :");
                оценка[3] = Convert.ToByte(Console.ReadLine());
                Console.Write("Оценка за 09.05.2024     :");

                оценка[4] = Convert.ToByte(Console.ReadLine());
                decimal средние_оценок = (оценка[0] + оценка[1] + оценка[2] + оценка[3] + оценка[4]) / 5;

                if (средние_оценок <= 4)
                    Console.WriteLine($"До экзаменов по :{предмет3}\n" +
                                      $"Учащийся        :{ученик_3}\n" +
                                      $"Не допущен  ");
                else Console.WriteLine($"До экзаменов по  :{предмет3}\n" +
                                       $"Учащийся         :{ученик_3}\n" +
                                       $"Допущен   ");
            }
        }
    }

}
if (2 == p)
{
    Console.WriteLine("условие " +
        "\nПользователь вводит число с клавиатуры." +
        "\n    Если оно парное, умножить его на три, иначе разделить на два." +
        "\n    Результат выводится на экран.");

    Console.WriteLine("Введите число");
    var число = Convert.ToInt32(Console.ReadLine());
    int результат = число % 2;
    if (результат == 0) Console.WriteLine($"Число: {число} парное\nВыражение:{число}*3={(float)число * 3}");
    if (результат == 1) Console.WriteLine($"Число: {число} не парное\nВыражение:{число}/2={(float)число / 2}");


}
if (3 == p) 
{   //Простой калькулятор 
    Console.WriteLine("dz_3 #3\n" +
                      "        Условие\n" +
                      "        Написать программу-калькулятор.\r\n" +
                      "        Пользователь вводит два числа и\r\n" +
                      "        выбирает арифметическое действие.\r\n" +
                      "        Вывести на экран результат.");
    
    Console.Write("Укажете первое число:");
    float число1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Укажете второе число:");
    float число2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Выберете действие :+ - * /");
    var действие = Convert.ToChar(Console.ReadLine());
    if (действие == '+') Console.WriteLine($"{число1}+{число2}={число1 + число2}");
    if (действие == '-') Console.WriteLine($"{число1}-{число2}={число1 - число2}");
    if (действие == '*') Console.WriteLine($"{число1}*{число2}={число1 * число2}");
    if (действие == '/' && число2 == 0) Console.WriteLine("На ноль не делится");
    else if (действие == '/') Console.WriteLine($"{число1}/{число2}={число1 / число2}");
    //пхх получилось обработать исключение  ( / на 0 ) при помощью дебагера 
    //так-как он проверяет всё строчку за строчкой ставим сначала проверку на ноль 
    // а потом просто деление :)  так и работает  
    // Если сделать так , то работать не будет.
    // if (действие == '/') Console.WriteLine($"{число1}/{число2}={число1 / число2}");
    // if (действие == '/' && число2 == 0) Console.WriteLine("На ноль не делится");
    // это просто гениально!!! :) 
    

}
//доп дз сделаю позже :) 






