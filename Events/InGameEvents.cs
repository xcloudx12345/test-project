using System;
using MelonLoader;
using UnhollowerBaseLib;

namespace GGD_Hack.Events
{
	// Token: 0x02000069 RID: 105
	public class InGameEvents
	{
		// Token: 0x0600019B RID: 411 RVA: 0x0005FE30 File Offset: 0x0005D430
		public static void Start_Game()
		{
			uint num;
			do
			{
				ConsoleColor consoleColor = ConsoleColor.Green;
				num = 889919128U;
				MelonLogger.Msg(consoleColor, "游戏开始事件");
			}
			while (236138601U + num == 0U);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0005FE5C File Offset: 0x0005D45C
		public static void OnGameEnded()
		{
			MelonLogger.Msg(ConsoleColor.Green, "游戏结束");
			throw new NotImplementedException();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0005FE80 File Offset: 0x0005D480
		public static void Vent(string userId, string ventId)
		{
			uint num = 1378485253U;
			ConsoleColor consoleColor = (ConsoleColor)(num - 1378485243U);
			string text = "钻管道事件：玩家: {0} 管道id: {1}";
			num ^= 414135109U;
			int num2 = (int)(num ^ 1250244418U);
			num += 731320868U;
			object[] array = new object[num2];
			num ^= 1256787001U;
			int num3 = (int)(num ^ 1022707037U);
			num = 196766170U + num;
			array[num3] = userId;
			num = (1881760845U ^ num);
			int num4 = (int)(num - 948358009U);
			num = 1312442509U % num;
			array[num4] = ventId;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0005FEF4 File Offset: 0x0005D4F4
		public static void ForceExitVent(string userId, string ventId)
		{
			uint num = 15884981U;
			ConsoleColor consoleColor = (ConsoleColor)(num - 15884971U);
			string text = "强制移出管道事件：玩家: {0} 管道id: {1}";
			object[] array = new object[num ^ 15884983U];
			num = 628758922U >> (int)num;
			array[(int)(num ^ 299U)] = userId;
			num = 1545167247U >> (int)num;
			num = 1674252007U * num;
			array[(int)(num + 1284258637U)] = ventId;
			num = 1758690611U - num;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0005FF64 File Offset: 0x0005D564
		public static void Pelican_Eat(string playerEaten, string pelican = null)
		{
			ConsoleColor consoleColor = ConsoleColor.Green;
			uint num = 675035067U;
			string text = "鹈鹕吃人事件：鹈鹕：{0} 被吃的玩家: {1}";
			num |= 1097074328U;
			int num2 = (int)(num + 2525218887U);
			num &= 529689855U;
			object[] array = new object[num2];
			num = (1688872298U | num);
			int num3 = (int)(num ^ 1840915963U);
			bool flag = string.IsNullOrEmpty(pelican);
			num += 1830376293U;
			object obj;
			if (!flag)
			{
				num <<= 11;
				obj = pelican;
			}
			else
			{
				num = (661198457U ^ num);
				obj = "未知";
				num += 2651885799U;
			}
			array[num3] = obj;
			num >>= 17;
			array[(int)(num ^ 19940U)] = playerEaten;
			num = 832396214U + num;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00060000 File Offset: 0x0005D600
		public static void Turn_Invisible(string userId, bool invisible)
		{
			ConsoleColor consoleColor = ConsoleColor.Green;
			string text = "隐身事件：玩家:{0} 隐身中:{1}";
			uint num = 1867657817U;
			int num2 = (int)(num + 2427309481U);
			num = 1413162239U % num;
			object[] array = new object[num2];
			num += 118365814U;
			int num3 = (int)(num ^ 1531528053U);
			num = 204827618U << (int)num;
			array[num3] = userId;
			num ^= 639270520U;
			int num4 = (int)(num ^ 1515880057U);
			num = (1667700126U ^ num);
			object obj;
			if (!invisible)
			{
				obj = "否";
			}
			else
			{
				obj = "是";
				num += 0U;
			}
			array[num4] = obj;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0006008C File Offset: 0x0005D68C
		public static void Grab_Body(string undertakerUserId, string bodyUserId)
		{
			uint num = 945112937U;
			ConsoleColor consoleColor = (ConsoleColor)(num ^ 945112931U);
			string text = "开始拖拽尸体事件：丧葬者:{0} 被拖拽的尸体:{1}";
			num = 339805156U / num;
			object[] array = new object[num - 4294967294U];
			num = (417334357U & num);
			int num2 = (int)(num ^ 0U);
			num = (261955919U & num);
			num = (536242666U | num);
			array[num2] = undertakerUserId;
			num /= 1617039418U;
			int num3 = (int)(num ^ 1U);
			num = (1998260242U & num);
			array[num3] = bodyUserId;
			num = 481502234U << (int)num;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00060110 File Offset: 0x0005D710
		public static void Receive_Kill(string killerUserId, string killedUserId, string stingerId)
		{
			ConsoleColor consoleColor = ConsoleColor.Green;
			string text = "玩家被杀事件：击杀者:{0} 被杀者:{1} 死亡动画id:{2}";
			int num = 3;
			uint num2 = 133700310U;
			object[] array = new object[num];
			int num3 = (int)(num2 ^ 133700310U);
			num2 ^= 733965281U;
			bool flag = string.IsNullOrEmpty(killerUserId);
			num2 = 799293322U - num2;
			object obj;
			if (!flag)
			{
				num2 &= 307250105U;
				obj = killerUserId;
			}
			else
			{
				num2 = (494999615U ^ num2);
				obj = "未知";
				num2 += 3815926693U;
			}
			array[num3] = obj;
			num2 >>= 31;
			int num4 = (int)(num2 ^ 1U);
			num2 <<= 3;
			array[num4] = killedUserId;
			array[(int)(num2 ^ 2U)] = stingerId;
			num2 = (2131965746U | num2);
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000601A8 File Offset: 0x0005D7A8
		public static void Eat(string eater, string eated)
		{
			uint num;
			do
			{
				ConsoleColor consoleColor = ConsoleColor.Green;
				num = 1505326519U;
				string text = "尸体被吃事件：吃者:{0} 被吃者:{1}";
				num = (201992422U ^ num);
				object[] array = new object[num + 2857149105U];
				num = 408227009U >> (int)num;
				array[(int)(num ^ 3114U)] = eater;
				num %= 1304040798U;
				array[(int)(num ^ 3115U)] = eated;
				num = 895294658U % num;
				MelonLogger.Msg(consoleColor, text, array);
			}
			while (num > 651190115U);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00060218 File Offset: 0x0005D818
		public static void Morph(string from, string to)
		{
			uint num = 317991048U;
			ConsoleColor consoleColor = (int)num + (ConsoleColor)(-317991038);
			num = 1844006385U + num;
			string text = "变形事件：From:{0} To:{1}";
			int num2 = (int)(num + 2132969865U);
			num = 1993941006U / num;
			object[] array = new object[num2];
			num *= 977629728U;
			array[(int)(num ^ 0U)] = from;
			num <<= 16;
			int num3 = (int)(num + 1U);
			num *= 284885864U;
			array[num3] = to;
			num = 167515453U - num;
			MelonLogger.Msg(consoleColor, text, array);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0006028C File Offset: 0x0005D88C
		public static void Task_Completed(string userId, string taskId, int i, string tokenName, int earnedTokenNums)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0006029C File Offset: 0x0005D89C
		public static void Whistleblow_Bomb()
		{
			uint num;
			do
			{
				ConsoleColor consoleColor = ConsoleColor.Green;
				string text = "传递炸弹事件：{0}";
				num = 1951274211U;
				MelonLogger.Msg(consoleColor, text);
			}
			while (1829055837U > num);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000602C8 File Offset: 0x0005D8C8
		public static void Generate_Bomb(string userId)
		{
			uint num;
			do
			{
				num = 1349802683U;
				ConsoleColor consoleColor = (ConsoleColor)(num ^ 1349802673U);
				num = 2043164851U * num;
				string text = "生成炸弹事件：{0}";
				num += 2048152253U;
				object[] array = new object[num + 2342474883U];
				num |= 56369169U;
				int num2 = (int)(num ^ 2004659071U);
				num = (1863979925U ^ num);
				array[num2] = userId;
				MelonLogger.Msg(consoleColor, text, array);
			}
			while (num == 823337987U);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00060330 File Offset: 0x0005D930
		public static void Celebrity_Died()
		{
			uint num;
			do
			{
				ConsoleColor consoleColor = ConsoleColor.Green;
				num = 245171277U;
				string text = "网红死亡事件";
				num <<= 17;
				MelonLogger.Msg(consoleColor, text);
			}
			while (num == 2083674631U);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00060364 File Offset: 0x0005D964
		public static void Server_Send_Role(Il2CppStringArray userIdArray, Il2CppStringArray roleIdArray, Il2CppStringArray taskIdArray)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00060374 File Offset: 0x0005D974
		public InGameEvents()
		{
			uint num = 2063341374U;
			do
			{
				num += 553801591U;
				base..ctor();
			}
			while (num << 8 == 0U);
		}
	}
}
