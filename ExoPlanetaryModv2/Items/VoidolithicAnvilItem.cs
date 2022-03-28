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

namespace ExoPlanetaryModv2.Items
{
    public class VoidolithicAnvilItem : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Voidolithic Anvil");
            Tooltip.SetDefault("Allows the forging of Voidolithic Tools.");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Purple;
            item.maxStack = 9999;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTime = 10;
            item.useAnimation = 15;
        
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("VoidolithicAnvil");
            item.value = 0;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula, 100);
            recipe.AddIngredient(ItemID.FragmentVortex, 100);
            recipe.AddIngredient(ItemID.FragmentSolar, 100);
            recipe.AddIngredient(ItemID.FragmentStardust, 100);
            recipe.AddIngredient(ItemID.LunarOre, 999);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
