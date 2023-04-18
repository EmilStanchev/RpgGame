using Interfaces.HeroInterfaces;

namespace Interfaces.GameInterfaces
{
    public interface IGameService
    {
        public IBaseHero UserFirstChoise();
        public void Start();
        public IBaseHero Gameplay();
        public void UserThirdChoice(IBaseHero hero);

    }
}
