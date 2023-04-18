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
            var stoneSword = _swordFactory.CreateSword("Stone Sword", 4, 54);
            var elfSword = _swordFactory.CreateSword("Elf Sword", 12, 229);
            var dwarfSword = _swordFactory.CreateSword("Dwarf Sword", 34, 500);
            List<ISword> swords = new List<ISword>() { stoneSword, elfSword, dwarfSword };
            _shop.Swords.AddRange(swords);
        }
    }
}
