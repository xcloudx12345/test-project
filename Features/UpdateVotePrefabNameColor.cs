using System;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200002C RID: 44
	[RegisterTypeInIl2Cpp]
	public class UpdateVotePrefabNameColor : MonoBehaviour
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x000520B4 File Offset: 0x0004F6B4
		public UpdateVotePrefabNameColor(IntPtr ptr)
		{
			uint num = 113981653U;
			if (109933412U % num != 0U)
			{
				do
				{
					base..ctor(ptr);
				}
				while (num >= 827135638U);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000520E8 File Offset: 0x0004F6E8
		public UpdateVotePrefabNameColor()
		{
			uint num = 697766143U;
			do
			{
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<UpdateVotePrefabNameColor>();
				num = 1652437609U >> (int)num;
				base..ctor(intPtr);
				num *= 656632103U;
			}
			while (num % 490172605U != 0U);
			num = (395580906U & num);
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00052138 File Offset: 0x0004F738
		public static void Init()
		{
			uint num = 711149130U;
			for (;;)
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				num = 508653015U * num;
				GameObject gameObject2 = gameObject;
				if (1280125036U % num == 0U)
				{
					goto IL_4D;
				}
				IL_25:
				Object @object = gameObject2;
				num = 1233543238U + num;
				Object object2 = null;
				num = (1184449833U & num);
				if (@object == object2)
				{
					if (num >> 13 != 0U)
					{
						goto IL_4D;
					}
					continue;
				}
				IL_8C:
				GameObject gameObject3 = gameObject2;
				num = 1093876176U >> (int)num;
				Object component = gameObject3.GetComponent<UpdateVotePrefabNameColor>();
				num |= 670762294U;
				bool flag = component == null;
				num *= 301997728U;
				if (flag)
				{
					num = 493316506U / num;
					GameObject gameObject4 = gameObject2;
					num &= 592914175U;
					UpdateVotePrefabNameColor.Instance = gameObject4.AddComponent<UpdateVotePrefabNameColor>();
					num ^= 3682330976U;
				}
				if (926186900U < num)
				{
					break;
				}
				goto IL_25;
				IL_4D:
				string text = "ML_Manager";
				num = (1652884472U ^ num);
				GameObject gameObject5 = new GameObject(text);
				num = 424221420U - num;
				gameObject2 = gameObject5;
				num = (1851271542U ^ num);
				Object object3 = gameObject2;
				num = 593381135U << (int)num;
				Object.DontDestroyOnLoad(object3);
				num ^= 2030402600U;
				goto IL_8C;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00052230 File Offset: 0x0004F830
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateVotePrefabNameColor()
		{
			string text = "GGDH";
			string text2 = "Enable_UpdateVotePrefabNameColor";
			bool flag = true;
			string text3 = null;
			string text4 = null;
			uint num = 879837244U;
			bool flag2 = num + 3415130052U != 0U;
			bool flag3 = (num ^ 879837244U) != 0U;
			num = 1402691480U / num;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, null);
			num <<= 25;
			UpdateVotePrefabNameColor.Enabled = enabled;
		}

		// Token: 0x04000135 RID: 309
		public static UpdateVotePrefabNameColor Instance;

		// Token: 0x04000136 RID: 310
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
