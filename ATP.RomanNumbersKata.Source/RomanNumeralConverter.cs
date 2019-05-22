
namespace ATP.RomanNumbersKata.Source
{
    using System;
    public class RomanNumeralConverter
    {
        public string ToRoman(int arabic)
        {
            if (arabic <= 0 || arabic >= 4000)
            {
                throw  new ArgumentException();
            }

            var romanNumerals = new[] {"I", "II", "III", "IV"};

            return romanNumerals[arabic - 1];
        }
    }
}