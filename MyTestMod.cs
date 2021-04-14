using Terraria;
using Terraria.ModLoader;
using MyTestMod.Config;
using Terraria.ModLoader.Config;

namespace MyTestMod
{


    public class GemFinderGlobalTile : GlobalTile
    {
        public override void SetDefaults()
        {
            Main.tileShine2[Terraria.ID.TileID.SnowBlock] = true;
            Main.tileShine[Terraria.ID.TileID.SnowBlock] = 10;
        }
        public override void NearbyEffects(int i, int j, int type, bool closer) {
            switch(type)
            {
                case Terraria.ID.TileID.SnowBlock:
                    Lighting.AddLight(i, j, 200, 200, 200);
                    Dust.NewDust(new Microsoft.Xna.Framework.Vector2(i, j), 1, 1, Terraria.ID.DustID.SpelunkerGlowstickSparkle);
                    break;
                default:
                    base.NearbyEffects(i, j, type, closer);
                    break;
            }
        }
    }

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

            Main.dust[0].noLight = false;

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