using Interfaces.PrintningInterfaces;
using Interfaces.ReadingInterfaces;

namespace Logic
{
    public class InputLogic
    {
        private readonly IGameMenu _menu;
        private readonly IReader _reader;
        public InputLogic(IGameMenu menu, IReader reader)
        {
            _menu = menu;
            _reader = reader;
        }
    }
}
