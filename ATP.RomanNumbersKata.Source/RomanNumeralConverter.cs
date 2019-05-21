namespace ATP.RomanNumbersKata.Source
{
    public class RomanNumeralConverter
    {
        public string ToRoman(int arabic)
        {
            var romanNumerals = new[] {"I", "II", "III", "IV"};

            return romanNumerals[arabic - 1];
        }
    }
}