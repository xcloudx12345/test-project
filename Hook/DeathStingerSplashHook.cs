using System;
using HarmonyLib;

namespace GGD_Hack.Hook
{
	// Token: 0x02000021 RID: 33
	public class DeathStingerSplashHook
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00051B5C File Offset: 0x0004F15C
		public DeathStingerSplashHook()
		{
			uint num;
			do
			{
				num = 683485612U;
				base..ctor();
			}
			while (987125799U <= num);
		}

		// Token: 0x02000082 RID: 130
		[HarmonyPatch(typeof(DeathStingerSplash), "StartDeathStinger")]
		private class StartDeathStingerHook
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x00063310 File Offset: 0x00060910
			private static bool Prefix(ref DeathStingerSplash __instance)
			{
				__instance.CloseThisShitSequence();
				return false;
			}
		}
	}
}
