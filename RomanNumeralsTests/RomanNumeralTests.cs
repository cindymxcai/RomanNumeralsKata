using RomanNumerals;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralTests
    {
        [Theory] 
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XXXIV", 34)]
        [InlineData("LXXXVI", 86)]
        [InlineData("CMXCIX", 999)]
        public void Test1ToRoman(string expected, int number)
        {
            var reader = new TestConsoleReader(number);
            var userInput = new UserInput(reader);
            var romanConverter = new RomanConverter(userInput);
            Assert.Equal(expected, romanConverter.ToRomanNumeral(number));
        }
    }
}