using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;


namespace CataclysmicVelocity.Items
{
    public class BloodstainedKnives : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloodstained Knives");
            Tooltip.SetDefault("This blade is stained with the blood of gods...");
        }

        public override void SetDefaults()
        {
            item.damage = 87;
            item.width = 52;      
            item.height = 58;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 100000;
            item.rare = 7;
            item.useTurn = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.crit = 34;
            item.noUseGraphic = true;
            item.autoReuse = true;
            item.thrown = true;
            item.noMelee = true;
            item.shootSpeed = 30f;
            item.shoot = mod.ProjectileType("Bloodknife");





        }




        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BrokenHeroSword);
            recipe.AddIngredient(ItemID.Obsidian, 50);
            recipe.AddIngredient(ItemID.Ichor, 25);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




       




    }
}