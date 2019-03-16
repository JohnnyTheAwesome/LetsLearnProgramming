using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DungeonMaster.Common.DomainModel
{
    [DataContract(IsReference = true)]
    public class Enemy
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public World World { get; set; }

        [DataMember]
        public List<Land> Lands { get; set; }

        private Enemy() { }

        public Enemy(string name, World world)
        {
            Name = name;
            World = world;
            Lands = new List<Land>();
        }

        public void AddLand(Land land)
        {
            if(Lands.Any(lnd => lnd.Equals(land)))
            {
                return;
            }

            Lands.Add(land);
            World.AddLand(land);
            land.AddEnemy(this);
        }

        public override bool Equals(object obj)
        {
            if(obj is Enemy)
            {
                if(this.Name == (obj as Enemy).Name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}