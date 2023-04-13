using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem.Collections.Generic;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack.Features
{
	// Token: 0x02000039 RID: 57
	[RegisterTypeInIl2Cpp]
	public class MinimapRecorder : MonoBehaviour
	{
		// Token: 0x060000DD RID: 221 RVA: 0x000552B0 File Offset: 0x000528B0
		public MinimapRecorder(IntPtr ptr)
		{
			uint num = 1800415574U;
			for (;;)
			{
				num %= 247347191U;
				this.recordInterval = 0.1f;
				num %= 582116710U;
				if (num / 1111167749U == 0U)
				{
					for (;;)
					{
						num %= 1806046348U;
						this.playersToRecord = new Dictionary<string, string>();
						if (num * 557413617U == 0U)
						{
							break;
						}
						this.records = new List<Dictionary<string, ValueTuple<string, Vector3>>>();
						num = (1302752163U & num);
						base..ctor(ptr);
						if (1416959660U >= num)
						{
							return;
						}
					}
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00055330 File Offset: 0x00052930
		public MinimapRecorder()
		{
			uint num = 830544384U;
			if (num << 6 == 0U)
			{
				goto IL_40;
			}
			do
			{
				IL_12:
				num >>= 5;
				float num2 = 0.1f;
				num &= 1505973882U;
				this.recordInterval = num2;
				num /= 791556979U;
			}
			while (num >= 1077572369U);
			IL_40:
			num &= 1326323891U;
			this.playersToRecord = new Dictionary<string, string>();
			if (num > 1963678120U)
			{
				goto IL_12;
			}
			do
			{
				num <<= 10;
				List<Dictionary<string, ValueTuple<string, Vector3>>> list = new List<Dictionary<string, ValueTuple<string, Vector3>>>();
				num = (365448666U ^ num);
				this.records = list;
				num = (1643804863U ^ num);
				if (num / 598692797U == 0U)
				{
					goto IL_12;
				}
				num |= 258426175U;
				base..ctor(ClassInjector.DerivedConstructorPointer<MinimapRecorder>());
				num %= 1817187605U;
			}
			while ((num ^ 405479611U) == 0U);
			num = 1957769931U - num;
			ClassInjector.DerivedConstructorBody(this);
			if (4343304U != num)
			{
				return;
			}
			goto IL_12;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0005540C File Offset: 0x00052A0C
		public static void Init()
		{
			for (;;)
			{
				string text = "ML_Manager";
				uint num = 2118139633U;
				GameObject gameObject = GameObject.Find(text);
				while (gameObject == null)
				{
					num |= 1289709538U;
					if (1635542203U != num)
					{
						IL_30:
						gameObject = new GameObject("ML_Manager");
						num %= 397173662U;
						Object.DontDestroyOnLoad(gameObject);
						num += 1975431444U;
						break;
					}
				}
				if (num > 1136033309U)
				{
					GameObject gameObject2 = gameObject;
					num = 851520909U << (int)num;
					Object component = gameObject2.GetComponent<MinimapRecorder>();
					num *= 1062020413U;
					Object @object = null;
					num = 867453808U + num;
					bool flag = component == @object;
					num |= 655039335U;
					if (flag)
					{
						if (num < 1917785782U)
						{
							goto IL_30;
						}
						MinimapRecorder instance = gameObject.AddComponent<MinimapRecorder>();
						num = (1341745901U & num);
						MinimapRecorder.Instance = instance;
						num += 2684752146U;
					}
					if ((num ^ 739379810U) != 0U)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000554E0 File Offset: 0x00052AE0
		public void StartRecording()
		{
			uint num = 1950825109U;
			if ((482368589U ^ num) != 0U)
			{
				goto IL_12;
			}
			goto IL_8C;
			Dictionary<string, PlayerController>.Enumerator enumerator;
			for (;;)
			{
				IL_25:
				Dictionary<string, PlayerController> playersList = PlayerController.playersList;
				num = (1841901344U ^ num);
				enumerator = playersList.GetEnumerator();
				if ((num & 581006828U) != 0U)
				{
					goto IL_44;
				}
			}
			IL_12:
			this.playersToRecord.Clear();
			num = (1666536296U & num);
			goto IL_25;
			IL_44:
			goto IL_11E;
			IL_8C:
			KeyValuePair<string, PlayerController> keyValuePair2;
			KeyValuePair<string, PlayerController> keyValuePair = keyValuePair2;
			num += 1753887064U;
			bool key = keyValuePair.Key != null;
			num -= 1353261571U;
			num ^= 2402245853U;
			if (key)
			{
				bool flag = keyValuePair2.Value == null;
				num += 0U;
				if (!flag)
				{
					KeyValuePair<string, PlayerController> keyValuePair3 = keyValuePair2;
					num += 1715238009U;
					PlayerController value = keyValuePair3.Value;
					num /= 1364395648U;
					Dictionary<string, string> dictionary = this.playersToRecord;
					num %= 44060453U;
					string userId = value.userId;
					num = (1165253146U & num);
					PlayerController playerController = value;
					num &= 684922612U;
					string nickname = playerController.nickname;
					num = (1587310675U ^ num);
					dictionary.Add(userId, nickname);
					num += 2934951117U;
				}
			}
			IL_11E:
			num = 405752953U - num;
			if (num << 6 != 0U)
			{
				Dictionary<string, PlayerController>.Enumerator enumerator2 = enumerator;
				num /= 2110947190U;
				if (!enumerator2.MoveNext())
				{
					if (2122861958U <= num)
					{
						goto IL_25;
					}
					this.records.Clear();
					float num2 = 0f;
					num += 1423383241U;
					this.recordTime = num2;
					if (num == 2007244349U)
					{
						goto IL_12;
					}
					MelonLogger.Msg("开始录制玩家位置！");
					num ^= 238575895U;
					if ((num ^ 2107864269U) == 0U)
					{
						goto IL_25;
					}
					num = 1067071719U % num;
					bool flag2 = (num ^ 1067071718U) != 0U;
					num = 7108499U >> (int)num;
					this.isRecording = flag2;
					if (num < 174744838U)
					{
						return;
					}
					goto IL_44;
				}
			}
			num = 1167744683U;
			if ((num ^ 1151625318U) == 0U)
			{
				goto IL_25;
			}
			Dictionary<string, PlayerController>.Enumerator enumerator3 = enumerator;
			num += 1155949450U;
			KeyValuePair<string, PlayerController> keyValuePair4 = enumerator3.Current;
			num |= 2101744319U;
			keyValuePair2 = keyValuePair4;
			num = (1793818280U & num);
			if (87259595U >> (int)num != 0U)
			{
				goto IL_8C;
			}
			goto IL_25;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000556B4 File Offset: 0x00052CB4
		public void StopRecording()
		{
			this.isRecording = false;
			uint num = 1000027044U;
			Dictionary<string, string> dictionary = this.playersToRecord;
			num &= 873600458U;
			dictionary.Clear();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000556E4 File Offset: 0x00052CE4
		public void RestartRecords()
		{
			uint num = 424222902U;
			string text = "正在重新开始录制玩家位置";
			num = 1646099188U - num;
			MelonLogger.Msg(text);
			if (num + 1194657044U != 0U)
			{
				do
				{
					num %= 675295834U;
					this.StartRecording();
				}
				while ((192941514U & num) == 0U);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00055730 File Offset: 0x00052D30
		public void RecordPositions()
		{
			Dictionary<string, ValueTuple<string, Vector3>> dictionary;
			Dictionary<string, PlayerController> playersList;
			uint num;
			do
			{
				dictionary = new Dictionary<string, ValueTuple<string, Vector3>>();
				playersList = PlayerController.playersList;
				num = 1987472224U;
			}
			while (433857424U / num != 0U);
			num = 2098809805U << (int)num;
			List<KeyValuePair<string, string>> list = this.playersToRecord.ToList<KeyValuePair<string, string>>();
			num = 1723229879U >> (int)num;
			List<KeyValuePair<string, string>>.Enumerator enumerator = list.GetEnumerator();
			num = 1564417155U + num;
			using (List<KeyValuePair<string, string>>.Enumerator enumerator2 = enumerator)
			{
				if (293551871 << (int)num == 0)
				{
					goto IL_A1;
				}
				IL_68:
				goto IL_217;
				IL_6D:
				num = 327222126U;
				if (num > 353910423U)
				{
					goto IL_DD;
				}
				num %= 1247501681U;
				KeyValuePair<string, string> keyValuePair = enumerator2.Current;
				num = (1455559541U & num);
				KeyValuePair<string, string> keyValuePair2 = keyValuePair;
				if (556022916U == num)
				{
					goto IL_68;
				}
				IL_A1:
				string key = keyValuePair2.Key;
				num <<= 29;
				string text = key;
				num ^= 1581740947U;
				if (1054937477U == num)
				{
					goto IL_6D;
				}
				string value = keyValuePair2.Value;
				num |= 718351841U;
				string item = value;
				num *= 245891749U;
				IL_DD:
				Dictionary<string, PlayerController> dictionary2 = playersList;
				num |= 1561360988U;
				string text2 = text;
				num |= 277893100U;
				if (dictionary2.ContainsKey(text2))
				{
					Dictionary<string, PlayerController> dictionary3 = playersList;
					string text3 = text;
					num <<= 28;
					Object @object = dictionary3[text3];
					Object object2 = null;
					num -= 957036333U;
					bool flag = @object == object2;
					num = 1648455087U / num;
					if (flag)
					{
						num += 2111668223U;
					}
					else
					{
						Dictionary<string, PlayerController> dictionary4 = playersList;
						num = 755179858U << (int)num;
						string text4 = text;
						num = (870476793U ^ num);
						PlayerController playerController = dictionary4[text4];
						num = 1019032293U >> (int)num;
						if (playerController.timeOfDeath != 0)
						{
							Dictionary<string, string> dictionary5 = this.playersToRecord;
							string key2 = text;
							num <<= 3;
							dictionary5.Remove(key2);
							num ^= 1568599814U;
							goto IL_217;
						}
						num = 1353802581U * num;
						if (1979723491U <= num)
						{
							Vector3 acgbaghofip = playerController.ACGBAGHOFIP;
							num -= 347621563U;
							Vector3 item2 = acgbaghofip;
							Dictionary<string, ValueTuple<string, Vector3>> dictionary6 = dictionary;
							string key3 = text;
							num = 1502873858U >> (int)num;
							dictionary6[key3] = new ValueTuple<string, Vector3>(item, item2);
							num ^= 1450234646U;
							goto IL_217;
						}
						goto IL_6D;
					}
				}
				num = 730687239U / num;
				num &= 139410429U;
				Dictionary<string, string> dictionary7 = this.playersToRecord;
				num = 800220005U + num;
				dictionary7.Remove(text);
				num >>= 2;
				if (1383544361U >= num)
				{
					num ^= 1454295791U;
				}
				IL_217:
				num = 923565290U >> (int)num;
				num = 534003751U << (int)num;
				bool flag2 = enumerator2.MoveNext();
				num = 1625579281U - num;
				if (flag2)
				{
					goto IL_6D;
				}
			}
			List<Dictionary<string, ValueTuple<string, Vector3>>> list2 = this.records;
			Dictionary<string, ValueTuple<string, Vector3>> item3 = dictionary;
			num = 2044810683U;
			list2.Add(item3);
			ConsoleColor consoleColor = (int)num + (ConsoleColor)(-2044810673);
			string str = "当前MinimapRecorder记录总数：";
			num = 1106709402U - num;
			num = 333533806U << (int)num;
			List<Dictionary<string, ValueTuple<string, Vector3>>> list3 = this.records;
			num = (272904570U | num);
			int count = list3.Count;
			num <<= 11;
			int num2 = count;
			num /= 121834201U;
			string text5 = str + num2.ToString();
			num = (543839185U | num);
			MelonLogger.Msg(consoleColor, text5);
			do
			{
				num <<= 25;
				this.recordTime += this.recordInterval;
			}
			while (1859286844U >= num);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00055A54 File Offset: 0x00053054
		private void Update()
		{
			uint num;
			for (;;)
			{
				num = 1522750794U;
				bool flag = this.isRecording;
				num <<= 26;
				if (!flag)
				{
					break;
				}
				float time = Time.time;
				num = 481638276U - num;
				float num2 = this.lastRecordTime;
				num = 797990214U << (int)num;
				object obj = time - num2;
				num %= 781528373U;
				float num3 = this.recordInterval;
				num *= 363552329U;
				if (obj < num3)
				{
					goto IL_94;
				}
				num = (2130206342U & num);
				this.RecordPositions();
				if (num * 1814959624U != 0U)
				{
					goto IL_71;
				}
			}
			return;
			IL_71:
			num >>= 7;
			float time2 = Time.time;
			num *= 823402945U;
			this.lastRecordTime = time2;
			num ^= 3338299158U;
			IL_94:
			if ((num ^ 1873231986U) != 0U)
			{
				return;
			}
			goto IL_71;
		}

		// Token: 0x0400014C RID: 332
		public static MinimapRecorder Instance;

		// Token: 0x0400014D RID: 333
		private bool isRecording;

		// Token: 0x0400014E RID: 334
		private float recordInterval;

		// Token: 0x0400014F RID: 335
		private float recordTime;

		// Token: 0x04000150 RID: 336
		private float lastRecordTime;

		// Token: 0x04000151 RID: 337
		private Dictionary<string, string> playersToRecord;

		// Token: 0x04000152 RID: 338
		[TupleElementNames(new string[]
		{
			"nickname",
			"position"
		})]
		private List<Dictionary<string, ValueTuple<string, Vector3>>> records;
	}
}
