namespace ATP.RomanNumbersKata.Source
{
    using System.Collections.Generic;
    using System.Linq;

    public class RomanNumeralConverter
    {
        private readonly SortedDictionary<int, string> _romanNumeralsLookup = new SortedDictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {40, "XL"},
            {50, "L"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };

        public string ToRoman(int arabic) =>
            _romanNumeralsLookup.Keys.Reverse()
                .Aggregate("", (result, number) =>
                {
                    while (arabic >= number)
                    {
                        result += _romanNumeralsLookup[number];
                        arabic -= number;
                    }

                    return result;
                });
    }
}