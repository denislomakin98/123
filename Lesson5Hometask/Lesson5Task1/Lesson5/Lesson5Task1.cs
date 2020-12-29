using System;
using System.Collections.Generic;
using System.IO; 
using System.Text;

namespace Lesson5Task1
{
    class Program
    {
        // вопрос на случай, если файл уже существует
        private static readonly string[] FileQuestion = new string[4]
        {
            "Файл уже существует:",
            "перезаписать",
            "добавить информацию в конец файла",
            "ничего не делать"
        };

        const string filename = "text.txt";


        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите любой набор символов:");
            string text = Console.ReadLine();

            //если файл уже существует, то дается выбор "перезаписать/добавить/ничего не делать"
            if (File.Exists(filename))
                switch (AskMenuQuestion(FileQuestion))
                {
                    case 1:
                        File.WriteAllText(filename, text);
                        break;
                    case 2:
                        File.AppendAllText(filename, text);
                        break;
                }
            else File.WriteAllText(filename, text);

            Console.WriteLine("\n Нажмите любую кнопку\n");
            Console.ReadKey();

        }
        /* задает вопрос пользователю с вариантами выбора
         <param name="menu">массив содержащий вопрос в 0-м элементе и варианты ответов в остальных</param>
         <returns>номер выбранного варианта</returns> */
        private static int AskMenuQuestion(string[] menu)
        {
            //задаем сообщение для главного меню справочника
            string question = menu[0] + "\n";
            for (int i = 1; i < menu.Length; i++)
                question += $"{i} - {menu[i]}\n";

            bool isInputCorrect = false; //флаг правильности ввода
            int answer = 0; //вывод ответа

            //основной рабочий цикл
            while (!isInputCorrect)
            {
                Console.WriteLine(question);
                isInputCorrect = int.TryParse(Console.ReadLine(), out answer);
                if (isInputCorrect && (answer < 0 || answer >= menu.Length))
                    isInputCorrect = false;
                if (!isInputCorrect)
                    Console.WriteLine("Неправльный выбор. Повторите ввод.\n");

            }

            return answer;
        }
    }
}