using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x0200005F RID: 95
	public class MorphIndicator
	{
		// Token: 0x0600017E RID: 382 RVA: 0x0005EABC File Offset: 0x0005C0BC
		public static void IndicateAsMorphed(string userId)
		{
			for (;;)
			{
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				uint num = 1678643827U;
				num = 1775372913U / num;
				PlayerController playerController = playersList[userId];
				for (;;)
				{
					string text;
					if (!Utils.IsChineseSystem())
					{
						if (1713271589U < num)
						{
							break;
						}
						text = "[Morphed] ";
					}
					else
					{
						if ((num & 1602567596U) != 0U)
						{
							break;
						}
						text = "[变形过] ";
						num ^= 0U;
					}
					string text2 = text;
					if (num >= 2001547876U)
					{
						break;
					}
					PlayerController playerController2 = playerController;
					num = 1936656330U * num;
					string nickname = playerController2.nickname;
					string value = text2;
					num = 555235125U / num;
					bool flag = nickname.Contains(value);
					num = 2032208410U >> (int)num;
					if (!flag)
					{
						if ((1899393338U ^ num) == 0U)
						{
							break;
						}
						PlayerController playerController3 = playerController;
						string format = "{0}{1}";
						num &= 1068382701U;
						object arg = text2;
						PlayerController playerController4 = playerController;
						num = 1654866384U + num;
						object nickname2 = playerController4.nickname;
						num = 1572425717U >> (int)num;
						playerController3.nickname = string.Format(format, arg, nickname2);
						num ^= 2032208455U;
					}
					num |= 1991386359U;
					string userId2 = playerController.userId;
					int roleId = (int)(num + 2152517891U);
					num %= 995850743U;
					PluginEventsManager.RevealRoleInternalLink(userId2, roleId);
					num %= 1219101001U;
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 150747931U);
					string text3 = "已标记玩家{0}变形过";
					num += 461263470U;
					object[] array = new object[num ^ 612011390U];
					num *= 1962550497U;
					int num2 = (int)(num + 4200449889U);
					num >>= 0;
					PlayerController playerController5 = playerController;
					num -= 1652890882U;
					object nickname3 = playerController5.nickname;
					num = 1362954395U % num;
					array[num2] = nickname3;
					num <<= 30;
					MelonLogger.Msg(consoleColor, text3, array);
					if (num != 2061844649U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x020000B9 RID: 185
		[HarmonyPatch(typeof(InGameEvents), "Morph", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class onMorph
		{
			// Token: 0x06000261 RID: 609 RVA: 0x00067C64 File Offset: 0x00065264
			private static void Postfix(string from, string to)
			{
				MorphIndicator.IndicateAsMorphed(from);
			}

			// Token: 0x06000262 RID: 610 RVA: 0x00067C78 File Offset: 0x00065278
			public onMorph()
			{
				uint num = 1171094544U;
				do
				{
					base..ctor();
				}
				while (1847878384U == num);
			}
		}
	}
}
