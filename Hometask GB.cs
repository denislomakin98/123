using System;

namespace HelloDateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine ($"Привет,{name}, сегодня { DateTime.Now}");
        }
    }
}
