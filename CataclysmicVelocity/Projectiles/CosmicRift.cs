
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class CosmicRift : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CosmicRift");
        }

        public override void SetDefaults()
        {
            projectile.arrow = false;
            projectile.width = 30;
            projectile.height = 94;
            projectile.aiStyle = 36;
            projectile.friendly = true;
            projectile.penetrate = 50;
            projectile.maxPenetrate = 50;
            projectile.tileCollide = false;
            projectile.timeLeft = 1800;
            
            




        }
        public override void AI()
        {

            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;

      

            if (Main.rand.Next(1) == 0)
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

                Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
            }
            
        }

        








    }


}




        




    
