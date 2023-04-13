using System;
using System.Collections.Generic;
using APIs.Photon;
using GGD_Hack.Utils;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using Photon.Realtime;
using TMPro;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace GGD_Hack.Features
{
	// Token: 0x0200003D RID: 61
	[RegisterTypeInIl2Cpp]
	public class RandomJoinRoom : MonoBehaviour
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x000563E0 File Offset: 0x000539E0
		public RandomJoinRoom(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000563F4 File Offset: 0x000539F4
		public RandomJoinRoom()
		{
			uint num = 1871388336U;
			base..ctor(ClassInjector.DerivedConstructorPointer<RandomJoinRoom>());
			num &= 2136761201U;
			if (num > 206073939U)
			{
				ClassInjector.DerivedConstructorBody(this);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0005642C File Offset: 0x00053A2C
		public static void Init()
		{
			uint num = 984579692U;
			if ((num ^ 591733641U) == 0U)
			{
				goto IL_5D;
			}
			IL_12:
			string text = "ML_Manager";
			num = 1168663770U - num;
			GameObject gameObject = GameObject.Find(text);
			num = 1363489698U >> (int)num;
			GameObject gameObject2 = gameObject;
			num = 31533939U / num;
			IL_3B:
			if (!(gameObject2 == null))
			{
				goto IL_6B;
			}
			gameObject2 = new GameObject("ML_Manager");
			if (num > 1991270238U)
			{
				goto IL_12;
			}
			IL_5D:
			Object.DontDestroyOnLoad(gameObject2);
			num ^= 0U;
			IL_6B:
			GameObject gameObject3 = gameObject2;
			num = 1099563704U << (int)num;
			bool flag = gameObject3.GetComponent<RandomJoinRoom>() == null;
			num &= 128581640U;
			if (flag)
			{
				if (num == 96734283U)
				{
					goto IL_3B;
				}
				RandomJoinRoom instance = gameObject2.AddComponent<RandomJoinRoom>();
				num <<= 22;
				RandomJoinRoom.Instance = instance;
				num ^= 0U;
			}
			num -= 1698785296U;
			if (1481843187U * num == 0U)
			{
				goto IL_12;
			}
			object @object = null;
			num += 1505653727U;
			PhotonCallbacksAPI.AddOnRoomListUpdateListener(new Action<List<RoomInfo>>(@object.UpdateRoomsInfo), num - 4101835726U != 0U);
			if ((1835286847U ^ num) != 0U)
			{
				return;
			}
			goto IL_3B;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00056538 File Offset: 0x00053B38
		public static bool CreateRandomJoinButton()
		{
			uint num = 607536427U;
			Button button;
			for (;;)
			{
				IL_06:
				Object @object = RandomJoinRoom.randomJoin;
				Object object2 = null;
				num ^= 1269908366U;
				bool flag = @object != object2;
				num >>= 12;
				if (flag)
				{
					break;
				}
				Transform transform6;
				do
				{
					num &= 493977555U;
					GameObject gameObject = GameObject.Find("Mode Select - Safe zone H");
					num = 1703439653U / num;
					Transform transform = gameObject.transform.Find("Goose");
					if (num >> 3 == 0U)
					{
						goto IL_26;
					}
					do
					{
						Transform transform2 = transform;
						num |= 2140686654U;
						Transform transform3 = transform2.Find("Host");
						Transform transform4 = transform;
						num = 55466284U / num;
						Transform transform5 = transform4.Find("Find");
						num &= 1852007112U;
						transform6 = transform5;
						num = 118696312U - num;
						Transform transform7 = transform;
						num = 801509206U << (int)num;
						string text = "Join";
						num = 1475697263U / num;
						Transform transform8 = transform7.Find(text);
						Transform transform9 = transform;
						num = 41229323U - num;
						string text2 = "Host (1)";
						num = (1808678477U | num);
						Transform transform10 = transform9.Find(text2);
						num = 1118330216U - num;
						Transform transform11 = transform;
						num = (1377444643U | num);
						Transform transform12 = transform11.Find("Find (1)");
						num = 350108516U % num;
						RandomJoinRoom.findButton = transform6.gameObject;
						num = 508102366U - num;
						float y = transform8.localPosition.y;
						Transform transform13 = transform6;
						num = (602608843U | num);
						float num2 = y - transform13.localPosition.y;
						num = 591487116U % num;
						num += 1551197582U;
						Vector3 localPosition = transform3.localPosition;
						float num3 = 0f;
						num = (774269229U ^ num);
						float num4 = num2;
						float num5 = 0f;
						num = (1849429709U | num);
						transform3.localPosition = localPosition - new Vector3(num3, num4, num5);
						Transform transform14 = transform6;
						num = 57089645U >> (int)num;
						Vector3 localPosition2 = transform14.localPosition;
						num = 617894967U << (int)num;
						float num6 = 0f;
						float num7 = num2;
						num &= 2054715868U;
						Vector3 vector = new Vector3(num6, num7, 0f);
						num = 144594334U - num;
						transform14.localPosition = localPosition2 - vector;
						num /= 89479519U;
						if (290393221U <= num)
						{
							goto IL_06;
						}
						Transform transform15 = transform10;
						num = 200035527U + num;
						Vector3 localPosition3 = transform15.localPosition;
						float num8 = 0f;
						num |= 679702089U;
						float num9 = num2;
						float num10 = 0f;
						num = 2033919053U + num;
						Vector3 localPosition4 = localPosition3 - new Vector3(num8, num9, num10);
						num <<= 1;
						transform15.localPosition = localPosition4;
						Transform transform16 = transform12;
						num = 149645033U / num;
						Vector3 localPosition5 = transform16.localPosition;
						num /= 1468812462U;
						float num11 = 0f;
						float num12 = num2;
						float num13 = 0f;
						num <<= 17;
						Vector3 vector2 = new Vector3(num11, num12, num13);
						num >>= 12;
						Vector3 localPosition6 = localPosition5 - vector2;
						num = 293561717U << (int)num;
						transform16.localPosition = localPosition6;
						num <<= 3;
					}
					while (num == 741218453U);
					Component component = transform6;
					num ^= 1071718563U;
					RandomJoinRoom.randomJoin = Object.Instantiate<GameObject>(component.gameObject, transform);
					num = 1337350871U + num;
				}
				while (num > 782180817U);
				RandomJoinRoom.randomJoin.name = "JoinRandomRoom";
				num /= 566451779U;
				if (num * 272841198U == 0U)
				{
					Transform transform17 = RandomJoinRoom.randomJoin.transform;
					int siblingIndex = transform6.GetSiblingIndex() + (int)(num ^ 1U);
					num |= 532022516U;
					transform17.SetSiblingIndex(siblingIndex);
					if (1989555111U < num)
					{
						break;
					}
					GameObject gameObject2 = RandomJoinRoom.randomJoin;
					num *= 2046492819U;
					button = gameObject2.GetComponent<Button>();
					num = 1646854695U + num;
					if (num >> 3 != 0U)
					{
						Object object3 = button;
						Object object4 = null;
						num &= 947937495U;
						bool flag2 = object3 != object4;
						num = 582554671U / num;
						if (!flag2)
						{
							goto IL_38C;
						}
						if ((num ^ 1544320288U) != 0U)
						{
							goto Block_8;
						}
					}
				}
			}
			IL_26:
			num *= 1996317289U;
			return (num ^ 3567699441U) != 0U;
			Block_8:
			Object object5 = button;
			num /= 716907980U;
			Object.DestroyImmediate(object5);
			num = (2044622745U & num);
			GameObject gameObject3 = RandomJoinRoom.randomJoin;
			num <<= 28;
			Button button2 = gameObject3.AddComponent<Button>();
			num += 1449016005U;
			button = button2;
			num ^= 1449015936U;
			IL_38C:
			Button button3 = button;
			num = (824576697U & num);
			UnityEvent onClick = button3.onClick;
			Action action;
			if ((action = RandomJoinRoom.<>c.<>9__7_0) == null)
			{
				object <> = RandomJoinRoom.<>c.<>9;
				IntPtr method = ldftn(<CreateRandomJoinButton>b__7_0);
				num = (1885433778U ^ num);
				Action <>9__7_ = action = new Action(<>, method);
				num -= 376647226U;
				RandomJoinRoom.<>c.<>9__7_0 = <>9__7_;
				num ^= 1508786552U;
			}
			onClick.AddListener(action);
			GameObject gameObject4 = RandomJoinRoom.randomJoin;
			num ^= 1308757477U;
			Transform transform18 = gameObject4.transform;
			num &= 117774168U;
			Component component2 = transform18.Find("Font");
			num >>= 28;
			TMP_Text component3 = component2.GetComponent<TextMeshProUGUI>();
			string text3 = "随机加入";
			num += 14973914U;
			component3.text = text3;
			num += 568287294U;
			return num + 3711706089U != 0U;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00056978 File Offset: 0x00053F78
		public static void DoRandomJoinRoom()
		{
			try
			{
				uint num = 380321719U;
				if (310647635U > num)
				{
					goto IL_23;
				}
				IL_11:
				bool flag = RandomJoinRoom.roomInfos != null;
				num ^= 438436782U;
				if (!flag)
				{
					goto IL_3A;
				}
				IL_23:
				if (RandomJoinRoom.roomInfos.Count != 0)
				{
					num = (1690197463U & num);
					List<RoomInfo> list = new List<RoomInfo>();
					num |= 229210171U;
					List<RoomInfo> list2 = RandomJoinRoom.roomInfos;
					num = (1688565198U ^ num);
					List<RoomInfo>.Enumerator enumerator = list2.GetEnumerator();
					try
					{
						if ((num & 1808534406U) == 0U)
						{
							goto IL_AA;
						}
						IL_A5:
						goto IL_145;
						IL_AA:
						num = 528894346U;
						RoomInfo roomInfo = enumerator.Current;
						num = 1630628955U << (int)num;
						RoomInfo roomInfo2 = roomInfo;
						num = 2014069544U - num;
						float playerCount = roomInfo2.PlayerCount;
						num ^= 1428630923U;
						int maxPlayers = (int)roomInfo2.MaxPlayers;
						num ^= 1602109295U;
						int num2 = maxPlayers;
						num %= 2002008215U;
						float num3 = playerCount;
						float num4 = num2;
						num = (2066627863U ^ num);
						double num5 = num3 / num4;
						num = 490624152U << (int)num;
						double num6 = num5;
						double num7 = 0.6666666666666666;
						num += 4094867349U;
						if (num6 >= num7)
						{
							goto IL_145;
						}
						if (num < 1246167108U)
						{
							goto IL_A5;
						}
						IL_134:
						list.Add(roomInfo2);
						num += 0U;
						IL_145:
						num &= 1971927425U;
						if (num == 76683726U)
						{
							goto IL_AA;
						}
						num |= 214268374U;
						bool flag2 = enumerator.MoveNext();
						num = 2046970845U / num;
						if (flag2)
						{
							goto IL_AA;
						}
						if (301760440U >> (int)num == 0U)
						{
							goto IL_134;
						}
					}
					finally
					{
						do
						{
							num = 286745091U;
							if (1505182123U / num == 0U)
							{
								break;
							}
							num = (1665532781U | num);
							((IDisposable)enumerator).Dispose();
						}
						while ((1574730519U & num) == 0U);
					}
					int num8;
					do
					{
						num = 1343388477U;
						num8 = (int)(num ^ 1343388477U);
					}
					while (num - 1842356358U == 0U);
					List<RoomInfo> list3 = list;
					num *= 22640689U;
					List<RoomInfo>.Enumerator enumerator2 = list3.GetEnumerator();
					num = 1365070523U / num;
					using (List<RoomInfo>.Enumerator enumerator = enumerator2)
					{
						for (;;)
						{
							num = 1121007626U + num;
							bool flag3 = enumerator.MoveNext();
							num >>= 7;
							if (!flag3)
							{
								break;
							}
							int playerCount2 = enumerator.Current.PlayerCount;
							num = 1562778011U;
							int num9 = playerCount2;
							int num10 = num8;
							num -= 448032111U;
							num += 3180221400U;
							if (num9 >= num10)
							{
								num8 = playerCount2;
								num += 0U;
							}
						}
					}
					List<RoomInfo> list5;
					do
					{
						num = 1571244392U;
						if (247935767U == num)
						{
							break;
						}
						List<RoomInfo> list4 = new List<RoomInfo>();
						num = (365571418U & num);
						list5 = list4;
					}
					while (1012535093U % num == 0U);
					List<RoomInfo> list6 = list;
					num = 1673729232U - num;
					enumerator = list6.GetEnumerator();
					try
					{
						if (num < 258809988U)
						{
							goto IL_2D9;
						}
						IL_2A5:
						goto IL_317;
						IL_2D9:
						RoomInfo roomInfo4;
						RoomInfo roomInfo3 = roomInfo4;
						num = 1388382243U % num;
						int playerCount3 = roomInfo3.PlayerCount;
						int num11 = num8;
						num = 1754596746U % num;
						num += 946671137U;
						if (playerCount3 != num11)
						{
							goto IL_317;
						}
						IL_2FE:
						List<RoomInfo> list7 = list5;
						num = 1297833500U + num;
						list7.Add(roomInfo4);
						num ^= 3588055596U;
						IL_317:
						num = 1088625239U * num;
						if (num + 936469297U == 0U)
						{
							goto IL_2FE;
						}
						bool flag4 = enumerator.MoveNext();
						num = 3038839U % num;
						if (flag4)
						{
							num = 1752582131U;
							if (611664977U + num == 0U)
							{
								goto IL_2A5;
							}
							RoomInfo roomInfo5 = enumerator.Current;
							num <<= 2;
							roomInfo4 = roomInfo5;
							if (1584692870U - num != 0U)
							{
								goto IL_2D9;
							}
							goto IL_2A5;
						}
					}
					finally
					{
						num = 216409954U;
						if (num != 1121463643U)
						{
							num += 170682985U;
							((IDisposable)enumerator).Dispose();
						}
					}
					for (;;)
					{
						num = 1486425932U;
						List<RoomInfo> list8 = list5;
						num = 781735228U - num;
						bool count = list8.Count != 0;
						num >>= 19;
						if (count)
						{
							break;
						}
						num = 922765294U * num;
						if (num <= 2060519197U)
						{
							goto Block_10;
						}
					}
					RoomInfo roomInfo6;
					for (;;)
					{
						int num12 = (int)(num ^ 6847U);
						List<RoomInfo> list9 = list5;
						num &= 2039825533U;
						int num13 = Random.RandomRangeInt(num12, list9.Count);
						num = (1232884308U | num);
						int num14 = num13;
						if (num % 1777810700U != 0U)
						{
							List<RoomInfo> list10 = list5;
							int index = num14;
							num *= 1075589721U;
							roomInfo6 = list10[index];
							string str = "随机房间:";
							num >>= 27;
							RoomInfo roomInfo7 = roomInfo6;
							num <<= 6;
							string str2 = roomInfo7.ToStringFull();
							num /= 992884776U;
							string text = str + str2;
							num = (1940405381U | num);
							MelonLogger.Msg(text);
							num %= 1562190787U;
							if (num != 1967812167U)
							{
								break;
							}
						}
					}
					string name = roomInfo6.Name;
					num = 769682089U >> (int)num;
					string text2 = "nick name";
					num = 245588564U % num;
					PlayerPrefs.GetString(text2);
					num = (2026973137U & num);
					num &= 1193372541U;
					JoinRoom.Join(name);
					return;
					Block_10:
					string text3 = "筛选后无可用房间可加入！";
					num = (2046911584U ^ num);
					MelonLogger.Warning(text3);
					return;
				}
				num += 0U;
				IL_3A:
				if (815745076 << (int)num == 0)
				{
					goto IL_11;
				}
				MelonLogger.Warning("当前无可用房间可加入！\n正在刷新房间...");
				num = 1917331474U >> (int)num;
				JoinRoom.Refresh();
			}
			catch (Exception ex)
			{
				uint num = 1542791074U;
				do
				{
					string str3 = "DoRandomJoinRoom失败: ";
					num |= 420289451U;
					object obj = ex;
					num -= 1298206507U;
					MelonLogger.Warning(str3 + obj.ToString());
				}
				while (num / 1732456390U != 0U);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00056EAC File Offset: 0x000544AC
		private static void UpdateRoomsInfo(List<RoomInfo> roomInfos)
		{
			uint num;
			List<RoomInfo> list2;
			do
			{
				IL_00:
				List<RoomInfo> list = new List<RoomInfo>();
				num = 783238809U;
				list2 = list;
				num = (1649166275U & num);
				List<RoomInfo>.Enumerator enumerator = roomInfos.GetEnumerator();
				while (enumerator.MoveNext())
				{
					List<RoomInfo>.Enumerator enumerator2 = enumerator;
					num = 2138124036U;
					RoomInfo roomInfo = enumerator2.Current;
					num *= 1204911242U;
					RoomInfo roomInfo2 = roomInfo;
					num = 536412667U - num;
					if ((num ^ 537418937U) == 0U)
					{
						goto IL_00;
					}
					List<RoomInfo> list3 = list2;
					num = 1892834086U % num;
					RoomInfo item = roomInfo2;
					num += 1393239604U;
					list3.Add(item);
					num += 3453856883U;
				}
			}
			while (num << 23 == 0U);
			List<RoomInfo> list4 = list2;
			num = (424633158U & num);
			RandomJoinRoom.roomInfos = list4;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00056F48 File Offset: 0x00054548
		private void Update()
		{
			uint num = 790918456U;
			if (896293701U <= num)
			{
				goto IL_66;
			}
			do
			{
				IL_11:
				Object @object = RandomJoinRoom.randomJoin;
				num = (980182403U ^ num);
				if (!(@object != null))
				{
					goto IL_66;
				}
				num = (1189039236U & num);
			}
			while (num % 942765259U == 0U);
			GameObject gameObject = RandomJoinRoom.randomJoin;
			num = 1583822454U % num;
			Object component = gameObject.GetComponent<Button>();
			num ^= 416830511U;
			component == null;
			num += 4233662818U;
			IL_66:
			if (1922519246 << (int)num != 0)
			{
				return;
			}
			goto IL_11;
		}

		// Token: 0x04000155 RID: 341
		public static List<RoomInfo> roomInfos;

		// Token: 0x04000156 RID: 342
		public static GameObject randomJoin;

		// Token: 0x04000157 RID: 343
		public static GameObject findButton;

		// Token: 0x04000158 RID: 344
		public static RandomJoinRoom Instance;
	}
}
