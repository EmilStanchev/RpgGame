﻿using Interfaces.HeroInterfaces;
using Interfaces.InputInterfaces;
using Interfaces.MonsterInterfaces;

namespace Logic.Services
{
    public class GameService
    {
        private readonly IHeroLogic _heroLogic;
        private readonly IMonsterLogic _monsterLogic;
        private readonly IInputLogic _inputLogic;
        private readonly IProcessingInput _processingInput;
        public GameService(IHeroLogic heroLogic, IMonsterLogic monsterLogic, IInputLogic inputLogic, IProcessingInput processingInput)
        {
            _heroLogic = heroLogic;
            _monsterLogic = monsterLogic;
            _inputLogic = inputLogic;
            _processingInput = processingInput;
        }
        public IBaseHero UserFirstChoise()
        {
            CreateMonsters();
            var input = _inputLogic.FirstChoose();
            while (input != 1)
            {
                _processingInput.FirstChoice(input);
                input = _inputLogic.FirstChoose();
            }
            var name = _inputLogic.NameChoose();
            var hero = CreateHero(name);
            _monsterLogic.GetAllMonsters();
            return hero;
        }
        public void UserSecondChoice()
        {
            int option = _inputLogic.SecondChoose();
            while (option != 1)
            {
                _processingInput.SecondChoice(option);
                option = _inputLogic.SecondChoose();
            }
            _processingInput.SecondChoice(option);
        }
        private IBaseHero CreateHero(string name)
        {
            var hero = _heroLogic.CreateHero(name);
            Console.WriteLine($"The name is: {name}");
            _heroLogic.AddHero(hero);
            return hero;
        }
        private void CreateMonsters()
        {
            _monsterLogic.CreatingMonsters();
        }
    }
}
