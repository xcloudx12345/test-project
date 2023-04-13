using System;
using Handlers.GameHandlers.SpecialBehaviour;
using HarmonyLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000038 RID: 56
	[HarmonyPatch(typeof(MiniMapHandler), "Update")]
	internal class MiniMapHandlerUpdateHook
	{
		// Token: 0x060000DB RID: 219 RVA: 0x00055204 File Offset: 0x00052804
		private static void Postfix(MiniMapHandler __instance)
		{
			uint num = 504309085U;
			do
			{
				Object miniMapHandler = MinimapESP.miniMapHandler;
				Object @object = null;
				num -= 1231701742U;
				if (miniMapHandler == @object)
				{
					if ((num & 1046428004U) != 0U)
					{
						num = 2028882385U << (int)num;
						MinimapESP.miniMapHandler = __instance;
					}
					num |= 172623259U;
					MinimapESP.instantiatedAllPlayers = ((num ^ 787121563U) != 0U);
					num += 2780453076U;
				}
			}
			while (num == 1968850438U);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00055278 File Offset: 0x00052878
		public MiniMapHandlerUpdateHook()
		{
			uint num = 1347097910U;
			if (num <= 2142588791U)
			{
				do
				{
					num += 355673348U;
					base..ctor();
				}
				while ((num & 1242374683U) == 0U);
			}
		}
	}
}
