using System;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000031 RID: 49
	[RegisterTypeInIl2Cpp]
	public class BombIndicator : MonoBehaviour
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0005348C File Offset: 0x00050A8C
		public static Sprite Bomb
		{
			get
			{
				return SpriteUtil.GetSpriteFromImageName("bomb.png");
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000534AC File Offset: 0x00050AAC
		public BombIndicator(IntPtr ptr)
		{
			uint num;
			do
			{
				num = 1615880239U;
				base..ctor(ptr);
			}
			while (786330210U > num);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000534D4 File Offset: 0x00050AD4
		public BombIndicator()
		{
			IntPtr intPtr = ClassInjector.DerivedConstructorPointer<BombIndicator>();
			uint num = 93729704U;
			base..ctor(intPtr);
			if (num <= 797532175U)
			{
				num = 1552230049U * num;
				ClassInjector.DerivedConstructorBody(this);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0005350C File Offset: 0x00050B0C
		public static void Init()
		{
			string text = "ML_Manager";
			uint num = 1668635380U;
			GameObject gameObject = GameObject.Find(text);
			do
			{
				bool flag = gameObject == null;
				num = 1428840925U + num;
				if (!flag)
				{
					goto IL_52;
				}
				GameObject gameObject2 = new GameObject("ML_Manager");
				num *= 1713717659U;
				gameObject = gameObject2;
			}
			while (num - 1539203309U == 0U);
			IL_44:
			Object.DontDestroyOnLoad(gameObject);
			num ^= 1598218074U;
			IL_52:
			if (gameObject.GetComponent<BombIndicator>() == null)
			{
				if (num == 1326994895U)
				{
					goto IL_44;
				}
				BombIndicator.Instance = gameObject.AddComponent<BombIndicator>();
				num ^= 0U;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0005359C File Offset: 0x00050B9C
		// Note: this type is marked as 'beforefieldinit'.
		static BombIndicator()
		{
			uint num;
			do
			{
				string text = "GGDH";
				num = 1354895627U;
				string text2 = "Enable_BombIndicator";
				num = 181630776U << (int)num;
				bool flag = num - 2612641791U != 0U;
				num |= 668537195U;
				BombIndicator.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, null, null, (num ^ 3220820331U) != 0U, (num ^ 3220820331U) != 0U, null);
			}
			while (1320104209U == num);
		}

		// Token: 0x0400013E RID: 318
		public static BombIndicator Instance;

		// Token: 0x0400013F RID: 319
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000140 RID: 320
		private const string bombSpriteName = "BombSprite";

		// Token: 0x0200008F RID: 143
		[HarmonyPatch(typeof(PlayerController), "Start")]
		public class AutoAddBombSprite
		{
			// Token: 0x06000207 RID: 519 RVA: 0x000641B0 File Offset: 0x000617B0
			private static void Postfix(PlayerController __instance)
			{
				while (BombIndicator.Enabled.Value)
				{
					GameObject gameObject = __instance.gameObject;
					uint num = 1878616855U;
					GameObject gameObject2 = gameObject;
					num = 1631732642U >> (int)num;
					if (num <= 420621897U)
					{
						string text = "BombSprite";
						num %= 957488478U;
						GameObject gameObject3 = new GameObject(text);
						Transform transform = gameObject3.transform;
						num = 1083584982U / num;
						GameObject gameObject4 = gameObject2;
						num %= 865545551U;
						transform.SetParent(gameObject4.transform);
						num &= 920031U;
						SpriteRenderer spriteRenderer = gameObject3.AddComponent<SpriteRenderer>();
						num += 57835012U;
						spriteRenderer.sprite = BombIndicator.Bomb;
						Transform transform2 = gameObject3.transform;
						float num2 = 0.05f;
						float num3 = -1.1f;
						float num4 = 1f;
						num = 1067084991U << (int)num;
						Vector3 localPosition = new Vector3(num2, num3, num4);
						num <<= 20;
						transform2.localPosition = localPosition;
						num >>= 4;
						gameObject3.transform.localScale = new Vector3(-0.3f, 0.3f, 1f);
						return;
					}
				}
			}

			// Token: 0x06000208 RID: 520 RVA: 0x000642A4 File Offset: 0x000618A4
			public AutoAddBombSprite()
			{
				uint num = 326177562U;
				if (1728327956U >= num)
				{
					do
					{
						base..ctor();
					}
					while (num * 1402361763U == 0U);
				}
			}
		}

		// Token: 0x02000090 RID: 144
		[HarmonyPatch(typeof(PlayerController), "Update")]
		public class UpdateBombSprite
		{
			// Token: 0x06000209 RID: 521 RVA: 0x000642D4 File Offset: 0x000618D4
			private static void Postfix(PlayerController __instance)
			{
				uint num = 771584920U;
				MelonPreferences_Entry<bool> enabled = BombIndicator.Enabled;
				num = 2110932554U / num;
				if (enabled.Value || 1217143142U % num != 0U)
				{
					num = (1515530490U & num);
					if (num != 749237724U)
					{
						num = (1645223130U ^ num);
						GameObject gameObject = __instance.gameObject;
						num <<= 22;
						GameObject gameObject2 = gameObject.transform.Find("BombSprite").gameObject;
						num = 1488281866U % num;
						gameObject2.SetActive(__instance.hasBomb);
						return;
					}
				}
			}
		}
	}
}
