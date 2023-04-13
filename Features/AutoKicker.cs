using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using APIs.Photon;
using ExitGames.Client.Photon;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using Handlers.PrefabAttachedHandlers;
using HarmonyLib;
using Il2CppSystem;
using Managers;
using Managers.ConnectionManagers;
using MelonLoader;
using Photon.Pun;
using Photon.Realtime;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000044 RID: 68
	[RegisterTypeInIl2Cpp]
	public class AutoKicker : MonoBehaviour
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00058064 File Offset: 0x00055664
		public AutoKicker(IntPtr ptr)
		{
			uint num = 676988320U;
			for (;;)
			{
				IL_06:
				num -= 282230271U;
				List<string> list = new List<string>();
				num /= 384309766U;
				this.rules = list;
				num /= 746855780U;
				for (;;)
				{
					IL_29:
					num = 366816747U - num;
					this.fileName = "AutoKick.txt";
					if (156505043U % num == 0U)
					{
						break;
					}
					IngameSettings.IngameSettingsEntry ingameSettingsEntry;
					for (;;)
					{
						List<string> list2 = new List<string>();
						num = 1250524074U * num;
						num <<= 25;
						list2.Add(".*[ 0123456789零一二三四五六七八九壹贰叁肆伍陆柒捌玖]{6,}.*");
						list2.Add(".*[qQ扣][裙群].*");
						num = 889267654U - num;
						num = 1359174107U / num;
						list2.Add(".*千人[裙群].*");
						num = 1382702226U >> (int)num;
						num |= 132738778U;
						string item = ".*全网最低.*";
						num = 1180183577U * num;
						list2.Add(item);
						list2.Add(".*稳定.*");
						num += 842103777U;
						num /= 2069037173U;
						list2.Add(".*奔放.*");
						string item2 = ".*辅助.*";
						num = 1329821715U * num;
						list2.Add(item2);
						num = 1823897970U * num;
						num = 1341353688U << (int)num;
						list2.Add(".*低价.*");
						num ^= 783628885U;
						list2.Add(".*透视.*");
						num %= 1248158540U;
						string item3 = ".*看身份.*";
						num = (1846439327U & num);
						list2.Add(item3);
						num = (131209213U | num);
						string item4 = ".*看职业.*";
						num <<= 26;
						list2.Add(item4);
						string item5 = ".*穿墙.*";
						num = (798954177U | num);
						list2.Add(item5);
						string item6 = ".*秒噶.*";
						num = (783887496U ^ num);
						list2.Add(item6);
						num -= 40521989U;
						num -= 1839137647U;
						string item7 = ".*瞬刀.*";
						num = (1238520782U & num);
						list2.Add(item7);
						this.defaultRules = list2;
						num = (153777727U ^ num);
						num = 1887594101U << (int)num;
						base..ctor(ptr);
						if (1936160969U < num)
						{
							num = 1263151471U >> (int)num;
							ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
							num -= 536623171U;
							if (1238840071U == num)
							{
								goto IL_29;
							}
							num = (1767078764U | num);
							MelonPreferences_Entry enabled = AutoKicker.Enabled;
							num |= 1185371008U;
							ingameSettingsEntry.entry = enabled;
							if (667964475U >= num)
							{
								goto IL_06;
							}
							num %= 676472172U;
							string name_cn = "自动踢出广告";
							num += 1056773036U;
							ingameSettingsEntry.name_cn = name_cn;
							num = 779767068U + num;
							if (783181667U != num)
							{
								break;
							}
						}
					}
					string name_eng = "AutoKicker";
					num = (1620581019U | num);
					ingameSettingsEntry.name_eng = name_eng;
					num /= 2144694602U;
					IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
					num = 1904503380U / num;
					IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
					if (num != 2044274872U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000582F8 File Offset: 0x000558F8
		public AutoKicker()
		{
			for (;;)
			{
				List<string> list = new List<string>();
				uint num = 281887833U;
				this.rules = list;
				num *= 1183071803U;
				if (num < 977151445U)
				{
					this.fileName = "AutoKick.txt";
					num &= 89422650U;
					List<string> list2 = new List<string>();
					num >>= 13;
					num = 203777153U - num;
					list2.Add(".*[ 0123456789零一二三四五六七八九壹贰叁肆伍陆柒捌玖]{6,}.*");
					string item = ".*[qQ扣][裙群].*";
					num /= 1897409705U;
					list2.Add(item);
					string item2 = ".*千人[裙群].*";
					num = 1594832434U * num;
					list2.Add(item2);
					num = 1442062919U >> (int)num;
					list2.Add(".*全网最低.*");
					string item3 = ".*稳定.*";
					num ^= 1935101690U;
					list2.Add(item3);
					list2.Add(".*奔放.*");
					num -= 1734440651U;
					list2.Add(".*辅助.*");
					num &= 1857225242U;
					num = 2070090612U << (int)num;
					list2.Add(".*低价.*");
					num %= 750459270U;
					string item4 = ".*透视.*";
					num = (1988633474U & num);
					list2.Add(item4);
					string item5 = ".*看身份.*";
					num ^= 754730554U;
					list2.Add(item5);
					num -= 163984260U;
					num /= 972698915U;
					string item6 = ".*看职业.*";
					num = 904032952U + num;
					list2.Add(item6);
					num += 1245870396U;
					list2.Add(".*穿墙.*");
					num *= 1314479615U;
					string item7 = ".*秒噶.*";
					num &= 254962437U;
					list2.Add(item7);
					num %= 1945703576U;
					num = 343090388U % num;
					list2.Add(".*瞬刀.*");
					num -= 477192914U;
					this.defaultRules = list2;
					if (1322517736U + num != 0U)
					{
						num = (1547194361U & num);
						IntPtr intPtr = ClassInjector.DerivedConstructorPointer<AutoKicker>();
						num = (1134575566U ^ num);
						base..ctor(intPtr);
						if (num != 1984266079U)
						{
							break;
						}
					}
				}
			}
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000584D0 File Offset: 0x00055AD0
		public static void Init()
		{
			uint num = 1655535869U;
			if (670975152U / num != 0U)
			{
				goto IL_63;
			}
			GameObject gameObject = GameObject.Find("ML_Manager");
			do
			{
				bool flag = gameObject == null;
				num = 656897685U / num;
				if (!flag)
				{
					goto IL_63;
				}
				gameObject = new GameObject("ML_Manager");
				num = 11366503U >> (int)num;
			}
			while (377762571U <= num);
			IL_55:
			Object.DontDestroyOnLoad(gameObject);
			num ^= 11366503U;
			IL_63:
			num ^= 1437344316U;
			Object component = gameObject.GetComponent<AutoKicker>();
			num >>= 30;
			bool flag2 = component == null;
			num >>= 14;
			if (flag2)
			{
				if (1211840409U + num == 0U)
				{
					goto IL_55;
				}
				GameObject gameObject2 = gameObject;
				num |= 431690796U;
				AutoKicker.Instance = gameObject2.AddComponent<AutoKicker>();
				num ^= 431690796U;
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00058590 File Offset: 0x00055B90
		private void Start()
		{
			uint num;
			string text;
			for (;;)
			{
				string modsDirectory = MelonHandler.ModsDirectory;
				num = 1704813479U;
				string str = "/";
				num %= 524819571U;
				text = modsDirectory + str + this.fileName;
				for (;;)
				{
					num = (1034117867U ^ num);
					ConsoleColor consoleColor = (int)num + (ConsoleColor)(-979791003);
					string str2 = "自动踢人的规则文件路径：";
					num >>= 7;
					string str3 = text;
					num >>= 27;
					string text2 = str2 + str3;
					num = 1386697333U + num;
					MelonLogger.Msg(consoleColor, text2);
					num = (249584359U & num);
					if (File.Exists(text))
					{
						break;
					}
					num |= 40719023U;
					ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 49107685U);
					num /= 1665029703U;
					MelonLogger.Msg(consoleColor2, "自动踢人的规则文件不存在，即将创建默认规则文件");
					num = 1307717003U - num;
					if (num > 1082065007U)
					{
						goto Block_1;
					}
				}
				num -= 1362393867U;
				if (1399004438U < num)
				{
					num = 807801831U >> (int)num;
					string path = text;
					num -= 505492986U;
					IEnumerable<string> source = File.ReadAllLines(path);
					Func<string, bool> <>9__8_ = AutoKicker.<>c.<>9__8_0;
					num *= 606894156U;
					Func<string, bool> predicate = <>9__8_;
					num ^= 1389061110U;
					if (<>9__8_ == null)
					{
						num >>= 16;
						Func<string, bool> <>9__8_2 = predicate = delegate(string line)
						{
							uint num6 = 1317695013U;
							num6 &= 63001956U;
							bool flag3 = line.StartsWith("//");
							num6 ^= 551173086U;
							uint num7 = num6 ^ 576356346U;
							num6 -= 1933576486U;
							return flag3 == num7;
						};
						num %= 295512127U;
						AutoKicker.<>c.<>9__8_0 = <>9__8_2;
						num += 3980271983U;
					}
					num = 341462104U + num;
					IEnumerable<string> source2 = source.Where(predicate);
					Func<string, string> selector;
					if ((selector = AutoKicker.<>c.<>9__8_1) == null)
					{
						num = 462305213U + num;
						num &= 1840191382U;
						Func<string, string> func = (string line) => line;
						num *= 1938826226U;
						selector = func;
						AutoKicker.<>c.<>9__8_1 = func;
						num ^= 2483953634U;
					}
					IEnumerable<string> source3 = source2.Select(selector);
					num ^= 1050296087U;
					this.rules = source3.ToList<string>();
					if (1414470417U * num != 0U)
					{
						goto Block_5;
					}
				}
			}
			do
			{
				IL_2B3:
				num = 77012629U;
				if (168437537U != num)
				{
					string path2 = text;
					num %= 1340289612U;
					int num2 = (int)(num - 77012626U);
					num -= 873614999U;
					string[] array = new string[num2];
					num >>= 13;
					int num3 = (int)(num + 4294540250U);
					string text3 = "//You can define any regular expression to automatically kick out players whose nicknames or chat messages match the pattern";
					num = 1864707557U - num;
					array[num3] = text3;
					int num4 = (int)(num - 1864280510U);
					num += 1498888497U;
					array[num4] = "//你可以定义任何正则表达式来自动踢出昵称或发言符合规则的玩家";
					num >>= 1;
					int num5 = (int)(num ^ 1681584506U);
					num = (467012347U ^ num);
					array[num5] = "//以下是一些默认规则，可以自行修改";
					num &= 581068078U;
					File.WriteAllLines(path2, array);
					if (743709167U >> (int)num == 0U)
					{
						continue;
					}
				}
				string path3 = text;
				num = (1531314839U | num);
				File.AppendAllLines(path3, this.rules);
			}
			while (num == 721386800U);
			return;
			Block_1:
			num = 690576746U + num;
			num %= 867106949U;
			this.rules = this.defaultRules;
			goto IL_2B3;
			Block_5:
			num = 918168570U % num;
			List<string> list = this.defaultRules;
			num *= 1064373050U;
			List<string>.Enumerator enumerator = list.GetEnumerator();
			num -= 1437818971U;
			using (List<string>.Enumerator enumerator2 = enumerator)
			{
				if (1699231895U >> (int)num != 0U)
				{
					goto IL_270;
				}
				string text5;
				for (;;)
				{
					IL_1EA:
					num = 1871079598U;
					string text4 = enumerator2.Current;
					num = 1347771370U << (int)num;
					text5 = text4;
					if (693181746U - num != 0U)
					{
						num = 209609482U + num;
						bool flag = this.rules.Contains(text5);
						num = 1400153U / num;
						num ^= 2002682953U;
						if (flag)
						{
							goto IL_270;
						}
						num /= 1290604675U;
						if (2007518013U != num)
						{
							break;
						}
					}
				}
				List<string> list2 = this.rules;
				string item = text5;
				num = 2096824525U << (int)num;
				list2.Add(item);
				num += 2104001199U;
				IL_270:
				num -= 1740989726U;
				if ((6557254U ^ num) == 0U)
				{
					goto IL_1EA;
				}
				num = 247744081U - num;
				bool flag2 = enumerator2.MoveNext();
				num -= 157422462U;
				if (flag2)
				{
					goto IL_1EA;
				}
			}
			goto IL_2B3;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0005892C File Offset: 0x00055F2C
		private bool IsStringForbidden(string str)
		{
			List<string> list = this.rules;
			uint num = 1521253767U;
			List<string>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				if (1617040218U / num == 0U)
				{
					goto IL_23;
				}
				IL_1E:
				goto IL_89;
				IL_23:
				string text = enumerator.Current;
				num = 1110343348U;
				IL_31:
				bool flag = text.StartsWith("//");
				num += 410910419U;
				if (!flag)
				{
					if (num + 660299814U == 0U)
					{
						goto IL_23;
					}
					bool flag2 = Regex.IsMatch(str, text);
					num = (348025223U & num);
					num += 1241517056U;
					if (flag2)
					{
						bool result = (num ^ 1521253766U) != 0U;
						if (1466377081U <= num)
						{
							return result;
						}
					}
				}
				IL_89:
				num = 1200357413U % num;
				if (747394638U / num != 0U)
				{
					goto IL_31;
				}
				num = 1425410625U + num;
				bool flag3 = enumerator.MoveNext();
				num = 697305663U >> (int)num;
				if (flag3)
				{
					goto IL_23;
				}
				if (824537198U + num == 0U)
				{
					goto IL_1E;
				}
			}
			finally
			{
				do
				{
					num = 315834635U;
					((IDisposable)enumerator).Dispose();
				}
				while (230249795U + num == 0U);
			}
			num = 919427520U;
			return (num ^ 919427520U) != 0U;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00058A5C File Offset: 0x0005605C
		private void KickPlayer(string userId)
		{
			uint num = 1755732452U;
			do
			{
				PluginEventsManager.Kick_Player(userId, "Super Banned");
			}
			while ((1126334250U ^ num) == 0U);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00058A88 File Offset: 0x00056088
		private void HandlePlayerChatMessage(string userId, string message)
		{
			uint num = 1136532811U;
			if (num <= 1971735664U)
			{
				GameObject gameObject;
				for (;;)
				{
					bool value = AutoKicker.Enabled.Value;
					num = (529924569U & num);
					if (!value)
					{
						return;
					}
					for (;;)
					{
						num %= 213800314U;
						if (269835177U < num)
						{
							break;
						}
						if (userId == LocalPlayer.Instance.Player.userId || num == 1780688414U)
						{
							return;
						}
						if (!LobbySceneHandler.InGameScene)
						{
							return;
						}
						if (num << 31 == 0U)
						{
							break;
						}
						if (LobbySceneHandler.Instance.gameStarted)
						{
							return;
						}
						for (;;)
						{
							num %= 853302476U;
							if (1183462089U <= num)
							{
								break;
							}
							Player localPlayer = PhotonNetwork.LocalPlayer;
							num = (2002667340U | num);
							Player player = localPlayer;
							num ^= 597037867U;
							MainManager instance = MainManager.Instance;
							num = 783766358U << (int)num;
							bool flag = instance.photonMasterManager.IsMasterClient(player);
							num = (1925673953U ^ num);
							if (!flag)
							{
								return;
							}
							num -= 1591450U;
							bool flag2 = this.IsStringForbidden(message);
							num = 970787580U + num;
							if (!flag2)
							{
								return;
							}
							gameObject = GameObject.Find(userId);
							num = 1029713270U - num;
							if (gameObject != null)
							{
								goto IL_128;
							}
							num = (631197198U & num);
							if (1748175843U != num)
							{
								goto Block_10;
							}
						}
					}
				}
				return;
				Block_10:
				string text = null;
				goto IL_175;
				IL_128:
				num = 928741097U >> (int)num;
				PlayerController component = gameObject.GetComponent<PlayerController>();
				num /= 2109084537U;
				num *= 2111902781U;
				if (component == null)
				{
					num -= 1274890066U;
					text = null;
					num += 1887734612U;
				}
				else
				{
					text = component.nickname;
					num ^= 612844546U;
				}
				IL_175:
				num %= 825130377U;
				string text2;
				bool flag3 = (text2 = text) != null;
				num = 1188453652U >> (int)num;
				if (!flag3)
				{
					num *= 68910347U;
					num = (819410019U ^ num);
					text2 = "";
					num ^= 1418957777U;
				}
				num &= 1679956973U;
				string text3 = text2;
				num -= 937653617U;
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 3359415774U);
				string text4 = "检测到违规发言:{0} ，正在踢出玩家：{1}";
				num /= 1753958348U;
				int num2 = (int)(num ^ 3U);
				num = (364255288U ^ num);
				object[] array = new object[num2];
				num = 241203627U - num;
				int num3 = (int)(num ^ 4171915634U);
				num /= 614412762U;
				array[num3] = message;
				int num4 = (int)(num + 4294967291U);
				num = 933893565U + num;
				object obj = text3;
				num |= 2033796546U;
				array[num4] = obj;
				num = 954269889U >> (int)num;
				MelonLogger.Msg(consoleColor, text4, array);
				num >>= 24;
				this.KickPlayer(userId);
				num ^= 416835780U;
				return;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00058CDC File Offset: 0x000562DC
		private void HandlePlayerNickname(string userId, string nickname)
		{
			uint num;
			for (;;)
			{
				IL_00:
				MelonPreferences_Entry<bool> enabled = AutoKicker.Enabled;
				num = 1563510229U;
				bool value = enabled.Value;
				num %= 768757874U;
				if (!value && (393625960U & num) != 0U)
				{
					break;
				}
				for (;;)
				{
					IL_2A:
					Object instance = LocalPlayer.Instance;
					num = 1425633118U / num;
					if (!(instance == null))
					{
						while (!(LocalPlayer.Instance.Player == null))
						{
							if (1253377895U == num)
							{
								return;
							}
							string userId2 = LocalPlayer.Instance.Player.userId;
							num ^= 790699948U;
							bool flag = userId == userId2;
							num = 537274137U - num;
							if (flag)
							{
								return;
							}
							if ((num & 1872255452U) == 0U)
							{
								goto IL_00;
							}
							bool inGameScene = LobbySceneHandler.InGameScene;
							num %= 943935264U;
							if (!inGameScene)
							{
								return;
							}
							if (1394935933U >= num)
							{
								LobbySceneHandler instance2 = LobbySceneHandler.Instance;
								num &= 2770347U;
								bool gameStarted = instance2.gameStarted;
								num = (623542005U & num);
								if (gameStarted)
								{
									goto Block_7;
								}
								num = 1377517511U + num;
								if (num < 496660626U)
								{
									goto IL_00;
								}
								Player localPlayer = PhotonNetwork.LocalPlayer;
								num = 1507742317U * num;
								Player player = localPlayer;
								num *= 1306801617U;
								PhotonMasterManager photonMasterManager = MainManager.Instance.photonMasterManager;
								Player player2 = player;
								num |= 586969448U;
								if (!photonMasterManager.IsMasterClient(player2))
								{
									return;
								}
								num |= 80749307U;
								if (num >> 16 != 0U)
								{
									goto Block_11;
								}
								goto IL_2A;
							}
						}
						goto Block_1;
					}
					return;
				}
				Block_11:
				num = 21981409U >> (int)num;
				num = (529563110U | num);
				if (this.IsStringForbidden(nickname))
				{
					num = 1905134669U % num;
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 316445329U);
					string text = "检测到违规昵称！正在踢出该玩家：{0}";
					int num2 = (int)(num + 3978521958U);
					num += 2125857957U;
					object[] array = new object[num2];
					num = (2147379339U | num);
					int num3 = (int)(num ^ 4294901707U);
					num = (1242397182U ^ num);
					array[num3] = nickname;
					MelonLogger.Msg(consoleColor, text, array);
					num = 533607219U % num;
					num = 338245725U % num;
					this.KickPlayer(userId);
					num += 191317385U;
				}
				if (1864189959U + num != 0U)
				{
					return;
				}
			}
			return;
			Block_1:
			num ^= 0U;
			return;
			Block_7:
			if (1353215108U + num != 0U)
			{
				return;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00058EC4 File Offset: 0x000564C4
		// Note: this type is marked as 'beforefieldinit'.
		static AutoKicker()
		{
			uint num = 830565850U;
			string text = "GGDH";
			num <<= 5;
			string text2 = "Enable_AutoKicker";
			bool flag = (num ^ 808303425U) != 0U;
			string text3 = null;
			string text4 = null;
			bool flag2 = num - 808303424U != 0U;
			bool flag3 = (num ^ 808303424U) != 0U;
			num |= 2001162591U;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, null);
			num = (116542513U & num);
			AutoKicker.Enabled = enabled;
			if (1703834287U > num)
			{
				AutoKicker.Instance = null;
			}
		}

		// Token: 0x04000166 RID: 358
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000167 RID: 359
		public static AutoKicker Instance;

		// Token: 0x04000168 RID: 360
		private List<string> rules;

		// Token: 0x04000169 RID: 361
		private string fileName;

		// Token: 0x0400016A RID: 362
		private List<string> defaultRules;

		// Token: 0x0200009B RID: 155
		[HarmonyPatch(typeof(PhotonEventAPI), "OnEvent", new Type[]
		{
			typeof(EventData)
		})]
		private class PlayerJoinedRoom
		{
			// Token: 0x0600021F RID: 543 RVA: 0x00065774 File Offset: 0x00062D74
			private static void Postfix(EventData __0)
			{
				uint num = 977610727U;
				for (;;)
				{
					num = 516234810U << (int)num;
					uint code = (uint)__0.Code;
					num /= 1240736134U;
					if (code != num + 254U && 490547002U > num)
					{
						break;
					}
					num = 1036918462U / num;
					if ((2069375870U ^ num) == 0U)
					{
						break;
					}
					Hashtable hashtable = __0.Parameters.Get<Hashtable>((byte)(num ^ 1036918343U));
					num -= 859450685U;
					num -= 1196298420U;
					string text = "userId";
					num -= 1209355512U;
					Object @object = hashtable[text];
					num ^= 33051184U;
					string text2 = @object.ToString();
					byte b = (byte)(num ^ 2059976986U);
					num = (830892802U & num);
					string text3 = hashtable[b].ToString();
					num *= 905589170U;
					MelonLogger.Msg("玩家加入房间: " + text3);
					num *= 333148861U;
					if (702304888U > num)
					{
						break;
					}
					MelonPreferences_Entry<bool> enabled = AutoKicker.Enabled;
					num = (737946533U & num);
					if (enabled.Value)
					{
						num = (1493434833U ^ num);
						AutoKicker instance = AutoKicker.Instance;
						string userId = text2;
						string nickname = text3;
						num %= 836716079U;
						instance.HandlePlayerNickname(userId, nickname);
						num += 180521613U;
					}
					if (1590501523U > num)
					{
						return;
					}
				}
			}

			// Token: 0x06000220 RID: 544 RVA: 0x000658A4 File Offset: 0x00062EA4
			public PlayerJoinedRoom()
			{
				uint num = 119884952U;
				if (num < 1326198657U)
				{
					do
					{
						base..ctor();
					}
					while (1161433197U / num == 0U);
				}
			}
		}

		// Token: 0x0200009C RID: 156
		[HarmonyPatch(typeof(MessagePrefabHandler), "Initialize")]
		private class OnReceivedMessage
		{
			// Token: 0x06000221 RID: 545 RVA: 0x000658D4 File Offset: 0x00062ED4
			private static void Postfix(MessagePrefabHandler __instance)
			{
				string message = __instance.message;
				uint num = 1278107817U;
				string text = message;
				do
				{
					num = (1469665402U ^ num);
					string sender = __instance.sender;
					num += 1891379886U;
					string text2 = sender;
					num -= 677998905U;
					AutoKicker instance = AutoKicker.Instance;
					num -= 877219744U;
					string userId = text2;
					string message2 = text;
					num = 804927196U * num;
					instance.HandlePlayerChatMessage(userId, message2);
				}
				while (2098137873U > num);
			}
		}
	}
}
