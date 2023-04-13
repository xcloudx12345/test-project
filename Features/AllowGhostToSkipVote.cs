using System;
using Handlers.GameHandlers.PlayerHandlers;
using Handlers.GameHandlers.VotingHandlers;
using HarmonyLib;
using Managers;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000052 RID: 82
	public class AllowGhostToSkipVote
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0005C1B8 File Offset: 0x000597B8
		public AllowGhostToSkipVote()
		{
			uint num = 2134313495U;
			if (10039068U % num != 0U)
			{
				base..ctor();
			}
		}

		// Token: 0x020000B0 RID: 176
		[HarmonyPatch(typeof(VotePrefabHandler), "Update")]
		private class ForceSkipButtonInteractable
		{
			// Token: 0x0600024A RID: 586 RVA: 0x000671CC File Offset: 0x000647CC
			private static void Prefix(ref bool __state)
			{
				uint num;
				for (;;)
				{
					LocalPlayer instance = LocalPlayer.Instance;
					num = 55318811U;
					Object @object;
					if (instance == null)
					{
						if (1448966884U >= num)
						{
							goto IL_1D;
						}
						continue;
					}
					else
					{
						@object = instance.Player;
						num += 0U;
					}
					IL_30:
					num *= 506418420U;
					Object object2 = null;
					num = 1763465816U + num;
					bool flag = @object == object2;
					num = 1014650938U >> (int)num;
					if (flag)
					{
						if (1144084310U % num != 0U)
						{
							break;
						}
						continue;
					}
					else if (1918657844U / num != 0U)
					{
						num = (900231040U ^ num);
						LocalPlayer instance2 = LocalPlayer.Instance;
						num ^= 1882065828U;
						PlayerController player = instance2.Player;
						num <<= 6;
						bool isGhost = player.isGhost;
						num += 1337032163U;
						__state = isGhost;
						uint num2 = (uint)MainManager.Instance.gameManager.gameState;
						num -= 628562914U;
						if (num2 != (num ^ 2345949892U))
						{
							if (284570160U != num)
							{
								return;
							}
						}
						else if ((1334723107U ^ num) != 0U)
						{
							goto Block_6;
						}
					}
					IL_1D:
					@object = null;
					goto IL_30;
				}
				return;
				Block_6:
				LocalPlayer instance3 = LocalPlayer.Instance;
				num = (627653840U & num);
				PlayerController player2 = instance3.Player;
				bool isGhost2 = num - 20977856U != 0U;
				num = (780696008U | num);
				player2.isGhost = isGhost2;
			}

			// Token: 0x0600024B RID: 587 RVA: 0x000672E0 File Offset: 0x000648E0
			private static void Postfix(ref bool __state)
			{
				LocalPlayer instance = LocalPlayer.Instance;
				uint num;
				Object @object;
				if (instance == null)
				{
					num = 1520003534U;
					num ^= 1799756861U;
					@object = null;
				}
				else
				{
					@object = instance.Player;
					num = 836728307U;
				}
				Object object2 = null;
				num = (1693278537U & num);
				bool flag = @object == object2;
				num = (2096714462U | num);
				if (flag)
				{
					return;
				}
				num = (1229922629U ^ num);
				LocalPlayer instance2 = LocalPlayer.Instance;
				num <<= 3;
				PlayerController player = instance2.Player;
				num = 635112167U * num;
				player.isGhost = __state;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x00067360 File Offset: 0x00064960
			public ForceSkipButtonInteractable()
			{
				uint num = 855670042U;
				num = 119745437U - num;
				base..ctor();
			}
		}
	}
}
