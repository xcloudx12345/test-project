using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using GGD_Hack.Utils;
using Handlers.CommonHandlers.UIHandlers;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace GGD_Hack.Features
{
	// Token: 0x0200002F RID: 47
	public class AutoUpdate
	{
		// Token: 0x060000AF RID: 175 RVA: 0x000524EC File Offset: 0x0004FAEC
		public static void CheckLatestModVersion()
		{
			uint num = 1013402446U;
			AsyncVoidMethodBuilder <>t__builder = AsyncVoidMethodBuilder.Create();
			num /= 1068396731U;
			AutoUpdate.<CheckLatestModVersion>d__4 <CheckLatestModVersion>d__;
			<CheckLatestModVersion>d__.<>t__builder = <>t__builder;
			num = (486221769U | num);
			for (;;)
			{
				<CheckLatestModVersion>d__.<>1__state = (int)(num + 3808745526U);
				if ((num ^ 326709958U) != 0U)
				{
					num = (1595571041U | num);
					<CheckLatestModVersion>d__.<>t__builder.Start<AutoUpdate.<CheckLatestModVersion>d__4>(ref <CheckLatestModVersion>d__);
					if (num != 180373694U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00052558 File Offset: 0x0004FB58
		private static void GetLatestVersionFromGithub(bool checkUpdate = false)
		{
			uint num;
			AutoUpdate.<>c__DisplayClass5_0 CS$<>8__locals2;
			do
			{
				AutoUpdate.<>c__DisplayClass5_0 CS$<>8__locals1 = new AutoUpdate.<>c__DisplayClass5_0();
				num = 1237338505U;
				CS$<>8__locals2 = CS$<>8__locals1;
				CS$<>8__locals2.checkUpdate = checkUpdate;
			}
			while (num / 2090739092U != 0U);
			AutoUpdate.<>c__DisplayClass5_0 CS$<>8__locals3 = CS$<>8__locals2;
			num = 111613075U + num;
			string githubLatestReleaseUrl = AutoUpdate.GithubLatestReleaseUrl;
			num &= 1267625594U;
			CS$<>8__locals3.www = UnityWebRequest.Get(githubLatestReleaseUrl);
			num = (964833782U & num);
			AutoUpdate.<>c__DisplayClass5_0 CS$<>8__locals4 = CS$<>8__locals2;
			num -= 1223112043U;
			AsyncOperation asyncOperation = CS$<>8__locals4.www.SendWebRequest();
			object @object = CS$<>8__locals2;
			num = 1568673145U % num;
			Action<AsyncOperation> action = delegate(AsyncOperation operation)
			{
				uint num2 = 1438597426U;
				if (972825522U >= num2)
				{
					goto IL_24;
				}
				IL_11:
				bool flag = AutoUpdate.latestVersionFromGithub != null;
				num2 |= 146806860U;
				if (!flag)
				{
					goto IL_24;
				}
				return;
				IL_24:
				if (377359594U - num2 == 0U)
				{
					goto IL_11;
				}
				UnityWebRequest www = @object.www;
				num2 = 133637990U % num2;
				uint result = www.result;
				num2 = 1894931940U + num2;
				if (result == num2 + 2266397367U)
				{
					num2 ^= 806823713U;
				}
				else
				{
					if (2075021188U - num2 == 0U)
					{
						goto IL_11;
					}
					string str = "Error getting latest mod version: ";
					num2 = 174988192U - num2;
					string error = @object.www.error;
					num2 /= 848633980U;
					MelonLogger.Error(str + error);
					if (2076255606U >> (int)num2 != 0U)
					{
						return;
					}
				}
				num2 ^= 1862075062U;
				UnityWebRequest www2 = @object.www;
				num2 = (144662700U ^ num2);
				string url = www2.url;
				num2 *= 178856920U;
				ConsoleColor consoleColor = (ConsoleColor)(num2 ^ 925553234U);
				string str2 = "latestReleaseRedirectedUrl: ";
				string str3 = url;
				num2 >>= 4;
				MelonLogger.Msg(consoleColor, str2 + str3);
				num2 = 256847782U / num2;
				Match match = Regex.Match(url, "\\/tag\\/v(?<version>[\\d\\.]+)$");
				num2 -= 978995054U;
				if (num2 < 1817863818U)
				{
					goto IL_11;
				}
				Group group = match;
				num2 *= 1547662075U;
				bool success = group.Success;
				num2 = 57417691U * num2;
				if (success)
				{
					if (1127183127U * num2 == 0U)
					{
						goto IL_11;
					}
					AutoUpdate.latestVersionFromGithub = match.Groups["version"].Value;
					ConsoleColor consoleColor2 = (ConsoleColor)(num2 ^ 1650817644U);
					num2 >>= 11;
					string text = "Latest version: " + AutoUpdate.latestVersionFromGithub;
					num2 >>= 2;
					MelonLogger.Msg(consoleColor2, text);
					num2 = 183046956U / num2;
					bool checkUpdate2 = @object.checkUpdate;
					num2 ^= 1308107333U;
					if (checkUpdate2)
					{
						if (1208623371U > num2)
						{
							return;
						}
						AutoUpdate.CheckLocalVersionAndPrompt();
						num2 += 0U;
					}
					if (num2 - 903115900U != 0U)
					{
						return;
					}
					return;
				}
				else
				{
					num2 = (944054692U ^ num2);
					string text2 = "Failed to extract version number from github latest release's redirect URL";
					num2 = (1738220830U | num2);
					MelonLogger.Error(text2);
					if ((84820056U & num2) != 0U)
					{
						return;
					}
					goto IL_11;
				}
			};
			num ^= 1076044343U;
			asyncOperation.completed += action;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000525E8 File Offset: 0x0004FBE8
		private static void CheckLocalVersionAndPrompt()
		{
			uint num;
			for (;;)
			{
				Version version = new Version(AutoUpdate.latestVersionFromGithub);
				Version version2 = new Version("1.6.13");
				num = 837439921U;
				int num2 = version2.CompareTo(version);
				num ^= 1055068218U;
				uint num3 = num - 252264843U;
				num ^= 1259471126U;
				if (num2 >= num3)
				{
					goto IL_DD;
				}
				num /= 1908833337U;
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 10U);
				num >>= 14;
				string str = "New version available: ";
				string str2 = version.ToString();
				num = 791359938U >> (int)num;
				MelonLogger.Msg(consoleColor, str + str2);
				ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 791359944U);
				string str3 = "检测到mod新版本可用: ";
				num *= 2005559005U;
				object obj = version;
				num = 2032997686U % num;
				MelonLogger.Msg(consoleColor2, str3 + obj.ToString());
				num >>= 14;
				if (num != 174090220U)
				{
					object obj2 = version;
					num = 1495611782U * num;
					string latestModVersion = obj2.ToString();
					num *= 2045718815U;
					AutoUpdate.OpenUpdatePrompt(latestModVersion);
					if (num != 1723287884U)
					{
						break;
					}
				}
			}
			return;
			IL_DD:
			num /= 1540900924U;
			bool flag = AutoUpdate.hasIgnoredUpdate;
			num &= 1277435704U;
			if (!flag)
			{
				num = (1635385531U ^ num);
				ConsoleColor consoleColor3 = (ConsoleColor)(num ^ 1635385521U);
				num = 507277345U / num;
				string str4 = "当前已是最新版本mod: ";
				num >>= 29;
				Version version;
				string str5 = version.ToString();
				num /= 546849380U;
				MelonLogger.Msg(consoleColor3, str4 + str5);
				AutoUpdate.hasIgnoredUpdate = (num - uint.MaxValue != 0U);
				num += 0U;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0005273C File Offset: 0x0004FD3C
		private static void OpenUpdatePrompt(string latestModVersion)
		{
			uint num;
			string text;
			StringBuilder stringBuilder;
			string text4;
			UnityAction unityAction;
			for (;;)
			{
				IL_00:
				bool flag = Utils.IsChineseSystem();
				num = 2106596368U;
				bool flag2 = flag;
				if (1207059566U < num)
				{
					goto IL_17;
				}
				goto IL_2F;
				IL_44:
				num *= 643565930U;
				string text2;
				text = text2;
				num = (767766690U | num);
				for (;;)
				{
					stringBuilder = new StringBuilder();
					num = 218507497U / num;
					StringBuilder stringBuilder2 = stringBuilder;
					string format = "<color=green>{0}</color>";
					bool flag3 = flag2;
					num *= 1377783425U;
					object arg;
					if (!flag3)
					{
						num |= 873232512U;
						arg = "New version of Mod is available";
					}
					else
					{
						num -= 1744765761U;
						arg = "新版本mod已可用!";
						num += 2617998273U;
					}
					num = 754404710U % num;
					stringBuilder2.AppendLine(string.Format(format, arg));
					num = 1928279459U / num;
					StringBuilder stringBuilder3 = stringBuilder;
					string format2 = "{0}: <color=yellow>{1}</color>";
					object arg2;
					if (!flag2)
					{
						num &= 2049774662U;
						arg2 = "Current version";
					}
					else
					{
						num |= 1536717995U;
						arg2 = "当前版本";
						num += 2758249303U;
					}
					num |= 1889285623U;
					object arg3 = "1.6.13";
					num = (216339319U & num);
					stringBuilder3.AppendLine(string.Format(format2, arg2, arg3));
					num += 138936467U;
					StringBuilder stringBuilder4 = stringBuilder;
					string format3 = "{0}: <color=green>{1}</color>";
					object arg4;
					if (!flag2)
					{
						num = 1744592969U + num;
						arg4 = "Latest version";
					}
					else
					{
						num = (999227817U & num);
						arg4 = "最新版本";
						num ^= 2017751643U;
					}
					num = (1260220503U | num);
					num |= 793600825U;
					stringBuilder4.AppendLine(string.Format(format3, arg4, latestModVersion));
					num %= 1293684957U;
					string text3;
					if (!flag2)
					{
						num -= 911875982U;
						text3 = "Update";
					}
					else
					{
						text3 = "立即下载";
						num ^= 3466994102U;
					}
					text4 = text3;
					num ^= 2010658356U;
					if (num * 1315048080U == 0U)
					{
						goto IL_00;
					}
					Action action;
					bool flag4 = (action = AutoUpdate.<>c.<>9__7_0) != null;
					num = 738134905U >> (int)num;
					if (!flag4)
					{
						num >>= 21;
						if (num >= 683505748U)
						{
							goto IL_00;
						}
						object <> = AutoUpdate.<>c.<>9;
						num = 275975687U + num;
						Action action2 = delegate()
						{
							string format4 = "https://github.com/Liuhaixv/GGDH_ML/releases/download/v{0}/{1}";
							uint num2 = 74780659U;
							string url = string.Format(format4, AutoUpdate.latestVersionFromGithub, AutoUpdate.modFileName);
							string location = Assembly.GetExecutingAssembly().Location;
							num2 ^= 959531100U;
							string text8 = location;
							num2 = 177810490U + num2;
							string localPath = text8;
							num2 = (1763523095U ^ num2);
							AutoUpdate.OpenUpdateDownloadPanel(url, localPath, num2 - 784353790U != 0U);
						};
						num |= 1078854883U;
						action = action2;
						num = (398154579U ^ num);
						AutoUpdate.<>c.<>9__7_0 = action2;
						num += 3829053125U;
					}
					num = 609960800U / num;
					unityAction = action;
					if (num == 331243916U)
					{
						break;
					}
					Object instance = GlobalPanelsHandler.Instance;
					Object @object = null;
					num = 2079592749U << (int)num;
					bool flag5 = instance == @object;
					num |= 376451539U;
					if (!flag5)
					{
						goto IL_26E;
					}
					num = 2129746396U >> (int)num;
					if (num - 1531974664U != 0U)
					{
						goto Block_10;
					}
				}
				IL_17:
				if (!flag2)
				{
					num += 291642457U;
					text2 = "Update mod";
					goto IL_44;
				}
				IL_2F:
				num = 493042493U / num;
				text2 = "更新可用";
				num += 2398238825U;
				goto IL_44;
			}
			Block_10:
			MelonLogger.Error("GlobalPanelsHandler.Instance is null");
			return;
			IL_26E:
			num /= 1539453297U;
			GlobalPanelsHandler instance2 = GlobalPanelsHandler.Instance;
			num = 931534213U / num;
			string text5 = text;
			object obj = stringBuilder;
			num = 1256018850U >> (int)num;
			string text6 = obj.ToString();
			string text7 = text4;
			num = 1630559930U * num;
			UnityAction unityAction2 = unityAction;
			bool flag6 = (num ^ 398203923U) != 0U;
			num ^= 1226864658U;
			instance2.OpenOneButtonPromptPanel(text5, text6, text7, unityAction2, flag6);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00052A04 File Offset: 0x00050004
		public static void OpenUpdateDownloadPanel(string url, string localPath, bool downloadFinished = false)
		{
			uint num = 1710376890U;
			AutoUpdate.<>c__DisplayClass8_0 CS$<>8__locals1;
			for (;;)
			{
				IL_06:
				CS$<>8__locals1 = new AutoUpdate.<>c__DisplayClass8_0();
				for (;;)
				{
					CS$<>8__locals1.downloadFinished = downloadFinished;
					num = (176896827U & num);
					for (;;)
					{
						Object instance = GlobalPanelsHandler.Instance;
						num = 1329748095U % num;
						Object @object = null;
						num /= 30084225U;
						if (instance == @object)
						{
							return;
						}
						num ^= 888176300U;
						if (1704408780U >> (int)num == 0U)
						{
							goto IL_06;
						}
						bool flag = Utils.IsChineseSystem();
						num = (282596719U ^ num);
						AutoUpdate.<>c__DisplayClass8_0 CS$<>8__locals2 = CS$<>8__locals1;
						num /= 307638867U;
						bool downloadFinished2 = CS$<>8__locals2.downloadFinished;
						num /= 1743270203U;
						string text2;
						if (!downloadFinished2)
						{
							string text;
							if (!flag)
							{
								num += 140583002U;
								if (num == 794583001U)
								{
									goto IL_06;
								}
								text = "Downloading...";
							}
							else
							{
								text = "正在下载更新中...";
								num ^= 140583002U;
							}
							text2 = text;
						}
						else
						{
							string text3;
							if (!flag)
							{
								text3 = "Updated";
							}
							else
							{
								text3 = "更新完毕";
								num += 0U;
							}
							text2 = text3;
							num += 140583002U;
						}
						num &= 917974750U;
						StringBuilder stringBuilder = new StringBuilder();
						num += 725380224U;
						if ((num ^ 186660568U) == 0U)
						{
							break;
						}
						AutoUpdate.<>c__DisplayClass8_0 CS$<>8__locals3 = CS$<>8__locals1;
						num = 120879415U / num;
						if (!CS$<>8__locals3.downloadFinished)
						{
							StringBuilder stringBuilder2 = stringBuilder;
							num = (627794039U & num);
							string format = "{0}<color=yellow>{1}</color>";
							bool flag2 = flag;
							num = 250088703U - num;
							object arg;
							if (!flag2)
							{
								arg = "Current Version:";
							}
							else
							{
								arg = "当前版本:";
								num ^= 0U;
							}
							string value = string.Format(format, arg, "1.6.13");
							num &= 820203598U;
							stringBuilder2.AppendLine(value);
							num <<= 15;
							if (1572428071U < num)
							{
								continue;
							}
							StringBuilder stringBuilder3 = stringBuilder;
							string format2 = "{0}<color=green>{1}</color>";
							object arg2;
							if (!flag)
							{
								arg2 = "Latest Version:";
							}
							else
							{
								num = 23684967U + num;
								arg2 = "最新版本:";
								num ^= 28796775U;
							}
							stringBuilder3.AppendLine(string.Format(format2, arg2, AutoUpdate.latestVersionFromGithub));
							num = 1836282281U - num;
							num = 1523524504U % num;
							StringBuilder stringBuilder4 = stringBuilder;
							string format3 = "<align=left>{0}</align>";
							num -= 1913683120U;
							bool flag3 = flag;
							num = 940990537U << (int)num;
							object arg3;
							if (!flag3)
							{
								arg3 = "Downloading latest mod in the background...";
							}
							else
							{
								arg3 = "正在后台下载最新mod中...如果长时间未下载完毕有可能是加速器问题，可以考虑手动下载替换mod";
								num += 0U;
							}
							num = 1658289389U + num;
							stringBuilder4.AppendLine(string.Format(format3, arg3));
							num *= 465791958U;
							StringBuilder stringBuilder5 = stringBuilder;
							num |= 1243094780U;
							string format4 = "<align=left>{0}</align>";
							object arg4;
							if (!flag)
							{
								arg4 = "The latest mod will automatically replace the old one, and the game needs to be restarted to take effect then";
							}
							else
							{
								arg4 = "下载完毕后mod将自动替换旧版文件，重启游戏即可";
								num ^= 0U;
							}
							num = 1814502292U + num;
							stringBuilder5.AppendLine(string.Format(format4, arg4));
							if (2031444121U / num != 0U)
							{
								goto IL_06;
							}
						}
						else
						{
							num %= 1438386155U;
							if (468539940U + num == 0U)
							{
								break;
							}
							StringBuilder stringBuilder6 = stringBuilder;
							num -= 515996702U;
							string format5 = "<color=green>{0}</color>{1}";
							bool flag4 = flag;
							num = (1141602504U & num);
							object arg5;
							if (!flag4)
							{
								arg5 = "Mod is up to date now:";
							}
							else
							{
								arg5 = "当前已是最新版本:";
								num ^= 0U;
							}
							num /= 1876568218U;
							string value2 = string.Format(format5, arg5, AutoUpdate.latestVersionFromGithub);
							num = 8545997U >> (int)num;
							stringBuilder6.AppendLine(value2);
							num /= 1225137260U;
							StringBuilder stringBuilder7 = stringBuilder;
							num = 2055482579U << (int)num;
							string format6 = "<size=150%><color=green>{0}</color></size>";
							object arg6;
							if (!flag)
							{
								num &= 174787189U;
								arg6 = "The latest mod has been downloaded!\nRestart game to take effect";
							}
							else
							{
								arg6 = "最新mod已经下载完毕！\n重启游戏后生效";
								num += 2407259006U;
							}
							string value3 = string.Format(format6, arg6);
							num = 354508193U * num;
							stringBuilder7.AppendLine(value3);
							num ^= 3747880035U;
						}
						num |= 55661384U;
						if (num * 1726165896U == 0U)
						{
							goto IL_06;
						}
						string text5;
						if (!CS$<>8__locals1.downloadFinished)
						{
							if (num / 763180611U == 0U)
							{
								break;
							}
							string text4;
							if (!flag)
							{
								text4 = "Downloading...Please wait";
							}
							else
							{
								num >>= 29;
								text4 = "正在下载中...请等待";
								num ^= 3680500700U;
							}
							text5 = text4;
							if (1830890458U * num == 0U)
							{
								goto IL_06;
							}
						}
						else
						{
							if ((899089987U & num) == 0U)
							{
								goto IL_06;
							}
							bool flag5 = flag;
							num = 381959741U - num;
							string text6;
							if (!flag5)
							{
								num &= 1823936044U;
								if (num == 1790251830U)
								{
									break;
								}
								text6 = "Quit game";
							}
							else
							{
								num %= 1085421895U;
								if ((1734441719U & num) == 0U)
								{
									break;
								}
								text6 = "关闭游戏";
								num ^= 322977859U;
							}
							num &= 1549408124U;
							text5 = text6;
							num ^= 3546282490U;
						}
						num = 928085740U << (int)num;
						object object2 = CS$<>8__locals1;
						num *= 652236087U;
						IntPtr method = ldftn(<OpenUpdateDownloadPanel>b__0);
						num = 1189752691U * num;
						Action action = new Action(object2, method);
						num &= 393750539U;
						UnityAction unityAction = action;
						num ^= 1716652063U;
						UnityAction unityAction2 = unityAction;
						num = 227083267U % num;
						GlobalPanelsHandler.Instance.OpenOneButtonPromptPanel(text2, stringBuilder.ToString(), text5, unityAction2, (num ^ 227083266U) != 0U);
						if (num % 1744845950U != 0U)
						{
							goto Block_27;
						}
					}
				}
			}
			return;
			Block_27:
			bool downloadFinished3 = CS$<>8__locals1.downloadFinished;
			num >>= 23;
			if (!downloadFinished3)
			{
				num = 1448307622U * num;
				num += 1077573071U;
				Action <>9__8_ = AutoUpdate.<>c.<>9__8_1;
				num = 552763389U / num;
				Action onCompleted = <>9__8_;
				if (<>9__8_ == null)
				{
					Action action2 = delegate()
					{
						uint num2;
						do
						{
							string url2 = "";
							string localPath2 = "";
							bool downloadFinished4 = true;
							num2 = 533614289U;
							AutoUpdate.OpenUpdateDownloadPanel(url2, localPath2, downloadFinished4);
						}
						while (1210607146U * num2 == 0U);
					};
					num = 1976596569U << (int)num;
					onCompleted = action2;
					num = 1858806811U / num;
					AutoUpdate.<>c.<>9__8_1 = action2;
					num += 0U;
				}
				num = (474378288U ^ num);
				AutoUpdate.DownloadLatestModAndReplaceOldMod(url, localPath, onCompleted);
				num += 3820589035U;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00052F08 File Offset: 0x00050508
		private static void DownloadLatestModAndReplaceOldMod(string url, string localFilePath, Action onCompleted)
		{
			uint num;
			AutoUpdate.<>c__DisplayClass9_0 CS$<>8__locals2;
			do
			{
				AutoUpdate.<>c__DisplayClass9_0 CS$<>8__locals1 = new AutoUpdate.<>c__DisplayClass9_0();
				num = 691498757U;
				CS$<>8__locals2 = CS$<>8__locals1;
				num = 1576172640U / num;
			}
			while (num == 1340430772U);
			for (;;)
			{
				AutoUpdate.<>c__DisplayClass9_0 CS$<>8__locals3 = CS$<>8__locals2;
				num %= 828902685U;
				CS$<>8__locals3.localFilePath = localFilePath;
				if (num - 2088652823U != 0U)
				{
					AutoUpdate.<>c__DisplayClass9_0 CS$<>8__locals4 = CS$<>8__locals2;
					num /= 327943133U;
					CS$<>8__locals4.onCompleted = onCompleted;
					if (num < 1896371462U)
					{
						break;
					}
				}
			}
			AutoUpdate.<>c__DisplayClass9_0 CS$<>8__locals5 = CS$<>8__locals2;
			UnityWebRequest www = UnityWebRequest.Get(url);
			num <<= 2;
			CS$<>8__locals5.www = www;
			if (num <= 2046643384U)
			{
				do
				{
					AsyncOperation asyncOperation = CS$<>8__locals2.www.SendWebRequest();
					object @object = CS$<>8__locals2;
					IntPtr method = ldftn(<DownloadLatestModAndReplaceOldMod>b__0);
					num %= 658201367U;
					Action<AsyncOperation> action = new Action<AsyncOperation>(@object, method);
					num += 1363359117U;
					asyncOperation.completed += action;
				}
				while ((830937395U ^ num) == 0U);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00052FC8 File Offset: 0x000505C8
		public static void OpenDownloadFailedPanel()
		{
			for (;;)
			{
				Object instance = GlobalPanelsHandler.Instance;
				Object @object = null;
				uint num = 2083535276U;
				if (instance == @object && 1866421782U != num)
				{
					break;
				}
				bool flag = Utils.IsChineseSystem();
				num *= 1298872044U;
				if (num * 1818568428U != 0U && 1315505807U <= num)
				{
					string text;
					if (!flag)
					{
						text = "Download Failed";
					}
					else
					{
						if (num < 1598635506U)
						{
							break;
						}
						text = "下载失败";
						num ^= 0U;
					}
					num = 449911052U % num;
					string text2 = text;
					StringBuilder stringBuilder = new StringBuilder();
					num /= 781740802U;
					StringBuilder stringBuilder2 = stringBuilder;
					string format = "{0}";
					num = 1309425587U << (int)num;
					object arg;
					if (!flag)
					{
						num = 1157959662U + num;
						arg = "Download failed! Please download latest mod manually";
					}
					else
					{
						arg = "下载失败！请手动下载最新mod替换...";
						num += 1157959662U;
					}
					stringBuilder2.AppendLine(string.Format(format, arg));
					num = 238777030U - num;
					if (1370914126U == num)
					{
						break;
					}
					if (1244071842U * num != 0U)
					{
						bool flag2 = flag;
						num = 104081339U << (int)num;
						string text3;
						if (!flag2)
						{
							text3 = "Download";
						}
						else
						{
							num = 747394243U % num;
							text3 = "手动下载";
							num ^= 3926434723U;
						}
						num = 230825084U % num;
						string text4 = text3;
						num = (1712735158U | num);
						if ((2050902403U ^ num) != 0U)
						{
							Action action;
							bool flag3 = (action = AutoUpdate.<>c.<>9__10_0) != null;
							num = 159465847U % num;
							if (!flag3)
							{
								num = 175323990U + num;
								if (num + 382664726U == 0U)
								{
									break;
								}
								Action <>9__10_ = action = delegate()
								{
									uint num2 = 1771460081U;
									if (793067905U >= num2)
									{
										goto IL_30;
									}
									IL_11:
									Process.Start("https://github.com/Liuhaixv/GGDH_ML/releases");
									num2 /= 1593071260U;
									if (num2 / 1440363605U != 0U)
									{
										return;
									}
									IL_30:
									AutoUpdate.QuitGame();
									if (1761749029U - num2 == 0U)
									{
										goto IL_11;
									}
								};
								num /= 138087537U;
								AutoUpdate.<>c.<>9__10_0 = <>9__10_;
								num += 159465845U;
							}
							UnityAction unityAction = action;
							num &= 1317937333U;
							UnityAction unityAction2 = unityAction;
							num = 1259294746U % num;
							if (1717320109U >= num)
							{
								GlobalPanelsHandler instance2 = GlobalPanelsHandler.Instance;
								num |= 957180914U;
								string text5 = text2;
								num >>= 13;
								string text6 = stringBuilder.ToString();
								num ^= 16789702U;
								instance2.OpenOneButtonPromptPanel(text5, text6, text4, unityAction2, num - 16894140U != 0U);
								if (num / 1036942924U == 0U)
								{
									return;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000531FC File Offset: 0x000507FC
		private static void QuitGame()
		{
			uint num = 481824196U;
			if (568467499U <= num)
			{
				goto IL_1E;
			}
			IL_11:
			PlayerPrefs.Save();
			num = 1297758672U + num;
			IL_1E:
			Application.Quit();
			if (661811901U % num != 0U)
			{
				return;
			}
			goto IL_11;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00053238 File Offset: 0x00050838
		public AutoUpdate()
		{
			uint num = 388067739U;
			if ((841685078U ^ num) != 0U)
			{
				num |= 735922317U;
				base..ctor();
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00053268 File Offset: 0x00050868
		// Note: this type is marked as 'beforefieldinit'.
		static AutoUpdate()
		{
			uint num = 1609566948U;
			do
			{
				string githubLatestReleaseUrl = "https://github.com/Liuhaixv/GGDH_ML/releases/latest";
				num |= 1567325500U;
				AutoUpdate.GithubLatestReleaseUrl = githubLatestReleaseUrl;
				num = (437133542U ^ num);
				AutoUpdate.hasIgnoredUpdate = ((num ^ 1173708570U) != 0U);
				AutoUpdate.modFileName = "GGD_Hack_Mod.dll";
				num /= 1237942038U;
			}
			while (1906077567U == num);
			string text = null;
			num = 1737044050U >> (int)num;
			AutoUpdate.latestVersionFromGithub = text;
		}

		// Token: 0x0400013A RID: 314
		private static string GithubLatestReleaseUrl;

		// Token: 0x0400013B RID: 315
		private static bool hasIgnoredUpdate;

		// Token: 0x0400013C RID: 316
		private static string modFileName;

		// Token: 0x0400013D RID: 317
		private static string latestVersionFromGithub;

		// Token: 0x02000089 RID: 137
		[HarmonyPatch(typeof(SceneManager), "Internal_SceneLoaded")]
		private class SceneManager_
		{
			// Token: 0x060001F8 RID: 504 RVA: 0x0006397C File Offset: 0x00060F7C
			private static void Postfix(Scene scene)
			{
				uint num = 895246520U;
				if (num + 1374568124U != 0U)
				{
					do
					{
						string text = "正在检查版本更新";
						num = 1040386320U * num;
						MelonLogger.Msg(text);
						if (1870090180 << (int)num == 0)
						{
							break;
						}
						AutoUpdate.CheckLatestModVersion();
					}
					while (num - 1490244093U == 0U);
				}
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x000639D0 File Offset: 0x00060FD0
			public SceneManager_()
			{
				uint num;
				do
				{
					num = 83107110U;
					base..ctor();
				}
				while (1250388336U < num);
			}
		}
	}
}
