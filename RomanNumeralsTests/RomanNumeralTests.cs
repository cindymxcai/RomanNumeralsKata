using System;
using Xunit;

namespace RomanNumeralsTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("I", Roman.To(1));
        }
        
    }
}