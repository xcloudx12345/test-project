using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;
using GGD_Hack.Features.Admin;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using Photon.Pun;
using UnhollowerBaseLib;
using UnityEngine;

namespace GGD_Hack.RPC
{
	// Token: 0x02000012 RID: 18
	public class RpcServer
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000505B8 File Offset: 0x0004DBB8
		public static void SendCommand(RpcServer.RpcCommand command, string targetUserId, string data = "")
		{
			uint num;
			string text2;
			Il2CppReferenceArray<Object> il2CppReferenceArray;
			for (;;)
			{
				IL_00:
				int userIndexById = RpcServer.getUserIndexById(targetUserId);
				num = 1274173878U;
				for (;;)
				{
					int num2 = userIndexById;
					num = (1195130265U & num);
					uint num3 = num + 3167741552U;
					num = (1567819046U ^ num);
					if (num2 < num3)
					{
						break;
					}
					for (;;)
					{
						num = (1075718690U | num);
						if ((num ^ 638472544U) == 0U)
						{
							goto IL_00;
						}
						num = 2090273135U / num;
						byte b = (byte)command;
						num = (1815618918U & num);
						if (num << 15 != 0U)
						{
							goto IL_00;
						}
						byte b2 = (byte)userIndexById;
						num = (1750273962U ^ num);
						byte b3 = b2;
						num = 743638517U << (int)num;
						byte[] array = new byte[num + 3018337282U];
						num >>= 4;
						int num4 = (int)(num + 4215177920U);
						byte b4 = b;
						num = (309473949U | num);
						array[num4] = b4;
						num = 47003510U << (int)num;
						int num5 = (int)(num ^ 3221225473U);
						num = 2023380942U % num;
						array[num5] = b3;
						num = 1388381142U >> (int)num;
						char c = BitConverter.ToChar(array, (int)(num ^ 84740U));
						if (345849593U - num == 0U)
						{
							break;
						}
						num = (748314427U ^ num);
						string str = c.ToString();
						num %= 307320227U;
						string text = str + data;
						num %= 823013683U;
						text2 = text;
						num = (1648507683U ^ num);
						if ((num & 1024939483U) != 0U)
						{
							goto Block_5;
						}
					}
				}
				num = (1806921809U ^ num);
				MelonLogger.Warning("找不到userId");
				if (1548816747U < num)
				{
					break;
				}
				continue;
				Block_5:
				Component instance = LocalPlayer.Instance;
				num = (295833136U ^ num);
				PhotonView component = instance.gameObject.GetComponent<PhotonView>();
				if ((260258397U ^ num) != 0U)
				{
					bool flag = component == null;
					num += 1800759430U;
					if (flag)
					{
						return;
					}
					num *= 2103643368U;
					long num6 = (long)(num - 236524927U);
					num = 1071069360U - num;
					il2CppReferenceArray = new Il2CppReferenceArray<Object>(num6);
					num = 254237780U >> (int)num;
					if (num < 871522676U)
					{
						goto Block_8;
					}
				}
			}
			return;
			Block_8:
			Il2CppArrayBase<Object> il2CppArrayBase = il2CppReferenceArray;
			num *= 112607183U;
			il2CppArrayBase[(int)(num - 3011565961U)] = text2;
			try
			{
				string text4;
				MethodInfo methodInfo2;
				for (;;)
				{
					string text3 = null;
					num %= 1198611970U;
					text4 = text3;
					num = 1981371509U / num;
					if (821316869U + num != 0U)
					{
						RuntimeTypeHandle handle = typeof(PhotonView).TypeHandle;
						num ^= 1338591784U;
						Type typeFromHandle = Type.GetTypeFromHandle(handle);
						string text5 = "RPC";
						int num7 = (int)(num ^ 1338591784U);
						num &= 1969751605U;
						Type[] array2 = new Type[num7];
						num = 9968042U * num;
						int num8 = (int)(num - 1302242026U);
						RuntimeTypeHandle handle2 = typeof(string).TypeHandle;
						num %= 2132815740U;
						array2[num8] = Type.GetTypeFromHandle(handle2);
						int num9 = (int)(num + 2992725271U);
						RuntimeTypeHandle handle3 = typeof(RpcTarget).TypeHandle;
						num |= 1989361751U;
						array2[num9] = Type.GetTypeFromHandle(handle3);
						num = 1592925087U / num;
						num &= 1831280262U;
						int num10 = (int)(num ^ 2U);
						num = (787185190U | num);
						RuntimeTypeHandle handle4 = typeof(Il2CppReferenceArray<Object>).TypeHandle;
						num = 1851080378U * num;
						Type typeFromHandle2 = Type.GetTypeFromHandle(handle4);
						num = 490634547U % num;
						array2[num10] = typeFromHandle2;
						num >>= 20;
						MethodInfo methodInfo = AccessTools.Method(typeFromHandle, text5, array2, null);
						num >>= 4;
						methodInfo2 = methodInfo;
						if (1096971914U / num == 0U)
						{
							goto IL_2E9;
						}
						if (!(methodInfo2 != null))
						{
							goto IL_3AB;
						}
						if (2065592348U % num != 0U)
						{
							break;
						}
					}
				}
				object obj = methodInfo2;
				num %= 955515244U;
				string text6 = obj.ToString();
				num = 968309930U / num;
				text4 = text6;
				IL_2E9:
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 33389991U);
				num = 571160455U << (int)num;
				MelonLogger.Msg(consoleColor, text4);
				try
				{
					int num11 = (int)(num - 1727062013U);
					num /= 1267670364U;
					object[] array3 = new object[num11];
					num /= 184906233U;
					num = (186210498U | num);
					array3[(int)(num ^ 186210498U)] = "ChangeCurrentRoom";
					int num12 = (int)(num ^ 186210499U);
					num <<= 12;
					object obj2 = num + 1785978881U;
					num = 585838720U << (int)num;
					array3[num12] = obj2;
					num += 1441537224U;
					int num13 = (int)(num ^ 2027375946U);
					num *= 1182482420U;
					object obj3 = il2CppReferenceArray;
					num -= 309939999U;
					array3[num13] = obj3;
					object[] array4 = array3;
					MethodBase methodBase = methodInfo2;
					PhotonView component;
					object obj4 = component;
					object[] parameters = array4;
					num ^= 1262364324U;
					methodBase.Invoke(obj4, parameters);
					num /= 66395922U;
				}
				catch (Exception)
				{
				}
				IL_3AB:;
			}
			catch (Exception ex)
			{
				MelonLogger.Error(ex.Message);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000509C0 File Offset: 0x0004DFC0
		private static void OnReceivedHackedRpc(string rpcData)
		{
			uint num;
			string userIdByIndex;
			string text2;
			for (;;)
			{
				IL_00:
				num = 1411322326U;
				if (rpcData == null)
				{
					return;
				}
				if (num << 1 != 0U)
				{
					IL_1A:
					while (rpcData.Length != 0)
					{
						bool flag;
						for (;;)
						{
							num = 1302607061U >> (int)num;
							if (num * 1752449569U == 0U)
							{
								goto IL_1A;
							}
							int index = (int)(num + 4294966986U);
							num = (1808345191U & num);
							char value = rpcData[index];
							num *= 348601190U;
							byte[] bytes = BitConverter.GetBytes(value);
							num |= 796525433U;
							int num2 = (int)(num + 3221564547U);
							num ^= 1177882055U;
							byte b = bytes[num2];
							num <<= 21;
							userIdByIndex = RpcServer.getUserIdByIndex(bytes[(int)(num ^ 3611295745U)]);
							PlayerController player = LocalPlayer.Instance.Player;
							num = 938018644U - num;
							flag = (player.userId == userIdByIndex);
							for (;;)
							{
								string text = null;
								num = 1106124886U % num;
								text2 = text;
								if (1128014319U + num == 0U)
								{
									goto IL_00;
								}
								num = 934692589U + num;
								uint length = (uint)rpcData.Length;
								num &= 559756193U;
								if (length > (num ^ 553919232U))
								{
									num = (846746322U | num);
									if (904665732U <= num)
									{
										return;
									}
									num /= 1448178638U;
									int startIndex = (int)(num - uint.MaxValue);
									num %= 480839424U;
									string text3 = rpcData.Substring(startIndex);
									num -= 635656752U;
									text2 = text3;
									num ^= 4212688593U;
								}
								num = (519310829U | num);
								int num3 = (int)b;
								num *= 30954706U;
								int num4 = num3;
								if (num >= 1093165675U)
								{
									int num5 = num4;
									num &= 520054705U;
									switch (num5)
									{
									case 0:
										if (!flag)
										{
											goto IL_267;
										}
										num = 1938555990U % num;
										CommandHandler.Suicide();
										if (969103781U != num)
										{
											return;
										}
										continue;
									case 1:
										goto IL_1D1;
									case 2:
										goto IL_1F3;
									case 3:
										goto IL_20A;
									case 4:
										goto IL_226;
									}
									break;
								}
								goto IL_00;
							}
							if (num + 848041792U != 0U)
							{
								return;
							}
						}
						IL_267:
						if (1154578755U > num)
						{
							return;
						}
						goto IL_00;
						IL_1D1:
						if (num > 331622681U)
						{
							continue;
						}
						bool flag2 = flag;
						num ^= 0U;
						if (flag2)
						{
							goto Block_12;
						}
						goto IL_267;
						IL_226:
						num = 715139172U / num;
						bool flag3 = flag;
						num ^= 302056482U;
						if (!flag3)
						{
							goto IL_267;
						}
						num %= 1190336785U;
						if (num + 16923231U != 0U)
						{
							CommandHandler.SendChat(text2);
							num ^= 0U;
							goto IL_267;
						}
						return;
					}
					break;
				}
			}
			num ^= 0U;
			return;
			Block_12:
			RpcServer.SuperBan();
			return;
			IL_1F3:
			string pingSender = userIdByIndex;
			num = 864772161U << (int)num;
			RpcServer.ResponsePong(pingSender);
			return;
			IL_20A:
			string pingResponderUserId = userIdByIndex;
			num = 1615268650U / num;
			string modVersion = text2;
			num = 223029961U + num;
			RpcServer.OnReceivedPong(pingResponderUserId, modVersion);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00050C40 File Offset: 0x0004E240
		private static void OnReceivedPong(string pingResponderUserId, string modVersion)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00050C50 File Offset: 0x0004E250
		private static void ResponsePong(string pingSender)
		{
			uint num = 1478569155U;
			RpcServer.RpcCommand command = (RpcServer.RpcCommand)(num - 1478569152U);
			PlayerController player = LocalPlayer.Instance.Player;
			num = 1039357828U / num;
			string userId = player.userId;
			num = (811428228U ^ num);
			RpcServer.SendCommand(command, userId, "1.6.13");
			if (num != 1981248530U)
			{
				ModDeveloperName.MarkAsDev(pingSender);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00050CA4 File Offset: 0x0004E2A4
		private static string getUserIdByIndex(byte userIndex)
		{
			uint num;
			List<string> list;
			for (;;)
			{
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = 978152415U;
				Dictionary<string, PlayerController> dictionary = playersList;
				num = 683758580U % num;
				if (346032957U != num)
				{
					goto IL_1F;
				}
				IL_33:
				Dictionary<string, PlayerController>.Enumerator enumerator = dictionary.GetEnumerator();
				num |= 89227073U;
				Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
				if (478428937U / num == 0U)
				{
					while (758149271U != num)
					{
						bool flag = enumerator2.MoveNext();
						num *= 1357863244U;
						if (!flag)
						{
							num += 1504535840U;
							if (num + 1928220033U == 0U)
							{
								goto IL_1F;
							}
							list.Sort();
							if (560349705U >= num)
							{
								break;
							}
							num &= 1066476733U;
							Dictionary<string, PlayerController> dictionary2 = dictionary;
							num = 408383050U / num;
							byte count = (byte)dictionary2.Count;
							num = (689206054U ^ num);
							if (userIndex < count)
							{
								goto IL_176;
							}
							if (num < 799753683U)
							{
								goto Block_11;
							}
							break;
						}
						else
						{
							KeyValuePair<string, PlayerController> keyValuePair = enumerator2.Current;
							num = 376010280U;
							string key = keyValuePair.Key;
							num = 1069699554U / num;
							PlayerController value = keyValuePair.Value;
							num = 1077882795U % num;
							PlayerController playerController = value;
							bool flag2 = key != null;
							num = (1803966683U ^ num);
							num ^= 3470206875U;
							if (flag2)
							{
								if (1379747888U > num)
								{
									goto IL_1F;
								}
								bool flag3 = key == "";
								num ^= 0U;
								if (!flag3)
								{
									num = 534588393U * num;
									bool flag4 = playerController == null;
									num = 137522672U * num;
									num ^= 2885465137U;
									if (!flag4)
									{
										num = (1347228221U | num);
										if (1675434119U == num)
										{
											goto IL_1F;
										}
										list.Add(key);
										num ^= 1342963772U;
									}
								}
							}
						}
					}
					continue;
				}
				continue;
				IL_1F:
				list = new List<string>();
				num = 30030417U << (int)num;
				goto IL_33;
			}
			Block_11:
			return null;
			IL_176:
			List<string> list2 = list;
			num = 1119163585U >> (int)num;
			return list2[(int)userIndex];
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00050E3C File Offset: 0x0004E43C
		private static int getUserIndexById(string userId_)
		{
			uint num = 927286092U;
			int num2;
			for (;;)
			{
				IL_06:
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				List<string> list = new List<string>();
				Dictionary<string, PlayerController>.Enumerator enumerator = playersList.GetEnumerator();
				if (num <= 1661363980U)
				{
					for (;;)
					{
						for (;;)
						{
							Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
							num *= 777788619U;
							if (!enumerator2.MoveNext())
							{
								break;
							}
							num = 887179266U;
							if (num >= 2030659817U)
							{
								goto IL_06;
							}
							Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator;
							num = 785920171U >> (int)num;
							KeyValuePair<string, PlayerController> keyValuePair = enumerator3.Current;
							num = 77290510U << (int)num;
							string key = keyValuePair.Key;
							num = (102707728U & num);
							PlayerController value = keyValuePair.Value;
							num = 1174039678U << (int)num;
							if ((num & 1228106565U) != 0U)
							{
								bool flag = key != null;
								num ^= 1925132082U;
								if (flag)
								{
									num %= 1662740848U;
									bool flag2 = key == "";
									num += 818160370U;
									num += 3476806926U;
									if (!flag2)
									{
										Object @object = value;
										Object object2 = null;
										num = (1951338809U | num);
										bool flag3 = @object == object2;
										num = 1902211146U % num;
										num += 3320042242U;
										if (!flag3)
										{
											List<string> list2 = list;
											string item = key;
											num -= 244327603U;
											list2.Add(item);
											num += 244327603U;
										}
									}
								}
							}
						}
						num = 2012902128U >> (int)num;
						list.Sort();
						num2 = (int)(num ^ 125806383U);
						if (895359363U > num)
						{
							for (;;)
							{
								num = 1318726089U % num;
								int num3 = num2;
								num = (411697988U ^ num);
								List<string> list3 = list;
								num <<= 29;
								if (num3 >= list3.Count)
								{
									goto Block_11;
								}
								List<string> list4 = list;
								num = 1255083501U;
								bool flag4 = list4[num2] == userId_;
								num %= 2102395066U;
								if (flag4)
								{
									break;
								}
								num *= 1823363998U;
								if (num == 220616607U)
								{
									goto IL_06;
								}
								int num4 = num2;
								num = 137431170U - num;
								num2 = num4 + (int)(num ^ 1204590909U);
								num ^= 1085488659U;
							}
							num = (1764380558U ^ num);
							if (num + 201201354U != 0U)
							{
								return num2;
							}
						}
					}
				}
			}
			return num2;
			Block_11:
			return (int)(num - 3758096385U);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00051018 File Offset: 0x0004E618
		private static void SuperBan()
		{
			Application.Quit();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00051040 File Offset: 0x0004E640
		// Note: this type is marked as 'beforefieldinit'.
		static RpcServer()
		{
			uint num = 2026984169U;
			if ((num ^ 181407010U) != 0U)
			{
				RpcServer.usersRespondedPing = new List<string>();
				num = (553270340U ^ num);
			}
			do
			{
				RpcServer.usersVersions = new Dictionary<string, string>();
			}
			while (181540660U >= num);
		}

		// Token: 0x04000012 RID: 18
		public static List<string> usersRespondedPing;

		// Token: 0x04000013 RID: 19
		public static Dictionary<string, string> usersVersions;

		// Token: 0x02000079 RID: 121
		public enum RpcCommand
		{
			// Token: 0x040001CB RID: 459
			Kill,
			// Token: 0x040001CC RID: 460
			SuperBan,
			// Token: 0x040001CD RID: 461
			Ping,
			// Token: 0x040001CE RID: 462
			Pong,
			// Token: 0x040001CF RID: 463
			SendChat
		}

		// Token: 0x0200007A RID: 122
		[HarmonyPatch(typeof(PlayerController), "ChangeCurrentRoom")]
		private class ChangeCurrentRoom_
		{
			// Token: 0x060001D9 RID: 473 RVA: 0x00062E3C File Offset: 0x0006043C
			private static void Postfix(PlayerController __instance, string __0)
			{
				uint num;
				do
				{
					bool flag = string.IsNullOrEmpty(__0);
					num = 1973755670U;
					if (!flag)
					{
						goto IL_1E;
					}
				}
				while (401370934U / num != 0U);
				return;
				IL_1E:
				string pattern = "^[A-Z0-9]{6}$";
				num = 728903028U % num;
				bool flag2 = Regex.IsMatch(__0, pattern);
				num = 414149932U >> (int)num;
				if (flag2)
				{
					return;
				}
				if ((558129620U & num) != 0U)
				{
					try
					{
						num ^= 1863456327U;
						do
						{
							num &= 500069794U;
							RpcServer.OnReceivedHackedRpc(__0);
						}
						while (1141665488U + num == 0U);
					}
					catch (Exception ex)
					{
						num = 860891456U;
						Exception arg = ex;
						num %= 162296060U;
						do
						{
							string format = "Exception in patch of void Handlers.GameHandlers.PlayerHandlers.PlayerController::ChangeCurrentRoom(string GMGCAGICDPG):\n{0}";
							num = 1045198268U + num;
							string text = string.Format(format, arg);
							num -= 497817123U;
							MelonLogger.Warning(text);
						}
						while (num % 424818025U == 0U);
					}
					return;
				}
			}

			// Token: 0x060001DA RID: 474 RVA: 0x00062F20 File Offset: 0x00060520
			public ChangeCurrentRoom_()
			{
				uint num = 1635804991U;
				do
				{
					num = 1152416498U << (int)num;
					base..ctor();
				}
				while (num << 4 != 0U);
			}
		}
	}
}
