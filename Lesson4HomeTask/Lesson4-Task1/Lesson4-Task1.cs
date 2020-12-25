using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theLesson4Task1
{ 

    class Program
    {
        // количество запросов ФИО 
        const int n = 4;

        static void Main(string[] args)
        {
            string lastName;
            string firstName;
            string patronimic;
            string fullName;

            for (int i = 0; i < n; i++)
            {
                lastName = StringInput("Введите фамилию: ");
                firstName = StringInput("Введите имя: ");
                patronimic = StringInput("Введите отчество: ");
                fullName = GetFullName(lastName, firstName, patronimic);
                Console.WriteLine($"ФИО: {fullName}");
            }

            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadKey();

        }

      
        // Запрашивает у пользователя ввод строки с заданным сообщением
     
        private static string StringInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        
        private static string GetFullName(string lastName, string firstName, string patronymic)
        {
            string fullName = lastName + " " + firstName + " " + patronymic; ;
            return fullName;
        }


    }
}