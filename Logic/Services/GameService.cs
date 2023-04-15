using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Models.MonsterModels;

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
            var input = _inputLogic.FirstChoose();
            while (input != 1)
            {
                input = _inputLogic.FirstChoose();
            }
            var name = _inputLogic.NameChoose();
            var hero = CreateHero(name);
        }
        public void UserSecondChoice()
        {

        }
        private IBaseHero CreateHero(string name)
        {
            var hero = _heroLogic.CreateHero(name);
            _heroLogic.AddHero(hero);
            return hero;
        }
    }
}
