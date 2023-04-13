using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x02000063 RID: 99
	public class InvisibilityIndicator
	{
		// Token: 0x06000189 RID: 393 RVA: 0x0005F1B0 File Offset: 0x0005C7B0
		public static void IndicateAsInvisibility(PlayerController playerController)
		{
			uint num = 113064296U;
			if (1574531995U == num)
			{
				goto IL_2E;
			}
			do
			{
				IL_11:
				bool flag = Utils.IsChineseSystem();
				num <<= 22;
				if (flag)
				{
					goto IL_38;
				}
			}
			while (1721387174U < num);
			IL_2E:
			string text = "[Invisibility] ";
			goto IL_51;
			IL_38:
			if (num >> 21 == 0U)
			{
				goto IL_11;
			}
			text = "[隐形鸭] ";
			num += 0U;
			IL_51:
			num %= 249189469U;
			string text2 = text;
			if (1053238099U - num == 0U)
			{
				goto IL_38;
			}
			if (!playerController.nickname.Contains(text2))
			{
				if (1636508652U <= num)
				{
					goto IL_11;
				}
				num -= 444545109U;
				string format = "{0}{1}";
				num = 2022317751U / num;
				object arg = text2;
				num = (1564698366U | num);
				playerController.nickname = string.Format(format, arg, playerController.nickname);
				num += 2745081556U;
			}
			string userId = playerController.userId;
			num = 2063824672U % num;
			PluginEventsManager.RevealRoleInternalLink(userId, (int)(num ^ 4869664U));
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 4869648U);
			string text3 = "已标记玩家{0}为隐形鸭子";
			num /= 213912423U;
			int num2 = (int)(num ^ 1U);
			num /= 894721921U;
			object[] array = new object[num2];
			num = 2044999910U >> (int)num;
			int num3 = (int)(num - 2044999910U);
			num -= 250051922U;
			object nickname = playerController.nickname;
			num <<= 12;
			array[num3] = nickname;
			num += 1402109922U;
			MelonLogger.Msg(consoleColor, text3, array);
			if (num >> 20 != 0U)
			{
				return;
			}
			goto IL_11;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0005F300 File Offset: 0x0005C900
		private static void HandleTurnInvisible(string userId, bool invisible)
		{
			if (invisible)
			{
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				uint num = 1727884906U;
				PlayerController playerController = playersList[userId];
				num >>= 27;
				InvisibilityIndicator.IndicateAsInvisibility(playerController);
			}
		}

		// Token: 0x020000BD RID: 189
		[HarmonyPatch(typeof(InGameEvents), "Turn_Invisible", new Type[]
		{
			typeof(string),
			typeof(bool)
		})]
		private class OnTurnInvisible
		{
			// Token: 0x06000269 RID: 617 RVA: 0x00067D90 File Offset: 0x00065390
			private static void Postfix(string userId, bool invisible)
			{
				uint num = 415781799U;
				if (num > 151981349U)
				{
					do
					{
						num = 1970078263U % num;
						InvisibilityIndicator.HandleTurnInvisible(userId, invisible);
					}
					while (num / 725760752U != 0U);
				}
			}
		}
	}
}
