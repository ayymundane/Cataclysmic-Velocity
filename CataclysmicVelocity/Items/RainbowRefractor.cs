using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class RainbowRefractor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rainbow Refractor");
            Tooltip.SetDefault("Why limit yourself to one hue?");

        }

        public override void SetDefaults()
        {
            item.damage = 250;
            item.melee = false;
            item.magic = true;
            item.mana = 15;
            item.width = 60;
            item.height = 60;
            item.useTime = 4;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 10;
            item.autoReuse = true;
            item.UseSound = SoundID.Item20;
            item.crit = 25;
            item.shoot = mod.ProjectileType("LightRay");
            item.shootSpeed = 15f;




        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserRifle, 2);
            recipe.AddIngredient(ItemID.LaserMachinegun);
            recipe.AddIngredient(ItemID.LunarBar, 25);
            recipe.AddIngredient(ItemID.Ectoplasm, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;
            return true;



        }




        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-27, 0);
        }

        









    }
}




    
