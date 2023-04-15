using Interfaces.HeroInterfaces;

namespace Interfaces.Factories
{
    public interface IHeroFactory
    {
        public IWarrior CreateWarrior(string name);
        public IMage CreateMage(string name);
        public IArcher CreateArcher(string name);

    }
}
