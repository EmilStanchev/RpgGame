using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.ShopInterfaces;

namespace Interfaces.StorageInterfaces
{
    public interface IGameStorage
    {
        public List<IBaseHero> Heroes { get; set; }
        public List<IBaseMonster> Monsters { get; set; }
        public IShopModel Shop { get; set; }
        public void AddHero(IBaseHero hero);
        public void GetCountOfLists();
    }
}
