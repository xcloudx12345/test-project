using System;
using GGD_Hack.Events;
using Handlers.CommonHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200004B RID: 75
	[RegisterTypeInIl2Cpp]
	public class DeathAlarm : MonoBehaviour
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0005AA20 File Offset: 0x00058020
		public DeathAlarm(IntPtr ptr)
		{
			uint num;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				num = 1408783616U;
				base..ctor(ptr);
				num = (235361299U & num);
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
				MelonPreferences_Entry enabled = DeathAlarm.Enabled;
				num |= 1209742713U;
				ingameSettingsEntry.entry = enabled;
				num = 248478211U % num;
			}
			while (1398809463U == num);
			string name_cn = "死亡播报";
			num *= 340997877U;
			ingameSettingsEntry.name_cn = name_cn;
			num = 694700837U % num;
			num *= 1650077103U;
			ingameSettingsEntry.name_eng = "Death Alarm";
			num &= 648811796U;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
			num = 1994742422U * num;
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0005AAB8 File Offset: 0x000580B8
		public DeathAlarm() : base(ClassInjector.DerivedConstructorPointer<DeathAlarm>())
		{
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0005AADC File Offset: 0x000580DC
		public static void Init()
		{
			uint num;
			GameObject gameObject;
			for (;;)
			{
				string text = "ML_Manager";
				num = 1977431843U;
				gameObject = GameObject.Find(text);
				for (;;)
				{
					bool flag = gameObject == null;
					num &= 1888642521U;
					if (!flag)
					{
						goto IL_66;
					}
					if (num / 509102690U == 0U)
					{
						break;
					}
					GameObject gameObject2 = new GameObject("ML_Manager");
					num *= 1852597009U;
					gameObject = gameObject2;
					if ((728633713U ^ num) != 0U)
					{
						goto Block_2;
					}
				}
			}
			Block_2:
			Object @object = gameObject;
			num |= 161641844U;
			Object.DontDestroyOnLoad(@object);
			num += 614475660U;
			IL_66:
			num /= 327767594U;
			Object component = gameObject.GetComponent<DeathAlarm>();
			num |= 2068269577U;
			bool flag2 = component == null;
			num ^= 310792742U;
			if (flag2)
			{
				GameObject gameObject3 = gameObject;
				num %= 1806834622U;
				DeathAlarm.Instance = gameObject3.AddComponent<DeathAlarm>();
				num ^= 0U;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0005AB94 File Offset: 0x00058194
		private static void ShowPlayerDeathPanel(PlayerController player = null)
		{
			uint num = 627990055U;
			if (num > 1173238693U)
			{
				goto IL_33;
			}
			IL_11:
			LobbySceneHandler instance = LobbySceneHandler.Instance;
			num = 1333818358U << (int)num;
			if (instance == null)
			{
				num = (1330720448U ^ num);
			}
			else
			{
				num %= 1007107592U;
				num /= 1228491822U;
				bool flag = (num ^ 0U) != 0U;
				num &= 773685027U;
				instance.CallTributePanel(player, flag);
				num += 2406012352U;
			}
			IL_33:
			num &= 1122393200U;
			if ((num ^ 447617252U) == 0U)
			{
				goto IL_11;
			}
			SoundHandler instance2 = SoundHandler.Instance;
			num = (1461327984U ^ num);
			SoundHandler soundHandler = instance2;
			num &= 1449196U;
			SoundHandler soundHandler2 = soundHandler;
			num &= 101922712U;
			AudioSource mainSFXAudioSource = soundHandler2.mainSFXAudioSource;
			SoundHandler soundHandler3 = soundHandler;
			num = (1494052565U & num);
			AudioClip dndGooseDead = soundHandler3.DndGooseDead;
			num = (636891859U ^ num);
			mainSFXAudioSource.PlayOneShot(dndGooseDead);
			if (1131953895U >= num)
			{
				return;
			}
			goto IL_33;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0005AC64 File Offset: 0x00058264
		// Note: this type is marked as 'beforefieldinit'.
		static DeathAlarm()
		{
			string text = "GGDH";
			uint num = 1384789929U;
			string text2 = "Enable_DeathAlarm";
			num += 1183593812U;
			bool flag = num - 2568383740U != 0U;
			num ^= 76679433U;
			DeathAlarm.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, null, null, (num ^ 2642699764U) != 0U, (num ^ 2642699764U) != 0U, null);
		}

		// Token: 0x04000186 RID: 390
		public static DeathAlarm Instance;

		// Token: 0x04000187 RID: 391
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x020000A4 RID: 164
		[HarmonyPatch(typeof(InGameEvents), "Receive_Kill")]
		private class InGameEvents_Receive_Kill
		{
			// Token: 0x06000231 RID: 561 RVA: 0x00065E2C File Offset: 0x0006342C
			private static void Postfix(string killerUserId, string killedUserId, string stingerId)
			{
				uint num = 56588463U;
				Dictionary<string, PlayerController> playersList;
				for (;;)
				{
					MelonPreferences_Entry<bool> enabled = DeathAlarm.Enabled;
					num = 1543010893U << (int)num;
					bool value = enabled.Value;
					num = (319499411U & num);
					if (!value)
					{
						break;
					}
					num = 389497170U / num;
					if (num / 59534569U == 0U)
					{
						playersList = PlayerController.playersList;
						if (playersList != null)
						{
							goto IL_65;
						}
						num |= 1451903821U;
						if (num != 2090555768U)
						{
							goto Block_4;
						}
					}
				}
				return;
				Block_4:
				PlayerController player = null;
				goto IL_83;
				IL_65:
				num = 114701500U + num;
				num += 1031566544U;
				player = playersList[killedUserId];
				num += 305635776U;
				IL_83:
				DeathAlarm.ShowPlayerDeathPanel(player);
			}
		}
	}
}
