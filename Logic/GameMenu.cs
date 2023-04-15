using Interfaces.MonsterInterfaces;
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
            ChooseOptionMessage();
            _print.Message("1. Create hero");
            _print.Message("2. Game info");
            _print.Message("3. Exit");
        }
        public void CreateHeroMessage()
        {
            _print.Message("Welcome to the journey. You should choose name for your hero. ");
        }
        public void MonsterList(List<IBaseMonster> monsters)
        {
            for (int i = 0; i < monsters.Count(); i++)
            {
                _print.Message($"{i + 1}. {monsters[i].Name}");
            }
        }
        public void SecondMessage()
        {
            _print.Message("Start fight and get gold and experience from monsters.Good luck!");
            ChooseOptionMessage();
            _print.Message("1. Fight");
            _print.Message("2. Hero info");
            _print.Message("3. Shop");
            _print.Message("4. Exit");
        }
        private void ChooseOptionMessage()
        {
            _print.Message("Choose option to continue");
        }
    }
}
