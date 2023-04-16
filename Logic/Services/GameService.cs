using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;

namespace Logic.Services
{
    public class GameService
    {
        private readonly IHeroLogic _heroLogic;
        private readonly IMonsterLogic _monsterLogic;
        private readonly IInputLogic _inputLogic;
        public GameService(IHeroLogic heroLogic, IMonsterLogic monsterLogic, IInputLogic inputLogic)
        {
            _heroLogic = heroLogic;
            _monsterLogic = monsterLogic;
            _inputLogic = inputLogic;
        }
        public void UserFirstChoise()
        {
            CreateMonsters();
            var input = _inputLogic.FirstChoose();
            while (input != 1)
            {
                input = _inputLogic.FirstChoose();
            }
            var name = _inputLogic.NameChoose();
            var hero = CreateHero(name);
            _monsterLogic.GetAllMonsters();
            _monsterLogic.GetListsCount();
        }
        public void UserSecondChoice()
        {
            var option = _inputLogic.SecondChoose();
        }
        private IBaseHero CreateHero(string name)
        {
            var hero = _heroLogic.CreateHero(name);
            Console.WriteLine($"The name is: {name}");
            _heroLogic.AddHero(hero);
            return hero;
        }
        private void CreateMonsters()
        {
            _monsterLogic.CreatingMonsters();
        }
    }
}
