using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.StorageInterfaces;

namespace Models.StorageModels
{
    public class GameStorage : IGameStorage
    {
        public List<IBaseHero> Heroes { get; set; } = new List<IBaseHero>();
        public List<IBaseMonster> Monsters { get; set; } = new List<IBaseMonster>();
    }
}
