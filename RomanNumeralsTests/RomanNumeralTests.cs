using System;
using RomanNumerals;
using Xunit;
using Xunit.Abstractions;

namespace RomanNumeralsTests
{
    public class RomanNumeralTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public RomanNumeralTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory] 
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("IV", 4)]
        public void Test1ToRoman(string expected, int actual)
        {
            var romanConverter = new RomanConverter();
            Assert.Equal(expected, romanConverter.ToRomanNumeral(actual));
        }

        [Fact]
        public void test2()
        {
            var romanConverter = new RomanConverter();
            Assert.Equal("I", romanConverter.ToRomanNumeral(1));
        }
    }
}