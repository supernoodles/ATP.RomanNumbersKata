namespace ATP.RomanNumbersKata.Tests
{
    using NUnit.Framework;
    using Source;

    [TestFixture]
    public class RomanNumeralConverterShould
    {
        private RomanNumeralConverter _romanNumeralConverter;

        [SetUp]
        public void Setup()
        {
            _romanNumeralConverter = new RomanNumeralConverter();
        }

        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(20, ExpectedResult = "XX")]


        public string GivenArabicNumber_ReturnExpectedRomanNumeral(int arabic) =>
            _romanNumeralConverter.ToRoman(arabic);
    }
}
