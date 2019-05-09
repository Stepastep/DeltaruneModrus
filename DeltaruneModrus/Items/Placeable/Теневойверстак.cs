using Terraria.ID;
using Terraria.ModLoader;

namespace DeltaruneModrus.Items.Placeable
{
	public class Теневойверстак : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Венец теневых предметов.");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("Теневойверстак");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}