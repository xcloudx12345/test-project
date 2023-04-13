using System;
using System.Reflection;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using Photon.Pun;
using UnhollowerBaseLib;
using UnityEngine;

namespace GGD_Hack.Features.Test
{
	// Token: 0x0200005C RID: 92
	public static class RPC
	{
		// Token: 0x06000176 RID: 374 RVA: 0x0005DA3C File Offset: 0x0005B03C
		public static void ChangeCurrentRoom(string roomId, RpcTarget rpcTarget = 5)
		{
			uint num = 35594297U;
			if (num != 1961651699U)
			{
				PhotonView photonView;
				Il2CppReferenceArray<Object> il2CppReferenceArray2;
				for (;;)
				{
					Component instance = LocalPlayer.Instance;
					num %= 1674774902U;
					GameObject gameObject = instance.gameObject;
					num = (165099645U ^ num);
					PhotonView component = gameObject.GetComponent<PhotonView>();
					num = 1111061723U << (int)num;
					photonView = component;
					num &= 737639963U;
					if (811730121U >= num)
					{
						for (;;)
						{
							Object @object = photonView;
							num += 257379429U;
							bool flag = @object == null;
							num = 951275928U >> (int)num;
							if (!flag)
							{
								break;
							}
							num /= 110953084U;
							if (num < 1370167820U)
							{
								goto IL_9B;
							}
						}
						long num2 = (long)(num - 452U);
						num *= 1314204337U;
						Il2CppReferenceArray<Object> il2CppReferenceArray = new Il2CppReferenceArray<Object>(num2);
						num = 2109344773U - num;
						il2CppReferenceArray2 = il2CppReferenceArray;
						num &= 1526930977U;
						if (num >> 29 != 0U)
						{
							break;
						}
					}
				}
				Il2CppArrayBase<Object> il2CppArrayBase = il2CppReferenceArray2;
				int num3 = (int)(num - 1090584576U);
				num = (378947603U & num);
				num = (1374517655U | num);
				Object object2 = roomId;
				num += 84373112U;
				il2CppArrayBase[num3] = object2;
				num = 195771869U * num;
				string text = "准备发送ChangeCurrentRoom";
				num = 447153119U * num;
				MelonLogger.Msg(text);
				try
				{
					MethodInfo methodInfo;
					if (659897257U > num || num >> 6 != 0U)
					{
						do
						{
							RuntimeTypeHandle handle = typeof(PhotonView).TypeHandle;
							num %= 2047680908U;
							Type typeFromHandle = Type.GetTypeFromHandle(handle);
							string text2 = "RPC";
							num %= 737023250U;
							int num4 = (int)(num ^ 233749386U);
							num >>= 9;
							Type[] array = new Type[num4];
							int num5 = (int)(num ^ 456541U);
							num = (434920654U ^ num);
							RuntimeTypeHandle handle2 = typeof(string).TypeHandle;
							num >>= 18;
							array[num5] = Type.GetTypeFromHandle(handle2);
							num /= 22443895U;
							num /= 1648558083U;
							int num6 = (int)(num ^ 1U);
							num ^= 1247630013U;
							Type typeFromHandle2 = typeof(RpcTarget);
							num >>= 21;
							array[num6] = typeFromHandle2;
							int num7 = (int)(num - 592U);
							RuntimeTypeHandle handle3 = typeof(Il2CppReferenceArray<Object>).TypeHandle;
							num %= 1192373694U;
							array[num7] = Type.GetTypeFromHandle(handle3);
							Type[] array2 = null;
							num = 1505632256U * num;
							methodInfo = AccessTools.Method(typeFromHandle, text2, array, array2);
							num = 1396841217U % num;
						}
						while (1309238296U == num);
						MethodInfo left = methodInfo;
						num *= 969816317U;
						if (!(left != null))
						{
							goto IL_3B8;
						}
					}
					string text3 = methodInfo.ToString();
					num |= 636230867U;
					string text4 = text3;
					ConsoleColor consoleColor = (ConsoleColor)(num - 2147336181U);
					num = (428178758U | num);
					string text5 = text4;
					num /= 1178884706U;
					MelonLogger.Msg(consoleColor, text5);
					try
					{
						int num8 = (int)(num + 2U);
						num = 1123238611U / num;
						object[] array3 = new object[num8];
						num = 298132779U + num;
						int num9 = (int)(num + 2873595906U);
						num = (232271109U | num);
						array3[num9] = "ChangeCurrentRoom";
						num ^= 1638742814U;
						int num10 = (int)(num ^ 1012225248U);
						num = 1621955136U % num;
						num = 1102339731U + num;
						array3[num10] = rpcTarget;
						num ^= 1382623602U;
						num ^= 668681713U;
						array3[(int)(num - 331249519U)] = il2CppReferenceArray2;
						object[] array4 = array3;
						if (1186668795U <= num)
						{
							goto IL_348;
						}
						IL_329:
						MethodBase methodBase = methodInfo;
						object obj = photonView;
						num = (1732780192U & num);
						object[] parameters = array4;
						num %= 1165052893U;
						methodBase.Invoke(obj, parameters);
						IL_348:
						num >>= 22;
						ConsoleColor consoleColor2 = (int)num + (ConsoleColor)(-2);
						num += 717302579U;
						string text6 = "Invoke成功";
						num <<= 25;
						MelonLogger.Msg(consoleColor2, text6);
						if (num >> 8 == 0U)
						{
							goto IL_329;
						}
					}
					catch (Exception ex)
					{
						do
						{
							string str = "Invoke失败";
							string message = ex.Message;
							num = 1085679651U;
							MelonLogger.Error(str + message);
						}
						while (535697781U >= num);
					}
					IL_3B8:;
				}
				catch (Exception ex2)
				{
					MelonLogger.Error(ex2.Message);
				}
				return;
			}
			do
			{
				IL_9B:
				string text7 = "LocalPlayer的PhotonView为空";
				num <<= 10;
				MelonLogger.Warning(text7);
			}
			while (num << 29 != 0U);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0005DE50 File Offset: 0x0005B450
		public static void Fake_Flip(int code)
		{
			uint num;
			for (;;)
			{
				Component instance = LocalPlayer.Instance;
				num = 821721408U;
				GameObject gameObject = instance.gameObject;
				num &= 1333396687U;
				PhotonView component = gameObject.GetComponent<PhotonView>();
				num -= 1325022836U;
				PhotonView photonView = component;
				if (num != 120016500U)
				{
					for (;;)
					{
						Object @object = photonView;
						num = 1986726105U % num;
						bool flag = @object == null;
						num ^= 905394500U;
						if (flag)
						{
							goto Block_0;
						}
						long num2 = (long)(num ^ 1134309790U);
						num = 1823412854U >> (int)num;
						Il2CppReferenceArray<Object> il2CppReferenceArray = new Il2CppReferenceArray<Object>(num2);
						num = (827003775U & num);
						Il2CppReferenceArray<Object> il2CppReferenceArray2 = il2CppReferenceArray;
						if (num + 449588540U == 0U)
						{
							break;
						}
						Il2CppArrayBase<Object> il2CppArrayBase = il2CppReferenceArray2;
						int num3 = (int)(num ^ 3U);
						num *= 1646669901U;
						Int32 @int = default(Int32);
						num >>= 8;
						num |= 650133195U;
						@int.m_value = code;
						num &= 1313210463U;
						Object object2 = @int.BoxIl2CppObject();
						num *= 108297557U;
						il2CppArrayBase[num3] = object2;
						num = (775041742U & num);
						Il2CppArrayBase<Object> il2CppArrayBase2 = il2CppReferenceArray2;
						num <<= 25;
						int num4 = (int)(num ^ 201326593U);
						@int = default(Int32);
						num = 1786398357U << (int)num;
						num = 1954371767U + num;
						PhotonView photonView2 = photonView;
						num <<= 27;
						@int.m_value = photonView2.ViewID;
						Object object3 = @int.BoxIl2CppObject();
						num /= 1973554796U;
						il2CppArrayBase2[num4] = object3;
						num *= 765207693U;
						Il2CppArrayBase<Object> il2CppArrayBase3 = il2CppReferenceArray2;
						int num5 = (int)(num ^ 2U);
						@int = default(Int32);
						num = 1914306634U >> (int)num;
						int value = (int)(num - 1914296533U);
						num = (2077687903U ^ num);
						@int.m_value = value;
						num |= 492320652U;
						num = 235303736U / num;
						Object object4 = @int.BoxIl2CppObject();
						num = 632771163U - num;
						il2CppArrayBase3[num5] = object4;
						num |= 1974032322U;
						if (42890130U < num)
						{
							goto Block_2;
						}
					}
				}
			}
			Block_0:
			MelonLogger.Warning("LocalPlayer的PhotonView为空");
			return;
			Block_2:
			string text = "准备发送Flip";
			num %= 1320223023U;
			MelonLogger.Msg(text);
			try
			{
				if (num > 529999654U)
				{
					num = 1458272959U >> (int)num;
				}
				RuntimeTypeHandle handle = typeof(PhotonView).TypeHandle;
				num = 515386838U + num;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				string text2 = "RPC";
				Type[] array = new Type[num ^ 515742862U];
				num = 221145361U << (int)num;
				int num6 = (int)(num ^ 3441565696U);
				num /= 2036362674U;
				RuntimeTypeHandle handle2 = typeof(string).TypeHandle;
				num += 39010659U;
				Type typeFromHandle2 = Type.GetTypeFromHandle(handle2);
				num = 464458155U + num;
				array[num6] = typeFromHandle2;
				num = 22086519U + num;
				int num7 = (int)(num ^ 525555335U);
				Type typeFromHandle3 = typeof(RpcTarget);
				num >>= 31;
				array[num7] = typeFromHandle3;
				array[(int)(num + 2U)] = typeof(Il2CppReferenceArray<Object>);
				num /= 2044469173U;
				Type[] array2 = null;
				num = (344873674U ^ num);
				MethodInfo methodInfo = AccessTools.Method(typeFromHandle, text2, array, array2);
				num ^= 508900071U;
				MethodInfo left = methodInfo;
				MethodInfo right = null;
				num |= 1365051883U;
				bool flag2 = left != right;
				num = 1071710487U * num;
				if (flag2)
				{
					num %= 212344750U;
					string text3 = methodInfo.ToString();
					num = 1313753138U + num;
					string text4 = text3;
					ConsoleColor consoleColor = (ConsoleColor)(num ^ 1524218785U);
					num = 1913860636U >> (int)num;
					MelonLogger.Msg(consoleColor, text4);
					try
					{
						do
						{
							object[] array3 = new object[num ^ 934501U];
							num = 1149400113U / num;
							array3[(int)(num + 4294966067U)] = "Flip";
							int num8 = (int)(num ^ 1228U);
							RpcTarget rpcTarget = num ^ 1224U;
							num ^= 1482057700U;
							object obj = rpcTarget;
							num -= 546995671U;
							array3[num8] = obj;
							num = 1878000240U * num;
							int num9 = (int)(num + 2602633250U);
							Il2CppReferenceArray<Object> il2CppReferenceArray2;
							object obj2 = il2CppReferenceArray2;
							num = (577982027U ^ num);
							array3[num9] = obj2;
							num = 1191379733U << (int)num;
							object[] parameters = array3;
							MethodBase methodBase = methodInfo;
							PhotonView photonView;
							object obj3 = photonView;
							num = 1388585372U >> (int)num;
							methodBase.Invoke(obj3, parameters);
							ConsoleColor consoleColor2 = (ConsoleColor)(num - 1388585362U);
							string text5 = "Invoke成功";
							num %= 548420513U;
							MelonLogger.Msg(consoleColor2, text5);
						}
						while (num < 34173517U);
					}
					catch (Exception ex)
					{
						do
						{
							string str = "Invoke失败";
							num = 1052386719U;
							Exception ex2 = ex;
							num >>= 2;
							string text6 = str + ex2.Message;
							num >>= 13;
							MelonLogger.Error(text6);
						}
						while (1858752909U < num);
					}
				}
			}
			catch (Exception ex3)
			{
				num = 750009223U;
				string message = ex3.Message;
				num <<= 4;
				MelonLogger.Error(message);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0005E280 File Offset: 0x0005B880
		public static void Flip()
		{
			uint num = 766255590U;
			if (821001630U == num)
			{
				goto IL_44;
			}
			bool facingRight;
			do
			{
				IL_13:
				LocalPlayer instance = LocalPlayer.Instance;
				num %= 67260925U;
				PlayerController player = instance.Player;
				num = 1319118278U + num;
				facingRight = player.facingRight;
			}
			while ((1083600994U ^ num) == 0U);
			PhotonView component;
			Il2CppReferenceArray<Object> il2CppReferenceArray2;
			for (;;)
			{
				IL_44:
				Component instance2 = LocalPlayer.Instance;
				num &= 1439309694U;
				GameObject gameObject = instance2.gameObject;
				num = 1038430991U >> (int)num;
				component = gameObject.GetComponent<PhotonView>();
				num %= 2049380484U;
				if (num - 894179281U == 0U)
				{
					goto IL_B1;
				}
				Object @object = component;
				num ^= 6126650U;
				Object object2 = null;
				num ^= 945371437U;
				if (@object == object2)
				{
					break;
				}
				num = 2110288109U << (int)num;
				long num2 = (long)(num + 595128626U);
				num >>= 30;
				long num3 = num2;
				num %= 318405302U;
				Il2CppReferenceArray<Object> il2CppReferenceArray = new Il2CppReferenceArray<Object>(num3);
				num = (657401342U & num);
				il2CppReferenceArray2 = il2CppReferenceArray;
				if (2104648438 << (int)num != 0)
				{
					goto Block_4;
				}
			}
			num /= 749996201U;
			IL_B1:
			string text = "LocalPlayer的PhotonView为空";
			num <<= 27;
			MelonLogger.Warning(text);
			if ((1611662130U ^ num) != 0U)
			{
				return;
			}
			goto IL_13;
			Block_4:
			Il2CppArrayBase<Object> il2CppArrayBase = il2CppReferenceArray2;
			num = 1894792376U >> (int)num;
			int num4 = (int)(num - 473698094U);
			num /= 1076444779U;
			Int32 @int = default(Int32);
			int value;
			if (!facingRight)
			{
				num = (728252171U | num);
				value = (int)(num - 728252170U);
			}
			else
			{
				num %= 1068065733U;
				value = (int)(num - 0U);
				num ^= 728252171U;
			}
			num = 6248550U - num;
			@int.m_value = value;
			num = 1521118859U % num;
			num = (1635148605U | num);
			Object object3 = @int.BoxIl2CppObject();
			num /= 537531692U;
			il2CppArrayBase[num4] = object3;
			Il2CppArrayBase<Object> il2CppArrayBase2 = il2CppReferenceArray2;
			num &= 911282849U;
			int num5 = (int)(num ^ 0U);
			num = (1730156784U ^ num);
			num %= 2019101159U;
			@int = default(Int32);
			num <<= 26;
			PhotonView photonView = component;
			num = 1976770384U / num;
			int viewID = photonView.ViewID;
			num /= 1958890760U;
			@int.m_value = viewID;
			num = (1352033544U ^ num);
			il2CppArrayBase2[num5] = @int.BoxIl2CppObject();
			num = 731931154U / num;
			MelonLogger.Msg("准备发送Flip");
			try
			{
				num = 1984982377U >> (int)num;
				string text3;
				MethodInfo methodInfo;
				if (num > 409556232U)
				{
					string text2 = "暂未获取rpc方法";
					num = (1510169870U & num);
					text3 = text2;
					RuntimeTypeHandle handle = typeof(PhotonView).TypeHandle;
					num = (34417517U | num);
					Type typeFromHandle = Type.GetTypeFromHandle(handle);
					string text4 = "RPC";
					Type[] array = new Type[num ^ 1376612206U];
					num = 1053180798U << (int)num;
					int num6 = (int)(num ^ 3362766848U);
					num %= 1942779990U;
					RuntimeTypeHandle handle2 = typeof(string).TypeHandle;
					num = (706758903U & num);
					array[num6] = Type.GetTypeFromHandle(handle2);
					int num7 = (int)(num + 4292853599U);
					RuntimeTypeHandle handle3 = typeof(RpcTarget).TypeHandle;
					num = 1302872190U - num;
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle3);
					num <<= 1;
					array[num7] = typeFromHandle2;
					num = 769851590U % num;
					num = 365770973U + num;
					int num8 = (int)(num - 1135622561U);
					num = 522608522U >> (int)num;
					array[num8] = typeof(Il2CppReferenceArray<Object>);
					num = 1570661460U >> (int)num;
					methodInfo = AccessTools.Method(typeFromHandle, text4, array, null);
					if (1132733764U >= num)
					{
						MethodInfo left = methodInfo;
						MethodInfo right = null;
						num &= 1453788077U;
						bool flag = left != right;
						num = 1275539866U >> (int)num;
						if (!flag)
						{
							goto IL_51F;
						}
						num >>= 7;
					}
					string text5 = methodInfo.ToString();
					num ^= 725240403U;
					text3 = text5;
				}
				ConsoleColor consoleColor = (ConsoleColor)(num - 725241481U);
				string text6 = text3;
				num = (555943347U & num);
				MelonLogger.Msg(consoleColor, text6);
				try
				{
					for (;;)
					{
						int num9 = (int)(num ^ 555877520U);
						num = 700276670U / num;
						object[] array2 = new object[num9];
						num <<= 28;
						int num10 = (int)(num ^ 268435456U);
						num += 1222470369U;
						array2[num10] = "Flip";
						num ^= 89861349U;
						num ^= 648568151U;
						array2[(int)(num ^ 2066619218U)] = num - 2066619214U;
						num = 353974720U + num;
						num += 667439842U;
						int num11 = (int)(num + 1206933517U);
						num = (1722626806U ^ num);
						array2[num11] = il2CppReferenceArray2;
						num = 1764822150U >> (int)num;
						object[] parameters = array2;
						if (num < 299852510U)
						{
							MethodBase methodBase = methodInfo;
							num = 838205452U * num;
							object obj = component;
							num = (1935895505U & num);
							methodBase.Invoke(obj, parameters);
							num = 2082616357U << (int)num;
							num = 1680940255U % num;
							ConsoleColor consoleColor2 = (int)num + (ConsoleColor)(-1680940245);
							num = 1585008399U - num;
							MelonLogger.Msg(consoleColor2, "Invoke成功");
							if (num / 362287201U != 0U)
							{
								break;
							}
						}
					}
				}
				catch (Exception ex)
				{
					num = 572279973U;
					if (220341449U + num != 0U)
					{
						do
						{
							string str = "Invoke失败";
							Exception ex2 = ex;
							num &= 2053506178U;
							string message = ex2.Message;
							num <<= 5;
							string text7 = str + message;
							num = (598628319U & num);
							MelonLogger.Error(text7);
						}
						while (1285098600U + num == 0U);
					}
				}
				IL_51F:;
			}
			catch (Exception ex3)
			{
				MelonLogger.Error(ex3.Message);
			}
		}
	}
}
