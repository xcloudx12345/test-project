using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using APIs.Photon;
using Handlers.PrefabAttachedHandlers;
using HarmonyLib;
using Il2CppSystem;
using MelonLoader;
using UnhollowerBaseLib;

namespace GGD_Hack.AntiSell
{
	// Token: 0x0200006D RID: 109
	public class MessageSensor
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000614B8 File Offset: 0x0005EAB8
		public static bool IsSpamming
		{
			get
			{
				return MessageSensor.spamDetector.isSpamming;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000614D0 File Offset: 0x0005EAD0
		public MessageSensor()
		{
			uint num;
			do
			{
				num = 1995537315U;
				base..ctor();
			}
			while (num < 76163323U);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000614F4 File Offset: 0x0005EAF4
		// Note: this type is marked as 'beforefieldinit'.
		static MessageSensor()
		{
			uint num = 1666124355U;
			string text = "免费mod群277392777";
			num = (587950769U ^ num);
			MessageSensor.spammingReplacement = text;
			num &= 1968856643U;
			if (num >> 8 == 0U)
			{
				goto IL_56;
			}
			IL_2C:
			string regex = "[ 0-9]{6,}";
			num = 1911830366U + num;
			MessageSensor.SensorMessageHacker sensorMessageHacker = new MessageSensor.SensorMessageHacker(regex, "277392777");
			num = 654713020U >> (int)num;
			MessageSensor.sensorMessageHacker = sensorMessageHacker;
			IL_56:
			num = 746984749U * num;
			int detectSize = (int)(num - 3475713290U);
			num /= 1853294576U;
			int ignoreMessagesLessThan = (int)(num ^ 13U);
			double similarityThreshold = 0.8;
			num += 864693389U;
			SpamDetector spamDetector = new SpamDetector(detectSize, ignoreMessagesLessThan, similarityThreshold);
			num >>= 20;
			MessageSensor.spamDetector = spamDetector;
			if ((num ^ 1920663925U) != 0U)
			{
				return;
			}
			goto IL_2C;
		}

		// Token: 0x040001AC RID: 428
		public static string spammingReplacement;

		// Token: 0x040001AD RID: 429
		public static MessageSensor.SensorMessageHacker sensorMessageHacker;

		// Token: 0x040001AE RID: 430
		public static SpamDetector spamDetector;

		// Token: 0x020000C4 RID: 196
		public class SensorMessageHacker
		{
			// Token: 0x06000277 RID: 631 RVA: 0x00068364 File Offset: 0x00065964
			public SensorMessageHacker(string regex, string replaceWith)
			{
				uint num = 356393573U;
				if ((num & 869230525U) != 0U)
				{
					do
					{
						num += 1375484785U;
						Dictionary<string, string> dictionary = new Dictionary<string, string>();
						num = 393881345U << (int)num;
						this.hackedStrings = dictionary;
						base..ctor();
						do
						{
							this.ruleRegex = regex;
							num = 622814921U + num;
						}
						while (num / 1673942006U == 0U);
						num = 184952241U >> (int)num;
						this.replaceWith = replaceWith;
					}
					while ((556280668U & num) == 0U);
				}
			}

			// Token: 0x06000278 RID: 632 RVA: 0x000683E8 File Offset: 0x000659E8
			public string Hack(string message)
			{
				uint num = 153379945U;
				num = 1382288713U % num;
				string text2;
				if (num + 367094883U != 0U)
				{
					num %= 62939905U;
					string text = Regex.Replace(message, this.ruleRegex, this.replaceWith);
					num <<= 10;
					text2 = text;
					num = (496267837U | num);
				}
				string b = text2;
				num -= 973477042U;
				bool flag = message != b;
				num = (1662139724U & num);
				if (flag)
				{
					num = 1713470815U >> (int)num;
					num -= 691501409U;
					Dictionary<string, string> dictionary = this.hackedStrings;
					string key = text2;
					num = 409304761U - num;
					num = (801590912U ^ num);
					dictionary[key] = message;
					num ^= 803308821U;
				}
				return text2;
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00068494 File Offset: 0x00065A94
			public string Unhack(string possibleModifiedString)
			{
				uint num = 1859858658U;
				if (402093546U != num)
				{
					num = 2021200044U + num;
					Dictionary<string, string> dictionary = this.hackedStrings;
					num *= 1238699736U;
					if (!dictionary.ContainsKey(possibleModifiedString))
					{
						return possibleModifiedString;
					}
				}
				num *= 1076498845U;
				Dictionary<string, string> dictionary2 = this.hackedStrings;
				num = (1534089524U ^ num);
				return dictionary2[possibleModifiedString];
			}

			// Token: 0x040001F4 RID: 500
			private string ruleRegex;

			// Token: 0x040001F5 RID: 501
			private string replaceWith;

			// Token: 0x040001F6 RID: 502
			public Dictionary<string, string> hackedStrings;
		}

		// Token: 0x020000C5 RID: 197
		[HarmonyPatch(typeof(PhotonEventAPI), "SendEventToPlugin")]
		public class SendChatMessageEvent_
		{
			// Token: 0x0600027A RID: 634 RVA: 0x000684F4 File Offset: 0x00065AF4
			private static void Prefix(byte __0, ref Object __1, bool __2)
			{
				try
				{
					uint num = 282007817U;
					for (;;)
					{
						IL_06:
						num = (1226263786U & num);
						if ((uint)__0 != (num ^ 460874U) && num != 48045277U)
						{
							break;
						}
						if ((1946508660U & num) != 0U)
						{
							IntPtr pointer = __1.Pointer;
							num -= 1830307072U;
							Il2CppStringArray il2CppStringArray = new Il2CppStringArray(pointer);
							num = 850010021U >> (int)num;
							Il2CppStringArray il2CppStringArray2 = il2CppStringArray;
							Il2CppArrayBase<string> il2CppArrayBase = il2CppStringArray2;
							num *= 192706339U;
							string text = il2CppArrayBase[(int)(num - 1342548797U)];
							num -= 245716728U;
							for (;;)
							{
								MessageSensor.SensorMessageHacker sensorMessageHacker = MessageSensor.sensorMessageHacker;
								num = (951071961U ^ num);
								string message = text;
								num = (1327659817U ^ num);
								string text2 = sensorMessageHacker.Hack(message);
								num = 1402024607U + num;
								if (num * 1992259845U == 0U)
								{
									goto IL_06;
								}
								SpamDetector spamDetector = MessageSensor.spamDetector;
								num >>= 8;
								string message2 = text;
								num = 1457675144U + num;
								spamDetector.AddMessage(message2);
								if (num + 1297445756U == 0U)
								{
									goto IL_26;
								}
								string a = text;
								string b = text2;
								num /= 1904243158U;
								if (!(a != b))
								{
									break;
								}
								if (1020354051U < num)
								{
									goto IL_06;
								}
								StringBuilder stringBuilder = new StringBuilder();
								num = 434380747U + num;
								string value = "检测到违规词，正在修改...";
								num >>= 18;
								stringBuilder.AppendLine(value);
								num >>= 24;
								num = 222773712U + num;
								string str = "原始消息：";
								num -= 1031022469U;
								string str2 = text;
								num *= 1627152177U;
								string value2 = str + str2;
								num = (1658081677U | num);
								stringBuilder.AppendLine(value2);
								num = (1713848894U | num);
								stringBuilder.AppendLine("和谐后：" + text2);
								num = 537155498U * num;
								Il2CppArrayBase<string> il2CppArrayBase2 = il2CppStringArray2;
								num = (392315185U & num);
								int num2 = (int)(num + 3942498288U);
								num = (199303625U | num);
								il2CppArrayBase2[num2] = text2;
								if (num / 915348057U == 0U)
								{
									goto Block_8;
								}
							}
							IL_1C1:
							if (num != 1272583754U)
							{
								break;
							}
							continue;
							Block_8:
							Il2CppObjectBase il2CppObjectBase = il2CppStringArray2;
							num %= 1036090349U;
							IntPtr pointer2 = il2CppObjectBase.Pointer;
							num ^= 775431107U;
							Object @object = new Object(pointer2);
							num = (1516976810U ^ num);
							__1 = @object;
							num += 2488239952U;
							goto IL_1C1;
						}
					}
					IL_26:;
				}
				catch (Exception ex)
				{
					uint num = 1928017820U;
					if (num * 1824027464U != 0U)
					{
						do
						{
							string text3 = "错误消息";
							num = (1451695352U ^ num);
							MelonLogger.Warning(text3);
						}
						while (1553730182U < num);
					}
				}
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00068724 File Offset: 0x00065D24
			public SendChatMessageEvent_()
			{
				uint num = 1387549275U;
				do
				{
					num <<= 27;
					base..ctor();
				}
				while ((num ^ 1462853084U) == 0U);
			}
		}

		// Token: 0x020000C6 RID: 198
		[HarmonyPatch(typeof(MessagePrefabHandler), "Initialize")]
		public class MessagePrefabHandler_
		{
			// Token: 0x0600027C RID: 636 RVA: 0x00068754 File Offset: 0x00065D54
			private static void Prefix(MessagePrefabHandler __instance)
			{
				try
				{
					uint num;
					string message;
					StringBuilder stringBuilder2;
					for (;;)
					{
						IL_00:
						num = 1938377399U;
						message = __instance.message;
						num *= 469519236U;
						for (;;)
						{
							MessageSensor.SensorMessageHacker sensorMessageHacker = MessageSensor.sensorMessageHacker;
							string possibleModifiedString = message;
							num = (1241263239U | num);
							string message2 = sensorMessageHacker.Unhack(possibleModifiedString);
							num %= 102368626U;
							__instance.message = message2;
							StringBuilder stringBuilder = new StringBuilder();
							num = (598689337U ^ num);
							stringBuilder2 = stringBuilder;
							for (;;)
							{
								stringBuilder2.AppendLine("--------------------");
								num = (1659440957U | num);
								if (num * 847604393U == 0U)
								{
									break;
								}
								StringBuilder stringBuilder3 = stringBuilder2;
								string value = "void Handlers.PrefabAttachedHandlers.MessagePrefabHandler::Initialize()";
								num /= 1096697914U;
								stringBuilder3.AppendLine(value);
								num <<= 21;
								if (328226119U <= num)
								{
									goto IL_00;
								}
								StringBuilder stringBuilder4 = stringBuilder2;
								num *= 1240623659U;
								StringBuilder stringBuilder5 = stringBuilder4.Append("- __instance: ");
								num = (431500574U ^ num);
								num = 681711459U + num;
								stringBuilder5.AppendLine(__instance.ToString());
								num &= 957241324U;
								if (!(message != __instance.message))
								{
									goto IL_138;
								}
								if (887954824U % num != 0U)
								{
									goto Block_4;
								}
							}
						}
					}
					Block_4:
					StringBuilder stringBuilder6 = stringBuilder2;
					num -= 1611537022U;
					stringBuilder6.AppendLine("真实文本：" + message);
					num = 2127375626U + num;
					num = 708079278U - num;
					StringBuilder stringBuilder7 = stringBuilder2;
					string str = "本地修改为：";
					num = 1835466844U + num;
					string message3 = __instance.message;
					num = (394479639U | num);
					stringBuilder7.AppendLine(str + message3);
					num += 2302076033U;
					IL_138:;
				}
				catch (Exception ex)
				{
					uint num = 2140668944U;
					Exception ex2 = ex;
					num |= 512309297U;
					do
					{
						string format = "Exception in patch of void Handlers.PrefabAttachedHandlers.MessagePrefabHandler::Initialize():\n{0}";
						object arg = ex2;
						num %= 1318326116U;
						string text = string.Format(format, arg);
						num = 1640770226U + num;
						MelonLogger.Warning(text);
					}
					while (1907647398U - num == 0U);
				}
			}

			// Token: 0x0600027D RID: 637 RVA: 0x000688FC File Offset: 0x00065EFC
			public MessagePrefabHandler_()
			{
				uint num = 1853389129U;
				if (num < 1974403992U)
				{
					do
					{
						num = 475282871U << (int)num;
						base..ctor();
					}
					while (451674890U % num == 0U);
				}
			}
		}
	}
}
