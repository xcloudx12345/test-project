using System;
using APIs.Photon;
using Il2CppSystem;
using UnhollowerBaseLib;

namespace GGD_Hack
{
	// Token: 0x02000005 RID: 5
	public static class SendEventToPlugin
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0004DA44 File Offset: 0x0004B044
		public static void MOVE_SHUTTLE()
		{
			uint num;
			do
			{
				byte b = 30;
				num = 1301551026U;
				Object @object = null;
				num = 1104761700U * num;
				bool flag = num - 2573858696U != 0U;
				num = 1209097716U - num;
				PhotonEventAPI.SendEventToPlugin(b, @object, flag);
			}
			while (num == 338775582U);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0004DA84 File Offset: 0x0004B084
		public static void SPECIAL_KILL(int type)
		{
			string[] array = new string[1];
			uint num = 804395277U;
			string[] array2 = array;
			num |= 1955274945U;
			string[] array3 = array2;
			num >>= 10;
			int num2 = (int)(num ^ 2096846U);
			string text = type.ToString();
			num -= 653730239U;
			array3[num2] = text;
			byte b = (byte)(num ^ 3643333891U);
			num = 809462779U * num;
			string[] stringArr = array2;
			num = 1114842075U + num;
			Object @object = SendEventToPlugin.fromStringArray(stringArr);
			bool flag = num - 2023368336U != 0U;
			num = 879570335U >> (int)num;
			PhotonEventAPI.SendEventToPlugin(b, @object, flag);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0004DB00 File Offset: 0x0004B100
		public static void RECEIVE_KILL()
		{
			uint num = 369710702U;
			byte b = (byte)(num - 369710699U);
			num = 797267004U << (int)num;
			PhotonEventAPI.SendEventToPlugin(b, null, (num ^ 1427046400U) != 0U);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0004DB38 File Offset: 0x0004B138
		public static void MorphIntoMummy()
		{
			uint num;
			do
			{
				byte b = 82;
				Object @object = null;
				num = 761691535U;
				PhotonEventAPI.SendEventToPlugin(b, @object, (num ^ 761691535U) != 0U);
			}
			while ((1522028575U ^ num) == 0U);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0004DB68 File Offset: 0x0004B168
		public static Object fromStringArray(string[] stringArr)
		{
			uint num = 372663795U;
			Il2CppStringArray il2CppStringArray2;
			for (;;)
			{
				int num2 = stringArr.Length;
				num = (1601515984U & num);
				int num3 = num2;
				long num4 = (long)num3;
				num >>= 1;
				long num5 = num4;
				num <<= 20;
				Il2CppStringArray il2CppStringArray = new Il2CppStringArray(num5);
				num %= 268775965U;
				il2CppStringArray2 = il2CppStringArray;
				num %= 758588034U;
				int num6 = (int)(num + 4051697664U);
				for (;;)
				{
					int num7 = num6;
					num = 1087471523U % num;
					if (num7 >= num3)
					{
						goto Block_2;
					}
					num = 1476660509U;
					Il2CppArrayBase<string> il2CppArrayBase = il2CppStringArray2;
					int num8 = num6;
					num ^= 805770666U;
					il2CppArrayBase[num8] = stringArr[num6];
					num += 1852255101U;
					if (1750677672U == num)
					{
						break;
					}
					int num9 = num6;
					int num10 = (int)(num ^ 3597288501U);
					num = (879714807U & num);
					num6 = num9 + num10;
					num ^= 451559476U;
				}
			}
			Block_2:
			num = 1742482148U + num;
			Il2CppObjectBase il2CppObjectBase = il2CppStringArray2;
			num %= 2113676134U;
			IntPtr pointer = il2CppObjectBase.Pointer;
			num = (1504641443U | num);
			return new Object(pointer);
		}
	}
}
