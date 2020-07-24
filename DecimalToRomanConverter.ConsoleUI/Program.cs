using System;
using Microsoft.Extensions.DependencyInjection;
using DecimalToRomanConverter.Application.Services;

namespace DecimalToRomanConverter.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = DependencyInjection.Setup();
            var converter = serviceProvider.GetService<IDecimalConverterService>();

            while (true)
            {
                var input = MainScreen();
                var output = converter.ConvertToRoman(input);
                Console.WriteLine(output.ToString());
                PauseScreen();
            }
        }

        static int MainScreen()
        {
            Console.Clear();
            Console.WriteLine("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Invalid number");
                PauseScreen();
                MainScreen();
            }

            return input;
        }

        static void PauseScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
