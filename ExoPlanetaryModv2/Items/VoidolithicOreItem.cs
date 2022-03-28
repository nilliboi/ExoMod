using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace ExoPlanetaryModv2.Items
{
    public class VoidolithicOreItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Voidolithic Metal Ore");
            Tooltip.SetDefault("Metal formed over countless Eons, possibly the core of the Old World");
        }
        public override void SetDefaults()
        {
            item.height = 30;
            item.width = 30;
            item.rare = ItemRarityID.Purple;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
            item.maxStack = 9999;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("VoidolithicOre");
           
            


        }

       


    }
}
