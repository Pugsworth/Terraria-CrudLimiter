using Terraria;
using Terraria.ModLoader;
using MyTestMod.Config;
using Terraria.ModLoader.Config;

namespace MyTestMod
{
    public class MyTestMod : Mod
	{
        internal static CrudItems CrudItems = new CrudItems();
        internal static MyConfig Config { get; set; }
        public static MyTestMod Instance { get; private set; }

        public static ModHotKey ForcePickup;

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
            ForcePickup = RegisterHotKey("ForcePickup", "f");

            base.Load();
        }

        internal static bool FullOfItem(Item item, Player player)
        {
            if (ForcePickup.JustPressed) {
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