using Interfaces.GameInterfaces;

namespace Logic.Controllers
{
    public class GameController : IGameController
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public void Start()
        {
            _gameService.Start();
        }
    }
}
