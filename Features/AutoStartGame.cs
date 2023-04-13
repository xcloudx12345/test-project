using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Managers;
using Managers.ConnectionManagers;
using Managers.GameManagers;
using MelonLoader;
using MelonLoader.Preferences;
using Photon.Pun;
using Photon.Realtime;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200004F RID: 79
	[RegisterTypeInIl2Cpp]
	public class AutoStartGame : MonoBehaviour
	{
		// Token: 0x06000149 RID: 329 RVA: 0x0005B508 File Offset: 0x00058B08
		public AutoStartGame(IntPtr ptr)
		{
			for (;;)
			{
				IL_00:
				uint num = 431166646U;
				num = 1458393260U << (int)num;
				base..ctor(ptr);
				if (622809281U < num)
				{
					for (;;)
					{
						IngameSettings.IngameSettingsEntry ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
						do
						{
							num &= 585790439U;
							MelonPreferences_Entry enabled = AutoStartGame.Enabled;
							num = 997921778U - num;
							ingameSettingsEntry.entry = enabled;
							num *= 885287579U;
							num |= 377061185U;
							ingameSettingsEntry.name_cn = "自动开始游戏";
							num = 404773705U * num;
							if (num / 1881157629U != 0U)
							{
								goto IL_00;
							}
							ingameSettingsEntry.name_eng = "Auto Start Game";
							num <<= 14;
						}
						while (num < 1691105140U);
						IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
						if (num != 1728390490U)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0005B5C0 File Offset: 0x00058BC0
		public AutoStartGame() : base(ClassInjector.DerivedConstructorPointer<AutoStartGame>())
		{
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0005B5E0 File Offset: 0x00058BE0
		public static void Init()
		{
			uint num = 101003365U;
			string text = "ML_Manager";
			num %= 80955978U;
			GameObject gameObject = GameObject.Find(text);
			num |= 593966703U;
			GameObject gameObject2 = gameObject;
			num = 1543917081U / num;
			do
			{
				Object @object = gameObject2;
				Object object2 = null;
				num = 889550409U >> (int)num;
				if (@object == object2)
				{
					gameObject2 = new GameObject("ML_Manager");
					if (290483060U <= num)
					{
						continue;
					}
					Object object3 = gameObject2;
					num = 2080200120U / num;
					Object.DontDestroyOnLoad(object3);
					num += 222387593U;
				}
				num = 1719365520U + num;
				Object component = gameObject2.GetComponent<AutoStartGame>();
				num = (37252518U ^ num);
				Object object4 = null;
				num = (1147875927U & num);
				bool flag = component == object4;
				num = 1104554804U % num;
				if (!flag)
				{
					return;
				}
				num = (1427382508U | num);
			}
			while (1309431327U == num);
			AutoStartGame instance = gameObject2.AddComponent<AutoStartGame>();
			num %= 2002545720U;
			AutoStartGame.Instance = instance;
			num += 2885672756U;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0005B6BC File Offset: 0x00058CBC
		// Note: this type is marked as 'beforefieldinit'.
		static AutoStartGame()
		{
			uint num = 1930830756U;
			do
			{
				string text = "GGDH";
				num -= 904020024U;
				string text2 = "Enable_AutoStartGame";
				num &= 186069086U;
				bool flag = num - 152248396U != 0U;
				num = (1222709995U & num);
				string text3 = null;
				num = 1441025647U << (int)num;
				string text4 = null;
				num -= 927563250U;
				bool flag2 = num - 2902782222U != 0U;
				num = 121441645U * num;
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, (num ^ 3182319862U) != 0U, null);
				num *= 18689327U;
				AutoStartGame.Enabled = enabled;
				num *= 1006645730U;
				if (num <= 133267041U)
				{
					goto IL_11C;
				}
				string text5 = "GGDH";
				num = 1172723595U * num;
				string text6 = "AutoStartGame_restartGameCooldownTime";
				num ^= 464982112U;
				float num2 = 10f;
				string text7 = null;
				num -= 949903397U;
				string text8 = null;
				bool flag3 = (num ^ 73231767U) != 0U;
				num = (1504343352U | num);
				bool flag4 = (num ^ 1577024959U) != 0U;
				num = (1596130171U | num);
				ValueValidator valueValidator = null;
				num *= 2068387337U;
				MelonPreferences_Entry<float> melonPreferences_Entry = MelonPreferences.CreateEntry<float>(text5, text6, num2, text7, text8, flag3, flag4, valueValidator);
				num ^= 1820219968U;
				AutoStartGame.restartGameCooldownTime = melonPreferences_Entry;
				num &= 1683321828U;
				float num3 = -1f;
				num >>= 29;
				AutoStartGame.lastTimeClickedStartGameButton = num3;
			}
			while (1102277869U < num);
			float num4 = 3f;
			num *= 2069911907U;
			AutoStartGame.clickButtonInterval = num4;
			IL_11C:
			float num5 = -1f;
			num = 974415640U * num;
			AutoStartGame.doNotStartGameBeforeTime = num5;
		}

		// Token: 0x0400018F RID: 399
		public static AutoStartGame Instance;

		// Token: 0x04000190 RID: 400
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000191 RID: 401
		public static MelonPreferences_Entry<float> restartGameCooldownTime;

		// Token: 0x04000192 RID: 402
		private static float lastTimeClickedStartGameButton;

		// Token: 0x04000193 RID: 403
		private static float clickButtonInterval;

		// Token: 0x04000194 RID: 404
		private static float doNotStartGameBeforeTime;

		// Token: 0x020000AB RID: 171
		[HarmonyPatch(typeof(LobbySceneHandler), "Update")]
		private class LobbySceneHandler_Update
		{
			// Token: 0x0600023F RID: 575 RVA: 0x00066B10 File Offset: 0x00064110
			private static void Postfix(LobbySceneHandler __instance)
			{
				for (;;)
				{
					IL_00:
					MelonPreferences_Entry<bool> enabled = AutoStartGame.Enabled;
					uint num = 285808814U;
					if (!enabled.Value)
					{
						break;
					}
					for (;;)
					{
						num = 592137485U + num;
						MainManager instance = MainManager.Instance;
						GameManager.BODGLAFHFNH? bodglafhfnh;
						GameManager.BODGLAFHFNH? bodglafhfnh2;
						if (instance == null)
						{
							if (505377069U % num == 0U)
							{
								continue;
							}
							bodglafhfnh = null;
							num >>= 27;
							bodglafhfnh2 = bodglafhfnh;
						}
						else
						{
							num &= 458965027U;
							GameManager gameManager = instance.gameManager;
							num %= 900289717U;
							num *= 1076039656U;
							if (gameManager == null)
							{
								num &= 1348873064U;
								if (1273507995U * num == 0U)
								{
									continue;
								}
								bodglafhfnh = null;
								num = (1734882340U & num);
								bodglafhfnh2 = bodglafhfnh;
								num ^= 4202534U;
							}
							else
							{
								num = 620831120U / num;
								GameManager.BODGLAFHFNH gameState = gameManager.gameState;
								num = (2035232058U & num);
								bodglafhfnh2 = new GameManager.BODGLAFHFNH?(gameState);
								num += 4294967278U;
							}
						}
						num ^= 1980914473U;
						bodglafhfnh = bodglafhfnh2;
						num = (1109328327U & num);
						byte b = bodglafhfnh.Value;
						num /= 1863605284U;
						uint num2 = num + 2U;
						num = (750612821U ^ num);
						if (b == num2)
						{
							num |= 1743938313U;
							float time = Time.time;
							MelonPreferences_Entry<float> restartGameCooldownTime = AutoStartGame.restartGameCooldownTime;
							num = (735316577U | num);
							float value = restartGameCooldownTime.Value;
							num = 696588056U * num;
							float doNotStartGameBeforeTime = time + value;
							num = 1507339935U / num;
							AutoStartGame.doNotStartGameBeforeTime = doNotStartGameBeforeTime;
							num ^= 750612821U;
						}
						num = 1837242061U + num;
						if (Time.time < AutoStartGame.doNotStartGameBeforeTime)
						{
							break;
						}
						num = 1406105641U % num;
						if ((257845373U ^ num) == 0U)
						{
							goto IL_00;
						}
						num <<= 10;
						if (__instance.gameStarted)
						{
							return;
						}
						num = (428678747U & num);
						if (MainManager.Instance.gameManager.gameState != 0)
						{
							return;
						}
						num = 25055068U + num;
						if ((num & 763917852U) == 0U)
						{
							return;
						}
						if (PlayerController.playersList.Count < (int)(num ^ 452875097U))
						{
							goto Block_11;
						}
						num = 1010504267U % num;
						Player localPlayer = PhotonNetwork.LocalPlayer;
						num = 736234290U - num;
						if (1114926010U < num)
						{
							goto IL_00;
						}
						PhotonMasterManager photonMasterManager = MainManager.Instance.photonMasterManager;
						num %= 283053208U;
						bool flag = photonMasterManager.IsMasterClient(localPlayer);
						num -= 592727147U;
						if (!flag)
						{
							return;
						}
						float time2 = Time.time;
						num = 1286937224U * num;
						float num3 = time2 - AutoStartGame.lastTimeClickedStartGameButton;
						num = 1543250606U * num;
						float clickButtonInterval = AutoStartGame.clickButtonInterval;
						num *= 1449156297U;
						if (num3 >= clickButtonInterval)
						{
							goto IL_257;
						}
						if (num << 28 == 0U)
						{
							return;
						}
					}
					if (num >> 30 != 0U)
					{
						return;
					}
					continue;
					Block_11:
					if (1829591819U > num)
					{
						return;
					}
					continue;
					IL_257:
					num >>= 29;
					LobbySceneHandler instance2 = LobbySceneHandler.Instance;
					num += 857563691U;
					instance2.StartGame();
					if (num != 1043286271U)
					{
						goto Block_17;
					}
				}
				return;
				Block_17:
				AutoStartGame.lastTimeClickedStartGameButton = Time.time;
			}
		}
	}
}
