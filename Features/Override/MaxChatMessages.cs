using System;
using HarmonyLib;
using Managers;
using MelonLoader;

namespace GGD_Hack.Features.Override
{
	// Token: 0x02000065 RID: 101
	public class MaxChatMessages
	{
		// Token: 0x06000191 RID: 401 RVA: 0x0005FB04 File Offset: 0x0005D104
		public MaxChatMessages()
		{
			uint num = 975314615U;
			do
			{
				base..ctor();
			}
			while (1797340399U < num);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0005FB28 File Offset: 0x0005D128
		// Note: this type is marked as 'beforefieldinit'.
		static MaxChatMessages()
		{
			uint num = 1503740430U;
			string text = "GGDH";
			num ^= 2078236595U;
			string text2 = "Override_MaxChatMessages";
			num /= 1862353709U;
			int num2 = (int)(num + 50U);
			num /= 719653175U;
			MelonPreferences_Entry<int> overrideMaxChatMessages = MelonPreferences.CreateEntry<int>(text, text2, num2, null, null, (num ^ 0U) != 0U, num + 0U != 0U, null);
			num %= 1014437540U;
			MaxChatMessages.OverrideMaxChatMessages = overrideMaxChatMessages;
		}

		// Token: 0x040001A8 RID: 424
		public static MelonPreferences_Entry<int> OverrideMaxChatMessages;

		// Token: 0x020000C0 RID: 192
		[HarmonyPatch(typeof(MainManager), "Awake")]
		private class MainManager_Awake
		{
			// Token: 0x0600026F RID: 623 RVA: 0x00067F7C File Offset: 0x0006557C
			private static void Postfix(MainManager __instance)
			{
				uint num = 1069443841U;
				if (MaxChatMessages.OverrideMaxChatMessages.Value > (int)(num - 1069443841U))
				{
					num = (1851139764U | num);
					int value = MaxChatMessages.OverrideMaxChatMessages.Value;
					num += 541012768U;
					__instance.maxChatMessages = value;
					num += 2676017196U;
				}
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00067FD0 File Offset: 0x000655D0
			public MainManager_Awake()
			{
				uint num = 1612797337U;
				do
				{
					base..ctor();
				}
				while (num - 419051132U == 0U);
			}
		}
	}
}
