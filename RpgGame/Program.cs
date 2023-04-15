using Logic.Services;
using Ninject;
using RpgGame.NinjectConfiguration;

var kernel = new StandardKernel(new GameModule());
var gameService = kernel.Get<GameService>();
gameService.UserFirstChoise();
gameService.UserSecondChoice();
