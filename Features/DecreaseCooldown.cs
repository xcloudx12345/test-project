using System;
using HarmonyLib;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000047 RID: 71
	[RegisterTypeInIl2Cpp]
	public class DecreaseCooldown : MonoBehaviour
	{
		// Token: 0x0600011F RID: 287 RVA: 0x0005933C File Offset: 0x0005693C
		public DecreaseCooldown(IntPtr ptr)
		{
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			uint num;
			do
			{
				base..ctor(ptr);
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				do
				{
					MelonPreferences_Entry enabled = DecreaseCooldown.Enabled;
					num = 1254240285U;
					ingameSettingsEntry.entry = enabled;
				}
				while (num == 1462259453U);
				string format = "微调CD时间";
				num -= 1082991120U;
				MelonPreferences_Entry<float> decreasedCooldown = DecreaseCooldown.DecreasedCooldown;
				num = 979633694U >> (int)num;
				ingameSettingsEntry.name_cn = string.Format(format, decreasedCooldown.Value);
				num *= 1521378739U;
				string format2 = "Decrease CD(Current value:{0} secs)";
				num -= 193739960U;
				float value = DecreaseCooldown.DecreasedCooldown.Value;
				num |= 374361433U;
				ingameSettingsEntry.name_eng = string.Format(format2, value);
			}
			while (num * 1611164972U == 0U);
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000593F8 File Offset: 0x000569F8
		public DecreaseCooldown() : base(ClassInjector.DerivedConstructorPointer<DecreaseCooldown>())
		{
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00059418 File Offset: 0x00056A18
		public static void Init()
		{
			uint num;
			GameObject gameObject2;
			for (;;)
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				num = 1505233569U;
				gameObject2 = gameObject;
				for (;;)
				{
					if (gameObject2 == null && 1791641217U >= num)
					{
						gameObject2 = new GameObject("ML_Manager");
						if (num == 1569272025U)
						{
							break;
						}
						Object.DontDestroyOnLoad(gameObject2);
						num += 0U;
					}
					if (num + 674190302U != 0U)
					{
						goto Block_3;
					}
				}
			}
			Block_3:
			Object component = gameObject2.GetComponent<DecreaseCooldown>();
			num = 1406566106U << (int)num;
			Object @object = null;
			num = 2015393304U / num;
			if (component == @object)
			{
				DecreaseCooldown instance = gameObject2.AddComponent<DecreaseCooldown>();
				num = 692154181U >> (int)num;
				DecreaseCooldown.Instance = instance;
				num += 3602813115U;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000594C8 File Offset: 0x00056AC8
		// Note: this type is marked as 'beforefieldinit'.
		static DecreaseCooldown()
		{
			uint num = 471866212U;
			if (992547464U != num)
			{
				string text = "GGDH";
				num *= 1691712735U;
				string text2 = "Enable_DecreaseCooldown";
				bool flag = (num ^ 3882896413U) != 0U;
				string text3 = null;
				num = (810109382U & num);
				string text4 = null;
				bool flag2 = num + 3753883644U != 0U;
				num /= 2043576063U;
				bool flag3 = num - 0U != 0U;
				num += 1560939628U;
				DecreaseCooldown.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, null);
			}
			string text5 = "GGDH";
			string text6 = "DecreaseCooldown_DecreasedCooldown";
			float num2 = 3f;
			string text7 = null;
			string text8 = null;
			num = (1875852246U ^ num);
			bool flag4 = (num ^ 851785658U) != 0U;
			bool flag5 = num + 3443181638U != 0U;
			num = 549214055U / num;
			MelonPreferences_Entry<float> decreasedCooldown = MelonPreferences.CreateEntry<float>(text5, text6, num2, text7, text8, flag4, flag5, null);
			num *= 1169894269U;
			DecreaseCooldown.DecreasedCooldown = decreasedCooldown;
		}

		// Token: 0x0400016F RID: 367
		public static DecreaseCooldown Instance;

		// Token: 0x04000170 RID: 368
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000171 RID: 369
		public static MelonPreferences_Entry<float> DecreasedCooldown;

		// Token: 0x020000A0 RID: 160
		[HarmonyPatch(typeof(PlayerButtonController), "RegisterCooldownButton")]
		private class RegisterCooldownButton_
		{
			// Token: 0x0600022B RID: 555 RVA: 0x00065C10 File Offset: 0x00063210
			private static void Prefix(PlayerButtonController __instance, UICooldownButton __result, string __0, KLKBPINDIGM __1, Transform __2, ref float __3, bool __4)
			{
				uint num;
				do
				{
					MelonPreferences_Entry<bool> enabled = DecreaseCooldown.Enabled;
					num = 13898358U;
					bool value = enabled.Value;
					num -= 101022941U;
					if (value)
					{
						goto IL_2A;
					}
				}
				while (num >> 17 == 0U);
				return;
				IL_2A:
				try
				{
					for (;;)
					{
						num %= 985091461U;
						if (12086210U < num)
						{
							num ^= 546986820U;
							num = 1816073168U % num;
							float num2 = __3;
							MelonPreferences_Entry<float> decreasedCooldown = DecreaseCooldown.DecreasedCooldown;
							num /= 1882408875U;
							float value2 = decreasedCooldown.Value;
							num = (2051099924U | num);
							__3 = num2 - value2;
							if ((1048652377U ^ num) != 0U)
							{
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					MelonLogger.Warning(ex.Message);
				}
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00065CCC File Offset: 0x000632CC
			public RegisterCooldownButton_()
			{
				uint num = 1224164005U;
				if (num >> 9 != 0U)
				{
					base..ctor();
				}
			}
		}
	}
}
