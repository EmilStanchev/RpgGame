using Interfaces.MonsterInterfaces;

namespace Models.MonsterModels
{
    public class BaseMonster : IBaseMonster
    {
        public BaseMonster(string name, int hp, int strength, int givenExperience, int gold)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            GivenExperience = givenExperience;
            Gold = gold;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int GivenExperience { get; set; }
        public int Gold { get; set; }
    }
}
