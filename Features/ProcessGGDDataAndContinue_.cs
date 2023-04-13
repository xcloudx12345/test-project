using System;
using System.Collections;
using System.Collections.Generic;
using HarmonyLib;
using Managers.InfoManagers;
using MelonLoader;
using Objects;
using UnhollowerBaseLib;

namespace GGD_Hack.Features
{
	// Token: 0x02000056 RID: 86
	[HarmonyPatch(typeof(UnlockablesManager), "ProcessGGDDataAndContinue")]
	internal class ProcessGGDDataAndContinue_
	{
		// Token: 0x06000162 RID: 354 RVA: 0x0005CBCC File Offset: 0x0005A1CC
		private static void Prefix(ref GGDDataBody __0)
		{
			uint num;
			Il2CppReferenceArray<UnlockableInfo> il2CppReferenceArray;
			UnlockableInfo unlockableInfo3;
			for (;;)
			{
				MelonPreferences_Entry<bool> enabled = ShowAllUnlockables.Enabled;
				num = 498095217U;
				bool value = enabled.Value;
				num *= 421294653U;
				if (!value)
				{
					break;
				}
				num = 983630335U / num;
				string text = "开始处理GGDDataBody";
				num <<= 12;
				MelonLogger.Msg(text);
				num = 1048858566U << (int)num;
				num <<= 4;
				GGDDataBody ggddataBody = __0;
				num &= 204884273U;
				UnlockablesInfoBody ggdUnlockables = ggddataBody.ggdUnlockables;
				num += 1248862572U;
				Il2CppReferenceArray<UnlockableInfo> unlockableInfo = ggdUnlockables.unlockableInfo;
				num -= 416563944U;
				il2CppReferenceArray = unlockableInfo;
				UnlockableInfo unlockableInfo2 = null;
				num = 1017649733U >> (int)num;
				unlockableInfo3 = unlockableInfo2;
				num &= 1937452406U;
				if (num != 505177872U)
				{
					goto Block_1;
				}
			}
			return;
			Block_1:
			Il2CppArrayBase<UnlockableInfo> il2CppArrayBase = il2CppReferenceArray;
			num = 1478302330U + num;
			IEnumerator<UnlockableInfo> enumerator = il2CppArrayBase.GetEnumerator();
			try
			{
				do
				{
					UnlockableInfo unlockableInfo5;
					for (;;)
					{
						num = (1689402640U | num);
						if (1871262221U >= num)
						{
							goto IL_C3;
						}
						IEnumerator enumerator2 = enumerator;
						num >>= 15;
						bool flag = enumerator2.MoveNext();
						num = 1198802095U * num;
						if (flag)
						{
							goto IL_C3;
						}
						if (num << 12 != 0U)
						{
							goto Block_9;
						}
						IL_D2:
						UnlockableInfo unlockableInfo4 = unlockableInfo5;
						num -= 1945008086U;
						bool isAvailable = unlockableInfo4.isAvailable;
						num ^= 2865229533U;
						if (isAvailable)
						{
							break;
						}
						continue;
						IL_C3:
						IEnumerator<UnlockableInfo> enumerator3 = enumerator;
						num = 1703898393U;
						unlockableInfo5 = enumerator3.Current;
						goto IL_D2;
					}
					unlockableInfo3 = unlockableInfo5;
				}
				while ((num & 2076600375U) == 0U);
				Block_9:;
			}
			finally
			{
				num = 1733380307U;
				if (1185554329U >> (int)num != 0U && enumerator != null && 49752943U / num == 0U)
				{
					enumerator.Dispose();
					num += 0U;
				}
			}
			UnlockableRecipe unlockableRecipe;
			do
			{
				unlockableRecipe = new UnlockableRecipe();
				num = 1499663192U;
			}
			while (2028750096U <= num);
			UnlockableCost unlockableCost2;
			do
			{
				UnlockableRecipe unlockableRecipe2 = unlockableRecipe;
				long num2 = (long)(num ^ 1499663193U);
				num |= 2042461984U;
				long num3 = num2;
				num &= 1199054081U;
				Il2CppReferenceArray<UnlockableCost> recipeCosts = new Il2CppReferenceArray<UnlockableCost>(num3);
				num &= 44314788U;
				unlockableRecipe2.recipeCosts = recipeCosts;
				UnlockableCost unlockableCost = new UnlockableCost();
				num = 577654705U % num;
				unlockableCost2 = unlockableCost;
				num = 1425085903U * num;
			}
			while (1164913986U - num == 0U);
			UnlockableCost unlockableCost3 = unlockableCost2;
			num = 985411856U % num;
			unlockableCost3.cost = (int)(num - 985311857U);
			UnlockableCost unlockableCost4 = unlockableCost2;
			num = 158617283U - num;
			string currencyType = "gold";
			num = (41904471U & num);
			unlockableCost4.currencyType = currencyType;
			Il2CppArrayBase<UnlockableCost> recipeCosts2 = unlockableRecipe.recipeCosts;
			num -= 1901225441U;
			int num4 = (int)(num ^ 2430968626U);
			num = (507403164U | num);
			recipeCosts2[num4] = unlockableCost2;
			num <<= 26;
			IEnumerator<UnlockableInfo> enumerator4 = il2CppReferenceArray.GetEnumerator();
			num = (347475575U ^ num);
			enumerator = enumerator4;
			try
			{
				if (num > 63708481U)
				{
					goto IL_289;
				}
				goto IL_2BE;
				UnlockableInfo unlockableInfo7;
				for (;;)
				{
					IL_28E:
					IEnumerator<UnlockableInfo> enumerator5 = enumerator;
					num = 1176389567U;
					UnlockableInfo unlockableInfo6 = enumerator5.Current;
					num = 1412244990U + num;
					unlockableInfo7 = unlockableInfo6;
					num -= 739140347U;
					if (1110849810U <= num)
					{
						goto IL_2BE;
					}
				}
				IL_289:
				goto IL_52E;
				IL_2BE:
				UnlockableInfo unlockableInfo8 = unlockableInfo7;
				num += 915094683U;
				Unlockable rawUnlockable = unlockableInfo8.rawUnlockable;
				num = 1555520866U >> (int)num;
				Unlockable unlockable = rawUnlockable;
				if ((num ^ 1762860915U) == 0U)
				{
					goto IL_28E;
				}
				UnlockableInfo unlockableInfo9 = unlockableInfo7;
				num <<= 18;
				bool isAvailable2 = unlockableInfo9.isAvailable;
				num = 1037304087U >> (int)num;
				if (!isAvailable2)
				{
					do
					{
						Unlockable unlockable2 = unlockable;
						num = (477565510U | num);
						unlockable2.recipes = new Il2CppReferenceArray<UnlockableRecipe>((long)(num + 3255364778U));
						num /= 1728190176U;
					}
					while (num << 1 != 0U);
					Il2CppArrayBase<UnlockableRecipe> recipes = unlockable.recipes;
					num <<= 2;
					int num5 = (int)(num - 0U);
					UnlockableRecipe unlockableRecipe3 = unlockableRecipe;
					num >>= 7;
					recipes[num5] = unlockableRecipe3;
					num *= 1716207677U;
					UnlockableInfo unlockableInfo10 = unlockableInfo7;
					bool isAvailable3 = (num ^ 1U) != 0U;
					num %= 399920725U;
					unlockableInfo10.isAvailable = isAvailable3;
					num ^= 1037304087U;
				}
				Unlockable unlockable3 = unlockable;
				UnlockableInfo unlockableInfo11 = unlockableInfo3;
				num %= 313415627U;
				long startDate = unlockableInfo11.rawUnlockable.startDate;
				num %= 1350391739U;
				unlockable3.startDate = startDate;
				if (671166038U >> (int)num != 0U)
				{
					Unlockable unlockable4 = unlockable;
					Unlockable rawUnlockable2 = unlockableInfo3.rawUnlockable;
					num *= 1262057045U;
					long expirationDate = rawUnlockable2.expirationDate;
					num = (1016463414U & num);
					unlockable4.expirationDate = expirationDate;
					if ((num ^ 1517684507U) == 0U)
					{
						goto IL_28E;
					}
					Unlockable unlockable5 = unlockable;
					UnlockableInfo unlockableInfo12 = unlockableInfo3;
					num += 1172205011U;
					Unlockable rawUnlockable3 = unlockableInfo12.rawUnlockable;
					num = 341536503U % num;
					long saleStartDate = rawUnlockable3.saleStartDate;
					num -= 1534474999U;
					unlockable5.saleStartDate = saleStartDate;
					Unlockable unlockable6 = unlockable;
					UnlockableInfo unlockableInfo13 = unlockableInfo3;
					num += 440795449U;
					Unlockable rawUnlockable4 = unlockableInfo13.rawUnlockable;
					num = (735390561U ^ num);
					unlockable6.saleExpirationDate = rawUnlockable4.saleExpirationDate;
					if (num >> 11 == 0U)
					{
						goto IL_28E;
					}
					UnlockableInfo unlockableInfo14 = unlockableInfo7;
					num = 50793203U / num;
					UnlockableInfo unlockableInfo15 = unlockableInfo3;
					num |= 296034239U;
					bool isAvailableExpiringSoon = unlockableInfo15.isAvailableExpiringSoon;
					num >>= 21;
					unlockableInfo14.isAvailableExpiringSoon = isAvailableExpiringSoon;
					if (num >= 23620652U)
					{
						goto IL_28E;
					}
					unlockableInfo7.isOnSale = unlockableInfo3.isOnSale;
					if (num + 866014071U != 0U)
					{
						UnlockableInfo unlockableInfo16 = unlockableInfo7;
						UnlockableInfo unlockableInfo17 = unlockableInfo3;
						num = (556271084U | num);
						unlockableInfo16.isOnSaleExpiringSoon = unlockableInfo17.isOnSaleExpiringSoon;
						num = 1642952396U * num;
						UnlockableInfo unlockableInfo18 = unlockableInfo7;
						num = 1217406156U / num;
						long timeUntilIsAvailableExpiring = unlockableInfo3.timeUntilIsAvailableExpiring;
						num = (430255373U | num);
						unlockableInfo18.timeUntilIsAvailableExpiring = timeUntilIsAvailableExpiring;
						UnlockableInfo unlockableInfo19 = unlockableInfo7;
						UnlockableInfo unlockableInfo20 = unlockableInfo3;
						num = 2009663300U * num;
						long timeUntilIsOnSaleExpiring = unlockableInfo20.timeUntilIsOnSaleExpiring;
						num += 1323204121U;
						unlockableInfo19.timeUntilIsOnSaleExpiring = timeUntilIsOnSaleExpiring;
						num += 3750182378U;
					}
				}
				IL_52E:
				num = 93945202U + num;
				if (enumerator.MoveNext())
				{
					goto IL_28E;
				}
				if ((num & 1370697861U) == 0U)
				{
					goto IL_289;
				}
			}
			finally
			{
				num = 1506230662U;
				bool flag2 = enumerator != null;
				num ^= 508377499U;
				if (flag2)
				{
					enumerator.Dispose();
					num ^= 0U;
				}
			}
		}
	}
}
