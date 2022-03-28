using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;
using ExoPlanetaryModv2.Tiles;

namespace ExoPlanetaryModv2.Items
{
    public class VoidolithicPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Voidolithic Pickaxe");
            Tooltip.SetDefault("pickaxe go brrrr");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Purple;
            item.maxStack = 1;
            item.pick = 300;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 3;
            item.useAnimation = 3;
            item.autoReuse = true;
            item.useTurn = true;
            

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<VoidolithicBarItem>(), 10);
            recipe.AddIngredient(ItemID.LunarOre, 100);
            recipe.AddTile(TileType<VoidolithicAnvil>());
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
