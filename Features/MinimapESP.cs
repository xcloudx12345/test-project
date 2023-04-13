using System;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.SpecialBehaviour;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using Managers;
using Managers.GameManagers;
using MelonLoader;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x02000037 RID: 55
	[RegisterTypeInIl2Cpp]
	public class MinimapESP : MonoBehaviour
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x00054270 File Offset: 0x00051870
		public MinimapESP(IntPtr ptr)
		{
			uint num = 1113328324U;
			if (1818698605U == num)
			{
				goto IL_66;
			}
			do
			{
				IL_11:
				base..ctor(ptr);
				num = 1318651551U * num;
			}
			while (num / 553067928U == 0U);
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				IL_2C:
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				num &= 208232569U;
				if (1598702404U == num)
				{
					goto IL_11;
				}
				num = 1481846905U + num;
				ingameSettingsEntry.entry = MinimapESP.Enabled;
			}
			while (503517681U == num);
			do
			{
				IL_66:
				num = 1256664905U + num;
				ingameSettingsEntry.name_cn = "Minimap ESP 透视";
				if (1953241482U > num)
				{
					goto IL_2C;
				}
				ingameSettingsEntry.name_eng = "Minimap ESP";
				num >>= 2;
			}
			while (num + 129122911U == 0U);
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
			if (850550260U >= num)
			{
				return;
			}
			goto IL_2C;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00054334 File Offset: 0x00051934
		public MinimapESP()
		{
			uint num = 1960989868U;
			do
			{
				num = (843278288U & num);
				base..ctor(ClassInjector.DerivedConstructorPointer<MinimapESP>());
				num = 1831028820U << (int)num;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (740391419U == num);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0005437C File Offset: 0x0005197C
		public static void Init()
		{
			uint num = 903219341U;
			if (814421975U <= num)
			{
				goto IL_11;
			}
			GameObject gameObject;
			for (;;)
			{
				IL_37:
				Object @object = gameObject;
				Object object2 = null;
				num = 1085227397U * num;
				if (!(@object == object2))
				{
					goto IL_98;
				}
				if (num >= 1448112276U)
				{
					goto IL_56;
				}
			}
			IL_11:
			string text = "ML_Manager";
			num ^= 1467354308U;
			GameObject gameObject2 = GameObject.Find(text);
			num = 735648253U - num;
			gameObject = gameObject2;
			if (1731592246U < num)
			{
				goto IL_37;
			}
			IL_56:
			string text2 = "ML_Manager";
			num = 541922510U << (int)num;
			gameObject = new GameObject(text2);
			num = 1591293763U * num;
			if (363539564U == num)
			{
				goto IL_11;
			}
			Object object3 = gameObject;
			num >>= 5;
			Object.DontDestroyOnLoad(object3);
			num ^= 3658982257U;
			IL_98:
			bool flag = gameObject.GetComponent<MinimapESP>() == null;
			num = (1577150463U ^ num);
			if (flag)
			{
				num = (988234848U | num);
				GameObject gameObject3 = gameObject;
				num = (1982475597U & num);
				MinimapESP instance = gameObject3.AddComponent<MinimapESP>();
				num = (1037787923U & num);
				MinimapESP.Instance = instance;
				num += 1362467962U;
			}
			if (num * 1035684629U != 0U)
			{
				return;
			}
			goto IL_37;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00054474 File Offset: 0x00051A74
		private static void InstantiateAllPlayers()
		{
			uint num;
			for (;;)
			{
				IL_00:
				MelonLogger.Msg("正在初始化所有玩家的minimap点位");
				num = 2058500436U;
				for (;;)
				{
					IL_10:
					MinimapESP.DestroyAllPlayers();
					num *= 1631210206U;
					for (;;)
					{
						LobbySceneHandler instance = LobbySceneHandler.Instance;
						num *= 1478705370U;
						object obj;
						if (instance == null)
						{
							num = 497490363U * num;
							obj = null;
						}
						else
						{
							MiniMapHandler miniMapHandler = instance.miniMapHandler;
							if (miniMapHandler == null)
							{
								num = 219694560U % num;
								if (634009416U == num)
								{
									goto IL_00;
								}
								obj = null;
								num ^= 2804684208U;
							}
							else
							{
								Transform transform = miniMapHandler.gameObject.transform;
								num >>= 26;
								string text = "Panel/Target Me";
								num = 1229936591U << (int)num;
								Transform transform2 = transform.Find(text);
								num -= 1477448892U;
								if (transform2 == null)
								{
									obj = null;
									num += 2236900620U;
								}
								else
								{
									obj = transform2.gameObject;
									num += 2236900620U;
								}
							}
						}
						object obj2;
						if ((obj2 = obj) == null)
						{
							num &= 2100320457U;
							goto IL_CF;
						}
						IL_D8:
						GameObject gameObject = obj2;
						num = 1796691088U + num;
						if (num > 1532849915U)
						{
							break;
						}
						Object @object = gameObject;
						Object object2 = null;
						num = 448007721U * num;
						bool flag = @object == object2;
						num ^= 931953045U;
						if (flag)
						{
							if (2015574335U > num)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							Dictionary<string, PlayerController> playersList = PlayerController.playersList;
							num = (1919223381U ^ num);
							Dictionary<string, PlayerController>.Enumerator enumerator = playersList.GetEnumerator();
							num *= 527649994U;
							Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
							for (;;)
							{
								Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator2;
								num |= 1898801233U;
								if (!enumerator3.MoveNext())
								{
									goto Block_13;
								}
								num = 251868595U;
								PlayerController value = enumerator2.Current.Value;
								num &= 642739866U;
								Object object3 = value;
								num >>= 16;
								Object object4 = null;
								num |= 1511130083U;
								bool flag2 = object3 == object4;
								num += 1307705693U;
								if (!flag2)
								{
									num = 1679910423U % num;
									if (num >> 10 == 0U)
									{
										goto IL_10;
									}
									bool isLocal = value.isLocal;
									num &= 1599627140U;
									num ^= 3959705412U;
									if (!isLocal)
									{
										GameObject gameObject2 = gameObject;
										num = (1117784945U | num);
										Transform transform3 = gameObject.transform;
										num += 1019028389U;
										Transform parent = transform3.parent;
										num = 955675700U / num;
										GameObject gameObject3 = Object.Instantiate<GameObject>(gameObject2, parent);
										Object object5 = gameObject3;
										num = (90970888U & num);
										PlayerController playerController = value;
										num = 1019299227U << (int)num;
										string userId = playerController.userId;
										num = 1581652310U * num;
										object5.name = userId;
										num = (405237805U & num);
										if (1258761211U % num == 0U)
										{
											break;
										}
										Object component = gameObject3.GetComponent<Animator>();
										num = 1698522753U - num;
										Object.DestroyImmediate(component);
										GameObject gameObject4 = gameObject3;
										num -= 2130461032U;
										Transform transform4 = gameObject4.transform;
										num = (844050800U & num);
										string text2 = "Text";
										num = 225000184U + num;
										TMP_Text component2 = transform4.Find(text2).gameObject.GetComponent<TextMeshProUGUI>();
										num = 238626088U << (int)num;
										Color white = Color.white;
										num /= 2098283889U;
										component2.color = white;
										GameObject playerOnMinimap = gameObject3;
										PlayerController playerController2 = value;
										num = 64029573U + num;
										MinimapESP.UpdatePlayerColorAndName(playerOnMinimap, playerController2);
										if (num - 481643233U == 0U)
										{
											goto IL_00;
										}
										Dictionary<string, GameObject> dictionary = MinimapESP.playersOnMinimap;
										PlayerController playerController3 = value;
										num = 117001034U - num;
										string userId2 = playerController3.userId;
										num = (52963890U ^ num);
										dictionary.Add(userId2, gameObject3);
										num ^= 2818860215U;
									}
								}
							}
						}
						IL_CF:
						obj2 = null;
						num ^= 2181300240U;
						goto IL_D8;
					}
				}
				Block_13:
				num <<= 28;
				if (num <= 1536829529U)
				{
					goto Block_14;
				}
			}
			Block_7:
			MelonLogger.Warning("[MinimapESP] 未找到Target Me对象，初始化所有玩家点位失败!");
			return;
			Block_14:
			MelonLogger.Msg("已初始化所有玩家的minimap点位");
			MinimapESP.instantiatedAllPlayers = ((num ^ 268435457U) != 0U);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00054780 File Offset: 0x00051D80
		private static void UpdatePlayerColorAndName(GameObject playerOnMinimap, PlayerController playerController)
		{
			uint num;
			TextMeshProUGUI component2;
			for (;;)
			{
				IL_00:
				num = 974595360U;
				Transform transform = playerOnMinimap.transform;
				string text = "You";
				num >>= 18;
				Transform transform2 = transform.Find(text);
				num = 375667608U - num;
				Image component = playerOnMinimap.GetComponent<Image>();
				num += 793010281U;
				Image image = component;
				num = (862215932U ^ num);
				Object @object = null;
				num = 1936875193U * num;
				if (transform2 == @object)
				{
					num = 1129411067U % num;
					MelonLogger.Warning("找不到 You");
					num += 2069652869U;
				}
				Object object2 = image;
				Object object3 = null;
				num = 369436369U % num;
				if (object2 == object3)
				{
					num = 1905487346U % num;
					string text2 = "找不到 Image";
					num <<= 7;
					MelonLogger.Warning(text2);
					num ^= 2865809489U;
				}
				num ^= 1794922965U;
				component2 = transform2.gameObject.GetComponent<TextMeshProUGUI>();
				num = 46923984U - num;
				if (num / 1457279734U != 0U)
				{
					while (component2 != null)
					{
						if (1491083869U == num)
						{
							goto IL_00;
						}
						if (playerController.isInPelican)
						{
							num >>= 26;
							num <<= 12;
							float num2 = 1f;
							num -= 1451177325U;
							float num3 = 0f;
							num = 420229631U >> (int)num;
							float num4 = 1f;
							num = 1447968953U >> (int)num;
							Color color;
							color..ctor(num2, num3, num4);
							num = 890534824U - num;
							TMP_Text tmp_Text = component2;
							num += 467029481U;
							tmp_Text.color = color;
							if (num << 22 == 0U)
							{
								goto IL_00;
							}
							TMP_Text tmp_Text2 = component2;
							Color white = Color.white;
							num >>= 17;
							Color32 outlineColor = white;
							num += 518735687U;
							tmp_Text2.outlineColor = outlineColor;
							if (num << 24 == 0U)
							{
								continue;
							}
						}
						else
						{
							int timeOfDeath = playerController.timeOfDeath;
							uint num5 = num ^ 2245165516U;
							num += 1248199207U;
							if (timeOfDeath > num5)
							{
								num = (771758565U | num);
								if (1074331914U == num)
								{
									goto IL_00;
								}
								Color black = Color.black;
								num <<= 22;
								Color color2 = black;
								TMP_Text tmp_Text3 = component2;
								num = 1526098238U / num;
								Color color3 = color2;
								num = 832513200U << (int)num;
								tmp_Text3.color = color3;
								num >>= 10;
								if (331754813U <= num)
								{
									goto IL_00;
								}
								TMP_Text tmp_Text4 = component2;
								num >>= 4;
								Color32 outlineColor2 = Color.white;
								num <<= 28;
								tmp_Text4.outlineColor = outlineColor2;
								if (num == 3236895U)
								{
									goto IL_00;
								}
								num += 1592482344U;
							}
							else
							{
								num += 1680746414U;
								if (num == 1038300659U)
								{
									goto IL_00;
								}
								IPLJDOHJOLM ijoicoidmhc = playerController.playerRole.IJOICOIDMHC;
								num = (188305063U & num);
								uint num6 = num - 2099813U;
								num += 90970860U;
								if (ijoicoidmhc == num6)
								{
									num &= 1325147617U;
									if (1404914308 << (int)num == 0)
									{
										goto IL_00;
									}
									Color green = Color.green;
									num |= 105471471U;
									Color color4 = green;
									TMP_Text tmp_Text5 = component2;
									Color color5 = color4;
									num -= 2026243962U;
									tmp_Text5.color = color5;
									num = 67054419U << (int)num;
									TMP_Text tmp_Text6 = component2;
									Color white2 = Color.white;
									num = (222911358U | num);
									tmp_Text6.outlineColor = white2;
									if (num >> 23 == 0U)
									{
										continue;
									}
									num ^= 1904345430U;
								}
								else
								{
									num /= 1080387164U;
									if (696722960U < num)
									{
										goto IL_00;
									}
									component2.color = Color.white;
									if (num * 966412523U != 0U)
									{
										goto IL_00;
									}
									TMP_Text tmp_Text7 = component2;
									Color black2 = Color.black;
									num /= 395336022U;
									Color32 outlineColor3 = black2;
									num = 250298733U << (int)num;
									tmp_Text7.outlineColor = outlineColor3;
									num ^= 268442437U;
								}
							}
						}
						TMP_Text tmp_Text8 = component2;
						num = 2122260566U - num;
						tmp_Text8.text = playerController.nickname;
						num = 1322990390U + num;
						if (650905441U <= num)
						{
							goto Block_17;
						}
						goto IL_00;
					}
					goto IL_37A;
				}
			}
			Block_17:
			component2.ForceMeshUpdate((num ^ 2926510436U) != 0U, (num ^ 2926510436U) != 0U);
			num ^= 733839528U;
			IL_37A:
			TMP_Text tmp_Text9 = component2;
			num = 2116766598U * num;
			RectTransform rectTransform = tmp_Text9.rectTransform;
			float num7 = 10f;
			float num8 = 0.5f;
			num = 137434841U - num;
			rectTransform.anchorMax = new Vector2(num7, num8);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00054B34 File Offset: 0x00052134
		private static void DestroyAllPlayers()
		{
			string text = "正在销毁所有玩家minimap点位";
			uint num = 378087457U;
			MelonLogger.Msg(text);
			num = 1572826220U + num;
			if (num <= 1141785286U)
			{
				goto IL_36;
			}
			IL_23:
			Dictionary<string, GameObject> dictionary = MinimapESP.playersOnMinimap;
			num <<= 14;
			Dictionary<string, GameObject>.Enumerator enumerator = dictionary.GetEnumerator();
			IL_36:
			for (;;)
			{
				num += 1383205543U;
				Dictionary<string, GameObject>.Enumerator enumerator2 = enumerator;
				num *= 1253008348U;
				bool flag = enumerator2.MoveNext();
				num >>= 7;
				if (!flag)
				{
					break;
				}
				KeyValuePair<string, GameObject> keyValuePair = enumerator.Current;
				num = 1486761346U;
				KeyValuePair<string, GameObject> keyValuePair2 = keyValuePair;
				num = (1977289977U & num);
				Object value = keyValuePair2.Value;
				Object @object = null;
				num |= 89682197U;
				bool flag2 = value != @object;
				num += 3477652075U;
				if (flag2)
				{
					num -= 849942252U;
					KeyValuePair<string, GameObject> keyValuePair3 = keyValuePair2;
					num = (941370186U ^ num);
					Object value2 = keyValuePair3.Value;
					num *= 79380340U;
					Object.Destroy(value2);
					num ^= 643527832U;
				}
			}
			num += 1753956143U;
			Dictionary<string, GameObject> dictionary2 = MinimapESP.playersOnMinimap;
			num = 645150059U / num;
			dictionary2.Clear();
			num = (255021610U & num);
			bool flag3 = num + 0U != 0U;
			num ^= 329779532U;
			MinimapESP.instantiatedAllPlayers = flag3;
			MelonLogger.Msg("已经销毁所有玩家minimap点位");
			if (1591871132U != num)
			{
				return;
			}
			goto IL_23;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00054C4C File Offset: 0x0005224C
		private void Update()
		{
			uint num = 481955553U;
			if (1630165743U - num != 0U)
			{
				IL_12:
				while (MinimapESP.Enabled.Value)
				{
					for (;;)
					{
						Object @object = MinimapESP.miniMapHandler;
						num = 1597712644U >> (int)num;
						bool flag = @object == null;
						num |= 1474051833U;
						if (flag && num > 98064441U)
						{
							return;
						}
						num = (810030945U & num);
						bool gameStarted = LobbySceneHandler.Instance.gameStarted;
						num &= 2047171926U;
						if (!gameStarted)
						{
							break;
						}
						if (525939001U / num != 0U)
						{
							return;
						}
						bool flag2 = MinimapESP.instantiatedAllPlayers;
						num &= 75127120U;
						if (!flag2)
						{
							goto Block_8;
						}
						num = 549397171U / num;
						Object object2 = GameObject.Find("Canvas/MiniMap");
						num ^= 1105677398U;
						bool flag3 = object2;
						num = 1951666527U % num;
						if (!flag3)
						{
							return;
						}
						Dictionary<string, GameObject> dictionary = MinimapESP.playersOnMinimap;
						num %= 314795575U;
						Dictionary<string, GameObject>.Enumerator enumerator = dictionary.GetEnumerator();
						num = 672491653U << (int)num;
						Dictionary<string, GameObject>.Enumerator enumerator2 = enumerator;
						for (;;)
						{
							num &= 648356835U;
							Dictionary<string, GameObject>.Enumerator enumerator3 = enumerator2;
							num %= 335114373U;
							if (!enumerator3.MoveNext())
							{
								return;
							}
							KeyValuePair<string, GameObject> keyValuePair = enumerator2.Current;
							num = 1381896358U;
							num = 1118256515U + num;
							string key = keyValuePair.Key;
							GameObject value = keyValuePair.Value;
							num = 355667544U << (int)num;
							if ((679939914U & num) == 0U)
							{
								break;
							}
							Object object3 = value;
							num = (1608283646U ^ num);
							bool flag4 = object3 == null;
							num = 1636176526U % num;
							num ^= 2277854352U;
							if (!flag4)
							{
								if (num < 1415462167U)
								{
									break;
								}
								Dictionary<string, PlayerController> playersList = PlayerController.playersList;
								num /= 684811981U;
								bool flag5 = playersList.ContainsKey(key);
								num ^= 2684354563U;
								if (flag5)
								{
									num = 355956815U - num;
									Dictionary<string, PlayerController> playersList2 = PlayerController.playersList;
									num = (1809916883U ^ num);
									PlayerController playerController = playersList2[key];
									num ^= 1108497436U;
									Vector3 acgbaghofip = playerController.ACGBAGHOFIP;
									num = 1909273847U - num;
									Vector3 vector = acgbaghofip;
									num ^= 843191014U;
									if (1712813924U < num)
									{
										return;
									}
									bool timeOfDeath = playerController.timeOfDeath != 0;
									num = 1206855865U / num;
									if (timeOfDeath)
									{
										num = 109645355U / num;
										if (num << 14 == 0U)
										{
											goto IL_12;
										}
										PlayerController playerController2 = playerController;
										num = 168106560U - num;
										string nickname = playerController2.nickname;
										num = 792725458U + num;
										bool flag6 = nickname.Contains("[尸体]");
										num >>= 11;
										if (!flag6)
										{
											num /= 1699240663U;
											bool flag7 = playerController.nickname.Contains("[Body]");
											num /= 1700615352U;
											num += 415618U;
											if (!flag7)
											{
												num = (1629385885U | num);
												if (1871972508U % num == 0U)
												{
													goto IL_12;
												}
												if (Utils.IsChineseSystem())
												{
													if (1394569106U * num == 0U)
													{
														return;
													}
													playerController.nickname = "[尸体] " + playerController.nickname;
													if (542075687U >= num)
													{
														break;
													}
													num += 2665996259U;
												}
												else
												{
													num /= 545483616U;
													if (num > 1039680385U)
													{
														goto IL_12;
													}
													PlayerController playerController3 = playerController;
													num -= 1484475776U;
													string str = "[Body] ";
													num = 1642686502U / num;
													PlayerController playerController4 = playerController;
													num |= 1837244380U;
													string nickname2 = playerController4.nickname;
													num -= 1402608685U;
													playerController3.nickname = str + nickname2;
													num ^= 435049517U;
												}
											}
										}
										num = 878846293U - num;
										if ((455623420U & num) == 0U)
										{
											goto IL_12;
										}
										GameManager gameManager = MainManager.Instance.gameManager;
										num ^= 498295979U;
										string userId = playerController.userId;
										num -= 375597937U;
										BodyHandler bodyHandler = gameManager.BodyFromUserId(userId);
										num >>= 9;
										BodyHandler bodyHandler2 = bodyHandler;
										bool flag8 = bodyHandler2 != null;
										num %= 927617374U;
										if (flag8)
										{
											Component component = bodyHandler2;
											num /= 753995424U;
											Transform transform = component.transform;
											num = 1428306087U - num;
											vector = transform.position;
											num ^= 1428306086U;
										}
										else
										{
											num = 1185102113U * num;
											Object object4 = value;
											num <<= 23;
											Object.Destroy(object4);
											if (1253732104U + num == 0U)
											{
												return;
											}
											num = (905389414U ^ num);
											if ((917532521U ^ num) != 0U)
											{
												num += 3666401946U;
												continue;
											}
											goto IL_12;
										}
									}
									Transform transform2 = value.transform;
									num >>= 3;
									MiniMapHandler miniMapHandler = MinimapESP.miniMapHandler;
									num = (1050628497U | num);
									float num2 = miniMapHandler.xFactor * vector.x;
									num ^= 1091533705U;
									float num3 = num2;
									num <<= 11;
									float num4 = num3 + MinimapESP.miniMapHandler.xOffset;
									MiniMapHandler miniMapHandler2 = MinimapESP.miniMapHandler;
									num %= 859530721U;
									float yFactor = miniMapHandler2.yFactor;
									Vector3 vector2 = vector;
									num |= 1190924397U;
									float num5 = yFactor * vector2.y;
									float yOffset = MinimapESP.miniMapHandler.yOffset;
									num = 352022152U >> (int)num;
									Vector3 localPosition = new Vector3(num4, num5 + yOffset, 0f);
									num /= 1763325343U;
									transform2.localPosition = localPosition;
									num %= 644496810U;
									if (num >= 1206453118U)
									{
										goto IL_12;
									}
									GameObject playerOnMinimap = value;
									num >>= 18;
									PlayerController playerController5 = playerController;
									num = (314406714U | num);
									MinimapESP.UpdatePlayerColorAndName(playerOnMinimap, playerController5);
									num ^= 2998761274U;
								}
							}
						}
					}
					if ((num ^ 72511472U) != 0U)
					{
						if (MinimapESP.playersOnMinimap.Count != 0)
						{
							if (227480401U == num)
							{
								continue;
							}
							string text = "游戏结束，清除所有玩家的minimap点位";
							num *= 1961837281U;
							MelonLogger.Msg(text);
							if (num >> 30 != 0U)
							{
								break;
							}
							MinimapESP.DestroyAllPlayers();
							num += 318097408U;
						}
						return;
					}
					break;
					Block_8:
					num *= 789586038U;
					MinimapESP.InstantiateAllPlayers();
					return;
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0005514C File Offset: 0x0005274C
		// Note: this type is marked as 'beforefieldinit'.
		static MinimapESP()
		{
			string text = "GGDH";
			uint num = 416747865U;
			string text2 = "Enable_MinimapESP";
			num |= 1699156217U;
			bool flag = num - 2111246840U != 0U;
			string text3 = null;
			num = 1156472508U / num;
			string text4 = null;
			bool flag2 = num + 0U != 0U;
			num = 814036976U - num;
			bool flag3 = num - 814036976U != 0U;
			num = 924676446U % num;
			MinimapESP.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, null);
			num <<= 13;
			bool flag4 = num + 4174528512U != 0U;
			num = 1294221876U - num;
			MinimapESP.instantiatedAllPlayers = flag4;
			MinimapESP.Instance = null;
			if (num - 1901219904U != 0U)
			{
				do
				{
					MinimapESP.miniMapHandler = null;
					num = 1472412371U % num;
				}
				while (num >= 1813717343U);
			}
			Dictionary<string, GameObject> dictionary = new Dictionary<string, GameObject>();
			num *= 1839624268U;
			MinimapESP.playersOnMinimap = dictionary;
		}

		// Token: 0x04000147 RID: 327
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000148 RID: 328
		public static bool instantiatedAllPlayers;

		// Token: 0x04000149 RID: 329
		public static MinimapESP Instance;

		// Token: 0x0400014A RID: 330
		public static MiniMapHandler miniMapHandler;

		// Token: 0x0400014B RID: 331
		private static Dictionary<string, GameObject> playersOnMinimap;

		// Token: 0x02000097 RID: 151
		[HarmonyPatch(typeof(InGameEvents), "Pelican_Eat")]
		private class PelicanEatenPlayerESP
		{
			// Token: 0x06000215 RID: 533 RVA: 0x000652B8 File Offset: 0x000628B8
			private static void OnPelicanEat(string playerEaten, string pelican = null)
			{
				uint num;
				PlayerController playerController;
				do
				{
					Dictionary<string, PlayerController> playersList = PlayerController.playersList;
					num = 1310488359U;
					playerController = playersList[playerEaten];
					num += 481787166U;
				}
				while (29452390U > num);
				PlayerController playerController2 = playerController;
				num *= 114062033U;
				string format = "[{0}] {1}";
				bool flag = Utils.IsChineseSystem();
				num -= 23226763U;
				object arg;
				if (!flag)
				{
					arg = "Eaten";
				}
				else
				{
					arg = "被吃";
					num ^= 0U;
				}
				num *= 1933860788U;
				PlayerController playerController3 = playerController;
				num = 557591623U >> (int)num;
				playerController2.nickname = string.Format(format, arg, playerController3.nickname);
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00065348 File Offset: 0x00062948
			private static void Postfix(string playerEaten, string pelican)
			{
				uint num;
				for (;;)
				{
					bool value = MinimapESP.Enabled.Value;
					num = 126241311U;
					if (!value)
					{
						if (1889745592U > num)
						{
							break;
						}
					}
					else
					{
						num /= 660672396U;
						if ((num & 743989127U) == 0U)
						{
							goto Block_1;
						}
					}
				}
				return;
				Block_1:
				num = (625829135U & num);
				MinimapESP.PelicanEatenPlayerESP.OnPelicanEat(playerEaten, pelican);
				if (453775223U >= num)
				{
					return;
				}
			}
		}
	}
}
