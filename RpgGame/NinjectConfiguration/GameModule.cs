﻿using Interfaces.Factories;
using Interfaces.GameInterfaces;
using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.PrintningInterfaces;
using Interfaces.ReadingInterfaces;
using Interfaces.ShopInterfaces;
using Interfaces.StorageInterfaces;
using Logic;
using Logic.Services;
using Models.HelpingClasses;
using Models.HeroModels;
using Models.MonsterModels;
using Models.ShopModels;
using Models.StorageModels;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace RpgGame.NinjectConfiguration
{
    public class GameModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrint>().To<Print>().InSingletonScope();
            Bind<IProcessingInput>().To<ProcessingInput>().InSingletonScope();
            Bind<IReader>().To<Reader>().InSingletonScope();
            Bind<ISword>().To<Sword>();
            Bind<IBaseHero>().To<BaseHero>();
            Bind<IBaseMonster>().To<BaseMonster>();
            Bind<ISwordFactory>().ToFactory();
            Bind<IHeroFactory>().ToFactory();
            Bind<IMonsterFactory>().ToFactory();
            Bind<IShopModel>().To<Shop>().InSingletonScope();
            Bind<IGameStorage>().To<GameStorage>().InSingletonScope(); ;
            Bind<IGameMenu>().To<GameMenu>().InSingletonScope();
            Bind<IInputLogic>().To<InputLogic>().InSingletonScope();
            Bind<IHeroLogic>().To<HeroLogic>().InSingletonScope();
            Bind<IMonsterLogic>().To<MonsterLogic>().InSingletonScope();
            Bind<IShopLogic>().To<ShopLogic>();
            Bind<IGameService>().To<GameService>();
        }
    }
}
