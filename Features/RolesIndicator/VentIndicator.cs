using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x02000061 RID: 97
	public class VentIndicator
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0005EE1C File Offset: 0x0005C41C
		public static void IndicateUsedVent(PlayerController playerController)
		{
			for (;;)
			{
				bool flag = Utils.IsChineseSystem();
				uint num = 313657373U;
				string text;
				if (!flag)
				{
					if (num < 1643972337U)
					{
						goto IL_1B;
					}
					break;
				}
				else
				{
					num <<= 5;
					text = "[用过管道] ";
					num ^= 1156778941U;
				}
				IL_3A:
				num <<= 3;
				string text2 = text;
				num *= 1056443062U;
				if (num <= 1875933575U)
				{
					num = (640828337U ^ num);
					string nickname = playerController.nickname;
					string value = text2;
					num = 1321275050U << (int)num;
					bool flag2 = nickname.Contains(value);
					num = 839403472U / num;
					if (!flag2)
					{
						num = (420355390U ^ num);
						string format = "{0}{1}";
						num ^= 1617890446U;
						object arg = text2;
						num = (445803929U ^ num);
						num %= 1125086234U;
						object nickname2 = playerController.nickname;
						num = 652439452U / num;
						string nickname3 = string.Format(format, arg, nickname2);
						num >>= 2;
						playerController.nickname = nickname3;
						num += 0U;
					}
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 10U);
					string text3 = "已标记玩家{0}为使用过管道";
					num = 711213456U + num;
					object[] array = new object[num + 3583753841U];
					num <<= 22;
					num /= 1564607395U;
					int num2 = (int)(num ^ 1U);
					num = (1249538868U & num);
					array[num2] = playerController.nickname;
					MelonLogger.Msg(consoleColor, text3, array);
					if ((1737587283U ^ num) != 0U)
					{
						break;
					}
					continue;
				}
				IL_1B:
				text = "[Vented] ";
				goto IL_3A;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0005EF58 File Offset: 0x0005C558
		private static void HandleVent(string userId)
		{
			uint num = 467283157U;
			if (num % 93455752U != 0U)
			{
				do
				{
					Dictionary<string, PlayerController> playersList = PlayerController.playersList;
					num &= 1256653248U;
					num ^= 586875126U;
					VentIndicator.IndicateUsedVent(playersList[userId]);
				}
				while (1327331390U - num == 0U);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0005EFA4 File Offset: 0x0005C5A4
		public VentIndicator()
		{
			uint num = 657137662U;
			num = 2050952246U % num;
			base..ctor();
		}

		// Token: 0x020000BB RID: 187
		[HarmonyPatch(typeof(InGameEvents), "Vent", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class OnForceExitVent
		{
			// Token: 0x06000265 RID: 613 RVA: 0x00067CE4 File Offset: 0x000652E4
			private static void Postfix(string userId, string ventId)
			{
				uint num = 148374424U;
				if (625879370U != num)
				{
					do
					{
						num *= 1191135169U;
						VentIndicator.HandleVent(userId);
					}
					while (num == 1382289346U);
				}
			}

			// Token: 0x06000266 RID: 614 RVA: 0x00067D1C File Offset: 0x0006531C
			public OnForceExitVent()
			{
				uint num = 1426947398U;
				do
				{
					base..ctor();
				}
				while (283326748U >= num);
			}
		}
	}
}
