
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class Render : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Render");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 30;
            projectile.height = 65;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 50;
            projectile.maxPenetrate = 50;
            projectile.tileCollide = true;
            projectile.timeLeft = 1800;






        }
        public override void AI()
        {


            projectile.rotation = projectile.velocity.ToRotation();


            if (Main.rand.Next(1) == 0)
            {
                int choice = Main.rand.Next(3);
                if (choice == 6)
                {
                    choice = 6;
                }
                else if (choice == 6)
                {
                    choice = 6;
                }
                else
                {
                    choice = 6;
                }

                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
            }

        }
        public void OnTileCollide()
        {
            float projectilespeedX = 0f;
            float projectilespeedY = -2f;
            float projectileknockBack = 4f;
            int projectiledamage = 70;
            {
                Projectile.NewProjectile(projectile.position.X, projectile.position.Y, projectilespeedX, projectilespeedY, ProjectileID.DD2ExplosiveTrapT3Explosion, projectiledamage, projectileknockBack, projectile.owner, 0f, 0f);
            }










        }
      



            
        
    }
}







        




    
