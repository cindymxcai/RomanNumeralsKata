using System.Collections.Generic;

namespace RomanNumerals
{
    public class TestConsoleReader: IConsoleReader
    {
       
        private readonly int _userInput;
        
        public TestConsoleReader(int inputToReturn)
        {
            _userInput = inputToReturn;
        }

        public int GetInput()
        {
            return _userInput;
        }
    }
}