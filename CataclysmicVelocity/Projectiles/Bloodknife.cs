using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class Bloodknife : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloodknife");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.maxPenetrate = 10;
            projectile.tileCollide = true;
            projectile.timeLeft = 90;
            projectile.aiStyle = 0;
            


        }

        public override void AI()
        {

            float velXMult = 0.98f;
            projectile.velocity *= velXMult;

            projectile.rotation += 1f * (float)projectile.direction;





            Lighting.AddLight(projectile.Center, 1f, 0f, 0.0f);

            int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 25, 0f, 0f, 200, default(Color), 0.8f);



        }


            

        

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {

            target.AddBuff(BuffID.Ichor, 720);
            float projectilespeedX = 0;
            float projectilespeedY = 0;
            float projectileknockBack = 4f;
            int projectiledamage = 20;
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, ProjectileID.SolarWhipSwordExplosion, projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
            }


        }


    }

}


