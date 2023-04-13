using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using MelonLoader;
using MelonLoader.Preferences;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200004A RID: 74
	[RegisterTypeInIl2Cpp]
	public class AutoThrowAwayBomb : MonoBehaviour
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0005A694 File Offset: 0x00057C94
		public AutoThrowAwayBomb(IntPtr ptr)
		{
			uint num = 1626676912U;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			if ((num ^ 1668107824U) != 0U)
			{
				for (;;)
				{
					base..ctor(ptr);
					num = 1837964195U << (int)num;
					if (num + 444418029U != 0U)
					{
						ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
						if (847078819U >= num)
						{
							break;
						}
					}
				}
			}
			num += 1989310073U;
			MelonPreferences_Entry enabled = AutoThrowAwayBomb.Enabled;
			num ^= 1334137195U;
			ingameSettingsEntry.entry = enabled;
			ingameSettingsEntry.name_cn = "自动扔掉手上的炸弹";
			ingameSettingsEntry.name_eng = "Auto Throw Away Bomb";
			IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
			num = 982455936U - num;
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0005A72C File Offset: 0x00057D2C
		public AutoThrowAwayBomb()
		{
			uint num = 1994604516U;
			num >>= 18;
			base..ctor(ClassInjector.DerivedConstructorPointer<AutoThrowAwayBomb>());
			num = 75247865U % num;
			if (325934349U >= num)
			{
				num |= 1995851147U;
				ClassInjector.DerivedConstructorBody(this);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0005A774 File Offset: 0x00057D74
		public static void Init()
		{
			uint num = 494758688U;
			string text = "ML_Manager";
			num *= 1933932358U;
			GameObject gameObject = GameObject.Find(text);
			num = 1650490358U / num;
			GameObject gameObject2 = gameObject;
			num = 1260609058U + num;
			if ((1052520664U & num) == 0U)
			{
				goto IL_76;
			}
			Object @object = gameObject2;
			num <<= 20;
			bool flag = @object == null;
			num = 557264871U + num;
			if (!flag)
			{
				goto IL_8C;
			}
			IL_51:
			GameObject gameObject3 = new GameObject("ML_Manager");
			num /= 134816278U;
			gameObject2 = gameObject3;
			if (1923316483 << (int)num == 0)
			{
				goto IL_8C;
			}
			IL_76:
			Object object2 = gameObject2;
			num = (421885460U ^ num);
			Object.DontDestroyOnLoad(object2);
			num ^= 443701747U;
			IL_8C:
			num |= 1937668498U;
			bool flag2 = gameObject2.GetComponent<AutoThrowAwayBomb>() == null;
			num -= 44856546U;
			if (flag2)
			{
				GameObject gameObject4 = gameObject2;
				num = 178200417U >> (int)num;
				AutoThrowAwayBomb.Instance = gameObject4.AddComponent<AutoThrowAwayBomb>();
				num ^= 1892879169U;
			}
			if (377246774U % num != 0U)
			{
				return;
			}
			goto IL_51;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0005A85C File Offset: 0x00057E5C
		private void Update()
		{
			while (AutoThrowAwayBomb.Enabled.Value)
			{
				uint num = 1775904455U;
				LocalPlayer instance = LocalPlayer.Instance;
				num = (385500558U ^ num);
				num >>= 24;
				Object @object;
				if (instance == null)
				{
					if ((num ^ 805116322U) == 0U)
					{
						continue;
					}
					@object = null;
				}
				else
				{
					@object = instance.Player;
					num += 0U;
				}
				num = 1653033691U - num;
				if (@object == null)
				{
					if (num * 2102023828U != 0U)
					{
						return;
					}
				}
				else
				{
					num %= 2130727676U;
					if (471073855U * num != 0U)
					{
						LobbySceneHandler instance2 = LobbySceneHandler.Instance;
						num = 680154728U + num;
						bool flag;
						if (instance2 == null)
						{
							flag = (num - 2333188291U != 0U);
						}
						else
						{
							bool gameStarted = instance2.gameStarted;
							num = (1047684190U | num);
							uint num2 = num ^ 3212043486U;
							num = 1157643011U % num;
							flag = (gameStarted == num2);
							num += 1175545281U;
						}
						if (flag)
						{
							if (114321008 << (int)num != 0)
							{
								return;
							}
						}
						else
						{
							num = (630546103U ^ num);
							if ((1797940275U ^ num) == 0U)
							{
								continue;
							}
							if (!LocalPlayer.Instance.Player.hasBomb)
							{
								return;
							}
							Bomb.ThrowAwayBomb();
						}
						LocalPlayer.Instance.Player.hasBomb = (num + 1367015821U != 0U);
						num ^= 0U;
						return;
					}
				}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0005A998 File Offset: 0x00057F98
		// Note: this type is marked as 'beforefieldinit'.
		static AutoThrowAwayBomb()
		{
			string text = "GGDH";
			uint num = 358420500U;
			string text2 = "Enable_AutoThrowAwayBomb";
			num *= 1680880755U;
			bool flag = num + 2888677125U != 0U;
			num ^= 477496278U;
			string text3 = null;
			num = 1775248910U >> (int)num;
			string text4 = null;
			num = 1261854390U + num;
			bool flag2 = num + 3031379265U != 0U;
			num = 1989287057U + num;
			bool flag3 = num - 3252875088U != 0U;
			num = (88241157U | num);
			ValueValidator valueValidator = null;
			num = 1889020315U - num;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num /= 1582976129U;
			AutoThrowAwayBomb.Enabled = enabled;
		}

		// Token: 0x04000184 RID: 388
		public static AutoThrowAwayBomb Instance;

		// Token: 0x04000185 RID: 389
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
