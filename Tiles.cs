using Terraria;
using Terraria.ID;

namespace MyModTest.Groups
{
    public static class Tiles
    {
        public const List<ushort> Ore = {
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

                TileId.FossilOre
        };

        public const List<ushort> Environment = {
            TileID.Heart,

            TileID.Containers,
            TileID.Pots,
            TileId.LifeFruit,
            TileID.DyePlants,

            TileID.FakeContainers,
            TileID.Containers2,
            TileID.FakeContainers2
        };

        public const List<ushort> Gems = {
            TileId.Sapphire,
            TileID.Ruby,
            TileID.Emerald,
            TileID.Topaz,
            TileID.Amethyst,
            TileID.Diamond
        };
    }
}