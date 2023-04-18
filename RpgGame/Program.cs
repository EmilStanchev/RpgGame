using Logic.Controllers;
using Ninject;
using RpgGame.NinjectConfiguration;

var kernel = new StandardKernel(new GameModule());
var gameController = kernel.Get<GameController>();
gameController.Start();

