using System;
using Handlers.MenuSceneHandlers;
using TMPro;

namespace GGD_Hack.Utils
{
	// Token: 0x0200000C RID: 12
	public class JoinRoom
	{
		// Token: 0x0600005B RID: 91 RVA: 0x0004F894 File Offset: 0x0004CE94
		public static void Join(string roomCode)
		{
			uint num = 1556638505U;
			TMP_InputField roomIdIF = MenuSceneHandler.Instance.roomIdIF;
			num = 1519724548U + num;
			roomIdIF.text = roomCode;
			MenuSceneHandler.Instance.JoinRoom();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0004F8CC File Offset: 0x0004CECC
		public static void Refresh()
		{
			uint num = 226832705U;
			MenuSceneHandler instance = MenuSceneHandler.Instance;
			num = 264981567U / num;
			instance.RefreshRooms();
		}
	}
}
