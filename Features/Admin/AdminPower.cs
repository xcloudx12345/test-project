using System;
using System.Collections.Generic;
using GGD_Hack.RPC;
using GGD_Hack.Utils;
using Handlers.CommonHandlers.UIHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using MelonLoader;
using Objects.UI;

namespace GGD_Hack.Features.Admin
{
	// Token: 0x02000066 RID: 102
	public class AdminPower
	{
		// Token: 0x06000193 RID: 403 RVA: 0x0005FB88 File Offset: 0x0005D188
		public static void SuperBan(string userId)
		{
			uint num;
			do
			{
				num = 387414039U;
				RpcCommandsSender.SuperBan(userId);
			}
			while (158616965 << (int)num == 0);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0005FBB4 File Offset: 0x0005D1B4
		public AdminPower()
		{
			uint num = 2104631595U;
			if (1668761010U - num != 0U)
			{
				do
				{
					num = 794044907U + num;
					base..ctor();
				}
				while (1728475782U == num);
			}
		}

		// Token: 0x020000C1 RID: 193
		[HarmonyPatch(typeof(PlayerRow), "Update")]
		public class PlayerRow_Update
		{
			// Token: 0x06000271 RID: 625 RVA: 0x00067FF8 File Offset: 0x000655F8
			private static void Postfix(PlayerRow __instance)
			{
				try
				{
					uint num = 1010922968U;
					string userId = __instance.userId;
					string userId2 = LocalPlayer.Instance.Player.userId;
					num = (573001803U ^ num);
					bool flag = userId != userId2;
					num ^= 868164944U;
					if (!flag)
					{
						goto IL_90;
					}
					IL_35:
					List<string> usersRespondedPing = RpcServer.usersRespondedPing;
					num = 2116180172U / num;
					bool flag2 = usersRespondedPing.Contains(__instance.userId);
					num /= 994528881U;
					num += 769196227U;
					if (flag2 && num >> 24 != 0U)
					{
						num >>= 17;
						__instance.adminButton.SetActive((num ^ 5869U) != 0U);
						num += 769190359U;
					}
					IL_90:
					if (878125047U % num == 0U)
					{
						goto IL_35;
					}
				}
				catch (Exception ex)
				{
					uint num = 1613319935U;
					string str = "Exception in void Objects.UI.PlayerRow.Update():";
					Exception ex2 = ex;
					string str2;
					if (ex2 == null)
					{
						num /= 823149695U;
						str2 = null;
					}
					else
					{
						num = (315032434U ^ num);
						str2 = ex2.ToString();
						num += 2366747252U;
					}
					string text = str + str2;
					num += 1886462471U;
					MelonLogger.Warning(text);
				}
			}
		}

		// Token: 0x020000C2 RID: 194
		private class OnSuperBanButtonsClick
		{
			// Token: 0x06000273 RID: 627 RVA: 0x00068124 File Offset: 0x00065724
			private static bool Prefix(AdminPanelHandler __instance)
			{
				string hnodnfgldaj = __instance.HNODNFGLDAJ;
				uint num = 197814222U;
				RpcCommandsSender.SuperBan(hnodnfgldaj);
				GlobalPanelsHandler.Instance.ClosePanels();
				num ^= 722035515U;
				return (num ^ 549651701U) != 0U;
			}

			// Token: 0x020000D2 RID: 210
			[HarmonyPatch(typeof(AdminPanelHandler), "AdminPermanentSuperBan")]
			public static class AdminPermanentSuperBanButtonClicked
			{
				// Token: 0x0600029C RID: 668 RVA: 0x00068F98 File Offset: 0x00066598
				private static bool Prefix(AdminPanelHandler __instance)
				{
					return AdminPower.OnSuperBanButtonsClick.Prefix(__instance);
				}
			}

			// Token: 0x020000D3 RID: 211
			[HarmonyPatch(typeof(AdminPanelHandler), "AdminSuperBan")]
			public static class AdminSuperBanButtonClicked
			{
				// Token: 0x0600029D RID: 669 RVA: 0x00068FAC File Offset: 0x000665AC
				private static bool Prefix(AdminPanelHandler __instance)
				{
					uint num = 996805004U;
					num <<= 20;
					return AdminPower.OnSuperBanButtonsClick.Prefix(__instance);
				}
			}
		}
	}
}
