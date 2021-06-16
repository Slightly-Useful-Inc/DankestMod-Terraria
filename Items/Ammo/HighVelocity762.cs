﻿using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items.Ammo
{
    class HighVelocity762 : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("7.62x39mm Round");
            Tooltip.SetDefault("The Finest Soviet Calibar");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.Green;
            item.shoot = ProjectileID.BulletHighVelocity;
            item.shootSpeed = 16f;
            item.ammo = 69762;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 10);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 100);
            recipe.AddRecipe();
        }
    }
}
