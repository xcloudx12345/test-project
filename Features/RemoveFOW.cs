using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000042 RID: 66
	[RegisterTypeInIl2Cpp]
	public class RemoveFOW : MonoBehaviour
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00057B34 File Offset: 0x00055134
		public RemoveFOW(IntPtr ptr)
		{
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			for (;;)
			{
				uint num = 183793269U;
				num >>= 1;
				base..ctor(ptr);
				num = 559774317U << (int)num;
				if (num >= 809380350U)
				{
					goto IL_2E;
				}
				IL_3E:
				num *= 1205216716U;
				ingameSettingsEntry.entry = RemoveFOW.Enabled;
				num >>= 15;
				string name_cn = "移除战争迷雾";
				num += 515838853U;
				ingameSettingsEntry.name_cn = name_cn;
				num /= 147196238U;
				if (472913427U <= num)
				{
					continue;
				}
				ingameSettingsEntry.name_eng = "Remove Fog of War";
				num %= 41965024U;
				if (2114016018U * num != 0U)
				{
					break;
				}
				IL_2E:
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				num |= 2134967250U;
				goto IL_3E;
			}
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00057BE8 File Offset: 0x000551E8
		public RemoveFOW()
		{
			uint num = 873347142U;
			base..ctor(ClassInjector.DerivedConstructorPointer<RemoveFOW>());
			num |= 102723537U;
			if (num % 1401703631U != 0U)
			{
				ClassInjector.DerivedConstructorBody(this);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00057C20 File Offset: 0x00055220
		public static void Init()
		{
			uint num = 1428637850U;
			if (num - 2101349222U != 0U)
			{
				goto IL_12;
			}
			GameObject gameObject;
			do
			{
				IL_2B:
				Object @object = gameObject;
				Object object2 = null;
				num /= 2046566817U;
				if (@object == object2)
				{
					num <<= 19;
					gameObject = new GameObject("ML_Manager");
					if (num - 410219661U == 0U)
					{
						goto IL_12;
					}
					Object.DontDestroyOnLoad(gameObject);
					num ^= 0U;
				}
				num = (663161818U | num);
				GameObject gameObject2 = gameObject;
				num = 1933389361U + num;
				Object component = gameObject2.GetComponent<RemoveFOW>();
				num += 1148418617U;
				Object object3 = null;
				num = (312376856U ^ num);
				if (component == object3)
				{
					num |= 1060665853U;
					if (num <= 1509127344U)
					{
						goto IL_12;
					}
					GameObject gameObject3 = gameObject;
					num = (1203975611U & num);
					RemoveFOW instance = gameObject3.AddComponent<RemoveFOW>();
					num = 1700012793U - num;
					RemoveFOW.Instance = instance;
					num ^= 3497736988U;
				}
			}
			while (280442011U > num);
			return;
			IL_12:
			gameObject = GameObject.Find("ML_Manager");
			num = 1064528770U >> (int)num;
			goto IL_2B;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00057D0C File Offset: 0x0005530C
		public static void SetBaseViewDistance(float distance)
		{
			uint num;
			do
			{
				LocalPlayer instance = LocalPlayer.Instance;
				num = 1869811963U;
				FogOfWarHandler fogOfWar = instance.fogOfWar;
				num = 1371676095U - num;
				num = 145043491U - num;
				ObscuredFloat baseViewDistance = distance;
				num = 1085154155U - num;
				fogOfWar.baseViewDistance = baseViewDistance;
			}
			while (906044944U == num);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00057D58 File Offset: 0x00055358
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveFOW()
		{
			uint num = 332271958U;
			string text = "GGDH";
			string text2 = "Enable_RemoveFOW";
			bool flag = (num ^ 332271959U) != 0U;
			num = (1040350151U | num);
			string text3 = null;
			string text4 = null;
			num = 2027357922U / num;
			RemoveFOW.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, (num ^ 1U) != 0U, (num ^ 1U) != 0U, null);
			do
			{
				float num2 = -1f;
				num |= 1781412084U;
				RemoveFOW.lastTimeHackedLayerMask = num2;
			}
			while (num == 425738621U);
		}

		// Token: 0x04000161 RID: 353
		public static RemoveFOW Instance;

		// Token: 0x04000162 RID: 354
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000163 RID: 355
		private static float lastTimeHackedLayerMask;

		// Token: 0x02000099 RID: 153
		[HarmonyPatch(typeof(FogOfWarHandler), "UpdateFieldOfView")]
		public class DelayedDisableUpdatingFOV
		{
			// Token: 0x0600021B RID: 539 RVA: 0x00065438 File Offset: 0x00062A38
			private static bool Prefix(ref FogOfWarHandler __instance)
			{
				uint num;
				GameObject gameObject6;
				for (;;)
				{
					IL_00:
					bool value = RemoveFOW.Enabled.Value;
					num = 1750099560U;
					if (!value)
					{
						break;
					}
					for (;;)
					{
						num *= 1684033786U;
						if ((1523137591U ^ num) == 0U)
						{
							goto IL_00;
						}
						FogOfWarHandler fogOfWarHandler = __instance;
						float num2 = 100000f;
						num = 1139038686U / num;
						ObscuredFloat baseViewDistance = num2;
						num &= 210852215U;
						fogOfWarHandler.baseViewDistance = baseViewDistance;
						if (340619892U / num == 0U)
						{
							goto IL_00;
						}
						LayerMask layerMask = __instance.layerMask;
						num |= 1959415394U;
						if (layerMask == 0)
						{
							goto IL_25D;
						}
						num -= 1757365736U;
						float time = Time.time;
						num = 1746756175U / num;
						RemoveFOW.lastTimeHackedLayerMask = time;
						if (num >= 1325481456U)
						{
							goto IL_15;
						}
						num = (1060793485U ^ num);
						FogOfWarHandler fogOfWarHandler2 = __instance;
						ObscuredInt bliajnlcmoe = (int)(num ^ 1060793477U);
						num = (2072927152U | num);
						fogOfWarHandler2.BLIAJNLCMOE = bliajnlcmoe;
						FogOfWarHandler fogOfWarHandler3 = __instance;
						LayerMask layerMask2 = (int)(num + 2151776331U);
						num = 1236604490U * num;
						fogOfWarHandler3.layerMask = layerMask2;
						num = 2047683250U >> (int)num;
						num = 1881749461U + num;
						Component component = __instance;
						num += 127816045U;
						GameObject gameObject = component.gameObject;
						num = (1835607816U & num);
						Transform transform = gameObject.transform;
						num = 1114250374U + num;
						string text = "faded";
						num <<= 28;
						GameObject gameObject2 = transform.Find(text).gameObject;
						num %= 462580093U;
						GameObject gameObject3 = gameObject2;
						if (num <= 606749297U)
						{
							Object @object = gameObject3;
							Object object2 = null;
							num = (1812755591U & num);
							if (@object != object2)
							{
								num %= 1889604320U;
								GameObject gameObject4 = gameObject3;
								num = (1182279016U ^ num);
								bool active = num - 1248880105U != 0U;
								num ^= 1538200725U;
								gameObject4.SetActive(active);
								num += 4196978437U;
							}
							num = 66007642U + num;
							FogOfWarHandler fogOfWarHandler4 = __instance;
							num = (689731839U & num);
							if (!(fogOfWarHandler4.shader == null))
							{
								num = (991104387U ^ num);
								FogOfWarHandler fogOfWarHandler5 = __instance;
								num -= 1894525923U;
								string name = fogOfWarHandler5.shader.name;
								string b = "empty_shader";
								num |= 407444617U;
								if (!(name != b))
								{
									goto IL_24D;
								}
								num ^= 3494849830U;
							}
							num = 916596625U * num;
							GameObject gameObject5 = new GameObject();
							num &= 857610990U;
							gameObject6 = gameObject5;
							if (1582260545U != num)
							{
								break;
							}
						}
					}
					Object object3 = gameObject6;
					num = (402984543U | num);
					string name2 = "empty_shader";
					num = (497567980U | num);
					object3.name = name2;
					num &= 620234085U;
					if ((num ^ 800549639U) != 0U)
					{
						goto Block_9;
					}
				}
				IL_15:
				num = (414004728U & num);
				return num - 134227047U != 0U;
				Block_9:
				FogOfWarHandler fogOfWarHandler6 = __instance;
				num ^= 1989350897U;
				fogOfWarHandler6.shader = gameObject6;
				num += 1731218537U;
				IL_24D:
				num ^= 1555584172U;
				return num - 2246248784U != 0U;
				IL_25D:
				num <<= 19;
				bool gameStarted = LobbySceneHandler.Instance.gameStarted;
				num += 88303587U;
				if (!gameStarted)
				{
					num %= 1361734387U;
					return num + 3635872529U != 0U;
				}
				float time2 = Time.time;
				num = (2103331838U | num);
				if (time2 - RemoveFOW.lastTimeHackedLayerMask > 2f)
				{
					num = 762275960U % num;
					return num + 3532691336U != 0U;
				}
				num |= 1231095005U;
				return num + 2189463554U != 0U;
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00065710 File Offset: 0x00062D10
			public DelayedDisableUpdatingFOV()
			{
				uint num = 1443242583U;
				num >>= 8;
				base..ctor();
			}
		}
	}
}
