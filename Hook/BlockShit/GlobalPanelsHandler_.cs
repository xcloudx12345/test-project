using System;
using Handlers.CommonHandlers.UIHandlers;
using HarmonyLib;
using MelonLoader;
using UnityEngine.Events;

namespace GGD_Hack.Hook.BlockShit
{
	// Token: 0x02000027 RID: 39
	internal class GlobalPanelsHandler_
	{
		// Token: 0x02000086 RID: 134
		[HarmonyPatch(typeof(GlobalPanelsHandler), "OpenPromptPanel", new Type[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(UnityAction),
			typeof(string),
			typeof(UnityAction),
			typeof(bool)
		})]
		private class OpenPromptPanel_
		{
			// Token: 0x060001F2 RID: 498 RVA: 0x00063670 File Offset: 0x00060C70
			private static bool Prefix(UnityAction __3, UnityAction __5)
			{
				uint num = 1885241032U;
				if (190473710U < num)
				{
					goto IL_11;
				}
				for (;;)
				{
					IL_1B:
					num = 661615129U % num;
					if (1932676228U * num == 0U)
					{
						goto IL_11;
					}
					num /= 1808409452U;
					string name = __5.Method.Name;
					num = 1995594692U + num;
					string value = "AttachPublicGameWarning";
					num = 894045072U - num;
					bool flag = name.Contains(value);
					num = (2093893119U & num);
					if (flag)
					{
						goto IL_95;
					}
					bool flag2 = __5.Method.Name.Contains("AttachHangingOutMatureWarning");
					num = 957231999U * num;
					if (flag2)
					{
						break;
					}
					num = 2113538673U << (int)num;
					if (num == 1076647773U)
					{
						goto IL_11;
					}
					if (!__5.Method.Name.Contains("AttachTutorialUnfinishedWarning"))
					{
						goto IL_13A;
					}
					ConsoleColor consoleColor = (int)num + (ConsoleColor)1492123658;
					string text = "已屏蔽教程游戏弹窗";
					num = 1463242542U - num;
					MelonLogger.Msg(consoleColor, text);
					if (num << 18 != 0U)
					{
						goto Block_6;
					}
				}
				num += 2772009368U;
				IL_95:
				ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 1011221958U);
				num = 13914605U - num;
				MelonLogger.Msg(consoleColor2, "已屏蔽游戏警告弹窗");
				num %= 973605584U;
				__5.Invoke();
				num = 923806755U * num;
				return (num ^ 599418163U) != 0U;
				Block_6:
				num <<= 6;
				__3.Invoke();
				return (num ^ 164875136U) != 0U;
				IL_13A:
				return (num ^ 2802843649U) != 0U;
				IL_11:
				num = (447376815U | num);
				goto IL_1B;
			}
		}
	}
}
