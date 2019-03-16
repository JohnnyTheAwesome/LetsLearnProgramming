using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DungeonMaster.Common.DomainModel
{
    [DataContract(IsReference = true)]
    public class Land
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public World World { get; set; }

        [DataMember]
        public List<Enemy> Enemies { get; set; }

        private Land() { }

        public Land(string name, World world)
        {
            Name = name;
            World = world;
            Enemies = new List<Enemy>();
        }

        public void AddEnemy(Enemy enemy)
        {
            if(Enemies.Any(en => en.Equals(enemy)))
            {
                return;
            }

            Enemies.Add(enemy);
            World.AddEnemy(enemy);
            enemy.AddLand(this);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}