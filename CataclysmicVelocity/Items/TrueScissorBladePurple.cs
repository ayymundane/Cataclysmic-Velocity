using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class TrueScissorBladePurple : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Scissor Blade (Purple)");
            Tooltip.SetDefault("This blade vibrates with malificent energy...");
        }

        public override void SetDefaults()
        {
            item.damage = 75;
            item.melee = true;
            item.width = 70;
            item.height = 70;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item12;
            item.crit = 80;
            item.shoot = mod.ProjectileType("ScissorLazer");
            item.shootSpeed = 15f;




        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ScissorBlade");
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        






        








    }





    
}