using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GBtask
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //матрица с диагональю из 1

            int[,] matrix = new int[5, 5];


            for (int i = 0; i < matrix.GetLength(1); i++)
            {

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, i] = 1;
                    System.Console.Write($"{matrix[i, j]} ");


                }
                System.Console.WriteLine();

            }

            //массив 5х2 "имя, контакт"

            string[,] contacts = new string[5, 2]{
                             { "Альберт Эйнштейн", "+79118791955"},
                             { "Галилео Галилей", "+79115641642"},
                             { "Микеланджело", "+79114751564"},
                             { "Макс Планк", "+79118581947"},
                             { "Вильгельм №1", "+79110271087"}
                                                    };
            for (int i = 0; i <= contacts.GetUpperBound(0); i++)
            {
                string s1 = contacts[i, 0];
                string s2 = contacts[i, 1];
                Console.WriteLine("{0}, {1}", s1, s2);
            }


            //программа реверсии слов
            {
                reverseSt(Console.ReadLine());
            }

            static void reverseSt(string stringInput)
            {
                char[] charArray = stringInput.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }
        }
    }
}

