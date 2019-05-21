namespace ATP.RomanNumbersKata.Tests
{
    using FluentAssertions;
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

        [Test]
        public void Given1_ReturnI()
        {
            var result = _romanNumeralConverter.ToRoman(1);
            result.Should().Be("I");
        }
    }
}
