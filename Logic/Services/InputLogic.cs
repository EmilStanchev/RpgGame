using Interfaces.InputInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.ReadingInterfaces;

namespace Logic.Services
{
    public class InputLogic : IInputLogic
    {
        private readonly IGameMenu _menu;
        private readonly IReader _reader;
        public InputLogic(IGameMenu menu, IReader reader)
        {
            _menu = menu;
            _reader = reader;
        }
        public int FirstChoose()
        {
            _menu.StartMessage();
            var input = _reader.ConsoleReadNumber(3);
            return input;
        }
        public string NameChoose()
        {
            _menu.CreateHeroMessage();
            var input = _reader.ConsoleReadLine();
            return input;
        }
    }
}
