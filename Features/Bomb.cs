using System;
using System.Collections.Generic;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000030 RID: 48
	public class Bomb
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x000532D4 File Offset: 0x000508D4
		public static void ThrowAwayBomb()
		{
			List<string> list;
			uint num;
			do
			{
				IL_00:
				list = new List<string>();
				for (;;)
				{
					Dictionary<string, PlayerController>.Enumerator enumerator = PlayerController.playersList.GetEnumerator();
					num = 1907583694U;
					Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
					if ((num & 971380604U) == 0U)
					{
						goto IL_00;
					}
					for (;;)
					{
						num = 1461858446U - num;
						if ((num ^ 168962897U) == 0U)
						{
							break;
						}
						Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator2;
						num -= 1139700216U;
						bool flag = enumerator3.MoveNext();
						num %= 1578508549U;
						if (!flag)
						{
							goto Block_6;
						}
						Dictionary<string, PlayerController>.Enumerator enumerator4 = enumerator2;
						num = 1448570175U;
						KeyValuePair<string, PlayerController> keyValuePair = enumerator4.Current;
						num = 636646529U << (int)num;
						string key = keyValuePair.Key;
						num *= 589854903U;
						PlayerController value = keyValuePair.Value;
						num |= 361437570U;
						PlayerController playerController = value;
						bool flag2 = playerController != null;
						num += 3693629772U;
						if (flag2)
						{
							num = 1871662379U >> (int)num;
							if (900079566U == num)
							{
								goto IL_00;
							}
							PlayerController playerController2 = playerController;
							num <<= 31;
							bool isLocal = playerController2.isLocal;
							num ^= 4055067342U;
							if (!isLocal)
							{
								PlayerController playerController3 = playerController;
								num -= 370421387U;
								bool timeOfDeath = playerController3.timeOfDeath != 0;
								num *= 2030324560U;
								num ^= 2512723774U;
								if (!timeOfDeath)
								{
									List<string> list2 = list;
									string item = key;
									num %= 1390085461U;
									list2.Add(item);
									num += 1390085461U;
								}
							}
						}
					}
				}
				Block_6:;
			}
			while ((54879993U ^ num) == 0U);
			List<string> list3 = list;
			num -= 1317946992U;
			int count = list3.Count;
			uint num2 = num - 4108053587U;
			num *= 289105237U;
			if (count > num2)
			{
				List<string> list4 = list;
				int num3 = (int)(num ^ 191051407U);
				List<string> list5 = list;
				num = (1465017540U | num);
				int count2 = list5.Count;
				num = 1675197238U % num;
				int index = Random.RandomRangeInt(num3, count2);
				num %= 328347509U;
				string userId = list4[index];
				num %= 2064983612U;
				PluginEventsManager.Throw_Bomb(userId);
				num ^= 251998952U;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00053468 File Offset: 0x00050A68
		public Bomb()
		{
			uint num = 607000806U;
			num -= 2119777720U;
			base..ctor();
		}
	}
}
