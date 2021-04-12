using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace MyTestMod.ItemLists
{

    interface IItemSet
    {
        bool Contains(Item item, Player player);
    }

    public class NaturalBlocks : IItemSet {
        internal readonly static List<short> Soils = new List<short> {
            ItemID.DirtBlock,
            ItemID.StoneBlock,
            ItemID.EbonstoneBlock,
            ItemID.CrimstoneBlock,
            ItemID.PearlstoneBlock,
            ItemID.GraniteBlock,
            ItemID.MarbleBlock,
            ItemID.SandBlock,
            ItemID.EbonsandBlock,
            ItemID.CrimsandBlock,
            ItemID.PearlsandBlock,
            ItemID.Sandstone,
            ItemID.EbonsandBlock,
            ItemID.CrimsandBlock,
            ItemID.PearlsandBlock,
            ItemID.HardenedSand,
            ItemID.CorruptHardenedSand,
            ItemID.CrimsonHardenedSand,
            ItemID.HallowHardenedSand,
            ItemID.ClayBlock,
            ItemID.MudBlock,
            ItemID.SnowBlock,
            ItemID.IceBlock,
            ItemID.PinkIceBlock,
            ItemID.PurpleIceBlock,
            ItemID.RedIceBlock,
            ItemID.AshBlock
        };

        internal readonly static List<short> Other = new List<short> {
            ItemID.Cobweb
        };

        internal readonly static List<short> Drops = new List<short> {
            ItemID.Bone,
            ItemID.CrimsonSeeds,
            ItemID.Feather,
            ItemID.Gel,
            ItemID.Glowstick,
            ItemID.Lens,
            ItemID.BlackLens,
            ItemID.RottenChunk,
            ItemID.Vine,
            ItemID.WoodenArrow
        };

        internal readonly static List<short> Consumable = new List<short> {
            ItemID.Rope,
            ItemID.Torch,
            ItemID.HealingPotion,
            ItemID.LesserHealingPotion,
            ItemID.Acorn,
            ItemID.Snowball,
            ItemID.Shuriken,
            ItemID.ThrowingKnife
            // ItemID.Bone
        };

        internal readonly List<List<short>> Combined = new List<List<short>>();

        public NaturalBlocks()
        {
            Combined.Add(Soils);
            Combined.Add(Other);
            Combined.Add(Drops);
            Combined.Add(Consumable);
        }

        public bool Contains(Item item, Player player)
        {
            foreach (List<short> list in Combined) {
                if (list.Contains((short)item.type)) {
                    return true;
                }
            }

            return false;
        }
    }
}
