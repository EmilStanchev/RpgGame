namespace Interfaces.MonsterInterfaces
{
    public interface IBaseMonster
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int GivenExperience { get; set; }
        public int Gold { get; set; }

    }
}
