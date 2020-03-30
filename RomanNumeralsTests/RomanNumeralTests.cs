using System;
using RomanNumerals;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Test1ToRoman()
        {
            var romanConverter = new RomanConverter();
            Assert.Equal("I", romanConverter.ConvertDecToRoman(1));
        }
        
    }
}