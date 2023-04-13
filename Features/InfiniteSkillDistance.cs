using System;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.LobbyHandlers;
using HarmonyLib;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x0200004E RID: 78
	[RegisterTypeInIl2Cpp]
	public class InfiniteSkillDistance : MonoBehaviour
	{
		// Token: 0x06000145 RID: 325 RVA: 0x0005B304 File Offset: 0x00058904
		public InfiniteSkillDistance(IntPtr ptr)
		{
			for (;;)
			{
				uint num = 1543243203U;
				base..ctor(ptr);
				num /= 959786828U;
				if (1545408324U >= num)
				{
					IngameSettings.IngameSettingsEntry ingameSettingsEntry;
					for (;;)
					{
						ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
						if (num < 717045956U)
						{
							do
							{
								ingameSettingsEntry.entry = InfiniteSkillDistance.Enabled;
								string name_cn = "无限距离技能: \n鸽子、侦探、跟踪者、爆炸王、超能力";
								num = (15805229U & num);
								ingameSettingsEntry.name_cn = name_cn;
							}
							while ((num ^ 378881623U) == 0U);
							ingameSettingsEntry.name_eng = "Skill Ignore Distance: \nPigeon, Detective, Stalker, Demolitionist, Esper";
							if (num <= 190930988U)
							{
								break;
							}
						}
					}
					IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
					if (131075173 << (int)num != 0)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0005B3A0 File Offset: 0x000589A0
		public InfiniteSkillDistance()
		{
			uint num = 318536632U;
			base..ctor(ClassInjector.DerivedConstructorPointer<InfiniteSkillDistance>());
			num *= 2075603297U;
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0005B3CC File Offset: 0x000589CC
		public static void Init()
		{
			uint num;
			do
			{
				GameObject gameObject = GameObject.Find("ML_Manager");
				num = 75398277U;
				GameObject gameObject2 = gameObject;
				if (gameObject2 == null)
				{
					GameObject gameObject3 = new GameObject("ML_Manager");
					num |= 84948376U;
					gameObject2 = gameObject3;
					num = (107225229U & num);
					if (1793856679U > num)
					{
						Object @object = gameObject2;
						num >>= 28;
						Object.DontDestroyOnLoad(@object);
						num ^= 75398277U;
					}
				}
				num >>= 14;
				Object component = gameObject2.GetComponent<InfiniteSkillDistance>();
				Object object2 = null;
				num = 2115010060U / num;
				bool flag = component == object2;
				num = 1012557501U * num;
				if (flag)
				{
					num -= 1917534202U;
					if (num == 1832400968U)
					{
						continue;
					}
					InfiniteSkillDistance.Instance = gameObject2.AddComponent<InfiniteSkillDistance>();
					num += 1917534202U;
				}
			}
			while (1502627912 << (int)num == 0);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0005B494 File Offset: 0x00058A94
		// Note: this type is marked as 'beforefieldinit'.
		static InfiniteSkillDistance()
		{
			uint num;
			do
			{
				string text = "GGDH";
				string text2 = "Enable_InfiniteSkillDistance";
				num = 2085448581U;
				bool flag = num - 2085448580U != 0U;
				num = 285025298U / num;
				string text3 = null;
				string text4 = null;
				num = 123690229U + num;
				bool flag2 = num + 4171277067U != 0U;
				bool flag3 = num + 4171277067U != 0U;
				num = 1449546225U - num;
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, null);
				num = 475273174U << (int)num;
				InfiniteSkillDistance.Enabled = enabled;
			}
			while (160259126U - num == 0U);
		}

		// Token: 0x0400018D RID: 397
		public static InfiniteSkillDistance Instance;

		// Token: 0x0400018E RID: 398
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x020000A9 RID: 169
		[HarmonyPatch(typeof(PlayerController), "Update")]
		private class PlayerController_Update
		{
			// Token: 0x0600023B RID: 571 RVA: 0x00066744 File Offset: 0x00063D44
			private static void Postfix(PlayerController __instance)
			{
				uint num = 2074770073U;
				if (num * 323887326U == 0U)
				{
					goto IL_46;
				}
				IL_12:
				if (InfiniteSkillDistance.Enabled.Value)
				{
					goto IL_22;
				}
				return;
				IL_22:
				num |= 72168123U;
				num = 938310230U * num;
				bool isLocal = __instance.isLocal;
				num |= 2079013659U;
				if (!isLocal)
				{
					goto IL_46;
				}
				return;
				IL_46:
				if (num <= 1656913817U)
				{
					return;
				}
				LocalPlayer instance = LocalPlayer.Instance;
				num += 993220498U;
				PlayerController playerController;
				if (instance == null)
				{
					num = (1716327182U & num);
					playerController = null;
				}
				else
				{
					num |= 994843111U;
					playerController = instance.Player;
					num ^= 426690787U;
				}
				num -= 1512717595U;
				PlayerController playerController2 = playerController;
				num >>= 20;
				if (1326914239U / num == 0U)
				{
					return;
				}
				Object @object = playerController2;
				num = 1189960694U - num;
				Object object2 = null;
				num %= 431167331U;
				bool flag = @object == object2;
				num <<= 4;
				if (flag)
				{
					if (1559699824U >= num)
					{
						return;
					}
					return;
				}
				else
				{
					num = 1190927040U >> (int)num;
					if ((num ^ 1579892158U) == 0U)
					{
						goto IL_22;
					}
					LobbySceneHandler instance2 = LobbySceneHandler.Instance;
					num = 622867990U - num;
					num <<= 22;
					bool flag2;
					if (instance2 == null)
					{
						flag2 = ((num ^ 3330277376U) != 0U);
					}
					else
					{
						num ^= 653676685U;
						flag2 = instance2.gameStarted;
						num ^= 653676685U;
					}
					if (!flag2)
					{
						return;
					}
					bool playerRole = playerController2.playerRole != null;
					num = (999621425U & num);
					if (!playerRole)
					{
						if (1309110081U > num)
						{
							return;
						}
						return;
					}
					else
					{
						num ^= 510668347U;
						if (num > 1133514324U)
						{
							return;
						}
						KDDFBBBFINF playerRole2 = playerController2.playerRole;
						num &= 501572553U;
						IPLJDOHJOLM ijoicoidmhc = playerRole2.IJOICOIDMHC;
						num ^= 422380526U;
						IPLJDOHJOLM ipljdohjolm = ijoicoidmhc;
						num >>= 9;
						if (1731814870U / num != 0U)
						{
							IPLJDOHJOLM ipljdohjolm2 = ipljdohjolm;
							uint num2 = num + 4294777221U;
							num /= 2042527256U;
							if (ipljdohjolm2 != num2)
							{
								num /= 1203649960U;
								IPLJDOHJOLM ipljdohjolm3 = ipljdohjolm;
								num >>= 0;
								uint num3 = num - 4294967276U;
								num &= 661989823U;
								num += 0U;
								if (ipljdohjolm3 != num3)
								{
									num += 625413555U;
									IPLJDOHJOLM ipljdohjolm4 = ipljdohjolm;
									uint num4 = num - 625413486U;
									num += 3669553741U;
									if (ipljdohjolm4 != num4)
									{
										num = 275083151U + num;
										IPLJDOHJOLM ipljdohjolm5 = ipljdohjolm;
										uint num5 = num ^ 275083182U;
										num += 4019884145U;
										if (ipljdohjolm5 != num5)
										{
											num = 1676229185U + num;
											IPLJDOHJOLM ipljdohjolm6 = ipljdohjolm;
											uint num6 = num ^ 1676229125U;
											num ^= 1676229185U;
											if (ipljdohjolm6 != num6)
											{
												if (num << 29 == 0U)
												{
													return;
												}
												goto IL_12;
											}
										}
									}
								}
							}
							LocalPlayer instance3 = LocalPlayer.Instance;
							num |= 270426495U;
							num <<= 15;
							Transform transform = __instance.gameObject.transform;
							string text = "Colliders";
							num *= 1738373567U;
							Component component = transform.Find(text);
							num = 1602776114U % num;
							Collider2D component2 = component.gameObject.GetComponent<CircleCollider2D>();
							num %= 1714556579U;
							instance3.TriggerEnter(component2);
							return;
						}
						goto IL_22;
					}
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x000669DC File Offset: 0x00063FDC
			public PlayerController_Update()
			{
				uint num = 1424232269U;
				if (110123263U / num == 0U)
				{
					do
					{
						base..ctor();
					}
					while (196092159U > num);
				}
			}
		}

		// Token: 0x020000AA RID: 170
		public class BodyHandler_Update
		{
			// Token: 0x0600023D RID: 573 RVA: 0x00066A0C File Offset: 0x0006400C
			private static void Postfix(BodyHandler __instance)
			{
				uint num = 279848477U;
				for (;;)
				{
					MelonPreferences_Entry<bool> enabled = InfiniteSkillDistance.Enabled;
					num = (1907581928U | num);
					bool value = enabled.Value;
					num = 1678658010U * num;
					if (!value)
					{
						break;
					}
					for (;;)
					{
						num /= 91191487U;
						bool killedByProfessional = __instance.killedByProfessional;
						num >>= 23;
						if (killedByProfessional)
						{
							goto Block_1;
						}
						if (187578720U + num != 0U)
						{
							GameObject gameObject = __instance.gameObject;
							num ^= 1871528642U;
							Object component = gameObject.GetComponent<PolygonCollider2D>();
							num &= 2044610930U;
							if (component != null)
							{
								num <<= 30;
								if (num <= 216797891U)
								{
									break;
								}
								LocalPlayer instance = LocalPlayer.Instance;
								num = 1305951344U / num;
								num -= 2014448242U;
								GameObject gameObject2 = __instance.gameObject;
								num = 1153970152U + num;
								instance.TriggerEnter(gameObject2.GetComponent<PolygonCollider2D>());
								num ^= 2772067636U;
							}
							if (num >= 1383150792U)
							{
								return;
							}
						}
					}
				}
				return;
				Block_1:
				if (num != 1711688168U)
				{
					return;
				}
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00066AEC File Offset: 0x000640EC
			public BodyHandler_Update()
			{
				uint num = 1293578074U;
				num = 2097969258U - num;
				base..ctor();
			}
		}
	}
}
