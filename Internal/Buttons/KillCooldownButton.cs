using System;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnityEngine;

namespace GGD_Hack.Internal.Buttons
{
	// Token: 0x02000014 RID: 20
	public class KillCooldownButton
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00051518 File Offset: 0x0004EB18
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00051570 File Offset: 0x0004EB70
		public static PlayerController CurrentTarget
		{
			get
			{
				uint num = 1325743380U;
				bool flag = KillCooldownButton.kill == null;
				num = 273709544U >> (int)num;
				if (flag && 1429170147U >= num)
				{
					return null;
				}
				num = 658190624U + num;
				return KillCooldownButton.kill.currentTarget as PlayerController;
			}
			set
			{
				uint num;
				do
				{
					UIButton uibutton = KillCooldownButton.kill;
					num = 264264706U;
					uibutton.currentTarget = value;
				}
				while (num >= 1044718509U);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0005159C File Offset: 0x0004EB9C
		public static bool KillFarest()
		{
			uint num = 455289943U;
			if (203097641U < num)
			{
				goto IL_13;
			}
			float num2;
			for (;;)
			{
				IL_4D:
				num2 = 0f;
				if (1293702914U / num != 0U)
				{
					goto IL_60;
				}
			}
			Dictionary<string, PlayerController>.Enumerator enumerator;
			PlayerController playerController;
			for (;;)
			{
				IL_1B4:
				num >>= 30;
				if (!enumerator.MoveNext())
				{
					goto Block_10;
				}
				Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
				num = 26499919U;
				KeyValuePair<string, PlayerController> keyValuePair = enumerator2.Current;
				num = 1793732649U * num;
				string key = keyValuePair.Key;
				PlayerController value = keyValuePair.Value;
				num = (1029575429U | num);
				playerController = value;
				num = 746085586U >> (int)num;
				if (1274046202U <= num)
				{
					goto IL_13;
				}
				bool flag = key != null;
				num ^= 2318142649U;
				if (flag)
				{
					if (num < 435504733U)
					{
						goto IL_13;
					}
					Object @object = playerController;
					Object object2 = null;
					num += 1761700037U;
					bool flag2 = @object == object2;
					num ^= 2030213317U;
					if (!flag2)
					{
						break;
					}
				}
			}
			if (1653175019U / num == 0U)
			{
				goto IL_129;
			}
			goto IL_4D;
			Block_10:
			PlayerController specificTarget;
			return KillCooldownButton.Kill(specificTarget);
			IL_13:
			Transform transform = LocalPlayer.Instance.transform;
			num += 708529366U;
			Vector3 position = transform.position;
			num -= 458768182U;
			Vector3 vector = position;
			num >>= 4;
			if (num < 1041444818U)
			{
				goto IL_4D;
			}
			goto IL_129;
			IL_60:
			PlayerController playerController2 = null;
			num *= 409347600U;
			specificTarget = playerController2;
			Dictionary<string, PlayerController>.Enumerator enumerator3 = PlayerController.playersList.GetEnumerator();
			num <<= 6;
			enumerator = enumerator3;
			if (num >= 1679240790U)
			{
				goto IL_1B4;
			}
			goto IL_13;
			IL_129:
			bool timeOfDeath = playerController.timeOfDeath != 0;
			num = 306716806U + num;
			num += 3988250490U;
			if (!timeOfDeath)
			{
				goto IL_1B4;
			}
			if (1657682718U % num == 0U)
			{
				goto IL_13;
			}
			Vector3 vector2 = vector;
			Vector3 acgbaghofip = playerController.ACGBAGHOFIP;
			num = 197025526U % num;
			float num3 = Vector3.Distance(vector2, acgbaghofip);
			float num4 = num2;
			num = 1524706571U % num;
			num ^= 2195220561U;
			if (num3 <= num4)
			{
				goto IL_1B4;
			}
			num |= 1240542680U;
			if (num != 646592051U)
			{
				PlayerController playerController3 = playerController;
				num = 1435190707U - num;
				specificTarget = playerController3;
				num += 14660645U;
				goto IL_1B4;
			}
			goto IL_60;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0005177C File Offset: 0x0004ED7C
		public static bool Kill(PlayerController specificTarget = null)
		{
			Object @object = KillCooldownButton.kill;
			uint num = 142766930U;
			if (@object == null)
			{
				if (1880698983U <= num)
				{
					goto IL_39;
				}
			}
			else
			{
				PlayerController playerController;
				if (num + 923483257U != 0U)
				{
					playerController = KillCooldownButton.CurrentTarget;
					num = 865624005U * num;
					if ((num ^ 1452804005U) == 0U)
					{
						goto IL_39;
					}
					num = 912544357U >> (int)num;
					bool flag = specificTarget;
					num = 146173232U >> (int)num;
					if (!flag)
					{
						goto IL_B5;
					}
				}
				KillCooldownButton.CurrentTarget = specificTarget;
				if (num == 1292844882U)
				{
					goto IL_21;
				}
				PlayerController currentTarget = KillCooldownButton.CurrentTarget;
				num /= 133909407U;
				playerController = currentTarget;
				num += 17843U;
				IL_B5:
				if (1781802386U * num != 0U)
				{
					MelonLogger.Msg("正在执行kill按钮方法，目标: " + playerController.nickname);
					num ^= 1508452623U;
					KillCooldownButton.Click(KillCooldownButton.kill);
					return num + 2786497349U != 0U;
				}
				goto IL_39;
			}
			IL_21:
			string text = "kill按钮未注册！";
			num = 271525242U >> (int)num;
			MelonLogger.Warning(text);
			IL_39:
			return num - 1035U != 0U;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00051878 File Offset: 0x0004EE78
		private static void Click(UICooldownButton cooldownButton)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0005189C File Offset: 0x0004EE9C
		// Note: this type is marked as 'beforefieldinit'.
		static KillCooldownButton()
		{
			uint num = 1496659181U;
			UICooldownButton uicooldownButton = null;
			num ^= 1162426638U;
			KillCooldownButton.kill = uicooldownButton;
			num = (1673028639U | num);
			ButtonType buttonType = (ButtonType)(num - 2147249659U);
			num -= 1484542595U;
			KillCooldownButton.type = buttonType;
		}

		// Token: 0x04000016 RID: 22
		public static UICooldownButton kill;

		// Token: 0x04000017 RID: 23
		public static ButtonType type;
	}
}
