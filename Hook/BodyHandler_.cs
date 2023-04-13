using System;
using GGD_Hack.Features;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.TaskHandlers;
using HarmonyLib;
using UnityEngine;

namespace GGD_Hack.Hook
{
	// Token: 0x0200001C RID: 28
	public class BodyHandler_
	{
		// Token: 0x0200007B RID: 123
		[HarmonyPatch(typeof(BodyHandler), "Start")]
		public class Start_
		{
			// Token: 0x060001DB RID: 475 RVA: 0x00062F54 File Offset: 0x00060554
			private static void Postfix(BodyHandler __instance)
			{
				bool value = AutoTrackBodies.Enabled.Value;
				uint num = 410150759U;
				if (value && num >> 12 != 0U)
				{
					TaskTargetingHandler instance = TaskTargetingHandler.Instance;
					num ^= 1310863152U;
					instance.TargetBody(__instance);
					num += 3257016080U;
				}
			}
		}

		// Token: 0x0200007C RID: 124
		[HarmonyPatch(typeof(BodyHandler), "GetNearestValidLocation")]
		public class GetNearestValidLocation_
		{
			// Token: 0x060001DD RID: 477 RVA: 0x00062FBC File Offset: 0x000605BC
			[HarmonyPrefix]
			public static bool Prefix(ref Vector2 __result)
			{
				uint num = 1443707974U;
				if (5853037U % num != 0U)
				{
					Component instance = LocalPlayer.Instance;
					num = (1151295596U | num);
					Vector3 position = instance.transform.position;
					if (num * 1942055337U != 0U)
					{
						num = (1673538051U & num);
						Vector3 vector = position;
						num >>= 6;
						float x = vector.x;
						num -= 1601181603U;
						Vector3 vector2 = position;
						num = 1156664363U - num;
						float y = vector2.y;
						num = 1335431782U << (int)num;
						__result = new Vector2(x, y);
					}
				}
				return (num ^ 1150910464U) != 0U;
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0006304C File Offset: 0x0006064C
			public GetNearestValidLocation_()
			{
				uint num = 1653678926U;
				if (559819569U - num != 0U)
				{
					num >>= 8;
					base..ctor();
				}
			}
		}

		// Token: 0x0200007D RID: 125
		public class AMFDOIDPDKK_
		{
			// Token: 0x060001DF RID: 479 RVA: 0x0006307C File Offset: 0x0006067C
			[HarmonyPrefix]
			public static bool Prefix(ref Vector2 __result)
			{
				Component instance = LocalPlayer.Instance;
				uint num = 418786623U;
				Transform transform = instance.transform;
				num = (2021671902U & num);
				Vector3 position = transform.position;
				num %= 15891366U;
				if (num < 833493475U)
				{
					num = 338645398U + num;
					__result = new Vector2(position.x, position.y);
				}
				return (num ^ 352403326U) != 0U;
			}
		}

		// Token: 0x0200007E RID: 126
		public class HFHGEKGODNG_
		{
			// Token: 0x060001E1 RID: 481 RVA: 0x000630F4 File Offset: 0x000606F4
			[HarmonyPrefix]
			public static bool Prefix(ref Vector2 __result)
			{
				uint num = 422257741U;
				Vector3 vector;
				do
				{
					Vector3 position = LocalPlayer.Instance.transform.position;
					num |= 595413980U;
					vector = position;
					num >>= 24;
				}
				while (1283657356U + num == 0U);
				__result = new Vector2(vector.x, vector.y);
				return (num ^ 59U) != 0U;
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00063154 File Offset: 0x00060754
			public HFHGEKGODNG_()
			{
				uint num = 580258639U;
				do
				{
					num = 1647912390U >> (int)num;
					base..ctor();
				}
				while ((num ^ 596841372U) == 0U);
			}
		}

		// Token: 0x0200007F RID: 127
		public class IJECFDHCFIN_
		{
			// Token: 0x060001E3 RID: 483 RVA: 0x00063188 File Offset: 0x00060788
			[HarmonyPrefix]
			public static bool Prefix(ref Vector2 __result)
			{
				uint num = 518147581U;
				Vector3 position;
				do
				{
					Component instance = LocalPlayer.Instance;
					num = 2024890713U + num;
					position = instance.transform.position;
					num |= 1271223279U;
				}
				while (522937110U + num == 0U);
				float x = position.x;
				num = 186726296U % num;
				Vector3 vector = position;
				num = 1712214130U / num;
				float y = vector.y;
				num ^= 245384516U;
				Vector2 vector2 = new Vector2(x, y);
				num = (245910295U | num);
				__result = vector2;
				return (num ^ 245911391U) != 0U;
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00063208 File Offset: 0x00060808
			public IJECFDHCFIN_()
			{
				uint num = 1440041960U;
				do
				{
					num %= 1137800946U;
					base..ctor();
				}
				while (num >= 1838373185U);
			}
		}
	}
}
