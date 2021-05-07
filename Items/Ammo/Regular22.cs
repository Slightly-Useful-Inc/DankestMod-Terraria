using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items.Ammo
{
    class Regular22 : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault(".22 Round");
            Tooltip.SetDefault("The Small One");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1.5f;
            item.value = 10;
            item.rare = ItemRarityID.Green;
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 10f;
            item.ammo = 42069;
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
