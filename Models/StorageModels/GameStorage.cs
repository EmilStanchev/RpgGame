using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.ShopInterfaces;
using Interfaces.StorageInterfaces;

namespace Models.StorageModels
{
    public class GameStorage : IGameStorage
    {
        public List<IBaseHero> Heroes { get; set; } = new List<IBaseHero>();
        public List<IBaseMonster> Monsters { get; set; } = new List<IBaseMonster>();
        public IShopModel Shop { get; set; }
        public GameStorage(IShopModel shop)
        {
            Shop = shop;
        }

        public void GetCountOfLists()
        {
            Console.WriteLine($"Heroes:{Heroes.Count()}, Monsters: {Monsters.Count()}");
        }
        public void AddHero(IBaseHero hero)
        {
            Heroes.Add(hero);
        }
    }
}
