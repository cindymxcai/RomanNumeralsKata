using System;

namespace RomanNumerals
{
    public class UserInput : IUserInput
    {
        private readonly IConsoleReader _consoleReader;

        public UserInput(IConsoleReader consoleReader)
        {
            _consoleReader = consoleReader;
        }

        public int GetInput()
        {
            return _consoleReader.GetInput();
        }
    }
}