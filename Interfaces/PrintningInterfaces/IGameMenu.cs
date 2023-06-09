﻿using Interfaces.HeroInterfaces;
using Interfaces.MonsterInterfaces;
using Interfaces.ShopInterfaces;

namespace Interfaces.PrintningInterfaces
{
    public interface IGameMenu
    {
        public void StartMessage();
        public void CreateHeroMessage();
        public void MonsterList(List<IBaseMonster> monsters);
        public void AllSwords(List<ISword> swords);
        public void SecondMessage();
        public void Tutorial();
        public void HeroInfo(IBaseHero hero);
        public void SwordList(List<ISword> swords);
    }
}
