using System;
using APIs.DragAndDrop;
using GGD_Hack.Events;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.TaskHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;
using Managers;
using Managers.GameManagers;
using MelonLoader;
using MelonLoader.Preferences;
using Objects;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;

namespace GGD_Hack.Features
{
	// Token: 0x02000048 RID: 72
	[RegisterTypeInIl2Cpp]
	public class AutoTasks : MonoBehaviour
	{
		// Token: 0x06000123 RID: 291 RVA: 0x00059574 File Offset: 0x00056B74
		public AutoTasks(IntPtr ptr)
		{
			uint num;
			IngameSettings.IngameSettingsEntry ingameSettingsEntry;
			for (;;)
			{
				num = 1707499924U;
				this.beforePrecursorTrueTime = -1f;
				num = 2135567091U + num;
				for (;;)
				{
					this.taskTime = -1f;
					num = 258695465U >> (int)num;
					if (num > 961350471U)
					{
						break;
					}
					float num2 = -1f;
					num = 1744068502U / num;
					this.cooldownWaitingTime = num2;
					num = (641548430U | num);
					this.precursorAfterCompletingTaskWaitingTime = -1f;
					num = 1168653250U - num;
					if (1729434253U / num == 0U)
					{
						break;
					}
					num = 1253984593U % num;
					float num3 = -1f;
					num = (1882918535U & num);
					this.doTaskAfterGameStartedIntervalWaitingTime = num3;
					num = 825116950U + num;
					this.tpToTaskPosition = ((num ^ 827740566U) != 0U);
					num = (1126522516U & num);
					base..ctor(ptr);
					ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
					if (num << 9 != 0U)
					{
						goto Block_2;
					}
				}
			}
			Block_2:
			num <<= 15;
			MelonPreferences_Entry enabled = AutoTasks.Enabled;
			num &= 658075526U;
			ingameSettingsEntry.entry = enabled;
			num = (1694506307U | num);
			ingameSettingsEntry.name_cn = "瞬移自动任务(测试中)";
			ingameSettingsEntry.name_eng = "Auto Tasks with TP(Testing)";
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00059690 File Offset: 0x00056C90
		public AutoTasks()
		{
			uint num;
			do
			{
				num = 274803782U;
				float num2 = -1f;
				num = 658593794U + num;
				this.beforePrecursorTrueTime = num2;
				num %= 250166364U;
				this.taskTime = -1f;
				num |= 318595130U;
				this.cooldownWaitingTime = -1f;
				num *= 631646278U;
				float num3 = -1f;
				num |= 1112492783U;
				this.precursorAfterCompletingTaskWaitingTime = num3;
				num = 258427824U % num;
				float num4 = -1f;
				num &= 1217096696U;
				this.doTaskAfterGameStartedIntervalWaitingTime = num4;
				num -= 1800234267U;
				bool flag = (num ^ 2629166740U) != 0U;
				num = 1857624572U >> (int)num;
				this.tpToTaskPosition = flag;
				num = 844763955U % num;
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<AutoTasks>();
				num /= 358704781U;
				base..ctor(intPtr);
				num *= 1289494243U;
				num += 757408401U;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (422475069U >= num);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00059774 File Offset: 0x00056D74
		public static void Init()
		{
			uint num = 1832781479U;
			if (525928389U % num == 0U)
			{
				goto IL_74;
			}
			string text = "ML_Manager";
			num = 335771209U << (int)num;
			GameObject gameObject = GameObject.Find(text);
			num = 165217841U - num;
			if (num << 21 == 0U)
			{
				goto IL_53;
			}
			IL_3F:
			Object @object = gameObject;
			num = 1613257039U + num;
			if (!(@object == null))
			{
				goto IL_74;
			}
			IL_53:
			gameObject = new GameObject("ML_Manager");
			Object object2 = gameObject;
			num /= 1837710797U;
			Object.DontDestroyOnLoad(object2);
			num += 1749433088U;
			IL_74:
			if (518927213U != num)
			{
				Object component = gameObject.GetComponent<AutoTasks>();
				num = (1477341867U ^ num);
				if (component == null)
				{
					num += 1998809262U;
					AutoTasks.Instance = gameObject.AddComponent<AutoTasks>();
					num += 2296158034U;
				}
				return;
			}
			goto IL_3F;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00059834 File Offset: 0x00056E34
		private void Update()
		{
			uint num = 1460999833U;
			if (1196588052U >> (int)num == 0U)
			{
				goto IL_42;
			}
			for (;;)
			{
				IL_18:
				bool value = AutoTasks.Enabled.Value;
				num = (801136002U ^ num);
				if (value)
				{
					break;
				}
				if (254280587 << (int)num != 0)
				{
					return;
				}
			}
			for (;;)
			{
				IL_42:
				LocalPlayer instance = LocalPlayer.Instance;
				Object @object;
				if (instance == null)
				{
					num &= 1495363001U;
					if (num / 35159557U != 0U)
					{
						goto IL_62;
					}
					return;
				}
				else
				{
					num = 291246593U % num;
					@object = instance.Player;
					num += 1185232664U;
				}
				IL_7D:
				Object object2 = null;
				num = 979578973U - num;
				if (!(@object == object2))
				{
					num = 619407043U * num;
					for (;;)
					{
						IL_98:
						LobbySceneHandler instance2 = LobbySceneHandler.Instance;
						num = 1122504865U << (int)num;
						bool flag;
						if (instance2 == null)
						{
							num += 1895387117U;
							num <<= 2;
							flag = (num + 938639437U != 0U);
						}
						else
						{
							num = (1741179362U & num);
							bool gameStarted = instance2.gameStarted;
							num = (1559257344U | num);
							uint num2 = num ^ 1576558848U;
							num *= 1152731127U;
							flag = (gameStarted == num2);
							num ^= 3934382260U;
						}
						num = 918178305U + num;
						if (flag)
						{
							goto Block_5;
						}
						num -= 372594820U;
						AutoTasks.TasksState tasksState = this.state;
						num <<= 3;
						if (num << 7 != 0U)
						{
							AutoTasks.TasksState tasksState2 = tasksState;
							num = 393042824U >> (int)num;
							switch (tasksState2)
							{
							case 0:
							{
								GameTask gameTask = null;
								num = (671904502U & num);
								AutoTasks.currentTask = gameTask;
								num |= 925716153U;
								if (Time.time > this.doTaskAfterGameStartedIntervalWaitingTime)
								{
									LobbySceneHandler instance3 = LobbySceneHandler.Instance;
									num = 1744469045U >> (int)num;
									GameObject tasksList = instance3.tasksListHandler.tasksList;
									int num3 = (int)(num + 4294967284U);
									while (num + 1805663424U != 0U)
									{
										int num4 = num3;
										num %= 317460372U;
										if (num4 >= tasksList.transform.childCount)
										{
											num += 578631764U;
										}
										else
										{
											num = 523831678U;
											GameObject gameObject = tasksList;
											num /= 1211374054U;
											Transform transform = gameObject.transform;
											num = 1985890903U >> (int)num;
											int num5 = num3;
											num >>= 13;
											Component child = transform.GetChild(num5);
											num = 266809500U << (int)num;
											TaskPrefabHandler component = child.gameObject.GetComponent<TaskPrefabHandler>();
											num = (603075929U & num);
											GameTask gameTask2;
											if (component == null)
											{
												gameTask2 = null;
											}
											else
											{
												num = 1315445906U / num;
												gameTask2 = component.task;
												num += 40894432U;
											}
											num %= 1482447711U;
											GameTask gameTask3 = gameTask2;
											num >>= 26;
											if (num * 1455431991U != 0U)
											{
												goto IL_18;
											}
											bool flag2 = gameTask3 != null;
											num = (578631776U | num);
											if (flag2)
											{
												num = 99356122U - num;
												bool flag3 = gameTask3 != null;
												num *= 219307507U;
												Object object3;
												if (!flag3)
												{
													object3 = null;
												}
												else
												{
													TaskObjectHandler taskObject = gameTask3.taskObject;
													num |= 2061712191U;
													if (taskObject == null)
													{
														num |= 1381982198U;
														num = 1957632345U * num;
														if (1094846391U >= num)
														{
															goto IL_42;
														}
														object3 = null;
														num ^= 335876713U;
													}
													else
													{
														num = 39398468U - num;
														object3 = taskObject.interactable;
														num ^= 3711228043U;
													}
												}
												bool flag4 = object3 == null;
												num = 2027911264U + num;
												if (!flag4)
												{
													num = 2002262438U / num;
													GameTask gameTask4 = gameTask3;
													num >>= 8;
													bool isSabotage = gameTask4.isSabotage;
													num += 3543493934U;
													if (!isSabotage)
													{
														AutoTasks.currentTask = gameTask3;
														if (num >> 6 != 0U)
														{
															num ^= 4048049486U;
															goto IL_38B;
														}
														goto IL_62;
													}
												}
												num &= 926250420U;
												int num6 = num3;
												num += 776343133U;
												int num7 = (int)(num ^ 1098609536U);
												num &= 197805779U;
												num3 = num6 + num7;
												num += 4273323403U;
												continue;
											}
										}
										IL_38B:
										if (num > 1845311104U)
										{
											break;
										}
										bool flag5 = AutoTasks.currentTask != null;
										num ^= 357586587U;
										if (!flag5)
										{
											return;
										}
										num = 857231065U * num;
										ConsoleColor consoleColor = (ConsoleColor)(num ^ 98274505U);
										num |= 953890509U;
										string text = "已获取到可用任务，即将开始做任务:{0}";
										int num8 = (int)(num ^ 1037811406U);
										num -= 1618503218U;
										object[] array = new object[num8];
										num <<= 9;
										num = 1265128188U << (int)num;
										array[(int)(num - 1265128188U)] = AutoTasks.currentTask.taskDisplayName;
										num = 1561402680U >> (int)num;
										MelonLogger.Msg(consoleColor, text, array);
										num >>= 3;
										if (1296763890U >> (int)num != 0U)
										{
											goto Block_23;
										}
										goto IL_98;
									}
									return;
								}
								return;
							}
							case 1:
								goto IL_46E;
							case 2:
								goto IL_488;
							case 3:
								goto IL_48F;
							case 4:
								num = 772342518U + num;
								if (228543483U != num)
								{
									goto Block_28;
								}
								continue;
							case 5:
								goto IL_4D3;
							}
							return;
						}
						return;
					}
					IL_46E:
					num = 722359666U + num;
					this.PrepareToDoTask();
					if (718407711U < num)
					{
						return;
					}
					continue;
					Block_5:
					num ^= 480653041U;
				}
				List<GameTask> list = AutoTasks.tasksToFinish;
				num /= 1111567409U;
				list.Clear();
				if (2029140808U > num)
				{
					break;
				}
				IL_62:
				@object = null;
				goto IL_7D;
			}
			return;
			Block_23:
			num += 663776818U;
			this.beforePrecursorTrueTime = Time.time + AutoTasks.beforePrecursorTrueInterval.Value;
			num = 495535726U % num;
			if ((num ^ 2038570837U) != 0U)
			{
				this.state = (int)num + (AutoTasks.TasksState)(-495535725);
				return;
			}
			goto IL_18;
			IL_488:
			this.DoingTask();
			return;
			IL_48F:
			if (244204964U == num)
			{
				goto IL_18;
			}
			this.FinishTask();
			if ((num ^ 1836678364U) != 0U)
			{
				return;
			}
			goto IL_18;
			Block_28:
			this.EndTask();
			if (num + 626461723U != 0U)
			{
				return;
			}
			goto IL_18;
			IL_4D3:
			num = 191710194U / num;
			if (1325101388U < num)
			{
				goto IL_18;
			}
			num = 2141979749U - num;
			this.Cooldown();
			num += 3078712082U;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00059D40 File Offset: 0x00057340
		private void PrepareToDoTask()
		{
			uint num = 785607019U;
			for (;;)
			{
				num &= 1215510565U;
				Vector3 position2;
				if (this.tpToTaskPosition)
				{
					num ^= 1988121087U;
					GameTask gameTask = AutoTasks.currentTask;
					num = 884107092U >> (int)num;
					GameObject gameObject = gameTask.taskObject.interactable.gameObject;
					num *= 346295769U;
					Vector3 position = gameObject.transform.position;
					num += 1897464635U;
					position2 = position;
					num = 1280714709U * num;
					if (748159467U >> (int)num != 0U)
					{
						goto IL_78;
					}
				}
				else
				{
					num *= 786194537U;
					if (35810775U > num)
					{
						continue;
					}
					LocalPlayer.Instance.disableMovement = ((num ^ 58971529U) != 0U);
					num ^= 58972350U;
				}
				IL_F7:
				float time = Time.time;
				num %= 1218185763U;
				num *= 1921590744U;
				if (time > this.beforePrecursorTrueTime)
				{
					num /= 1724872178U;
					TaskObjectHandler taskObject = AutoTasks.currentTask.taskObject;
					num = 1033766153U * num;
					num = 559683018U / num;
					if (taskObject == null)
					{
						num = (1807888390U | num);
					}
					else
					{
						num = 566052673U >> (int)num;
						Interactable interactable = taskObject.interactable;
						if (interactable == null)
						{
							if (1190684990U == num)
							{
								continue;
							}
							num ^= 1249867591U;
						}
						else
						{
							num = (1885942277U ^ num);
							UnityEvent onClick = interactable.onClick;
							if (onClick == null)
							{
								if (1570712459U / num == 0U)
								{
									continue;
								}
								num += 435010242U;
							}
							else
							{
								num = 1498962878U / num;
								onClick.Invoke();
								num ^= 1807888391U;
							}
						}
					}
					num ^= 1657166268U;
					num = (1974411096U | num);
					AutoTasks.TasksState tasksState = (int)num + (AutoTasks.TasksState)(-2108653560);
					num <<= 1;
					this.state = tasksState;
					num -= 1887009593U;
					num = (2067547604U | num);
					float time2 = Time.time;
					num = 1286030076U >> (int)num;
					this.taskTime = time2 + AutoTasks.taskInterval.Value;
					num <<= 2;
					ConsoleColor consoleColor = (ConsoleColor)(num - 4294967286U);
					num = (524624032U | num);
					string text = "已经通知服务器正在做任务，{0}秒后任务将完成";
					int num2 = (int)(num ^ 524624033U);
					num >>= 8;
					object[] array = new object[num2];
					int num3 = (int)(num + 4292917984U);
					MelonPreferences_Entry<float> melonPreferences_Entry = AutoTasks.taskInterval;
					num = 1884904534U % num;
					array[num3] = melonPreferences_Entry.Value;
					MelonLogger.Msg(consoleColor, text, array);
					num += 2454381298U;
				}
				if (662592809 << (int)num != 0)
				{
					break;
				}
				goto IL_78;
				IL_C6:
				goto IL_F7;
				IL_78:
				Component instance = LocalPlayer.Instance;
				num = (494355010U ^ num);
				GameObject gameObject2 = instance.gameObject;
				num = (1972312640U | num);
				Transform transform = gameObject2.transform;
				num = (161698016U & num);
				transform.position = position2;
				num = 725353055U + num;
				LocalPlayer instance2 = LocalPlayer.Instance;
				bool disableMovement = num + 3407916386U != 0U;
				num >>= 18;
				instance2.disableMovement = disableMovement;
				goto IL_C6;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00059FD8 File Offset: 0x000575D8
		private void DoingTask()
		{
			float time = Time.time;
			uint num = 1552680979U;
			if (time <= this.taskTime)
			{
				goto IL_50;
			}
			if ((1349394153U & num) == 0U)
			{
				goto IL_2F;
			}
			IL_22:
			this.state = (AutoTasks.TasksState)(num ^ 1552680976U);
			IL_2F:
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 1552680985U);
			num |= 187588331U;
			MelonLogger.Msg(consoleColor, "任务过程已模拟完毕，即将完成任务");
			num += 4242385176U;
			IL_50:
			if (num > 1152324108U)
			{
				return;
			}
			goto IL_22;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0005A040 File Offset: 0x00057640
		private void FinishTask()
		{
			for (;;)
			{
				GameManager gameManager = MainManager.Instance.gameManager;
				uint num = 745166927U;
				byte gameState = gameManager.gameState;
				num ^= 574650290U;
				if ((uint)gameState == (num ^ 237645816U))
				{
					List<GameTask> list = AutoTasks.tasksToFinish;
					num ^= 499022859U;
					GameTask gameTask = AutoTasks.currentTask;
					num %= 1871269801U;
					list.Add(gameTask);
					num /= 602831116U;
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 10U);
					string text = "检测到当前正在投票，任务回滚中";
					num = (1737970318U | num);
					MelonLogger.Msg(consoleColor, text);
				}
				else
				{
					num = 1526409525U + num;
					GameTask gameTask2 = AutoTasks.currentTask;
					num = 1148455874U % num;
					gameTask2.taskPanel.CompleteTask();
					num |= 990858901U;
					float time = Time.time;
					num &= 569521718U;
					float num2 = 0.5f;
					num &= 1937788213U;
					float num3 = time + num2;
					num <<= 15;
					this.precursorAfterCompletingTaskWaitingTime = num3;
					ConsoleColor consoleColor2 = (int)num + (ConsoleColor)(-34209782);
					num = 1704683922U % num;
					MelonLogger.Msg(consoleColor2, "任务已完成，即将通知服务器");
					if (num * 807546188U == 0U)
					{
						continue;
					}
					AutoTasks.TasksState tasksState = (AutoTasks.TasksState)(num ^ 28404118U);
					num %= 1608857570U;
					this.state = tasksState;
					if (num < 220934871U)
					{
						return;
					}
					goto IL_89;
				}
				IL_6A:
				PluginEventsManager.Precursor((num ^ 1737970318U) != 0U);
				num -= 973626008U;
				if (num >= 904418768U)
				{
					continue;
				}
				IL_89:
				AutoTasks.TasksState tasksState2 = (AutoTasks.TasksState)(num ^ 764344310U);
				num %= 1149594113U;
				this.state = tasksState2;
				if (287442399U <= num)
				{
					break;
				}
				goto IL_6A;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0005A18C File Offset: 0x0005778C
		private void EndTask()
		{
			uint num;
			do
			{
				float time = Time.time;
				num = 1222789532U;
				num -= 1841245110U;
				float num2 = this.precursorAfterCompletingTaskWaitingTime;
				num ^= 165480231U;
				if (time <= num2)
				{
					goto IL_115;
				}
				num %= 1477145982U;
			}
			while ((num ^ 1863668433U) == 0U);
			IL_3A:
			TaskPanelHandler taskPanel = AutoTasks.currentTask.taskPanel;
			bool canClosePanel = num + 3709390908U != 0U;
			num = (2132624723U ^ num);
			taskPanel.canClosePanel = canClosePanel;
			TaskPanelHandler taskPanel2 = AutoTasks.currentTask.taskPanel;
			num = 1848645126U - num;
			taskPanel2.ClosePanel();
			num &= 1243939586U;
			float time2 = Time.time;
			MelonPreferences_Entry<float> melonPreferences_Entry = AutoTasks.cooldownInterval;
			num = (1705853665U | num);
			float num3 = time2 + melonPreferences_Entry.Value;
			num = (1710574797U ^ num);
			this.cooldownWaitingTime = num3;
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 5771046U);
			string text = "任务已完成，即将进入冷却期等待{0}秒...";
			num = (1788020268U ^ num);
			object[] array = new object[num ^ 1791691009U];
			int num4 = (int)(num ^ 1791691008U);
			num = (1618363844U | num);
			object obj = AutoTasks.cooldownInterval;
			num |= 865087731U;
			array[num4] = obj;
			num -= 1942639988U;
			MelonLogger.Msg(consoleColor, text, array);
			num &= 922515010U;
			num = (798052508U | num);
			AutoTasks.TasksState tasksState = (AutoTasks.TasksState)(num - 800419993U);
			num -= 2097687171U;
			this.state = tasksState;
			num ^= 1616075994U;
			IL_115:
			if (num > 1180580685U)
			{
				return;
			}
			goto IL_3A;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0005A2BC File Offset: 0x000578BC
		private void Cooldown()
		{
			uint num = 317134204U;
			if (num % 1549559204U != 0U)
			{
				float time = Time.time;
				float num2 = this.cooldownWaitingTime;
				num = (1558123424U | num);
				if (time <= num2)
				{
					return;
				}
			}
			ConsoleColor consoleColor = (ConsoleColor)(num - 1593776114U);
			string text = "冷却期已完成，即将进入Idle状态";
			num = 1493790899U / num;
			MelonLogger.Msg(consoleColor, text);
			num |= 1496796834U;
			num = 2100319493U % num;
			AutoTasks.TasksState tasksState = (AutoTasks.TasksState)(num ^ 603522659U);
			num >>= 22;
			this.state = tasksState;
			num += 1593775981U;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0005A33C File Offset: 0x0005793C
		// Note: this type is marked as 'beforefieldinit'.
		static AutoTasks()
		{
			uint num = 364457096U;
			string text = "GGDH";
			string text2 = "Enable_AutoTasks";
			num = 1390369475U % num;
			bool flag = num + 3997969109U != 0U;
			string text3 = null;
			num = 282819445U >> (int)num;
			string text4 = null;
			bool flag2 = (num ^ 138095U) != 0U;
			num = 1034896667U << (int)num;
			bool flag3 = (num ^ 2727182336U) != 0U;
			ValueValidator valueValidator = null;
			num = (227155083U & num);
			AutoTasks.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num /= 1572019957U;
			if (853899781U > num)
			{
				for (;;)
				{
					string text5 = "GGDH";
					string text6 = "AutoTasks_beforePrecursorTrueInterval";
					float num2 = 2f;
					num |= 898507644U;
					string text7 = null;
					num &= 248399755U;
					string text8 = null;
					num = (185549336U ^ num);
					bool flag4 = (num ^ 260129040U) != 0U;
					num = 434526951U % num;
					bool flag5 = num - 174397911U != 0U;
					num -= 365570323U;
					AutoTasks.beforePrecursorTrueInterval = MelonPreferences.CreateEntry<float>(text5, text6, num2, text7, text8, flag4, flag5, null);
					num = 179730651U % num;
					for (;;)
					{
						string text9 = "GGDH";
						num = (43062642U | num);
						string text10 = "AutoTasks_taskInterval";
						float num3 = 10f;
						string text11 = null;
						num &= 1069688324U;
						string text12 = null;
						bool flag6 = num + 4118666240U != 0U;
						num = 1969105823U << (int)num;
						bool flag7 = (num ^ 1969105823U) != 0U;
						num = 1657014214U >> (int)num;
						AutoTasks.taskInterval = MelonPreferences.CreateEntry<float>(text9, text10, num3, text11, text12, flag6, flag7, null);
						if (1273385784U == num)
						{
							break;
						}
						string text13 = "GGDH";
						string text14 = "AutoTasks_cooldownInterval";
						float num4 = 10f;
						string text15 = null;
						string text16 = null;
						bool flag8 = num - 0U != 0U;
						num = 1182739361U * num;
						MelonPreferences_Entry<float> melonPreferences_Entry = MelonPreferences.CreateEntry<float>(text13, text14, num4, text15, text16, flag8, num - 0U != 0U, null);
						num /= 1358503107U;
						AutoTasks.cooldownInterval = melonPreferences_Entry;
						GameTask gameTask = null;
						num ^= 1740341115U;
						AutoTasks.currentTask = gameTask;
						num /= 1783852161U;
						AutoTasks.tasksToFinish = new List<GameTask>();
						if (num < 664236947U)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x04000172 RID: 370
		public static AutoTasks Instance;

		// Token: 0x04000173 RID: 371
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000174 RID: 372
		public static MelonPreferences_Entry<float> beforePrecursorTrueInterval;

		// Token: 0x04000175 RID: 373
		public static MelonPreferences_Entry<float> taskInterval;

		// Token: 0x04000176 RID: 374
		public static MelonPreferences_Entry<float> cooldownInterval;

		// Token: 0x04000177 RID: 375
		public const float precursorAfterCompletingTaskInterval = 0.5f;

		// Token: 0x04000178 RID: 376
		public const float doTaskAfterGameStartedInterval = 6f;

		// Token: 0x04000179 RID: 377
		private AutoTasks.TasksState state;

		// Token: 0x0400017A RID: 378
		private static GameTask currentTask;

		// Token: 0x0400017B RID: 379
		private float beforePrecursorTrueTime;

		// Token: 0x0400017C RID: 380
		private float taskTime;

		// Token: 0x0400017D RID: 381
		private float cooldownWaitingTime;

		// Token: 0x0400017E RID: 382
		private float precursorAfterCompletingTaskWaitingTime;

		// Token: 0x0400017F RID: 383
		private float doTaskAfterGameStartedIntervalWaitingTime;

		// Token: 0x04000180 RID: 384
		private bool tpToTaskPosition;

		// Token: 0x04000181 RID: 385
		private static List<GameTask> tasksToFinish;

		// Token: 0x020000A1 RID: 161
		public enum TasksState
		{
			// Token: 0x040001E6 RID: 486
			Idle,
			// Token: 0x040001E7 RID: 487
			Prepare,
			// Token: 0x040001E8 RID: 488
			Doing,
			// Token: 0x040001E9 RID: 489
			Finish,
			// Token: 0x040001EA RID: 490
			Ending,
			// Token: 0x040001EB RID: 491
			Cooldowning
		}

		// Token: 0x020000A2 RID: 162
		private class TasksHandler_AssignTask
		{
			// Token: 0x0600022D RID: 557 RVA: 0x00065CF4 File Offset: 0x000632F4
			private static void Postfix(GameTask __0, bool __1)
			{
				uint num;
				do
				{
					List<GameTask> tasksToFinish = AutoTasks.tasksToFinish;
					num = 1285491857U;
					tasksToFinish.Add(__0);
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 1285491867U);
					string text = "已添加任务:{0} 到待完成任务列表，当前待做任务数量:{1}";
					int num2 = (int)(num ^ 1285491859U);
					num = 435362073U >> (int)num;
					object[] array = new object[num2];
					num >>= 7;
					int num3 = (int)(num - 25U);
					num = 822286369U + num;
					object taskDisplayName = __0.taskDisplayName;
					num &= 330646702U;
					array[num3] = taskDisplayName;
					num = 711272091U + num;
					int num4 = (int)(num + 3298416956U);
					List<GameTask> tasksToFinish2 = AutoTasks.tasksToFinish;
					num <<= 24;
					int count = tasksToFinish2.Count;
					num |= 346762262U;
					object obj = count;
					num |= 305092068U;
					array[num4] = obj;
					MelonLogger.Msg(consoleColor, text, array);
				}
				while (num < 1935738218U);
			}
		}

		// Token: 0x020000A3 RID: 163
		[HarmonyPatch(typeof(InGameEvents), "Start_Game")]
		private class InGameEvents_StartGame
		{
			// Token: 0x0600022F RID: 559 RVA: 0x00065DBC File Offset: 0x000633BC
			private static void Postfix()
			{
				uint num = 856365893U;
				if (num % 1330537647U != 0U)
				{
					AutoTasks instance = AutoTasks.Instance;
					float time = Time.time;
					num = 1110976062U / num;
					instance.doTaskAfterGameStartedIntervalWaitingTime = time + 6f;
				}
			}

			// Token: 0x06000230 RID: 560 RVA: 0x00065DF8 File Offset: 0x000633F8
			public InGameEvents_StartGame()
			{
				uint num = 949692239U;
				if (1505304537 << (int)num != 0)
				{
					num += 1247493900U;
					base..ctor();
				}
			}
		}
	}
}
