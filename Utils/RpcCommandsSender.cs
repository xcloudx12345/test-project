using System;
using GGD_Hack.RPC;
using Handlers.GameHandlers.PlayerHandlers;
using UnityEngine;

namespace GGD_Hack.Utils
{
	// Token: 0x0200000F RID: 15
	public class RpcCommandsSender
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0004FB04 File Offset: 0x0004D104
		public static void Kill(string userId)
		{
			uint num = 372000088U;
			RpcServer.RpcCommand command = (RpcServer.RpcCommand)(num ^ 372000088U);
			num = 1579118347U / num;
			RpcServer.SendCommand(command, userId, "");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0004FB34 File Offset: 0x0004D134
		public static void SuperBan(string userId)
		{
			uint num;
			do
			{
				RpcServer.RpcCommand command = RpcServer.RpcCommand.SendChat;
				num = 1975125747U;
				RpcServer.SendCommand(command, userId, "<size=99>a</size>");
			}
			while (num / 1571959410U == 0U);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0004FB60 File Offset: 0x0004D160
		public static void SendChat(string userId, string message)
		{
			uint num;
			do
			{
				num = 1222909450U;
				RpcServer.RpcCommand command = (RpcServer.RpcCommand)(num - 1222909446U);
				num >>= 27;
				num = 1046289530U % num;
				RpcServer.SendCommand(command, userId, message);
			}
			while (num + 1020226875U == 0U);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0004FBA0 File Offset: 0x0004D1A0
		public static void Ping()
		{
			uint num = 801537445U;
			if (645925211U < num)
			{
				for (;;)
				{
					float num2 = Time.time - RpcCommandsSender.lastPingTime;
					num = (995183631U | num);
					float num3 = RpcCommandsSender.minPingInterval;
					num <<= 21;
					if (num2 < num3)
					{
						return;
					}
					if ((2079151219U ^ num) != 0U)
					{
						RpcCommandsSender.lastPingTime = Time.time;
						RpcServer.RpcCommand command = (RpcServer.RpcCommand)(num ^ 3051356162U);
						LocalPlayer instance = LocalPlayer.Instance;
						num %= 668278779U;
						string userId = instance.Player.userId;
						num = (1060847922U & num);
						string data = "";
						num = (804732960U | num);
						RpcServer.SendCommand(command, userId, data);
						if (num > 366036537U)
						{
							break;
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0004FC54 File Offset: 0x0004D254
		// Note: this type is marked as 'beforefieldinit'.
		static RpcCommandsSender()
		{
			uint num2;
			do
			{
				float num = -1f;
				num2 = 532810484U;
				RpcCommandsSender.lastPingTime = num;
				num2 = 1994424008U * num2;
				if ((num2 ^ 1408368795U) == 0U)
				{
					break;
				}
				float num3 = 1f;
				num2 -= 1041137435U;
				RpcCommandsSender.minPingInterval = num3;
			}
			while (num2 == 616958404U);
		}

		// Token: 0x0400000F RID: 15
		public static float lastPingTime;

		// Token: 0x04000010 RID: 16
		public static float minPingInterval;
	}
}
