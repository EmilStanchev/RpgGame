using Logic;
using Ninject;
using RpgGame.NinjectConfiguration;

var kernel = new StandardKernel(new GameModule());
var gameService = kernel.Get<MonsterLogic>();
gameService.CreatingMonsters();
gameService.GetAllMonsters();
