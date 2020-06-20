using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class PerfectionRay : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Perfection Ray");
            Tooltip.SetDefault("Hasten the ~(REPLICATION)~");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 75;
            item.melee = false;
            item.magic = true;
            item.mana = 10;
            item.width = 60;
            item.height = 60;
            item.useTime = 10;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.knockBack = 8;
            item.value = 1000000;
            item.rare = 5;          
            item.autoReuse = true;
            item.UseSound = SoundID.Item20;
            item.crit = 10;
            item.shoot = mod.ProjectileType("Perfector");
            item.shootSpeed = 25f;




        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShadowbeamStaff);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddIngredient(ItemID.CrystalStorm);
            recipe.AddIngredient(ItemID.CrystalShard, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        

        







    }





    
}