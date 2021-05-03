﻿using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items
{
    public class Cum : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cum");
            Tooltip.SetDefault("Just Cum");
            
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmptyBucket, 1);
            recipe.AddIngredient(ItemID.PurpleMucos, 10);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
