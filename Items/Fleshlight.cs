using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items
{
    public class Fleshlight : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fleshlight");
            Tooltip.SetDefault("Cause what woman would want you!");

        }


        public override bool CanUseItem(Player player)
        {               
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WhoopieCushion, 1);
            recipe.AddIngredient(ItemID.EmptyBucket, 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
