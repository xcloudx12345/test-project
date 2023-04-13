using System;
using APIs.Photon;
using Handlers.CommonHandlers;
using Handlers.GameHandlers;
using Handlers.GameHandlers.PlayerHandlers;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Managers;
using Managers.GameManagers.EventsManagers;
using UnhollowerBaseLib;

namespace GGD_Hack
{
	// Token: 0x02000006 RID: 6
	public class PluginEventsManager
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0004DC34 File Offset: 0x0004B234
		public static void Throw_Bomb(string userId)
		{
			byte b = 48;
			uint num = 1903961U;
			num = 290608583U - num;
			Object @object = userId;
			num &= 1574198068U;
			PhotonEventAPI.SendEventToPlugin(b, @object, num - 286541860U != 0U);
			num = 172312610U / num;
			if (num % 1982430934U == 0U)
			{
				SoundHandler instance = SoundHandler.Instance;
				bool flag = (num ^ 1U) != 0U;
				num = (656696281U | num);
				instance.PlayMedium(flag);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0004DC98 File Offset: 0x0004B298
		public static void Report(string userId)
		{
			uint num;
			do
			{
				num = 573793139U;
				byte b = (byte)(num - 573793135U);
				num = 1799567564U % num;
				Object @object = userId;
				num &= 1339979409U;
				PhotonEventAPI.SendEventToPlugin(b, @object, num - 76023313U != 0U);
			}
			while (457582571U < num);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0004DCE0 File Offset: 0x0004B2E0
		public static void Generate_Bomb(string userId)
		{
			uint num = 5011864U;
			byte b = (byte)(num - 5011802U);
			num = 1113472867U << (int)num;
			PhotonEventAPI.SendEventToPlugin(b, userId, (num ^ 1660944384U) != 0U);
			num = 574430310U / num;
			if (1065834567U > num)
			{
				SoundHandler.Instance.PlayMedium(num - uint.MaxValue != 0U);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0004DD40 File Offset: 0x0004B340
		public static void Silence(string userId)
		{
			uint num = 1309478798U;
			byte b = (byte)(num - 1309478774U);
			num -= 993861782U;
			PhotonEventAPI.SendEventToPlugin(b, userId, (num ^ 315617016U) != 0U);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0004DD74 File Offset: 0x0004B374
		public static void Helium(string userId)
		{
			byte b = 46;
			uint num = 1662333615U;
			Object @object = userId;
			bool flag = num + 2632633681U != 0U;
			num *= 660948946U;
			PhotonEventAPI.SendEventToPlugin(b, @object, flag);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0004DDA4 File Offset: 0x0004B3A4
		public static void Kill(string userId, string stingerId = null)
		{
			uint num2;
			for (;;)
			{
				int num = 1;
				num2 = 153184723U;
				string[] array = new string[num];
				num2 <<= 5;
				int num3 = (int)(num2 ^ 606943840U);
				num2 |= 1719819431U;
				num2 >>= 30;
				array[num3] = userId;
				num2 >>= 15;
				string[] array2 = array;
				num2 ^= 536617481U;
				if (185298578U >> (int)num2 != 0U)
				{
					PluginEventsManager pluginEventsManager = MainManager.Instance.pluginEventsManager;
					num2 -= 1237351144U;
					Il2CppStringArray il2CppStringArray = array2;
					num2 += 715078542U;
					string text;
					if (stingerId == null)
					{
						num2 >>= 5;
						text = LocalPlayer.Instance.Player.stingerId;
					}
					else
					{
						text = stingerId;
						num2 ^= 14431674U;
					}
					num2 /= 1944408341U;
					pluginEventsManager.AOGMBHOEOOL(il2CppStringArray, text);
					if (878855698U > num2)
					{
						break;
					}
				}
			}
			SoundHandler instance = SoundHandler.Instance;
			num2 = 846687047U + num2;
			instance.PlayKillTarget();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0004DE78 File Offset: 0x0004B478
		public static void Eat(string userId)
		{
			uint num = 774987340U;
			byte b = (byte)(num ^ 774987359U);
			num /= 179388347U;
			Object @object = userId;
			num -= 1645701797U;
			bool flag = (num ^ 2649265503U) != 0U;
			num = 593628426U % num;
			PhotonEventAPI.SendEventToPlugin(b, @object, flag);
			SoundHandler instance = SoundHandler.Instance;
			num = (757664565U ^ num);
			instance.PlayChompEat();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0004DED0 File Offset: 0x0004B4D0
		public static void PelicanEat(string userId)
		{
			string[] array = new string[1];
			int num = 0;
			uint num2 = 1929346428U;
			num2 |= 1323715544U;
			array[num] = userId;
			num2 <<= 17;
			num2 = (314314691U ^ num2);
			byte b = (byte)(num2 - 3980660597U);
			num2 = (1341291942U & num2);
			PhotonEventAPI.SendEventToPlugin(b, userId, (num2 ^ 1296043394U) != 0U);
			num2 &= 1614679058U;
			SoundHandler.Instance.PlayChompEat();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0004DF3C File Offset: 0x0004B53C
		public static void Drag_Body(BodyHandler body)
		{
			uint num = 267867814U;
			if (1446983080U >= num)
			{
				MainManager instance = MainManager.Instance;
				num &= 659123073U;
				PluginEventsManager pluginEventsManager = instance.pluginEventsManager;
				num = (1373655122U & num);
				pluginEventsManager.BNPIDBHLEBC(body);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0004DF7C File Offset: 0x0004B57C
		public static void Drop_Body(BodyHandler body)
		{
			uint num;
			do
			{
				MainManager instance = MainManager.Instance;
				num = 1008538064U;
				instance.pluginEventsManager.MDEIHFLFGLO(body);
			}
			while (num / 100278075U == 0U);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0004DFAC File Offset: 0x0004B5AC
		public static void Infect(string userId)
		{
			PhotonEventAPI.SendEventToPlugin(32, userId, false);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0004DFC8 File Offset: 0x0004B5C8
		public static void Vent(string ventId)
		{
			uint num = 342778726U;
			byte b = (byte)(num ^ 342778721U);
			Object @object = ventId;
			bool flag = (num ^ 342778726U) != 0U;
			num <<= 21;
			PhotonEventAPI.SendEventToPlugin(b, @object, flag);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0004DFFC File Offset: 0x0004B5FC
		public static void Assasinate(string userId, int roldId)
		{
			uint num;
			do
			{
				PluginEventsManager pluginEventsManager = MainManager.Instance.pluginEventsManager;
				num = 1523065020U;
				num >>= 4;
				pluginEventsManager.OIKLNCHNNAN(userId, (short)roldId);
			}
			while (num == 2085688053U);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0004E034 File Offset: 0x0004B634
		public static void RingBell()
		{
			uint num;
			do
			{
				num = 2057570669U;
				byte b = (byte)(num ^ 2057570671U);
				Object @object = null;
				num = 1929720954U - num;
				PhotonEventAPI.SendEventToPlugin(b, @object, (num ^ 4167117581U) != 0U);
			}
			while (1135018498U >= num);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0004E070 File Offset: 0x0004B670
		public static void Kick_Player(string userId, string reason)
		{
			uint num = 1309040390U;
			PluginEventsManager pluginEventsManager = MainManager.Instance.pluginEventsManager;
			num = (1206530734U | num);
			pluginEventsManager.IGLGBEBKOPM(userId, reason);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0004E09C File Offset: 0x0004B69C
		public static void Move_Shuttle()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0004E0AC File Offset: 0x0004B6AC
		public static void Precursor(bool enable)
		{
			uint num = 1929074758U;
			do
			{
				MainManager instance = MainManager.Instance;
				num += 1980436707U;
				PluginEventsManager pluginEventsManager = instance.pluginEventsManager;
				num = 1798725813U % num;
				pluginEventsManager.AFBDLHKELGG(enable);
			}
			while (1439702701U > num);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0004E0EC File Offset: 0x0004B6EC
		public static void Settings_Update(Dictionary<string, float> newRoomSettings)
		{
			MainManager instance = MainManager.Instance;
			uint num = 1242695776U;
			PluginEventsManager pluginEventsManager = instance.pluginEventsManager;
			num >>= 15;
			num = 132663724U * num;
			pluginEventsManager.KNIMBEJDIPP(newRoomSettings);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0004E120 File Offset: 0x0004B720
		public static void HandleReconnectionData()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0004E130 File Offset: 0x0004B730
		public static void Complete_Task(string userId, string taskId, string s3 = "")
		{
			uint num = 1576212114U;
			do
			{
				MainManager instance = MainManager.Instance;
				num -= 828595737U;
				TaskEventsManager taskEventsManager = instance.taskEventsManager;
				num -= 1914896434U;
				num = 1094671722U / num;
				num = (1644830793U & num);
				taskEventsManager.OEJGOPFACBH(userId, taskId, s3);
			}
			while (1726238796U - num == 0U);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0004E184 File Offset: 0x0004B784
		public static void RevealRoleInternalLink(string userId, int roleId)
		{
			uint num;
			for (;;)
			{
				LocalPlayer instance = LocalPlayer.Instance;
				num = 1571504411U;
				PlayerController player = instance.Player;
				num = (1216954887U | num);
				if (player.userId == userId)
				{
					break;
				}
				if (932738236U != num)
				{
					PluginEventsManager pluginEventsManager = MainManager.Instance.pluginEventsManager;
					IPLJDOHJOLM ipljdohjolm = (short)roleId;
					num <<= 20;
					pluginEventsManager.NGCEEDDMGEH(userId, ipljdohjolm);
					if (num <= 1959339406U)
					{
						return;
					}
				}
			}
			if (944455223U + num != 0U)
			{
				return;
			}
		}
	}
}
