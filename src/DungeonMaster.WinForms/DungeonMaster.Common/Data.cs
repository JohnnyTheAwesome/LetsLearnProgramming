using DungeonMaster.Common.DomainModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace DungeonMaster.Common
{
    public static class Data
    {
        public static World World { get; set; }

        static Data()
        {
            bool deserializingWorldSucceded;
            World deserializedWorld = null;

            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                path = Path.Combine(path, "myData.txt");

                deserializedWorld = Data.DeserializeMyWorld(path);
                deserializingWorldSucceded = true;
            }
            catch (Exception ex)
            {
                deserializingWorldSucceded = false;
            }

            if (deserializingWorldSucceded)
            {
                World = deserializedWorld;
            }
            else {
                #region Generate world manually
                World = new World("Example World");

                Land plains = World.CreateLand("Plains");
                Land forest = World.CreateLand("Forest");
                Land hills = World.CreateLand("Hills");
                Land mountains = World.CreateLand("Mountains");
                Land underground = World.CreateLand("Underground");

                Enemy orc = World.CreateEnemy("Orc");
                Enemy ogre = World.CreateEnemy("Ogre");
                Enemy troll = World.CreateEnemy("Troll");
                Enemy gnoll = World.CreateEnemy("Gnoll");
                Enemy goblin = World.CreateEnemy("Goblin");
                Enemy wolf = World.CreateEnemy("Wolf");
                Enemy griffon = World.CreateEnemy("Griffon");

                orc.AddLand(underground);
                orc.AddLand(mountains);
                orc.AddLand(hills);

                ogre.AddLand(hills);

                troll.AddLand(underground);

                gnoll.AddLand(plains);

                goblin.AddLand(plains);
                goblin.AddLand(forest);

                wolf.AddLand(forest);

                griffon.AddLand(hills);
                griffon.AddLand(mountains);
                #endregion
            }
        }

        //public static void AddEnemyWithLand(string newEnemyName, string landName)
        //{
        //    Enemy newEnemy = World.CreateEnemy(newEnemyName);
        //    Land land = World.Lands.First(lnd => lnd.Name.Equals(landName));
        //    newEnemy.AddLand(land);
        //}

        public static void AddEnemyWithLands(string newEnemyName, List<Land> lands)
        {
            Enemy newEnemy = World.CreateEnemy(newEnemyName);

            foreach(Land land in lands)
            {
                newEnemy.AddLand(land);
            }
        }

        public static string SerializeMyWorld()
        {
            Encoding encoding = Encoding.UTF8;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = encoding;
                settings.Indent = true;
                settings.NewLineOnAttributes = true;

                using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, settings))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(World));
                    serializer.WriteObject(xmlWriter, World);
                }

                return encoding.GetString(memoryStream.ToArray());
            }
        }

        public static World DeserializeMyWorld(string path)
        {
            World deserializedWorld;

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                using (XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas()))
                {
                    DataContractSerializer serializer = new DataContractSerializer(typeof(World));
                    deserializedWorld = (World)serializer.ReadObject(reader, true);
                }
            }

            return deserializedWorld;
        }        
    }
}
