using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items.Weapons
{
    class AK_47 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("AK-47");
            Tooltip.SetDefault("Pure Soviet Ingenuity");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 2;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 50;
            item.value = 100000000;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = ProjectileID.BulletHighVelocity;
            item.shootSpeed = 1000f;
            item.useAmmo = AmmoID.Bullet;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood,10);
            recipe.AddIngredient(ItemID.LunarBar,20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
