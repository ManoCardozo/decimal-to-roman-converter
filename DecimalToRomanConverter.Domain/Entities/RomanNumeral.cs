using System.Collections.Generic;
using System.Linq;
using DecimalToRomanConverter.Domain.Enums;

namespace DecimalToRomanConverter.Domain.Entities
{
    public class RomanNumeral
    {
        public RomanNumeral()
        {
            Symbols = new List<RomanSymbol>();
        }

        public List<RomanSymbol> Symbols { get; set; }

        public override string ToString()
        {
            return string.Join("", Symbols);
        }
    }
}
