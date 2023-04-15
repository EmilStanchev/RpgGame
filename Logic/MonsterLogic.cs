using Interfaces.Factories;
using Interfaces.MonsterInterfaces;
using Interfaces.StorageInterfaces;

namespace Logic
{
    public class MonsterLogic
    {
        private readonly IMonsterFactory _factory;
        private readonly IGameStorage _storage;
        public MonsterLogic(IMonsterFactory factory, IGameStorage storage)
        {
            _factory = factory;
            _storage = storage;
        }
        public void CreatingMonsters()
        {
            var rat = _factory.CreateMonster("Rat", 3, 3, 5, 1);
            var boar = _factory.CreateMonster("Boar", 7, 5, 9, 4);
            var wolf = _factory.CreateMonster("Wolf", 11, 8, 14, 7);
            var bear = _factory.CreateMonster("Bear", 22, 17, 21, 11);
            List<IBaseMonster> monsters = new List<IBaseMonster>() { rat, boar, wolf, bear };
            _storage.Monsters.AddRange(monsters);
        }
        public void GetAllMonsters()
        {
            foreach (var item in _storage.Monsters)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
