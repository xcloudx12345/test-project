using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.PrefabAttachedHandlers;
using HarmonyLib;
using Il2CppSystem;
using Managers;
using Managers.ConnectionManagers;
using MelonLoader;
using MelonLoader.Preferences;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000051 RID: 81
	[RegisterTypeInIl2Cpp]
	public class AllowToSeeDeadPlayersChatMessagesInVotingScene : MonoBehaviour
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0005BF40 File Offset: 0x00059540
		public AllowToSeeDeadPlayersChatMessagesInVotingScene(IntPtr ptr)
		{
			uint num = 252983135U;
			for (;;)
			{
				base..ctor(ptr);
				num = 1308565766U + num;
				if (511989626U >> (int)num != 0U)
				{
					goto IL_27;
				}
				IL_3F:
				IngameSettings.IngameSettingsEntry ingameSettingsEntry;
				ingameSettingsEntry.entry = AllowToSeeDeadPlayersChatMessagesInVotingScene.Enabled;
				num %= 1280539858U;
				do
				{
					num = (2066297037U & num);
					ingameSettingsEntry.name_cn = "投票界面查看死人聊天";
					num ^= 858597089U;
					if (num * 593119052U == 0U)
					{
						goto IL_27;
					}
					num += 471158561U;
					string name_eng = "Show dead players' chat messages in voting scene";
					num %= 907309453U;
					ingameSettingsEntry.name_eng = name_eng;
				}
				while (num - 603144838U == 0U);
				IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
				if ((603290377U ^ num) != 0U)
				{
					break;
				}
				continue;
				IL_27:
				num *= 1942380451U;
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				num = 1325017427U + num;
				goto IL_3F;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0005C004 File Offset: 0x00059604
		public AllowToSeeDeadPlayersChatMessagesInVotingScene()
		{
			uint num = 1230122143U;
			base..ctor(ClassInjector.DerivedConstructorPointer<AllowToSeeDeadPlayersChatMessagesInVotingScene>());
			do
			{
				num |= 1594257989U;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (2065966991U <= num);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0005C03C File Offset: 0x0005963C
		public static void Init()
		{
			for (;;)
			{
				string text = "ML_Manager";
				uint num = 960300755U;
				GameObject gameObject = GameObject.Find(text);
				num = 665279814U - num;
				GameObject gameObject2 = gameObject;
				if (815611031U != num)
				{
					for (;;)
					{
						Object @object = gameObject2;
						num = 214269107U << (int)num;
						if (@object == null)
						{
							num = 958541294U - num;
							do
							{
								string text2 = "ML_Manager";
								num -= 1011225469U;
								GameObject gameObject3 = new GameObject(text2);
								num <<= 23;
								gameObject2 = gameObject3;
							}
							while (138768292U > num);
							Object object2 = gameObject2;
							num += 724060080U;
							Object.DontDestroyOnLoad(object2);
							num ^= 2251311024U;
						}
						if (num % 1204449283U != 0U)
						{
							GameObject gameObject4 = gameObject2;
							num = 593311891U >> (int)num;
							Object component = gameObject4.GetComponent<AllowToSeeDeadPlayersChatMessagesInVotingScene>();
							num *= 1127246958U;
							Object object3 = null;
							num = 1236549421U >> (int)num;
							bool flag = component == object3;
							num = (92893548U ^ num);
							if (!flag)
							{
								break;
							}
							if (num + 1378303841U != 0U)
							{
								goto Block_4;
							}
						}
					}
					IL_F2:
					if (num != 1511878449U)
					{
						break;
					}
					continue;
					Block_4:
					AllowToSeeDeadPlayersChatMessagesInVotingScene instance = gameObject2.AddComponent<AllowToSeeDeadPlayersChatMessagesInVotingScene>();
					num <<= 8;
					AllowToSeeDeadPlayersChatMessagesInVotingScene.Instance = instance;
					num += 1786689891U;
					goto IL_F2;
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0005C148 File Offset: 0x00059748
		// Note: this type is marked as 'beforefieldinit'.
		static AllowToSeeDeadPlayersChatMessagesInVotingScene()
		{
			uint num;
			do
			{
				string text = "GGDH";
				string text2 = "Enable_AllowToSeeDeadPlayersChatMessagesInVotingScene";
				num = 1584812201U;
				bool flag = (num ^ 1584812200U) != 0U;
				num &= 704999064U;
				string text3 = null;
				num = 544683810U << (int)num;
				string text4 = null;
				bool flag2 = num - 2000101888U != 0U;
				bool flag3 = (num ^ 2000101888U) != 0U;
				ValueValidator valueValidator = null;
				num = (498368279U | num);
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
				num *= 216488551U;
				AllowToSeeDeadPlayersChatMessagesInVotingScene.Enabled = enabled;
			}
			while (num <= 172253066U);
		}

		// Token: 0x04000199 RID: 409
		public static AllowToSeeDeadPlayersChatMessagesInVotingScene Instance;

		// Token: 0x0400019A RID: 410
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x020000AE RID: 174
		[HarmonyPatch(typeof(ChatManager), "IKMLHFKHHDD", new Type[]
		{
			typeof(Object)
		})]
		private class OnReceivedMessage
		{
			// Token: 0x06000245 RID: 581 RVA: 0x00066F34 File Offset: 0x00064534
			private static void Prefix(ref bool __state, Object __0)
			{
				uint num;
				for (;;)
				{
					MelonPreferences_Entry<bool> enabled = AllowToSeeDeadPlayersChatMessagesInVotingScene.Enabled;
					num = 1128867949U;
					if (!enabled.Value)
					{
						break;
					}
					LocalPlayer instance = LocalPlayer.Instance;
					num >>= 29;
					num = 474290834U / num;
					Object @object;
					if (instance == null)
					{
						num <<= 28;
						if (322187927U + num == 0U)
						{
							continue;
						}
						@object = null;
					}
					else
					{
						@object = instance.Player;
						num += 2178773687U;
					}
					Object object2 = null;
					num ^= 1048972459U;
					bool flag = @object == object2;
					num = 1102126839U * num;
					if (!flag)
					{
						goto IL_81;
					}
					if ((2098804038U ^ num) != 0U)
					{
						return;
					}
				}
				return;
				IL_81:
				num = 1843421284U / num;
				num = 1600724721U * num;
				PlayerController player = LocalPlayer.Instance.Player;
				num = (460926679U ^ num);
				__state = player.isGhost;
				byte gameState = MainManager.Instance.gameManager.gameState;
				num /= 1215381153U;
				if ((uint)gameState != num + 5U)
				{
					return;
				}
				PlayerController player2 = LocalPlayer.Instance.Player;
				bool isGhost = num + 1U != 0U;
				num += 1574635122U;
				player2.isGhost = isGhost;
				if (68749355U <= num)
				{
					return;
				}
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0006703C File Offset: 0x0006463C
			private static void Postfix(ref bool __state)
			{
				uint num = 414609379U;
				if (294259439U < num)
				{
					while (AllowToSeeDeadPlayersChatMessagesInVotingScene.Enabled.Value)
					{
						num ^= 2133879277U;
						if (num > 926030071U)
						{
							LocalPlayer instance = LocalPlayer.Instance;
							num = (1914315569U ^ num);
							Object @object;
							if (instance == null)
							{
								num = (1002335032U & num);
								if (1134036286 << (int)num == 0)
								{
									continue;
								}
								@object = null;
							}
							else
							{
								@object = instance.Player;
								num ^= 67109895U;
							}
							num = (893533529U & num);
							bool flag = @object == null;
							num = 2108382717U << (int)num;
							if (flag)
							{
								return;
							}
							PlayerController player = LocalPlayer.Instance.Player;
							num = 38041675U >> (int)num;
							player.isGhost = __state;
							return;
						}
					}
					return;
				}
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00067100 File Offset: 0x00064700
			public OnReceivedMessage()
			{
				uint num;
				do
				{
					num = 969421163U;
					base..ctor();
				}
				while (num >> 2 == 0U);
			}
		}

		// Token: 0x020000AF RID: 175
		[HarmonyPatch(typeof(MessagePrefabHandler), "Initialize")]
		private class FixLocalPlayerWrongDeathIcon
		{
			// Token: 0x06000248 RID: 584 RVA: 0x00067128 File Offset: 0x00064728
			private static void Prefix(MessagePrefabHandler __instance)
			{
				uint num = 1001206614U;
				if (num < 715482642U)
				{
					goto IL_38;
				}
				IL_11:
				string sender = __instance.sender;
				num = 322330323U / num;
				if (!(sender == LocalPlayer.Instance.Player.userId))
				{
					goto IL_6E;
				}
				IL_38:
				LocalPlayer instance = LocalPlayer.Instance;
				num = 1384595480U + num;
				uint timeOfDeath = (uint)instance.Player.timeOfDeath;
				num = (706035294U | num);
				__instance.isGhost = (timeOfDeath > num + 2238218658U);
				num ^= 2056748638U;
				IL_6E:
				if (num < 1732382635U)
				{
					return;
				}
				goto IL_11;
			}
		}
	}
}
