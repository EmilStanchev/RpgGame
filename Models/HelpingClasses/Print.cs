using Interfaces.PrintningInterfaces;

namespace Models.HelpingClasses
{
    public class Print : IPrint
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
