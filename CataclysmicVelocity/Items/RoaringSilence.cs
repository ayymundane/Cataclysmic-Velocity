using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CataclysmicVelocity.Items
{
    public class RoaringSilence : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heaven's Vigil");
            Tooltip.SetDefault("Fear is Freedom! (this weapon is so powerful it tears a hole through the space-time continuum)");
        }

        public override void SetDefaults()
        {
            item.damage = 37500;
            item.melee = true;
            item.width = 84;
            item.height = 84;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 35;
            item.value = 10000;
            item.rare = -13;
            item.useTurn = true;
            item.noMelee = true;
            item.UseSound = SoundID.Item109;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("Static");
            item.shootSpeed = 1f;



        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpectreBar, 50);
            recipe.AddIngredient(ItemID.LunarBar, 50);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddIngredient(ItemID.DarkLance, 1);
            recipe.AddIngredient(ItemID.InfluxWaver, 1);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddIngredient(ItemID.NypmhBanner, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        





    }
}