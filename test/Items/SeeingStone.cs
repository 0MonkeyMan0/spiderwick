using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace test.Items
{
        public class SeeingStone : ModItem
        {
        public override void SetStaticDefaults() {
			// We want the information benefits of this accessory to work while in the void bag in order to keep
			// it in line with the vanilla accessories; This is the default behavior.
			// If you DON'T want your info accessory to work in the void bag, then add: ItemID.Sets.WorksInVoidBag[Type] = false;
        }

		public override void SetDefaults() {
			// We don't need to add anything particularly unique for the stats of this item; so let's just clone the Radar.
			Item.CloneDefaults(ItemID.Radar);
            Item.defense = 1000;
			Item.lifeRegen = 10;
		}
        


		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 10)
				.Register();
        }
	}
}
