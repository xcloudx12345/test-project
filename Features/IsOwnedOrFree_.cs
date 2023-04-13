using System;
using Handlers.LobbyHandlers;
using HarmonyLib;

namespace GGD_Hack.Features
{
	// Token: 0x02000057 RID: 87
	[HarmonyPatch(typeof(PlayerCustomizationPanelHandler), "IsOwnedOrFree")]
	internal class IsOwnedOrFree_
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0005D1AC File Offset: 0x0005A7AC
		private static void Postfix(ref bool __result)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0005D1BC File Offset: 0x0005A7BC
		public IsOwnedOrFree_()
		{
			uint num;
			do
			{
				num = 1387597304U;
				base..ctor();
			}
			while (num > 1848049769U);
		}
	}
}
