using System;

namespace RomanNumerals
{
    public class ConsoleReader : IConsoleReader
    {
        public int GetInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}