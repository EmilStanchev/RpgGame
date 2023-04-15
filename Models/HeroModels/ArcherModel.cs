using Interfaces.HeroInterfaces;

namespace Models.HeroModels
{
    public class ArcherModel : BaseHero, IArcher
    {
        protected override int _startHP { get; set; } = 21;
        protected override int _startStrength { get; set; } = 8;
        public ArcherModel(string name) : base(name)
        {
        }
    }
}
