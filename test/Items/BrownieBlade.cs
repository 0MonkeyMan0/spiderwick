using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace test.Items
{
    public class BrownieBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brownie Blade");
            Tooltip.SetDefault("A dagger that poisons enemies on hit.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.Stabbing;
            item.knockBack = 2;
            item.value = Item.sellPrice(silver: 10);
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.UseSound = SoundID.Item1;
            item.useTurn = true;
            item.shoot = ProjectileID.None;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddIngredient(ItemID.PoisonedKnife, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
