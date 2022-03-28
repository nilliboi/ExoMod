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
    class TestItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("testing item");

        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.rare = ItemRarityID.Purple;
            item.maxStack = 9999;
            item.consumable = true;
            

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<VoidolithicBarItem>(), 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }
}