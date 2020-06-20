using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace CataclysmicVelocity.Projectiles
{


    public class LightRay : ModProjectile
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LightRay");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 15;
            projectile.height = 15;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 4;
            projectile.maxPenetrate = 4;
            projectile.tileCollide = true;
            projectile.timeLeft = 600;




        }




        public override void AI()
        {



            Lighting.AddLight(projectile.Center, Main.rand.NextFloat(0f, 1f), Main.rand.NextFloat(0f, 1f), Main.rand.NextFloat(0f, 1f));

           






             projectile.rotation = projectile.velocity.ToRotation();
             float velXMult = 1.15f;
             projectile.velocity *= velXMult;






            
        }

        public override void Kill(int timeLeft)
        {

            Player player = Main.player[projectile.owner];
            {
                float projectilespeedX = 0f;
                float projectilespeedY = 20f;
                float projectileknockBack = 4f;
                int projectiledamage = 30;
                {
                    Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, ProjectileID.CrystalPulse, projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
                }

            }

        }
    }
}