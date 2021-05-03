using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items
{
	public class CumSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cum Sword");
			Tooltip.SetDefault("Forged Out of Pure Cum, the Cum Sword is unbreakable! You Must Be A MEGAFAGGOT to Weild");
		}

		public override void SetDefaults() 
		{
			item.damage = 1000000;
			item.melee = true;
			item.width = 100;
			item.height = 50;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}