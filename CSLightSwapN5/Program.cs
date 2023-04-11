using System;
using System.Text;

namespace CSLightSwapN5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Петров";
            string lastName = "Егор";
            string bufferString;

            Console.WriteLine($"Имя: {firstName}\n" +
                              $"Фамилия: {lastName}");

            bufferString = firstName;
            firstName = lastName;
            lastName = bufferString;

            Console.WriteLine("\nИсправление ошибки...");
            Console.WriteLine($"Имя: {firstName}\n" +
                              $"Фамилия: {lastName}");

            Console.ReadLine();
        }
    }
}
