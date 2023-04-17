using Interfaces.ShopInterfaces;

namespace Models.ShopModels
{
    public class Sword : ISword
    {
        public Sword(string name, int strength, int price)
        {
            Name = name;
            Strength = strength;
            Price = price;
        }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Price { get; set; }
    }
}
