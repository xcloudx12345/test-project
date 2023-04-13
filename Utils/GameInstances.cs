using System;
using Handlers.GameHandlers.PlayerHandlers;
using UnhollowerBaseLib;
using UnityEngine;

namespace GGD_Hack.Utils
{
	// Token: 0x0200000B RID: 11
	public class GameInstances
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0004F59C File Offset: 0x0004CB9C
		public static LocalPlayer GetLocalPlayer()
		{
			string text = "Player";
			uint num = 1984003398U;
			Il2CppArrayBase<GameObject> il2CppArrayBase = GameObject.FindGameObjectsWithTag(text);
			num = (533016780U ^ num);
			GameObject[] array = il2CppArrayBase;
			GameObject gameObject = null;
			GameObject[] array2 = array;
			int num2 = (int)(num - 1770278282U);
			for (;;)
			{
				num = (1806779371U | num);
				int num3 = num2;
				num = 297028950U / num;
				if (num3 >= array2.Length)
				{
					goto Block_3;
				}
				GameObject[] array3 = array2;
				int num4 = num2;
				num = 1996229741U;
				GameObject gameObject2 = array3[num4];
				num = 1234703238U - num;
				if (530936118U * num != 0U)
				{
					for (;;)
					{
						GameObject gameObject3 = gameObject2;
						num /= 1011094588U;
						Object component = gameObject3.GetComponent<LocalPlayer>();
						num %= 1935366469U;
						Object @object = null;
						num |= 1028198940U;
						bool flag = component == @object;
						num |= 319700034U;
						if (flag)
						{
							break;
						}
						GameObject gameObject4 = gameObject2;
						num = 606154587U % num;
						gameObject = gameObject4;
						if (num <= 1684225175U)
						{
							goto Block_2;
						}
					}
				}
				num = 2059091752U * num;
				int num5 = num2 + (int)(num ^ 975183833U);
				num &= 594508444U;
				num2 = num5;
				num ^= 1269061394U;
			}
			Block_2:
			goto IL_DE;
			Block_3:
			num += 606154587U;
			IL_DE:
			Object object2 = gameObject;
			num -= 907170546U;
			Object object3 = null;
			num = 26613656U % num;
			if (object2 == object3)
			{
				return null;
			}
			num += 1258186543U;
			GameObject gameObject5 = gameObject;
			num = 625410544U << (int)num;
			return gameObject5.GetComponent<LocalPlayer>();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0004F6C4 File Offset: 0x0004CCC4
		public static GameObject FindGameObjectByPath(string path)
		{
			uint num = 98452844U;
			Transform transform2;
			for (;;)
			{
				num |= 35748492U;
				int num2 = (int)(num ^ 134184941U);
				num = (1470981231U | num);
				char[] array = new char[num2];
				num = 774596694U - num;
				int num3 = (int)(num ^ 3593201767U);
				num = (1572170397U | num);
				char c = (char)(num ^ 3753896656U);
				num *= 1275402820U;
				array[num3] = c;
				num += 991712716U;
				string[] array2 = path.Split(array);
				num = (176911102U ^ num);
				string[] array3 = array2;
				num &= 670788962U;
				Transform transform = null;
				num %= 1336353993U;
				transform2 = transform;
				int num4 = (int)(num ^ 543180130U);
				if (1408907951U != num)
				{
					goto IL_86;
				}
				IL_8B:
				Object @object = transform2;
				Object object2 = null;
				num = 898632064U;
				if (@object == object2)
				{
					num <<= 29;
					if (223899417U + num == 0U)
					{
						continue;
					}
					string[] array4 = array3;
					int num5 = num4;
					num &= 630719738U;
					Transform transform3 = GameObject.Find(array4[num5]).transform;
					num %= 268128334U;
					transform2 = transform3;
					if (num == 236284000U)
					{
						continue;
					}
				}
				else
				{
					num >>= 19;
					Transform transform4 = transform2;
					string[] array5 = array3;
					int num6 = num4;
					num >>= 8;
					string text = array5[num6];
					num += 1045964889U;
					Transform transform5 = transform4.Find(text);
					num ^= 2052656278U;
					transform2 = transform5;
					num ^= 1140925641U;
				}
				num /= 960501514U;
				Object object3 = transform2;
				num = 1755910326U + num;
				if (object3 == null)
				{
					if (num >= 216995106U)
					{
						break;
					}
				}
				else
				{
					num = (2113012376U & num);
					int num7 = num4 + (int)(num + 2539650929U);
					num += 267079780U;
					num4 = num7;
					num += 2815751278U;
				}
				IL_15C:
				num = 702548829U << (int)num;
				if (num >= 1473933537U)
				{
					int num8 = num4;
					string[] array6 = array3;
					num *= 1396441201U;
					int num9 = array6.Length;
					num = (1691510176U & num);
					if (num8 >= num9)
					{
						goto Block_7;
					}
					goto IL_8B;
				}
				IL_86:
				goto IL_15C;
			}
			return null;
			Block_7:
			num >>= 24;
			return transform2.gameObject;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0004F870 File Offset: 0x0004CE70
		public GameInstances()
		{
			uint num;
			do
			{
				num = 580128296U;
				base..ctor();
			}
			while (num > 1019430557U);
		}
	}
}
