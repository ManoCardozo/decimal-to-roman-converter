using DecimalToRomanConverter.Application.Exceptions;
using DecimalToRomanConverter.Domain.Entities;

namespace DecimalToRomanConverter.Application.Services
{
    public class DecimalConverterService : IDecimalConverterService
    {
        public RomanNumeral ConvertToRoman(int number)
        {
            if (number > 3999 || number < 3999)
            {
                throw new OutOfRomanNumeralBoundsException(number.ToString());
            }

            return new RomanNumeral();
        }
    }
}
