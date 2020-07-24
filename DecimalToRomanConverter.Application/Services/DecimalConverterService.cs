using System;
using System.Linq;
using DecimalToRomanConverter.Domain.Enums;
using DecimalToRomanConverter.Domain.Entities;
using DecimalToRomanConverter.Application.Exceptions;
using DecimalToRomanConverter.Application.Extensions;

namespace DecimalToRomanConverter.Application.Services
{
    public class DecimalConverterService : IDecimalConverterService
    {
        public RomanNumeral ConvertToRoman(int number)
        {
            if (!number.InRange(1, 3999))
            {
                throw new OutOfRomanNumeralBoundsException(number.ToString());
            }

            var romanNumeral = new RomanNumeral();

            while (number > 0)
            {
                var nextSymbol = FindHighestSymbol(number);
                romanNumeral.Symbols.Add(nextSymbol);

                number -= (int) nextSymbol;
            }

            return romanNumeral;
        }

        private RomanSymbol FindHighestSymbol(int number)
        {
            var symbols = Enum
                .GetValues(typeof(RomanSymbol))
                .Cast<RomanSymbol>()
                .ToList();

            var highestSymbol = symbols
                .OrderByDescending(s => (int) s)
                .FirstOrDefault(s => (int) s <= number);

            return highestSymbol;
        }
    }
}
