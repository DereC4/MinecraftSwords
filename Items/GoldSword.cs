using Terraria.ID;
using Terraria.ModLoader;

namespace MinecraftSwords.Items
{
	public class GoldSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Golden Sword");
			// By default, capitalization in classnames will add
			// spaces to the display name. You can customize the
			// display name here by uncommenting this line.
			Tooltip.SetDefault("We didn't realise we were making memories, we just knew we were having fun...");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Excalibur, 1);
			recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}