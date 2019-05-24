namespace ATP.RomanNumbersKata.Source
{
    public class RomanNumeralConverter
    {
        public string ToRoman(int arabic)
        {
            var romanNumerals = new[] {"I", "II", "III", "IV","V","","","","","X"};

            return romanNumerals[arabic - 1];
        }
    }
}