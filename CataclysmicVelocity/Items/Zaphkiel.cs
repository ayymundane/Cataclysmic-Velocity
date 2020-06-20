using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class Zaphkiel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zaphkiel");
            Tooltip.SetDefault("THIS REALM CORRESPONDS TO ~(YOUR)~ ACTIONS");
          
        }

        public override void SetDefaults()
        {
            item.damage = 85;
            item.melee = false;
            item.ranged = true;
            item.width = 60;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 14;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 8;          
            item.autoReuse = true;
            item.UseSound = SoundID.Item11;         
            item.shoot = 20;
            item.shootSpeed = 40f;
            item.useAmmo = AmmoID.Bullet;






        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet) 
            {
                type = ProjectileID.CursedBullet;
            }
            return true; 

        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);         
            recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddIngredient(ItemID.Gatligator);
            recipe.AddIngredient(ItemID.Megashark);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }










    }





    
}
 