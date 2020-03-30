using System.Collections.Generic;
using System.Text;

// ReSharper disable InconsistentNaming

namespace RomanNumerals
{
    public class RomanConverter
    {
        private enum RomanSymbol
        { 
            I = 1,
            IV = 4,
            V = 5,
            IX = 9,
            X = 10,
            XL = 40,
            L = 50,
            XC = 90,
            C = 100,
            CD = 400,
            D = 500,
            CM = 900,
            M = 1000, 
        }

        private Dictionary<RomanSymbol, int> RomanNumerals = new Dictionary<RomanSymbol, int>
        {
            {RomanSymbol.I, 1},
            {RomanSymbol.IV,4},
            {RomanSymbol.V,5},
            {RomanSymbol.IX, 9},
            {RomanSymbol.X,10},
            {RomanSymbol.XL,40},
            {RomanSymbol.L, 50},
            {RomanSymbol.XC,90},
            {RomanSymbol.C,100},
            {RomanSymbol.CD, 400},
            {RomanSymbol.D,500},
            {RomanSymbol.CM,900},
            {RomanSymbol.M, 1000}
        };
            
        
        public string ConvertDecToRoman(int number)
        {
            var roman = new StringBuilder(); 
            
            foreach (var romanSymbol in RomanNumerals)
            {
                while (number >=  romanSymbol.Value)
                {
                    roman.Append(romanSymbol.Key);
                    number -=  romanSymbol.Value;
                }
            }
            return roman.ToString().ToUpper();
        }
    }
}