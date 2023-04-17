using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;

namespace Interfaces.InputInterfaces
{
    public interface IProcessingInput
    {
        public void FirstChoice(int option);
        public void SecondChoice(int option, IBaseHero hero);
        public IBaseMonster MonsterChoice(int option);
    }
}
