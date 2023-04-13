using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using MelonLoader.Preferences;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200002B RID: 43
	[RegisterTypeInIl2Cpp]
	public class ForceEnableRoleRevealText : MonoBehaviour
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00051E9C File Offset: 0x0004F49C
		public ForceEnableRoleRevealText(IntPtr ptr)
		{
			uint num = 706420979U;
			for (;;)
			{
				IL_06:
				num = 676868365U + num;
				base..ctor(ptr);
				if (1170224328U % num != 0U)
				{
					IngameSettings.IngameSettingsEntry ingameSettingsEntry;
					do
					{
						num = 381120009U / num;
						ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
						num |= 1653164361U;
						if (num / 1477137214U == 0U)
						{
							goto IL_06;
						}
						MelonPreferences_Entry enabled = ForceEnableRoleRevealText.Enabled;
						num += 1486708300U;
						ingameSettingsEntry.entry = enabled;
						num = 834802764U * num;
						string name_cn = "显示角色身份文字在姓名下方";
						num = 1518284525U - num;
						ingameSettingsEntry.name_cn = name_cn;
					}
					while ((num ^ 751859023U) == 0U);
					string name_eng = "Show role text below name";
					num = (1614421077U | num);
					ingameSettingsEntry.name_eng = name_eng;
					IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
					num = 1319990509U % num;
					IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
					if (813499000U / num == 0U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00051F58 File Offset: 0x0004F558
		public ForceEnableRoleRevealText()
		{
			uint num = 83890001U;
			num += 2121010337U;
			IntPtr intPtr = ClassInjector.DerivedConstructorPointer<ForceEnableRoleRevealText>();
			num <<= 29;
			base..ctor(intPtr);
			num = 1717307118U + num;
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00051F94 File Offset: 0x0004F594
		public static void Init()
		{
			uint num;
			GameObject gameObject;
			do
			{
				string text = "ML_Manager";
				num = 1780767499U;
				gameObject = GameObject.Find(text);
				num = 689721051U * num;
				if (gameObject == null)
				{
					num |= 1320116429U;
					if (num == 647259638U)
					{
						continue;
					}
					gameObject = new GameObject("ML_Manager");
					if (num % 591537410U == 0U)
					{
						continue;
					}
					Object @object = gameObject;
					num &= 206399299U;
					Object.DontDestroyOnLoad(@object);
					num += 2365446184U;
				}
				num /= 1196110011U;
			}
			while (num / 2037405025U != 0U);
			Object component = gameObject.GetComponent<ForceEnableRoleRevealText>();
			num = 762665970U / num;
			Object object2 = null;
			num %= 495923911U;
			if (component == object2)
			{
				ForceEnableRoleRevealText.Instance = gameObject.AddComponent<ForceEnableRoleRevealText>();
				num ^= 0U;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00052050 File Offset: 0x0004F650
		// Note: this type is marked as 'beforefieldinit'.
		static ForceEnableRoleRevealText()
		{
			uint num = 872698772U;
			do
			{
				string text = "GGDH";
				string text2 = "Enable_ForceEnableRoleRevealText";
				bool flag = num - 872698771U != 0U;
				num = 1473137661U + num;
				string text3 = null;
				string text4 = null;
				bool flag2 = (num ^ 2345836433U) != 0U;
				bool flag3 = num + 1949130863U != 0U;
				ValueValidator valueValidator = null;
				num += 1873678310U;
				ForceEnableRoleRevealText.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			}
			while (93002851 << (int)num == 0);
		}

		// Token: 0x04000133 RID: 307
		public static ForceEnableRoleRevealText Instance;

		// Token: 0x04000134 RID: 308
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x02000087 RID: 135
		[HarmonyPatch(typeof(PlayerController), "Update")]
		private class PlayerController_Update
		{
			// Token: 0x060001F4 RID: 500 RVA: 0x000637D4 File Offset: 0x00060DD4
			private static void Postfix(PlayerController __instance)
			{
				bool isLocal = __instance.isLocal;
				uint num = 1723563549U;
				if (!isLocal)
				{
					do
					{
						num = 2052215468U / num;
						if (num >= 1361127070U)
						{
							return;
						}
						bool gameStarted = LobbySceneHandler.Instance.gameStarted;
						num ^= 260926374U;
						if (gameStarted)
						{
							goto IL_49;
						}
					}
					while ((num & 589366753U) == 0U);
					return;
					IL_49:
					num = 599142519U << (int)num;
					if (num > 1044206833U)
					{
						Behaviour playerNameRoleText = __instance.playerNameRoleText;
						bool enabled = (num ^ 3675798401U) != 0U;
						num = (888432828U ^ num);
						playerNameRoleText.enabled = enabled;
						if (446638403 << (int)num != 0)
						{
							return;
						}
					}
				}
			}
		}
	}
}
