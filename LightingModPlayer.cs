using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;

namespace MyTestMod
{
    class LightingModPlayer : ModPlayer
    {
        private Vector3 lightColor = new Vector3(0.2f, 0.18f, 0.2f);

        public override void PreUpdate()
        {
            Lighting.AddLight(player.position, lightColor);
            base.PreUpdate();
        }
    }
}
