using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MyModTest.Groups;
using System.Linq;

namespace MyModTest.Lighting
{
    internal class LightColor
    {
        public float R = 0.0f;
        public float G = 0.0f;
        public float B = 0.0f;

        public float Value = 0.0f;

        public LightColor(float r, float g, float b) {
            R = r; G = g; B = b;
        }

        public LightColor(float value) {
            R = G = B = value;
            Value = value;
        }
    }
    public class LightingGlobalTile : GlobalTile
    {
        internal LightColor OreGlowStrength = new LightColor(0.5f);
        internal LightColor EnvironmentGlowStrength = new LightColor(0.1f);
        internal LightColor GemGlowStrength = new LightColor(0.5f);

        public override void NearbyEffects(int i, int j, int type, bool closer)
        {
            base.NearbyEffects(i, j, type, closer);
        }

        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            if (Tiles.Ore.Contains((ushort)type)) {
                r = g = b = OreGlowStrength.Value;
            } else if (Tiles.Environment.Contains((ushort)type)) {
                r = g = b = EnvironmentGlowStrength.Value;
            } else if (Tiles.Gems.Contains((ushort)type)) {
                r = g = b = GemGlowStrength.Value;
            }

            base.ModifyLight(i, j, type, ref r, ref g, ref b);
        }
    }
}