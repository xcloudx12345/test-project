using System;
using ExitGames.Client.Photon;
using GGD_Hack.Utils;
using Handlers.CommonHandlers.UIHandlers;
using Handlers.MenuSceneHandlers;
using HarmonyLib;
using MelonLoader;
using MelonLoader.Preferences;
using Photon.Realtime;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;

namespace GGD_Hack.Features.Test
{
	// Token: 0x0200005A RID: 90
	[RegisterTypeInIl2Cpp]
	public class BlacklistedAccountIndicator : MonoBehaviour
	{
		// Token: 0x0600016D RID: 365 RVA: 0x0005D4FC File Offset: 0x0005AAFC
		public BlacklistedAccountIndicator(IntPtr ptr)
		{
			uint num = 1835489005U;
			if (168955708U <= num)
			{
				num = 547775304U * num;
				base..ctor(ptr);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0005D52C File Offset: 0x0005AB2C
		public BlacklistedAccountIndicator()
		{
			uint num = 1146974152U;
			do
			{
				base..ctor(ClassInjector.DerivedConstructorPointer<BlacklistedAccountIndicator>());
			}
			while (1657241063U % num == 0U);
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0005D55C File Offset: 0x0005AB5C
		public static void Init()
		{
			uint num = 551426779U;
			if ((48833358U ^ num) == 0U)
			{
				goto IL_7D;
			}
			GameObject gameObject;
			do
			{
				IL_12:
				string text = "ML_Manager";
				num /= 198139315U;
				gameObject = GameObject.Find(text);
				num = (1486173118U ^ num);
			}
			while ((1838951668U ^ num) == 0U);
			IL_39:
			if (!(gameObject == null))
			{
				goto IL_8B;
			}
			if (num < 168563128U)
			{
				goto IL_12;
			}
			string text2 = "ML_Manager";
			num = 858344522U - num;
			GameObject gameObject2 = new GameObject(text2);
			num = 462377079U >> (int)num;
			gameObject = gameObject2;
			if (num >> 18 != 0U)
			{
				goto IL_8B;
			}
			IL_7D:
			Object.DontDestroyOnLoad(gameObject);
			num ^= 1486183809U;
			IL_8B:
			GameObject gameObject3 = gameObject;
			num = 60104847U << (int)num;
			Object component = gameObject3.GetComponent<BlacklistedAccountIndicator>();
			Object @object = null;
			num = 1025206614U << (int)num;
			bool flag = component == @object;
			num *= 2049128311U;
			if (flag)
			{
				num = (1340158169U | num);
				if (num == 1294628519U)
				{
					goto IL_39;
				}
				BlacklistedAccountIndicator instance = gameObject.AddComponent<BlacklistedAccountIndicator>();
				num >>= 24;
				BlacklistedAccountIndicator.Instance = instance;
				num ^= 2921426965U;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0005D658 File Offset: 0x0005AC58
		private void Update()
		{
			uint num = 713364016U;
			if (1633832481U != num)
			{
				while (BlacklistedAccountIndicator.showBan)
				{
					if (num + 653727821U != 0U)
					{
						goto IL_27;
					}
				}
				return;
			}
			IL_27:
			float time = Time.time;
			float num2 = BlacklistedAccountIndicator.showTime;
			num ^= 0U;
			if (time > num2)
			{
				num = (796816413U & num);
				BlacklistedAccountIndicator.showBan = ((num ^ 704909328U) != 0U);
				num *= 1441355961U;
				BlacklistedAccountIndicator.showTime = -1f;
				num = 1929135418U + num;
				BlacklistedAccountIndicator.ShowBan();
				num ^= 243561210U;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0005D6E0 File Offset: 0x0005ACE0
		private static void ShowBan()
		{
			uint num;
			string text4;
			string text6;
			string text8;
			for (;;)
			{
				bool flag = Utils.IsChineseSystem();
				num = 744554795U;
				num /= 2070505112U;
				string text;
				if (!flag)
				{
					num /= 1003170436U;
					text = "It seems that your account has been <color=black>banned</color>, you can clear cache and login with another account";
				}
				else
				{
					text = "你可能注意到了游戏一直在主菜单转圈，这说明你的账号极大可能已被服务器<color=black>拉黑</color>。\n你可以清理缓存或登出来重新登陆其他账号。";
					num += 0U;
				}
				string text2 = text;
				string text3;
				if (!flag)
				{
					num = 1628071752U >> (int)num;
					text3 = "Warning";
				}
				else
				{
					text3 = "严重警告";
					num ^= 1628071752U;
				}
				text4 = text3;
				string text5 = text2;
				num = 2069061274U - num;
				text6 = text5;
				num = 1891764131U + num;
				num *= 443768955U;
				string text7;
				if (!flag)
				{
					text7 = "WTF";
				}
				else
				{
					text7 = "???";
					num ^= 0U;
				}
				text8 = text7;
				num += 1026324556U;
				if (!flag)
				{
					break;
				}
				if (655576521U < num)
				{
					goto Block_4;
				}
			}
			num %= 1017251530U;
			string text9 = "Logout and quit";
			goto IL_DA;
			Block_4:
			text9 = "登出并关闭游戏";
			num ^= 2395214444U;
			IL_DA:
			num %= 1383399451U;
			string text10 = text9;
			GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
			num >>= 21;
			string text11 = text4;
			string text12 = text6.ToString();
			num /= 603742976U;
			string text13 = text8;
			Action action;
			bool flag2 = (action = BlacklistedAccountIndicator.<>c.<>9__8_0) != null;
			num ^= 1872915718U;
			if (!flag2)
			{
				num = 1211763742U * num;
				object <> = BlacklistedAccountIndicator.<>c.<>9;
				num /= 1285977491U;
				Action action2 = delegate()
				{
					uint num2 = 1584216953U;
					GlobalPanelsHandler instance2 = GlobalPanelsHandler.Instance;
					num2 = (2017791754U ^ num2);
					instance2.ClosePanels();
				};
				num = (1877885361U & num);
				action = action2;
				num <<= 19;
				BlacklistedAccountIndicator.<>c.<>9__8_0 = action2;
				num += 1872915718U;
			}
			num = 627846701U >> (int)num;
			UnityAction unityAction = action;
			string text14 = text10;
			Action action3;
			if ((action3 = BlacklistedAccountIndicator.<>c.<>9__8_1) == null)
			{
				num = 1078350054U % num;
				num = 1335785011U << (int)num;
				object <>2 = BlacklistedAccountIndicator.<>c.<>9;
				num = 39981296U << (int)num;
				action3 = (BlacklistedAccountIndicator.<>c.<>9__8_1 = delegate()
				{
					uint num2 = 523792854U;
					GlobalPanelsHandler instance2 = GlobalPanelsHandler.Instance;
					num2 = 238888459U << (int)num2;
					instance2.ClosePanels();
					num2 = 602740041U >> (int)num2;
					do
					{
						MenuSceneHandler.Instance.SignOut();
						num2 /= 1858345477U;
					}
					while ((num2 ^ 319362383U) == 0U);
					Application.Quit();
				});
				num += 4264796104U;
			}
			UnityAction unityAction2 = action3;
			num = (1002657551U ^ num);
			bool flag3 = num + 3299416138U != 0U;
			num -= 1779455327U;
			instance.OpenPromptPanel(text11, text12, text13, unityAction, text14, unityAction2, flag3);
			string text15 = "GlobalCanvas/FriendLoadingPanel";
			num = (1107040854U & num);
			Object.Destroy(GameObject.Find(text15));
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0005D8DC File Offset: 0x0005AEDC
		// Note: this type is marked as 'beforefieldinit'.
		static BlacklistedAccountIndicator()
		{
			uint num = 2117679963U;
			if (2027568189U != num)
			{
				do
				{
					string text = "GGDH";
					num = (583292815U ^ num);
					string text2 = "Enable_BlacklistedAccountIndicator";
					bool flag = num + 2734854957U != 0U;
					string text3 = null;
					string text4 = null;
					num = 1231178945U * num;
					bool flag2 = num - 1954937812U != 0U;
					num /= 319901633U;
					bool flag3 = num + 4294967290U != 0U;
					ValueValidator valueValidator = null;
					num %= 518215295U;
					BlacklistedAccountIndicator.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
					bool flag4 = num + 4294967290U != 0U;
					num = 956436765U - num;
					BlacklistedAccountIndicator.showBan = flag4;
					num = (1902845897U & num);
				}
				while (num + 1340415076U == 0U);
				BlacklistedAccountIndicator.showTime = -1f;
			}
		}

		// Token: 0x040001A2 RID: 418
		public static BlacklistedAccountIndicator Instance;

		// Token: 0x040001A3 RID: 419
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x040001A4 RID: 420
		private static bool showBan;

		// Token: 0x040001A5 RID: 421
		private static float showTime;

		// Token: 0x020000B5 RID: 181
		[HarmonyPatch(typeof(LoadBalancingClient), "OnOperationResponse")]
		public class IndicateAsBanned
		{
			// Token: 0x06000256 RID: 598 RVA: 0x000679C0 File Offset: 0x00064FC0
			private static void Prefix(LoadBalancingClient __instance, OperationResponse __0)
			{
				try
				{
					uint num = 896802911U;
					uint returnCode = (uint)__0.ReturnCode;
					num += 1523010939U;
					if (returnCode == num - 2419781083U)
					{
						num %= 1855652734U;
						ConsoleColor consoleColor = (ConsoleColor)(num ^ 564161110U);
						num >>= 12;
						string text = "账号疑似已被拉黑";
						num = 1255437299U / num;
						MelonLogger.Msg(consoleColor, text);
						do
						{
							num = 1063605836U / num;
							BlacklistedAccountIndicator.showBan = ((num ^ 116701U) != 0U);
						}
						while (num == 3082629U);
						float showTime = Time.time + 10f;
						num = (1472153899U | num);
						BlacklistedAccountIndicator.showTime = showTime;
						num ^= 3347358245U;
					}
				}
				catch (Exception ex)
				{
					uint num = 538791630U;
					Exception arg = ex;
					if (num >= 134156593U)
					{
						do
						{
							string format = "Exception in patch of void Photon.Realtime.LoadBalancingClient::OnOperationResponse(ExitGames.Client.Photon.OperationResponse operationResponse):\n{0}";
							num = 1375887074U - num;
							string text2 = string.Format(format, arg);
							num = 25116655U + num;
							MelonLogger.Warning(text2);
						}
						while ((1420519974U ^ num) == 0U);
					}
				}
			}

			// Token: 0x06000257 RID: 599 RVA: 0x00067ABC File Offset: 0x000650BC
			public IndicateAsBanned()
			{
				uint num = 1326978976U;
				do
				{
					base..ctor();
				}
				while (num % 1270699287U == 0U);
			}
		}
	}
}
