using System;
using System.Diagnostics;
using System.Text;
using GGD_Hack.Utils;
using Handlers.CommonHandlers.UIHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using UnityEngine;
using UnityEngine.Events;

namespace GGD_Hack.AntiSell
{
	// Token: 0x0200006E RID: 110
	[HarmonyPatch(typeof(PlayerCustomizationPanelHandler), "Start")]
	public class PopupFree
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000615A4 File Offset: 0x0005EBA4
		public static void OpenLiuhaixvPanel()
		{
			uint num = 273748724U;
			for (;;)
			{
				string text = "Liuhaixv";
				num = 1409439344U + num;
				string text2 = text;
				StringBuilder stringBuilder = new StringBuilder();
				num = 614867251U + num;
				if (2066430644U < num)
				{
					goto IL_34;
				}
				for (;;)
				{
					IL_4D:
					stringBuilder.AppendLine("");
					num %= 1931105959U;
					num -= 1398870179U;
					for (;;)
					{
						string imageName = "liuhaixv.jpg";
						num /= 1813855670U;
						Sprite spriteFromImageName = SpriteUtil.GetSpriteFromImageName(imageName);
						num -= 269156903U;
						Sprite sprite = spriteFromImageName;
						bool flag = Utils.IsChineseSystem();
						num = (110113560U ^ num);
						string text3;
						if (!flag)
						{
							if (num * 5006536U == 0U)
							{
								goto IL_34;
							}
							text3 = "Continue";
						}
						else
						{
							num <<= 28;
							text3 = "继续";
							num ^= 3378826946U;
						}
						num = 267734950U * num;
						string text4 = text3;
						bool flag2 = Utils.IsChineseSystem();
						num -= 609966866U;
						string text5;
						if (!flag2)
						{
							num = (445409106U | num);
							if ((num & 226756371U) == 0U)
							{
								goto IL_34;
							}
							text5 = "Visit";
						}
						else
						{
							num >>= 21;
							if (num >> 18 != 0U)
							{
								continue;
							}
							text5 = "拜访";
							num += 2667508631U;
						}
						num &= 797008411U;
						string text6 = text5;
						num += 1211254317U;
						Action action;
						bool flag3 = (action = PopupFree.<>c.<>9__0_0) != null;
						num *= 1821988491U;
						if (!flag3)
						{
							num %= 31853843U;
							num = 990799169U % num;
							if (1619007347U % num == 0U)
							{
								break;
							}
							action = (PopupFree.<>c.<>9__0_0 = delegate()
							{
								GlobalPanelsHandler.Instance.ClosePanels();
								uint num2 = 1282304765U;
								do
								{
									PopupFree.OpenChocolatePanel();
								}
								while (num2 <= 1183079519U);
							});
							num ^= 2649035668U;
						}
						num = (917847817U & num);
						UnityAction unityAction = action;
						num = 1495873114U >> (int)num;
						UnityAction unityAction2 = unityAction;
						Action <>9__0_ = PopupFree.<>c.<>9__0_1;
						num >>= 8;
						Action action2 = <>9__0_;
						if (<>9__0_ == null)
						{
							num = 350948073U * num;
							num /= 1804600712U;
							object <> = PopupFree.<>c.<>9;
							num >>= 2;
							IntPtr method = ldftn(<OpenLiuhaixvPanel>b__0_1);
							num = 137110316U << (int)num;
							Action action3 = new Action(<>, method);
							num %= 942240031U;
							action2 = action3;
							PopupFree.<>c.<>9__0_1 = action3;
							num += 4157868392U;
						}
						num /= 415067267U;
						UnityAction unityAction3 = action2;
						num = (403243932U ^ num);
						UnityAction unityAction4 = unityAction3;
						if (num != 811014582U)
						{
							GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
							string text7 = text2;
							num = 1834551514U >> (int)num;
							string text8 = stringBuilder.ToString();
							Sprite sprite2 = sprite;
							string text9 = text4;
							UnityAction unityAction5 = unityAction2;
							num = 504128791U / num;
							instance.OpenErrorPanelWithImage(text7, text8, sprite2, text9, unityAction5, text6, unityAction4, num + 4210945832U != 0U);
							if (349442278U != num)
							{
								return;
							}
						}
					}
				}
				IL_34:
				stringBuilder.AppendLine("Chief developer");
				if (num * 979394171U != 0U)
				{
					goto IL_4D;
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00061850 File Offset: 0x0005EE50
		public static void OpenChocolatePanel()
		{
			string text;
			uint num;
			StringBuilder stringBuilder2;
			Sprite spriteFromImageName;
			string text3;
			string text5;
			UnityAction unityAction2;
			Action action3;
			for (;;)
			{
				text = "Blue_Chocolate";
				num = 1606045249U;
				for (;;)
				{
					StringBuilder stringBuilder = new StringBuilder();
					num <<= 29;
					stringBuilder2 = stringBuilder;
					num <<= 10;
					if ((num ^ 461790078U) == 0U)
					{
						goto IL_B5;
					}
					IL_35:
					StringBuilder stringBuilder3 = stringBuilder2;
					num = 2118264578U << (int)num;
					stringBuilder3.AppendLine("<color=red>Super Administrator</color>");
					num &= 526283672U;
					num *= 383669052U;
					StringBuilder stringBuilder4 = stringBuilder2;
					num += 1510213630U;
					string value = "";
					num = (674780205U | num);
					stringBuilder4.AppendLine(value);
					num /= 768869179U;
					if (num + 1598423472U == 0U)
					{
						continue;
					}
					stringBuilder2.AppendLine("All information and resources should be <color=green>free</color>");
					num %= 32399050U;
					IL_B5:
					string imageName = "chocolate.jpg";
					num = 1816199514U % num;
					spriteFromImageName = SpriteUtil.GetSpriteFromImageName(imageName);
					if (1885210097U < num)
					{
						break;
					}
					string text2;
					if (!Utils.IsChineseSystem())
					{
						num = (286272366U & num);
						if ((num ^ 1385375596U) == 0U)
						{
							continue;
						}
						text2 = "Continue";
					}
					else
					{
						if (687808955U < num)
						{
							goto IL_35;
						}
						text2 = "继续";
						num ^= 0U;
					}
					num /= 749017182U;
					text3 = text2;
					if (1335129157U == num)
					{
						break;
					}
					string text4;
					if (!Utils.IsChineseSystem())
					{
						num = (1496871116U & num);
						if (1094063298U + num == 0U)
						{
							break;
						}
						text4 = "Visit";
					}
					else
					{
						num *= 2050582029U;
						text4 = "拜访";
						num += 0U;
					}
					num = (1852969712U ^ num);
					text5 = text4;
					Action action;
					bool flag = (action = PopupFree.<>c.<>9__1_0) != null;
					num -= 1634748452U;
					if (!flag)
					{
						num <<= 21;
						num = 1186404971U % num;
						object <> = PopupFree.<>c.<>9;
						IntPtr method = ldftn(<OpenChocolatePanel>b__1_0);
						num ^= 1980509841U;
						Action action2 = new Action(<>, method);
						num = 2113551700U >> (int)num;
						action = action2;
						PopupFree.<>c.<>9__1_0 = action2;
						num += 218221229U;
					}
					num /= 1762938201U;
					UnityAction unityAction = action;
					num = (1391285332U ^ num);
					unityAction2 = unityAction;
					num <<= 5;
					if (num % 1467181631U != 0U)
					{
						if ((action3 = PopupFree.<>c.<>9__1_1) != null)
						{
							goto IL_278;
						}
						num = (2090685448U & num);
						if (1918987818U >= num)
						{
							goto Block_11;
						}
					}
				}
			}
			Block_11:
			object <>2 = PopupFree.<>c.<>9;
			num %= 712968190U;
			IntPtr method2 = ldftn(<OpenChocolatePanel>b__1_1);
			num -= 40069810U;
			Action action4 = new Action(<>2, method2);
			num = 8393806U - num;
			action3 = action4;
			PopupFree.<>c.<>9__1_1 = action4;
			num += 1649474436U;
			IL_278:
			UnityAction unityAction3 = action3;
			GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
			string text6 = text;
			num = 260579717U % num;
			object obj = stringBuilder2;
			num = (338174697U | num);
			string text7 = obj.ToString();
			num = (265571133U | num);
			Sprite sprite = spriteFromImageName;
			string text8 = text3;
			UnityAction unityAction4 = unityAction2;
			string text9 = text5;
			num = 898702381U * num;
			instance.OpenErrorPanelWithImage(text6, text7, sprite, text8, unityAction4, text9, unityAction3, num - 3329992568U != 0U);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00061B28 File Offset: 0x0005F128
		public static void OpenNoticePanel()
		{
			bool flag;
			uint num;
			string text4;
			string text10;
			for (;;)
			{
				flag = Utils.IsChineseSystem();
				num = 944782146U;
				if ((num ^ 745038914U) != 0U)
				{
					goto IL_1A;
				}
				goto IL_2A;
				IL_4D:
				num /= 1381775039U;
				string text2;
				string text = text2;
				if ((num ^ 1706458185U) == 0U)
				{
					goto IL_1A;
				}
				string text3;
				if (!flag)
				{
					if (859443022U + num == 0U)
					{
						goto IL_1A;
					}
					text3 = "Notice";
				}
				else
				{
					num = (1706646194U | num);
					text3 = "声明";
					num += 2588321102U;
				}
				text4 = text3;
				num += 1205691550U;
				int num2 = (int)(num - 1205691540U);
				num ^= 600784635U;
				string[] array = new string[num2];
				num = 970600921U % num;
				num <<= 31;
				int num3 = (int)(num - 2147483648U);
				string text5 = text;
				num -= 215435916U;
				array[num3] = text5;
				num = 2113109848U * num;
				num &= 2067993695U;
				array[(int)(num ^ 687996993U)] = "\n<color=green>";
				num *= 1970168918U;
				int num4 = (int)(num ^ 3930396034U);
				num = 1101665548U % num;
				string text6 = text;
				num ^= 1860725253U;
				array[num4] = text6;
				int num5 = (int)(num ^ 792887050U);
				num >>= 17;
				string text7 = "</color>\n<color=red>";
				num = 702559930U / num;
				array[num5] = text7;
				num = 1627666104U * num;
				array[(int)(num + 3628517764U)] = text;
				num *= 53626288U;
				num = 1632910938U - num;
				int num6 = (int)(num + 4273060267U);
				num -= 42154163U;
				array[num6] = "</color>\n<color=blue>";
				num &= 2039628948U;
				int num7 = (int)(num ^ 2021786754U);
				string text8 = text;
				num &= 1367894211U;
				array[num7] = text8;
				array[(int)(num + 2944401287U)] = "</color>\n<color=purple>";
				num = 1288072366U / num;
				int num8 = (int)(num ^ 8U);
				num = 362883535U * num;
				array[num8] = text;
				num = (600538039U ^ num);
				num = (447287991U ^ num);
				int num9 = (int)(num + 3332216585U);
				num |= 1630044024U;
				string text9 = "</color>";
				num = (144734321U & num);
				array[num9] = text9;
				num -= 91101964U;
				text10 = string.Concat(array);
				num = 815206768U % num;
				if (241066220U != num)
				{
					break;
				}
				continue;
				IL_2A:
				text2 = "Never buy or sell this mod!";
				goto IL_4D;
				IL_1A:
				bool flag2 = flag;
				num *= 1038376636U;
				if (!flag2)
				{
					goto IL_2A;
				}
				num = 81755544U / num;
				text2 = "本项目完全免费，禁止任何人贩卖!";
				num += 1366671480U;
				goto IL_4D;
			}
			string text11;
			if (!flag)
			{
				num = 1140469472U - num;
				text11 = "Great!";
			}
			else
			{
				text11 = "太棒了!";
				num += 1138830864U;
			}
			string text12 = text11;
			num = 298142373U / num;
			bool flag3 = (num ^ 0U) != 0U;
			GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
			string text13 = text4;
			num = 1985740883U + num;
			string text14 = text10;
			string text15 = text12;
			Action action;
			bool flag4 = (action = PopupFree.<>c.<>9__2_0) != null;
			num = 1433684930U * num;
			if (!flag4)
			{
				num = 2016156794U % num;
				object <> = PopupFree.<>c.<>9;
				IntPtr method = ldftn(<OpenNoticePanel>b__2_0);
				num = 1371612159U % num;
				Action action2 = new Action(<>, method);
				num ^= 1566851073U;
				action = action2;
				PopupFree.<>c.<>9__2_0 = action2;
				num += 256263440U;
			}
			num >>= 23;
			UnityAction unityAction = action;
			bool flag5 = flag3;
			num ^= 1145196276U;
			instance.OpenOneButtonPromptPanel(text13, text14, text15, unityAction, flag5);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00061E44 File Offset: 0x0005F444
		public static void OpenFreeCheckboxPanel()
		{
			uint num = 1985902291U;
			string text2;
			string text4;
			string text6;
			string text8;
			string text9;
			bool flag2;
			UnityAction unityAction2;
			UnityAction unityAction3;
			for (;;)
			{
				IL_07:
				bool flag = Utils.IsChineseSystem();
				num /= 800353751U;
				string text;
				if (!flag)
				{
					num = (868487831U | num);
					text = "Warning!!";
				}
				else
				{
					text = "警告！";
					num += 868487829U;
				}
				text2 = text;
				num >>= 5;
				num &= 2055821795U;
				string text3;
				if (!flag)
				{
					num = 2137201169U + num;
					text3 = "This mod is 100% free!\nIf you bought it somewhere else, you are scammed!";
				}
				else
				{
					text3 = "本mod项目为Github<color=green>100%免费</color>项目!\n如果你是从别处购买的请立刻<color=red>退款</color>并投诉卖家!";
					num ^= 2137201169U;
				}
				num = 1702495434U * num;
				text4 = text3;
				num ^= 2143829067U;
				string text5;
				if (!flag)
				{
					text5 = "Understand";
				}
				else
				{
					text5 = "我已知晓";
					num ^= 0U;
				}
				text6 = text5;
				string text7;
				if (!flag)
				{
					text7 = "Don't show again";
				}
				else
				{
					num /= 335702477U;
					text7 = "不再显示";
					num += 97453601U;
				}
				text8 = text7;
				if (!flag)
				{
					num = 1277774083U * num;
					goto IL_EE;
				}
				goto IL_F8;
				IL_113:
				num = 1082219815U << (int)num;
				string text10;
				text9 = text10;
				for (;;)
				{
					num &= 973879910U;
					flag2 = (num - 534560U != 0U);
					num %= 966348327U;
					if (num + 843217020U == 0U)
					{
						goto IL_F8;
					}
					Action <>9__3_ = PopupFree.<>c.<>9__3_0;
					num = 367088125U % num;
					Action action = <>9__3_;
					if (<>9__3_ == null)
					{
						num |= 616659098U;
						object <> = PopupFree.<>c.<>9;
						IntPtr method = ldftn(<OpenFreeCheckboxPanel>b__3_0);
						num = 2005148581U * num;
						action = (PopupFree.<>c.<>9__3_0 = new Action(<>, method));
						num += 526370850U;
					}
					UnityAction unityAction = action;
					num ^= 1242331686U;
					unityAction2 = unityAction;
					Action <>9__3_2 = PopupFree.<>c.<>9__3_1;
					num = 1772749555U + num;
					Action action2 = <>9__3_2;
					num = 336075513U * num;
					if (<>9__3_2 == null)
					{
						num += 951845637U;
						if (num <= 291317703U)
						{
							goto IL_07;
						}
						Action <>9__3_3 = action2 = delegate()
						{
							bool isOn = GlobalPanelsHandler.Instance.checkboxToggle.isOn;
							Process.Start("https://github.com/Liuhaixv");
						};
						num = (886794932U & num);
						PopupFree.<>c.<>9__3_1 = <>9__3_3;
						num ^= 3418882622U;
					}
					unityAction3 = action2;
					num >>= 16;
					if (1708002522U >= num)
					{
						goto Block_11;
					}
				}
				IL_EE:
				text10 = "Github";
				goto IL_113;
				IL_F8:
				if (1675891354U != num)
				{
					text10 = "查看项目";
					num += 3685119298U;
					goto IL_113;
				}
				goto IL_EE;
			}
			Block_11:
			GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
			string text11 = text2;
			num = 726948226U << (int)num;
			string text12 = text4;
			string text13 = text6;
			num <<= 2;
			string text14 = text8;
			UnityAction unityAction4 = unityAction2;
			num = 498085836U / num;
			string text15 = text9;
			UnityAction unityAction5 = unityAction3;
			num = 1573912735U - num;
			instance.OpenCheckboxPanel(text11, text12, text13, text14, unityAction4, text15, unityAction5, flag2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000620BC File Offset: 0x0005F6BC
		private static void Postfix(PlayerCustomizationPanelHandler __instance)
		{
			try
			{
				bool hasWarnedFree = GGDHack_Mod.HasWarnedFree;
				uint num = 47341911U;
				if (hasWarnedFree || 1494558090U <= num)
				{
					goto IL_28;
				}
				IL_1B:
				PopupFree.OpenFreeCheckboxPanel();
				num += 0U;
				IL_28:
				if (712133361 << (int)num == 0)
				{
					goto IL_1B;
				}
			}
			catch (Exception ex)
			{
				uint num;
				do
				{
					string format = "Exception in patch of void Handlers.LobbyHandlers.PlayerCustomizationPanelHandler::Start():\n{0}";
					num = 40641610U;
					object arg = ex;
					num *= 12941416U;
					string text = string.Format(format, arg);
					num = (1705731886U & num);
					MelonLogger.Warning(text);
				}
				while (num << 8 == 0U);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0006215C File Offset: 0x0005F75C
		public PopupFree()
		{
			uint num = 753737360U;
			do
			{
				base..ctor();
			}
			while (num > 1079719882U);
		}
	}
}
