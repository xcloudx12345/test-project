using System;
using HarmonyLib;
using Managers.PlayerManagers;

namespace GGD_Hack.Hook
{
	// Token: 0x02000023 RID: 35
	public class PlayerPropertiesManager_
	{
		// Token: 0x06000099 RID: 153 RVA: 0x00051BB0 File Offset: 0x0004F1B0
		public PlayerPropertiesManager_()
		{
			uint num = 81811497U;
			if (668539498U >= num)
			{
				base..ctor();
			}
		}

		// Token: 0x02000083 RID: 131
		[HarmonyPatch(typeof(PlayerPropertiesManager), "ClearTempUserProperties")]
		private class ClearTempUserProperties_
		{
			// Token: 0x060001EB RID: 491 RVA: 0x00063344 File Offset: 0x00060944
			private static bool Prefix()
			{
				return false;
			}

			// Token: 0x060001EC RID: 492 RVA: 0x00063354 File Offset: 0x00060954
			public ClearTempUserProperties_()
			{
				uint num;
				do
				{
					num = 1104965979U;
					base..ctor();
				}
				while ((176255069U ^ num) == 0U);
			}
		}
	}
}
