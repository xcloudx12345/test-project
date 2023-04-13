using System;
using Handlers.LobbyHandlers;
using UnityEngine;

namespace GGD_Hack.Utils
{
	// Token: 0x0200000E RID: 14
	public class RoleIcon
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0004FAA8 File Offset: 0x0004D0A8
		public static Sprite GetRoleIcon(int roleID)
		{
			LobbySceneHandler instance = LobbySceneHandler.Instance;
			uint num = 899571560U;
			if (instance == null)
			{
				return null;
			}
			UIRoleIconHandler uIRoleIconHandler = instance.uIRoleIconHandler;
			IPLJDOHJOLM ipljdohjolm = (short)roleID;
			num &= 578884101U;
			return uIRoleIconHandler.GetRoleIcon(ipljdohjolm);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0004FAE0 File Offset: 0x0004D0E0
		public RoleIcon()
		{
			uint num = 199981363U;
			do
			{
				base..ctor();
			}
			while (938692938U <= num);
		}
	}
}
