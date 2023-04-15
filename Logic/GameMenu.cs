using Interfaces.PrintningInterfaces;

namespace Logic
{
    public class GameMenu : IGameMenu
    {
        private readonly IPrint _print;
        public GameMenu(IPrint print)
        {
            _print = print;
        }
        public void StartMessage()
        {
            _print.Message("Welcome to the game.");
            _print.Message("Choose option to continue");
            _print.Message("1. Create hero");
            _print.Message("2. Game info");
            _print.Message("3. Exit");
        }
        public void CreateHeroMessage()
        {
            _print.Message("");
        }
    }
}
