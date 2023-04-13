using System;
using Il2CppSystem.Collections.Generic;
using Managers;
using Managers.PlayerManagers;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000055 RID: 85
	[RegisterTypeInIl2Cpp]
	public class ShowAllUnlockables : MonoBehaviour
	{
		// Token: 0x0600015C RID: 348 RVA: 0x0005C7B8 File Offset: 0x00059DB8
		public ShowAllUnlockables(IntPtr ptr)
		{
			uint num = 1490492782U;
			if ((num ^ 515194393U) == 0U)
			{
				goto IL_43;
			}
			do
			{
				IL_12:
				num *= 1817394237U;
				num = (828309769U | num);
				base..ctor(ptr);
				num = (237969130U & num);
			}
			while (587478950 << (int)num == 0);
			IL_43:
			IngameSettings.IngameSettingsEntry ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			num ^= 1873891508U;
			ingameSettingsEntry.entry = ShowAllUnlockables.Enabled;
			num /= 161635971U;
			ingameSettingsEntry.name_cn = "显示所有装扮";
			if ((1300442904U ^ num) != 0U)
			{
				do
				{
					string name_eng = "Show All Unlockables";
					num >>= 20;
					ingameSettingsEntry.name_eng = name_eng;
					num <<= 0;
					if (num << 0 != 0U)
					{
						goto IL_12;
					}
					IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
				}
				while (num > 1657156998U);
				return;
			}
			goto IL_12;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0005C880 File Offset: 0x00059E80
		public ShowAllUnlockables()
		{
			uint num = 201615529U;
			if (922424742U >= num)
			{
				do
				{
					IntPtr intPtr = ClassInjector.DerivedConstructorPointer<ShowAllUnlockables>();
					num &= 611412810U;
					base..ctor(intPtr);
					num = 9451849U % num;
					num /= 550449450U;
					ClassInjector.DerivedConstructorBody(this);
				}
				while (num >> 30 != 0U);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0005C8D4 File Offset: 0x00059ED4
		public static void Init()
		{
			uint num;
			GameObject gameObject2;
			do
			{
				string text = "ML_Manager";
				num = 1850833316U;
				GameObject gameObject = GameObject.Find(text);
				num -= 1941268086U;
				gameObject2 = gameObject;
				if (num * 229579123U != 0U)
				{
					Object @object = gameObject2;
					num |= 241439416U;
					bool flag = @object == null;
					num = 1181885896U << (int)num;
					if (flag)
					{
						gameObject2 = new GameObject("ML_Manager");
						if (num >= 1017593633U)
						{
							continue;
						}
						Object.DontDestroyOnLoad(gameObject2);
						num ^= 0U;
					}
				}
				num = 1344087060U * num;
				bool flag2 = gameObject2.GetComponent<ShowAllUnlockables>() == null;
				num = 1323041838U >> (int)num;
				if (!flag2)
				{
					return;
				}
			}
			while (num - 3368335U == 0U);
			GameObject gameObject3 = gameObject2;
			num /= 1566270603U;
			ShowAllUnlockables instance = gameObject3.AddComponent<ShowAllUnlockables>();
			num |= 1815483724U;
			ShowAllUnlockables.Instance = instance;
			num ^= 585765218U;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0005C9A4 File Offset: 0x00059FA4
		public static void UpdateTempUserUnlockables()
		{
			uint num;
			Dictionary<string, string> dictionary2;
			for (;;)
			{
				IL_00:
				PlayerPropertiesManager playerPropertiesManager = MainManager.Instance.playerPropertiesManager;
				num = 1547447222U;
				PlayerPropertiesManager playerPropertiesManager2 = playerPropertiesManager;
				num <<= 19;
				do
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					num |= 1753235961U;
					dictionary2 = dictionary;
					num /= 818633418U;
					if (443173717U == num)
					{
						goto IL_00;
					}
					Dictionary<string, string> dictionary3 = dictionary2;
					num = 881924672U / num;
					string text = "hat";
					PlayerPropertiesManager playerPropertiesManager3 = playerPropertiesManager2;
					num ^= 455613295U;
					string tempHat = playerPropertiesManager3.tempHat;
					num ^= 937446201U;
					dictionary3.Add(text, tempHat);
				}
				while (748960238U >= num);
				Dictionary<string, string> dictionary4 = dictionary2;
				string text2 = "clothes";
				num = 531445416U - num;
				dictionary4.Add(text2, playerPropertiesManager2.tempClothes);
				if (419459482U <= num)
				{
					Dictionary<string, string> dictionary5 = dictionary2;
					num ^= 2068670018U;
					string text3 = "fart";
					num = 342303072U % num;
					PlayerPropertiesManager playerPropertiesManager4 = playerPropertiesManager2;
					num = (105320276U & num);
					dictionary5.Add(text3, playerPropertiesManager4.tempFart);
					Dictionary<string, string> dictionary6 = dictionary2;
					num |= 184489779U;
					string text4 = "pet";
					PlayerPropertiesManager playerPropertiesManager5 = playerPropertiesManager2;
					num %= 1400176985U;
					string tempPet = playerPropertiesManager5.tempPet;
					num = (2001338614U | num);
					dictionary6.Add(text4, tempPet);
					num |= 1346268232U;
					if (1274108660U != num)
					{
						Dictionary<string, string> dictionary7 = dictionary2;
						string text5 = "stinger";
						num += 1556381350U;
						PlayerPropertiesManager playerPropertiesManager6 = playerPropertiesManager2;
						num = 338058686U / num;
						dictionary7.Add(text5, playerPropertiesManager6.tempStinger);
						Dictionary<string, string> dictionary8 = dictionary2;
						num >>= 27;
						string text6 = "Banners";
						PlayerPropertiesManager playerPropertiesManager7 = playerPropertiesManager2;
						num += 1614026191U;
						dictionary8.Add(text6, playerPropertiesManager7.tempBanner);
						if (1721714031U > num)
						{
							Dictionary<string, string> dictionary9 = dictionary2;
							num <<= 24;
							string text7 = "Cards";
							PlayerPropertiesManager playerPropertiesManager8 = playerPropertiesManager2;
							num |= 491153542U;
							dictionary9.Add(text7, playerPropertiesManager8.tempCard);
							num %= 481762513U;
							if (476521369U - num != 0U)
							{
								break;
							}
						}
					}
				}
			}
			PlayerPropertiesManager playerPropertiesManager9 = MainManager.Instance.playerPropertiesManager;
			num = 631789596U * num;
			playerPropertiesManager9.ChangeUserProperties(dictionary2);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0005CB44 File Offset: 0x0005A144
		private void Update()
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0005CB54 File Offset: 0x0005A154
		// Note: this type is marked as 'beforefieldinit'.
		static ShowAllUnlockables()
		{
			uint num;
			do
			{
				string text = "GGDH";
				num = 1495622772U;
				string text2 = "Enable_ShowAllUnlockables";
				num = 1464105825U - num;
				bool flag = (num ^ 4263450348U) != 0U;
				num /= 1879706651U;
				string text3 = null;
				string text4 = null;
				num = 1163545593U + num;
				bool flag2 = num - 1163545595U != 0U;
				num = 2095858946U + num;
				MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, (num ^ 3259404541U) != 0U, null);
				num = 1470845839U << (int)num;
				ShowAllUnlockables.Enabled = enabled;
			}
			while (num <= 1915369122U);
		}

		// Token: 0x0400019C RID: 412
		public static ShowAllUnlockables Instance;

		// Token: 0x0400019D RID: 413
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
