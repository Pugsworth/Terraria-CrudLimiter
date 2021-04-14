using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader.IO;

namespace MyTestMod
{
    [Serializable]
    class ItemLimit : TagSerializable
    {
        public int ID;
        public int LimitSize;
        public string Name;

        public static Func<TagCompound, ItemLimit> DESERIALIZER = DeserializeData;

        public ItemLimit(short itemID, int limit) : this(null, itemID, limit) {}
        public ItemLimit(string name, short itemID, int limit)
        {
            Name = name;
            ID = itemID;
            LimitSize = limit;
        }
        public ItemLimit() { }

        public TagCompound SerializeData()
        {
            TagCompound root = new TagCompound();
            root.Add(Name, LimitSize);

            return root;
        }

        private static ItemLimit DeserializeData(TagCompound tag)
        {
            short id = tag.Get<short>("id");
            int limit = tag.Get<int>("limit");

            ItemLimit itemLimit = new ItemLimit(id, limit);

            return itemLimit;
        }
    }
}
