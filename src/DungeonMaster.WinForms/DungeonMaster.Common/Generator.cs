using DungeonMaster.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Common
{
    public static class Generator
    {
        public static Tuple<Land, Enemy> GenerateLandAndEnemy()
        {
            int number = 0;
            var world = Data.World;

            Random RandomNumberGenerator = new Random();

            number = RandomNumberGenerator.Next(0, world.Lands.Count);
            Land land = world.Lands[number];

            number = RandomNumberGenerator.Next(0, land.Enemies.Count);
            Enemy enemy = land.Enemies[number];           

            return new Tuple<Land, Enemy>(land, enemy);
        }
    }
}
