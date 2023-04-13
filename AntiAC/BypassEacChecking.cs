using System;
using HarmonyLib;

namespace GGD_Hack.AntiAC
{
	// Token: 0x02000070 RID: 112
	public class BypassEacChecking
	{
		// Token: 0x020000C8 RID: 200
		[HarmonyPatch(typeof(PDLHHFCIKDK), "OIHPNGJIOHE")]
		private class BypassAntiCheatNotInstalled
		{
			// Token: 0x06000287 RID: 647 RVA: 0x00068B38 File Offset: 0x00066138
			private static bool Prefix(ref bool __result)
			{
				uint num = 1286999360U;
				if ((num ^ 205094871U) != 0U)
				{
					bool flag = (num ^ 1286999360U) != 0U;
					num = 943482563U / num;
					__result = flag;
				}
				return num + 0U != 0U;
			}

			// Token: 0x06000288 RID: 648 RVA: 0x00068B70 File Offset: 0x00066170
			public BypassAntiCheatNotInstalled()
			{
				uint num = 996040227U;
				num = 1622238525U % num;
				base..ctor();
			}
		}

		// Token: 0x020000C9 RID: 201
		[HarmonyPatch(typeof(PIHAGKIJDKF), "KHJKDOMNJPM")]
		private class BypassAntiCheatNotRunning
		{
			// Token: 0x06000289 RID: 649 RVA: 0x00068B94 File Offset: 0x00066194
			private static void Postfix(ref ulong __result)
			{
				uint num = 377225993U;
				if (num << 12 != 0U)
				{
					long num2 = (long)(num - 377225994U);
					num = (1409840757U & num);
					ulong num3 = (ulong)num2;
					num |= 2036749494U;
					__result = num3;
				}
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00068BD0 File Offset: 0x000661D0
			public BypassAntiCheatNotRunning()
			{
				uint num = 891703275U;
				if (num < 2123837791U)
				{
					num |= 820329417U;
					base..ctor();
				}
			}
		}

		// Token: 0x020000CA RID: 202
		[HarmonyPatch(typeof(BHJJGFBHDOH), "NLJNEHCEHGM")]
		private class FakeInstance
		{
			// Token: 0x0600028B RID: 651 RVA: 0x00068BFC File Offset: 0x000661FC
			private static bool Prefix(ref PIHAGKIJDKF __result)
			{
				uint num = 398357406U;
				__result = new PIHAGKIJDKF();
				num = 1035822889U % num;
				return num + 4055859219U != 0U;
			}
		}

		// Token: 0x020000CB RID: 203
		[HarmonyPatch(typeof(ShaderCachingDx11), "Update")]
		private class ShaderCachingDx11_Update
		{
			// Token: 0x0600028D RID: 653 RVA: 0x00068C44 File Offset: 0x00066244
			private static bool Prefix()
			{
				return false;
			}

			// Token: 0x0600028E RID: 654 RVA: 0x00068C54 File Offset: 0x00066254
			public ShaderCachingDx11_Update()
			{
				uint num = 304316256U;
				if (num + 1375024111U != 0U)
				{
					do
					{
						num = (1257929490U ^ num);
						base..ctor();
					}
					while (1543245384U + num == 0U);
				}
			}
		}
	}
}
