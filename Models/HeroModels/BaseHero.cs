using Interfaces.HeroInterfaces;

namespace Models.HeroModels
{
    public class BaseHero : IBaseHero
    {
        protected virtual int _startHP { get; set; } = 25;
        protected virtual int _startStrength { get; set; } = 5;
        public BaseHero(string name)
        {
            Name = name;
            HP = _startHP;
            Strength = _startStrength;
            Level = 1;
            Experience = 0;
            Gold = 0;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
    }
}
