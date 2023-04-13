using System;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features.Admin
{
	// Token: 0x02000067 RID: 103
	[RegisterTypeInIl2Cpp]
	public class ModDeveloperName : MonoBehaviour
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0005FBEC File Offset: 0x0005D1EC
		public ModDeveloperName(IntPtr ptr)
		{
			uint num = 1364288200U;
			if (num <= 1561273514U)
			{
				num = 1616538322U / num;
				base..ctor(ptr);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0005FC1C File Offset: 0x0005D21C
		public ModDeveloperName()
		{
			uint num = 722301207U;
			do
			{
				base..ctor(ClassInjector.DerivedConstructorPointer<ModDeveloperName>());
			}
			while (1140850706U <= num);
			do
			{
				num &= 670395047U;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (2028417928U == num);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0005FC60 File Offset: 0x0005D260
		public static void Init()
		{
			for (;;)
			{
				string text = "ML_Manager";
				uint num = 904465249U;
				GameObject gameObject = GameObject.Find(text);
				num |= 433856635U;
				GameObject gameObject2 = gameObject;
				num = (211760821U & num);
				if (1538545335U >> (int)num == 0U)
				{
					goto IL_53;
				}
				Object @object = gameObject2;
				Object object2 = null;
				num = (438465734U & num);
				if (@object == object2)
				{
					if (num >> 12 != 0U)
					{
						goto IL_53;
					}
					continue;
				}
				IL_74:
				if (1465345484U % num != 0U)
				{
					GameObject gameObject3 = gameObject2;
					num = 266106239U << (int)num;
					Object component = gameObject3.GetComponent<ModDeveloperName>();
					Object object3 = null;
					num ^= 688527806U;
					if (component == object3)
					{
						ModDeveloperName.Instance = gameObject2.AddComponent<ModDeveloperName>();
						num ^= 0U;
					}
					if (1537747915U != num)
					{
						break;
					}
					continue;
				}
				IL_53:
				gameObject2 = new GameObject("ML_Manager");
				num ^= 859916328U;
				Object.DontDestroyOnLoad(gameObject2);
				num += 3435050968U;
				goto IL_74;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0005FD34 File Offset: 0x0005D334
		public static void MarkAsDev(string userId)
		{
			uint num = 1814175824U;
			Dictionary<string, PlayerController> playersList = PlayerController.playersList;
			num = 1196231651U - num;
			bool flag = playersList.ContainsKey(userId);
			num += 1300833046U;
			if (!flag)
			{
				return;
			}
			num -= 868447101U;
			if (num >> 7 != 0U)
			{
				Dictionary<string, PlayerController> playersList2 = PlayerController.playersList;
				num = 2145015934U / num;
				Component playerNameText = playersList2[userId].playerNameText;
				num = 1237534904U * num;
				GameObject gameObject = playerNameText.gameObject;
				num = 720650147U + num;
				Transform transform = gameObject.transform.Find("Mod Developer Name");
				num >>= 15;
				num = 131139755U / num;
				if (transform == null)
				{
					num += 873741248U;
					if (1348953408 << (int)num != 0)
					{
						return;
					}
				}
				else
				{
					num *= 567811816U;
					transform.gameObject.SetActive(num - 1427629559U != 0U);
				}
				return;
			}
		}

		// Token: 0x040001A9 RID: 425
		public static ModDeveloperName Instance;

		// Token: 0x040001AA RID: 426
		public const string developerName = "Mod Developer Name";

		// Token: 0x020000C3 RID: 195
		[HarmonyPatch(typeof(PlayerController), "Start")]
		private class PlayerController_Start
		{
			// Token: 0x06000275 RID: 629 RVA: 0x00068170 File Offset: 0x00065770
			private static void Postfix(PlayerController __instance)
			{
				uint num = 2097232622U;
				if (num * 2032427663U != 0U)
				{
					do
					{
						num *= 1792703270U;
						TextMeshProUGUI playerNameText = __instance.playerNameText;
						num = 637618108U + num;
						TextMeshProUGUI textMeshProUGUI = playerNameText;
						GameObject gameObject = new GameObject();
						num = 807077537U % num;
						gameObject.name = "Mod Developer Name";
						Transform transform = gameObject.transform;
						Component component = textMeshProUGUI;
						num = 1470528608U - num;
						Transform transform2 = component.gameObject.transform;
						num |= 1099790102U;
						transform.SetParent(transform2, num + 2888859841U != 0U);
						Transform transform3 = gameObject.transform;
						num %= 339418398U;
						float num2 = 0f;
						num = 322194088U % num;
						float num3 = 40f;
						num ^= 1951432477U;
						float num4 = 0f;
						num = 1517771331U - num;
						transform3.localPosition = new Vector3(num2, num3, num4);
						num += 292422315U;
						num >>= 31;
						TextMeshProUGUI textMeshProUGUI2 = gameObject.AddComponent<TextMeshProUGUI>();
						RectTransform rectTransform = textMeshProUGUI2.rectTransform;
						float num5 = 500f;
						num += 842358582U;
						float num6 = 50f;
						num -= 542051714U;
						rectTransform.sizeDelta = new Vector2(num5, num6);
						num = (490487710U & num);
						num = 1636311077U >> (int)num;
						textMeshProUGUI2.alignment = num + 4294966250U;
						textMeshProUGUI2.horizontalAlignment = (num ^ 1562U);
						num -= 1863215410U;
						TMP_Text tmp_Text = textMeshProUGUI;
						num = 89277074U + num;
						textMeshProUGUI2.font = tmp_Text.font;
						num &= 187367940U;
						string format = "<sprite name=\"1f60e\"> <color=#FFD700>{0}</color> <sprite name=\"1f60e\">";
						num += 2108437475U;
						object arg;
						if (!Utils.IsChineseSystem())
						{
							num = (679177945U & num);
							arg = "Mod Dev";
						}
						else
						{
							num ^= 1645817764U;
							arg = "Mod开发者";
							num += 175442554U;
						}
						string text = string.Format(format, arg);
						num ^= 893929770U;
						textMeshProUGUI2.text = text;
						num ^= 908022215U;
						bool active = (num ^ 729562156U) != 0U;
						num = 2038640944U + num;
						gameObject.active = active;
					}
					while (85942117 << (int)num == 0);
				}
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0006833C File Offset: 0x0006593C
			public PlayerController_Start()
			{
				uint num;
				do
				{
					num = 1792016881U;
					base..ctor();
				}
				while ((1984184383U & num) == 0U);
			}
		}
	}
}
