using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items
{
	public class MulgarathsEyepatch : ModItem
    {
            public static readonly int AdditiveDamageBonus = 25;
            public static readonly int MultiplicativeDamageBonus = 12;
            public static readonly int BaseDamageBonus = 4;
            public static readonly int FlatDamageBonus = 5;
            public static readonly int MeleeCritBonus = 10;
            public static readonly int RangedAttackSpeedBonus = 15;
		    public static readonly int MagicArmorPenetration = 5;
		    public static readonly int ExampleKnockback = 100;
		    public static readonly int AdditiveCritDamageBonus = 20;

    		public override void SetDefaults() {
		      	Item.width = 17;
			    Item.height = 26;
			    Item.accessory = true;

                }

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.GetDamage(DamageClass.Generic) += 1f; // Increase ALL player damage by 100%
			player.endurance = 1f - (0.1f * (1f - player.endurance));  // The percentage of damage reduction
		}

			public override void AddRecipes() {
				CreateRecipe()
				.AddIngredient(ItemID.Wood, 10)
				.Register();
        }
        }
    }   