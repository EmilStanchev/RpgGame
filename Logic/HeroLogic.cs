using Interfaces.Factories;
using Interfaces.HeroInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic
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
        public IMage CreateMage(string name)
        {
            return _heroFactory.CreateMage(name);
        }
        public IWarrior CreateWarrior(string name)
        {
            return _heroFactory.CreateWarrior(name);
        }
        public IArcher CreateArcher(string name)
        {
            return _heroFactory.CreateArcher(name);
        }
        public void AddHero(IBaseHero hero)
        {
            _gameStorage.Heroes.Add(hero);
        }
    }
}
