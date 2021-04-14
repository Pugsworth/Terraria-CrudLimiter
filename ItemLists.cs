using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Reflection;


namespace MyTestMod
{
    public class CrudItems {
        internal readonly static List<ItemLimit> Crud = new List<ItemLimit> {
            new ItemLimit(ItemID.DirtBlock, -1),
            new ItemLimit(ItemID.StoneBlock, -1),
            new ItemLimit(ItemID.EbonstoneBlock, -1),
            new ItemLimit(ItemID.CrimstoneBlock, -1),
            new ItemLimit(ItemID.PearlstoneBlock, -1),
            new ItemLimit(ItemID.GraniteBlock, -1),
            new ItemLimit(ItemID.MarbleBlock, -1),
            new ItemLimit(ItemID.SandBlock, -1),
            new ItemLimit(ItemID.EbonsandBlock, -1),
            new ItemLimit(ItemID.CrimsandBlock, -1),
            new ItemLimit(ItemID.PearlsandBlock, -1),
            new ItemLimit(ItemID.Sandstone, -1),
            new ItemLimit(ItemID.EbonsandBlock, -1),
            new ItemLimit(ItemID.CrimsandBlock, -1),
            new ItemLimit(ItemID.PearlsandBlock, -1),
            new ItemLimit(ItemID.HardenedSand, -1),
            new ItemLimit(ItemID.CorruptHardenedSand, -1),
            new ItemLimit(ItemID.CrimsonHardenedSand, -1),
            new ItemLimit(ItemID.HallowHardenedSand, -1),
            new ItemLimit(ItemID.ClayBlock, -1),
            new ItemLimit(ItemID.MudBlock, -1),
            new ItemLimit(ItemID.SnowBlock, -1),
            new ItemLimit(ItemID.IceBlock, -1),
            new ItemLimit(ItemID.PinkIceBlock, -1),
            new ItemLimit(ItemID.PurpleIceBlock, -1),
            new ItemLimit(ItemID.RedIceBlock, -1),
            new ItemLimit(ItemID.AshBlock, -1),
        // Other
            new ItemLimit(ItemID.Cobweb, -1),
        // Drops
            new ItemLimit(ItemID.Bone, -1),
            new ItemLimit(ItemID.CrimsonSeeds, -1),
            new ItemLimit(ItemID.Feather, -1),
            new ItemLimit(ItemID.Gel, -1),
            new ItemLimit(ItemID.Glowstick, -1),
            new ItemLimit(ItemID.Lens, -1),
            new ItemLimit(ItemID.BlackLens, -1),
            new ItemLimit(ItemID.RottenChunk, -1),
            new ItemLimit(ItemID.Vine, -1),
            new ItemLimit(ItemID.WoodenArrow, -1),
        // Cunsumables
            new ItemLimit(ItemID.Rope, -1),
            new ItemLimit(ItemID.Torch, -1),
            new ItemLimit(ItemID.HealingPotion, -1),
            new ItemLimit(ItemID.LesserHealingPotion, -1),
            new ItemLimit(ItemID.Acorn, -1),
            new ItemLimit(ItemID.Snowball, -1),
            new ItemLimit(ItemID.Shuriken, -1),
            new ItemLimit(ItemID.ThrowingKnife, -1)
            // ItemID.Bone
        };

        public CrudItems()
        {
        }

        public bool Contains(Item item, Player player)
        {
            short sid = (short)item.type;
            foreach (var il in Crud) {
                if (il.ID == sid) {
                    return true;
                }
            }

            return false;
        }

        public string GetNameFromID(int id)
        {
            string result = "";

            Type type = typeof(ItemID);
            foreach (var p in type.GetFields())
            {
                var v = p.GetValue(null);
                switch(Type.GetTypeCode(v.GetType()))
                {
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.UInt16:
                    case TypeCode.UInt32:
                    case TypeCode.UInt64:
                        // MyTestMod.Instance.Logger.InfoFormat("{0} is {1}", p.Name, v);
                        break;
                    default:
                        break;
                }
            }

            return result;
        }

        public void FillItemNames()
        {
            foreach (ItemLimit ci in Crud) {
                ci.Name = GetNameFromID(ci.ID);
            }
        }
    }
}
