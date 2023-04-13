using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using MelonLoader;
using UnityEngine;

namespace GGD_Hack.Utils
{
	// Token: 0x02000010 RID: 16
	public class SpriteUtil
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0004FCA4 File Offset: 0x0004D2A4
		public static Sprite GetSpriteFromImageName(string imageName)
		{
			uint num;
			for (;;)
			{
				Dictionary<string, Sprite> dictionary = SpriteUtil.spriteCache;
				num = 1349719340U;
				if (dictionary.ContainsKey(imageName))
				{
					num += 1224939031U;
					if (1302756425 << (int)num == 0)
					{
						continue;
					}
					Dictionary<string, Sprite> dictionary2 = SpriteUtil.spriteCache;
					num = 353132678U / num;
					Object @object = dictionary2[imageName];
					Object object2 = null;
					num = 1146307831U >> (int)num;
					bool flag = @object != object2;
					num += 203411509U;
					if (flag)
					{
						break;
					}
				}
				num &= 97859204U;
				if (1229088866U >= num)
				{
					goto Block_3;
				}
			}
			Dictionary<string, Sprite> dictionary3 = SpriteUtil.spriteCache;
			num += 129699324U;
			return dictionary3[imageName];
			Block_3:
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			num = 1046704356U % num;
			string str = "GGD_Hack.Resources.";
			num = (1936224181U & num);
			num = 1479544623U % num;
			string text = str + imageName;
			num %= 1353019415U;
			string text2 = text;
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text2);
			num = (711220913U ^ num);
			Stream stream = manifestResourceStream;
			Sprite result;
			try
			{
				for (;;)
				{
					bool flag2 = stream != null;
					num = (1339060873U | num);
					Texture2D texture2D;
					if (!flag2)
					{
						num |= 1106276711U;
						if (num < 1628584036U)
						{
							continue;
						}
						string str2 = "找不到嵌入式资源: ";
						num = (1778254047U & num);
						string text3 = str2 + text2;
						num %= 735729265U;
						MelonLogger.Error(text3);
						num = (1543713294U & num);
						if ((621098255U ^ num) != 0U)
						{
							break;
						}
					}
					else
					{
						int num2 = (int)(checked((IntPtr)stream.Length));
						num ^= 2041017409U;
						byte[] array = new byte[num2];
						num = 1233002682U >> (int)num;
						Stream stream2 = stream;
						num = 702768599U % num;
						byte[] buffer = array;
						num = (1754015244U & num);
						int offset = (int)(num ^ 0U);
						num *= 1102323496U;
						int num3 = array.Length;
						num = (809571214U & num);
						int count = num3;
						num -= 2017279985U;
						stream2.Read(buffer, offset, count);
						num <<= 28;
						texture2D = new Texture2D((int)(num - 4026531838U), (int)(num ^ 4026531842U));
						Texture2D texture2D2 = texture2D;
						num = (805380621U | num);
						ImageConversion.LoadImage(texture2D2, array);
					}
					float num4 = 0f;
					float num5 = 0f;
					float num6 = (float)texture2D.width;
					Texture texture = texture2D;
					num = 628902638U * num;
					Rect rect;
					rect..ctor(num4, num5, num6, (float)texture.height);
					if (num >= 310854170U)
					{
						Texture2D texture2D3 = texture2D;
						Rect rect2 = rect;
						num -= 2001359111U;
						Vector2 zero = Vector2.zero;
						num <<= 13;
						Sprite sprite = Sprite.Create(texture2D3, rect2, zero);
						num %= 28343089U;
						Sprite sprite2 = sprite;
						Object object3 = sprite2;
						num = 838823699U << (int)num;
						object3.name = imageName;
						Dictionary<string, Sprite> dictionary4 = SpriteUtil.spriteCache;
						num <<= 5;
						Sprite value = sprite2;
						num = 566511897U >> (int)num;
						dictionary4[imageName] = value;
						Object object4 = sprite2;
						num = (176649135U | num);
						Object.DontDestroyOnLoad(object4);
						num <<= 5;
						result = sprite2;
						if (943602208U < num)
						{
							goto Block_9;
						}
					}
				}
				Sprite sprite3 = null;
				num = 1345258889U >> (int)num;
				result = sprite3;
				Block_9:;
			}
			finally
			{
				do
				{
					num = 1359117893U;
					bool flag3 = stream != null;
					num += 1741754514U;
					if (flag3)
					{
						num = 1983666028U * num;
						if (num > 696912853U)
						{
							IDisposable disposable = stream;
							num = (1924677303U ^ num);
							disposable.Dispose();
							num += 3074171348U;
						}
					}
				}
				while (num < 89730557U);
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00050000 File Offset: 0x0004D600
		public SpriteUtil()
		{
			uint num;
			do
			{
				num = 1077961396U;
				base..ctor();
			}
			while (num * 1405099157U == 0U);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00050028 File Offset: 0x0004D628
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteUtil()
		{
			uint num = 1424689913U;
			do
			{
				Dictionary<string, Sprite> dictionary = new Dictionary<string, Sprite>();
				num ^= 1055085984U;
				SpriteUtil.spriteCache = dictionary;
			}
			while (14447995U == num);
		}

		// Token: 0x04000011 RID: 17
		public static Dictionary<string, Sprite> spriteCache;
	}
}
