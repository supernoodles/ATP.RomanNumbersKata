namespace ATP.RomanNumbersKata.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using Source;

    [TestFixture]
    public class RomanNumeralConverterShould
    {
        [Test]
        public void Given1_ReturnI()
        {
            var converter = new RomanNumeralConverter();
            string result = converter.ToRoman(1);
            result.Should().Be("I");
        }
    }
}
