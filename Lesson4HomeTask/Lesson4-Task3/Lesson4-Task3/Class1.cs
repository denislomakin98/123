﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04_03
{
    class Program
    {
        //общее количество месяцев в году 
        const int MONTHS_AMOUNT = 12;
        // количество месяцев в одном сезоне
        const int MONTHS_IN_SEASON = 3;
        // названия времен года 
        private static readonly string[] SeasonNames = new string[4] { "зима", "весна", "лето", "осень" };

        //времена года 
        private enum Season
        {
            Winter = 0,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            int monthNumber = NumberInput("Введите номер месяца: ", 1, MONTHS_AMOUNT);
            Season season = GetSeason(monthNumber);
            Console.WriteLine($"Месяцу №{monthNumber} соответствует время года - {GetSeasonName(season)}");

            Console.WriteLine("\n--------\npress any key\n");
            Console.ReadKey();

        }

        // преобразует Season в текстовое представление
        private static string GetSeasonName(Season season)
        {
            return SeasonNames[(int)season];
        }

        // возвращает значение времени года по номеру месяца

        private static Season GetSeason(int monthNumber)
        {
            return (Season)((monthNumber < MONTHS_AMOUNT ? monthNumber : 0) / MONTHS_IN_SEASON);
        }

        // запрашивает у пользовател число с проверкой ввода на правильность и вхождение в заданный интервал

        private static int NumberInput(string message, int min, int max)
        {
            bool isInputCorrect = false; //флаг проверки
            int number = 0;
            while (!isInputCorrect) //цикл будет повторятся, пока вводимое число не пройдет все проверки
            {
                Console.WriteLine($"{message} (от {min} до {max})");
                //ввод и проверка на то, что это целове число
                isInputCorrect = int.TryParse(Console.ReadLine(), out number);
                //проверка на вхождение в заданный интервал
                if (isInputCorrect && (number < min || number > max))
                    isInputCorrect = false;

                if (!isInputCorrect) Console.Write("Ошибка. ");
            }
            return number;
        }


    }
}