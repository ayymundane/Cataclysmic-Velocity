using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CataclysmicVelocity.Projectiles
{
	public class ChaosKelvin : ModProjectile
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("ChaosKelvin"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults() 
		{
            projectile.arrow = false;
            projectile.width = 28;
            projectile.height = 28;
            projectile.aiStyle = 81;
            projectile.friendly = true;
            projectile.penetrate = 8;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = false;
            projectile.light = 1f;





        }

		
	}
}