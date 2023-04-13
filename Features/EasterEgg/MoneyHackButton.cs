using System;
using System.Collections.Generic;
using System.Linq;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace GGD_Hack.Features.EasterEgg
{
	// Token: 0x02000059 RID: 89
	public class MoneyHackButton
	{
		// Token: 0x06000168 RID: 360 RVA: 0x0005D260 File Offset: 0x0005A860
		public static void OnSilverBuyButtonClicked(BaseEventData data)
		{
			for (;;)
			{
				ConsoleColor consoleColor = ConsoleColor.Green;
				uint num = 1481842055U;
				MelonLogger.Msg(consoleColor, "Buy按钮被点击!");
				if (num < 2134928528U)
				{
					MoneyHackButton.IncreaseSilver();
					if (962603907 << (int)num != 0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0005D2A4 File Offset: 0x0005A8A4
		public static void OnGoldBuyButtonClicked(BaseEventData data)
		{
			MelonLogger.Msg(ConsoleColor.Green, "Buy按钮被点击!");
			uint num = 1199263029U;
			do
			{
				MoneyHackButton.IncreaseGold();
			}
			while (1729439385U == num);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0005D2D4 File Offset: 0x0005A8D4
		private static void IncreaseGold()
		{
			string text = "金币已减少";
			uint num = 1385374670U;
			MelonLogger.Msg(text);
			PlayerCustomizationPanelHandler playerCustomizationPanelHandler = MoneyHackButton.playerCustomizationPanelHandler;
			num %= 1976445875U;
			num &= 588848962U;
			int goldBalance = playerCustomizationPanelHandler.goldBalance;
			num = 1975930849U << (int)num;
			int goldBalance2 = goldBalance - (int)(num + 686211296U);
			num = 1607032706U >> (int)num;
			playerCustomizationPanelHandler.goldBalance = goldBalance2;
			if (715724634U > num)
			{
				TMP_Text goldCurrencyText = MoneyHackButton.playerCustomizationPanelHandler.goldCurrencyText;
				PlayerCustomizationPanelHandler playerCustomizationPanelHandler2 = MoneyHackButton.playerCustomizationPanelHandler;
				num = (103894893U | num);
				int goldBalance3 = playerCustomizationPanelHandler2.goldBalance;
				num = 1153247354U % num;
				int num2 = goldBalance3;
				num ^= 2115058085U;
				num = 1942641301U >> (int)num;
				string text2 = num2.ToString();
				num = (1977092089U ^ num);
				goldCurrencyText.text = text2;
				num = 184642047U - num;
			}
			TextMeshProUGUI goldCurrencyText2 = MoneyHackButton.playerCustomizationPanelHandler.goldCurrencyText;
			bool flag = num - 2502517472U != 0U;
			num -= 1506874958U;
			bool flag2 = (num ^ 995642514U) != 0U;
			num ^= 620722297U;
			goldCurrencyText2.ForceMeshUpdate(flag, flag2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0005D3C4 File Offset: 0x0005A9C4
		private static void IncreaseSilver()
		{
			uint num = 1091978066U;
			if (609430114U >> (int)num != 0U)
			{
				goto IL_18;
			}
			do
			{
				IL_30:
				PlayerCustomizationPanelHandler playerCustomizationPanelHandler = MoneyHackButton.playerCustomizationPanelHandler;
				num = (1309491114U ^ num);
				num *= 193022403U;
				int silverBalance = playerCustomizationPanelHandler.silverBalance;
				num = 612831657U >> (int)num;
				int num2 = (int)(num - 73808U);
				num *= 555431402U;
				playerCustomizationPanelHandler.silverBalance = silverBalance - num2;
				num = (1018050791U | num);
				if (592320906U > num)
				{
					goto IL_18;
				}
				TMP_Text silverCurrencyText = MoneyHackButton.playerCustomizationPanelHandler.silverCurrencyText;
				int silverBalance2 = MoneyHackButton.playerCustomizationPanelHandler.silverBalance;
				num = 584733310U << (int)num;
				int num3 = silverBalance2;
				silverCurrencyText.text = num3.ToString();
				num ^= 895161143U;
				PlayerCustomizationPanelHandler playerCustomizationPanelHandler2 = MoneyHackButton.playerCustomizationPanelHandler;
				num >>= 29;
				TextMeshProUGUI silverCurrencyText2 = playerCustomizationPanelHandler2.silverCurrencyText;
				num %= 1176916794U;
				bool flag = num + 1U != 0U;
				num = (960763246U | num);
				bool flag2 = num + 3334204051U != 0U;
				num = 1717522751U + num;
				silverCurrencyText2.ForceMeshUpdate(flag, flag2);
			}
			while (num == 1204054952U);
			return;
			IL_18:
			MelonLogger.Msg("银币已减少");
			num = 362041509U >> (int)num;
			goto IL_30;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0005D4D4 File Offset: 0x0005AAD4
		public MoneyHackButton()
		{
			uint num;
			do
			{
				num = 739978405U;
				base..ctor();
			}
			while ((2095211304U ^ num) == 0U);
		}

		// Token: 0x0400019F RID: 415
		public static PlayerCustomizationPanelHandler playerCustomizationPanelHandler;

		// Token: 0x040001A0 RID: 416
		private static EventTrigger.Entry gold;

		// Token: 0x040001A1 RID: 417
		private static EventTrigger.Entry silver;

		// Token: 0x020000B4 RID: 180
		[HarmonyPatch(typeof(PlayerCustomizationPanelHandler), "Update")]
		private class PlayerCustomizationPanelHandler_Update
		{
			// Token: 0x06000254 RID: 596 RVA: 0x00067510 File Offset: 0x00064B10
			private static void Postfix(PlayerCustomizationPanelHandler __instance)
			{
				try
				{
					uint num;
					for (;;)
					{
						IL_00:
						bool gold = MoneyHackButton.gold != null;
						num = 1485375129U;
						if (!gold)
						{
							num = 492330542U / num;
							if (num % 2102218607U == 0U)
							{
								goto IL_24;
							}
							continue;
						}
						for (;;)
						{
							IL_9D:
							num = 311437080U >> (int)num;
							if (296972844U <= num)
							{
								goto IL_00;
							}
							bool silver = MoneyHackButton.silver != null;
							num ^= 521410667U;
							if (!silver)
							{
								num = (734344033U | num);
								if (num <= 996701848U)
								{
									goto IL_00;
								}
								EventTrigger.Entry entry = new EventTrigger.Entry();
								num = (1114398115U & num);
								num |= 826693931U;
								EventTriggerType eventID = num - 860248359U;
								num <<= 13;
								entry.eventID = eventID;
								num += 504721478U;
								UnityEvent<BaseEventData> callback = entry.callback;
								Action<BaseEventData> action = new Action<BaseEventData>(MoneyHackButton.OnSilverBuyButtonClicked);
								num /= 1325736500U;
								callback.AddListener(action);
								num |= 1767136830U;
								MoneyHackButton.silver = entry;
								num ^= 1983923804U;
							}
							Object playerCustomizationPanelHandler = MoneyHackButton.playerCustomizationPanelHandler;
							num *= 1366322996U;
							num = 432284035U / num;
							bool flag = playerCustomizationPanelHandler != __instance;
							num = 776104854U << (int)num;
							if (!flag)
							{
								goto IL_43B;
							}
							for (;;)
							{
								Object @object = null;
								num %= 2058497288U;
								bool flag2 = __instance != @object;
								num &= 1136477395U;
								num += 742533892U;
								if (!flag2)
								{
									goto IL_43B;
								}
								MoneyHackButton.playerCustomizationPanelHandler = __instance;
								IEnumerable<GameObject> source = Object.FindObjectsOfType<GameObject>();
								Func<GameObject, bool> predicate;
								if ((predicate = MoneyHackButton.PlayerCustomizationPanelHandler_Update.<>c.<>9__0_0) == null)
								{
									num += 1036786392U;
									Func<GameObject, bool> func = delegate(GameObject obj)
									{
										uint num6 = 533821864U;
										string name2 = obj.name;
										num6 = 1008730926U - num6;
										return name2 == "Buy";
									};
									num = (1009006212U & num);
									predicate = func;
									num %= 1813413302U;
									MoneyHackButton.PlayerCustomizationPanelHandler_Update.<>c.<>9__0_0 = func;
									num += 37643666U;
								}
								num |= 1816931461U;
								GameObject[] array = source.Where(predicate).ToArray<GameObject>();
								num |= 222121475U;
								GameObject[] array2 = array;
								num <<= 1;
								int num2 = (int)(num + 553722066U);
								num |= 767758400U;
								int num3 = num2;
								if (899894771U == num)
								{
									break;
								}
								for (;;)
								{
									int num4 = num3;
									num *= 1737168539U;
									GameObject[] array3 = array2;
									num &= 440889827U;
									if (num4 >= array3.Length)
									{
										goto Block_19;
									}
									num = 471340831U;
									if ((num ^ 1096958502U) == 0U)
									{
										goto IL_00;
									}
									GameObject[] array4 = array2;
									num >>= 15;
									int num5 = num3;
									num = 843399247U * num;
									object obj2 = array4[num5];
									num = 1623673524U + num;
									string name = obj2.transform.parent.gameObject.name;
									num <<= 17;
									string text = name;
									EventTrigger component = obj2.GetComponent<EventTrigger>();
									num %= 2000770975U;
									EventTrigger eventTrigger = component;
									if (270426161U >= num)
									{
										goto IL_00;
									}
									Object object2 = eventTrigger;
									num &= 762078629U;
									Object object3 = null;
									num = 186667921U << (int)num;
									bool flag3 = object2 != object3;
									num = 195066397U >> (int)num;
									if (flag3)
									{
										string a = text;
										num = (1445346122U | num);
										if (a == "Gold")
										{
											if (num == 1472295915U)
											{
												break;
											}
											eventTrigger.triggers.Clear();
											num = 1001858057U / num;
											if ((1679583510U ^ num) == 0U)
											{
												goto IL_00;
											}
											EventTrigger eventTrigger2 = eventTrigger;
											num = 1620135466U << (int)num;
											List<EventTrigger.Entry> triggers = eventTrigger2.triggers;
											EventTrigger.Entry gold2 = MoneyHackButton.gold;
											num = 52051487U >> (int)num;
											triggers.Add(gold2);
											num = (432754948U & num);
											MelonLogger.Msg((int)num + (ConsoleColor)(-16378), "已添加彩蛋");
											if (num << 24 == 0U)
											{
												goto IL_00;
											}
											num ^= 17876U;
										}
										else
										{
											if (num >> 15 == 0U)
											{
												goto IL_00;
											}
											bool flag4 = text == "Silver";
											num ^= 1445345802U;
											if (flag4)
											{
												if (num + 1801262979U == 0U)
												{
													goto IL_24;
												}
												List<EventTrigger.Entry> triggers2 = eventTrigger.triggers;
												num = (1073371391U ^ num);
												triggers2.Clear();
												num = 1653868202U - num;
												if (646324253U < num)
												{
													goto IL_24;
												}
												EventTrigger eventTrigger3 = eventTrigger;
												num %= 1755674430U;
												List<EventTrigger.Entry> triggers3 = eventTrigger3.triggers;
												num *= 442913352U;
												EventTrigger.Entry silver2 = MoneyHackButton.silver;
												num = 593635944U - num;
												triggers3.Add(silver2);
												num /= 1801266894U;
												ConsoleColor consoleColor = (ConsoleColor)(num ^ 10U);
												num /= 104954429U;
												MelonLogger.Msg(consoleColor, "已添加彩蛋");
												num ^= 1488U;
											}
										}
									}
									num3 += (int)(num ^ 1489U);
									num += 4294957470U;
								}
							}
						}
						IL_24:
						EventTrigger.Entry entry2 = new EventTrigger.Entry();
						num = (944469511U & num);
						num = (1572685171U & num);
						entry2.eventID = (num ^ 4U);
						num ^= 1029439497U;
						num *= 1595958567U;
						UnityEvent<BaseEventData> callback2 = entry2.callback;
						num = 1303728361U << (int)num;
						object object4 = null;
						num >>= 3;
						UnityAction<BaseEventData> unityAction = new Action<BaseEventData>(object4.OnGoldBuyButtonClicked);
						num = (310658778U & num);
						callback2.AddListener(unityAction);
						MoneyHackButton.gold = entry2;
						num ^= 1216939673U;
						goto IL_9D;
					}
					Block_19:
					num ^= 604199444U;
					IL_43B:;
				}
				catch (Exception arg)
				{
					MelonLogger.Warning(string.Format("Exception in patch of void Handlers.LobbyHandlers.PlayerCustomizationPanelHandler::Update():\n{0}", arg));
				}
			}

			// Token: 0x06000255 RID: 597 RVA: 0x00067998 File Offset: 0x00064F98
			public PlayerCustomizationPanelHandler_Update()
			{
				uint num = 2084586496U;
				if (num + 1420755497U != 0U)
				{
					base..ctor();
				}
			}
		}
	}
}
