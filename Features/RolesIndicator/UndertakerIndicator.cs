using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x02000060 RID: 96
	public class UndertakerIndicator
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0005EC44 File Offset: 0x0005C244
		public static void IndicateAsUndertaker(PlayerController playerController)
		{
			uint num = 2082167140U;
			if (1056986596U >= num)
			{
				goto IL_35;
			}
			bool flag = Utils.IsChineseSystem();
			num ^= 334057199U;
			if (flag)
			{
				goto IL_35;
			}
			num >>= 4;
			IL_2B:
			string text = "[Undertaker] ";
			goto IL_55;
			IL_35:
			num /= 301750369U;
			if (num >= 524839969U)
			{
				goto IL_2B;
			}
			text = "[丧葬者] ";
			num ^= 117383550U;
			IL_55:
			num |= 1341458567U;
			string text2 = text;
			num |= 827925201U;
			string nickname = playerController.nickname;
			num += 633630054U;
			if (!nickname.Contains(text2))
			{
				if ((470253322U ^ num) == 0U)
				{
					goto IL_35;
				}
				num = 1138375877U - num;
				string format = "{0}{1}";
				object arg = text2;
				num = (1840715360U | num);
				object nickname2 = playerController.nickname;
				num = 1647975094U / num;
				playerController.nickname = string.Format(format, arg, nickname2);
				num ^= 2781059429U;
			}
			if (1047424058U >= num)
			{
				goto IL_2B;
			}
			num |= 222194859U;
			string userId = playerController.userId;
			num >>= 1;
			PluginEventsManager.RevealRoleInternalLink(userId, (int)(num + 2835349824U));
			num = 1726546658U << (int)num;
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 1895825418U);
			num ^= 1453276478U;
			string text3 = "已标记玩家{0}为丧葬者";
			num += 1334987943U;
			int num2 = (int)(num + 2295232028U);
			num = 54082362U >> (int)num;
			object[] array = new object[num2];
			num = (870261529U ^ num);
			int num3 = (int)(num ^ 868674240U);
			num = 808587669U << (int)num;
			object nickname3 = playerController.nickname;
			num = 1515613308U << (int)num;
			array[num3] = nickname3;
			MelonLogger.Msg(consoleColor, text3, array);
			if ((221791191U & num) != 0U)
			{
				return;
			}
			goto IL_2B;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0005EDC8 File Offset: 0x0005C3C8
		private static void HandleGrabBody(string undertakerUserId, string bodyUserId)
		{
			uint num = 1258768900U;
			if (1517962643U != num)
			{
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = (1614753985U & num);
				UndertakerIndicator.IndicateAsUndertaker(playersList[undertakerUserId]);
			}
		}

		// Token: 0x020000BA RID: 186
		[HarmonyPatch(typeof(InGameEvents), "Grab_Body", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class OnTurnInvisible
		{
			// Token: 0x06000263 RID: 611 RVA: 0x00067C9C File Offset: 0x0006529C
			private static void Postfix(string undertakerUserId, string bodyUserId)
			{
				UndertakerIndicator.HandleGrabBody(undertakerUserId, bodyUserId);
			}

			// Token: 0x06000264 RID: 612 RVA: 0x00067CB8 File Offset: 0x000652B8
			public OnTurnInvisible()
			{
				uint num = 779035753U;
				if (155284699U != num)
				{
					num /= 1496086472U;
					base..ctor();
				}
			}
		}
	}
}
