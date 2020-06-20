using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class RendingScissors : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rending Scissors");
            Tooltip.SetDefault("Light up the sky...");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = false;
            item.width = 80;
            item.height = 80;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 5;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item28;
            item.crit = 100;
            item.shoot = ProjectileID.NebulaBlaze2;
            item.shootSpeed = 20f;




        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TrueScissorBladePurple");
            recipe.AddIngredient(mod, "TrueScissorBladeRed");
            recipe.AddIngredient(ItemID.LifeCrystal, 10);
            recipe.AddIngredient(ItemID.StarWrath);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            float ceilingLimit = target.Y;
            if (ceilingLimit > player.Center.Y - 200f)
            {
                ceilingLimit = player.Center.Y - 200f;
            }
            for (int i = 0; i < 3; i++)
            {
                position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                position.Y -= (100 * i);
                Vector2 heading = target - position;
                if (heading.Y < 0f)
                {
                    heading.Y *= -1f;
                }
                if (heading.Y < 20f)
                {
                    heading.Y = 20f;
                }
                heading.Normalize();
                heading *= new Vector2(speedX, speedY).Length();
                speedX = heading.X;
                speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
            }
            return false;




















        }
    }
}

    
   