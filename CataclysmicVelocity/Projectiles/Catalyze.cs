using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CataclysmicVelocity.Projectiles
{
	public class Catalyze : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Catalyze"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
            projectile.arrow = false;
            projectile.width = 90;
            projectile.height = 34;
            projectile.aiStyle = 71;
            projectile.friendly = true;
            projectile.penetrate = 3;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = true;
            projectile.light = 2f;





        }

		
	}
}