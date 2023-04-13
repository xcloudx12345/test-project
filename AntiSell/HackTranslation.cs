using System;
using System.Collections.Generic;
using Gaggle.Translation;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;

namespace GGD_Hack.AntiSell
{
	// Token: 0x0200006C RID: 108
	[HarmonyPatch(typeof(TranslationManager), "GetTranslation", new Type[]
	{
		typeof(string)
	})]
	public class HackTranslation
	{
		// Token: 0x060001AF RID: 431 RVA: 0x000612B4 File Offset: 0x0005E8B4
		private static void Postfix(TranslationManager __instance, string __result, string __0)
		{
			try
			{
				uint num = 1813991772U;
				if ((391476583U & num) == 0U)
				{
					goto IL_54;
				}
				do
				{
					IL_12:
					Dictionary<string, string> dictionary = HackTranslation.hackedStrings;
					num = 1143161946U + num;
					num = (1178671616U & num);
					bool flag = dictionary.ContainsKey(__0);
					num *= 1049571591U;
					if (!flag)
					{
						goto IL_126;
					}
					num = (1511411415U ^ num);
				}
				while (62213974 << (int)num == 0);
				do
				{
					IL_54:
					num = (460474636U & num);
				}
				while (num > 1993044520U);
				Dictionary<string, Translation> translations = __instance.Translations;
				num = (383082805U ^ num);
				string currentLanguage = __instance.CurrentLanguage;
				num = 1358434239U + num;
				Translation translation = translations[currentLanguage];
				if (1534529786U != num)
				{
					bool flag2 = translation != null;
					num = 266036131U << (int)num;
					num += 3509415936U;
					if (!flag2)
					{
						goto IL_126;
					}
				}
				List<string> keys = translation.Keys;
				num /= 397293799U;
				int num2 = keys.IndexOf(__0);
				if (1558144059U == num)
				{
					goto IL_12;
				}
				List<string> values = translation.Values;
				int num3 = num2;
				Dictionary<string, string> dictionary2 = HackTranslation.hackedStrings;
				num = 361324624U / num;
				string text = dictionary2[__0];
				num += 632883722U;
				values[num3] = text;
				Dictionary<string, string> dictionary3 = HackTranslation.hackedStrings;
				num = 520894628U % num;
				num /= 1783846479U;
				string text2 = dictionary3[__0];
				num = 1545014804U - num;
				num ^= 1757904404U;
				IL_126:
				if ((num ^ 1726699429U) == 0U)
				{
					goto IL_54;
				}
			}
			catch (Exception arg)
			{
				uint num = 1250435089U;
				if (num != 959126052U)
				{
					do
					{
						string text3 = string.Format("Exception in patch of string Gaggle.Translation.TranslationManager::GetTranslation(string GDFPBPKHPDH):\n{0}", arg);
						num = (181891972U ^ num);
						MelonLogger.Warning(text3);
					}
					while (625701953U == num);
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00061464 File Offset: 0x0005EA64
		// Note: this type is marked as 'beforefieldinit'.
		static HackTranslation()
		{
			uint num = 1761692310U;
			do
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				num |= 245909858U;
				num = (1165842525U | num);
				string key = "MENU_PLAY";
				num >>= 23;
				dictionary.Add(key, "GGDHack Mod\nv1.6.13");
				HackTranslation.hackedStrings = dictionary;
			}
			while (num / 988300958U != 0U);
		}

		// Token: 0x040001AB RID: 427
		private static Dictionary<string, string> hackedStrings;
	}
}
