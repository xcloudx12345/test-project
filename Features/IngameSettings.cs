using System;
using System.Collections;
using System.Collections.Generic;
using Gaggle.Translation;
using GGD_Hack.Utils;
using Handlers.CommonHandlers;
using HarmonyLib;
using MelonLoader;
using TMPro;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x02000033 RID: 51
	public class IngameSettings
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00053628 File Offset: 0x00050C28
		public static void AddIngameSettingsEntry(IngameSettings.IngameSettingsEntry ingameSettingsEntry)
		{
			uint num = 169566981U;
			List<IngameSettings.IngameSettingsEntry> list = IngameSettings.registeredEntries;
			num = 655970044U * num;
			List<IngameSettings.IngameSettingsEntry>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				do
				{
					bool flag;
					do
					{
						num -= 1987058701U;
						if (769065730U / num == 0U && !enumerator.MoveNext())
						{
							goto Block_5;
						}
						num = 2114272894U;
						num /= 1038960556U;
						MelonPreferences_Entry entry = enumerator.Current.entry;
						num %= 78207682U;
						string displayName = entry.DisplayName;
						num |= 1436895407U;
						MelonPreferences_Entry entry2 = ingameSettingsEntry.entry;
						num %= 311715383U;
						flag = (displayName == entry2.DisplayName);
						num /= 268525689U;
						num += 3114139372U;
					}
					while (!flag);
				}
				while ((1203857042U & num) == 0U);
				string str = "已经添加过设置项:";
				num *= 1099449675U;
				num &= 1415054039U;
				MelonPreferences_Entry entry3 = ingameSettingsEntry.entry;
				num = 1906643361U << (int)num;
				string displayName2 = entry3.DisplayName;
				num = 80032804U % num;
				MelonLogger.Error(str + displayName2);
				return;
				Block_5:;
			}
			finally
			{
				do
				{
					num = 225475729U;
					if (num + 23352013U == 0U)
					{
						break;
					}
					((IDisposable)enumerator).Dispose();
				}
				while (1981432875U == num);
			}
			num = 519994683U;
			IngameSettings.registeredEntries.Add(ingameSettingsEntry);
			ConsoleColor consoleColor = (ConsoleColor)(num - 519994673U);
			num = 282395236U - num;
			string str2 = "已注册mod设置项:";
			num %= 40706257U;
			string text = str2 + ingameSettingsEntry.entry.DisplayName;
			num = 152531179U << (int)num;
			MelonLogger.Msg(consoleColor, text);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000537BC File Offset: 0x00050DBC
		private static void RegisterAllMelonPreferencesIntoGameSettings()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000537CC File Offset: 0x00050DCC
		public IngameSettings()
		{
			uint num = 29444242U;
			do
			{
				num -= 142963860U;
				base..ctor();
			}
			while (1053951669U > num);
		}

		// Token: 0x04000141 RID: 321
		public static List<IngameSettings.IngameSettingsEntry> registeredEntries = new List<IngameSettings.IngameSettingsEntry>();

		// Token: 0x04000142 RID: 322
		private static GameObject boolSettingPrefab = null;

		// Token: 0x02000091 RID: 145
		public struct IngameSettingsEntry
		{
			// Token: 0x040001DC RID: 476
			public MelonPreferences_Entry entry;

			// Token: 0x040001DD RID: 477
			public string name_cn;

			// Token: 0x040001DE RID: 478
			public string name_eng;
		}

		// Token: 0x02000092 RID: 146
		[HarmonyPatch(typeof(ClientSettings), "Update")]
		public class ClientSettings_Update
		{
			// Token: 0x0600020B RID: 523 RVA: 0x00064378 File Offset: 0x00061978
			private static void Postfix(ClientSettings __instance)
			{
				Il2CppArrayBase<ModularUIButtonHandler> verticalTabs = __instance.GetVerticalTabs();
				ModularUIButtonHandler modularUIButtonHandler = null;
				uint num = 574307635U;
				ModularUIButtonHandler modularUIButtonHandler2 = modularUIButtonHandler;
				IEnumerator<ModularUIButtonHandler> enumerator = verticalTabs.GetEnumerator();
				num |= 944588556U;
				using (IEnumerator<ModularUIButtonHandler> enumerator2 = enumerator)
				{
					ModularUIButtonHandler modularUIButtonHandler3;
					for (;;)
					{
						for (;;)
						{
							num %= 1958222286U;
							if ((1428037618U ^ num) != 0U)
							{
								IEnumerator enumerator3 = enumerator2;
								num = 852388596U % num;
								bool flag = enumerator3.MoveNext();
								num /= 539954043U;
								if (!flag)
								{
									goto Block_18;
								}
							}
							do
							{
								num = 150816236U;
								modularUIButtonHandler3 = enumerator2.Current;
								num = 1456302067U >> (int)num;
							}
							while (791289848U < num);
							GameObject gameObject = modularUIButtonHandler3.gameObject;
							num <<= 11;
							num <<= 20;
							object obj;
							if (gameObject == null)
							{
								obj = null;
							}
							else
							{
								obj = gameObject.name;
								num += 0U;
							}
							object a;
							bool flag2 = (a = obj) != null;
							num = (1620262053U | num);
							if (!flag2)
							{
								num = 1795980052U << (int)num;
								if (num <= 1360987916U)
								{
									break;
								}
								a = null;
								num += 4278442533U;
							}
							num <<= 8;
							bool flag3 = a == "Account";
							num += 2806176319U;
							if (flag3)
							{
								goto Block_16;
							}
						}
					}
					Block_16:
					modularUIButtonHandler2 = modularUIButtonHandler3;
					Block_18:;
				}
				do
				{
					IL_115:
					num = 1746303715U;
					if (modularUIButtonHandler2 == null)
					{
						if (263480703U > num)
						{
							continue;
						}
					}
					else
					{
						for (;;)
						{
							bool flag4 = modularUIButtonHandler2 != null;
							num = (1169231355U | num);
							TextMeshProUGUI textMeshProUGUI;
							if (!flag4)
							{
								textMeshProUGUI = null;
							}
							else
							{
								if (1814512664U >= num)
								{
									goto IL_115;
								}
								Component component = modularUIButtonHandler2;
								num = 1929645611U + num;
								Transform transform = component.gameObject.transform;
								string text = "Text";
								num <<= 30;
								Transform transform2 = transform.Find(text);
								num = (325976212U & num);
								if (transform2 == null)
								{
									num = (747771429U & num);
									num = 1406825774U - num;
									textMeshProUGUI = null;
									num ^= 1047333589U;
								}
								else
								{
									textMeshProUGUI = transform2.GetComponent<TextMeshProUGUI>();
									num ^= 1840742395U;
								}
							}
							TextMeshProUGUI textMeshProUGUI2 = textMeshProUGUI;
							if (516753100U % num == 0U)
							{
								goto IL_115;
							}
							Object @object = textMeshProUGUI2;
							Object object2 = null;
							num /= 218978596U;
							if (@object == object2)
							{
								goto Block_8;
							}
							if ((num ^ 1168521556U) == 0U)
							{
								goto IL_115;
							}
							TMP_Text tmp_Text = textMeshProUGUI2;
							string text2 = "Mod";
							num |= 717168784U;
							tmp_Text.text = text2;
							num *= 654715543U;
							TextMeshProUGUI textMeshProUGUI3 = textMeshProUGUI2;
							num = 1980915553U / num;
							bool flag5 = (num ^ 0U) != 0U;
							bool flag6 = (num ^ 0U) != 0U;
							num %= 1571322151U;
							textMeshProUGUI3.ForceMeshUpdate(flag5, flag6);
							Component component2 = modularUIButtonHandler2;
							num /= 1537544365U;
							GameObject gameObject2 = component2.gameObject;
							num |= 956239980U;
							gameObject2.SetActive(num - 956239979U != 0U);
							num += 34486605U;
							if (num * 683681777U == 0U)
							{
								break;
							}
							num %= 151286855U;
							GameObject gameObject3 = __instance.gameObject;
							num >>= 2;
							Transform transform3 = gameObject3.transform;
							string text3 = "Frame (new)/Content Container/Panel - Account";
							num /= 114694410U;
							GameObject gameObject4 = transform3.Find(text3).gameObject;
							num /= 129584531U;
							bool active = num - uint.MaxValue != 0U;
							num = 702155933U * num;
							gameObject4.SetActive(active);
							if (1020600868U >= num)
							{
								return;
							}
						}
					}
					string text4 = "未找到Account";
					num <<= 27;
					MelonLogger.Error(text4);
				}
				while (1562785661U < num);
				return;
				Block_8:
				MelonLogger.Error("未找到Account->TextMeshProUGUI");
			}

			// Token: 0x0600020C RID: 524 RVA: 0x0006467C File Offset: 0x00061C7C
			public ClientSettings_Update()
			{
				uint num;
				do
				{
					num = 426007639U;
					base..ctor();
				}
				while (num / 1774861591U != 0U);
			}
		}

		// Token: 0x02000093 RID: 147
		[HarmonyPatch(typeof(ClientSettings), "Start")]
		public class ClientSettings_Start
		{
			// Token: 0x0600020D RID: 525 RVA: 0x000646A4 File Offset: 0x00061CA4
			private static void Postfix(ClientSettings __instance)
			{
				uint num = 678977987U;
				GameObject gameObject9;
				for (;;)
				{
					Transform transform = __instance.gameObject.transform;
					string text = "Frame (new)/Content Container";
					num = 1248867085U + num;
					Transform transform2 = transform.Find(text);
					num *= 2137400861U;
					object obj;
					if (transform2 == null)
					{
						if (1544643214 << (int)num != 0)
						{
							goto IL_44;
						}
						continue;
					}
					else
					{
						obj = transform2.gameObject;
						num ^= 0U;
					}
					IL_57:
					object obj2;
					bool flag = (obj2 = obj) != null;
					num = 1516722951U - num;
					if (!flag)
					{
						num = (229449754U ^ num);
						num |= 1901925396U;
						goto IL_76;
					}
					IL_7F:
					num -= 656878810U;
					GameObject gameObject = obj2;
					num |= 569921136U;
					if ((num & 1109610766U) != 0U)
					{
						bool flag2 = gameObject != null;
						num %= 363348055U;
						object obj3;
						if (!flag2)
						{
							if (2094932312U / num == 0U)
							{
								continue;
							}
							obj3 = null;
						}
						else
						{
							num <<= 12;
							if (num < 1419664485U)
							{
								goto IL_44;
							}
							Transform transform3 = gameObject.gameObject.transform.Find("Panel - Account/Content - Account");
							if (transform3 == null)
							{
								num |= 245837774U;
								if (1911433229U >= num)
								{
									continue;
								}
								obj3 = null;
								num += 2193620609U;
							}
							else
							{
								num -= 54408622U;
								obj3 = transform3.gameObject;
								num ^= 2114012189U;
							}
						}
						object obj4;
						bool flag3 = (obj4 = obj3) != null;
						num /= 1715428236U;
						if (!flag3)
						{
							num = (488442745U | num);
							goto IL_13B;
						}
						IL_144:
						num -= 1122530318U;
						GameObject gameObject2 = obj4;
						if (1529227825U > num)
						{
							goto IL_44;
						}
						Object @object = gameObject;
						num *= 1036876450U;
						bool flag4 = @object == null;
						num &= 2066153695U;
						if (flag4)
						{
							if (1499475089U >> (int)num != 0U)
							{
								break;
							}
							continue;
						}
						else
						{
							num += 1816472914U;
							if (gameObject2 == null)
							{
								num <<= 29;
								if (1935835052U / num == 0U)
								{
									goto Block_14;
								}
								goto IL_44;
							}
							else
							{
								if ((382356491U ^ num) == 0U)
								{
									continue;
								}
								GameObject gameObject3 = gameObject;
								num = 1902120848U % num;
								Transform transform4 = gameObject3.transform;
								num %= 946889750U;
								Transform transform5 = transform4.Find("Panel -  Controls - Done/Content - KbM/StandaloneContent/Keybinds/Scroll View");
								num = (2114998465U | num);
								object obj5;
								if (transform5 == null)
								{
									num >>= 7;
									num = 20594135U % num;
									obj5 = null;
								}
								else
								{
									obj5 = transform5.gameObject;
									num += 2176706371U;
								}
								num <<= 13;
								object obj6;
								if ((obj6 = obj5) == null)
								{
									if (num >> 13 == 0U)
									{
										goto IL_76;
									}
									obj6 = null;
									num += 0U;
								}
								GameObject gameObject4 = obj6;
								num = 311763122U - num;
								if ((1817999205U & num) == 0U)
								{
									continue;
								}
								Object object2 = gameObject4;
								num = 96298975U >> (int)num;
								Object object3 = null;
								num /= 1672552950U;
								if (object2 == object3)
								{
									num = 1270838520U + num;
									if (937515078U / num != 0U)
									{
										goto IL_44;
									}
									string text2 = "scrollView未找到";
									num /= 1007107531U;
									MelonLogger.Error(text2);
									if (num / 434984903U == 0U)
									{
										return;
									}
									continue;
								}
								else
								{
									if (num / 1538021448U != 0U)
									{
										continue;
									}
									GameObject gameObject5 = gameObject4;
									Transform transform6 = gameObject2.transform;
									num += 2012560464U;
									gameObject4 = Object.Instantiate<GameObject>(gameObject5, transform6);
									num = 539325984U * num;
									Object object4 = gameObject4;
									num |= 20659766U;
									string name = "Mod Scroll View";
									num -= 989419770U;
									object4.name = name;
									if (1249738374 << (int)num == 0)
									{
										continue;
									}
									GameObject gameObject6 = gameObject4;
									num &= 174025303U;
									RectTransform component = gameObject6.GetComponent<RectTransform>();
									num = 2093361890U + num;
									RectTransform rectTransform = component;
									if (rectTransform == null)
									{
										if (395720842U / num != 0U)
										{
											continue;
										}
										MelonLogger.Error("rectTransform未找到");
										if (604383462U / num == 0U)
										{
											return;
										}
										goto IL_44;
									}
									else
									{
										num = 1563918224U - num;
										if (1987522845U == num)
										{
											continue;
										}
										RectTransform rectTransform2 = rectTransform;
										num = 169810091U >> (int)num;
										rectTransform2.anchorMax = new Vector2(1f, 1f);
										if (970732108U % num != 0U)
										{
											goto IL_44;
										}
										RectTransform rectTransform3 = rectTransform;
										num = (1190728797U | num);
										rectTransform3.anchoredPosition = new Vector2(-15f, -80f);
										RectTransform rectTransform4 = rectTransform;
										Vector2 sizeDelta = new Vector2(43f, -220f);
										num = (319706391U | num);
										rectTransform4.sizeDelta = sizeDelta;
										if (num <= 1019610302U)
										{
											goto IL_44;
										}
										num = (204363173U ^ num);
										num *= 1949120228U;
										GameObject gameObject7 = gameObject4;
										num *= 350752819U;
										Transform transform7 = gameObject7.transform.Find("Viewport/Content");
										num = (617245216U & num);
										num = 938948086U % num;
										GameObject gameObject8;
										if (transform7 == null)
										{
											gameObject8 = null;
										}
										else
										{
											gameObject8 = transform7.gameObject;
											num ^= 0U;
										}
										gameObject9 = gameObject8;
										num = 1279864173U << (int)num;
										if (num > 1620380432U)
										{
											continue;
										}
										GridLayoutGroup component2 = gameObject9.GetComponent<GridLayoutGroup>();
										component2.constraint = (num ^ 1530920961U);
										int constraintCount = (int)(num ^ 1530920961U);
										num = 937843814U / num;
										component2.constraintCount = constraintCount;
										num = 1601720073U >> (int)num;
										float num2 = 100f;
										num = 900286655U - num;
										component2.cellSize = new Vector2(num2, 100f);
										if (412896231U + num == 0U)
										{
											goto IL_76;
										}
										Object boolSettingPrefab = IngameSettings.boolSettingPrefab;
										num -= 1619623069U;
										bool flag5 = boolSettingPrefab == null;
										num %= 1082932726U;
										if (!flag5)
										{
											goto IL_670;
										}
										if (1430216491U < num)
										{
											continue;
										}
										Transform transform8 = gameObject.transform;
										string text3 = "Panel -  Gameplay - Done (check fullscreen)/Content - Gameplay/Content/Output Label BG (4)/GameObject/Flash Toggle";
										num /= 785317979U;
										Transform transform9 = transform8.Find(text3);
										num = (749892737U & num);
										object obj7;
										if (transform9 == null)
										{
											num %= 1859734699U;
											if (num / 1137987088U != 0U)
											{
												goto IL_13B;
											}
											obj7 = null;
										}
										else
										{
											obj7 = transform9.gameObject;
											num ^= 0U;
										}
										num &= 1113405069U;
										object obj8;
										if ((obj8 = obj7) == null)
										{
											num |= 1328431758U;
											if (974734317U > num)
											{
												continue;
											}
											obj8 = null;
											num += 2966535538U;
										}
										GameObject boolSettingPrefab2 = Object.Instantiate<GameObject>(obj8);
										num = 832570924U - num;
										IngameSettings.boolSettingPrefab = boolSettingPrefab2;
										if ((num ^ 922839583U) == 0U)
										{
											continue;
										}
										Object boolSettingPrefab3 = IngameSettings.boolSettingPrefab;
										string name2 = "Mod's Bool Setting Prefab";
										num -= 1055396084U;
										boolSettingPrefab3.name = name2;
										num <<= 7;
										Object component3 = IngameSettings.boolSettingPrefab.GetComponent<Toggle>();
										num &= 1269264595U;
										Object.DestroyImmediate(component3);
										num = (1954369564U & num);
										GameObject boolSettingPrefab4 = IngameSettings.boolSettingPrefab;
										num = 1730240063U / num;
										Toggle toggle = boolSettingPrefab4.AddComponent<Toggle>();
										GameObject boolSettingPrefab5 = IngameSettings.boolSettingPrefab;
										num += 578756332U;
										Transform transform10 = boolSettingPrefab5.transform;
										num <<= 21;
										GameObject gameObject10 = transform10.Find("Checkmark").gameObject;
										num = 1838228027U * num;
										Graphic component4 = gameObject10.GetComponent<Image>();
										num = 1675189051U % num;
										toggle.graphic = component4;
										num = 239668728U / num;
										if (num / 172702497U == 0U)
										{
											goto Block_41;
										}
										goto IL_76;
									}
								}
							}
						}
						IL_13B:
						obj4 = null;
						num += 3806524551U;
						goto IL_144;
					}
					continue;
					IL_76:
					obj2 = null;
					num ^= 753410058U;
					goto IL_7F;
					IL_44:
					obj = null;
					goto IL_57;
				}
				string text4 = "contentContainer为空";
				num = 843273250U - num;
				MelonLogger.Error(text4);
				return;
				Block_14:
				MelonLogger.Error("accountContent为空");
				return;
				Block_41:
				Transform transform11 = IngameSettings.boolSettingPrefab.transform;
				num *= 37508873U;
				string text5 = "Title";
				num = 41645330U >> (int)num;
				GameObject gameObject11 = transform11.Find(text5).gameObject;
				num -= 52429814U;
				Object component5 = gameObject11.GetComponent<TranslationHelper>();
				num %= 911699899U;
				Object.DestroyImmediate(component5);
				num += 253594867U;
				IL_670:
				Transform transform12 = gameObject9.transform;
				num ^= 786451468U;
				int childCount = transform12.childCount;
				num += 321224538U;
				int num3 = childCount - (int)(num - 790688392U);
				for (;;)
				{
					uint num4 = (uint)num3;
					num >>= 22;
					if (num4 < (num ^ 188U))
					{
						break;
					}
					num = 1914834572U;
					GameObject gameObject12 = gameObject9;
					num *= 1006508862U;
					Transform transform13 = gameObject12.transform;
					int num5 = num3;
					num -= 361587253U;
					Component child = transform13.GetChild(num5);
					num = 728898707U << (int)num;
					Object.Destroy(child.gameObject);
					int num6 = num3;
					num = 863270146U >> (int)num;
					int num7 = (int)(num - 863270145U);
					num = 474170796U * num;
					int num8 = num6 - num7;
					num = 1611165800U >> (int)num;
					num3 = num8;
					num += 790688297U;
				}
				List<IngameSettings.IngameSettingsEntry> registeredEntries = IngameSettings.registeredEntries;
				num -= 469829989U;
				List<IngameSettings.IngameSettingsEntry>.Enumerator enumerator = registeredEntries.GetEnumerator();
				num += 1662666436U;
				List<IngameSettings.IngameSettingsEntry>.Enumerator enumerator2 = enumerator;
				try
				{
					for (;;)
					{
						IL_73F:
						while (num % 703692779U != 0U)
						{
							num = 543557825U - num;
							bool flag6 = enumerator2.MoveNext();
							num = (1484594912U | num);
							if (!flag6 && num != 1694708627U)
							{
								goto Block_53;
							}
							IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals1 = new IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0();
							num = 525499784U;
							IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
							do
							{
								IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals3 = CS$<>8__locals2;
								num = 1494249916U * num;
								num %= 1112023990U;
								CS$<>8__locals3.ingameSettingsEntry = enumerator2.Current;
								if (num > 799425774U)
								{
									goto IL_73F;
								}
								IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals4 = CS$<>8__locals2;
								num = 1138116751U % num;
								MelonPreferences_Entry entry = CS$<>8__locals4.ingameSettingsEntry.entry;
								num |= 17921804U;
								bool flag7 = entry.BoxedValue is bool;
								num += 1594564126U;
								if (!flag7)
								{
									goto IL_9B3;
								}
								num ^= 1936269544U;
								ConsoleColor consoleColor = (ConsoleColor)(num - 296367435U);
								num = 1994468565U * num;
								string str = "正在添加mod设置：";
								num += 918632061U;
								IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals5 = CS$<>8__locals2;
								num = 1615948857U - num;
								MelonPreferences_Entry entry2 = CS$<>8__locals5.ingameSettingsEntry.entry;
								num ^= 26945297U;
								MelonLogger.Msg(consoleColor, str + entry2.DisplayName);
								GameObject boolSettingPrefab6 = IngameSettings.boolSettingPrefab;
								num = 445917029U * num;
								GameObject gameObject13 = gameObject9;
								num = (1967202647U ^ num);
								Transform transform14 = gameObject13.transform;
								num <<= 29;
								GameObject gameObject14 = Object.Instantiate<GameObject>(boolSettingPrefab6, transform14);
								if (789334963U >> (int)num == 0U)
								{
									goto IL_73F;
								}
								GameObject gameObject15 = gameObject14;
								num >>= 25;
								Transform transform15 = gameObject15.transform;
								num ^= 676077359U;
								Component component6 = transform15.Find("Title");
								num = 756438657U >> (int)num;
								TextMeshProUGUI component7 = component6.gameObject.GetComponent<TextMeshProUGUI>();
								num |= 433150111U;
								num = 342826015U + num;
								string text6;
								if (!Utils.IsChineseSystem())
								{
									text6 = CS$<>8__locals2.ingameSettingsEntry.name_eng;
								}
								else
								{
									text6 = CS$<>8__locals2.ingameSettingsEntry.name_cn;
									num += 0U;
								}
								component7.text = text6;
								component7.ForceMeshUpdate((num ^ 775976127U) != 0U, num + 3518991170U != 0U);
								num = (50409607U & num);
								IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals6 = CS$<>8__locals2;
								num = 1077880312U - num;
								Toggle component8 = gameObject14.GetComponent<Toggle>();
								num = 2103776387U - num;
								CS$<>8__locals6.toggle = component8;
								num /= 1438732715U;
							}
							while (2015566024U <= num);
							UnityEvent<bool> onValueChanged = CS$<>8__locals2.toggle.onValueChanged;
							num = 1344696619U >> (int)num;
							Action<bool> action = delegate(bool v)
							{
								uint num9 = 1405174795U;
								bool flag8;
								if (num9 > 1269061274U)
								{
									Toggle toggle3 = CS$<>8__locals2.toggle;
									num9 /= 1344682973U;
									bool isOn2 = toggle3.isOn;
									num9 += 1592069370U;
									flag8 = isOn2;
								}
								do
								{
									num9 = 1603356522U % num9;
									MelonPreferences_Entry entry5 = CS$<>8__locals2.ingameSettingsEntry.entry;
									object boxedValue2 = flag8;
									num9 /= 89158247U;
									entry5.BoxedValue = boxedValue2;
									num9 ^= 1592806676U;
									if ((num9 ^ 421741591U) == 0U)
									{
										break;
									}
									MelonPreferences.Save();
								}
								while (1235763062U * num9 == 0U);
							};
							num = 952316239U - num;
							onValueChanged.AddListener(action);
							num -= 432491808U;
							IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals7 = CS$<>8__locals2;
							num *= 128588879U;
							Toggle toggle2 = CS$<>8__locals7.toggle;
							num = (469577314U | num);
							IngameSettings.ClientSettings_Start.<>c__DisplayClass0_0 CS$<>8__locals8 = CS$<>8__locals2;
							num = 445918303U / num;
							num <<= 18;
							MelonPreferences_Entry entry3 = CS$<>8__locals8.ingameSettingsEntry.entry;
							num = 1958376329U - num;
							object boxedValue = entry3.BoxedValue;
							num = (2018786710U & num);
							bool isOn = (bool)boxedValue;
							num = 658907729U % num;
							toggle2.isOn = isOn;
							if (num * 175864715U != 0U)
							{
								num += 533928906U;
								break;
							}
							break;
							IL_9B3:
							num = 2105230041U + num;
							if ((num ^ 317534975U) != 0U)
							{
								string str2 = "未添加mod设置选项，因为数据非bool类型：";
								MelonPreferences_Entry entry4 = CS$<>8__locals2.ingameSettingsEntry.entry;
								num <<= 10;
								MelonLogger.Warning(str2 + entry4.DisplayName);
								num += 1303832091U;
							}
						}
					}
					Block_53:;
				}
				finally
				{
					do
					{
						num = 883118028U;
						num ^= 335701348U;
						((IDisposable)enumerator2).Dispose();
					}
					while (num - 1643908386U == 0U);
				}
			}

			// Token: 0x0600020E RID: 526 RVA: 0x00065124 File Offset: 0x00062724
			public ClientSettings_Start()
			{
				uint num = 731647030U;
				num = (13786059U ^ num);
				base..ctor();
			}
		}
	}
}
