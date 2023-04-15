using Interfaces.HeroInterfaces;

namespace Models.HeroModels
{
    public class MageModel : BaseHero, IMage
    {
        protected override int _startHP { get; set; } = 15;

        protected override int _startStrength { get; set; } = 13;
        public MageModel(string name) : base(name)
        {
        }
    }
}
