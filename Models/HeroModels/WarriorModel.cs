using Interfaces.HeroInterfaces;

namespace Models.HeroModels
{
    public class WarriorModel : BaseHero, IWarrior
    {
        protected override int _startHP { get; set; } = 30;
        protected override int _startStrength { get; set; } = 5;
        public WarriorModel(string name) : base(name)
        {
        }
    }
}
