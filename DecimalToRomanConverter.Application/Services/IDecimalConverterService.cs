using DecimalToRomanConverter.Domain.Entities;

namespace DecimalToRomanConverter.Application.Services
{
    public interface IDecimalConverterService
    {
        RomanNumeral ConvertToRoman(int number);
    }
}