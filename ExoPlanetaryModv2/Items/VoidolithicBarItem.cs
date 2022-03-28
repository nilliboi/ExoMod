using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using static Terraria.ModLoader.ModContent;

namespace ExoPlanetaryModv2.Items
{
    public class VoidolithicBarItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Voidolithic Bar");
            Tooltip.SetDefault("a metalic substance able to contain large amounts of power, has ancient engravings");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Purple;
            item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<VoidolithicOreItem>(), 5);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}
