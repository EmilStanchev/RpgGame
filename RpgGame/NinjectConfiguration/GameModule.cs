using Interfaces.Factories;
using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.ReadingInterfaces;
using Interfaces.StorageInterfaces;
using Models.HelpingClasses;
using Models.HeroModels;
using Models.MonsterModels;
using Models.StorageModels;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace RpgGame.NinjectConfiguration
{
    public class GameModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrint>().To<Print>();
            Bind<IReader>().To<Reader>();
            Bind<IArcher>().To<ArcherModel>();
            Bind<IMage>().To<MageModel>();
            Bind<IWarrior>().To<WarriorModel>();
            Bind<IBaseMonster>().To<BaseMonster>();
            Bind<IGameStorage>().To<GameStorage>();
            Bind<IHeroFactory>().ToFactory();
            Bind<IMonsterFactory>().ToFactory();

        }
    }
}
