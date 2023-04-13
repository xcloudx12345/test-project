using System;
using System.Collections.Generic;
using APIs.Photon;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem;
using Managers;
using Managers.PlayerManagers;
using MelonLoader;
using UnhollowerBaseLib;
using UnityEngine;

namespace GGD_Hack.Utils
{
	// Token: 0x02000011 RID: 17
	public class Utils
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00050058 File Offset: 0x0004D658
		public static void ChangeColor(int color)
		{
			uint num = 1354508229U;
			PlayerPropertiesManager playerPropertiesManager = MainManager.Instance.playerPropertiesManager;
			num = 1565466662U + num;
			playerPropertiesManager.ChangeColor(color);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00050084 File Offset: 0x0004D684
		public static void SendTextMessage(string text)
		{
			try
			{
				uint num = 896276129U;
				long num2 = (long)(num + 3398691169U);
				num -= 1750759122U;
				Il2CppStringArray il2CppStringArray = new Il2CppStringArray(num2);
				int num3 = (int)(num - 3440484303U);
				num = (2130719462U ^ num);
				il2CppStringArray[num3] = text;
				num = (1413971403U ^ num);
				num %= 339028542U;
				il2CppStringArray[(int)(num + 4159832009U)] = "false";
				num = 1107957275U % num;
				IntPtr pointer = il2CppStringArray.Pointer;
				num = 29314765U << (int)num;
				Object @object = new Object(pointer);
				byte b = (byte)(num ^ 1744830530U);
				num += 1154511896U;
				Object object2 = @object;
				num %= 187779718U;
				bool flag = num + 4212320706U != 0U;
				num = 1943237076U + num;
				PhotonEventAPI.SendEventToPlugin(b, object2, flag);
			}
			catch (Exception ex)
			{
				string str = "ERROR!!: SendTextMessage";
				uint num = 1898074980U;
				string message = ex.Message;
				num = 270952072U << (int)num;
				string text2 = str + message;
				num -= 870147834U;
				MelonLogger.Error(text2);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0005018C File Offset: 0x0004D78C
		public static void PrintAllPrefs()
		{
			uint num = 1814919979U;
			string text = "GGDH";
			num -= 1622026016U;
			MelonPreferences_Category category = MelonPreferences.GetCategory(text);
			num = 1508324024U % num;
			List<MelonPreferences_Entry> entries = category.Entries;
			num >>= 8;
			List<MelonPreferences_Entry>.Enumerator enumerator = entries.GetEnumerator();
			num -= 69471727U;
			List<MelonPreferences_Entry>.Enumerator enumerator2 = enumerator;
			try
			{
				do
				{
					for (;;)
					{
						num = (294005204U | num);
						if (num != 1518949732U)
						{
							if (!enumerator2.MoveNext())
							{
								break;
							}
							MelonPreferences_Entry melonPreferences_Entry = enumerator2.Current;
							num = 1716653455U;
							MelonPreferences_Entry melonPreferences_Entry2 = melonPreferences_Entry;
							num = 1485601866U + num;
							if (num + 1217471836U != 0U)
							{
								string text2 = "键名：{0} 默认值：{1} 当前值：{2}";
								int num2 = (int)(num ^ 3202255322U);
								num = 403115774U / num;
								object[] array = new object[num2];
								int num3 = (int)(num - 0U);
								MelonPreferences_Entry melonPreferences_Entry3 = melonPreferences_Entry2;
								num &= 1419844140U;
								object displayName = melonPreferences_Entry3.DisplayName;
								num <<= 26;
								array[num3] = displayName;
								num -= 702620564U;
								int num4 = (int)(num ^ 3592346733U);
								MelonPreferences_Entry melonPreferences_Entry4 = melonPreferences_Entry2;
								num = (1672751958U ^ num);
								array[num4] = melonPreferences_Entry4.GetDefaultValueAsString();
								int num5 = (int)(num - 3047880504U);
								MelonPreferences_Entry melonPreferences_Entry5 = melonPreferences_Entry2;
								num /= 1084646703U;
								array[num5] = melonPreferences_Entry5.GetEditedValueAsString();
								num = 2026386189U + num;
								MelonLogger.Msg(text2, array);
								num += 2199726824U;
							}
						}
					}
				}
				while (num <= 1445801101U);
			}
			finally
			{
				num = 576935520U;
				if ((300221178U & num) != 0U)
				{
					((IDisposable)enumerator2).Dispose();
				}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000502EC File Offset: 0x0004D8EC
		public static LocalPlayer GetLocalPlayer()
		{
			return LocalPlayer.Instance;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00050300 File Offset: 0x0004D900
		public static GameObject FindGameObjectByPath(string path)
		{
			uint num = 665476728U;
			Transform transform2;
			for (;;)
			{
				IL_06:
				num |= 515207108U;
				int num2 = (int)(num + 3225452549U);
				num += 540232856U;
				char[] array = new char[num2];
				num |= 2131706069U;
				num = 542913474U * num;
				int num3 = (int)(num - 842246250U);
				num = 1142098934U % num;
				array[num3] = (char)(num + 3995114659U);
				string[] array2 = path.Split(array);
				num %= 104889270U;
				int num5;
				do
				{
					Transform transform = null;
					num <<= 6;
					transform2 = transform;
					num += 1779122797U;
					int num4 = (int)(num ^ 3248900717U);
					num *= 2065452914U;
					num5 = num4;
				}
				while (num >= 1156071568U);
				for (;;)
				{
					num = 1134959559U << (int)num;
					int num6 = num5;
					num = (713180085U | num);
					int num7 = array2.Length;
					num = (33514379U ^ num);
					int num8 = num7;
					num += 1353719111U;
					if (num6 >= num8)
					{
						goto Block_8;
					}
					num = 1439776751U;
					if (num - 1519604170U == 0U)
					{
						goto IL_06;
					}
					Object @object = transform2;
					num %= 1768556775U;
					if (@object == null)
					{
						num = 326784780U - num;
						if (364477895U + num == 0U)
						{
							goto IL_06;
						}
						string[] array3 = array2;
						int num9 = num5;
						num |= 500917219U;
						Transform transform3 = GameObject.Find(array3[num9]).transform;
						num -= 1700933924U;
						transform2 = transform3;
					}
					else
					{
						num -= 1916632167U;
						Transform transform4 = transform2;
						num = (1218926537U & num);
						string[] array4 = array2;
						int num10 = num5;
						num *= 90047100U;
						string text = array4[num10];
						num = 79038616U - num;
						transform2 = transform4.Find(text);
						num += 233767971U;
					}
					num = 1964256854U / num;
					if (29710305U < num)
					{
						goto IL_06;
					}
					Object object2 = transform2;
					num = 11347003U % num;
					Object object3 = null;
					num ^= 305348483U;
					if (object2 == object3)
					{
						break;
					}
					int num11 = num5;
					num *= 1399065155U;
					int num12 = (int)(num + 4092543672U);
					num = 1808216545U >> (int)num;
					int num13 = num11 + num12;
					num = 479005021U / num;
					num5 = num13;
					num += 267437827U;
				}
				num <<= 27;
				if (773537586U + num != 0U)
				{
					break;
				}
				continue;
				Block_8:
				num >>= 5;
				if ((num & 1794724053U) != 0U)
				{
					goto Block_9;
				}
			}
			return null;
			Block_9:
			Component component = transform2;
			num = 1133647294U / num;
			return component.gameObject;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000504F0 File Offset: 0x0004DAF0
		public static bool IsChineseSystem()
		{
			uint num = 142621236U;
			SystemLanguage systemLanguage2;
			do
			{
				SystemLanguage systemLanguage = Application.systemLanguage;
				num /= 1470502439U;
				systemLanguage2 = systemLanguage;
				if ((1054881429U ^ num) == 0U)
				{
					break;
				}
				if (systemLanguage2 == (num ^ 6U))
				{
					goto IL_72;
				}
				SystemLanguage systemLanguage3 = systemLanguage2;
				uint num2 = num - 4294967256U;
				num = 16385108U + num;
				num ^= 16385108U;
				if (systemLanguage3 == num2)
				{
					goto IL_72;
				}
			}
			while (num == 832910068U);
			uint num3 = systemLanguage2;
			num |= 1170625978U;
			if (num3 != num - 1170625937U)
			{
				num |= 1170295780U;
				return (num ^ 1170694142U) != 0U;
			}
			num ^= 1170625978U;
			IL_72:
			num ^= 596722642U;
			return (num ^ 596722643U) != 0U;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00050590 File Offset: 0x0004DB90
		public Utils()
		{
			uint num = 1534791881U;
			if (num - 1794050030U != 0U)
			{
				base..ctor();
			}
		}
	}
}
