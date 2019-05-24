namespace ATP.RomanNumbersKata.Source
{
    using System.Collections.Generic;
    using System.Linq;

    public class RomanNumeralConverter
    {
        private readonly SortedDictionary<int,string> _romanNumeralsLookup = new SortedDictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
        };

        public string ToRoman(int arabic)
        {
            var result = "";

            foreach (var number in _romanNumeralsLookup.Keys.Reverse())
            {
                while (arabic >= number)
                {
                    result += _romanNumeralsLookup[number];
                    arabic -= number;
                }
            }

            return result;
        }
    }
}