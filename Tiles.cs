using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace MyModTest.Groups
{
    public static class Tiles
    {
        public static IReadOnlyList<ushort> Ore = new List<ushort> {
            TileID.Iron,
            TileID.Copper,
            TileID.Gold,
            TileID.Silver,

            TileID.Meteorite,

            TileID.Cobalt,
            TileID.Mythril,
            TileID.Adamantite,

            TileID.Tin,
            TileID.Lead,
            TileID.Tungsten,
            TileID.Platinum,

            TileID.Chlorophyte,

            TileID.Palladium,
            TileID.Orichalcum,
            TileID.Titanium,

            TileID.FossilOre
        };

        public static IReadOnlyList<ushort> Environment = new List<ushort> {
            TileID.Heart,

            TileID.Containers,
            TileID.Pots,
            TileID.LifeFruit,
            TileID.DyePlants,

            TileID.FakeContainers,
            TileID.Containers2,
            TileID.FakeContainers2
        };

        public static IReadOnlyList<ushort> Gems = new List<ushort> {
            TileID.Sapphire,
            TileID.Ruby,
            TileID.Emerald,
            TileID.Topaz,
            TileID.Amethyst,
            TileID.Diamond
        };
    }
}