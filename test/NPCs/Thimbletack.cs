using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace test.NPCs
{
	public class Thimbletack : ModNPC	
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thimbletack");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Guide];
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 10;
			npc.defense = 15;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			animationType = NPCID.Guide;
		}
		public override bool CanTownNPCSpawn(int numTownNPCs) { // Requirements for the town NPC to spawn.
			for (int k = 0; k < Main.maxPlayers; k++) {
				Player player = Main.player[k];
				if (!player.active) {
					continue;
				}

				// Player has to have either an ExampleItem or an ExampleBlock in order for the NPC to spawn
				if (player.inventory.Any(item => item.type == ModContent.ItemType<BrownieBlade>())) {
					return true;
				}
			}

			return false;
		}
		public override string GetChat()
		{
			return "Some sample text here.";
		}
	}
}