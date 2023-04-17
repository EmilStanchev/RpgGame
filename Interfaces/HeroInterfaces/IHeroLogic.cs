using Interfaces.MonsterInterfaces;

namespace Interfaces.HeroInterfaces
{
    public interface IHeroLogic
    {
        public IBaseHero CreateHero(string name);
        public void AddHero(IBaseHero hero);
        public void Fight(IBaseHero hero, IBaseMonster monster);
        public void CalculateNeededExp(IBaseHero hero);
        public void LevelUp(IBaseHero hero);
    }
}
