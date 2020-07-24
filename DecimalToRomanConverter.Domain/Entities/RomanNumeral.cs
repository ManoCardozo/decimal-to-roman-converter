using System.Collections.Generic;
using DecimalToRomanConverter.Domain.Enums;

namespace DecimalToRomanConverter.Domain.Entities
{
    public class RomanNumeral
    {
        List<RomanSymbol> Number { get; set; }

        public override string ToString()
        {
            return null;
        }
    }
}
