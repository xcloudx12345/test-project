using System;
using System.Diagnostics;
using System.Net;
using System.Net.Security;
using GGD_Hack.Features;
using GGD_Hack.Features.Test;
using GGD_Hack.Hook;
using GGD_Hack.MyForms;
using GGD_Hack.Utils;
using MelonLoader;
using MelonLoader.Preferences;
using UnityEngine;

namespace GGD_Hack
{
	// Token: 0x02000008 RID: 8
	public class GGDHack_Mod : MelonMod
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0004E214 File Offset: 0x0004B814
		public override void OnInitializeMelon()
		{
			string text = "OnInitializeMelon";
			uint num = 762511767U;
			MelonLogger.Msg(text);
			string text2 = "GGDH";
			num %= 1910720380U;
			MelonPreferences.CreateCategory(text2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0004E244 File Offset: 0x0004B844
		public override void OnLateInitializeMelon()
		{
			string text = "OnLateInitializeMelon";
			uint num = 1395139495U;
			MelonLogger.Msg(text);
			try
			{
				int num3;
				do
				{
					int num2 = (int)(num + 2899857042U);
					num = 2133621072U << (int)num;
					num3 = num2;
					num = 729770434U - num;
				}
				while (num >> 15 == 0U);
				int port = num3;
				num = 2123716288U - num;
				if (!TCPTestServer.IsPortAvailable(port))
				{
					string str = "端口 ";
					num = (1579118895U | num);
					MelonLogger.Error(str + num3.ToString() + " 已被占用");
					string text2 = "TCP服务器启动失败！如果你是多开游戏请忽略";
					num %= 1391469798U;
					MelonLogger.Error(text2);
					return;
				}
				do
				{
					int port2 = (int)(num ^ 3914524359U);
					num -= 259672570U;
					new TCPTestServer(port2).Start();
				}
				while ((num ^ 1380862923U) == 0U);
			}
			catch (Exception ex)
			{
				num = 614888399U;
				string str2 = "TCP服务器启动失败！如果你是多开游戏请忽略:";
				num = (230693225U | num);
				Exception ex2 = ex;
				num = 1706457484U / num;
				string text3 = str2 + ex2.Message;
				num += 420418752U;
				MelonLogger.Error(text3);
			}
			this.CheckModVersion();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0004E364 File Offset: 0x0004B964
		public override void OnSceneWasLoaded(int buildindex, string sceneName)
		{
			this.Init();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0004E380 File Offset: 0x0004B980
		public override void OnSceneWasInitialized(int buildindex, string sceneName)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0004E390 File Offset: 0x0004B990
		public override void OnUpdate()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0004E3A0 File Offset: 0x0004B9A0
		public override void OnFixedUpdate()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0004E3B0 File Offset: 0x0004B9B0
		public override void OnLateUpdate()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0004E3C0 File Offset: 0x0004B9C0
		public override void OnGUI()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0004E3D0 File Offset: 0x0004B9D0
		public override void OnApplicationQuit()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0004E3E0 File Offset: 0x0004B9E0
		public override void OnPreferencesSaved()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0004E3F0 File Offset: 0x0004B9F0
		public override void OnPreferencesLoaded()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0004E400 File Offset: 0x0004BA00
		private void Init()
		{
			uint num;
			for (;;)
			{
				IL_00:
				RemoteCertificateValidationCallback <>9__11_ = GGDHack_Mod.<>c.<>9__11_0;
				num = 356134646U;
				RemoteCertificateValidationCallback serverCertificateValidationCallback = <>9__11_;
				num %= 2134783805U;
				if (<>9__11_ != null)
				{
					goto IL_6B;
				}
				num &= 707294759U;
				num /= 482548085U;
				if (num < 2060872603U)
				{
					goto IL_35;
				}
				for (;;)
				{
					IL_AB:
					RemoteKillPlayer.Init();
					if (num >> 0 == 0U)
					{
						goto IL_35;
					}
					for (;;)
					{
						RandomName.Init();
						RandomJoinRoom.Init();
						num -= 2108235169U;
						if (num * 1351818201U == 0U)
						{
							goto IL_35;
						}
						MinimapRecorder.Init();
						if (num < 445545237U)
						{
							goto IL_00;
						}
						DecreaseCooldown.Init();
						AverageKillButtonToKillButton.Init();
						num = 2050436993U % num;
						if (num + 12478132U == 0U)
						{
							goto IL_80;
						}
						DeathAlarm.Init();
						num &= 1058110018U;
						if (num - 1614511025U == 0U)
						{
							goto IL_00;
						}
						OneTapCompleteTask.Init();
						num += 1055330807U;
						AutoThrowAwayBomb.Init();
						if (num * 1449541450U == 0U)
						{
							goto IL_35;
						}
						AutoTasks.Init();
						num = (1125540093U ^ num);
						EsperBlockSpectate.Init();
						if (num == 2140345927U)
						{
							goto IL_00;
						}
						AutoStartGame.Init();
						AutoReady.Init();
						Moonwalk.Init();
						if (1730965704U < num)
						{
							goto IL_00;
						}
						MinimapTeleport.Init();
						num >>= 11;
						if ((num ^ 980905640U) == 0U)
						{
							goto IL_80;
						}
						MinimapESP.Init();
						num ^= 544170395U;
						InfiniteSkillDistance.Init();
						RemoveFOW.Init();
						num = (473265578U & num);
						if (num >= 114559030U)
						{
							break;
						}
						RemoveRoofs.Init();
						if (433731363U % num != 0U)
						{
							goto Block_11;
						}
					}
				}
				Block_11:
				BombIndicator.Init();
				AutoTrackBodies.Init();
				if ((1635480099U ^ num) == 0U)
				{
					continue;
				}
				ShowAllUnlockables.Init();
				AutoKicker.Init();
				if (num >= 878531812U)
				{
					goto IL_35;
				}
				ForceEnableRoleRevealText.Init();
				AllowToSeeDeadPlayersChatMessagesInVotingScene.Init();
				num ^= 1338838206U;
				if (934638045U != num)
				{
					break;
				}
				continue;
				IL_80:
				CommandHandler.Init();
				num ^= 972312095U;
				UnityMainThreadDispatcher.Init();
				num = 1189675946U % num;
				if (num % 1371175284U != 0U)
				{
					BlacklistedAccountIndicator.Init();
					goto IL_AB;
				}
				continue;
				IL_6B:
				num = 2134057228U % num;
				ServicePointManager.ServerCertificateValidationCallback = serverCertificateValidationCallback;
				num = (1616130028U | num);
				goto IL_80;
				IL_35:
				object <> = GGDHack_Mod.<>c.<>9;
				num = 459625536U * num;
				IntPtr method = ldftn(<Init>b__11_0);
				num = (1196951987U ^ num);
				RemoteCertificateValidationCallback remoteCertificateValidationCallback = new RemoteCertificateValidationCallback(<>, method);
				num = 58075065U % num;
				serverCertificateValidationCallback = remoteCertificateValidationCallback;
				GGDHack_Mod.<>c.<>9__11_0 = remoteCertificateValidationCallback;
				num ^= 374081871U;
				goto IL_6B;
			}
			object @object = null;
			num += 1299582442U;
			Action action = new Action(@object.MoveShuttle);
			num = 165969777U << (int)num;
			SendFartHook.bindAction(action);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0004E648 File Offset: 0x0004BC48
		private bool CheckModVersion()
		{
			uint num = 1880101447U;
			Time.timeScale = 0f;
			for (;;)
			{
				string a = "2.19.02";
				num >>= 22;
				string version = Application.version;
				num -= 1756915688U;
				bool flag = a != version;
				num = 46402201U * num;
				if (!flag)
				{
					goto IL_FF;
				}
				string str = "Mod only works with game version:2.19.02\nCurrent game version:";
				num &= 1294815675U;
				string version2 = Application.version;
				num *= 1542391600U;
				string text = str + version2 + "\nMod outdated already!";
				num *= 1236543995U;
				string str2 = "Mod对应游戏版本:2.19.02\n当前游戏版本:";
				string version3 = Application.version;
				num = (1052126390U | num);
				string str3 = "\nMod已过期!";
				num = 1294234313U * num;
				string text2 = str2 + version3 + str3;
				for (;;)
				{
					string message;
					if (!Utils.IsChineseSystem())
					{
						if ((191693475U ^ num) == 0U)
						{
							continue;
						}
						message = text;
					}
					else
					{
						if (1881693081U > num)
						{
							break;
						}
						message = text2;
						num += 0U;
					}
					MyMessageBox.Show(message);
					num <<= 28;
					if (num >> 26 != 0U)
					{
						goto Block_5;
					}
				}
			}
			Block_5:
			string fileName = "https://github.com/Liuhaixv/GGDH_ML";
			num = (2054644567U & num);
			Process.Start(fileName);
			num = 2062955783U - num;
			Application.Quit();
			return (num ^ 452343047U) != 0U;
			IL_FF:
			num &= 800029379U;
			float timeScale = 1f;
			num = (463806062U & num);
			Time.timeScale = timeScale;
			return (num ^ 186974721U) != 0U;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0004E778 File Offset: 0x0004BD78
		private void WarningFree()
		{
			for (;;)
			{
				float timeScale = 0f;
				uint num = 849225794U;
				Time.timeScale = timeScale;
				num = 164719615U >> (int)num;
				bool hasWarnedFree = GGDHack_Mod.HasWarnedFree;
				num = (638077193U & num);
				if (!hasWarnedFree)
				{
					num <<= 23;
					string text = "This mod was developed by Liuhaixv@github.com\nThe mod is free, if you bought it somewhere, you are scammed";
					num %= 682040720U;
					string text2 = text;
					string text3 = "本mod由Liuhaixv@github.com开发\n该mod完全免费，如果你从别处购买到，那你就是大冤种";
					num = (1502285612U & num);
					bool flag = Utils.IsChineseSystem();
					num = 408777946U * num;
					string message;
					if (!flag)
					{
						message = text2;
					}
					else
					{
						message = text3;
						num ^= 0U;
					}
					num += 1951554420U;
					MyMessageBox.Show(message);
					num = 828469721U % num;
					GGDHack_Mod.HasWarnedFree = (num + 3466497576U != 0U);
					num ^= 862009808U;
				}
				num %= 1216491684U;
				if (num <= 1201279728U)
				{
					Time.timeScale = 1f;
					if (num <= 878920881U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0004E84C File Offset: 0x0004BE4C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0004E974 File Offset: 0x0004BF74
		public static bool HasWarnedFree
		{
			get
			{
				uint num = 419109751U;
				string text2;
				if (1561801224U * num != 0U)
				{
					string text = "HasWarnedFree";
					num <<= 11;
					text2 = text;
					num = 1693668163U % num;
				}
				string str = "1.6.132.19.02";
				string version = Application.version;
				DateTime utcNow = DateTime.UtcNow;
				num ^= 632634923U;
				num = 1166368476U - num;
				string str2 = utcNow.ToString("yyyy-MM-dd");
				num += 1414930811U;
				string input = str + version + str2;
				num = (2031779614U | num);
				string md5Hash = MD5Util.GetMd5Hash(input);
				num = (331440605U ^ num);
				string text3 = "GGDH";
				string text4 = text2;
				num %= 1405419919U;
				MelonPreferences_Entry<string> melonPreferences_Entry = MelonPreferences.GetEntry<string>(text3, text4);
				num = 2105697902U << (int)num;
				if (melonPreferences_Entry == null)
				{
					num *= 1589788160U;
					string text5 = "GGDH";
					num = 935091070U << (int)num;
					string text6 = text2;
					num *= 1968714186U;
					string text7 = "";
					num |= 1943892111U;
					string text8 = null;
					string text9 = null;
					bool flag = num - 1946124271U != 0U;
					num = 1237285223U * num;
					bool flag2 = (num ^ 160788521U) != 0U;
					num = (111301364U & num);
					ValueValidator valueValidator = null;
					num = 484645118U % num;
					melonPreferences_Entry = MelonPreferences.CreateEntry<string>(text5, text6, text7, text8, text9, flag, flag2, valueValidator);
					num += 857652770U;
				}
				MelonPreferences_Entry<string> melonPreferences_Entry2 = melonPreferences_Entry;
				num = 1083713624U % num;
				return md5Hash == melonPreferences_Entry2.Value;
			}
			set
			{
				uint num = 896929969U;
				for (;;)
				{
					IL_06:
					string text = "HasWarnedFree";
					num = 1676886590U >> (int)num;
					string text2 = text;
					num = 26231567U * num;
					if (992573471U + num != 0U)
					{
						MelonPreferences_Entry<string> melonPreferences_Entry;
						for (;;)
						{
							string str = "正在设置已提示过免费警告:";
							num = 1115643880U * num;
							string str2 = text2;
							num /= 694487714U;
							string text3 = str + str2;
							num = 421668840U - num;
							MelonLogger.Msg(text3);
							num = (656873454U ^ num);
							if ((1658002704U ^ num) == 0U)
							{
								goto IL_06;
							}
							for (;;)
							{
								string text4 = "GGDH";
								num = 924479775U * num;
								melonPreferences_Entry = MelonPreferences.GetEntry<string>(text4, text2);
								num = 379936444U << (int)num;
								bool flag = melonPreferences_Entry != null;
								num = 573184651U - num;
								if (!flag)
								{
									if (num == 338962014U)
									{
										break;
									}
									string text5 = "GGDH";
									num = 104223147U >> (int)num;
									string text6 = text2;
									num &= 295056941U;
									string text7 = "";
									num = (1592730424U ^ num);
									string text8 = null;
									string text9 = null;
									bool flag2 = num + 2702236368U != 0U;
									bool flag3 = num + 2702236368U != 0U;
									num -= 1129254034U;
									melonPreferences_Entry = MelonPreferences.CreateEntry<string>(text5, text6, text7, text8, text9, flag2, flag3, null);
									num ^= 1359610389U;
								}
								num = 1694523365U + num;
								if ((num ^ 630199154U) != 0U)
								{
									goto Block_3;
								}
							}
						}
						Block_3:
						if (value)
						{
							if (num == 1305560380U)
							{
								continue;
							}
							string str3 = "1.6.132.19.02";
							num >>= 8;
							string version = Application.version;
							num /= 954289779U;
							DateTime utcNow = DateTime.UtcNow;
							num = (501694448U & num);
							string format = "yyyy-MM-dd";
							num = 1259359000U - num;
							string str4 = utcNow.ToString(format);
							num = 95696355U >> (int)num;
							string md5Hash = MD5Util.GetMd5Hash(str3 + version + str4);
							MelonPreferences_Entry<string> melonPreferences_Entry2 = melonPreferences_Entry;
							num >>= 18;
							string value2 = md5Hash;
							num = 609485174U << (int)num;
							melonPreferences_Entry2.Value = value2;
							if (num << 20 == 0U)
							{
								continue;
							}
						}
						else
						{
							num = 1458700978U - num;
							MelonPreferences_Entry<string> melonPreferences_Entry3 = melonPreferences_Entry;
							num &= 1742365549U;
							string value3 = "";
							num &= 628702024U;
							melonPreferences_Entry3.Value = value3;
							num ^= 18088246U;
						}
						MelonPreferences.Save();
						if (965745904U + num != 0U)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0004EB60 File Offset: 0x0004C160
		public GGDHack_Mod()
		{
			uint num = 2096642597U;
			do
			{
				base..ctor();
			}
			while (747076464U >= num);
		}
	}
}
