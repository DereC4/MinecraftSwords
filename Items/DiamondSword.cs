using Terraria.ID;
using Terraria.ModLoader;

namespace MinecraftSwords.Items
{
	public class DiamondSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Diamond Sword");
			// By default, capitalization in classnames will add
			// spaces to the display name. You can customize the
			// display name here by uncommenting this line.
			Tooltip.SetDefault("We didn't realise we were making memories, we just knew we were having fun...");
		}

		public override void SetDefaults() 
		{
			item.damage = 250;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
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
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.Diamond, 2);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}