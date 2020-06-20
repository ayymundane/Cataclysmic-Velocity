using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class Spikegun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spikegun");
            Tooltip.SetDefault("Warning: Sharp edges, watch your fingers");
          
        }

        public override void SetDefaults()
        {
            item.damage = 36;
            item.melee = false;
            item.ranged = true;
            item.width = 60;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 14;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 8;          
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;         
            item.shoot = mod.ProjectileType("Spike");
            item.shootSpeed = 20f;
            item.useAmmo = AmmoID.Sand;
            item.reuseDelay = 0;
            





        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) 
            {
                type = ProjectileID.CursedBullet;
            }
            return true; 

        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sandgun);         
            recipe.AddIngredient(ItemID.Spike, 99);
            recipe.AddIngredient(ItemID.StoneBlock, 200);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }




        public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .15f;
		}





    }






}
 