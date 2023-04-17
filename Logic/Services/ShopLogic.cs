using Interfaces.Factories;
using Interfaces.ShopInterfaces;

namespace Logic.Services
{
    public class ShopLogic : IShopLogic
    {
        private readonly IShopModel _shop;
        private readonly ISwordFactory _swordFactory;
        public ShopLogic(IShopModel shop, ISwordFactory factory)
        {
            _shop = shop;
            _swordFactory = factory;
        }

        public void CreateTheSwords()
        {
            var test = _swordFactory.CreateSword("test", 12, 2);
            var stoneSword = _swordFactory.CreateSword("Stone Sword", 22, 4);
            var elfSword = _swordFactory.CreateSword("Elf Sword", 52, 9);
            var dwarfSword = _swordFactory.CreateSword("Dwarf Sword", 202, 19);
            List<ISword> swords = new List<ISword>() { stoneSword, elfSword, dwarfSword };
            _shop.Swords.AddRange(swords);
        }
    }
}
