namespace DecimalToRomanConverter.Application.Extensions
{
    public static class IntExtensions
    {
        public static bool InRange(this int value, int minValue, int maxValue)
        {
            return value >= minValue && value <= maxValue;
        }
    }
}
