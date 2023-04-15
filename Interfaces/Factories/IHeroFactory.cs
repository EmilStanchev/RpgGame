using Interfaces.HeroInterfaces;

namespace Interfaces.Factories
{
    public interface IHeroFactory
    {
        public IBaseHero CreateHero(string name);

    }
}
