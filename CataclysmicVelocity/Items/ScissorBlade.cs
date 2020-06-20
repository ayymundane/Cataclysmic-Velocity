using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class ScissorBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scissor Blade");
            Tooltip.SetDefault("This blade is filled with vengeance...");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 70;      
            item.height = 70;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 100000;
            item.rare = 3;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.crit = 40;




        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
            recipe.AddIngredient(ItemID.Obsidian, 50);
            recipe.AddIngredient(ItemID.HellstoneBar, 25);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

      







    }
}