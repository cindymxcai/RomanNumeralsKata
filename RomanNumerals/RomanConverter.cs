using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanConverter : IRomanConverter
    {

        private readonly Dictionary<string,int> _romanNumeralDictionary = new Dictionary<string, int>()
        {
            {"M", 1000},
            {"CM", 900},
            {"D", 500},
            {"CD", 400},
            {"C", 100},
            {"XC", 90},
            {"L", 50},
            {"XL", 40},
            {"X", 10},
            {"IX", 9},
            {"V", 5},
            {"IV", 4},
            {"I", 1}
        };

        private readonly UserInput _userInput;

        public RomanConverter(UserInput userInput)
        {
            _userInput = userInput;
        }
        
        public string ToRomanNumeral(int number)
        {
            var romanNumeral = new StringBuilder();
            //separate out
            //single responsibility -> not dependent on each other
            var currentNumber = number;

            foreach (var romanSymbol in _romanNumeralDictionary)
            {
                while (currentNumber >=   romanSymbol.Value)
                {
                    romanNumeral.Append(romanSymbol.Key);
                    currentNumber -= romanSymbol.Value;
                }
            }
            return romanNumeral.ToString().ToUpper();
        }
        
    }
}