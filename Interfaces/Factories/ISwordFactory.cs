using Interfaces.ShopInterfaces;

namespace Interfaces.Factories
{
    public interface ISwordFactory
    {
        public ISword CreateSword(string name, int strength, int price);
    }
}
