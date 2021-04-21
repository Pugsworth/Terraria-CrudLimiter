using Terraria;
using Terraria.ModLoader;
using MyTestMod.Config;
using Terraria.ModLoader.Config;
using Microsoft.Xna.Framework.Input;

namespace MyTestMod
{
    public class MyTestMod : Mod
	{
        internal static CrudItems CrudItems = new CrudItems();
        internal static MyConfig Config { get; set; }
        public static MyTestMod Instance { get; private set; }

        private static ModHotKey ForcePickup;
        public static bool ForcePickupDown = false;

        public MyTestMod()
        {
            Properties = new ModProperties() {
                Autoload = true
            };

            Instance = this;
            CrudItems.FillItemNames();
        }

        public override void Load()
        {
            ForcePickup = RegisterHotKey("ForcePickup", Keys.F.ToString());

            base.Load();
        }

        public override void HotKeyPressed(string name)
        {
        }

        internal static bool FullOfItem(Item item, Player player)
        {
            if (ForcePickup.Current) {
                return false;
            }

            int count = 0;

            for (int i = 0; i < player.inventory.Length; i++)
            {
                Item invItem = player.inventory[i];

                if (invItem.IsTheSameAs(item)) {
                    count += invItem.stack;

                    if (count >= Config.GetItemLimit(item)) {
                        return true;
                    }
                }
            }

            return count >= Config.GetItemLimit(item);
        }
    }
}