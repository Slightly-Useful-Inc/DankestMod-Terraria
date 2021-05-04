using Terraria.ModLoader;
using Terraria.ID;

namespace DankestMod.Items.Weapons
{
    class Ruger1022 : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruger 10/.22");
            Tooltip.SetDefault("Everyone's First Gun");
        }


        public override void SetDefaults()
        {
            item.damage = 50;
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
            item.shoot = ProjectileID.Bullet;
            item.shootSpeed = 1000f;
            item.useAmmo = AmmoID.Bullet;
        }

    }
}
