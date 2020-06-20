using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class Static : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Static");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 90;
            projectile.height = 50;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.maxPenetrate = 50;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = true;
            projectile.light = 1f;
            projectile.tileCollide = false;


        }




        public override void AI()
        {

            float velXMult = 1.15f;
            projectile.velocity *= velXMult;
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
            {
                float projectilespeedX = 0f;
                float projectilespeedY = 0f;
                float projectileknockBack = 4f;
                int projectiledamage = 90000;
                {
                    Projectile.NewProjectile(player.position.X, player.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("ShadeScythe"), projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
                }
            }

        }
        




         
    }
}