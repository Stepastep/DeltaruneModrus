using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace DeltaruneModrus.NPCs
{
	public class Монетка : ModNPC
	{
		public override void SetStaticDefaults() {
		 Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; 
		}

		public override void SetDefaults() {
			npc.width = 45;
			npc.height = 104;
			npc.aiStyle = -1; 
			npc.damage = 7;
			npc.defense = 2;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 25f;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
		 return spawnInfo.spawnTileY < Main.rockLayer && !Main.dayTime ? 0.5f : 0f;	
		}
		public override void HitEffect(int hitDirection, double damage)  
    {
      for (int i = 0; i < 10; i++)
      {
        int dustType = Main.rand.Next(139, 143);
        int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
        Dust dust = Main.dust[dustIndex];
        dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
        dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
        dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
		
			}
		}
	}
}