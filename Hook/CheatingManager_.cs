using System;
using HarmonyLib;
using Managers.GameManagers;
using MelonLoader;
using UnityEngine;

namespace GGD_Hack.Hook
{
	// Token: 0x0200001D RID: 29
	public class CheatingManager_
	{
		// Token: 0x02000080 RID: 128
		[HarmonyPatch(typeof(CheatingManager), "OnCheat")]
		public class OnCheat_
		{
			// Token: 0x060001E5 RID: 485 RVA: 0x00063234 File Offset: 0x00060834
			private static bool Prefix(string __0)
			{
				uint num = 1551900507U;
				MelonLogger.Error("已检测到作弊: " + __0);
				num /= 602693913U;
				Application.Quit();
				return num + 4294967294U != 0U;
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0006326C File Offset: 0x0006086C
			public OnCheat_()
			{
				uint num = 1063539449U;
				if ((1044789684U & num) != 0U)
				{
					base..ctor();
				}
			}
		}
	}
}
