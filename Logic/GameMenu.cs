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
        public void Tutorial()
        {
            _print.Message("The King`s Bounty is RPG console game. First you should join in our community. To do this you should " +
            " choose option '1' from the previous menu. You should pick your hero name.  After you choose the class" +
            " You can attack monsters by choosing option. If you beat them u will recieve experience points and gold. With each level" +
            " your hero HP and Strenght will increase. If you beat all the monster u win. Have fun and don`t leave without get the" +
            " head of the last monster. Good luck and watch out.");
        }
        private void ChooseOptionMessage()
        {
            _print.Message("Choose option to continue");
        }
    }
}
