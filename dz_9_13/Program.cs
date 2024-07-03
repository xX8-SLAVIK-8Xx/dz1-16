using System;
using System.Collections.Generic;

namespace CityApp
{
    class City
    {
        // Поля класса
        public string Name;
        public string Region;
        public string Country;
        public int Population;
        public string PostalCode;
        public string PhoneCode;

        // Конструктор
        public City(string name, string region, string country, int population, string postalCode, string phoneCode)
        {
            Name = name;
            Region = region;
            Country = country;
            Population = population;
            PostalCode = postalCode;
            PhoneCode = phoneCode;
        }

        // Метод для получения информации о городе
        public string GetCityInformation()
        {
            return $"Название города    : {Name}\n" +
                   $"Регион             : {Region}\n" +
                   $"Страна             : {Country}\n" +
                   $"Количество жителей : {Population}\n" +
                   $"Почтовый индекс    : {PostalCode}\n" +
                   $"Телефонный код     : {PhoneCode}\n";
        }
    }

    class Country
    {
        // Поля класса
        public string Name;
        public string Continent;
        public int Population;
        public string PhoneCode;
        public string Capital;
        public List<string> Cities;

        // Конструктор
        public Country(string name, string continent, int population, string phoneCode, string capital, List<string> cities)
        {
            Name = name;
            Continent = continent;
            Population = population;
            PhoneCode = phoneCode;
            Capital = capital;
            Cities = cities;
        }

        // Метод для получения информации о стране
        public string GetCountryInformation()
        {
            string cityInformation = string.Join(", ", Cities);
            return $"Название страны   : {Name}\n" +
                   $"Континент         : {Continent}\n" +
                   $"Количество жителей: {Population}\n" +
                   $"Телефонный код    : {PhoneCode}\n" +
                   $"Столица           : {Capital}\n" +
                   $"Города            : {cityInformation}...\n";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Задание 1:\n" +
                                    "Создайте класс \"Город\".\n" +
                                    "Необходимо хранить в полях класса:\n" +
                                    "-название   города\n" +
                                    "-название   региона,\n" +
                                    "-название   страны\n" +
                                    "-количество жителей города\n" +
                                    "-почтовый индекс города\n" +
                                    "-телефонный код города\n\n" +

                                    "Реализуйте методы для получения информации\n" +
                                    "о городе и протестируйте на разных экземплярах.\n\n\n" +


                                    "Задание 2:\n" +
                                    "Создайте класс \"Страна\".\n" +
                                    "Необходимо хранить в полях класса:\n" +
                                    "-название страны\n" +
                                    "-название континента\n" +
                                    "-количество жителей страны\n" +
                                    "-телефонный код страны\n" +
                                    "-название столицы\n" +
                                    "-названия городов страны\n\n" +

                                    "Реализуйте методы получения информации\n" +
                                    "о стране и протестируйте на разных экземплярах.\n\n\n");

                Console.WriteLine("Выберете задание  ");
                Console.WriteLine("Задание 1 :нажмите 1");
                Console.WriteLine("Задание 2 :нажмите 2");
                Console.WriteLine("Выйти     :нажмите 3");
                try
                {
                    var rezalt = Convert.ToInt32(Console.ReadLine());
                    if (rezalt == 1)
                    {
                        Console.Clear();
                        // Создание экземпляров класса Город
                        City Kyiv = new City("Киев", "Киевская  ", "Украина", 2963000, "01001", "044");
                        City Lviv = new City("Львов", "Львовская ", "Украина", 721301, "79000", "032");
                        City Odessa = new City("Одесса", "Одесская  ", "Украина", 1015000, "65000", "048");

                        // Вывод информации о городах
                        Console.WriteLine(Kyiv.GetCityInformation());
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine(Lviv.GetCityInformation());
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine(Odessa.GetCityInformation());
                        Console.WriteLine("Продолжить нажмите Entet");
                        Console.ReadLine();


                    }
                    if (rezalt == 2)
                    {
                        Console.Clear();
                        // Создание экземпляров класса Страна 
                        Country Ukraine = new Country("Украина", "Европа", 41000000, "380", "Киев", new List<string> { "Киев", "Львов", "Одесса" });
                        Country Poland = new Country("Польша", "Европа", 38386000, "48", "Варшава", new List<string> { "Варшава", "Краков", "Лодзь" });
                        Country Germany = new Country("Германия", "Европа", 83100000, "49", "Берлин", new List<string> { "Берлин ", "Гамбург", "Мюнхен" });

                        // Вывод информации о странах
                        Console.WriteLine(Ukraine.GetCountryInformation());
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine(Poland.GetCountryInformation());
                        Console.WriteLine(); Console.WriteLine();
                        Console.WriteLine(Germany.GetCountryInformation());
                        Console.WriteLine("Продолжить нажмите Entet");
                        Console.ReadLine();
                    }
                    if (rezalt == 3) break;
                }
                catch (Exception)
                {
                }
            }
        }
    }
}


