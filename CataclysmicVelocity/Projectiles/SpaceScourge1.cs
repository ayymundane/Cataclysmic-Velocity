using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class SpaceScourge1 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SpaceScourge1");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 15;
            projectile.height = 15;
            projectile.aiStyle = 0;
            projectile.friendly = true;
            projectile.penetrate = 3;
            projectile.maxPenetrate = 10;
            Lighting.AddLight(projectile.position, 0.25f, 0f, 0.5f);
            projectile.tileCollide = true;
            projectile.light = 1f;       
            drawOriginOffsetY = -16;
            drawOriginOffsetX = 15;


        }




        public override void AI()
        {
           


            if (Main.rand.Next(3) == 0)
            {
                int choice = Main.rand.Next(3);
                if (choice == 15)
                {
                    choice = 15;
                }
                else if (choice == 15)
                {
                    choice = 15;
                }
                else
                {
                    choice = 15;
                }

                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 1.5f);

                projectile.rotation = projectile.velocity.ToRotation();



            }
            projectile.spriteDirection = projectile.direction = (projectile.velocity.X > 0).ToDirectionInt();
            
            projectile.rotation = projectile.velocity.ToRotation() + (projectile.spriteDirection == 1 ? 0f : MathHelper.Pi);
            if (projectile.spriteDirection == 1) 
            {
                drawOffsetX = -58; 
                drawOriginOffsetY = -3;
                drawOriginOffsetX = 33;
            }
            else
            {
               
                
                drawOffsetX = 0; 
                drawOriginOffsetY = -3; 
                drawOriginOffsetX = -33; 
            }

        }
      
        




         
    }
}