using System;
using APIs.Photon;
using ExitGames.Client.Photon;
using GGD_Hack.GameData;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using UnhollowerBaseLib;

namespace GGD_Hack.Events
{
	// Token: 0x0200006A RID: 106
	[HarmonyPatch(typeof(PhotonEventAPI), "OnEvent", new Type[]
	{
		typeof(EventData)
	})]
	internal class PhotonEventAPI_OnEvent
	{
		// Token: 0x060001AB RID: 427 RVA: 0x000603A4 File Offset: 0x0005D9A4
		private static void Postfix(EventData __0)
		{
			try
			{
				uint num;
				do
				{
					IL_00:
					EventDataCode code = (EventDataCode)__0.Code;
					num = 2123635251U;
					num = 91509834U + num;
					ParameterDictionary parameters = __0.Parameters;
					num = 1907105911U * num;
					EventDataCode eventDataCode = code;
					num |= 428287101U;
					if (1602058660U % num == 0U)
					{
						goto IL_67;
					}
					for (;;)
					{
						IL_41:
						uint num2 = (uint)eventDataCode;
						num = (592919197U ^ num);
						if (num2 <= (num ^ 4242589404U))
						{
							if (num * 7894702U != 0U)
							{
								goto IL_67;
							}
						}
						else
						{
							num %= 1009986051U;
							uint num3 = (uint)eventDataCode;
							num &= 287864738U;
							if (num3 <= num - 5684U)
							{
								if (1343969882U % num == 0U)
								{
									goto IL_00;
								}
								EventDataCode eventDataCode2 = eventDataCode;
								uint num4 = num - 5689U;
								num = (444409329U & num);
								if (eventDataCode2 <= num4)
								{
									num = (1147146352U & num);
									if ((num ^ 1691113541U) != 0U)
									{
										EventDataCode eventDataCode3 = eventDataCode;
										uint num5 = num + 66U;
										num = 2003200042U + num;
										num += 1222174653U;
										if (eventDataCode3 == num5)
										{
											goto IL_D12;
										}
										num = 679746291U << (int)num;
										if (568153907U * num == 0U)
										{
											goto IL_67;
										}
										if (eventDataCode != (EventDataCode)(num ^ 1108179401U))
										{
											break;
										}
										num ^= 1112237932U;
										if (1041826052U < num)
										{
											goto IL_00;
										}
										InGameEvents.Celebrity_Died();
										if (45090762U * num != 0U)
										{
											goto Block_54;
										}
									}
								}
								else
								{
									num = (397610218U ^ num);
									if (1845898698U >> (int)num != 0U)
									{
										EventDataCode eventDataCode4 = eventDataCode;
										num += 1545171195U;
										uint num6 = num + 2352187112U;
										num = 1232798922U % num;
										if (eventDataCode4 == num6)
										{
											goto IL_51D;
										}
										EventDataCode eventDataCode5 = eventDataCode;
										num %= 1860855794U;
										uint num7 = num + 3062168452U;
										num &= 1463043220U;
										if (eventDataCode5 != num7)
										{
											goto Block_29;
										}
										num ^= 1381186783U;
										if (num <= 1536164505U)
										{
											goto Block_41;
										}
									}
								}
							}
							else
							{
								num %= 590572347U;
								if (eventDataCode <= (EventDataCode)(num ^ 5860U))
								{
									if (num >> 27 != 0U)
									{
										goto IL_00;
									}
									EventDataCode eventDataCode6 = eventDataCode;
									uint num8 = num ^ 5857U;
									num = 277625662U >> (int)num;
									if (eventDataCode6 == num8)
									{
										goto IL_C34;
									}
									if (261583151U < num)
									{
										goto IL_00;
									}
									EventDataCode eventDataCode7 = eventDataCode;
									num = (532481162U | num);
									uint num9 = num ^ 532614825U;
									num |= 1456209986U;
									if (eventDataCode7 != num9)
									{
										if (981079034U >> (int)num != 0U)
										{
											goto Block_35;
										}
									}
									else
									{
										num -= 1700531450U;
										if (num >> 4 != 0U)
										{
											goto Block_40;
										}
									}
								}
								else
								{
									if (1444812211U - num == 0U)
									{
										goto IL_00;
									}
									uint num10 = (uint)eventDataCode;
									num <<= 20;
									if (num10 == num + 2548039800U)
									{
										goto IL_688;
									}
									num = 1116569446U - num;
									if (540493586U <= num)
									{
										goto Block_38;
									}
								}
							}
						}
					}
					if ((num ^ 1546923982U) != 0U)
					{
						num ^= 2184328807U;
						goto IL_D12;
					}
					continue;
					Block_41:
					ParameterDictionary parameterDictionary = parameters;
					byte b = (byte)(num ^ 325269674U);
					num *= 606564962U;
					Il2CppStringArray il2CppStringArray = parameterDictionary.Get<Il2CppStringArray>(b);
					num /= 422657706U;
					string text = il2CppStringArray[(int)(num ^ 5U)];
					num = 1311903484U - num;
					string text2 = text;
					num &= 1498505130U;
					string playerEaten = il2CppStringArray[(int)(num + 3085955423U)];
					string value = text2;
					num = 1671710996U % num;
					bool flag = string.IsNullOrWhiteSpace(value);
					num = 1446606032U * num;
					if (!flag)
					{
						InGameEvents.Pelican_Eat(playerEaten, text2);
						num += 3723635527U;
						goto IL_D12;
					}
					if (num * 1060851518U != 0U)
					{
						InGameEvents.Pelican_Eat(playerEaten, null);
						num ^= 577923911U;
						goto IL_D12;
					}
					continue;
					IL_51D:
					num /= 1015429168U;
					if (939405604U >> (int)num != 0U)
					{
						ParameterDictionary parameterDictionary2 = parameters;
						num <<= 21;
						Il2CppStringArray il2CppStringArray2 = parameterDictionary2.Get<Il2CppStringArray>((byte)(num - 2096907U));
						num = (1388656969U & num);
						string text3 = il2CppStringArray2[(int)(num - 0U)];
						num -= 682192262U;
						int num11 = (int)(num - 3612775033U);
						num = 1481183582U / num;
						string a = il2CppStringArray2[num11];
						string b2 = "true";
						num |= 652755527U;
						bool flag2 = a == b2;
						num = (442782576U | num);
						bool flag3 = flag2;
						num *= 887578889U;
						string userId = text3;
						bool invisible = flag3;
						num = (811926858U & num);
						InGameEvents.Turn_Invisible(userId, invisible);
						num ^= 4034874349U;
						goto IL_D12;
					}
					continue;
					IL_688:
					num %= 2065369090U;
					ConsoleColor consoleColor = (ConsoleColor)(num - 1746927606U);
					num >>= 5;
					ParameterDictionary parameterDictionary3 = parameters;
					bool flag4 = num - 54591487U != 0U;
					num = 698836236U >> (int)num;
					MelonLogger.Msg(consoleColor, parameterDictionary3.ToStringFull(flag4));
					num = (363617125U | num);
					if (num < 1430476601U)
					{
						Il2CppStringArray il2CppStringArray3 = parameters.Get<Il2CppStringArray>((byte)(num + 3260055944U));
						num |= 1572361579U;
						num = 1647919707U - num;
						int num12 = (int)(num + 461782292U);
						num |= 1225611479U;
						string text4 = il2CppStringArray3[num12];
						num = 305155949U % num;
						string text5 = text4;
						int num13 = (int)(num ^ 305155948U);
						num /= 378751736U;
						string text6 = il2CppStringArray3[num13];
						num &= 498688521U;
						string text7 = text6;
						string userId2 = text5;
						num = (611258330U ^ num);
						string ventId = text7;
						num = 1747006134U - num;
						InGameEvents.ForceExitVent(userId2, ventId);
						num ^= 2207083835U;
						goto IL_D12;
					}
					continue;
					Block_40:
					InGameEvents.Start_Game();
					num ^= 983322162U;
					goto IL_D12;
					Block_38:
					EventDataCode eventDataCode8 = eventDataCode;
					uint num14 = num ^ 3664609156U;
					num += 3855732865U;
					if (eventDataCode8 != num14)
					{
						num += 0U;
						goto IL_D12;
					}
					goto IL_D12;
					Block_35:
					num ^= 2680176936U;
					goto IL_D12;
					Block_29:
					num += 2131708775U;
					goto IL_D12;
					IL_C34:
					num = 1166172328U / num;
					ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 26U);
					ParameterDictionary parameterDictionary4 = parameters;
					num = 1245910661U - num;
					string text8 = parameterDictionary4.ToStringFull(num + 3049056652U != 0U);
					num >>= 10;
					MelonLogger.Msg(consoleColor2, text8);
					if (num + 1325865738U != 0U)
					{
						Il2CppReferenceArray<Il2CppStringArray> il2CppReferenceArray = parameters.Get<Il2CppReferenceArray<Il2CppStringArray>>((byte)(num ^ 1216560U));
						Il2CppStringArray il2CppStringArray4 = il2CppReferenceArray[(int)(num ^ 1216709U)];
						num |= 168363179U;
						Il2CppStringArray userIdArray = il2CppStringArray4;
						num %= 530987997U;
						num = 1013658894U + num;
						int num15 = (int)(num ^ 1183238652U);
						num &= 260857629U;
						Il2CppStringArray il2CppStringArray5 = il2CppReferenceArray[num15];
						num %= 764561648U;
						Il2CppStringArray roleIdArray = il2CppStringArray5;
						num = (417007598U & num);
						Il2CppStringArray il2CppStringArray6 = il2CppReferenceArray[(int)(num - 8388872U)];
						num = 387611288U + num;
						Il2CppStringArray taskIdArray = il2CppStringArray6;
						InGameEvents.Server_Send_Role(userIdArray, roleIdArray, taskIdArray);
						num += 2829374531U;
						goto IL_D12;
					}
					goto IL_67;
					Block_54:
					num ^= 3229176075U;
					goto IL_D12;
					IL_67:
					while (eventDataCode > (EventDataCode)(num ^ 4242589425U))
					{
						if (num <= 1588484601U)
						{
							goto IL_00;
						}
						if (eventDataCode <= (int)num + (EventDataCode)52377933)
						{
							if (2028410241U <= num)
							{
								uint num16 = (uint)eventDataCode;
								num = 305336980U - num;
								if (num16 == num + 3937252451U)
								{
									num = 1812810750U - num;
									ConsoleColor consoleColor3 = (ConsoleColor)(num ^ 1455095878U);
									ParameterDictionary parameterDictionary5 = parameters;
									bool flag5 = num + 2839871413U != 0U;
									num %= 610368230U;
									MelonLogger.Msg(consoleColor3, parameterDictionary5.ToStringFull(flag5));
									num = (1081948441U ^ num);
									Il2CppStringArray il2CppStringArray7 = parameters.Get<Il2CppStringArray>((byte)(num + 2994392412U));
									string text9 = il2CppStringArray7[(int)(num + 2994392167U)];
									int num17 = (int)(num - 1300575128U);
									num %= 157384201U;
									string text10 = il2CppStringArray7[num17];
									num *= 306452981U;
									string to = text10;
									num <<= 14;
									string from = text9;
									num = (227742354U & num);
									InGameEvents.Morph(from, to);
									num ^= 3309195239U;
									goto IL_D12;
								}
								num &= 1843230695U;
								if (num + 1518423431U == 0U)
								{
									goto IL_41;
								}
								EventDataCode eventDataCode9 = eventDataCode;
								uint num18 = num - 89146227U;
								num = (1597073114U | num);
								if (eventDataCode9 != num18)
								{
									num += 1624106989U;
									goto IL_D12;
								}
								num = (378869214U | num);
								ConsoleColor consoleColor4 = (int)num + (ConsoleColor)(-1609922548);
								ParameterDictionary parameterDictionary6 = parameters;
								bool flag6 = num + 2685044739U != 0U;
								num = 1412251205U / num;
								MelonLogger.Msg(consoleColor4, parameterDictionary6.ToStringFull(flag6));
								parameters.Get<Il2CppArrayBase<Object>>((byte)(num ^ 245U));
								num = 40125077U + num;
								num += 1484024721U;
								MelonLogger.Msg((int)num + (ConsoleColor)(-1524149788), "收到炸弹WHISTLEBLOW_BOMB");
								num += 1701224897U;
								goto IL_D12;
							}
						}
						else
						{
							num -= 1755194251U;
							if (num % 1488667606U == 0U)
							{
								goto IL_00;
							}
							EventDataCode eventDataCode10 = eventDataCode;
							num = 1718244050U % num;
							uint num19 = num ^ 1718244073U;
							num = (647908288U | num);
							if (eventDataCode10 != num19)
							{
								if (num <= 954487608U)
								{
									goto IL_00;
								}
								uint num20 = (uint)eventDataCode;
								num = (116531265U & num);
								if (num20 != (num ^ 116523134U))
								{
									if (1993825293U >= num)
									{
										num ^= 3335344039U;
										goto IL_D12;
									}
									goto IL_00;
								}
								else
								{
									num >>= 0;
									ConsoleColor consoleColor5 = (ConsoleColor)(num ^ 116523082U);
									num ^= 1313103858U;
									ParameterDictionary parameterDictionary7 = parameters;
									bool flag7 = num + 3075055695U != 0U;
									num -= 1698715263U;
									string text11 = parameterDictionary7.ToStringFull(flag7);
									num <<= 14;
									MelonLogger.Msg(consoleColor5, text11);
									num >>= 9;
									if (num != 356263455U)
									{
										ParameterDictionary parameterDictionary8 = parameters;
										num = 835784546U + num;
										byte b3 = (byte)(num ^ 840054071U);
										num %= 1741438745U;
										string userId3 = parameterDictionary8.Get<string>(b3);
										MelonLogger.Msg((ConsoleColor)(num ^ 840054216U), "生成炸弹GENERATE_BOMB:");
										num = 211376604U / num;
										InGameEvents.Generate_Bomb(userId3);
										num ^= 3225374695U;
										goto IL_D12;
									}
								}
							}
							else
							{
								ConsoleColor consoleColor6 = (int)num + (ConsoleColor)(-1727945672);
								ParameterDictionary parameterDictionary9 = parameters;
								bool flag8 = num - 1727945681U != 0U;
								num |= 1222859855U;
								string text12 = parameterDictionary9.ToStringFull(flag8);
								num >>= 20;
								MelonLogger.Msg(consoleColor6, text12);
								if (319767353U == num)
								{
									goto IL_00;
								}
								ParameterDictionary parameterDictionary10 = parameters;
								num |= 603590702U;
								byte b4 = (byte)(num + 3691375110U);
								num |= 1196054901U;
								Il2CppStringArray il2CppStringArray8 = parameterDictionary10.Get<Il2CppStringArray>(b4);
								num &= 1588535057U;
								string text13 = il2CppStringArray8[(int)(num ^ 1185554193U)];
								num -= 2114546891U;
								string undertakerUserId = text13;
								num >>= 15;
								int num21 = (int)(num + 4294864576U);
								num = (1180762211U | num);
								string text14 = il2CppStringArray8[num21];
								num /= 486556611U;
								string bodyUserId = text14;
								if (num < 1685064781U)
								{
									InGameEvents.Grab_Body(undertakerUserId, bodyUserId);
									if (1607342548U > num)
									{
										num ^= 3225374693U;
										goto IL_D12;
									}
									goto IL_00;
								}
								else
								{
									IL_D1:
									EventDataCode eventDataCode11 = eventDataCode;
									uint num22 = num ^ 1154091191U;
									num = 84498571U - num;
									if (eventDataCode11 == num22)
									{
										num = 1330262437U + num;
										ConsoleColor consoleColor7 = (ConsoleColor)(num - 260669826U);
										num ^= 1599369070U;
										ParameterDictionary parameterDictionary11 = parameters;
										bool flag9 = (num ^ 1356721891U) != 0U;
										num &= 469858589U;
										string text15 = parameterDictionary11.ToStringFull(flag9);
										num |= 843666368U;
										MelonLogger.Msg(consoleColor7, text15);
										ParameterDictionary parameterDictionary12 = parameters;
										num = 1173503629U * num;
										byte b5 = (byte)(num ^ 972138549U);
										num &= 1791629740U;
										Il2CppStringArray il2CppStringArray9 = parameterDictionary12.Get<Il2CppStringArray>(b5);
										num &= 1881883890U;
										int num23 = (int)(num ^ 536871040U);
										num = 1802372667U * num;
										string text16 = il2CppStringArray9[num23];
										num /= 1397114908U;
										string text17 = text16;
										num = 1078088804U << (int)num;
										int num24 = (int)(num ^ 1078088805U);
										num |= 102697054U;
										string text18 = il2CppStringArray9[num24];
										string eater = text17;
										string eated = text18;
										num = 478945749U / num;
										InGameEvents.Eat(eater, eated);
										num += 3225374695U;
										goto IL_D12;
									}
									if (num != 515062374U)
									{
										goto IL_D12;
									}
									goto IL_41;
								}
							}
						}
					}
					num = 1133278097U << (int)num;
					string text19;
					string text20;
					string text21;
					for (;;)
					{
						EventDataCode eventDataCode12 = eventDataCode;
						uint num25 = num ^ 238145095U;
						num += 1352433312U;
						if (eventDataCode12 != num25)
						{
							break;
						}
						num = 317134293U % num;
						ConsoleColor consoleColor8 = (ConsoleColor)(num ^ 317134303U);
						num = 1963681766U + num;
						ParameterDictionary parameterDictionary13 = parameters;
						bool flag10 = num + 2014151238U != 0U;
						num = (152591584U & num);
						MelonLogger.Msg(consoleColor8, parameterDictionary13.ToStringFull(flag10));
						num = 1157515564U % num;
						Il2CppStringArray il2CppStringArray10 = parameters.Get<Il2CppStringArray>((byte)(num - 15147063U));
						int num26 = (int)(num - 15147308U);
						num <<= 30;
						text19 = il2CppStringArray10[num26];
						num |= 1747333862U;
						int num27 = (int)(num + 2547633435U);
						num = (156331266U ^ num);
						text20 = il2CppStringArray10[num27];
						num = (60911331U ^ num);
						int num28 = (int)(num - 1658204421U);
						num = 611282681U * num;
						text21 = il2CppStringArray10[num28];
						num = (231820879U | num);
						if (2142765536U > num)
						{
							goto Block_50;
						}
					}
					if (1271415858U % num == 0U)
					{
						continue;
					}
					uint num29 = (uint)eventDataCode;
					num &= 1709914549U;
					if (num29 != num + 3140876131U)
					{
						if (21889261U < num)
						{
							goto IL_D1;
						}
						continue;
					}
					else
					{
						ParameterDictionary parameterDictionary14 = parameters;
						byte b6 = (byte)(num ^ 1154091089U);
						num = 1287402404U << (int)num;
						Il2CppStringArray il2CppStringArray11 = parameterDictionary14.Get<Il2CppStringArray>(b6);
						num = 1761043540U << (int)num;
						int num30 = (int)(num ^ 1761043540U);
						num %= 1609333667U;
						string text22 = il2CppStringArray11[num30];
						num <<= 25;
						string text23 = text22;
						num = 889801123U << (int)num;
						string text24 = il2CppStringArray11[(int)(num - 889801122U)];
						num = 671906862U - num;
						string text25 = text24;
						string userId4 = text23;
						num = (612776334U & num);
						string ventId2 = text25;
						num = 1545019167U % num;
						InGameEvents.Vent(userId4, ventId2);
						if (936406691U > num)
						{
							num ^= 3693998572U;
							goto IL_D12;
						}
						continue;
					}
					Block_50:
					string killerUserId = text19;
					num = (2005756001U & num);
					string killedUserId = text20;
					num = 159998503U * num;
					string stingerId = text21;
					num -= 1368333312U;
					InGameEvents.Receive_Kill(killerUserId, killedUserId, stingerId);
					if (num >> 2 == 0U)
					{
						continue;
					}
					num += 1670490112U;
					IL_D12:;
				}
				while (550268146U == num);
			}
			catch (Exception ex)
			{
				uint num = 1642399968U;
				Exception ex2 = ex;
				num <<= 16;
				do
				{
					string str = "InGameEvent发生异常：";
					num %= 1848207807U;
					object obj = ex2;
					num = 1285166172U >> (int)num;
					MelonLogger.Error(str + obj.ToString());
				}
				while (9986368U + num == 0U);
			}
		}
	}
}
