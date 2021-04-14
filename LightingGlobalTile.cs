using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MyModTest.Groups;

namespace MyModTest.Lighting
{
    internal struct LightColor
    {
        float R = 0.0f;
        float G = 0.0f;
        float B = 0.0f;

        float Value = 0.0f;

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
        public LightColor OreGlowStrength = new LightColor(0.5f);
        public LightColor EnvironmentGlowStrength = new LightColor(0.1f);
        public LightColor GemGlowStrength = new LightColor(0.5f);

        public override void NearbyEffects(int i, int j, int type, bool closer)
        {
            base.NerbyEffects(i, j, type, closer);
        }

        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            if (Tiles.Ore.Contains(type)) {
                r = g = b = OreGlowStrength.Value;
            } else if (Tiles.Environment.Contains(type)) {
                r = g = b = EnvironmentGlowStrength.Value
            } else if (Tiles.Gems.Contains(type)) {
                r = g = b = GemGlowStrength.Value;
            }

            base.ModifyLight(i, j, type, r, g, b);
        }
    }
}