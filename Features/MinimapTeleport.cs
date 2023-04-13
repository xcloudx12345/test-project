using System;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.SpecialBehaviour;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x0200003A RID: 58
	[RegisterTypeInIl2Cpp]
	public class MinimapTeleport : MonoBehaviour
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00055B04 File Offset: 0x00053104
		public MinimapTeleport(IntPtr ptr)
		{
			uint num;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				base..ctor(ptr);
				do
				{
					num = 2130402225U;
					ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
					num %= 391718020U;
					num = 1061491970U % num;
					MelonPreferences_Entry enabled = MinimapTeleport.Enabled;
					num <<= 31;
					ingameSettingsEntry.entry = enabled;
					num += 301998385U;
				}
				while (num == 81223094U);
				string name_cn = "Minimap右键传送";
				num = 443748719U / num;
				ingameSettingsEntry.name_cn = name_cn;
				num = (1412510845U & num);
				ingameSettingsEntry.name_eng = "Minimap right-click to Teleport";
				num /= 1636313270U;
			}
			while (1247021108U >> (int)num == 0U);
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00055BA8 File Offset: 0x000531A8
		public MinimapTeleport()
		{
			uint num = 465990153U;
			IntPtr intPtr = ClassInjector.DerivedConstructorPointer<MinimapTeleport>();
			num <<= 7;
			base..ctor(intPtr);
			num = 1716856195U << (int)num;
			if (num << 23 != 0U)
			{
				do
				{
					num = 1397891255U + num;
					ClassInjector.DerivedConstructorBody(this);
				}
				while (num % 937441033U == 0U);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00055C04 File Offset: 0x00053204
		public static void Init()
		{
			for (;;)
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				uint num = 2025727273U;
				GameObject gameObject2 = gameObject;
				num %= 1943026406U;
				for (;;)
				{
					bool flag = gameObject2 == null;
					num >>= 10;
					if (flag)
					{
						num += 490762744U;
						string text = "ML_Manager";
						num = (558564793U | num);
						gameObject2 = new GameObject(text);
						Object @object = gameObject2;
						num += 1427799893U;
						Object.DontDestroyOnLoad(@object);
						num += 1838878250U;
					}
					GameObject gameObject3 = gameObject2;
					num = 335901997U % num;
					Object component = gameObject3.GetComponent<MinimapTeleport>();
					Object object2 = null;
					num = (805724670U ^ num);
					if (component == object2)
					{
						num = (153247915U | num);
						if (num == 22348546U)
						{
							break;
						}
						MinimapTeleport instance = gameObject2.AddComponent<MinimapTeleport>();
						num = 2047487903U / num;
						MinimapTeleport.Instance = instance;
						num ^= 805721051U;
					}
					if ((1849244541U ^ num) != 0U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00055CCC File Offset: 0x000532CC
		private bool GetMouseLocalPositionOnMinimapPanel(out Vector2 localPosition)
		{
			uint num = 1582267835U;
			num *= 1314401841U;
			localPosition = Vector2.zero;
			try
			{
				bool result;
				if ((1683232836U & num) != 0U)
				{
					for (;;)
					{
						GameObject gameObject = GameInstances.FindGameObjectByPath("Canvas/MiniMap/Panel");
						if (1869423523 << (int)num == 0)
						{
							break;
						}
						Object @object = gameObject;
						num = 910886424U % num;
						bool flag = @object == null;
						num >>= 2;
						if (flag)
						{
							goto IL_5E;
						}
						num |= 1346767049U;
						if (num << 6 != 0U)
						{
							GameObject gameObject2 = gameObject;
							num -= 278550608U;
							Component component = gameObject2.GetComponent<Image>();
							num = (749087443U & num);
							Vector3 mousePosition = Input.mousePosition;
							num <<= 29;
							Vector2 vector = mousePosition;
							RectTransform component2 = component.GetComponent<RectTransform>();
							Vector2 vector2 = vector;
							num += 98767707U;
							Camera camera = null;
							num = (500377245U | num);
							bool flag2 = RectTransformUtility.ScreenPointToLocalPointInRectangle(component2, vector2, camera, ref localPosition);
							num = (2011124976U | num);
							if (!flag2)
							{
								goto IL_158;
							}
							if (511778721U - num != 0U)
							{
								string str = "Click position relative to MiniMap panel's image component: ";
								num ^= 368250968U;
								string str2 = localPosition.x.ToString();
								num = 590244623U / num;
								string str3 = ", ";
								num = (122956469U | num);
								string text = str + str2 + str3 + localPosition.y.ToString();
								num = (213261396U | num);
								MelonLogger.Msg(text);
								bool flag3 = num - 267796212U != 0U;
								num >>= 28;
								result = flag3;
								if (num < 1401039201U)
								{
									break;
								}
							}
						}
					}
					goto IL_174;
					IL_158:
					return false;
				}
				IL_5E:
				num |= 471008076U;
				bool flag4 = num + 3798744114U != 0U;
				num ^= 677196103U;
				result = flag4;
				goto IL_174;
			}
			catch (Exception ex)
			{
				MelonLogger.Warning(ex.Message);
			}
			return false;
			IL_174:
			num = 1354501177U;
			if (num <= 1799317294U)
			{
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00055E7C File Offset: 0x0005347C
		private bool LocalPositionOnMinimapToPosition(in Vector2 localPosition, out Vector3 position)
		{
			uint num = 1759468224U;
			if (1478888795U * num == 0U)
			{
				goto IL_30;
			}
			IL_12:
			num %= 729966489U;
			position = Vector3.zero;
			if (2045653613U <= num)
			{
				goto IL_57;
			}
			IL_30:
			MiniMapHandler miniMapHandler = MinimapESP.miniMapHandler;
			num = 1818000710U - num;
			MiniMapHandler miniMapHandler2 = miniMapHandler;
			num = 1188457634U << (int)num;
			if (1085543335U >= num)
			{
				goto IL_12;
			}
			IL_57:
			if (miniMapHandler2 == null)
			{
				return num - 2717908992U != 0U;
			}
			num = 206774394U << (int)num;
			num = 2033327561U + num;
			float x = localPosition.x;
			num = (1998263757U ^ num);
			float num2 = x - miniMapHandler2.xOffset;
			num |= 2112366828U;
			float num3 = num2;
			num = 455021310U >> (int)num;
			float xFactor = miniMapHandler2.xFactor;
			num = 2031887543U + num;
			float num4 = num3 / xFactor;
			float y = localPosition.y;
			MiniMapHandler miniMapHandler3 = miniMapHandler2;
			num = 816986483U >> (int)num;
			float yOffset = miniMapHandler3.yOffset;
			num &= 355472338U;
			float num5 = y - yOffset;
			num *= 692530907U;
			MiniMapHandler miniMapHandler4 = miniMapHandler2;
			num -= 632901333U;
			float num6 = num5 / miniMapHandler4.yFactor;
			float num7 = 0f;
			num ^= 1849261637U;
			position = new Vector3(num4, num6, num7);
			return num + 3731043117U != 0U;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00055FA0 File Offset: 0x000535A0
		private void Update()
		{
			for (;;)
			{
				IL_00:
				MelonPreferences_Entry<bool> enabled = MinimapTeleport.Enabled;
				uint num = 87494646U;
				bool value = enabled.Value;
				num = 731801571U - num;
				if (!value)
				{
					if ((854540197U ^ num) != 0U)
					{
						break;
					}
				}
				else
				{
					do
					{
						int num2 = (int)(num ^ 644306924U);
						num = (1637097630U & num);
						bool mouseButtonDown = Input.GetMouseButtonDown(num2);
						num = (1786275298U ^ num);
						if (!mouseButtonDown)
						{
							goto IL_126;
						}
						if ((num ^ 801273161U) == 0U)
						{
							goto IL_00;
						}
						string text = "Canvas/MiniMap";
						num -= 2092649326U;
						Object @object = GameObject.Find(text);
						num = (1644776323U | num);
						bool flag = @object;
						num ^= 1643674745U;
						if (!flag)
						{
							return;
						}
						num <<= 25;
					}
					while (num < 1255288244U);
					num ^= 1176199544U;
					Vector2 vector;
					bool mouseLocalPositionOnMinimapPanel = this.GetMouseLocalPositionOnMinimapPanel(out vector);
					num = 2115386283U % num;
					if (!mouseLocalPositionOnMinimapPanel)
					{
						return;
					}
					num = (601383010U | num);
					num = (1153384569U ^ num);
					num = 669934285U / num;
					num *= 2133938806U;
					Vector3 position;
					if (!this.LocalPositionOnMinimapToPosition(vector, out position))
					{
						if (275664469U >= num)
						{
							return;
						}
						continue;
					}
					else
					{
						num <<= 10;
						Component instance = LocalPlayer.Instance;
						num += 266358749U;
						Transform transform = instance.transform;
						num = 1111510441U >> (int)num;
						transform.position = position;
						num += 1249666412U;
					}
					IL_126:
					if (1975532647U >> (int)num != 0U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000560E8 File Offset: 0x000536E8
		// Note: this type is marked as 'beforefieldinit'.
		static MinimapTeleport()
		{
			string text = "GGDH";
			string text2 = "Enable_MinimapTeleport";
			bool flag = true;
			string text3 = null;
			string text4 = null;
			uint num = 1921004459U;
			bool flag2 = num - 1921004459U != 0U;
			num %= 819537491U;
			MinimapTeleport.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, num - 281929477U != 0U, null);
		}

		// Token: 0x04000153 RID: 339
		private static MinimapTeleport Instance;

		// Token: 0x04000154 RID: 340
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
