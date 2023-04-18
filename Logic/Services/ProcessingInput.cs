using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.ShopInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic.Services
{
    public class ProcessingInput : IProcessingInput
    {
        private readonly IGameMenu _gameMenu;
        private readonly IGameStorage _storage;
        private readonly IHeroLogic _heroLogic;
        private readonly IInputLogic _inputLogic;
        public ProcessingInput(IGameMenu menu, IGameStorage storage, IHeroLogic logic, IInputLogic inputLogic)
        {
            _gameMenu = menu;
            _storage = storage;
            _heroLogic = logic;
            _inputLogic = inputLogic;
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
                    option = _inputLogic.GetMonster();
                    var monster = MonsterChoice(option);
                    _heroLogic.Fight(hero, monster);
                    _heroLogic.LevelUp(hero);
                    break;
                case 2:
                    _gameMenu.HeroInfo(hero);
                    break;
                case 3:
                    _gameMenu.AllSwords(_storage.Shop.Swords);
                    option = _inputLogic.SwordForBuying();
                    var sword = SwordChoice(option);
                    _heroLogic.Buy(hero, sword);
                    break;
                case 4:
                    ExitOption();
                    break;
            }
        }
        public ISword SwordChoice(int option)
        {
            switch (option)
            {
                case 1:
                    return _storage.Shop.Swords.SingleOrDefault(s => s.Name == "Stone Sword");
                case 2:
                    return _storage.Shop.Swords.SingleOrDefault(s => s.Name == "Elf Sword");
                case 3:
                    return _storage.Shop.Swords.SingleOrDefault(s => s.Name == "Dwarf Sword");
            }
            return null;
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
