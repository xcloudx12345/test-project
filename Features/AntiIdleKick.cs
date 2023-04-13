using System;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using MelonLoader.Preferences;

namespace GGD_Hack.Features
{
	// Token: 0x0200002D RID: 45
	public class AntiIdleKick
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0005227C File Offset: 0x0004F87C
		public AntiIdleKick()
		{
			uint num = 1194936938U;
			if (num / 67529238U != 0U)
			{
				base..ctor();
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000522A4 File Offset: 0x0004F8A4
		// Note: this type is marked as 'beforefieldinit'.
		static AntiIdleKick()
		{
			string text = "GGDH";
			uint num = 1733783060U;
			string text2 = "Enable_AntiIdleKick";
			bool flag = num - 1733783059U != 0U;
			string text3 = null;
			num = 1591559113U / num;
			string text4 = null;
			bool flag2 = (num ^ 0U) != 0U;
			bool flag3 = (num ^ 0U) != 0U;
			num ^= 1424912285U;
			ValueValidator valueValidator = null;
			num ^= 1778671405U;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num = 1175995938U * num;
			AntiIdleKick.Enabled = enabled;
		}

		// Token: 0x04000137 RID: 311
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x02000088 RID: 136
		[HarmonyPatch(typeof(LobbySceneHandler), "Start")]
		private class LobbySceneHandle_Start
		{
			// Token: 0x060001F6 RID: 502 RVA: 0x0006388C File Offset: 0x00060E8C
			private static void Postfix(LobbySceneHandler __instance)
			{
				uint num;
				do
				{
					MelonPreferences_Entry<bool> enabled = AntiIdleKick.Enabled;
					num = 1440381353U;
					bool value = enabled.Value;
					num = 1347517863U / num;
					if (!value)
					{
						return;
					}
					num <<= 5;
				}
				while (308506614 << (int)num == 0);
				float num2;
				do
				{
					num2 = 1E+09f;
					ConsoleColor consoleColor = (int)num + ConsoleColor.Green;
					num &= 125846337U;
					string str = "已修改房间内最大挂机允许时长为：";
					num |= 601052119U;
					string text = str + num2.ToString();
					num = 1477137421U / num;
					MelonLogger.Msg(consoleColor, text);
					num <<= 6;
				}
				while ((376382955U & num) == 0U);
				num = 485911691U - num;
				float inactiveTimeThreshold = num2;
				num = (997868941U & num);
				__instance.inactiveTimeThreshold = inactiveTimeThreshold;
				num /= 560662056U;
				num = (524627820U & num);
				float privateInactiveTimeThreshold = num2;
				num = (1875317662U ^ num);
				__instance.privateInactiveTimeThreshold = privateInactiveTimeThreshold;
				num ^= 1875317662U;
			}
		}
	}
}
