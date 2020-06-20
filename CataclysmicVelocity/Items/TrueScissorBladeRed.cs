using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class TrueScissorBladeRed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Scissor Blade (Red)");
            Tooltip.SetDefault("This blade vibrates with hateful energy...");
        }

        public override void SetDefaults()
        {
            item.damage = 82;
            item.melee = true;
            item.width = 70;
            item.height = 70;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 1;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.crit = 60;
            item.shoot = ProjectileID.DD2ExplosiveTrapT3Explosion;




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

        public void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 480);






        }








    }





    
}