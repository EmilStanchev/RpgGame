using Interfaces.HeroInterfaces;

namespace Models.HeroModels
{
    public class BaseHero : IBaseHero
    {
        private int _startHP { get; set; } = 25;
        private int _startStrength { get; set; } = 5;
        private int _requiredExperience { get; set; } = 30;

        public BaseHero(string name)
        {
            Name = name;
            HP = _startHP;
            Strength = _startStrength;
            Level = 1;
            Experience = 0;
            Gold = 0;
            ExperienceRequired = _requiredExperience;
        }
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public int ExperienceRequired { get; set; }

    }
}
