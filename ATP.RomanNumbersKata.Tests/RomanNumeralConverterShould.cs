namespace ATP.RomanNumbersKata.Tests
{
    using System;
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

        [TestCase(4000)]
        [TestCase(4030)]
        [TestCase(0)]
        [TestCase(-1)]
        public void GivenArabicNumberOutsideRomanRange_ThrowArgumentException(int arabic)
        {
            Assert.That(() =>_romanNumeralConverter.ToRoman(arabic), Throws.TypeOf<ArgumentException>());
        }

        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(4, ExpectedResult = "IV")]
        public string GivenArabicNumberInsideRomanRange_ReturnExpectedRomanNumeral(int arabic) =>
            _romanNumeralConverter.ToRoman(arabic);
    }
}
