using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class CursedKnife : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CursedKnife");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 15;
            projectile.height = 15;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.maxPenetrate = 2;
            projectile.tileCollide = true;
            projectile.timeLeft = 60;



        }

        public override void AI()
        {

            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;

            projectile.ai[0] += 1f;
            if (projectile.ai[0] > 50f)
            {

                projectile.alpha += 25;
                if (projectile.alpha > 255)
                {
                    projectile.alpha = 255;
                }











            }


            Lighting.AddLight(projectile.Center, 0.0f, 1f, 0.0f);

        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.CursedInferno, 120);


           
        }


    }

}


