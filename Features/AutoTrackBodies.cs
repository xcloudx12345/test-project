using System;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200002E RID: 46
	[RegisterTypeInIl2Cpp]
	public class AutoTrackBodies : MonoBehaviour
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00052304 File Offset: 0x0004F904
		public AutoTrackBodies(IntPtr ptr)
		{
			uint num;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				num = 1639343011U;
				base..ctor(ptr);
				num ^= 155664568U;
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			}
			while (num <= 658789689U);
			ingameSettingsEntry.entry = AutoTrackBodies.Enabled;
			do
			{
				string name_cn = "箭头自动追踪尸体";
				num -= 988349322U;
				ingameSettingsEntry.name_cn = name_cn;
				num = 1585528490U * num;
				ingameSettingsEntry.name_eng = "Auto Track Bodies";
				IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
			}
			while (924936070U > num);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00052380 File Offset: 0x0004F980
		public AutoTrackBodies()
		{
			uint num;
			do
			{
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<AutoTrackBodies>();
				num = 1962362346U;
				base..ctor(intPtr);
			}
			while (126424966U > num);
			num |= 86262752U;
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000523B8 File Offset: 0x0004F9B8
		public static void Init()
		{
			uint num;
			GameObject gameObject;
			for (;;)
			{
				string text = "ML_Manager";
				num = 185547654U;
				gameObject = GameObject.Find(text);
				num = 1055401526U << (int)num;
				for (;;)
				{
					Object @object = gameObject;
					num = 1999791259U % num;
					Object object2 = null;
					num += 1896052538U;
					bool flag = @object == object2;
					num -= 1412505369U;
					if (!flag)
					{
						break;
					}
					if (1084250081U <= num)
					{
						GameObject gameObject2 = new GameObject("ML_Manager");
						num *= 1436377709U;
						gameObject = gameObject2;
						if ((989993268U ^ num) != 0U)
						{
							goto Block_2;
						}
					}
				}
				IL_7B:
				Object component = gameObject.GetComponent<AutoTrackBodies>();
				Object object3 = null;
				num >>= 4;
				bool flag2 = component == object3;
				num >>= 21;
				if (!flag2)
				{
					return;
				}
				num = 607527858U + num;
				if ((332214244U ^ num) != 0U)
				{
					break;
				}
				continue;
				Block_2:
				Object.DontDestroyOnLoad(gameObject);
				num += 2457102512U;
				goto IL_7B;
			}
			GameObject gameObject3 = gameObject;
			num += 153311282U;
			AutoTrackBodies.Instance = gameObject3.AddComponent<AutoTrackBodies>();
			num ^= 760839268U;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00052490 File Offset: 0x0004FA90
		// Note: this type is marked as 'beforefieldinit'.
		static AutoTrackBodies()
		{
			uint num;
			do
			{
				string text = "GGDH";
				string text2 = "Enable_AutoTrackBodies";
				num = 365843803U;
				bool flag = (num ^ 365843802U) != 0U;
				num ^= 835330067U;
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, null, null, (num ^ 604271944U) != 0U, (num ^ 604271944U) != 0U, null);
				num >>= 25;
				AutoTrackBodies.Enabled = enabled;
			}
			while (647368672U % num == 0U);
		}

		// Token: 0x04000138 RID: 312
		public static AutoTrackBodies Instance;

		// Token: 0x04000139 RID: 313
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
