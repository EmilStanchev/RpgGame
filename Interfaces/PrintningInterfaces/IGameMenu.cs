using Interfaces.MonsterInterfaces;

namespace Interfaces.PrintningInterfaces
{
    public interface IGameMenu
    {
        public void StartMessage();
        public void CreateHeroMessage();
        public void MonsterList(List<IBaseMonster> monsters);
        public void SecondMessage();

    }
}
