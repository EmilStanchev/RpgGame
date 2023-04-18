using Interfaces.Factories;
using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.ShopInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic.Services
{
    public class HeroLogic : IHeroLogic
    {
        private readonly IHeroFactory _heroFactory;
        private readonly IGameStorage _gameStorage;
        private readonly IPrint _print;
        public HeroLogic(IHeroFactory heroFactory, IGameStorage gameStorage, IPrint print)
        {
            _heroFactory = heroFactory;
            _gameStorage = gameStorage;
            _print = print;
        }
        public IBaseHero CreateHero(string name)
        {
            return _heroFactory.CreateHero(name);
        }
        public void AddHero(IBaseHero hero)
        {
            _gameStorage.AddHero(hero);
        }
        public void Fight(IBaseHero hero, IBaseMonster monster)
        {
            while (hero.HP > 0 && monster.HP > 0)
            {
                Console.WriteLine($"Hero hp:{hero.HP}");
                monster.HP -= hero.Strength;
                hero.HP -= monster.Strength;
                Console.WriteLine($"Hero hp:{hero.HP}");
            }
            if (hero.HP > monster.HP)
            {
                _print.Message($"{hero.Name} won vs {monster.Name} and get {monster.Gold} gold and {monster.GivenExperience} experience" +
                    $"point!He has {hero.HP} HP");
                hero.Gold += monster.Gold;
                hero.Experience += monster.GivenExperience;
            }
            else if (hero.HP < monster.HP)
            {
                _print.Message($"{monster.Name} won!");
                hero.HP = 1;
            }
            else
            {
                _print.Message("Draw");
            }
        }
        public void CalculateNeededExp(IBaseHero hero)
        {
            int baseExperience = 100;
            double growthRate = 1.2;
            int experienceRequired = (int)(baseExperience * Math.Pow(growthRate, hero.Level - 1));
            hero.ExperienceRequired = experienceRequired;
        }
        public void LevelUp(IBaseHero hero)
        {
            if (hero.Experience >= hero.ExperienceRequired)
            {
                hero.Level += 1;
                hero.Experience = 0;
            }
        }
        public void Buy(IBaseHero hero, ISword sword)
        {
            if (hero.Gold >= sword.Price)
            {
                _print.Message($"You bought {sword.Name} for {sword.Price}");
                hero.Gold -= sword.Price;
                hero.Strength += sword.Strength;
            }
            else
            {
                int difference = sword.Price - hero.Gold;
                _print.Message($"You dont have enough gold. You need {difference} more gold");
            }

        }
    }
}
