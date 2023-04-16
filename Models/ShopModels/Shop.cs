using Interfaces.ShopInterfaces;

namespace Models.ShopModels
{
    public class Shop : IShopModel
    {
        public List<ISword> Swords { get; set; } = new List<ISword>();
    }
}
