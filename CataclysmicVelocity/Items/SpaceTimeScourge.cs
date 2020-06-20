using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class SpaceTimeScourge : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Space-Time Scourge");
            Tooltip.SetDefault("TEAR IT ~(DOWN)~");
        }

        public override void SetDefaults()
        {
            item.damage = 180;
            item.width = 70;      
            item.height = 70;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 4f;
            item.value = 20000000;
            item.rare = 10;
            item.useTurn = true;
            item.UseSound = SoundID.Item1;
            item.crit = 20;
            item.noUseGraphic = true;
            item.autoReuse = true;
            item.thrown = true;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("SpaceScourge1");
            item.shootSpeed = 30f;



        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ScourgeoftheCorruptor);
            recipe.AddIngredient(ItemID.InfluxWaver);
            recipe.AddIngredient(ItemID.Ectoplasm, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

      







    }
}