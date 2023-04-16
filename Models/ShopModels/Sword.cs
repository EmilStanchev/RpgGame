using Interfaces.ShopInterfaces;

namespace Models.ShopModels
{
    public class Sword : ISword
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Price { get; set; }
    }
}
