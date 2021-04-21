using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace MyTestMod
{
    class LightingEnemies : GlobalNPC
    {
        private static Vector3 lightColor = new Vector3(0.5f);
        private static Vector2 offset = new Vector2(0f, -40f);
        private static float maxDistanceSqr = 1000.0f * 1000.0f;

        public override void PostDraw(NPC npc, SpriteBatch spriteBatch, Color drawColor)
        {
            Vector2 origin = npc.position;
            Vector2 destination = Main.LocalPlayer.position;

            float distSqr = Vector2.DistanceSquared(origin, destination);
            float scalar = MathHelper.Clamp(1.0f - (distSqr / maxDistanceSqr), 0.0f, 1.0f);
            Vector3 light = lightColor * (float)(1.0f - Math.Sqrt(1.0f-scalar*scalar));

            // float zoom = Main.GameZoomTarget;

            if (distSqr <= maxDistanceSqr) {
                Lighting.AddLight(origin, light);
            }

            // var pos = (origin + offset) - Main.screenPosition;

            // Main.spriteBatch.DrawString(Main.fontMouseText, scalar.ToString(), pos, Color.White, 0f, default(Vector2), 1.0f, SpriteEffects.None, 0f);

            base.PostDraw(npc, spriteBatch, drawColor);
        }
    }
}
