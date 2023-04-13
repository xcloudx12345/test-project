using System;
using Handlers.GameHandlers;
using HarmonyLib;
using MelonLoader;
using MelonLoader.Preferences;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000043 RID: 67
	[RegisterTypeInIl2Cpp]
	public class RemoveRoofs : MonoBehaviour
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00057DC4 File Offset: 0x000553C4
		public RemoveRoofs(IntPtr ptr)
		{
			uint num = 781603969U;
			base..ctor(ptr);
			num &= 1675131144U;
			for (;;)
			{
				IngameSettings.IngameSettingsEntry ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				if (377372259U < num)
				{
					ingameSettingsEntry.entry = RemoveRoofs.Enabled;
					num = 1655271931U >> (int)num;
					ingameSettingsEntry.name_cn = "移除屋顶";
					ingameSettingsEntry.name_eng = "Remove Roofs";
					if (48851068U >> (int)num == 0U)
					{
						IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
						if (1532060084U / num == 0U)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00057E50 File Offset: 0x00055450
		public RemoveRoofs() : base(ClassInjector.DerivedConstructorPointer<RemoveRoofs>())
		{
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00057E70 File Offset: 0x00055470
		public static void Init()
		{
			uint num;
			GameObject gameObject;
			for (;;)
			{
				string text = "ML_Manager";
				num = 681837181U;
				gameObject = GameObject.Find(text);
				num = (547557034U ^ num);
				if (1945782795U >= num)
				{
					goto IL_24;
				}
				goto IL_38;
				IL_59:
				if (num == 976715548U)
				{
					continue;
				}
				Object component = gameObject.GetComponent<RemoveRoofs>();
				num |= 1641550326U;
				Object @object = null;
				num *= 1237990101U;
				bool flag = component == @object;
				num >>= 23;
				if (!flag)
				{
					return;
				}
				if (1061906348U % num != 0U)
				{
					break;
				}
				IL_24:
				if (!(gameObject == null))
				{
					goto IL_59;
				}
				num = 365300305U * num;
				IL_38:
				string text2 = "ML_Manager";
				num = 351934508U % num;
				gameObject = new GameObject(text2);
				Object.DontDestroyOnLoad(gameObject);
				num += 4077712555U;
				goto IL_59;
			}
			RemoveRoofs instance = gameObject.AddComponent<RemoveRoofs>();
			num ^= 795888707U;
			RemoveRoofs.Instance = instance;
			num += 3499078721U;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00057F34 File Offset: 0x00055534
		private static void RemoveAllRoofs()
		{
			uint num = 107236560U;
			if (726166398U < num)
			{
				goto IL_32;
			}
			IL_11:
			GameObject gameObject = GameObject.Find("Roofs");
			num = 1797082019U * num;
			GameObject gameObject2 = gameObject;
			num = 2014599481U << (int)num;
			IL_32:
			Object @object = gameObject2;
			num %= 18228047U;
			bool flag = @object != null;
			num = 918421798U % num;
			if (flag)
			{
				num = (2002675597U | num);
				if (num % 2111588496U != 0U)
				{
					GameObject gameObject3 = gameObject2;
					num = (280251242U & num);
					gameObject3.SetActive(num + 4023106808U != 0U);
					MelonLogger.Msg((ConsoleColor)(num ^ 271860482U), "屋顶已移除");
					return;
				}
				goto IL_11;
			}
			else
			{
				num = 194529023U * num;
				MelonLogger.Msg((ConsoleColor)(num ^ 1782159202U), "该地图未找到屋顶，无需移除");
				if (352329192U != num)
				{
					return;
				}
				goto IL_11;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00057FF0 File Offset: 0x000555F0
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveRoofs()
		{
			uint num;
			do
			{
				string text = "GGDH";
				num = 1415865357U;
				string text2 = "Enable_RemoveRoofs";
				num = (1771504689U | num);
				bool flag = num - 2113365052U != 0U;
				num >>= 19;
				string text3 = null;
				string text4 = null;
				bool flag2 = (num ^ 4030U) != 0U;
				num = 2044154978U >> (int)num;
				bool flag3 = num + uint.MaxValue != 0U;
				ValueValidator valueValidator = null;
				num = (1286281698U ^ num);
				RemoveRoofs.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			}
			while (num + 1891961146U == 0U);
		}

		// Token: 0x04000164 RID: 356
		public static RemoveRoofs Instance;

		// Token: 0x04000165 RID: 357
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x0200009A RID: 154
		[HarmonyPatch(typeof(FogOfWarHandler), "Start")]
		public class RemoveFOW_On_Start
		{
			// Token: 0x0600021D RID: 541 RVA: 0x00065734 File Offset: 0x00062D34
			private static void Prefix(ref FogOfWarHandler __instance)
			{
				if (RemoveRoofs.Enabled.Value)
				{
					RemoveRoofs.RemoveAllRoofs();
				}
			}
		}
	}
}
