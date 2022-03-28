using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace ExoPlanetaryModv2.Items
{
    class VoidBeaconItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beacon of Void");
            Tooltip.SetDefault("It has ancient text, roughly translated it says 'DO NOT ENTER, parallel universe world bad'.");
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
            item.createTile = mod.TileType("VoidBeacon");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<VoidolithicBarItem>(), 90);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
