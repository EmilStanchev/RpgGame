using Interfaces.Factories;
using Interfaces.HeroInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic.Services
{
    public class HeroLogic : IHeroLogic
    {
        private readonly IHeroFactory _heroFactory;
        private readonly IGameStorage _gameStorage;
        public HeroLogic(IHeroFactory heroFactory, IGameStorage gameStorage)
        {
            _heroFactory = heroFactory;
            _gameStorage = gameStorage;
        }
        public IBaseHero CreateHero(string name)
        {
            return _heroFactory.CreateHero(name);
        }
        public void AddHero(IBaseHero hero)
        {
            _gameStorage.AddHero(hero);
        }
    }
}
