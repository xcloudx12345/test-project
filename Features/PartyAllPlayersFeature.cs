using System;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;

namespace GGD_Hack.Features
{
	// Token: 0x0200003C RID: 60
	public class PartyAllPlayersFeature
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000561FC File Offset: 0x000537FC
		public static bool PartyAllPlayers()
		{
			uint num;
			for (;;)
			{
				IL_00:
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = 565931757U;
				Dictionary<string, PlayerController>.Enumerator enumerator = playersList.GetEnumerator();
				num = 1445623380U << (int)num;
				Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
				if (1671115940U >= num)
				{
					string key;
					for (;;)
					{
						num = 70725947U * num;
						if (!enumerator2.MoveNext())
						{
							goto Block_11;
						}
						Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator2;
						num = 315521849U;
						KeyValuePair<string, PlayerController> keyValuePair = enumerator3.Current;
						num = 250221063U % num;
						key = keyValuePair.Key;
						PlayerController value = keyValuePair.Value;
						num -= 1205824112U;
						PlayerController playerController = value;
						num = 1625055515U % num;
						bool flag = key != null;
						num *= 396915500U;
						num ^= 2197639588U;
						if (flag)
						{
							num /= 1871201706U;
							string a = key;
							num &= 1911950858U;
							string b = "";
							num += 899758006U;
							bool flag2 = a == b;
							num = 2006520318U * num;
							num += 2119967596U;
							if (!flag2)
							{
								num = (520697896U | num);
								bool flag3 = playerController == null;
								num = 546637511U << (int)num;
								num += 3116611840U;
								if (!flag3)
								{
									num ^= 1105205522U;
									PlayerController playerController2 = playerController;
									num = 544213160U * num;
									bool isLocal = playerController2.isLocal;
									num /= 2136873380U;
									num += 1321893887U;
									if (!isLocal)
									{
										num -= 1369834656U;
										if (num < 1151157064U)
										{
											goto IL_00;
										}
										bool timeOfDeath = playerController.timeOfDeath != 0;
										num *= 1588860837U;
										num ^= 567518432U;
										if (!timeOfDeath)
										{
											num = (353902964U | num);
											if (num % 1486815772U == 0U)
											{
												goto IL_00;
											}
											bool isHelium = playerController.isHelium;
											num += 4008697484U;
											if (!isHelium)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
					num <<= 8;
					if (num * 1923364010U != 0U)
					{
						PluginEventsManager.Helium(key);
						if ((num ^ 805860500U) != 0U)
						{
							break;
						}
					}
				}
			}
			goto IL_19E;
			Block_11:
			num ^= 2712371200U;
			IL_19E:
			num -= 813514217U;
			return num - 2583872022U != 0U;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000563B8 File Offset: 0x000539B8
		public PartyAllPlayersFeature()
		{
			uint num;
			do
			{
				num = 626351777U;
				base..ctor();
			}
			while (552280273U + num == 0U);
		}
	}
}
