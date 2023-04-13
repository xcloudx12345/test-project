using System;
using System.Collections.Generic;
using APIs.Photon;
using ExitGames.Client.Photon;
using GGD_Hack.Utils;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using MelonLoader.Preferences;
using Photon.Realtime;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x02000034 RID: 52
	[RegisterTypeInIl2Cpp]
	public class RandomName : MonoBehaviour
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00053818 File Offset: 0x00050E18
		public RandomName(IntPtr ptr)
		{
			uint num = 652497564U;
			if (num != 1133974990U)
			{
				num = 1040867591U % num;
				num = 1997815385U - num;
				base..ctor(ptr);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00053850 File Offset: 0x00050E50
		public RandomName()
		{
			uint num = 907440549U;
			if (1397847711U > num)
			{
				do
				{
					IntPtr intPtr = ClassInjector.DerivedConstructorPointer<RandomName>();
					num %= 1968508814U;
					base..ctor(intPtr);
					num >>= 15;
				}
				while (num >= 638078809U);
			}
			do
			{
				ClassInjector.DerivedConstructorBody(this);
			}
			while (num > 265162639U);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000538A8 File Offset: 0x00050EA8
		public static void Init()
		{
			uint num = 755899806U;
			GameObject gameObject;
			do
			{
				gameObject = GameObject.Find("ML_Manager");
				num -= 1721772644U;
				Object @object = gameObject;
				Object object2 = null;
				num &= 641752281U;
				if (!(@object == object2))
				{
					goto IL_5A;
				}
			}
			while (131026498U / num == 0U);
			GameObject gameObject2 = new GameObject("ML_Manager");
			num *= 1374240483U;
			gameObject = gameObject2;
			Object.DontDestroyOnLoad(gameObject);
			num += 1778088656U;
			IL_5A:
			Object component = gameObject.GetComponent<RandomName>();
			Object object3 = null;
			num = 2031687286U - num;
			if (component == object3)
			{
				num >>= 12;
				GameObject gameObject3 = gameObject;
				num = 1781219945U - num;
				RandomName instance = gameObject3.AddComponent<RandomName>();
				num >>= 27;
				RandomName.Instance = instance;
				num ^= 1926809171U;
			}
			object object4 = null;
			IntPtr method = ldftn(StoleNicknameFromHost);
			num >>= 23;
			PhotonCallbacksAPI.AddOnRoomListUpdateListener(new Action<List<RoomInfo>>(object4, method), num + 4294967068U != 0U);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00053978 File Offset: 0x00050F78
		public static bool CreateChangeRandomNameButton()
		{
			uint num = 156253409U;
			RandomName.<>c__DisplayClass7_0 CS$<>8__locals1 = new RandomName.<>c__DisplayClass7_0();
			num &= 1933016342U;
			RandomName.<>c__DisplayClass7_0 CS$<>8__locals2 = CS$<>8__locals1;
			num = 1107770487U * num;
			if (num % 550252639U != 0U)
			{
				Object @object = RandomName.changeRandomNameButton;
				num = (546665725U & num);
				Object object2 = null;
				num %= 1712275883U;
				if (!(@object != object2))
				{
					num /= 1159208609U;
					GameObject gameObject = GameObject.Find("Mode Select - Safe zone H");
					GameObject gameObject2 = gameObject;
					num = (1726884132U ^ num);
					Transform transform = gameObject2.transform.Find("Goose");
					num = 2007399914U % num;
					string text = "Find";
					num = (1244412483U ^ num);
					Component component = transform.Find(text);
					num %= 709709327U;
					RandomName.<>c__DisplayClass7_0 CS$<>8__locals3 = CS$<>8__locals2;
					num >>= 8;
					GameObject gameObject3 = gameObject;
					num = 755726590U + num;
					CS$<>8__locals3.nicknameInput = gameObject3.transform.Find("Nick Name Input");
					GameObject gameObject4 = component.gameObject;
					num += 897254855U;
					Transform transform2 = CS$<>8__locals2.nicknameInput.transform;
					num >>= 10;
					RandomName.changeRandomNameButton = Object.Instantiate<GameObject>(gameObject4, transform2);
					num = (1050217508U | num);
					if (757073972U / num == 0U)
					{
						List<string> list = new List<string>();
						list.Add("DropShadow");
						num = 893076678U - num;
						list.Add("Fill");
						num = (440733825U & num);
						num |= 1261259197U;
						list.Add("Shadow");
						num = 1627736067U >> (int)num;
						num = 1096627285U / num;
						list.Add("Border");
						List<string>.Enumerator enumerator = list.GetEnumerator();
						num = (336468053U & num);
						List<string>.Enumerator enumerator2 = enumerator;
						try
						{
							if (139267087U == num)
							{
								goto IL_189;
							}
							IL_184:
							goto IL_252;
							IL_189:
							num = 1541043634U;
							if (num == 429158394U)
							{
								goto IL_184;
							}
							num <<= 6;
							string text2 = enumerator2.Current;
							num -= 320035771U;
							string text3 = text2;
							num += 1644235922U;
							IL_1BB:
							Transform transform3 = RandomName.changeRandomNameButton.transform;
							num += 1144064569U;
							Transform transform4 = transform3.Find(text3);
							Object object3 = transform4;
							Object object4 = null;
							num = 1748197551U * num;
							bool flag = object3 != object4;
							num = 372994358U >> (int)num;
							num += 336069081U;
							if (flag)
							{
								num &= 81424011U;
								if (962210711U >= num)
								{
									Transform transform5 = transform4;
									num -= 1353586715U;
									float num2 = 0.6f;
									float num3 = 1f;
									num = 2020486542U << (int)num;
									float num4 = 1f;
									num <<= 10;
									transform5.localScale = new Vector3(num2, num3, num4);
									num += 4248901652U;
								}
							}
							IL_252:
							if (num == 1079457257U)
							{
								goto IL_184;
							}
							num *= 1089556512U;
							bool flag2 = enumerator2.MoveNext();
							num /= 710155000U;
							if (flag2)
							{
								goto IL_189;
							}
							if (num == 80357008U)
							{
								goto IL_1BB;
							}
						}
						finally
						{
							do
							{
								num = 1989412358U;
								((IDisposable)enumerator2).Dispose();
							}
							while (num == 186724515U);
						}
						do
						{
							IL_2A8:
							Object object5 = RandomName.changeRandomNameButton;
							num = 1741386931U;
							object5.name = "changeRandomNameButton";
							Button button;
							do
							{
								Transform transform6 = RandomName.changeRandomNameButton.transform;
								float num5 = -850f;
								float num6 = -65f;
								float num7 = 0f;
								num += 379194068U;
								transform6.localPosition = new Vector3(num5, num6, num7);
								GameObject gameObject5 = RandomName.changeRandomNameButton;
								num /= 1233267562U;
								GameObject gameObject6 = gameObject5.gameObject;
								num = 48968820U * num;
								button = gameObject6.GetComponent<Button>();
								Object object6 = button;
								Object object7 = null;
								num = (2112364559U ^ num);
								bool flag3 = object6 != object7;
								num %= 1870074967U;
								if (flag3)
								{
									if (735213489U + num == 0U)
									{
										continue;
									}
									Object object8 = button;
									num = (1840741509U | num);
									Object.DestroyImmediate(object8);
									num = 703080136U << (int)num;
									if (num >= 1101617090U)
									{
										goto IL_2A8;
									}
									GameObject gameObject7 = RandomName.changeRandomNameButton.gameObject;
									num = 1027543237U >> (int)num;
									button = gameObject7.AddComponent<Button>();
									num ^= 850596065U;
								}
								num = (758999699U | num);
							}
							while (1372675728U < num);
							UnityEvent onClick = button.onClick;
							object object9 = CS$<>8__locals2;
							num = 1647472007U + num;
							IntPtr method = ldftn(<CreateChangeRandomNameButton>b__0);
							num >>= 20;
							onClick.AddListener(new Action(object9, method));
							num %= 615403168U;
						}
						while (num == 1675656777U);
						GameObject gameObject8 = RandomName.changeRandomNameButton;
						num = 1907624962U - num;
						Transform transform7 = gameObject8.transform;
						string text4 = "Font";
						num %= 1676482067U;
						TMP_Text component2 = transform7.Find(text4).GetComponent<TextMeshProUGUI>();
						num &= 945112038U;
						string text5;
						if (!Utils.IsChineseSystem())
						{
							text5 = "Random";
						}
						else
						{
							text5 = "随机";
							num ^= 0U;
						}
						component2.text = text5;
						num = (525861648U | num);
						return (num ^ 526140369U) != 0U;
					}
				}
			}
			num = 348138946U / num;
			return num + 1U != 0U;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00053DDC File Offset: 0x000513DC
		private static void StoleNicknameFromHost(List<RoomInfo> roomInfos)
		{
			for (;;)
			{
				uint num = 1221870680U;
				List<RoomInfo>.Enumerator enumerator = roomInfos.GetEnumerator();
				num = 855391439U % num;
				List<RoomInfo>.Enumerator enumerator2 = enumerator;
				for (;;)
				{
					num &= 971658492U;
					if (num == 658528872U)
					{
						break;
					}
					List<RoomInfo>.Enumerator enumerator3 = enumerator2;
					num = (1875138714U | num);
					bool flag = enumerator3.MoveNext();
					num >>= 30;
					if (!flag)
					{
						return;
					}
					num = 319376153U;
					List<RoomInfo>.Enumerator enumerator4 = enumerator2;
					num -= 1278282017U;
					Hashtable customProperties = enumerator4.Current.CustomProperties;
					num *= 1503924504U;
					Object @object = "C1";
					num = 1388860319U % num;
					string nickname = customProperties[@object].ToString();
					num = (875250449U ^ num);
					RandomName.AddNicknameToList(nickname);
					num += 3424201793U;
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00053E84 File Offset: 0x00051484
		private static void AddNicknameToList(string nickname)
		{
			uint num = 1131872423U;
			do
			{
				RandomName.nicknames.Add(nickname);
				num = 1155481454U - num;
				if ((num ^ 1953851839U) != 0U)
				{
					List<string> list = RandomName.nicknames;
					num = (973300398U | num);
					bool flag = list.Contains(nickname);
					num ^= 606863579U;
					if (!flag)
					{
						num /= 1148788737U;
						if (284824393U >> (int)num != 0U)
						{
							List<string> list2 = RandomName.nicknames;
							num = 171533853U << (int)num;
							list2.Add(nickname);
							num += 353245207U;
						}
					}
				}
			}
			while (num > 1236818736U);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00053F1C File Offset: 0x0005151C
		private static string GetRandomNickname()
		{
			List<string> list = RandomName.nicknames;
			uint num = 1447264139U;
			bool count = list.Count != 0;
			num = (476651811U & num);
			if (!count)
			{
				num = 169503183U / num;
				if ((num ^ 1611935897U) != 0U)
				{
					return null;
				}
			}
			num <<= 17;
			List<string> list2 = RandomName.nicknames;
			int num2 = (int)(num ^ 1107689472U);
			List<string> list3 = RandomName.nicknames;
			num <<= 2;
			int index = Random.RandomRangeInt(num2, list3.Count);
			num |= 1993552061U;
			return list2[index];
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00053F94 File Offset: 0x00051594
		// Note: this type is marked as 'beforefieldinit'.
		static RandomName()
		{
			string text = "GGDH";
			string text2 = "Enable_RandomName";
			bool flag = true;
			uint num = 1864321921U;
			string text3 = null;
			num |= 1408778636U;
			string text4 = null;
			bool flag2 = num + 2147529843U != 0U;
			bool flag3 = (num ^ 2147437453U) != 0U;
			num %= 569990381U;
			ValueValidator valueValidator = null;
			num = 1354972641U / num;
			RandomName.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num -= 721032525U;
			if (1322058182U < num)
			{
				RandomName instance = null;
				num &= 380898024U;
				RandomName.Instance = instance;
			}
			do
			{
				GameObject gameObject = null;
				num >>= 12;
				RandomName.changeRandomNameButton = gameObject;
				List<string> list = new List<string>();
				num %= 586830382U;
				RandomName.nicknames = list;
			}
			while (num >= 916072542U);
		}

		// Token: 0x04000143 RID: 323
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000144 RID: 324
		public static RandomName Instance;

		// Token: 0x04000145 RID: 325
		public static GameObject changeRandomNameButton;

		// Token: 0x04000146 RID: 326
		public static List<string> nicknames;

		// Token: 0x02000094 RID: 148
		[HarmonyPatch(typeof(SceneManager), "Internal_SceneLoaded")]
		private class SceneManager_
		{
			// Token: 0x0600020F RID: 527 RVA: 0x00065148 File Offset: 0x00062748
			private static void Postfix(Scene scene)
			{
				uint num;
				do
				{
					ConsoleColor consoleColor = ConsoleColor.Green;
					num = 1192303467U;
					string str = "场景";
					string name = scene.name;
					num = 2134509430U >> (int)num;
					string str2 = "已加载!";
					num = (822094822U ^ num);
					MelonLogger.Msg(consoleColor, str + name + str2);
					num = 1910463774U / num;
				}
				while (num % 162607412U == 0U);
				if (scene.name == "MenuScene")
				{
					num += 639442065U;
					if (RandomName.CreateChangeRandomNameButton())
					{
						ConsoleColor consoleColor2 = (ConsoleColor)(num ^ 639442073U);
						num = 456727319U * num;
						string text = "已成功添加随机昵称按钮!";
						num ^= 196222943U;
						MelonLogger.Msg(consoleColor2, text);
						return;
					}
					num = 1413184569U + num;
					MelonLogger.Warning("添加随机昵称按钮失败!");
					num += 2242340662U;
				}
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00065208 File Offset: 0x00062808
			public SceneManager_()
			{
				uint num = 1508516546U;
				if (223093820U < num)
				{
					do
					{
						base..ctor();
					}
					while (num << 7 == 0U);
				}
			}
		}

		// Token: 0x02000095 RID: 149
		[HarmonyPatch(typeof(PlayerController), "Start")]
		private class StoleNameFromPlayerController
		{
			// Token: 0x06000211 RID: 529 RVA: 0x00065238 File Offset: 0x00062838
			private static void Postfix(PlayerController __instance)
			{
				RandomName.AddNicknameToList(__instance.nickname);
			}
		}
	}
}
