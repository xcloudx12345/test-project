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
	// Token: 0x0200003F RID: 63
	public class RemoteEat
	{
		// Token: 0x060000FA RID: 250 RVA: 0x000570A8 File Offset: 0x000546A8
		public static void EatRandomBody()
		{
			for (;;)
			{
				IL_00:
				bool flag = false;
				uint num = 1909158935U;
				Dictionary<string, PlayerController>.Enumerator enumerator;
				if (1358252621U * num != 0U)
				{
					Dictionary<string, PlayerController> playersList = PlayerController.playersList;
					num += 819598449U;
					enumerator = playersList.GetEnumerator();
				}
				for (;;)
				{
					while (enumerator.MoveNext())
					{
						num = 394680850U;
						Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
						num <<= 9;
						KeyValuePair<string, PlayerController> keyValuePair = enumerator2.Current;
						num >>= 23;
						num = (493628585U | num);
						string key = keyValuePair.key;
						PlayerController value = keyValuePair.value;
						bool flag2 = key != null;
						num = 704789667U - num;
						num ^= 2922612578U;
						if (flag2)
						{
							bool flag3 = value == null;
							num ^= 0U;
							if (!flag3)
							{
								PlayerController playerController = value;
								num = 783758561U * num;
								bool timeOfDeath = playerController.timeOfDeath != 0;
								num = 1293962845U >> (int)num;
								num ^= 2733156550U;
								if (timeOfDeath)
								{
									if (1948873526U == num)
									{
										goto IL_00;
									}
									GameManager gameManager = MainManager.Instance.gameManager;
									num = (862586686U ^ num);
									PlayerController playerController2 = value;
									num /= 255395483U;
									BodyHandler bodyHandler = gameManager.BodyFromUserId(playerController2.userId);
									num %= 1622216424U;
									BodyHandler bodyHandler2 = bodyHandler;
									num = 102704304U * num;
									Object @object = bodyHandler2;
									num %= 841100890U;
									Object object2 = null;
									num *= 768351030U;
									bool flag4 = @object == object2;
									num += 3578009444U;
									if (!flag4)
									{
										num = 704327373U - num;
										string str = "已找到有效尸体，正在远程消化尸体:";
										num /= 2132170655U;
										string nickname = value.nickname;
										num = (548753739U & num);
										MelonLogger.Msg(str + nickname);
										string bodyUserId = bodyHandler2.bodyUserId;
										num %= 1896249753U;
										PluginEventsManager.Eat(bodyUserId);
										bool flag5 = num - 0U != 0U;
										num = 291068615U * num;
										flag = flag5;
										num += 2437688769U;
									}
								}
							}
						}
					}
					num = (1286481070U | num);
					if (num == 992292862U)
					{
						break;
					}
					bool flag6 = flag;
					num = (1101881524U | num);
					if (!flag6)
					{
						if (1631258843U > num)
						{
							break;
						}
						string text = "未找到有效尸体";
						num ^= 2085376590U;
						MelonLogger.Warning(text);
						num += 1540107726U;
					}
					if ((1733130556U ^ num) != 0U)
					{
						return;
					}
				}
			}
		}
	}
}
