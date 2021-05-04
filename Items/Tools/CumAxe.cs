using Terraria.ID;
using Terraria.ModLoader;

namespace DankestMod.Items.Tools
{
    class CumAxe : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cum Axe");
            Tooltip.SetDefault("Cum cuts though all!");
        }


        public override void SetDefaults()
        {
            item.axe = 50;


        }

    }
}
