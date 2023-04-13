using System;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.TransitionHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Managers;
using Managers.GameManagers;
using Managers.GameManagers.EventsManagers;
using MelonLoader;
using MelonLoader.Preferences;
using TMPro;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x0200004C RID: 76
	[RegisterTypeInIl2Cpp]
	public class AverageKillButtonToKillButton : MonoBehaviour
	{
		// Token: 0x0600013C RID: 316 RVA: 0x0005ACB4 File Offset: 0x000582B4
		public AverageKillButtonToKillButton(IntPtr ptr)
		{
			uint num = 1009473417U;
			if (num % 268639211U == 0U)
			{
				goto IL_70;
			}
			IL_12:
			num -= 1837123275U;
			base..ctor(ptr);
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			}
			while ((num ^ 1159219122U) == 0U);
			ingameSettingsEntry.entry = AverageKillButtonToKillButton.Enabled;
			num = 1642144622U * num;
			if (1163875973U >= num)
			{
				return;
			}
			num >>= 10;
			ingameSettingsEntry.name_cn = "复仇者加强版(测试功能)";
			num &= 103898931U;
			IL_70:
			num = 1419401712U % num;
			ingameSettingsEntry.name_eng = "Replace Avenger's Skill(Testing)";
			if (207184852U >> (int)num == 0U)
			{
				goto IL_12;
			}
			IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
			num <<= 4;
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0005AD68 File Offset: 0x00058368
		public AverageKillButtonToKillButton()
		{
			uint num;
			do
			{
				num = 1966999356U;
				base..ctor(ClassInjector.DerivedConstructorPointer<AverageKillButtonToKillButton>());
			}
			while (num + 154935016U == 0U);
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0005AD98 File Offset: 0x00058398
		public static void Init()
		{
			uint num = 1839209617U;
			if (850219158U >= num)
			{
				goto IL_51;
			}
			IL_11:
			GameObject gameObject = GameObject.Find("ML_Manager");
			num ^= 1703019392U;
			GameObject gameObject2 = gameObject;
			IL_24:
			bool flag = gameObject2 == null;
			num %= 1961972039U;
			if (flag)
			{
				gameObject2 = new GameObject("ML_Manager");
				Object.DontDestroyOnLoad(gameObject2);
				num += 0U;
			}
			IL_51:
			if (num % 1668159724U != 0U)
			{
				GameObject gameObject3 = gameObject2;
				num /= 1328760853U;
				if (gameObject3.GetComponent<AverageKillButtonToKillButton>() == null)
				{
					if ((1463162150U ^ num) == 0U)
					{
						goto IL_11;
					}
					GameObject gameObject4 = gameObject2;
					num = 236413261U - num;
					AverageKillButtonToKillButton.Instance = gameObject4.AddComponent<AverageKillButtonToKillButton>();
					num += 4058554035U;
				}
			}
			if (num * 18768111U == 0U)
			{
				return;
			}
			goto IL_24;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0005AE50 File Offset: 0x00058450
		// Note: this type is marked as 'beforefieldinit'.
		static AverageKillButtonToKillButton()
		{
			string text = "GGDH";
			uint num = 2090743850U;
			string text2 = "Enable_AverageKillButtonToKillButton";
			bool flag = num + 2204223446U != 0U;
			num <<= 21;
			string text3 = null;
			num &= 609632546U;
			string text4 = null;
			num = 1626869242U - num;
			bool flag2 = (num ^ 1555566074U) != 0U;
			num = 1212233U + num;
			bool flag3 = (num ^ 1556778307U) != 0U;
			num = (147993103U & num);
			ValueValidator valueValidator = null;
			num = 1252293248U % num;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num = 733706373U >> (int)num;
			AverageKillButtonToKillButton.Enabled = enabled;
			num = (126843961U & num);
			bool flag4 = (num ^ 735288U) != 0U;
			num = 492452461U % num;
			AverageKillButtonToKillButton.isAvenger = flag4;
		}

		// Token: 0x04000188 RID: 392
		public static AverageKillButtonToKillButton Instance;

		// Token: 0x04000189 RID: 393
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x0400018A RID: 394
		private static bool isAvenger;

		// Token: 0x020000A5 RID: 165
		[HarmonyPatch(typeof(PluginEventsManager), "KLBECEJIHMI")]
		private class AverageRegisterCooldownButton
		{
			// Token: 0x06000233 RID: 563 RVA: 0x00065EE0 File Offset: 0x000634E0
			private static void Prefix(PluginEventsManager __instance, ref Il2CppReferenceArray<Il2CppStringArray> __0)
			{
				uint num = 2083729347U;
				if (num / 1894002225U != 0U)
				{
					while (!AverageKillButtonToKillButton.Enabled.Value)
					{
						if (2072790578U <= num)
						{
							return;
						}
					}
				}
				uint num2 = num + 2211237948U;
				num <<= 14;
				try
				{
					num ^= 660226962U;
					for (;;)
					{
						num = 338113965U % num;
						Il2CppArrayBase<Il2CppStringArray> il2CppArrayBase = __0;
						int num3 = (int)(num - 338113965U);
						num = 1964849396U * num;
						Il2CppArrayBase<string> il2CppArrayBase2 = il2CppArrayBase[num3];
						Il2CppArrayBase<Il2CppStringArray> il2CppArrayBase3 = __0;
						num = (1332768867U ^ num);
						int num4 = (int)(num ^ 2714136710U);
						num *= 1770398253U;
						Il2CppStringArray il2CppStringArray = il2CppArrayBase3[num4];
						LocalPlayer instance = LocalPlayer.Instance;
						num <<= 6;
						int num5 = il2CppArrayBase2.IndexOf(instance.Player.userId);
						num |= 1571693808U;
						if (num5 < (int)(num ^ 1609527024U))
						{
							if (num != 267849556U)
							{
								break;
							}
						}
						else
						{
							for (;;)
							{
								num = (663160214U ^ num);
								Il2CppArrayBase<string> il2CppArrayBase4 = il2CppStringArray;
								int num6 = num5;
								num |= 1515462841U;
								int num7 = int.Parse(il2CppArrayBase4[num6]);
								num = 1384389562U * num;
								int num8 = num7;
								if (num8 == (int)(num + 2226758639U))
								{
									num += 2041319172U;
									Il2CppArrayBase<string> il2CppArrayBase5 = il2CppStringArray;
									num = 1728004922U + num;
									int num9 = num5;
									num = 103755933U % num;
									int num10 = (int)(num - 103755922U);
									num -= 803285948U;
									int num11 = num10;
									num = 998142118U * num;
									string text = num11.ToString();
									num >>= 6;
									il2CppArrayBase5[num9] = text;
									ConsoleColor consoleColor = (int)num + (ConsoleColor)(-23715421);
									num /= 997662806U;
									string text2 = "已修改角色{0}为警长";
									num <<= 25;
									object[] array = new object[num + 1U];
									num = 135744643U + num;
									int num12 = (int)(num + 4159222653U);
									num <<= 29;
									object obj = num8;
									num = 1623067763U + num;
									array[num12] = obj;
									num |= 1730619204U;
									MelonLogger.Msg(consoleColor, text2, array);
									num = 1883835133U * num;
									bool isAvenger = (num ^ 414944922U) != 0U;
									num = 1462912756U - num;
									AverageKillButtonToKillButton.isAvenger = isAvenger;
									if (num == 15235275U)
									{
										break;
									}
								}
								else
								{
									bool isAvenger2 = (num ^ 2068208710U) != 0U;
									num = 978788793U << (int)num;
									AverageKillButtonToKillButton.isAvenger = isAvenger2;
									num += 2829994521U;
								}
								if (num != 1599677661U)
								{
									goto Block_9;
								}
							}
						}
					}
					Block_9:;
				}
				catch (Exception ex)
				{
					num = 2014646519U;
					do
					{
						string format = "Exception in patch of void Managers.GameManagers.EventsManagers.PluginEventsManager::FPPGAKHLIFL(bool HGJEOMCCGGO):\n{0}";
						object arg = ex;
						num = (927475658U & num);
						string text3 = string.Format(format, arg);
						num <<= 8;
						MelonLogger.Msg(text3);
					}
					while ((num & 627514387U) != 0U);
				}
			}

			// Token: 0x06000234 RID: 564 RVA: 0x00066188 File Offset: 0x00063788
			public AverageRegisterCooldownButton()
			{
				uint num = 1935111602U;
				if (num >> 2 != 0U)
				{
					base..ctor();
				}
			}
		}

		// Token: 0x020000A6 RID: 166
		[HarmonyPatch(typeof(TransitionScreen), "Update")]
		private class TransitionScreen_Update
		{
			// Token: 0x06000235 RID: 565 RVA: 0x000661B0 File Offset: 0x000637B0
			private static void Postfix(TransitionScreen __instance)
			{
				while (AverageKillButtonToKillButton.Enabled.Value)
				{
					uint num = 10038118U;
					if (AverageKillButtonToKillButton.isAvenger)
					{
						num = 501755624U << (int)num;
						try
						{
							num = 519308210U % num;
							if (num < 1416774939U)
							{
								for (;;)
								{
									MainManager instance = MainManager.Instance;
									num >>= 3;
									byte b = instance.gameManager.gameState;
									uint num2 = num ^ 64913524U;
									num = 1273265654U + num;
									if (b != num2)
									{
										if (num > 1027872597U)
										{
											goto IL_86;
										}
									}
									else if (1070808527U != num)
									{
										break;
									}
								}
								GameObject gameObject = __instance.gameObject;
								num = 945436831U % num;
								Transform transform = gameObject.transform;
								string text = "Canvas";
								num = (542195631U ^ num);
								Transform transform2 = transform.Find(text);
								string text2 = "WinText";
								num += 1443631274U;
								GameObject gameObject2 = transform2.Find(text2).gameObject;
								num %= 7561521U;
								num >>= 5;
								TextMeshProUGUI component = gameObject2.GetComponent<TextMeshProUGUI>();
								num |= 760677249U;
								Component component2 = gameObject2.transform.Find("WinText (1)");
								num ^= 74263798U;
								TMP_Text component3 = component2.gameObject.GetComponent<TextMeshProUGUI>();
								num = 1492858690U >> (int)num;
								TMP_Text tmp_Text = component;
								string text3 = "复仇天使";
								num = 1599348328U + num;
								tmp_Text.text = text3;
								string text4 = "你可以杀死任何玩家";
								num = (388462025U ^ num);
								component3.text = text4;
							}
							IL_86:;
						}
						catch (Exception ex)
						{
							MelonLogger.Error(ex.Message);
						}
						return;
					}
					if ((2008154539U ^ num) != 0U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x020000A7 RID: 167
		[HarmonyPatch(typeof(LobbySceneHandler), "FixedUpdate")]
		private class LobbySceneHandler_Update
		{
			// Token: 0x06000237 RID: 567 RVA: 0x00066354 File Offset: 0x00063954
			private static void Postfix(LobbySceneHandler __instance)
			{
				uint num = 887707084U;
				Image image;
				for (;;)
				{
					MelonPreferences_Entry<bool> enabled = AverageKillButtonToKillButton.Enabled;
					num = 1083667725U / num;
					if (!enabled.Value)
					{
						if (num + 127220541U != 0U)
						{
							break;
						}
					}
					else if (num / 1010064422U == 0U)
					{
						if (!AverageKillButtonToKillButton.isAvenger)
						{
							goto Block_3;
						}
						num = (43910729U | num);
						GameManager gameManager = MainManager.Instance.gameManager;
						num *= 794709507U;
						byte gameState = gameManager.gameState;
						num >>= 30;
						byte b = gameState;
						uint num2 = num ^ 1U;
						num += 742082490U;
						if (b != num2)
						{
							if ((531523010U ^ num) != 0U)
							{
								return;
							}
						}
						else
						{
							Transform transform = __instance.gamePanel.transform;
							string text = "RoleIcon";
							num = 426783106U * num;
							Transform transform2 = transform.Find(text);
							TextMeshProUGUI component = transform2.Find("Name/RoleName").gameObject.GetComponent<TextMeshProUGUI>();
							num = 328616979U / num;
							string text2 = "复仇天使";
							num ^= 817119121U;
							component.text = text2;
							bool flag = (num ^ 817119121U) != 0U;
							bool flag2 = (num ^ 817119121U) != 0U;
							num = 1309632868U * num;
							component.ForceMeshUpdate(flag, flag2);
							num ^= 955927648U;
							string text3 = "BG/RoleSprite";
							num = 1828021053U * num;
							GameObject gameObject = transform2.Find(text3).gameObject;
							num = 663055902U + num;
							Image component2 = gameObject.GetComponent<Image>();
							num |= 1227751443U;
							image = component2;
							Object sprite = image.sprite;
							num = (1511196462U ^ num);
							string name = sprite.name;
							num *= 675242003U;
							string b2 = "liuhaixv.jpg";
							num = (1997144284U | num);
							bool flag3 = name != b2;
							num <<= 18;
							if (!flag3)
							{
								goto IL_19F;
							}
							if (num > 1446982286U)
							{
								goto Block_8;
							}
						}
					}
				}
				return;
				Block_3:
				if (2040613286U != num)
				{
					return;
				}
				return;
				Block_8:
				Image image2 = image;
				num %= 1199770044U;
				string imageName = "liuhaixv.jpg";
				num = (1202727940U ^ num);
				image2.sprite = SpriteUtil.GetSpriteFromImageName(imageName);
				num ^= 2822688456U;
				IL_19F:
				if (num >= 590832744U)
				{
					return;
				}
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0006650C File Offset: 0x00063B0C
			public LobbySceneHandler_Update()
			{
				uint num = 311976085U;
				if (num != 1309803970U)
				{
					base..ctor();
				}
			}
		}
	}
}
