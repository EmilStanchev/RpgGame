namespace Interfaces.HeroInterfaces
{
    public interface IBaseHero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }

    }
}
