using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Managers;
using Managers.GameManagers;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x02000062 RID: 98
	public class EngineerIndicator
	{
		// Token: 0x06000186 RID: 390 RVA: 0x0005EFC8 File Offset: 0x0005C5C8
		public static void IndicateAsEngineer(PlayerController playerController)
		{
			string text;
			if (!Utils.IsChineseSystem())
			{
				text = "[Engineer] ";
				goto IL_1F;
			}
			IL_14:
			text = "[工程师] ";
			IL_1F:
			uint num = 73871990U;
			string text2 = text;
			num = (1845918476U & num);
			if (num <= 1185156441U)
			{
				num *= 882521488U;
				string nickname = playerController.nickname;
				num = (104752050U ^ num);
				bool flag = nickname.Contains(text2);
				num -= 1049909956U;
				if (!flag)
				{
					string format = "{0}{1}";
					num = (1063811714U & num);
					object arg = text2;
					num = 1079207593U - num;
					num += 2082955831U;
					playerController.nickname = string.Format(format, arg, playerController.nickname);
					num ^= 2994648560U;
				}
				num = 1720603923U * num;
				string userId = playerController.userId;
				int roleId = (int)(num ^ 238201386U);
				num &= 266226781U;
				PluginEventsManager.RevealRoleInternalLink(userId, roleId);
				num -= 560729695U;
				ConsoleColor consoleColor = (int)num + (ConsoleColor)324666913;
				num /= 1030322538U;
				string text3 = "已标记玩家{0}为工程师";
				num = (976515807U ^ num);
				int num2 = (int)(num ^ 976515805U);
				num = 1633769090U + num;
				object[] array = new object[num2];
				num = (70793465U & num);
				int num3 = (int)(num + 4293916584U);
				num /= 288579865U;
				array[num3] = playerController.nickname;
				MelonLogger.Msg(consoleColor, text3, array);
				return;
			}
			goto IL_14;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0005F0EC File Offset: 0x0005C6EC
		private static void HandleForceExitVent(string userId)
		{
			uint num = 1915552207U;
			MainManager instance = MainManager.Instance;
			num = 1058146116U - num;
			GameManager gameManager = instance.gameManager;
			num <<= 6;
			byte b = gameManager.gameState;
			num >>= 17;
			uint num2 = num ^ 7333U;
			num = 855651008U % num;
			if (b == num2)
			{
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 4426U);
				num = (272837369U | num);
				string text = "由于正在投票，忽略强制退出管道事件";
				num ^= 1204056164U;
				MelonLogger.Msg(consoleColor, text);
				return;
			}
			do
			{
				PlayerController playerController = PlayerController.playersList[userId];
				num += 1804612234U;
				EngineerIndicator.IndicateAsEngineer(playerController);
			}
			while (1708799587U >> (int)num == 0U);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0005F188 File Offset: 0x0005C788
		public EngineerIndicator()
		{
			uint num = 668688965U;
			if (num << 1 != 0U)
			{
				base..ctor();
			}
		}

		// Token: 0x020000BC RID: 188
		[HarmonyPatch(typeof(InGameEvents), "ForceExitVent", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class OnForceExitVent
		{
			// Token: 0x06000267 RID: 615 RVA: 0x00067D40 File Offset: 0x00065340
			private static void Postfix(string userId, string ventId)
			{
				uint num = 1417043555U;
				if (num + 903897628U != 0U)
				{
					do
					{
						EngineerIndicator.HandleForceExitVent(userId);
					}
					while ((31684094U ^ num) == 0U);
				}
			}
		}
	}
}
