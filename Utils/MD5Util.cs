using System;
using System.Security.Cryptography;
using System.Text;

namespace GGD_Hack.Utils
{
	// Token: 0x0200000D RID: 13
	public class MD5Util
	{
		// Token: 0x0600005E RID: 94 RVA: 0x0004F910 File Offset: 0x0004CF10
		public static string GetMd5Hash(string input)
		{
			uint num = 329321525U;
			MD5 md = MD5.Create();
			string result;
			try
			{
				StringBuilder stringBuilder2;
				for (;;)
				{
					HashAlgorithm hashAlgorithm = md;
					Encoding utf = Encoding.UTF8;
					num ^= 1674399073U;
					byte[] array = hashAlgorithm.ComputeHash(utf.GetBytes(input));
					if (721750111U == num)
					{
						goto IL_F3;
					}
					int num2;
					do
					{
						StringBuilder stringBuilder = new StringBuilder();
						num *= 225536250U;
						stringBuilder2 = stringBuilder;
						num = 235542393U * num;
						num2 = (int)(num + 2296297528U);
					}
					while (num == 1202400859U);
					while (356790209U + num != 0U)
					{
						int num3 = num2;
						num ^= 998643334U;
						if (num3 >= array.Length)
						{
							goto Block_5;
						}
						num = 195045938U;
						StringBuilder stringBuilder3 = stringBuilder2;
						num = 264261824U / num;
						byte[] array2 = array;
						num = (1153269240U | num);
						int num4 = num2;
						num += 1018784409U;
						string format = "x2";
						num = 307960769U % num;
						string value = array2[num4].ToString(format);
						num %= 788224568U;
						stringBuilder3.Append(value);
						if (num < 2007435431U)
						{
							int num5 = num2;
							int num6 = (int)(num ^ 307960768U);
							num = (344930513U ^ num);
							num2 = num5 + num6;
							num ^= 1911907544U;
						}
					}
				}
				Block_5:
				num = (1769896019U ^ num);
				IL_F3:
				string text = stringBuilder2.ToString();
				num = (630674273U & num);
				result = text;
			}
			finally
			{
				num = 581718392U;
				bool flag = md != null;
				num &= 359410068U;
				if (!flag)
				{
					goto IL_12C;
				}
				IL_11D:
				((IDisposable)md).Dispose();
				num += 0U;
				IL_12C:
				if ((1696493927U & num) == 0U)
				{
					goto IL_11D;
				}
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0004FA7C File Offset: 0x0004D07C
		public MD5Util()
		{
			uint num = 1844598298U;
			if (1028593239U != num)
			{
				num = (807409198U | num);
				base..ctor();
			}
		}
	}
}
