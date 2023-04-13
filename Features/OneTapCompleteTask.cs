using System;
using APIs.DragAndDrop;
using Handlers.GameHandlers.TaskHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using MelonLoader.Preferences;
using Objects;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x0200004D RID: 77
	[RegisterTypeInIl2Cpp]
	public class OneTapCompleteTask : MonoBehaviour
	{
		// Token: 0x06000140 RID: 320 RVA: 0x0005AEEC File Offset: 0x000584EC
		public OneTapCompleteTask(IntPtr ptr)
		{
			uint num = 1011881494U;
			if (num <= 763589428U)
			{
				goto IL_3B;
			}
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			do
			{
				IL_11:
				num *= 2104783876U;
				base..ctor(ptr);
				num /= 800219868U;
				ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			}
			while (2056062613U < num);
			IL_3B:
			num = (975074854U & num);
			ingameSettingsEntry.entry = OneTapCompleteTask.Enabled;
			num <<= 1;
			do
			{
				ingameSettingsEntry.name_cn = "任务列表秒任务";
				num += 669930961U;
				ingameSettingsEntry.name_eng = "Tasklist onetap completing task";
				num = 891239728U << (int)num;
				if (num + 1433015800U == 0U)
				{
					goto IL_11;
				}
				IngameSettings.IngameSettingsEntry ingameSettingsEntry2 = ingameSettingsEntry;
				num = (968053558U ^ num);
				IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry2);
			}
			while (num >> 16 == 0U);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0005AFA4 File Offset: 0x000585A4
		public OneTapCompleteTask()
		{
			uint num = 1916225634U;
			do
			{
				num &= 1681553060U;
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<OneTapCompleteTask>();
				num -= 196545128U;
				base..ctor(intPtr);
				num %= 441924031U;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (num > 1734548143U);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0005AFEC File Offset: 0x000585EC
		public static void Init()
		{
			uint num = 1969232854U;
			do
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				num = 2049518011U * num;
				GameObject gameObject2 = gameObject;
				if (num >= 101469402U)
				{
					bool flag = gameObject2 == null;
					num = (400561626U & num);
					if (flag)
					{
						string text = "ML_Manager";
						num %= 1079209838U;
						gameObject2 = new GameObject(text);
						num = 914322916U * num;
						Object.DontDestroyOnLoad(gameObject2);
						num ^= 164099674U;
					}
					num = (1481664290U & num);
					GameObject gameObject3 = gameObject2;
					num = 1422532867U >> (int)num;
					Object component = gameObject3.GetComponent<OneTapCompleteTask>();
					num >>= 30;
					Object @object = null;
					num *= 1056581144U;
					bool flag2 = component == @object;
					num >>= 10;
					if (flag2)
					{
						if (963314522 << (int)num == 0)
						{
							continue;
						}
						GameObject gameObject4 = gameObject2;
						num >>= 9;
						OneTapCompleteTask instance = gameObject4.AddComponent<OneTapCompleteTask>();
						num *= 873925232U;
						OneTapCompleteTask.Instance = instance;
						num += 0U;
					}
				}
			}
			while (73890242U <= num);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0005B0DC File Offset: 0x000586DC
		private static void CompleteTask(TaskPrefabHandler instance)
		{
			for (;;)
			{
				GameTask task = instance.task;
				uint num = 272776079U;
				if (task == null)
				{
					if ((884560614U & num) == 0U)
					{
						continue;
					}
				}
				else
				{
					num = (1163419050U | num);
					TaskObjectHandler taskObject = task.taskObject;
					num = 653930307U * num;
					if (taskObject == null)
					{
						num |= 708642558U;
						num ^= 2944250992U;
					}
					else
					{
						Interactable interactable = taskObject.interactable;
						num = 1873943399U + num;
						if (interactable == null)
						{
							num ^= 519740603U;
						}
						else
						{
							UnityEvent onClick = interactable.onClick;
							if (onClick == null)
							{
								num = 785266210U - num;
								if (788226289U % num != 0U)
								{
									num ^= 811054433U;
								}
							}
							else
							{
								num >>= 1;
								onClick.Invoke();
								num ^= 387868693U;
							}
						}
					}
				}
				IL_B8:
				num >>= 30;
				if (num != 290264132U)
				{
					num = (744193582U ^ num);
					instance.task.taskPanel.CompleteTask();
					num = (848067503U & num);
					if (2083218093U % num == 0U)
					{
						continue;
					}
					num &= 632700082U;
					TaskPanelHandler taskPanel = instance.task.taskPanel;
					num = 358810172U >> (int)num;
					taskPanel.canClosePanel = (num - 89702542U != 0U);
					num += 952060508U;
					if (num % 1251222565U != 0U)
					{
						TaskPanelHandler taskPanel2 = instance.task.taskPanel;
						num *= 902693783U;
						taskPanel2.ClosePanel();
						num = (1405315440U ^ num);
						ConsoleColor consoleColor = (ConsoleColor)(num - 195713251U);
						num = (988090263U | num);
						string str = "已秒任务: ";
						num = 1757484518U % num;
						string taskDisplayName = instance.task.taskDisplayName;
						num |= 1192063621U;
						string text = str + taskDisplayName;
						num &= 1755457729U;
						MelonLogger.Msg(consoleColor, text);
						if (1685461850U < num)
						{
							num *= 1715550008U;
							Object gameObject = instance.gameObject;
							num *= 458318945U;
							Object.Destroy(gameObject);
							if (num - 827392849U != 0U)
							{
								break;
							}
						}
					}
				}
				goto IL_B8;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0005B2B4 File Offset: 0x000588B4
		// Note: this type is marked as 'beforefieldinit'.
		static OneTapCompleteTask()
		{
			uint num = 1543325708U;
			string text = "GGDH";
			string text2 = "Enable_OneTapCompleteTask";
			bool flag = (num ^ 1543325709U) != 0U;
			string text3 = null;
			string text4 = null;
			bool flag2 = (num ^ 1543325708U) != 0U;
			bool flag3 = num - 1543325708U != 0U;
			ValueValidator valueValidator = null;
			num = (868446378U & num);
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num = (1528254681U ^ num);
			OneTapCompleteTask.Enabled = enabled;
		}

		// Token: 0x0400018B RID: 395
		public static OneTapCompleteTask Instance;

		// Token: 0x0400018C RID: 396
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x020000A8 RID: 168
		[HarmonyPatch(typeof(TaskPrefabHandler), "Update")]
		private class TaskPrefabHandler_TargetTask
		{
			// Token: 0x06000239 RID: 569 RVA: 0x00066530 File Offset: 0x00063B30
			private static void Postfix(TaskPrefabHandler __instance)
			{
				uint num = 565866068U;
				for (;;)
				{
					IL_06:
					OneTapCompleteTask.TaskPrefabHandler_TargetTask.<>c__DisplayClass0_0 CS$<>8__locals1 = new OneTapCompleteTask.TaskPrefabHandler_TargetTask.<>c__DisplayClass0_0();
					num = 639855014U % num;
					OneTapCompleteTask.TaskPrefabHandler_TargetTask.<>c__DisplayClass0_0 CS$<>8__locals2 = CS$<>8__locals1;
					Button button2;
					for (;;)
					{
						CS$<>8__locals2.__instance = __instance;
						if (num >> 7 != 0U)
						{
							for (;;)
							{
								MelonPreferences_Entry<bool> enabled = OneTapCompleteTask.Enabled;
								num = (1587704256U | num);
								bool value = enabled.Value;
								num = (1766873181U & num);
								if (value)
								{
									break;
								}
								if (num * 747912936U != 0U)
								{
									return;
								}
							}
							if (num >= 1990987511U)
							{
								goto IL_06;
							}
							Transform transform = CS$<>8__locals2.__instance.gameObject.transform;
							string text = "Selector";
							num += 654521429U;
							Transform transform2 = transform.Find(text);
							num <<= 25;
							Button button;
							if (transform2 == null)
							{
								num = 361261848U + num;
								if (num < 886136120U)
								{
									goto IL_06;
								}
								button = null;
							}
							else
							{
								button = transform2.GetComponent<Button>();
								num ^= 361261848U;
							}
							num %= 1737441722U;
							button2 = button;
							num += 763329759U;
							if (!(button2 == null))
							{
								break;
							}
							if (107050291U / num == 0U)
							{
								return;
							}
						}
					}
					if (1703149800U < num)
					{
						UnityEventBase onClick = button2.onClick;
						num /= 896220136U;
						if (onClick.GetPersistentEventCount() == (int)(num ^ 3U))
						{
							num = 1905591042U * num;
							Button button3 = button2;
							num &= 1145640586U;
							UnityEventBase onClick2 = button3.onClick;
							num = (538201428U & num);
							List<PersistentCall> calls = onClick2.m_PersistentCalls.m_Calls;
							int num2 = (int)(num ^ 1024U);
							num &= 167211283U;
							string methodName = calls[num2].m_MethodName;
							num = 541686011U >> (int)num;
							string b = "TargetTask";
							num /= 1959286355U;
							bool flag = methodName == b;
							num *= 1346642346U;
							num ^= 2U;
							if (flag)
							{
								num = 1226668724U << (int)num;
								UnityEventBase onClick3 = button2.onClick;
								num %= 34013870U;
								onClick3.RemoveAllListeners();
								Button button4 = button2;
								num += 428571151U;
								UnityEvent onClick4 = button4.onClick;
								num &= 755187832U;
								object @object = CS$<>8__locals2;
								IntPtr method = ldftn(<Postfix>b__0);
								num = 569797479U % num;
								onClick4.AddListener(new Action(@object, method));
								num += 4178548107U;
							}
						}
						if ((num & 236736623U) != 0U)
						{
							return;
						}
					}
				}
			}
		}
	}
}
