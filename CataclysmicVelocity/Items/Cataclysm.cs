using Terraria.ID;
using Terraria.ModLoader;

namespace CataclysmicVelocity.Items
{
	public class Cataclysm : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cataclysm"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The barrier between the light and the dark is so very, very thin...");
		}

		public override void SetDefaults() 
		{
			item.damage = 40000;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 35;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item60;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("ChaosKelvin");
            item.shootSpeed = 25f;
           





		}

    

public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 50);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.StarWrath, 10);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}