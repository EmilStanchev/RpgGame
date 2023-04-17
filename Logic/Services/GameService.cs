using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.ShopInterfaces;

namespace Logic.Services
{
    public class GameService
    {
        private readonly IHeroLogic _heroLogic;
        private readonly IMonsterLogic _monsterLogic;
        private readonly IInputLogic _inputLogic;
        private readonly IProcessingInput _processingInput;
        private readonly IShopLogic _shopLogic;
        public GameService(IHeroLogic heroLogic, IMonsterLogic monsterLogic,
            IInputLogic inputLogic, IProcessingInput processingInput, IShopLogic logic)
        {
            _heroLogic = heroLogic;
            _monsterLogic = monsterLogic;
            _inputLogic = inputLogic;
            _processingInput = processingInput;
            _shopLogic = logic;
        }
        public IBaseHero UserFirstChoise()
        {
            CreateMonsters();
            CreateSwords();
            var input = _inputLogic.FirstChoose();
            while (input != 1)
            {
                _processingInput.FirstChoice(input);
                input = _inputLogic.FirstChoose();
            }
            var name = _inputLogic.NameChoose();
            var hero = CreateHero(name);
            return hero;
        }
        public void UserSecondChoice()
        {
            Console.Clear();
            int option = _inputLogic.SecondChoose();
            while (option != 4)
            {
                _processingInput.SecondChoice(option);
                option = _inputLogic.SecondChoose();
            }
            _processingInput.SecondChoice(option);
        }
        private IBaseHero CreateHero(string name)
        {
            var hero = _heroLogic.CreateHero(name);
            _heroLogic.AddHero(hero);
            return hero;
        }
        private void CreateMonsters()
        {
            _monsterLogic.CreatingMonsters();
        }
        private void CreateSwords()
        {
            _shopLogic.CreateTheSwords();
        }
    }
}
