using System;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000049 RID: 73
	[RegisterTypeInIl2Cpp]
	public class AutoNavigateLocalPlayerToPosition : MonoBehaviour
	{
		// Token: 0x0600012D RID: 301 RVA: 0x0005A4DC File Offset: 0x00057ADC
		public AutoNavigateLocalPlayerToPosition(IntPtr ptr)
		{
			uint num = 1840080006U;
			num *= 433848482U;
			base..ctor(ptr);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0005A500 File Offset: 0x00057B00
		public AutoNavigateLocalPlayerToPosition()
		{
			uint num = 1179788161U;
			if (1824197605U + num == 0U)
			{
				goto IL_37;
			}
			IL_12:
			IntPtr intPtr = ClassInjector.DerivedConstructorPointer<AutoNavigateLocalPlayerToPosition>();
			num >>= 19;
			base..ctor(intPtr);
			if (1421107420U >> (int)num == 0U)
			{
				return;
			}
			IL_37:
			ClassInjector.DerivedConstructorBody(this);
			if (num > 511649287U)
			{
				goto IL_12;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0005A558 File Offset: 0x00057B58
		public static void Init()
		{
			uint num = 1369311645U;
			do
			{
				string text = "ML_Manager";
				num = 2070491614U * num;
				GameObject gameObject = GameObject.Find(text);
				num += 235291365U;
				GameObject gameObject2 = gameObject;
				Object @object = gameObject2;
				Object object2 = null;
				num = 1274639647U + num;
				bool flag = @object == object2;
				num ^= 473761734U;
				if (flag)
				{
					num <<= 13;
					if (num * 1797679826U != 0U)
					{
						GameObject gameObject3 = new GameObject("ML_Manager");
						num >>= 8;
						gameObject2 = gameObject3;
						Object.DontDestroyOnLoad(gameObject2);
						num += 3704717164U;
					}
				}
				bool flag2 = gameObject2.GetComponent<AutoNavigateLocalPlayerToPosition>() == null;
				num -= 1495431426U;
				if (flag2)
				{
					num ^= 1805345255U;
					if (num < 2099129664U)
					{
						continue;
					}
					AutoNavigateLocalPlayerToPosition.Instance = gameObject2.AddComponent<AutoNavigateLocalPlayerToPosition>();
					num += 2491998685U;
				}
			}
			while (num == 834613378U);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0005A624 File Offset: 0x00057C24
		private void InitColliders()
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0005A634 File Offset: 0x00057C34
		// Note: this type is marked as 'beforefieldinit'.
		static AutoNavigateLocalPlayerToPosition()
		{
			string text = "GGDH";
			uint num = 2146323718U;
			string text2 = "Enable_AutoNavigateLocalPlayerToPosition";
			num = (2059682735U | num);
			bool flag = (num ^ 2146324398U) != 0U;
			num = (1167736922U | num);
			string text3 = null;
			num = 708986850U % num;
			string text4 = null;
			num -= 1637685288U;
			AutoNavigateLocalPlayerToPosition.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, num + 928698438U != 0U, num + 928698438U != 0U, null);
		}

		// Token: 0x04000182 RID: 386
		public static AutoNavigateLocalPlayerToPosition Instance;

		// Token: 0x04000183 RID: 387
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
