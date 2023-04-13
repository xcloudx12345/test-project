using System;
using GGD_Hack.Utils;
using Handlers.CommonHandlers;
using HarmonyLib;
using MelonLoader;
using TMPro;
using UnityEngine;

namespace GGD_Hack.AntiSell
{
	// Token: 0x0200006B RID: 107
	[HarmonyPatch(typeof(ClientSettings), "Update")]
	public class ChangeVersionText
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00061164 File Offset: 0x0005E764
		private static void Postfix(ClientSettings __instance)
		{
			try
			{
				uint num = 434065612U;
				if (num << 18 != 0U)
				{
					num %= 115879107U;
					TMP_Text pluginVersionText = __instance.PluginVersionText;
					bool flag = Utils.IsChineseSystem();
					num = 330704834U * num;
					string text;
					if (!flag)
					{
						num /= 1232211915U;
						text = "This mod is 100% Free!";
					}
					else
					{
						text = "本mod完全免费! 禁止售卖";
						num ^= 2187422791U;
					}
					pluginVersionText.text = text;
					num = 403650842U << (int)num;
					if (247799458U / num != 0U)
					{
						goto IL_BB;
					}
					num <<= 4;
					TMP_Text pluginVersionText2 = __instance.PluginVersionText;
					num *= 115366201U;
					pluginVersionText2.color = Color.red;
					num &= 990267442U;
					if (447698040U > num)
					{
						goto IL_BB;
					}
				}
				TMP_Text pluginVersionText3 = __instance.PluginVersionText;
				num = 744969854U / num;
				pluginVersionText3.fontSize = 70f;
				IL_BB:;
			}
			catch (Exception ex)
			{
				uint num = 1728188884U;
				string str = "Exception in patch of void Handlers.CommonHandlers.ClientSettings::Update():\n{";
				Exception ex2 = ex;
				string str2;
				if (ex2 == null)
				{
					num = 787036289U + num;
					num = 1352226011U - num;
					str2 = null;
				}
				else
				{
					str2 = ex2.ToString();
					num ^= 3719043922U;
				}
				num = (1374625621U & num);
				MelonLogger.Msg(str + str2 + "}");
			}
		}
	}
}
