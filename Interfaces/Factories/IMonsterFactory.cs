using Interfaces.MonsterInterfaces;

namespace Interfaces.Factories
{
    public interface IMonsterFactory
    {
        public IBaseMonster CreateMonster(string name, int hp, int strength, int gold, int givenExperience);
    }
}
