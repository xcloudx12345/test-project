using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.TaskHandlers;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000054 RID: 84
	public class TrackAllPlayers
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0005C648 File Offset: 0x00059C48
		public static void ShowAllPlayersArrow()
		{
			uint num = 1521752683U;
			if ((num ^ 876094095U) == 0U)
			{
				goto IL_42;
			}
			IL_12:
			TaskTargetingHandler instance = TaskTargetingHandler.Instance;
			num ^= 377507340U;
			instance.StopAllTargeting();
			Dictionary<string, PlayerController>.Enumerator enumerator;
			if (116670377U <= num)
			{
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = 1293051522U / num;
				enumerator = playersList.GetEnumerator();
			}
			IL_42:
			for (;;)
			{
				bool flag = enumerator.MoveNext();
				num = (1744335688U & num);
				if (!flag)
				{
					break;
				}
				num = 930497541U;
				KeyValuePair<string, PlayerController> keyValuePair2;
				if (1258978583 << (int)num != 0)
				{
					Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
					num %= 1517486376U;
					KeyValuePair<string, PlayerController> keyValuePair = enumerator2.Current;
					num = (1440774447U | num);
					keyValuePair2 = keyValuePair;
					num = 751191231U - num;
				}
				KeyValuePair<string, PlayerController> keyValuePair3 = keyValuePair2;
				num = 1040077773U - num;
				Object value = keyValuePair3.Value;
				num >>= 18;
				bool flag2 = value == null;
				num ^= 8778U;
				if (!flag2)
				{
					if (1076198042U * num == 0U)
					{
						goto IL_12;
					}
					KeyValuePair<string, PlayerController> keyValuePair4 = keyValuePair2;
					num = (1870998681U ^ num);
					PlayerController value2 = keyValuePair4.Value;
					num = (646722046U | num);
					PlayerController playerController = value2;
					num = 115345649U >> (int)num;
					PlayerController playerController2 = playerController;
					num = 816123265U + num;
					bool isGhost = playerController2.isGhost;
					num += 3478844032U;
					if (!isGhost)
					{
						num %= 618507U;
						TaskTargetingHandler instance2 = TaskTargetingHandler.Instance;
						PlayerController playerController3 = playerController;
						num *= 971011330U;
						instance2.TargetPlayer(playerController3, num ^ 971011332U);
						num += 3323955967U;
					}
				}
			}
			if (num < 1969386119U)
			{
				return;
			}
			goto IL_12;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0005C790 File Offset: 0x00059D90
		public TrackAllPlayers()
		{
			uint num = 1702977205U;
			if (255030664U + num != 0U)
			{
				base..ctor();
			}
		}
	}
}
