using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class CorrosiveKnives : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Corrosive Knives");
            Tooltip.SetDefault("NULLTYPE 0");
        }

        public override void SetDefaults()
        {
            item.damage = 87;
            item.width = 32;      
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 100000;
            item.rare = 7;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.crit = 34;
            item.noUseGraphic = true;
            item.autoReuse = true;
            item.thrown = true;
            item.noMelee = true;
            item.shootSpeed = 90f;
            item.shoot = mod.ProjectileType("CursedKnife");





        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddIngredient(ItemID.Obsidian, 50);
            recipe.AddIngredient(ItemID.CursedFlame, 25);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 4 + Main.rand.Next(1);
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}




    }
}