using System;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;

namespace GGD_Hack.Hook
{
	// Token: 0x02000024 RID: 36
	public class SpawnedPlayerHandler_
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00051BD4 File Offset: 0x0004F1D4
		public SpawnedPlayerHandler_()
		{
			uint num;
			do
			{
				num = 1167262468U;
				base..ctor();
			}
			while (num + 1259493938U == 0U);
		}

		// Token: 0x02000084 RID: 132
		[HarmonyPatch(typeof(SpawnedPlayerHandler), "UpdatePlayerProperties")]
		private class UpdatePlayerProperties_
		{
			// Token: 0x060001ED RID: 493 RVA: 0x0006337C File Offset: 0x0006097C
			private static bool Prefix(SpawnedPlayerHandler __instance, PlayerProperties __0)
			{
				return true;
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0006338C File Offset: 0x0006098C
			private static bool isEmpty(string str)
			{
				if (str != null)
				{
					uint num = 1364213640U;
					num <<= 14;
					string b = "";
					num = (158082459U ^ num);
					bool flag = str == b;
					num &= 32584886U;
					if (!flag)
					{
						num += 986603069U;
						num <<= 15;
						return str.Contains("empty");
					}
				}
				return true;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x000633EC File Offset: 0x000609EC
			public UpdatePlayerProperties_()
			{
				uint num = 1593786246U;
				do
				{
					num |= 743128505U;
					base..ctor();
				}
				while (1954899411U - num == 0U);
			}
		}
	}
}
