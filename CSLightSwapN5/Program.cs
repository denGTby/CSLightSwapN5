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
            string bufferName;

            Console.WriteLine($"Имя: {firstName}\n" +
                              $"Фамилия: {lastName}");

            bufferName = firstName;
            firstName = lastName;
            lastName = bufferName;

            Console.WriteLine("\nИсправление ошибки...");
            Console.WriteLine($"Имя: {firstName}\n" +
                              $"Фамилия: {lastName}");

            Console.ReadLine();
        }
    }
}
