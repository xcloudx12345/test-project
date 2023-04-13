using System;
using System.Reflection;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using MelonLoader.Preferences;
using Photon.Pun;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000050 RID: 80
	[RegisterTypeInIl2Cpp]
	public class Moonwalk : MonoBehaviour
	{
		// Token: 0x0600014D RID: 333 RVA: 0x0005B7F8 File Offset: 0x00058DF8
		public Moonwalk(IntPtr ptr)
		{
			uint num = 1971726996U;
			if (num << 9 != 0U)
			{
				base..ctor(ptr);
				num = (2033857779U & num);
			}
			IngameSettings.IngameSettingsEntry ingameSettingsEntry = default(IngameSettings.IngameSettingsEntry);
			num |= 1362132761U;
			ingameSettingsEntry.entry = Moonwalk.Enabled;
			num = (2071153385U ^ num);
			string name_cn = "太空步";
			num &= 724325378U;
			ingameSettingsEntry.name_cn = name_cn;
			num %= 2003439728U;
			num += 1335821403U;
			string name_eng = "Moonwalk";
			num = 545475616U % num;
			ingameSettingsEntry.name_eng = name_eng;
			num |= 1116688591U;
			IngameSettings.AddIngameSettingsEntry(ingameSettingsEntry);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0005B890 File Offset: 0x00058E90
		public Moonwalk()
		{
			uint num = 1499158877U;
			if (num * 95245315U != 0U)
			{
				num = 1946238501U >> (int)num;
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<Moonwalk>();
				num = (847784168U | num);
				base..ctor(intPtr);
				num = (1196689963U ^ num);
			}
			do
			{
				num = 909074199U % num;
				ClassInjector.DerivedConstructorBody(this);
			}
			while (2135308552U + num == 0U);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0005B8F4 File Offset: 0x00058EF4
		public static void Init()
		{
			uint num = 66871106U;
			if (num * 385102137U == 0U)
			{
				goto IL_5B;
			}
			IL_12:
			string text = "ML_Manager";
			num -= 1373569436U;
			GameObject gameObject = GameObject.Find(text);
			num = (782112638U | num);
			GameObject gameObject2 = gameObject;
			if (num >> 10 == 0U)
			{
				goto IL_79;
			}
			Object @object = gameObject2;
			Object object2 = null;
			num = (663230037U | num);
			if (!(@object == object2))
			{
				goto IL_87;
			}
			num = 317732082U >> (int)num;
			IL_5B:
			GameObject gameObject3 = new GameObject("ML_Manager");
			num <<= 24;
			gameObject2 = gameObject3;
			if (num == 1017120931U)
			{
				goto IL_12;
			}
			IL_79:
			Object.DontDestroyOnLoad(gameObject2);
			num ^= 3214893055U;
			IL_87:
			if (320275600U % num != 0U)
			{
				Object component = gameObject2.GetComponent<Moonwalk>();
				num = 737565705U % num;
				if (component == null)
				{
					num = (300354191U & num);
					GameObject gameObject4 = gameObject2;
					num >>= 30;
					Moonwalk instance = gameObject4.AddComponent<Moonwalk>();
					num = (592314487U | num);
					Moonwalk.Instance = instance;
					num += 145251218U;
				}
				return;
			}
			goto IL_12;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0005B9D8 File Offset: 0x00058FD8
		private static void OnChangeDirection(bool turnRight)
		{
			uint num;
			bool flag;
			do
			{
				num = 320107397U;
				flag = turnRight;
			}
			while (616251050U < num);
			PhotonView photonView;
			Il2CppReferenceArray<Object> il2CppReferenceArray;
			for (;;)
			{
				uint num2 = flag ? 1U : 0U;
				num >>= 24;
				flag = (num2 == (num ^ 19U));
				num %= 467758823U;
				if (num % 2577016U != 0U)
				{
					for (;;)
					{
						PhotonView component = LocalPlayer.Instance.gameObject.GetComponent<PhotonView>();
						num ^= 972440616U;
						photonView = component;
						num = 1110649780U << (int)num;
						bool flag2 = photonView == null;
						num = 2044550758U - num;
						if (!flag2)
						{
							break;
						}
						num = 1538602333U % num;
						if (num << 20 != 0U)
						{
							goto Block_1;
						}
					}
					num = 1669675442U / num;
					long num3 = (long)(num ^ 2U);
					num = (289613861U ^ num);
					il2CppReferenceArray = new Il2CppReferenceArray<Object>(num3);
					num = 1786536877U << (int)num;
					if (1228684843U <= num)
					{
						goto Block_2;
					}
				}
			}
			Block_1:
			MelonLogger.Warning("LocalPlayer的PhotonView为空");
			return;
			Block_2:
			Il2CppArrayBase<Object> il2CppArrayBase = il2CppReferenceArray;
			num = (210136946U ^ num);
			int num4 = (int)(num - 1124735698U);
			num = 1190753734U - num;
			num %= 1290098804U;
			Int32 @int = default(Int32);
			num += 1717568473U;
			bool flag3 = flag;
			num = (313685622U & num);
			int value;
			if (!flag3)
			{
				value = (int)(num - 33707588U);
			}
			else
			{
				num = 995894404U % num;
				value = (int)(num + 4276592945U);
				num += 15333236U;
			}
			num = (149178292U & num);
			@int.m_value = value;
			num = 387345789U * num;
			Object @object = @int.BoxIl2CppObject();
			num /= 1167681108U;
			il2CppArrayBase[num4] = @object;
			num = 1691950330U % num;
			Il2CppArrayBase<Object> il2CppArrayBase2 = il2CppReferenceArray;
			num = 2044487896U >> (int)num;
			int num5 = (int)(num ^ 2044487897U);
			num = 823081772U % num;
			num = 1086420871U / num;
			@int = default(Int32);
			num = 1468161584U / num;
			PhotonView photonView2 = photonView;
			num = 1523125923U % num;
			int viewID = photonView2.ViewID;
			num = 832247559U - num;
			@int.m_value = viewID;
			num = 1105417759U % num;
			il2CppArrayBase2[num5] = @int.BoxIl2CppObject();
			try
			{
				num -= 975196094U;
				num = (314721752U ^ num);
				RuntimeTypeHandle handle = typeof(PhotonView).TypeHandle;
				num = 1317344081U * num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num >>= 10;
				string text = "RPC";
				Type[] array = new Type[num + 4290891168U];
				num &= 446170733U;
				array[(int)(num ^ 1573473U)] = typeof(string);
				num = 800132705U >> (int)num;
				int num6 = (int)(num - 400066351U);
				RuntimeTypeHandle handle2 = typeof(RpcTarget).TypeHandle;
				num = 2110915118U >> (int)num;
				Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
				num = 1610247319U % num;
				array[num6] = typeFromHandle2;
				num |= 670529736U;
				int num7 = (int)(num + 3624436787U);
				num |= 1198332765U;
				Type typeFromHandle3 = typeof(Il2CppReferenceArray<Object>);
				num = 1523004800U >> (int)num;
				array[num7] = typeFromHandle3;
				num = 1410085787U >> (int)num;
				MethodInfo methodInfo = AccessTools.Method(typeFromHandle, text, array, null);
				num *= 579668115U;
				MethodInfo methodInfo2 = methodInfo;
				MethodInfo left = methodInfo2;
				num = 394217611U / num;
				MethodInfo right = null;
				num %= 71583250U;
				bool flag4 = left != right;
				num = 1262109065U - num;
				if (flag4)
				{
					object obj = methodInfo2;
					num &= 1089558275U;
					string text2 = obj.ToString();
					num <<= 6;
					string text3 = text2;
					MelonLogger.Msg((ConsoleColor)(num ^ 202391626U), text3);
					try
					{
						int num8 = (int)(num ^ 202391619U);
						num = 381229598U / num;
						object[] array2 = new object[num8];
						num = (852181868U | num);
						int num9 = (int)(num - 852181869U);
						num = (1802638676U & num);
						object obj2 = "Flip";
						num &= 938033963U;
						array2[num9] = obj2;
						num <<= 22;
						int num10 = (int)(num ^ 1073741825U);
						object obj3 = num + 3221225477U;
						num = 455835502U - num;
						array2[num10] = obj3;
						num %= 1636984092U;
						array2[(int)(num ^ 403092788U)] = il2CppReferenceArray;
						num = 719002339U % num;
						object[] parameters = array2;
						num = 682562029U % num;
						do
						{
							MethodBase methodBase = methodInfo2;
							num = 1764253389U + num;
							object obj4 = photonView;
							num = 461582923U - num;
							methodBase.Invoke(obj4, parameters);
							num += 27416303U;
							ConsoleColor consoleColor = (ConsoleColor)(num - 2968970192U);
							num &= 691830286U;
							MelonLogger.Msg(consoleColor, "Invoke成功");
						}
						while (num << 5 == 0U);
					}
					catch (Exception ex)
					{
						num = 1799375128U;
						string str = "Invoke失败";
						Exception ex2 = ex;
						num *= 1434335677U;
						string message = ex2.Message;
						num = 2084011854U / num;
						MelonLogger.Error(str + message);
					}
				}
			}
			catch (Exception ex3)
			{
				num = 601577602U;
				string message2 = ex3.Message;
				num = 1303447216U / num;
				MelonLogger.Error(message2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0005BEC8 File Offset: 0x000594C8
		// Note: this type is marked as 'beforefieldinit'.
		static Moonwalk()
		{
			uint num = 514794398U;
			string text = "GGDH";
			string text2 = "Enable_Moonwalk";
			bool flag = num + 3780172898U != 0U;
			string text3 = null;
			string text4 = null;
			bool flag2 = (num ^ 514794398U) != 0U;
			bool flag3 = num - 514794398U != 0U;
			ValueValidator valueValidator = null;
			num = 658730008U >> (int)num;
			MelonPreferences_Entry<bool> enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			num -= 877942258U;
			Moonwalk.Enabled = enabled;
			Moonwalk.lastFrameMovingRight = ((num ^ 3417025038U) != 0U);
			num = (1415605350U ^ num);
			Moonwalk.movingRight = (num + 1614035352U != 0U);
		}

		// Token: 0x04000195 RID: 405
		public static Moonwalk Instance;

		// Token: 0x04000196 RID: 406
		public static MelonPreferences_Entry<bool> Enabled;

		// Token: 0x04000197 RID: 407
		public static bool lastFrameMovingRight;

		// Token: 0x04000198 RID: 408
		public static bool movingRight;

		// Token: 0x020000AC RID: 172
		[HarmonyPatch(typeof(LocalPlayer), "MoveTowards", new Type[]
		{
			typeof(Vector3)
		})]
		private class PlayerController_MoveTowards
		{
			// Token: 0x06000241 RID: 577 RVA: 0x00066DC0 File Offset: 0x000643C0
			private static void Prefix(LocalPlayer __instance, Vector3 __0)
			{
				uint num = 1768040794U;
				if (num > 1371423780U)
				{
					for (;;)
					{
						MelonPreferences_Entry<bool> enabled = Moonwalk.Enabled;
						num |= 348402666U;
						if (!enabled.Value)
						{
							break;
						}
						num = (203166441U & num);
						num &= 1350959333U;
						float x = __0.x;
						GameObject gameObject = LocalPlayer.Instance.gameObject;
						num = 1361256779U >> (int)num;
						Transform transform = gameObject.transform;
						num = (273160863U ^ num);
						Moonwalk.movingRight = (x - transform.position.x > 0f);
						bool movingRight = Moonwalk.movingRight;
						num &= 1023044882U;
						bool lastFrameMovingRight = Moonwalk.lastFrameMovingRight;
						num = 1843472802U << (int)num;
						if (movingRight != lastFrameMovingRight)
						{
							num |= 2120038922U;
							if (num % 559289870U == 0U)
							{
								continue;
							}
							Moonwalk.OnChangeDirection(Moonwalk.movingRight);
							num += 2846017014U;
						}
						if (636495129U / num == 0U)
						{
							goto Block_4;
						}
					}
					return;
					Block_4:
					bool movingRight2 = Moonwalk.movingRight;
					num %= 703202375U;
					Moonwalk.lastFrameMovingRight = movingRight2;
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00066EB4 File Offset: 0x000644B4
			public PlayerController_MoveTowards()
			{
				uint num = 166082260U;
				if (num - 597823979U != 0U)
				{
					do
					{
						base..ctor();
					}
					while (1687572569U == num);
				}
			}
		}

		// Token: 0x020000AD RID: 173
		[HarmonyPatch(typeof(PlayerController), "MMHJKMIPBGE", new Type[]
		{
			typeof(bool)
		})]
		private class PlayerController_Flip
		{
			// Token: 0x06000243 RID: 579 RVA: 0x00066EE4 File Offset: 0x000644E4
			private static bool Prefix(LocalPlayer __instance, ref bool __0)
			{
				bool value = Moonwalk.Enabled.Value;
				uint num = 158161918U;
				if (value)
				{
					num = 1735747112U * num;
					return num - 1221825456U != 0U;
				}
				return num + 4136805379U != 0U;
			}
		}
	}
}
