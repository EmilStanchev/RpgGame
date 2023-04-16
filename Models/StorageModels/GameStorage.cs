using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.StorageInterfaces;

namespace Models.StorageModels
{
    public class GameStorage : IGameStorage
    {
        public List<IBaseHero> Heroes { get; set; } = new List<IBaseHero>();
        public List<IBaseMonster> Monsters { get; set; } = new List<IBaseMonster>();
        public void GetCountOfLists()
        {
            Console.WriteLine($"Heroes:{Heroes.Count()}, Monsters: {Monsters.Count()}");
        }
        public void AddHero(IBaseHero hero)
        {
            Heroes.Add(hero);
            Console.WriteLine($"You added hero with name: {hero.Name}");
        }
    }
}
