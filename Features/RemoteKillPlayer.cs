using System;
using Cinemachine;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000040 RID: 64
	[RegisterTypeInIl2Cpp]
	public class RemoteKillPlayer : MonoBehaviour
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00057298 File Offset: 0x00054898
		public RemoteKillPlayer(IntPtr ptr)
		{
			uint num = 209745368U;
			do
			{
				num *= 81860623U;
				Vector3 zero = Vector3.zero;
				num |= 829950419U;
				this.localPlayerPositionBeforeTeleport = zero;
				num /= 1413619826U;
			}
			while (804589644U < num);
			do
			{
				num = 1905860419U % num;
				num += 898922529U;
				base..ctor(ptr);
			}
			while (num >= 1782269767U);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000572FC File Offset: 0x000548FC
		public RemoteKillPlayer()
		{
			uint num;
			do
			{
				Vector3 zero = Vector3.zero;
				num = 1821778288U;
				this.localPlayerPositionBeforeTeleport = zero;
			}
			while (540021271U % num == 0U);
			do
			{
				num = 120458066U << (int)num;
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<RemoteKillPlayer>();
				num = 1268529832U + num;
				base..ctor(intPtr);
				num >>= 30;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (num > 633609706U);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00057360 File Offset: 0x00054960
		public static void Init()
		{
			GameObject gameObject;
			uint num;
			do
			{
				gameObject = GameObject.Find("ML_Manager");
				Object @object = gameObject;
				num = 559827040U;
				Object object2 = null;
				num = 875311761U * num;
				bool flag = @object == object2;
				num = 787241407U >> (int)num;
				if (flag)
				{
					num &= 2122777261U;
					string text = "ML_Manager";
					num &= 2082409082U;
					gameObject = new GameObject(text);
					num &= 1671845868U;
					Object object3 = gameObject;
					num = (1464467855U & num);
					Object.DontDestroyOnLoad(object3);
					num ^= 787241399U;
				}
				num = 2092971200U << (int)num;
				GameObject gameObject2 = gameObject;
				num = 1064904467U - num;
				Object component = gameObject2.GetComponent<RemoteKillPlayer>();
				num = 1026119191U % num;
				if (!(component == null))
				{
					return;
				}
				num = 1960074913U << (int)num;
			}
			while (num % 476069854U == 0U);
			GameObject gameObject3 = gameObject;
			num = 1661555390U << (int)num;
			RemoteKillPlayer instance = gameObject3.AddComponent<RemoteKillPlayer>();
			num = 378668163U - num;
			RemoteKillPlayer.Instance = instance;
			num += 2309006418U;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0005744C File Offset: 0x00054A4C
		public static bool TeleportAndKill(string userId, string _killDelay = null)
		{
			uint num;
			for (;;)
			{
				RemoteKillPlayer instance = RemoteKillPlayer.Instance;
				num = 850091816U;
				bool flag = instance.hasStartedToKill;
				num = 244200789U - num;
				if (flag)
				{
					num |= 1033718984U;
					if (num * 1339443509U != 0U)
					{
						break;
					}
				}
				else
				{
					num = 1612526937U - num;
					if (222648263U / num == 0U)
					{
						if (_killDelay != null)
						{
							goto IL_7F;
						}
						if (697829559U != num)
						{
							goto Block_3;
						}
					}
				}
			}
			IL_31:
			string text = "当前已经有击杀任务正在执行!";
			num %= 1763460001U;
			MelonLogger.Warning(text);
			num ^= 1598518005U;
			return (num ^ 1921000798U) != 0U;
			Block_3:
			return RemoteKillPlayer.TeleportAndKill(userId);
			IL_7F:
			if (643831036U / num == 0U)
			{
				num = (141170119U ^ num);
				RemoteKillPlayer.killDelay = float.Parse(_killDelay);
				num |= 1231321488U;
				return RemoteKillPlayer.TeleportAndKill(userId);
			}
			goto IL_31;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00057508 File Offset: 0x00054B08
		private static bool TeleportAndKill(string userId)
		{
			uint num = 1723095768U;
			if (1909487900U >> (int)num == 0U)
			{
				goto IL_44;
			}
			do
			{
				IL_18:
				RemoteKillPlayer instance = RemoteKillPlayer.Instance;
				num *= 575290528U;
				instance.hasStartedToKill = (num - 1752393471U != 0U);
				num = (615127938U ^ num);
			}
			while (num >= 1378974414U);
			for (;;)
			{
				IL_44:
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = (645755274U ^ num);
				if ((2050643676U ^ num) == 0U)
				{
					goto IL_AC;
				}
				bool flag = playersList.ContainsKey(userId);
				num <<= 5;
				if (!flag)
				{
					goto IL_AC;
				}
				num <<= 30;
				Dictionary<string, PlayerController> dictionary = playersList;
				num *= 1700552093U;
				num = (313598254U & num);
				Object @object = dictionary[userId];
				num ^= 1960850466U;
				if (@object == null)
				{
					break;
				}
				num >>= 7;
				if (num >= 1638938053U)
				{
					goto IL_18;
				}
				RemoteKillPlayer instance2 = RemoteKillPlayer.Instance;
				Transform transform = LocalPlayer.Instance.transform;
				num = 449970349U >> (int)num;
				Vector3 position = transform.position;
				num = 1467880510U / num;
				instance2.localPlayerPositionBeforeTeleport = position;
				num = 38099062U << (int)num;
				RemoteKillPlayer instance3 = RemoteKillPlayer.Instance;
				num = 637950255U / num;
				PlayerController playerController = playersList[userId];
				num += 494171511U;
				instance3.killTarget = playerController;
				if (num != 2072513629U)
				{
					goto Block_5;
				}
			}
			num += 3751898334U;
			IL_AC:
			RemoteKillPlayer instance4 = RemoteKillPlayer.Instance;
			num = 656284608U + num;
			bool flag2 = (num ^ 2074066112U) != 0U;
			num = 1741035543U / num;
			instance4.hasStartedToKill = flag2;
			num <<= 17;
			return (num ^ 0U) != 0U;
			Block_5:
			Behaviour component = Camera.main.GetComponent<CinemachineBrain>();
			num = 84476174U - num;
			bool enabled = (num ^ 3885271957U) != 0U;
			num = 634655667U - num;
			component.enabled = enabled;
			return (num ^ 1044351007U) != 0U;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0005769C File Offset: 0x00054C9C
		private void Update()
		{
			uint num = 294982950U;
			for (;;)
			{
				bool flag = this.hasStartedToKill;
				num ^= 1339434780U;
				if (!flag)
				{
					break;
				}
				num <<= 22;
				if (num == 967661708U)
				{
					break;
				}
				Object @object = this.killTarget;
				num = (1698380564U | num);
				if (!(@object != null))
				{
					goto IL_2EF;
				}
				num = 689308595U + num;
				if (148075489U > num)
				{
					break;
				}
				for (;;)
				{
					num = 964778896U << (int)num;
					float num2 = this.killTimer;
					num &= 1502505690U;
					float num3 = num2 + Time.deltaTime;
					num |= 1524049686U;
					this.killTimer = num3;
					num >>= 30;
					if (num > 1260198125U)
					{
						break;
					}
					num |= 770784931U;
					float num4 = this.killTimer;
					float num5 = RemoteKillPlayer.killDelay;
					num /= 866393863U;
					if (num4 >= num5)
					{
						goto IL_119;
					}
					num = (484007847U & num);
					if (num / 200287304U != 0U)
					{
						break;
					}
					Transform transform = LocalPlayer.Instance.transform;
					num <<= 24;
					Transform transform2 = this.killTarget.transform;
					num %= 2140548246U;
					Vector3 position = transform2.position;
					num = 1351371104U << (int)num;
					transform.position = position;
					if (num < 1407333198U)
					{
						return;
					}
				}
			}
			return;
			IL_119:
			string str = "正在击杀目标: ";
			num = 1054870813U << (int)num;
			string nickname = this.killTarget.nickname;
			num += 854160732U;
			MelonLogger.Msg(str + nickname);
			try
			{
				if (num * 1933539133U != 0U)
				{
					num = 1540651202U * num;
					PlayerController playerController = this.killTarget;
					num &= 1377910385U;
					if (playerController.timeOfDeath != 0)
					{
						goto IL_234;
					}
					num |= 1811120078U;
					bool isInPelican = this.killTarget.isInPelican;
					num ^= 1777494478U;
					if (isInPelican)
					{
						goto IL_234;
					}
				}
				do
				{
					PlayerController player = LocalPlayer.Instance.Player;
					num = 1822836918U / num;
					KDDFBBBFINF playerRole = player.playerRole;
					num += 1347429750U;
					IPLJDOHJOLM ijoicoidmhc = playerRole.IJOICOIDMHC;
					uint num6 = num - 1347429696U;
					num = (455737696U & num);
					if (ijoicoidmhc != num6)
					{
						goto IL_205;
					}
					num <<= 29;
					string userId = this.killTarget.userId;
					num = 2146180618U - num;
					PluginEventsManager.PelicanEat(userId);
				}
				while (1123444138U == num);
				num += 2450847782U;
				goto IL_234;
				IL_205:
				num = 2086349955U - num;
				string userId2 = this.killTarget.userId;
				num = 810422849U << (int)num;
				PluginEventsManager.Kill(userId2, null);
				num ^= 2423358520U;
				IL_234:;
			}
			catch (Exception ex)
			{
				string text = "击杀目标" + this.killTarget.nickname + "失败!!";
				num = 547446535U;
				MelonLogger.Warning(text);
				string text2 = ex.ToString();
				num ^= 2017072672U;
				MelonLogger.Warning(text2);
			}
			IL_275:
			num = 525561250U;
			if (num / 1431374389U == 0U)
			{
				string str2 = "已击杀目标: ";
				string nickname2 = this.killTarget.nickname;
				num += 1870350883U;
				MelonLogger.Msg(str2 + nickname2);
				num = 491937804U % num;
				if (1801457434U < num)
				{
					return;
				}
			}
			IL_2BC:
			num -= 2002344064U;
			float num7 = 0f;
			num |= 1872699851U;
			this.killTimer = num7;
			IL_2D7:
			num |= 400627880U;
			PlayerController playerController2 = null;
			num = 244977019U % num;
			this.killTarget = playerController2;
			return;
			IL_2EF:
			num *= 879320898U;
			num = 466501289U + num;
			float num8 = this.teleportTimer;
			float num9 = RemoteKillPlayer.teleportDuration;
			num = 1668706335U * num;
			if (num8 < num9)
			{
				if (1785224277U > num)
				{
					goto IL_275;
				}
				Transform transform3 = LocalPlayer.Instance.transform;
				num *= 304625690U;
				Vector3 position2 = this.localPlayerPositionBeforeTeleport;
				num = 91967604U - num;
				transform3.position = position2;
				if (1651843263U != num)
				{
					Camera.main.GetComponent<CinemachineBrain>().enabled = (num - 3488028781U != 0U);
					num ^= 120661661U;
					float num10 = this.teleportTimer;
					num += 879766999U;
					this.teleportTimer = num10 + Time.deltaTime;
					return;
				}
				goto IL_2BC;
			}
			else
			{
				num = (47803192U ^ num);
				if (1439981802 << (int)num == 0)
				{
					goto IL_275;
				}
				bool flag2 = num + 822923401U != 0U;
				num = (2147297883U | num);
				this.hasStartedToKill = flag2;
				if (num < 65168000U)
				{
					goto IL_2BC;
				}
				float num11 = 0f;
				num = (2023752888U | num);
				this.teleportTimer = num11;
				num /= 1460428920U;
				string text3 = "已完成击杀任务!";
				num /= 905445881U;
				MelonLogger.Msg(text3);
				if (1874333914U != num)
				{
					return;
				}
				goto IL_2D7;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00057AC4 File Offset: 0x000550C4
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteKillPlayer()
		{
			uint num = 50678227U;
			RemoteKillPlayer.killDelay = 0.2f;
			num = 951081166U * num;
			if (num > 594749779U)
			{
				RemoteKillPlayer.teleportDuration = 0.5f;
			}
		}

		// Token: 0x04000159 RID: 345
		public static RemoteKillPlayer Instance = null;

		// Token: 0x0400015A RID: 346
		private PlayerController killTarget;

		// Token: 0x0400015B RID: 347
		private Vector3 localPlayerPositionBeforeTeleport;

		// Token: 0x0400015C RID: 348
		private bool hasStartedToKill;

		// Token: 0x0400015D RID: 349
		private float killTimer;

		// Token: 0x0400015E RID: 350
		private float teleportTimer;

		// Token: 0x0400015F RID: 351
		private static float killDelay;

		// Token: 0x04000160 RID: 352
		private static float teleportDuration;
	}
}
