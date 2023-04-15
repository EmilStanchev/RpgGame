namespace Interfaces.HeroInterfaces
{
    public interface IHeroLogic
    {
        public IBaseHero CreateHero(string name);
        public void AddHero(IBaseHero hero);

    }
}
