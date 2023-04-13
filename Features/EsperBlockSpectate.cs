using System;
using APIs.Photon;
using ExitGames.Client.Photon;
using HarmonyLib;
using MelonLoader;
using MelonLoader.Preferences;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000046 RID: 70
	[RegisterTypeInIl2Cpp]
	public class EsperBlockSpectate : MonoBehaviour
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0005915C File Offset: 0x0005675C
		public EsperBlockSpectate(IntPtr ptr) : base(ptr)
		{
			IngameSettings.IngameSettingsEntry ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			MelonPreferences_Entry enabled = EsperBlockSpectate.Enabled;
			uint num = 16398859U;
			ingameSettingsEntry.entry = enabled;
			num = (298015025U & num);
			string name_cn = "超能力鸭取消附身阶段";
			num = 554129799U * num;
			ingameSettingsEntry.name_cn = name_cn;
			num |= 227557507U;
			ingameSettingsEntry.name_eng = "Esper disable spectate";
			IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
			num %= 349048719U;
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000591C8 File Offset: 0x000567C8
		public EsperBlockSpectate()
		{
			IntPtr intPtr = ClassInjector.DerivedConstructorPointer<EsperBlockSpectate>();
			uint num = 2063024586U;
			base..ctor(intPtr);
			num <<= 0;
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000591F4 File Offset: 0x000567F4
		public static void Init()
		{
			uint num;
			GameObject gameObject2;
			for (;;)
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				num = 1497510310U;
				gameObject2 = gameObject;
				num = 729951606U << (int)num;
				for (;;)
				{
					Object @object = gameObject2;
					Object object2 = null;
					num = 600657388U / num;
					if (!(@object == object2))
					{
						break;
					}
					gameObject2 = new GameObject("ML_Manager");
					if (num <= 113249803U)
					{
						goto Block_1;
					}
				}
				IL_57:
				GameObject gameObject3 = gameObject2;
				num = (591867319U ^ num);
				Object component = gameObject3.GetComponent<EsperBlockSpectate>();
				Object object3 = null;
				num /= 1461930941U;
				bool flag = component == object3;
				num = 2045856635U >> (int)num;
				if (!flag)
				{
					return;
				}
				num = 929856756U / num;
				if (num <= 1165131023U)
				{
					break;
				}
				continue;
				Block_1:
				Object.DontDestroyOnLoad(gameObject2);
				num ^= 0U;
				goto IL_57;
			}
			GameObject gameObject4 = gameObject2;
			num = 698900604U + num;
			EsperBlockSpectate instance = gameObject4.AddComponent<EsperBlockSpectate>();
			num ^= 1408642939U;
			EsperBlockSpectate.Instance = instance;
			num += 4287822964U;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000592C0 File Offset: 0x000568C0
		// Note: this type is marked as 'beforefieldinit'.
		static EsperBlockSpectate()
		{
			uint num = 2078369463U;
			do
			{
				string text = "GGDH";
				num = 1603744441U / num;
				string text2 = "Enable_EsperBlockSpectate";
				num = (1001744608U ^ num);
				bool flag = (num ^ 1001744609U) != 0U;
				num = (1967682616U | num);
				string text3 = null;
				string text4 = null;
				bool flag2 = (num ^ 2147319032U) != 0U;
				bool flag3 = num - 2147319032U != 0U;
				num *= 1753635544U;
				ValueValidator valueValidator = null;
				num = (580609452U ^ num);
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
				num = 958430325U + num;
				EsperBlockSpectate.Enabled = enabled;
			}
			while (340078357U >= num);
		}

		// Token: 0x0400016D RID: 365
		public static EsperBlockSpectate Instance;

		// Token: 0x0400016E RID: 366
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x0200009F RID: 159
		[HarmonyPatch(typeof(PhotonEventAPI), "OnEvent", new Type[]
		{
			typeof(EventData)
		})]
		private class PhotonEventAPI_OnEvent
		{
			// Token: 0x06000229 RID: 553 RVA: 0x00065AC8 File Offset: 0x000630C8
			private static bool Prefix(EventData __0)
			{
				MelonPreferences_Entry<bool> enabled = EsperBlockSpectate.Enabled;
				uint num = 218723956U;
				bool value = enabled.Value;
				num /= 1502483998U;
				if (value)
				{
					num = 1466059012U << (int)num;
					if (num != 557270427U)
					{
						bool result;
						try
						{
							for (;;)
							{
								num = 70349496U >> (int)num;
								bool flag = num + 4290570453U != 0U;
								num = 607280605U * num;
								bool flag2 = flag;
								num = 1485536835U >> (int)num;
								if ((uint)__0.Code == (num ^ 141U))
								{
									flag2 = (num - uint.MaxValue != 0U);
									num += 0U;
								}
								for (;;)
								{
									num += 1893538760U;
									if (!flag2)
									{
										goto IL_D1;
									}
									if (333801365U == num)
									{
										break;
									}
									MelonLogger.Warning("已屏蔽超能力附身事件");
									bool flag3 = (num ^ 1893538760U) != 0U;
									num = 1659320905U - num;
									result = flag3;
									if (num / 904356890U != 0U)
									{
										goto Block_5;
									}
								}
							}
							Block_5:
							return result;
							IL_D1:
							bool flag4 = (num ^ 1893538761U) != 0U;
							num += 1008035035U;
							result = flag4;
						}
						catch (Exception ex)
						{
							MelonLogger.Error(ex.ToString());
							result = true;
						}
						return result;
					}
				}
				return num - uint.MaxValue != 0U;
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00065BEC File Offset: 0x000631EC
			public PhotonEventAPI_OnEvent()
			{
				uint num;
				do
				{
					num = 1937142678U;
					base..ctor();
				}
				while (1385758748U >= num);
			}
		}
	}
}
