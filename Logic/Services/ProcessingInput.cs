using Interfaces.InputInterfaces;
using Interfaces.PrintningInterfaces;

namespace Logic.Services
{
    public class ProcessingInput : IProcessingInput
    {
        private readonly IGameMenu _gameMenu;
        public ProcessingInput(IGameMenu menu)
        {
            _gameMenu = menu;
        }

        public void FirstChoice(int option)
        {
            switch (option)
            {
                case 2:
                    _gameMenu.Tutorial();
                    break;
                case 3:
                    ExitOption();
                    break;
            }
        }
        private void ExitOption()
        {
            Environment.Exit(0);
        }
    }
}
