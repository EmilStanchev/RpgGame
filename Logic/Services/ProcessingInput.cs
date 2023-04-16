using Interfaces.InputInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic.Services
{
    public class ProcessingInput : IProcessingInput
    {
        private readonly IGameMenu _gameMenu;
        private readonly IGameStorage _storage;
        public ProcessingInput(IGameMenu menu, IGameStorage storage)
        {
            _gameMenu = menu;
            _storage = storage;
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
        public void SecondChoice(int option)
        {
            switch (option)
            {
                case 1:
                    _gameMenu.MonsterList(_storage.Monsters);
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
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
