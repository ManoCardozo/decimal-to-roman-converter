using System;
using Microsoft.Extensions.DependencyInjection;
using DecimalToRomanConverter.Application.Services;
using DecimalToRomanConverter.Application.Exceptions;

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
                try
                {
                    var input = ReadUserInput();
                    var output = converter.ConvertToRoman(input);
                    Console.WriteLine($"Result: {output}");
                    PauseScreen();
                }
                catch(OutOfRomanNumeralBoundsException)
                {
                    Console.WriteLine("Please enter a number between 1 and 3999");
                    PauseScreen();
                }
            }
        }

        static int ReadUserInput()
        {
            Console.Clear();
            Console.WriteLine("Decimal to Roman Numeral Converter");
            Console.WriteLine("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int input))
            {
                Console.WriteLine("Invalid number");
                PauseScreen();
                ReadUserInput();
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
