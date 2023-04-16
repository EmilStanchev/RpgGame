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
            var input = int.Parse(Console.ReadLine());
            while (input > max)
            {
                input = int.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}
