using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Common.DomainModel
{
    [DataContract(IsReference = true)]
    public class World
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Land> Lands { get; set; }

        [DataMember]
        public List<Enemy> Enemies { get; set; }

        private World() { }

        public World(string name)
        {
            Name = name;
            Lands = new List<Land>();
            Enemies = new List<Enemy>();
        }

        public Land CreateLand(string landName)
        {
            var land = new Land(landName, this);
            AddLand(land);
            return land;
        }

        public void AddLand(Land land)
        {
            if(Lands.Any(lnd => lnd.Equals(land)))
            {
                return;
            }

            Lands.Add(land);
        }

        public Enemy CreateEnemy(string enemyName)
        {
            var enemy = new Enemy(enemyName, this);
            AddEnemy(enemy);
            return enemy;
        }

        //A może tak?:

        //public Enemy CreateEnemy(string enemyName)
        //{
        //    Enemy enemy;
        //    if (Enemies.Any(en => en.Name == enemyName))
        //    {
        //        enemy = Enemies.First(en => en.Name == enemyName);
        //    }
        //    else
        //    {
        //        enemy = new Enemy(enemyName, this);
        //    }

        //    AddEnemy(enemy);
        //    return enemy;
        //}

        public void AddEnemy(Enemy enemy)
        {
            if (Enemies.Any(en => en.Equals(enemy)))
            {
                return;
            }

            Enemies.Add(enemy);
        }
    }
}
