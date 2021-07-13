using Terraria.ID;
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


        public override void SetDefaults()
        {
            item.maxStack = 99;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PurpleMucos, 10);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }
}
