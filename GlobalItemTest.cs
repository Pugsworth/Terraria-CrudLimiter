using System;
using Terraria;
using Terraria.ModLoader;

namespace MyTestMod
{
    public class GlobalItemTest : GlobalItem
    {
        public override bool CanPickup(Item item, Player player)
        {
            if (MyTestMod.FullOfItem(item, player) && MyTestMod.CrudItems.Contains(item, player)) {
                return false;
            }

            return base.CanPickup(item, player);
        }

        public override bool OnPickup(Item item, Player player)
        {
            return base.OnPickup(item, player);
        }
    }
}