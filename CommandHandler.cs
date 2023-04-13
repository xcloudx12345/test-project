using System;
using System.Collections.Generic;
using System.Linq;
using GGD_Hack.Features;
using GGD_Hack.Features.Test;
using GGD_Hack.Hook;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack
{
	// Token: 0x02000004 RID: 4
	[RegisterTypeInIl2Cpp]
	public class CommandHandler : MonoBehaviour
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0004C000 File Offset: 0x00049600
		public CommandHandler(IntPtr ptr)
		{
			uint num;
			do
			{
				num = 1692742925U;
				base..ctor(ptr);
			}
			while ((643842419U ^ num) == 0U);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0004C028 File Offset: 0x00049628
		public CommandHandler()
		{
			uint num = 385568060U;
			base..ctor(ClassInjector.DerivedConstructorPointer<CommandHandler>());
			num = 1008303028U / num;
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0004C054 File Offset: 0x00049654
		public static void Init()
		{
			uint num = 1809997155U;
			if (431779456U > num)
			{
				goto IL_37;
			}
			GameObject gameObject2;
			do
			{
				IL_11:
				string text = "ML_Manager";
				num = 2048271232U % num;
				GameObject gameObject = GameObject.Find(text);
				num <<= 23;
				gameObject2 = gameObject;
			}
			while (1179454766U == num);
			do
			{
				IL_37:
				bool flag = gameObject2 == null;
				num <<= 11;
				if (flag)
				{
					if ((1611996555U & num) == 0U)
					{
						string text2 = "ML_Manager";
						num = 1842748457U - num;
						gameObject2 = new GameObject(text2);
						num &= 2002483212U;
					}
					Object @object = gameObject2;
					num *= 1106581167U;
					Object.DontDestroyOnLoad(@object);
					num ^= 1490492792U;
				}
				if (num - 1560439018U == 0U)
				{
					goto IL_11;
				}
				GameObject gameObject3 = gameObject2;
				num ^= 206322328U;
				Object component = gameObject3.GetComponent<CommandHandler>();
				num /= 1242576464U;
				bool flag2 = component == null;
				num <<= 1;
				if (!flag2)
				{
					return;
				}
			}
			while (794908484U - num == 0U);
			GameObject gameObject4 = gameObject2;
			num = 92744434U + num;
			CommandHandler.instance = gameObject4.AddComponent<CommandHandler>();
			num += 4202222862U;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0004C148 File Offset: 0x00049748
		public void Update()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0004C158 File Offset: 0x00049758
		public static bool HandleMessage(string message)
		{
			uint num = 670567931U;
			string[] array2;
			for (;;)
			{
				IL_06:
				string[] array = new string[num ^ 670567929U];
				num = (1396516834U | num);
				int num2 = (int)(num ^ 2013081595U);
				num = 719614900U * num;
				string text = "\n";
				num = 797403109U << (int)num;
				array[num2] = text;
				num /= 1071460559U;
				num *= 2094203949U;
				int num3 = (int)(num ^ 2094203948U);
				num = 1040860063U * num;
				string text2 = "\r\n";
				num >>= 8;
				array[num3] = text2;
				num = (675030959U & num);
				array2 = message.Split(array, (StringSplitOptions)(num - 1057037U));
				num &= 838748777U;
				if (num << 25 != 0U)
				{
					string text3;
					uint num5;
					for (;;)
					{
						IL_96:
						string[] array3 = array2;
						num = 456936945U * num;
						if (array3.Length == 0)
						{
							goto IL_A5;
						}
						for (;;)
						{
							IL_BF:
							num >>= 12;
							string[] array4 = array2;
							int num4 = (int)(num - 757542U);
							num %= 563879178U;
							text3 = array4[num4];
							if (num > 680801751U)
							{
								goto IL_06;
							}
							for (;;)
							{
								IL_E4:
								MelonLogger.Msg("正在处理command: " + message);
								num5 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								uint num6 = num5;
								uint num7 = num + 2159315241U;
								num <<= 28;
								if (num6 <= num7)
								{
									while (num5 > (num ^ 556951233U))
									{
										num = 1038827300U - num;
										uint num8 = num5;
										uint num9 = num + 2076106803U;
										num = 1475949910U * num;
										if (num8 <= num9)
										{
											num >>= 21;
											if (num > 81944119U)
											{
												goto IL_06;
											}
											if (num5 == (num ^ 1249468069U))
											{
												goto IL_744;
											}
											num = 133117552U % num;
											uint num10 = num5;
											num = 1509892474U + num;
											uint num11 = num ^ 5586149U;
											num %= 353852733U;
											if (num10 != num11)
											{
												goto Block_13;
											}
											if (1912952512U < num)
											{
												goto IL_B7;
											}
											if (!(text3 == "RemoteEat"))
											{
												goto Block_67;
											}
											num = (1456156481U & num);
											if (num >= 1043872462U)
											{
												goto IL_A5;
											}
											MelonLogger.Msg("command命中: RemoteEat()");
											num = (1956793177U ^ num);
											CommandHandler.RemoteEat();
											if (801442360U <= num)
											{
												goto Block_102;
											}
										}
										else
										{
											if (959081998U > num)
											{
												goto IL_06;
											}
											uint num12 = num5;
											num = 99310870U * num;
											if (num12 == num - 3540706655U)
											{
												goto IL_4DC;
											}
											uint num13 = num5;
											num = 333217052U - num;
											if (num13 != (num ^ 1421688643U))
											{
												goto Block_17;
											}
											string a = text3;
											num = 1944745231U >> (int)num;
											if (!(a == "Suicide"))
											{
												goto Block_53;
											}
											MelonLogger.Msg("command命中: Suicide()");
											if (num % 1739160234U != 0U)
											{
												goto Block_89;
											}
											goto IL_E4;
										}
									}
									goto Block_1;
								}
								num = 913516386U >> (int)num;
								if (num >= 2082038789U)
								{
									goto IL_B7;
								}
								if (num5 > (num ^ 2424426243U))
								{
									goto IL_3A9;
								}
								num %= 1280130873U;
								if (num > 1258690726U)
								{
									goto IL_96;
								}
								if (num5 > num - 2881074029U)
								{
									goto IL_357;
								}
								num = 803933399U >> (int)num;
								if (num * 660171165U == 0U)
								{
									goto IL_BF;
								}
								uint num14 = num5;
								num >>= 27;
								uint num15 = num ^ 2257753805U;
								num *= 319966485U;
								if (num14 == num15)
								{
									goto IL_51E;
								}
								if ((num ^ 1692026616U) == 0U)
								{
									goto IL_96;
								}
								uint num16 = num5;
								num >>= 14;
								if (num16 != num + 2327390124U)
								{
									goto Block_26;
								}
								bool flag = text3 == "BindHookToSendFart";
								num = (1157194835U ^ num);
								if (!flag)
								{
									goto Block_40;
								}
								MelonLogger.Msg("command命中: BindHookToSendFart(System.Action action)");
								CommandHandler.BindHookToSendFart(array2);
								if ((1881491289U ^ num) != 0U)
								{
									goto Block_77;
								}
							}
							Block_17:
							if ((1260474231U & num) != 0U)
							{
								goto Block_18;
							}
							continue;
							IL_3A9:
							num |= 79523332U;
							uint num17 = num5;
							uint num18 = num - 2063790164U;
							num |= 6950249U;
							if (num17 > num18)
							{
								break;
							}
							num = (978741480U & num);
							if (575171059U != num)
							{
								uint num19 = num5;
								num = 2115000632U * num;
								uint num20 = num ^ 1757239413U;
								num <<= 8;
								if (num19 == num20)
								{
									goto IL_769;
								}
								if (967735490U + num == 0U)
								{
									goto IL_B7;
								}
								if (num5 != num - 4144120046U)
								{
									goto Block_35;
								}
								num *= 1167987036U;
								if (num <= 1573140186U)
								{
									goto IL_06;
								}
								bool flag2 = text3 == "UpdateTempUserUnlockables";
								num = 921896885U >> (int)num;
								if (!flag2)
								{
									goto Block_61;
								}
								string text4 = "command命中: UpdateTempUserUnlockables()";
								num = 1976254842U >> (int)num;
								MelonLogger.Msg(text4);
								if (412625728U % num == 0U)
								{
									goto IL_06;
								}
								CommandHandler.UpdateTempUserUnlockables();
								if (1911882201U >= num)
								{
									goto Block_96;
								}
							}
						}
						num %= 1483816407U;
						uint num21 = num5;
						uint num22 = num ^ 4028804191U;
						num %= 2013859071U;
						if (num21 != num22)
						{
							if ((num ^ 1901599968U) != 0U)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							if (2036551266U == num)
							{
								goto IL_06;
							}
							if (!(text3 == "SendFart"))
							{
								goto Block_42;
							}
							num = 2101442302U % num;
							if (1936198697U - num == 0U)
							{
								goto IL_06;
							}
							string text5 = "command命中: SendFart()";
							num = 1569736534U / num;
							MelonLogger.Msg(text5);
							num ^= 316212807U;
							if (num != 1395880181U)
							{
								goto Block_79;
							}
							continue;
						}
						Block_53:
						if (2080393321 << (int)num != 0)
						{
							goto Block_54;
						}
						continue;
						Block_1:
						if (num5 <= (num ^ 1410747732U))
						{
							num <<= 18;
							uint num23 = num5;
							num >>= 20;
							uint num24 = num ^ 293666899U;
							num = (531125059U ^ num);
							if (num23 != num24)
							{
								num -= 791248344U;
								uint num25 = num5;
								num <<= 1;
								if (num25 != num - 2900843906U)
								{
									goto Block_4;
								}
								num = (706879839U ^ num);
								if (num >> 7 == 0U)
								{
									goto IL_A5;
								}
								string a2 = text3;
								num *= 140196788U;
								string b = "PickUpAllBodies";
								num >>= 10;
								bool flag3 = a2 == b;
								num *= 1347307370U;
								if (!flag3)
								{
									goto Block_64;
								}
								if ((num & 415379396U) == 0U)
								{
									goto IL_06;
								}
								string text6 = "command命中: PickUpAllBodies()";
								num >>= 21;
								MelonLogger.Msg(text6);
								num = 761555705U << (int)num;
								if (num <= 1981361707U)
								{
									goto IL_06;
								}
								CommandHandler.PickUpAllBodies();
								if ((num & 277880106U) != 0U)
								{
									goto Block_100;
								}
								continue;
							}
							else
							{
								if (1570641381U <= num)
								{
									goto IL_B7;
								}
								string a3 = text3;
								num = 1989431502U - num;
								string b2 = "RemoteKill";
								num >>= 16;
								bool flag4 = a3 == b2;
								num = (939535257U | num);
								if (!flag4)
								{
									goto Block_56;
								}
								num = (700324766U & num);
								if ((2122602510U & num) == 0U)
								{
									goto IL_B7;
								}
								MelonLogger.Msg("command命中: RemoteKill(string userId)");
								if (1186988655U % num != 0U)
								{
									goto Block_91;
								}
								continue;
							}
						}
						else
						{
							num = 1683889228U << (int)num;
							if (num + 629043752U == 0U)
							{
								goto IL_06;
							}
							if (num5 == num - 693810118U)
							{
								goto IL_796;
							}
							if ((1842950496U ^ num) == 0U)
							{
								goto IL_06;
							}
							uint num26 = num5;
							num <<= 9;
							if (num26 != (num ^ 4245356225U))
							{
								goto Block_8;
							}
							if (num <= 1320440793U)
							{
								continue;
							}
							string a4 = text3;
							string b3 = "SilencePlayer";
							num = 263127330U * num;
							bool flag5 = a4 == b3;
							num /= 902966271U;
							if (!flag5)
							{
								goto Block_72;
							}
							num &= 1523272293U;
							if (num > 1832205988U)
							{
								goto IL_06;
							}
							MelonLogger.Msg("command命中: SilencePlayer(string userId)");
							num = (1047742459U | num);
							if (num > 23404298U)
							{
								goto Block_108;
							}
							continue;
						}
						IL_4DC:
						if ((599801282U & num) == 0U)
						{
							goto IL_06;
						}
						bool flag6 = text3 == "SendChat";
						num = 890374736U << (int)num;
						if (!flag6)
						{
							goto Block_45;
						}
						num &= 934572402U;
						if (num == 58877012U)
						{
							continue;
						}
						string text7 = "command命中: SendChat(string message)";
						num = 2047024225U - num;
						MelonLogger.Msg(text7);
						num = (1980519227U & num);
						if (num >> 8 == 0U)
						{
							goto IL_06;
						}
						string[] strings = array2;
						num ^= 1771458771U;
						CommandHandler.SendChat(strings);
						if (num - 1380799018U != 0U)
						{
							goto Block_83;
						}
						continue;
						IL_51E:
						if ((117467429U ^ num) == 0U)
						{
							goto IL_06;
						}
						bool flag7 = text3 == "ShowAllPlayersArrow";
						num = 1621232632U % num;
						if (!flag7)
						{
							goto Block_48;
						}
						num %= 2092961013U;
						if (num * 953434590U != 0U)
						{
							goto Block_84;
						}
						continue;
						IL_357:
						uint num27 = num5;
						uint num28 = num + 1708431736U;
						num |= 2063597958U;
						if (num27 == num28)
						{
							goto IL_695;
						}
						num -= 1505704492U;
						uint num29 = num5;
						num = (1805733854U & num);
						uint num30 = num ^ 2270406139U;
						num &= 1257394226U;
						if (num29 != num30)
						{
							goto Block_29;
						}
						if (61364406U <= num)
						{
							goto IL_A5;
						}
						string a5 = text3;
						num = 982931865U / num;
						string b4 = "MoveShuttle";
						num = (541142247U ^ num);
						bool flag8 = a5 == b4;
						num = 1442914166U * num;
						if (!flag8)
						{
							goto Block_51;
						}
						if (1243769149U > num)
						{
							goto IL_B7;
						}
						MelonLogger.Msg("command命中: MoveShuttle()");
						if (391193860U != num)
						{
							goto Block_87;
						}
						continue;
						IL_744:
						string a6 = text3;
						num = 137506886U / num;
						if (!(a6 == "ThrowAwayBomb"))
						{
							goto Block_68;
						}
						num -= 1824807694U;
						if (num <= 412024910U)
						{
							goto IL_06;
						}
						MelonLogger.Msg("command命中: ThrowAwayBomb()");
						num += 260331843U;
						if (num - 780536550U != 0U)
						{
							goto Block_104;
						}
						continue;
						IL_769:
						string a7 = text3;
						string b5 = "StartGame";
						num >>= 13;
						bool flag9 = a7 == b5;
						num -= 1697732325U;
						if (!flag9)
						{
							goto Block_69;
						}
						MelonLogger.Msg("command命中: StartGame()");
						CommandHandler.StartGame();
						if (num * 424357419U != 0U)
						{
							goto Block_105;
						}
					}
					Block_13:
					if (num < 1746623702U)
					{
						num ^= 3848012904U;
						goto IL_C8B;
					}
					continue;
					Block_26:
					if (1383858668 << (int)num != 0)
					{
						num ^= 3774736031U;
						goto IL_C8B;
					}
					continue;
					Block_29:
					if (1568371702U > num)
					{
						num ^= 3764251332U;
						goto IL_C8B;
					}
					continue;
					Block_42:
					if (2064075213U > num)
					{
						num ^= 3590505913U;
						goto IL_C8B;
					}
					continue;
					Block_37:
					uint num31 = num5;
					num = (574580483U ^ num);
					if (num31 != (num ^ 3396182404U))
					{
						uint num32 = num5;
						num ^= 682978648U;
						uint num33 = num + 3254158341U;
						num |= 1120555457U;
						if (num32 != num33)
						{
							num += 1644049633U;
							goto IL_C8B;
						}
						if (1923684077U * num == 0U)
						{
							continue;
						}
						if (!(text3 == "TestConnection"))
						{
							if ((168169557U & num) != 0U)
							{
								num += 1644049633U;
								goto IL_C8B;
							}
							continue;
						}
						else
						{
							if (363539043U < num)
							{
								goto Block_109;
							}
							continue;
						}
					}
					else if (!(text3 == "UnlockAllItems"))
					{
						if ((41831844U ^ num) != 0U)
						{
							num += 3426591338U;
							goto IL_C8B;
						}
						continue;
					}
					else
					{
						string text8 = "command命中: UnlockAllItems()";
						num ^= 402408008U;
						MelonLogger.Msg(text8);
						if (553742668U <= num)
						{
							continue;
						}
						CommandHandler.UnlockAllItems_();
						if ((num & 762145549U) != 0U)
						{
							goto Block_94;
						}
						continue;
					}
					Block_64:
					if (num < 679870473U)
					{
						num += 3715693960U;
						goto IL_C8B;
					}
					continue;
					Block_72:
					if (2002987090U >> (int)num != 0U)
					{
						num ^= 3774720726U;
						goto IL_C8B;
					}
					continue;
					Block_79:
					CommandHandler.SendFart();
					if (num < 2120953491U)
					{
						goto Block_80;
					}
					continue;
					Block_84:
					MelonLogger.Msg("command命中: ShowAllPlayersArrow()");
					num *= 1769020352U;
					CommandHandler.ShowAllPlayersArrow();
					if (num <= 968890870U)
					{
						goto Block_85;
					}
					continue;
					Block_87:
					CommandHandler.MoveShuttle();
					if ((num & 765674777U) != 0U)
					{
						goto Block_88;
					}
					continue;
					Block_91:
					string[] strings2 = array2;
					num = 1452568542U << (int)num;
					CommandHandler.RemoteKill(strings2);
					if ((1279006497U ^ num) != 0U)
					{
						goto Block_92;
					}
					continue;
					IL_695:
					string a8 = text3;
					string b6 = "RingBell";
					num = 698228356U % num;
					bool flag10 = a8 == b6;
					num = 1804668191U << (int)num;
					if (!flag10)
					{
						num ^= 1508735782U;
						goto IL_C8B;
					}
					num = 2118386423U + num;
					if (952634693U >= num)
					{
						goto Block_97;
					}
					continue;
					IL_796:
					num = (1068198710U | num);
					string a9 = text3;
					num = (2035358123U ^ num);
					bool flag11 = a9 == "Flip";
					num = (1258369487U & num);
					if (!flag11)
					{
						num ^= 3808266771U;
					}
					else
					{
						num += 783104522U;
						string text9 = "command命中：Flip()";
						num = (1789876598U & num);
						MelonLogger.Msg(text9);
						num = 549867080U << (int)num;
						CommandHandler.Flip();
						if (1473541931U > num)
						{
							goto Block_106;
						}
						continue;
					}
					IL_C8B:
					num = 991777612U << (int)num;
					if (405096435U / num == 0U)
					{
						goto Block_110;
					}
					continue;
					Block_69:
					num ^= 2049567687U;
					goto IL_C8B;
					Block_68:
					num ^= 3774646398U;
					goto IL_C8B;
					Block_67:
					num ^= 3848012904U;
					goto IL_C8B;
					Block_61:
					num ^= 3591286115U;
					goto IL_C8B;
					Block_56:
					if (1187938162U > num)
					{
						num ^= 3640513837U;
						goto IL_C8B;
					}
					break;
					Block_54:
					num ^= 3774518385U;
					goto IL_C8B;
					Block_51:
					if (num - 367729953U != 0U)
					{
						num ^= 2345830762U;
						goto IL_C8B;
					}
					break;
					Block_48:
					if (num != 1493969472U)
					{
						num ^= 3787137113U;
						goto IL_C8B;
					}
					break;
					Block_45:
					if (num < 1158626279U)
					{
						num ^= 3937250006U;
						goto IL_C8B;
					}
					break;
					Block_40:
					num ^= 2751759052U;
					goto IL_C8B;
					Block_35:
					num ^= 1375955670U;
					goto IL_C8B;
					Block_18:
					num ^= 880840154U;
					goto IL_C8B;
					Block_8:
					if (1206526206U % num == 0U)
					{
						break;
					}
					num += 616895190U;
					Block_4:
					goto IL_C8B;
				}
				break;
			}
			IL_A5:
			string text10 = "收到的指令为空！";
			num += 310935335U;
			MelonLogger.Warning(text10);
			IL_B7:
			return (num ^ 3413831342U) != 0U;
			Block_77:
			goto IL_CB7;
			Block_80:
			num += 840966617U;
			goto IL_CB7;
			Block_83:
			num ^= 1534028008U;
			goto IL_CB7;
			Block_85:
			num += 257239002U;
			goto IL_CB7;
			Block_88:
			num += 3653895262U;
			goto IL_CB7;
			Block_89:
			CommandHandler.Suicide();
			num ^= 1157502653U;
			goto IL_CB7;
			Block_92:
			num ^= 1022961690U;
			goto IL_CB7;
			Block_94:
			num ^= 1204118078U;
			goto IL_CB7;
			Block_96:
			num ^= 1157180340U;
			goto IL_CB7;
			Block_97:
			string text11 = "command命中: RingBell()";
			num = 1139867889U % num;
			MelonLogger.Msg(text11);
			num -= 1755996275U;
			CommandHandler.RingBell();
			num += 2701614211U;
			goto IL_CB7;
			Block_100:
			num ^= 3573098522U;
			goto IL_CB7;
			Block_102:
			num ^= 886721859U;
			goto IL_CB7;
			Block_104:
			CommandHandler.ThrowAwayBomb();
			num += 2721580861U;
			goto IL_CB7;
			Block_105:
			num ^= 3727517963U;
			goto IL_CB7;
			Block_106:
			num += 325424666U;
			goto IL_CB7;
			Block_108:
			CommandHandler.SilencePlayer(array2);
			num ^= 2055892961U;
			goto IL_CB7;
			Block_109:
			MelonLogger.Msg("测试TCP服务器连接成功");
			num = 632977655U / num;
			return num + 1U != 0U;
			Block_110:
			MelonLogger.Msg("未知command指令");
			return (num ^ 3539992576U) != 0U;
			IL_CB7:
			return num + 3137787879U != 0U;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0004CE24 File Offset: 0x0004A424
		public static void StartGame()
		{
			UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
			Action <>9__6_ = CommandHandler.<>c.<>9__6_0;
			uint num = 1070096312U;
			Action action = <>9__6_;
			num *= 1441556200U;
			if (<>9__6_ == null)
			{
				num = 679901431U % num;
				num ^= 85293548U;
				object <> = CommandHandler.<>c.<>9;
				IntPtr method = ldftn(<StartGame>b__6_0);
				num >>= 26;
				Action action2 = new Action(<>, method);
				num %= 1525036272U;
				action = action2;
				num = (1732843804U & num);
				CommandHandler.<>c.<>9__6_0 = action2;
				num ^= 4183428808U;
			}
			unityMainThreadDispatcher.Enqueue(action);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0004CE9C File Offset: 0x0004A49C
		public static void Flip()
		{
			uint num = 78135538U;
			if (1484608698U + num != 0U)
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				num = 2125414813U + num;
				Action action;
				bool flag = (action = CommandHandler.<>c.<>9__7_0) != null;
				num /= 6496275U;
				if (!flag)
				{
					num = 1875732414U % num;
					num = 1113543414U << (int)num;
					object <> = CommandHandler.<>c.<>9;
					num = 23546956U << (int)num;
					Action action2 = delegate()
					{
						RPC.Flip();
					};
					num &= 437405721U;
					action = action2;
					CommandHandler.<>c.<>9__7_0 = action2;
					num ^= 149851U;
				}
				num *= 1508650820U;
				unityMainThreadDispatcher.Enqueue(action);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0004CF34 File Offset: 0x0004A534
		public static void ThrowAwayBomb()
		{
			uint num;
			do
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				Action action;
				if ((action = CommandHandler.<>c.<>9__8_0) == null)
				{
					num = 4935853U;
					object <> = CommandHandler.<>c.<>9;
					num += 1904821589U;
					IntPtr method = ldftn(<ThrowAwayBomb>b__8_0);
					num = 1523864328U * num;
					Action action2 = new Action(<>, method);
					num = (424035786U ^ num);
					action = action2;
					num &= 1593589190U;
					CommandHandler.<>c.<>9__8_0 = action2;
				}
				num = 636752767U;
				unityMainThreadDispatcher.Enqueue(action);
			}
			while ((num & 1653751881U) == 0U);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0004CFA8 File Offset: 0x0004A5A8
		public static void RemoteEat()
		{
			uint num = 1564281286U;
			do
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				num *= 165114150U;
				Action <>9__9_ = CommandHandler.<>c.<>9__9_0;
				num ^= 1067611666U;
				Action action = <>9__9_;
				if (<>9__9_ == null)
				{
					num %= 21701055U;
					Action action2 = delegate()
					{
						uint num2 = 793461283U;
						do
						{
							GGD_Hack.Features.RemoteEat.EatRandomBody();
						}
						while (595139228U > num2);
					};
					num = 1174689586U - num;
					action = action2;
					CommandHandler.<>c.<>9__9_0 = action2;
					num += 2264880535U;
				}
				unityMainThreadDispatcher.Enqueue(action);
			}
			while (num >> 0 == 0U);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0004D01C File Offset: 0x0004A61C
		private static void PickUpAllBodies()
		{
			uint num;
			do
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				Action <>9__10_ = CommandHandler.<>c.<>9__10_0;
				num = 1725908477U;
				Action action = <>9__10_;
				if (<>9__10_ == null)
				{
					num |= 400840793U;
					num = 1299191818U % num;
					object <> = CommandHandler.<>c.<>9;
					num = 1390349044U % num;
					IntPtr method = ldftn(<PickUpAllBodies>b__10_0);
					num = 2100577424U % num;
					Action action2 = new Action(<>, method);
					num = 683037322U >> (int)num;
					action = action2;
					CommandHandler.<>c.<>9__10_0 = action2;
					num ^= 1725261929U;
				}
				unityMainThreadDispatcher.Enqueue(action);
			}
			while ((num ^ 273503533U) == 0U);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0004D0A0 File Offset: 0x0004A6A0
		private static void RingBell()
		{
			uint num = 1696103046U;
			do
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				num -= 1167545601U;
				Action <>9__11_ = CommandHandler.<>c.<>9__11_0;
				num = (1588082811U & num);
				Action action = <>9__11_;
				if (<>9__11_ == null)
				{
					num |= 1581395291U;
					object <> = CommandHandler.<>c.<>9;
					num = (1004540214U ^ num);
					Action action2 = delegate()
					{
						PluginEventsManager.RingBell();
					};
					num <<= 8;
					action = action2;
					num = (1445543788U ^ num);
					CommandHandler.<>c.<>9__11_0 = action2;
					num += 2859126165U;
				}
				unityMainThreadDispatcher.Enqueue(action);
			}
			while (num >= 1683248775U);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0004D124 File Offset: 0x0004A724
		private static void SilencePlayer(string[] lines)
		{
			for (;;)
			{
				IL_00:
				CommandHandler.<>c__DisplayClass12_0 CS$<>8__locals1 = new CommandHandler.<>c__DisplayClass12_0();
				uint num = 1008022101U;
				for (;;)
				{
					num /= 1018172153U;
					int num2 = lines.Length;
					num &= 123895061U;
					int num3 = num2;
					uint num4 = num - 4294967294U;
					num = (355345259U | num);
					if (num3 < num4)
					{
						num ^= 659372457U;
						if (num > 905341681U)
						{
							return;
						}
						string text = "SilencePlayer参数过少！";
						num -= 127665068U;
						MelonLogger.Warning(text);
						if (num != 594820944U)
						{
							return;
						}
					}
					else
					{
						while (1364353320U >= num)
						{
							CommandHandler.<>c__DisplayClass12_0 CS$<>8__locals2 = CS$<>8__locals1;
							num ^= 1435203415U;
							CS$<>8__locals2.targetUserId = null;
							num -= 231033995U;
							int num5 = lines.Length;
							num = (1836517103U ^ num);
							uint num6 = num ^ 1603731804U;
							num -= 485375381U;
							if (num5 != num6)
							{
								goto IL_E8;
							}
							num = 229797415U >> (int)num;
							CommandHandler.<>c__DisplayClass12_0 CS$<>8__locals3 = CS$<>8__locals1;
							num = (1310672400U | num);
							string targetUserId = lines[(int)(num + 2984255690U)];
							num = 1139552712U >> (int)num;
							CS$<>8__locals3.targetUserId = targetUserId;
							if (646263656U < num || num >= 1030037399U)
							{
								goto IL_00;
							}
							UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
							num >>= 25;
							object @object = CS$<>8__locals1;
							IntPtr method = ldftn(<SilencePlayer>b__0);
							num = 557322941U + num;
							unityMainThreadDispatcher.Enqueue(new Action(@object, method));
							if ((num ^ 1188899195U) != 0U)
							{
								return;
							}
						}
					}
				}
				IL_E8:
				num = 468653066U % num;
				if (num + 785541398U != 0U)
				{
					string text2 = "SilencePlayer参数过多！";
					num |= 1617169317U;
					MelonLogger.Warning(text2);
					if ((num ^ 251689871U) != 0U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0004D28C File Offset: 0x0004A88C
		private static void UpdateTempUserUnlockables()
		{
			uint num = 162595420U;
			UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
			Action <>9__13_ = CommandHandler.<>c.<>9__13_0;
			num += 1234646218U;
			Action action = <>9__13_;
			num = 1145252070U << (int)num;
			if (<>9__13_ == null)
			{
				num -= 1744388147U;
				num -= 2131510337U;
				object <> = CommandHandler.<>c.<>9;
				num >>= 4;
				IntPtr method = ldftn(<UpdateTempUserUnlockables>b__13_0);
				num = 1124602195U / num;
				Action action2 = new Action(<>, method);
				num += 1687575914U;
				action = action2;
				num <<= 9;
				CommandHandler.<>c.<>9__13_0 = action2;
				num += 3826201472U;
			}
			unityMainThreadDispatcher.Enqueue(action);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0004D31C File Offset: 0x0004A91C
		private static void UnlockAllItems_()
		{
			uint num;
			do
			{
				MelonPreferences_Entry<bool> enabled = ShowAllUnlockables.Enabled;
				bool value = true;
				num = 1901584U;
				enabled.Value = value;
			}
			while (461641963U == num);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0004D348 File Offset: 0x0004A948
		private static void RemoteKill(string[] strings)
		{
			uint num;
			CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals2;
			for (;;)
			{
				IL_00:
				CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals1 = new CommandHandler.<>c__DisplayClass15_0();
				num = 827597336U;
				CS$<>8__locals2 = CS$<>8__locals1;
				num = (133395514U & num);
				if (1932800957U > num)
				{
					int num2 = strings.Length;
					num *= 1360879269U;
					uint num3 = num ^ 2133163898U;
					num <<= 29;
					if (num2 < num3 && 492992345U >= num)
					{
						break;
					}
					for (;;)
					{
						num = 979373911U + num;
						CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals3 = CS$<>8__locals2;
						num |= 2009889474U;
						CS$<>8__locals3.targetUserId = null;
						num = 265181619U / num;
						if (1219640883 << (int)num == 0)
						{
							goto IL_00;
						}
						int num5;
						for (;;)
						{
							CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals4 = CS$<>8__locals2;
							num %= 23218123U;
							CS$<>8__locals4.killDelay = null;
							num = (855793776U ^ num);
							int num4 = strings.Length;
							num = (1043867989U & num);
							num5 = num4;
							if (855579038U >> (int)num == 0U)
							{
								goto IL_49;
							}
							if (num5 == (int)(num ^ 838869074U))
							{
								goto IL_ED;
							}
							if ((num & 653027435U) != 0U)
							{
								goto Block_4;
							}
						}
						IL_1C8:
						num = 937310667U * num;
						if (num < 1507032314U)
						{
							goto Block_12;
						}
						continue;
						IL_ED:
						num <<= 7;
						if (num >= 150148023U)
						{
							goto IL_00;
						}
						CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals5 = CS$<>8__locals2;
						num *= 1496863822U;
						string targetUserId = strings[(int)(num ^ 302788609U)];
						num = 8913322U / num;
						CS$<>8__locals5.targetUserId = targetUserId;
						if (num <= 108407580U)
						{
							goto IL_1C8;
						}
						goto IL_00;
						Block_4:
						int num6 = num5;
						uint num7 = num + 3456098227U;
						num = (2001285734U | num);
						if (num6 != num7)
						{
							break;
						}
						num = 1254246134U >> (int)num;
						if ((1074423992U ^ num) == 0U)
						{
							goto IL_00;
						}
						CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals6 = CS$<>8__locals2;
						num = 1442137353U + num;
						num -= 1172062983U;
						CS$<>8__locals6.targetUserId = strings[(int)(num ^ 270074668U)];
						num = 1850572789U * num;
						if (num != 758601627U)
						{
							CommandHandler.<>c__DisplayClass15_0 CS$<>8__locals7 = CS$<>8__locals2;
							num += 1265505976U;
							int num8 = (int)(num + 2575666233U);
							num ^= 1352535832U;
							CS$<>8__locals7.killDelay = strings[num8];
							num += 3374023471U;
							goto IL_1C8;
						}
						goto IL_00;
					}
					if (1857319182U != num)
					{
						MelonLogger.Warning("RemoteKill参数过多！");
						if (1457201055U != num)
						{
							return;
						}
					}
				}
			}
			IL_49:
			MelonLogger.Warning("RemoteKill参数过少！");
			return;
			Block_12:
			UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
			num >>= 25;
			object @object = CS$<>8__locals2;
			IntPtr method = ldftn(<RemoteKill>b__0);
			num >>= 27;
			unityMainThreadDispatcher.Enqueue(new Action(@object, method));
			if (793786810U >= num)
			{
				return;
			}
			goto IL_49;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0004D564 File Offset: 0x0004AB64
		public static void Suicide()
		{
			uint num = 1562669331U;
			UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
			Action action;
			bool flag = (action = CommandHandler.<>c.<>9__16_0) != null;
			num = 2094882492U - num;
			if (!flag)
			{
				num <<= 2;
				Action action2 = delegate()
				{
					uint num2 = 69341029U;
					do
					{
						MiscFunctions.Suicide();
					}
					while (1612459573U + num2 == 0U);
				};
				num = 2047084704U * num;
				action = action2;
				num >>= 11;
				CommandHandler.<>c.<>9__16_0 = action2;
				num ^= 531971905U;
			}
			unityMainThreadDispatcher.Enqueue(action);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0004D5CC File Offset: 0x0004ABCC
		public static void BindHookToSendFart(string[] strings)
		{
			uint num;
			Action action2;
			for (;;)
			{
				num = 892489923U;
				if (strings.Length < (int)(num ^ 892489921U))
				{
					MelonLogger.Warning("BindHook参数过少！");
					if ((872431238U ^ num) != 0U)
					{
						break;
					}
					goto IL_EB;
				}
				IL_2C:
				if (1934498989U == num)
				{
					continue;
				}
				string separator = "\n";
				num |= 1653757643U;
				num = 718372106U - num;
				int count = (int)(num ^ 3005163070U);
				num ^= 732438695U;
				IEnumerable<string> values = strings.Skip(count);
				num &= 1244859596U;
				string a = string.Join(separator, values);
				num /= 1293056023U;
				Action action = null;
				num *= 854262041U;
				action2 = action;
				num = 417757914U << (int)num;
				string b = "MoveShuttle";
				num &= 825231699U;
				Action action3;
				if (a == b)
				{
					num = 876374592U / num;
					if (num >> 18 != 0U)
					{
						continue;
					}
					Action <>9__17_ = CommandHandler.<>c.<>9__17_0;
					num = (1839205957U | num);
					action3 = <>9__17_;
					num = 1867463432U << (int)num;
					if (<>9__17_ == null)
					{
						num /= 1029984810U;
						num >>= 21;
						goto IL_EB;
					}
					goto IL_109;
				}
				else
				{
					string text = "未知Action name!";
					num = 333674165U - num;
					MelonLogger.Warning(text);
					num ^= 151786991U;
				}
				IL_13C:
				num ^= 1441410534U;
				if (num < 2110333253U)
				{
					goto Block_7;
				}
				continue;
				IL_109:
				num %= 438458046U;
				action2 = action3;
				if (1368857822U > num)
				{
					goto IL_13C;
				}
				goto IL_2C;
				IL_EB:
				action3 = (CommandHandler.<>c.<>9__17_0 = delegate()
				{
					uint num2 = 1269376445U;
					do
					{
						UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
						Action <>9__17_2 = CommandHandler.<>c.<>9__17_1;
						num2 = 439553092U % num2;
						Action action5 = <>9__17_2;
						num2 = 6750762U - num2;
						if (<>9__17_2 == null)
						{
							num2 <<= 27;
							object <> = CommandHandler.<>c.<>9;
							IntPtr method = ldftn(<BindHookToSendFart>b__17_1);
							num2 <<= 1;
							Action action6 = new Action(<>, method);
							num2 = 1261575096U * num2;
							action5 = action6;
							CommandHandler.<>c.<>9__17_1 = action6;
							num2 += 3862164966U;
						}
						unityMainThreadDispatcher.Enqueue(action5);
					}
					while (num2 == 992687001U);
				});
				num ^= 2812118016U;
				goto IL_109;
			}
			return;
			Block_7:
			Action action4 = action2;
			num <<= 6;
			SendFartHook.bindAction(action4);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0004D738 File Offset: 0x0004AD38
		public static void MoveShuttle()
		{
			uint num = 1043086740U;
			UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
			num = 1210395129U / num;
			Action <>9__18_ = CommandHandler.<>c.<>9__18_0;
			num ^= 539256041U;
			Action action = <>9__18_;
			num = 390674715U - num;
			if (<>9__18_ == null)
			{
				num = 618096168U / num;
				object <> = CommandHandler.<>c.<>9;
				IntPtr method = ldftn(<MoveShuttle>b__18_0);
				num &= 1001851907U;
				Action action2 = new Action(<>, method);
				num = 911631069U + num;
				action = action2;
				num = 909521543U >> (int)num;
				CommandHandler.<>c.<>9__18_0 = action2;
				num += 4146385970U;
			}
			unityMainThreadDispatcher.Enqueue(action);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0004D7C0 File Offset: 0x0004ADC0
		public static void ShowAllPlayersArrow()
		{
			uint num = 772411508U;
			if (1836984989U >= num)
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				num /= 982059435U;
				Action <>9__19_ = CommandHandler.<>c.<>9__19_0;
				num = (1432693130U & num);
				Action action = <>9__19_;
				if (<>9__19_ == null)
				{
					object <> = CommandHandler.<>c.<>9;
					num |= 221992315U;
					IntPtr method = ldftn(<ShowAllPlayersArrow>b__19_0);
					num >>= 26;
					Action action2 = new Action(<>, method);
					num %= 1943345330U;
					action = action2;
					CommandHandler.<>c.<>9__19_0 = action2;
					num += 4294967293U;
				}
				num = (800400562U | num);
				unityMainThreadDispatcher.Enqueue(action);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0004D844 File Offset: 0x0004AE44
		public static void SendChat(string message)
		{
			uint num = 1379416323U;
			for (;;)
			{
				CommandHandler.<>c__DisplayClass20_0 CS$<>8__locals1 = new CommandHandler.<>c__DisplayClass20_0();
				num = 1257666254U / num;
				CommandHandler.<>c__DisplayClass20_0 CS$<>8__locals2 = CS$<>8__locals1;
				CS$<>8__locals2.message = message;
				if ((num ^ 1337525601U) == 0U)
				{
					goto IL_3A;
				}
				if (CS$<>8__locals2.message == null)
				{
					num = (608463462U | num);
					goto IL_3A;
				}
				IL_54:
				if (1577386265U == num)
				{
					continue;
				}
				UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
				num = 1984982459U - num;
				object @object = CS$<>8__locals2;
				IntPtr method = ldftn(<SendChat>b__0);
				num = 167205205U - num;
				Action action = new Action(@object, method);
				num <<= 18;
				unityMainThreadDispatcher.Enqueue(action);
				if (2068669007U < num)
				{
					break;
				}
				continue;
				IL_3A:
				string text = "聊天消息不能为空!";
				num = 1985233293U * num;
				MelonLogger.Warning(text);
				num ^= 1177190446U;
				goto IL_54;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0004D8EC File Offset: 0x0004AEEC
		public static void SendChat(string[] strings)
		{
			uint num = 2100116889U;
			if (402205765U == num)
			{
				goto IL_33;
			}
			IL_11:
			while (strings.Length < (int)(num ^ 2100116891U))
			{
				num = 1711018083U * num;
				if (num != 1877365570U)
				{
					goto IL_33;
				}
			}
			goto IL_4D;
			IL_33:
			string text = "SendChat参数过少！";
			num = (1677676705U ^ num);
			MelonLogger.Warning(text);
			num ^= 623251219U;
			IL_4D:
			num = 401696330U / num;
			if (num - 304903884U == 0U)
			{
				goto IL_11;
			}
			string separator = "\n";
			num -= 1972515122U;
			num = 697042895U % num;
			string message = string.Join(separator, strings.Skip((int)(num + 3597924402U)));
			num = (1363365438U & num);
			CommandHandler.SendChat(message);
			if ((num ^ 1973823960U) != 0U)
			{
				return;
			}
			goto IL_11;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0004D99C File Offset: 0x0004AF9C
		public static void SendFart()
		{
			uint num = 755658809U;
			do
			{
				LocalPlayer localPlayer = GameInstances.GetLocalPlayer();
				num = 381815087U * num;
				LocalPlayer localPlayer2 = localPlayer;
				num *= 1765495035U;
				Object @object = localPlayer2;
				num = 927676471U % num;
				Object object2 = null;
				num /= 740700616U;
				bool flag = @object != object2;
				num >>= 26;
				if (flag)
				{
					LocalPlayer localPlayer3 = localPlayer2;
					num %= 467077410U;
					string nickname = localPlayer3.Player.nickname;
					num = (991691951U ^ num);
					MelonLogger.Msg(nickname);
					UnityMainThreadDispatcher unityMainThreadDispatcher = UnityMainThreadDispatcher.Instance();
					object object3 = localPlayer2;
					num &= 639532888U;
					IntPtr method = ldftn(SendFart);
					num = 986275259U - num;
					unityMainThreadDispatcher.Enqueue(new Action(object3, method));
					num += 3880953421U;
				}
			}
			while ((1952867210U & num) != 0U);
		}

		// Token: 0x04000002 RID: 2
		private static CommandHandler instance;
	}
}
