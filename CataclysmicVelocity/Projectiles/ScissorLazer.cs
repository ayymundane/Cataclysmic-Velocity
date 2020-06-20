using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class ScissorLazer : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ScissorLaser");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 60;
            projectile.height = 2;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 6;
            projectile.maxPenetrate = 6;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = true;
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
        
        




         
    }
}