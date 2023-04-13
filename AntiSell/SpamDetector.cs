using System;
using System.Collections.Generic;

namespace GGD_Hack.AntiSell
{
	// Token: 0x0200006F RID: 111
	public class SpamDetector
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00062180 File Offset: 0x0005F780
		public SpamDetector(int detectSize, int ignoreMessagesLessThan, double similarityThreshold)
		{
			uint num = 1259226408U;
			if (986659949U != num)
			{
				do
				{
					num = 1172583796U << (int)num;
					this.ignoreMessagesLessThan = (int)(num + 466258956U);
					num *= 1464665504U;
					if (1376611033U <= num)
					{
						num >>= 18;
						base..ctor();
					}
					num = 1279075325U >> (int)num;
					this.detectSize = detectSize;
					num = 1083850911U * num;
					num = 1270951498U - num;
					this.ignoreMessagesLessThan = ignoreMessagesLessThan;
					num %= 2015510603U;
					num += 663041995U;
					num = (454444998U | num);
					this.similarityThreshold = similarityThreshold;
					this.messages = new Queue<string>();
				}
				while (2005096788U > num);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0006223C File Offset: 0x0005F83C
		public void AddMessage(string message)
		{
			while (message.Length >= this.ignoreMessagesLessThan)
			{
				uint num = 1888102103U;
				if ((2030518965U & num) != 0U)
				{
					Queue<string> queue = this.messages;
					num %= 1353806639U;
					int count = queue.Count;
					num = 2119833377U * num;
					int num2 = this.detectSize;
					num &= 1297704690U;
					if (count >= num2)
					{
						if (284372808U > num)
						{
							goto IL_9D;
						}
						num = 456288640U + num;
						this.messages.Dequeue();
						num += 1039168647U;
						num ^= 3911540231U;
					}
					num %= 1620077280U;
					Queue<string> queue2 = this.messages;
					num /= 1890940684U;
					queue2.Enqueue(message);
					IL_9D:
					num ^= 636506800U;
					num = 248868598U / num;
					bool flag = this.IsSpamming();
					num /= 654464904U;
					this.isSpamming = flag;
					return;
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0006230C File Offset: 0x0005F90C
		private bool IsSpamming()
		{
			uint num;
			for (;;)
			{
				IL_00:
				num = 1244141009U;
				Queue<string> queue = this.messages;
				num /= 101402801U;
				int count = queue.Count;
				num += 920336686U;
				num %= 314067996U;
				int num2 = this.detectSize;
				num %= 1576166660U;
				if (count < num2)
				{
					break;
				}
				IEnumerable<string> collection = this.messages;
				num = 1020741012U / num;
				List<string> list = new List<string>(collection);
				for (;;)
				{
					IL_61:
					List<string> list2 = list;
					num = 1941705024U >> (int)num;
					int count2 = list2.Count;
					num %= 1707703375U;
					int num3 = (int)(num - 242713128U);
					num -= 1415931282U;
					int num4 = num3;
					if (num >> 6 == 0U)
					{
						break;
					}
					for (;;)
					{
						int num5 = num4;
						int num6 = count2;
						num ^= 225649141U;
						if (num5 >= num6)
						{
							goto Block_8;
						}
						num = 686909417U;
						if (num == 1165771130U)
						{
							goto IL_00;
						}
						int num7 = num4 + (int)(num ^ 686909416U);
						num = 1881166089U * num;
						int num8 = num7;
						for (;;)
						{
							num |= 156390700U;
							if (1702972700U >= num)
							{
								goto IL_00;
							}
							int num9 = num8;
							int num10 = count2;
							num ^= 1769757281U;
							if (num9 >= num10)
							{
								break;
							}
							num = 1031884596U;
							if (num >= 1348879395U)
							{
								goto IL_61;
							}
							List<string> list3 = list;
							num <<= 16;
							int index = num4;
							num >>= 9;
							string text = list3[index];
							num -= 731730063U;
							string s = text;
							List<string> list4 = list;
							num <<= 28;
							string text2 = list4[num8];
							num += 242487423U;
							string t = text2;
							num = (256389475U | num);
							num &= 1470041841U;
							double num11 = this.ComputeLevenshteinSimilarity(s, t);
							double num12 = this.similarityThreshold;
							num += 739802468U;
							if (num11 > num12)
							{
								goto Block_4;
							}
							num8 += (int)(num ^ 1127513556U);
							num += 2085151324U;
						}
						num /= 780159943U;
						if (num > 632448792U)
						{
							goto IL_00;
						}
						int num13 = num4;
						int num14 = (int)(num + 4294967293U);
						num = (45880410U ^ num);
						int num15 = num13 + num14;
						num = 304222400U - num;
						num4 = num15;
						num ^= 3044532468U;
					}
				}
			}
			num = (1766920723U & num);
			return num + 4273995774U != 0U;
			Block_4:
			num = 2068784122U % num;
			return num - 941270564U != 0U;
			Block_8:
			return num + 1218364061U != 0U;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000624F0 File Offset: 0x0005FAF0
		private double ComputeJaccardSimilarity(string s, string t)
		{
			uint num = 1907892652U;
			char[] separator = Array.Empty<char>();
			num *= 1680099193U;
			IEnumerable<string> collection = s.Split(separator);
			num <<= 4;
			HashSet<string> collection2 = new HashSet<string>(collection);
			num = (1738163365U | num);
			char[] separator2 = Array.Empty<char>();
			num -= 846615425U;
			HashSet<string> hashSet = new HashSet<string>(t.Split(separator2));
			num /= 1383169435U;
			HashSet<string> other = hashSet;
			num = 804351834U + num;
			HashSet<string> hashSet2 = new HashSet<string>(collection2);
			num *= 1150902272U;
			HashSet<string> hashSet3 = hashSet2;
			HashSet<string> hashSet4 = hashSet3;
			num -= 550326865U;
			hashSet4.UnionWith(other);
			HashSet<string> hashSet5 = new HashSet<string>(collection2);
			hashSet5.IntersectWith(other);
			double num2 = (double)hashSet5.Count;
			num -= 877737559U;
			HashSet<string> hashSet6 = hashSet3;
			num = 932531300U - num;
			double count = (double)hashSet6.Count;
			num ^= 519186730U;
			double num3 = count;
			num %= 271000042U;
			return num2 / num3;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000625AC File Offset: 0x0005FBAC
		private double ComputeLevenshteinSimilarity(string s, string t)
		{
			int length;
			uint num;
			int num2;
			int[,] array2;
			for (;;)
			{
				IL_00:
				length = s.Length;
				for (;;)
				{
					IL_08:
					int length2 = t.Length;
					num = 2088191374U;
					num2 = length2;
					if ((num ^ 1261658113U) == 0U)
					{
						break;
					}
					for (;;)
					{
						IL_22:
						int num3 = length;
						num += 33293617U;
						int num4 = (int)(num ^ 2121484990U);
						num = (1803581277U ^ num);
						int num5 = num3 + num4;
						num = 483817334U >> (int)num;
						int num6 = num2;
						int num7 = (int)(num - 120954332U);
						num ^= 332756829U;
						int num8 = num6 + num7;
						num = 636503049U + num;
						int[,] array = new int[num5, num8];
						num = (211031824U ^ num);
						array2 = array;
						for (;;)
						{
							IL_73:
							num = 63506646U * num;
							int num9 = (int)(num ^ 2345397734U);
							if (num < 2082475889U)
							{
								goto IL_00;
							}
							for (;;)
							{
								num *= 1615540682U;
								if (705695559U > num)
								{
									goto IL_00;
								}
								if (num9 > length)
								{
									break;
								}
								int[,] array3 = array2;
								int num10 = num9;
								num = 130944063U;
								int num11 = (int)(num ^ 130944063U);
								int num12 = num9;
								num %= 1208763844U;
								array3[num10, num11] = num12;
								num |= 631526429U;
								int num13 = num9;
								int num14 = (int)(num + 3625034690U);
								num += 1999055202U;
								int num15 = num13 + num14;
								num = 24789299U << (int)num;
								num9 = num15;
								num += 2295819136U;
							}
							int num16 = (int)(num ^ 1238678908U);
							num = 1765496958U + num;
							int num17 = num16;
							for (;;)
							{
								num = 310211556U * num;
								int num18 = num17;
								num = (1895188697U | num);
								if (num18 > num2)
								{
									break;
								}
								num = 1378627411U;
								if (1966290027 << (int)num == 0)
								{
									goto IL_22;
								}
								int[,] array4 = array2;
								int num19 = (int)(num + 2916339885U);
								int num20 = num17;
								num &= 1422983793U;
								array4[num19, num20] = num17;
								num <<= 18;
								int num21 = num17;
								num = (838213310U ^ num);
								int num22 = num21 + (int)(num ^ 951197375U);
								num = (514926129U & num);
								num17 = num22;
								num += 2589986762U;
							}
							num = 103636426U % num;
							int num23 = (int)(num + 4191330871U);
							num *= 43070889U;
							int num24 = num23;
							for (;;)
							{
								num = (1109416217U ^ num);
								int num25 = num24;
								num = 930230983U % num;
								int num26 = num2;
								num -= 1021845741U;
								if (num25 > num26)
								{
									goto Block_13;
								}
								num = 940121203U;
								int num27 = (int)(num ^ 940121202U);
								num >>= 9;
								int num28 = num27;
								for (;;)
								{
									num ^= 1999332988U;
									if (num <= 855146478U)
									{
										goto IL_73;
									}
									int num29 = num28;
									num *= 124652250U;
									int num30 = length;
									num = 1377251725U + num;
									if (num29 > num30)
									{
										break;
									}
									num = 1657549227U;
									if (num == 2094561263U)
									{
										goto IL_22;
									}
									num %= 628236242U;
									uint num31 = num28;
									num = 1209885235U + num;
									int index = num31 - (num ^ 1610961979U);
									num = 368666181U + num;
									char c = s[index];
									num %= 1319913288U;
									num = 572529851U * num;
									uint num32 = num24;
									num /= 63836344U;
									int index2 = num32 - (num + 4294967267U);
									num = 1231757640U * num;
									char c2 = t[index2];
									num <<= 3;
									if (c == c2)
									{
										int[,] array5 = array2;
										int num33 = num28;
										int num34 = num24;
										num = 1013318636U / num;
										int[,] array6 = array2;
										num &= 1885755136U;
										int num35 = num28;
										int num36 = (int)(num - uint.MaxValue);
										num = 34175037U << (int)num;
										int num37 = num35 - num36;
										int num38 = num24;
										num = 1087706754U << (int)num;
										int num39 = array6[num37, num38 - (int)(num - 1073741823U)];
										num = 1845384317U << (int)num;
										array5[num33, num34] = num39;
										if ((537012011U ^ num) == 0U)
										{
											goto IL_08;
										}
									}
									else
									{
										num -= 611936510U;
										if (num <= 664417271U)
										{
											goto IL_08;
										}
										int[,] array7 = array2;
										int num40 = num28;
										int num41 = num24;
										num = 1346528913U % num;
										int[,] array8 = array2;
										num = 1527869968U / num;
										int num42 = num28;
										num -= 1485570719U;
										int val = array8[num42 - (int)(num ^ 2809396579U), num24];
										num /= 2145670821U;
										int[,] array9 = array2;
										num = (1257381961U ^ num);
										int num43 = num28;
										int num44 = num24;
										int num45 = (int)(num ^ 1257381961U);
										num *= 1758027380U;
										int num46 = num44 - num45;
										num >>= 29;
										int val2 = array9[num43, num46];
										int[,] array10 = array2;
										num %= 394070781U;
										int num47 = num28;
										num = 351541295U - num;
										int num48 = (int)(num ^ 351541293U);
										num /= 204023388U;
										int num49 = num47 - num48;
										int num50 = num24;
										num ^= 1164526817U;
										int val3 = Math.Min(val2, array10[num49, num50 - (int)(num - 1164526815U)]);
										num = 1465348559U - num;
										int num51 = Math.Min(val, val3);
										int num52 = (int)(num ^ 300821742U);
										num = (1257468847U & num);
										array7[num40, num41] = num51 + num52;
										num += 1830564814U;
									}
									num /= 986455906U;
									if (633038634U == num)
									{
										goto IL_00;
									}
									int num53 = num28;
									int num54 = (int)(num - 0U);
									num = 1605909810U + num;
									num28 = num53 + num54;
									num ^= 1604598205U;
								}
								if (1747142331U <= num)
								{
									goto IL_00;
								}
								int num55 = num24;
								int num56 = (int)(num ^ 588965792U);
								num |= 1950683721U;
								num24 = num55 + num56;
								num += 3026699377U;
							}
						}
					}
					Block_13:
					num = 1817454740U << (int)num;
					if (1391998993U >> (int)num != 0U)
					{
						goto Block_14;
					}
				}
			}
			Block_14:
			double num57 = 1.0;
			int[,] array11 = array2;
			int num58 = length;
			int num59 = num2;
			num = (1519801576U | num);
			double num60 = (double)array11[num58, num59];
			num = (115817586U & num);
			double num61 = num60;
			int val4 = length;
			int val5 = num2;
			num |= 1452807018U;
			double num62 = (double)Math.Max(val4, val5);
			num = 184185942U + num;
			double num63 = num62;
			num >>= 0;
			double num64 = num61 / num63;
			num ^= 982455306U;
			return num57 - num64;
		}

		// Token: 0x040001AF RID: 431
		public bool isSpamming;

		// Token: 0x040001B0 RID: 432
		private int detectSize;

		// Token: 0x040001B1 RID: 433
		private int ignoreMessagesLessThan;

		// Token: 0x040001B2 RID: 434
		private double similarityThreshold;

		// Token: 0x040001B3 RID: 435
		private Queue<string> messages;
	}
}
