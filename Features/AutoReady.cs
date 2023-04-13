using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000045 RID: 69
	[RegisterTypeInIl2Cpp]
	public class AutoReady : MonoBehaviour
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00058F2C File Offset: 0x0005652C
		public AutoReady(IntPtr ptr)
		{
			uint num;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				num = 1959933833U;
				base..ctor(ptr);
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				if ((num ^ 750066045U) != 0U)
				{
					ingameSettingsEntry.entry = AutoReady.Enabled;
					num >>= 22;
					if (947660288U == num)
					{
						continue;
					}
					do
					{
						string name_cn = "自动准备";
						num = 740126084U >> (int)num;
						ingameSettingsEntry.name_cn = name_cn;
						num = 965099583U - num;
					}
					while (14502368U >= num);
				}
				num %= 692809981U;
				string name_eng = "Auto Ready";
				num |= 1050214812U;
				ingameSettingsEntry.name_eng = name_eng;
				num >>= 31;
			}
			while (num > 1218252558U);
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00058FDC File Offset: 0x000565DC
		public AutoReady() : base(ClassInjector.DerivedConstructorPointer<AutoReady>())
		{
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00059000 File Offset: 0x00056600
		public static void Init()
		{
			uint num = 73352935U;
			if (num == 1364998349U)
			{
				goto IL_64;
			}
			IL_11:
			string text = "ML_Manager";
			num |= 539300165U;
			GameObject gameObject = GameObject.Find(text);
			num >>= 14;
			GameObject gameObject2 = gameObject;
			do
			{
				Object @object = gameObject2;
				num = 41834993U * num;
				Object object2 = null;
				num = (835418278U | num);
				bool flag = @object == object2;
				num /= 733375542U;
				if (!flag)
				{
					goto IL_99;
				}
				num = (1228287547U | num);
			}
			while ((1989489515U ^ num) == 0U);
			IL_64:
			string text2 = "ML_Manager";
			num += 310122036U;
			gameObject2 = new GameObject(text2);
			if (252276376U % num == 0U)
			{
				goto IL_11;
			}
			Object object3 = gameObject2;
			num >>= 12;
			Object.DontDestroyOnLoad(object3);
			num ^= 375589U;
			IL_99:
			if (475997006U > num)
			{
				Object component = gameObject2.GetComponent<AutoReady>();
				Object object4 = null;
				num = 597190460U + num;
				if (component == object4)
				{
					if (num == 759517735U)
					{
						goto IL_11;
					}
					GameObject gameObject3 = gameObject2;
					num = (1728326242U & num);
					AutoReady.Instance = gameObject3.AddComponent<AutoReady>();
					num += 9979165U;
				}
				return;
			}
			goto IL_11;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000590F0 File Offset: 0x000566F0
		// Note: this type is marked as 'beforefieldinit'.
		static AutoReady()
		{
			uint num = 584415311U;
			if (723346504U >= num)
			{
				string text = "GGDH";
				num &= 564275158U;
				string text2 = "Enable_AutoReady";
				num = (1497636316U | num);
				bool flag = (num ^ 2042904031U) != 0U;
				num = 659237526U * num;
				string text3 = null;
				num -= 898777845U;
				AutoReady.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, null, num + 3093665505U != 0U, (num ^ 1201301791U) != 0U, null);
			}
		}

		// Token: 0x0400016B RID: 363
		public static AutoReady Instance;

		// Token: 0x0400016C RID: 364
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x0200009E RID: 158
		[HarmonyPatch(typeof(LobbySceneHandler), "Update")]
		public class LobbySceneHandler_Update
		{
			// Token: 0x06000227 RID: 551 RVA: 0x000659F0 File Offset: 0x00062FF0
			private static void Postfix(LobbySceneHandler __instance)
			{
				if (AutoReady.Enabled.Value)
				{
					uint num;
					for (;;)
					{
						num = 216557619U;
						if ((754804902U ^ num) != 0U)
						{
							num <<= 19;
							bool gameStarted = __instance.gameStarted;
							num = 35330615U + num;
							if (gameStarted)
							{
								break;
							}
							num <<= 20;
							if (__instance.readyState == (num ^ 2742026241U))
							{
								goto IL_A3;
							}
						}
						num -= 1740138532U;
						bool flag = num + 3293079589U != 0U;
						num = 753100319U + num;
						ObscuredBool mouseClicked = flag;
						num = (396849362U ^ num);
						__instance.mouseClicked = mouseClicked;
						num &= 835273074U;
						if (num != 2116103842U)
						{
							goto Block_3;
						}
					}
					return;
					Block_3:
					__instance.ChangeReadyState();
					num ^= 2457403680U;
					IL_A3:
					if ((1124995678U ^ num) != 0U)
					{
						return;
					}
				}
			}
		}
	}
}
