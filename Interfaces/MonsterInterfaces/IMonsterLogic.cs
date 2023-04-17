﻿namespace Interfaces.MonsterInterfaces;

public interface IMonsterLogic
{
    public void CreatingMonsters();
    public void GetAllMonsters();
    public void GetListsCount();
    public IBaseMonster GetMonsterByName(IBaseMonster monster);
}

