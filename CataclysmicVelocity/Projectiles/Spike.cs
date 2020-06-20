using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;


namespace CataclysmicVelocity.Projectiles
{
    public class Spike : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spike");
        }

        public override void SetDefaults()
        {
            projectile.arrow = true;
            projectile.width = 15;
            projectile.height = 15;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.penetrate = 2;
            projectile.maxPenetrate = 2;         
            projectile.tileCollide = true;
   


        }

        public override void AI()
        {
            projectile.rotation += 1f * (float)projectile.direction;
        }




    }
}