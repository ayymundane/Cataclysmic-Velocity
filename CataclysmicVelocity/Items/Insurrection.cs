using Terraria.ID;
using Terraria.ModLoader;

namespace CataclysmicVelocity.Items
{
	public class Insurrection : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Insurrection"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("A rebellion draws near...");
		}

		public override void SetDefaults() 
		{
			item.damage = 14500;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 35;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shoot = ProjectileID.Typhoon;
            item.shootSpeed = 12f;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 50);
            recipe.AddIngredient(ItemID.FragmentVortex, 10);
            recipe.AddIngredient(ItemID.RazorbladeTyphoon, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}