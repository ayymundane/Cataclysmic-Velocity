using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class Perfector : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Perfector");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 120;
            projectile.height = 24;
            projectile.aiStyle = 24;
            projectile.friendly = true;
            projectile.penetrate = 6;
            projectile.maxPenetrate = 6;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = false;
            projectile.light = 1f;
          


        }




        public override void AI()
        {

            
            if (Main.rand.Next(1) == 0)
            {
                int choice = Main.rand.Next(3);
                if (choice == 58)
                {
                    choice = 58;
                }
                else if (choice == 58)
                {
                    choice = 27;
                }
                else
                {
                    choice = 27;
                }

                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 1.5f);

                projectile.rotation = projectile.velocity.ToRotation();



            }
           

        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player player = Main.player[projectile.owner];
            float projectilespeedX = Main.rand.NextFloat(.0f, .10f) + Main.rand.NextFloat(-8f, 8f);
            float projectilespeedY = Main.rand.NextFloat(.0f, .10f) + Main.rand.NextFloat(-8f, 8f);
            float projectileknockBack = 4f;
            int projectiledamage = 40;
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, ProjectileID.ShadowBeamFriendly, projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
            }






        }







    }
}