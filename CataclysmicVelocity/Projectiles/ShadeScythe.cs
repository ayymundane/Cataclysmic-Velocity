
using Terraria;
using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class ShadeScythe : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ShadeScythe");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 54;
            projectile.height = 54;
            projectile.aiStyle = 118;
            projectile.friendly = true;
            projectile.penetrate = 1;
            projectile.maxPenetrate = 1;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.light = 1f;
            projectile.tileCollide = false;



        }
        public override void AI()
        {

            if (Main.rand.Next(5) == 0)
            {
                int choice = Main.rand.Next(3);
                if (choice == 287)
                {
                    choice = 287;
                }
                else if (choice == 287)
                {
                    choice = 287;
                }
                else
                {
                    choice = 287;
                }

                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.CursedInferno, 300);
            Player player = Main.player[projectile.owner];
            float projectilespeedX = Main.rand.NextFloat(.0f, .10f) + Main.rand.NextFloat(-8f, 8f);
            float projectilespeedY = Main.rand.NextFloat(.0f, .10f) + Main.rand.NextFloat(-8f, 8f);
            float projectileknockBack = 4f;
            int projectiledamage = 80000;
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, mod.ProjectileType("CosmicRift"), projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
            }



        }








    }


}




        




    
