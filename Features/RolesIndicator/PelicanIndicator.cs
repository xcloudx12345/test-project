using System;
using System.Collections.Generic;
using System.Linq;
using GGD_Hack.Events;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;

namespace GGD_Hack.Features.RolesIndicator
{
	// Token: 0x02000064 RID: 100
	public class PelicanIndicator
	{
		// Token: 0x0600018C RID: 396 RVA: 0x0005F348 File Offset: 0x0005C948
		public static void MarkAllPlayersAsPelican()
		{
			uint num = 420303032U;
			for (;;)
			{
				Dictionary<string, PlayerController>.ValueCollection.Enumerator enumerator = PlayerController.playersList.Values.GetEnumerator();
				num &= 1698392409U;
				Dictionary<string, PlayerController>.ValueCollection.Enumerator enumerator2 = enumerator;
				for (;;)
				{
					num <<= 2;
					if (!enumerator2.MoveNext())
					{
						return;
					}
					num = 654379580U;
					PlayerController playerController2;
					if ((num ^ 441853610U) != 0U)
					{
						PlayerController playerController = enumerator2.Current;
						num = (842859186U & num);
						playerController2 = playerController;
						if ((num ^ 612525680U) == 0U)
						{
							break;
						}
					}
					Object @object = playerController2;
					Object object2 = null;
					num ^= 2034051521U;
					bool flag = @object != object2;
					num += 2781680679U;
					if (flag)
					{
						num = 1289055938U + num;
						PlayerController playerController3 = playerController2;
						num *= 250553965U;
						bool isLocal = playerController3.isLocal;
						num ^= 1581485770U;
						if (!isLocal)
						{
							PlayerController playerController4 = playerController2;
							num ^= 1117670581U;
							SpawnedPlayerHandler spawnedPlayerHandler = playerController4.spawnedPlayerHandler;
							num <<= 27;
							if (spawnedPlayerHandler == null)
							{
								num = 2059405535U * num;
								num ^= 2567520280U;
							}
							else
							{
								IPLJDOHJOLM playerRole = num ^ 1744830524U;
								num = 2019365305U + num;
								spawnedPlayerHandler.SetPlayerRole(playerRole);
								num ^= 3780399521U;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0005F448 File Offset: 0x0005CA48
		public static void IndicateAsPelican(PlayerController playerController)
		{
			uint num;
			string text2;
			do
			{
				bool flag = Utils.IsChineseSystem();
				num = 1612579679U;
				string text;
				if (!flag)
				{
					num -= 550519848U;
					text = "[Pelican] ";
				}
				else
				{
					if (num >= 1823762343U)
					{
						continue;
					}
					text = "[鹈鹕] ";
					num ^= 1599323240U;
				}
				num = (1075081431U ^ num);
				text2 = text;
			}
			while (num % 1445294167U == 0U);
			string nickname = playerController.nickname;
			num -= 1632661812U;
			string value = text2;
			num = 1248949002U - num;
			bool flag2 = nickname.Contains(value);
			num = 1666725824U / num;
			if (!flag2)
			{
				num -= 488261763U;
				string format = "{0}{1}";
				object arg = text2;
				num = 1321540490U * num;
				num = 1115768697U % num;
				string nickname2 = string.Format(format, arg, playerController.nickname);
				num ^= 674135943U;
				playerController.nickname = nickname2;
				num ^= 1789868284U;
			}
			num = (271064493U | num);
			num = 1315447686U % num;
			string userId = playerController.userId;
			num %= 58739883U;
			int roleId = (int)(num + 4239997299U);
			num = (1255956312U ^ num);
			PluginEventsManager.RevealRoleInternalLink(userId, roleId);
			num = 110894509U + num;
			ConsoleColor consoleColor = (int)num + (ConsoleColor)(-1345763124);
			num = 605321261U >> (int)num;
			string text3 = "已标记玩家{0}为鹈鹕";
			num -= 810373183U;
			object[] array = new object[num ^ 3484594112U];
			num /= 120073964U;
			int num2 = (int)(num ^ 29U);
			num = 1441727409U + num;
			num = 965767036U * num;
			object nickname3 = playerController.nickname;
			num &= 133966230U;
			array[num2] = nickname3;
			num /= 1371292907U;
			MelonLogger.Msg(consoleColor, text3, array);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0005F5B0 File Offset: 0x0005CBB0
		public static List<PlayerController> GetOtherAlivePlayersNearby(string userId)
		{
			List<PlayerController> list;
			for (;;)
			{
				PelicanIndicator.<>c__DisplayClass2_0 CS$<>8__locals1 = new PelicanIndicator.<>c__DisplayClass2_0();
				for (;;)
				{
					PelicanIndicator.<>c__DisplayClass2_0 CS$<>8__locals2 = CS$<>8__locals1;
					uint num = 115147755U;
					Dictionary<string, PlayerController> playersList = PlayerController.playersList;
					num = 1677027337U % num;
					num = (232614848U ^ num);
					Vector3 acgbaghofip = playersList[userId].ACGBAGHOFIP;
					num |= 1648171193U;
					CS$<>8__locals2.position = acgbaghofip;
					if (1256683518U < num)
					{
						list = new List<PlayerController>();
						if (num % 698572942U == 0U)
						{
							break;
						}
					}
					for (;;)
					{
						IL_59:
						Dictionary<string, PlayerController> playersList2 = PlayerController.playersList;
						num >>= 31;
						Dictionary<string, PlayerController>.Enumerator enumerator = playersList2.GetEnumerator();
						while (num >> 26 == 0U)
						{
							bool flag = enumerator.MoveNext();
							num -= 641406635U;
							if (!flag && 1623286307U + num != 0U)
							{
								List<PlayerController> list2 = list;
								object @object = CS$<>8__locals1;
								num = 985935950U / num;
								list2.Sort(delegate(PlayerController p1, PlayerController p2)
								{
									uint num2 = 1965708895U;
									Vector3 acgbaghofip2 = p1.ACGBAGHOFIP;
									num2 = 974079491U % num2;
									float num3 = Vector3.Distance(acgbaghofip2, @object.position);
									num2 = (690374247U | num2);
									float num4 = num3;
									num2 = (494800905U & num2);
									num2 = 1894465904U - num2;
									Vector3 acgbaghofip3 = p2.ACGBAGHOFIP;
									Vector3 position = @object.position;
									num2 -= 933261721U;
									return num4.CompareTo(Vector3.Distance(acgbaghofip3, position));
								});
								if ((num ^ 391472880U) != 0U)
								{
									return list;
								}
								goto IL_59;
							}
							else
							{
								KeyValuePair<string, PlayerController> keyValuePair = enumerator.Current;
								string key = keyValuePair.key;
								num = 1959536747U;
								string value = key;
								num = (807622895U | num);
								PlayerController value2 = keyValuePair.value;
								num = (261178219U ^ num);
								bool flag2 = string.IsNullOrEmpty(value);
								num = 1654413824U + num;
								num += 568683132U;
								if (!flag2)
								{
									bool flag3 = value2 == null;
									num = (584546273U & num);
									num += 0U;
									if (!flag3)
									{
										bool timeOfDeath = value2.timeOfDeath != 0;
										num ^= 0U;
										if (!timeOfDeath)
										{
											bool flag4 = value2.userId == userId;
											num ^= 0U;
											if (!flag4)
											{
												num = 845755527U << (int)num;
												list.Add(value2);
												num ^= 845755527U;
											}
										}
									}
								}
							}
						}
						break;
					}
				}
			}
			return list;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0005F72C File Offset: 0x0005CD2C
		private static void HandlePelicanEat(string playerEaten, string pelican = null)
		{
			uint num = 876041257U;
			for (;;)
			{
				PlayerController playerController = null;
				num = 338762411U - num;
				for (;;)
				{
					num |= 179725125U;
					if (!string.IsNullOrWhiteSpace(pelican))
					{
						num |= 268655353U;
					}
					else
					{
						num -= 1978601191U;
						List<PlayerController> otherAlivePlayersNearby = PelicanIndicator.GetOtherAlivePlayersNearby(playerEaten);
						num = 1105070021U + num;
						List<PlayerController> list = otherAlivePlayersNearby;
						if (num <= 473069382U)
						{
							break;
						}
						PlayerController playerController2 = PlayerController.playersList[playerEaten];
						num |= 207106524U;
						Vector3 acgbaghofip = playerController2.ACGBAGHOFIP;
						num &= 1122187943U;
						Vector3 vector = acgbaghofip;
						num %= 565195104U;
						if (1699101256U - num == 0U)
						{
							goto IL_5D;
						}
						bool flag = list != null;
						num = 260704354U - num;
						if (flag)
						{
							num = 362571769U % num;
							bool count = list.Count != 0;
							num = 488011196U + num;
							if (!count)
							{
								num ^= 715969093U;
							}
							else
							{
								PlayerController playerController3 = list.ElementAt((int)(num - 638256632U));
								num &= 1172922253U;
								PlayerController playerController4 = playerController3;
								num = (1945595213U | num);
								if (1862807716U * num == 0U)
								{
									continue;
								}
								List<PlayerController> list2 = list;
								num = 1844802599U << (int)num;
								int count2 = list2.Count;
								uint num2 = num ^ 2927943681U;
								num = 1800872999U % num;
								if (count2 == num2)
								{
									PlayerController playerController5 = playerController4;
									num |= 1318148494U;
									playerController = playerController5;
									if (1222906040U == num)
									{
										goto IL_33;
									}
								}
								else
								{
									num /= 1796938912U;
									PlayerController playerController6 = playerController4;
									num /= 854013413U;
									float num3 = Vector3.Distance(playerController6.ACGBAGHOFIP, vector);
									if (num >= 1524176734U)
									{
										break;
									}
									IEnumerable<PlayerController> source = list;
									num = (1712485560U ^ num);
									int index = (int)(num + 2582481737U);
									num = 1736646745U % num;
									Vector3 acgbaghofip2 = source.ElementAt(index).ACGBAGHOFIP;
									num += 1752501203U;
									Vector3 vector2 = vector;
									num = (1687820478U & num);
									float num4 = Vector3.Distance(acgbaghofip2, vector2) - num3;
									num *= 360669475U;
									if (num4 > 1f)
									{
										num = 100873083U * num;
										playerController = playerController4;
										num += 3069244219U;
									}
									else
									{
										num -= 1471175181U;
										if (num == 1107385042U)
										{
											continue;
										}
										PlayerController playerController7 = null;
										num = 1811504060U % num;
										playerController = playerController7;
										num = 1615010952U - num;
										ConsoleColor consoleColor = (ConsoleColor)(num ^ 4098474176U);
										num ^= 2070766631U;
										string text = "鹈鹕吃人事件: 被吃的玩家: {0} 附近有多个玩家，无法判断鹈鹕";
										num = 1900876697U << (int)num;
										int num5 = (int)(num - 1755105279U);
										num = (1594630116U | num);
										object[] array = new object[num5];
										num *= 1403418768U;
										num = (678264362U ^ num);
										array[(int)(num ^ 1130737258U)] = playerEaten;
										num >>= 20;
										MelonLogger.Msg(consoleColor, text, array);
										num += 1876392313U;
									}
								}
								if (1429677316 << (int)num == 0)
								{
									continue;
								}
								Object @object = playerController;
								num &= 6307065U;
								if (@object)
								{
									ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 4209827U);
									num = 1259480538U << (int)num;
									string text2 = "鹈鹕吃人事件: 已根据被吃玩家附近玩家判断出鹈鹕为：{0}";
									int num6 = (int)(num ^ 608941057U);
									num = 745696189U + num;
									object[] array2 = new object[num6];
									array2[(int)(num + 2940330051U)] = playerController.nickname;
									num = 20521602U << (int)num;
									MelonLogger.Msg(consoleColor2, text2, array2);
									num %= 641872171U;
									if (num == 1007121216U)
									{
										break;
									}
									PlayerController playerController8 = playerController;
									num = (2086881491U & num);
									PelicanIndicator.IndicateAsPelican(playerController8);
									num += 3894342616U;
								}
								if (num <= 1331632811U)
								{
									return;
								}
								goto IL_5D;
							}
						}
						num >>= 30;
						if (num << 13 == 0U)
						{
							goto Block_7;
						}
						continue;
					}
					IL_33:
					PlayerController playerController9 = PlayerController.playersList[pelican];
					num = (448143574U | num);
					playerController = playerController9;
					if (718155358U >> (int)num != 0U)
					{
						continue;
					}
					IL_5D:
					PlayerController playerController10 = playerController;
					num >>= 21;
					PelicanIndicator.IndicateAsPelican(playerController10);
					if (591402516U != num)
					{
						return;
					}
					goto IL_33;
				}
			}
			return;
			Block_7:
			MelonLogger.Error("HandlePelicanEat的playersNearby不能为空");
		}

		// Token: 0x020000BE RID: 190
		[HarmonyPatch(typeof(InGameEvents), "Pelican_Eat", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class OnPelicanEat
		{
			// Token: 0x0600026B RID: 619 RVA: 0x00067DE8 File Offset: 0x000653E8
			private static void Postfix(string playerEaten, string pelican = null)
			{
				uint num;
				do
				{
					num = 1410748948U;
					ConsoleColor consoleColor = (int)num + (ConsoleColor)(-1410748938);
					num >>= 22;
					string text = "Postfix: 鹈鹕吃人事件：鹈鹕：{0} 被吃的玩家: {1}";
					object[] array = new object[num + 4294966962U];
					num = 1253247420U % num;
					num |= 1629901498U;
					int num2 = (int)(num + 2665065794U);
					num += 547370693U;
					bool flag = string.IsNullOrEmpty(pelican);
					num = (430459842U ^ num);
					object obj;
					if (!flag)
					{
						obj = pelican;
					}
					else
					{
						obj = "未知";
						num ^= 0U;
					}
					num <<= 20;
					array[num2] = obj;
					num = 707462316U / num;
					int num3 = (int)(num - 0U);
					num *= 205349551U;
					num *= 1119054077U;
					array[num3] = playerEaten;
					MelonLogger.Msg(consoleColor, text, array);
					num += 2112952827U;
				}
				while (154428764U == num);
				num /= 979843563U;
				num = 917663760U % num;
				PelicanIndicator.HandlePelicanEat(playerEaten, pelican);
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00067EBC File Offset: 0x000654BC
			public OnPelicanEat()
			{
				uint num = 437745099U;
				if ((num & 1539329500U) != 0U)
				{
					do
					{
						num -= 195695677U;
						base..ctor();
					}
					while (488852285U * num == 0U);
				}
			}
		}
	}
}
