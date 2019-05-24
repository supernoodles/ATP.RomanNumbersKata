namespace ATP.RomanNumbersKata.Source
{
    using System.Collections.Generic;

    public class RomanNumeralConverter
    {
        private readonly SortedDictionary<int,string> _romanNumeralsLookup = new SortedDictionary<int, string>
        {
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"},
            {5, "V"},
            {10, "X"}
        };

        public string ToRoman(int arabic)
        {
            return _romanNumeralsLookup[arabic];
        }
    }
}