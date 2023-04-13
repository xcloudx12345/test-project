using System;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;
using Managers;
using Managers.GameManagers;
using MelonLoader;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000035 RID: 53
	public class DragAllBodies
	{
		// Token: 0x060000CE RID: 206 RVA: 0x00054034 File Offset: 0x00051634
		public static void PickupAllBodies()
		{
			for (;;)
			{
				IL_00:
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				uint num = 462952038U;
				Dictionary<string, PlayerController>.Enumerator enumerator = playersList.GetEnumerator();
				num ^= 492260773U;
				Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
				if (num <= 843777398U)
				{
					goto IL_18F;
				}
				PlayerController playerController;
				do
				{
					IL_29:
					Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator2;
					num = 988549660U;
					KeyValuePair<string, PlayerController> keyValuePair = enumerator3.Current;
					string key = keyValuePair.Key;
					num = 1106604927U % num;
					string text = key;
					PlayerController value = keyValuePair.Value;
					num = (759331926U | num);
					playerController = value;
					num /= 1695689647U;
					if (num - 939859827U == 0U)
					{
						goto IL_00;
					}
					bool flag = text != null;
					num ^= 114252739U;
					if (!flag)
					{
						goto IL_18F;
					}
					num /= 172847938U;
					string a = text;
					num = (981759882U ^ num);
					bool flag2 = a == "";
					num ^= 1011559497U;
					if (flag2)
					{
						goto IL_18F;
					}
					if (num == 716186395U)
					{
						goto IL_00;
					}
					Object @object = playerController;
					num = 1161696224U >> (int)num;
					bool flag3 = @object == null;
					num ^= 241736127U;
					if (flag3)
					{
						goto IL_18F;
					}
					num = (1692736607U | num);
				}
				while (num % 517957627U == 0U);
				bool isLocal = playerController.isLocal;
				num += 2682256356U;
				if (!isLocal)
				{
					num += 1582848297U;
					if (1430348328U + num == 0U)
					{
						continue;
					}
					bool timeOfDeath = playerController.timeOfDeath != 0;
					num += 2712118999U;
					if (timeOfDeath)
					{
						if (num - 1228213688U == 0U)
						{
							continue;
						}
						GameManager gameManager = MainManager.Instance.gameManager;
						num = 1541810606U % num;
						string userId = playerController.userId;
						num ^= 292308575U;
						BodyHandler bodyHandler = gameManager.BodyFromUserId(userId);
						num = 359162393U - num;
						string text2 = "已捡起尸体：" + bodyHandler.bodyUserId;
						num &= 1898598404U;
						MelonLogger.Msg(text2);
						num *= 1100757213U;
						BodyHandler body = bodyHandler;
						num /= 1579627964U;
						PluginEventsManager.Drag_Body(body);
						num += 114252738U;
					}
				}
				IL_18F:
				num += 629174900U;
				if (num * 1299079472U != 0U)
				{
					Dictionary<string, PlayerController>.Enumerator enumerator4 = enumerator2;
					num = (344722347U ^ num);
					if (enumerator4.MoveNext())
					{
						goto IL_29;
					}
					if (num <= 1516335914U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00054204 File Offset: 0x00051804
		public DragAllBodies()
		{
			uint num;
			do
			{
				num = 731597895U;
				base..ctor();
			}
			while (num == 1096499266U);
		}
	}
}
