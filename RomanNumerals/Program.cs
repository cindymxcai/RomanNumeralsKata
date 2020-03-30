using System;

namespace RomanNumerals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a decimal to convert!");

            var consoleReader = new ConsoleReader();
            var _userInput = new UserInput(consoleReader);
            var currentNumber = _userInput.GetInput();
            RomanConverter romanConverter = new RomanConverter(new UserInput(consoleReader));

            Console.WriteLine("As Roman Numeral: {0}", romanConverter.ToRomanNumeral(currentNumber));
        }
    }
} 