using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic.Services
{
    public class ProcessingInput : IProcessingInput
    {
        private readonly IGameMenu _gameMenu;
        private readonly IGameStorage _storage;
        private readonly IHeroLogic _heroLogic;
        public ProcessingInput(IGameMenu menu, IGameStorage storage, IHeroLogic logic)
        {
            _gameMenu = menu;
            _storage = storage;
            _heroLogic = logic;
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
        public void SecondChoice(int option, IBaseHero hero)
        {
            switch (option)
            {
                case 1:
                    _gameMenu.MonsterList(_storage.Monsters);
                    break;
                case 2:
                    _gameMenu.HeroInfo(hero);
                    break;
                case 3:
                    _gameMenu.AllSwords(_storage.Shop.Swords);
                    Console.WriteLine(_storage.Shop.Swords.Count() + "count");
                    break;
                case 4:
                    ExitOption();
                    break;
            }
        }
        public void ThirdChoice(int option)
        {
            switch (option)
            {
                case 1:
                    MonsterChoice(option);
                    break;
            }
        }
        public IBaseMonster MonsterChoice(int option)
        {
            switch (option)
            {
                case 1:
                    return _storage.Monsters.SingleOrDefault(m => m.Name == "Rat");
                case 2:
                    return _storage.Monsters.SingleOrDefault(m => m.Name == "Boar");
                case 3:
                    return _storage.Monsters.SingleOrDefault(m => m.Name == "Wolf");
                case 4:
                    return _storage.Monsters.SingleOrDefault(m => m.Name == "Bear");
            }
            return null;
        }
        private void ExitOption()
        {
            Environment.Exit(0);
        }
    }
}
