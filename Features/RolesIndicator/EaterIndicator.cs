using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x0200005E RID: 94
	public class EaterIndicator
	{
		// Token: 0x0600017C RID: 380 RVA: 0x0005E948 File Offset: 0x0005BF48
		public static void IndicateAsEater(string userId)
		{
			PlayerController playerController;
			uint num;
			string text2;
			for (;;)
			{
				playerController = PlayerController.playersList[userId];
				bool flag = Utils.IsChineseSystem();
				num = 1974959571U;
				string text;
				if (!flag)
				{
					num ^= 1055720734U;
					text = "[Ate body] ";
					goto IL_55;
				}
				IL_2E:
				num = 1069621971U << (int)num;
				if ((978586221U ^ num) == 0U)
				{
					continue;
				}
				text = "[吃过尸体] ";
				num += 885160141U;
				IL_55:
				num /= 362491973U;
				text2 = text;
				num = 847461231U * num;
				if ((1052005777U & num) != 0U)
				{
					PlayerController playerController2 = playerController;
					num &= 395461958U;
					bool flag2 = playerController2.nickname.Contains(text2);
					num ^= 657275315U;
					if (flag2)
					{
						goto IL_D4;
					}
					if (num - 1246519126U != 0U)
					{
						break;
					}
					goto IL_2E;
				}
			}
			PlayerController playerController3 = playerController;
			num = 1005465944U >> (int)num;
			string format = "{0}{1}";
			object arg = text2;
			object nickname = playerController.nickname;
			num += 1318746054U;
			playerController3.nickname = string.Format(format, arg, nickname);
			num ^= 2117550538U;
			IL_D4:
			num /= 1191341256U;
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 10U);
			string text3 = "已标记玩家{0}吃过尸体";
			num &= 103555530U;
			int num2 = (int)(num ^ 1U);
			num = (1822522169U | num);
			object[] array = new object[num2];
			num = (1996319299U & num);
			int num3 = (int)(num - 1688300033U);
			num = 620317062U % num;
			PlayerController playerController4 = playerController;
			num /= 1804617632U;
			array[num3] = playerController4.nickname;
			num &= 559088668U;
			MelonLogger.Msg(consoleColor, text3, array);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0005EA90 File Offset: 0x0005C090
		public EaterIndicator()
		{
			uint num = 8933713U;
			if (num <= 1418530483U)
			{
				num = (1869501185U & num);
				base..ctor();
			}
		}

		// Token: 0x020000B8 RID: 184
		[HarmonyPatch(typeof(InGameEvents), "Eat", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class OnTurnInvisible
		{
			// Token: 0x0600025F RID: 607 RVA: 0x00067C2C File Offset: 0x0006522C
			private static void Postfix(string eater, string eated)
			{
				EaterIndicator.IndicateAsEater(eater);
			}
		}
	}
}
