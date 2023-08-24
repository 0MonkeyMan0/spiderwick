using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items
{
		public class GoblinskinSlingshot : ModItem
		{
			public override void SetDefaults() {
			Item.width = 36; // The width of item hitbox
			Item.height = 31; // The height of item hitbox

			Item.autoReuse = true;  // Whether or not you can hold click to automatically use it again.
			Item.damage = 100; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.DamageType = DamageClass.Ranged; // What type of damage does this item affect?
			Item.knockBack = 4f; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.noMelee = true; // So the item's animation doesn't do damage.
			Item.rare = ItemRarityID.Yellow; // The color that the item's name will be in-game.
			Item.shootSpeed = 10f; // The speed of the projectile (measured in pixels per frame.)
			Item.useAnimation = 35; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useTime = 35; // The item's use time in ticks (60 ticks == 1 second.)
			Item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			Item.useStyle = ItemUseStyleID.Shoot; // How you use the item (swinging, holding out, shoot, etc.)
			Item.value = Item.buyPrice(gold: 1); // The value of the weapon in copper coins

			// Custom ammo and shooting homing projectiles
            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 8.5f;
            Item.useAmmo = AmmoID.Bullet;
        }

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        
        
        public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 10)
				.Register();
        }
	}
}