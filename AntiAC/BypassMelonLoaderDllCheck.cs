using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using MelonLoader;

namespace GGD_Hack.AntiAC
{
	// Token: 0x02000071 RID: 113
	public static class BypassMelonLoaderDllCheck
	{
		// Token: 0x020000CC RID: 204
		[HarmonyPatch]
		private static class MelonLoaderFileExsistsCheckPatch
		{
			// Token: 0x0600028F RID: 655 RVA: 0x00068C90 File Offset: 0x00066290
			private static IEnumerable<MethodBase> TargetMethods()
			{
				Type typeFromHandle = typeof(MPNAGEGEHLO);
				uint num = 750792567U;
				IEnumerable<MethodInfo> methods = typeFromHandle.GetMethods();
				Func<MethodInfo, bool> predicate;
				bool flag = (predicate = BypassMelonLoaderDllCheck.MelonLoaderFileExsistsCheckPatch.<>c.<>9__0_0) != null;
				num = 1500583264U * num;
				if (!flag)
				{
					object <> = BypassMelonLoaderDllCheck.MelonLoaderFileExsistsCheckPatch.<>c.<>9;
					num = (1109087524U & num);
					Func<MethodInfo, bool> func = delegate(MethodInfo method)
					{
						Type returnType = method.ReturnType;
						uint num2 = 224936772U;
						RuntimeTypeHandle handle = typeof(string).TypeHandle;
						num2 = 699211533U - num2;
						Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
						num2 = 1070794U * num2;
						return returnType == typeFromHandle2;
					};
					num = (1201367807U ^ num);
					predicate = func;
					BypassMelonLoaderDllCheck.MelonLoaderFileExsistsCheckPatch.<>c.<>9__0_0 = func;
					num ^= 3690979455U;
				}
				num = (1548423023U & num);
				return methods.Where(predicate).Cast<MethodBase>();
			}

			// Token: 0x06000290 RID: 656 RVA: 0x00068D08 File Offset: 0x00066308
			private static void Postfix(ref string __result)
			{
				uint num = 1811048787U;
				num |= 863784208U;
				if (!(__result == "MelonLoader.dll"))
				{
					goto IL_78;
				}
				num |= 1242958571U;
				if (num == 1006571665U)
				{
					goto IL_3C;
				}
				IL_32:
				MelonLogger.Msg("游戏即将检测到非法DLL: MelonLoader.dll");
				IL_3C:
				num *= 1175921782U;
				string text = "LodasMnfks.dll";
				num &= 67190160U;
				__result = text;
				if (1061839960U <= num)
				{
					goto IL_32;
				}
				string text2 = "已成功修改DLL名称返回值!";
				num = (1890402179U | num);
				MelonLogger.Msg(text2);
				num ^= 190010048U;
				IL_78:
				if (num % 930951088U != 0U)
				{
					return;
				}
				goto IL_32;
			}
		}

		// Token: 0x020000CD RID: 205
		private class FailFastPatch
		{
			// Token: 0x06000291 RID: 657 RVA: 0x00068D9C File Offset: 0x0006639C
			private static bool Prefix(string message)
			{
				uint num = 724923182U;
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 724923170U);
				string str = "阻止了FailFast: ";
				num = 2035750812U * num;
				MelonLogger.Msg(consoleColor, str + message);
				return (num ^ 76370440U) != 0U;
			}
		}

		// Token: 0x020000CE RID: 206
		[HarmonyPatch(typeof(JMHIIODOCBJ), "HINOAEOKBPP")]
		private class PreloadCheckPatch
		{
			// Token: 0x06000293 RID: 659 RVA: 0x00068DEC File Offset: 0x000663EC
			private static bool Prefix()
			{
				return false;
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00068DFC File Offset: 0x000663FC
			public PreloadCheckPatch()
			{
				uint num = 1452629017U;
				if (num - 1623290730U != 0U)
				{
					num -= 1409691872U;
					base..ctor();
				}
			}
		}
	}
}
