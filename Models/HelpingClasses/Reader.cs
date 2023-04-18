using Interfaces.ReadingInterfaces;

namespace Models.HelpingClasses
{
    public class Reader : IReader
    {
        public string ConsoleReadLine()
        {
            var input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
            }
            return input;
        }
        public int ConsoleReadNumber(int max)
        {
            var rawInput = Console.ReadLine();
            while (!Checker(rawInput))
            {
                rawInput = Console.ReadLine();
            }
            var input = int.Parse(rawInput);
            while (input > max)
            {
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
        private bool Checker(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            return true;
        }
    }
}
