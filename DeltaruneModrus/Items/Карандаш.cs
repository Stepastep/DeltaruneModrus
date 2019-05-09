 using Terraria.ID;

 using Terraria.ModLoader;


 namespace DeltaruneModrus.Items

 {
	
   public class Карандаш : ModItem
 
   {
		
     public override void SetDefaults()

     {
			
      item.damage = 10;
			
      item.melee = true;
			
      item.width = 40;
			
      item.height = 40;		
      item.useTime = 30;
			
      item.useAnimation = 30;
			
      item.useStyle = 1;
			
      item.knockBack = 3;
			
      item.value = 1000;
			
      item.rare = 2;
			
      item.UseSound = SoundID.Item1;
			
      item.autoReuse = true;
		
     }

		
 public override void AddRecipes()
		
     {
			
     ModRecipe recipe = new ModRecipe(mod);
			
     recipe.AddIngredient(ItemID.CopperShortsword, 1);
			
     recipe.AddTile(TileID.WorkBenches);
			
     recipe.SetResult(this,1);
			
     recipe.AddRecipe();
		
     }
	
   }

 }
