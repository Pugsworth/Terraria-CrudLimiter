using System;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.UI;

namespace MyTestMod.Config
{
    internal class MyConfig : ModConfig {
        public override ConfigScope Mode => ConfigScope.ClientSide;
        public override void OnLoaded() => MyTestMod.Config = this;

        [Label("Items and stack sizes to limit")]
        public List<ItemLimit> ItemSets = CrudItems.Crud;

        [DefaultValue(true)]
        [Label("Use default stack sizes for limits")]
        public bool UseStackSize { get; set; }

        public MyConfig()
        {
        }


        internal int GetItemLimit(Item item)
        {
            if (UseStackSize) {
                return item.maxStack;
            }

            return 200; // TODO: get value from config
        }
    }
}
