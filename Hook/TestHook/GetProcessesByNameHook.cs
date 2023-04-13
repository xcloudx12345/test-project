using System;
using System.Diagnostics;
using System.Text;
using HarmonyLib;
using MelonLoader;

namespace GGD_Hack.Hook.TestHook
{
	// Token: 0x02000026 RID: 38
	public class GetProcessesByNameHook
	{
		// Token: 0x02000085 RID: 133
		[HarmonyPatch(typeof(Process), "GetProcessesByName", new Type[]
		{
			typeof(string),
			typeof(string)
		})]
		private class GetProcessesByName_
		{
			// Token: 0x060001F0 RID: 496 RVA: 0x0006341C File Offset: 0x00060A1C
			private static void Postfix(Process[] __result, string __0, string __1)
			{
				try
				{
					uint num = 1976465265U;
					if (1448756983U >> (int)num != 0U)
					{
						do
						{
							StringBuilder stringBuilder = new StringBuilder();
							num = (461405520U ^ num);
							stringBuilder.AppendLine("--------------------");
							num = (138609604U & num);
							num >>= 5;
							stringBuilder.AppendLine("static System.Diagnostics.Process[] System.Diagnostics.Process::GetProcessesByName(string processName, string machineName)");
							num = 1909345685U << (int)num;
							StringBuilder stringBuilder2 = stringBuilder.Append("- Parameter 0 'processName': ");
							num = (333204140U & num);
							string text;
							if (__0 == null)
							{
								num |= 195918969U;
								text = null;
							}
							else
							{
								text = __0.ToString();
								num ^= 170491001U;
							}
							string value;
							if ((value = text) == null)
							{
								num = 535574574U / num;
								num = 698683912U + num;
								value = "null";
								num += 3793250927U;
							}
							stringBuilder2.AppendLine(value);
							StringBuilder stringBuilder3 = stringBuilder.Append("- Parameter 1 'machineName': ");
							num = 452012437U << (int)num;
							num = 1315779257U + num;
							string text2;
							if (__1 == null)
							{
								text2 = null;
							}
							else
							{
								num -= 175262222U;
								text2 = __1.ToString();
								num ^= 362273298U;
							}
							num *= 1616398132U;
							string value2;
							if ((value2 = text2) == null)
							{
								num = 1774341266U - num;
								num %= 1112544278U;
								value2 = "null";
								num += 2061314264U;
							}
							num = (1056187770U | num);
							stringBuilder3.AppendLine(value2);
							StringBuilder stringBuilder4 = stringBuilder.Append("- Return value: ");
							num += 121124474U;
							string text3;
							if (__result == null)
							{
								num = (1639738066U | num);
								text3 = null;
							}
							else
							{
								num = 93017725U << (int)num;
								text3 = __result.ToString();
								num += 1790967546U;
							}
							num |= 1420905438U;
							string value3;
							bool flag = (value3 = text3) != null;
							num = 1194998865U - num;
							if (!flag)
							{
								value3 = "null";
								num ^= 0U;
							}
							stringBuilder4.AppendLine(value3);
							num ^= 398817778U;
							num %= 1093214631U;
							string text4 = stringBuilder.ToString();
							num = 695082967U << (int)num;
							MelonLogger.Msg(text4);
						}
						while (1112806727U == num);
					}
				}
				catch (Exception ex)
				{
					uint num = 2102079682U;
					string format = "Exception in patch of static System.Diagnostics.Process[] System.Diagnostics.Process::GetProcessesByName(string processName, string machineName):\n{0}";
					num = (1615600512U | num);
					object arg = ex;
					num = 1764576470U << (int)num;
					string text5 = string.Format(format, arg);
					num = 322394149U * num;
					MelonLogger.Warning(text5);
				}
			}
		}
	}
}
