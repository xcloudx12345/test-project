using System;
using Handlers.LobbyHandlers;

namespace GGD_Hack.Features
{
	// Token: 0x0200003B RID: 59
	public class MiscFunctions
	{
		// Token: 0x060000EC RID: 236 RVA: 0x0005612C File Offset: 0x0005372C
		public static void MoveShuttle()
		{
			uint num = 1938709545U;
			bool enable = num - 1938709544U != 0U;
			num *= 207448391U;
			PluginEventsManager.Precursor(enable);
			num = 1556052090U % num;
			SendEventToPlugin.MOVE_SHUTTLE();
			do
			{
				num = (154023562U & num);
				bool enable2 = num + 4157722614U != 0U;
				num = 65606456U << (int)num;
				PluginEventsManager.Precursor(enable2);
			}
			while (841559098U + num == 0U);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00056190 File Offset: 0x00053790
		public static void Suicide()
		{
			string roomMap = LobbySceneHandler.Instance.roomMap;
			uint num = 1581334027U;
			uint num2 = (uint)int.Parse(roomMap);
			num <<= 24;
			if (num2 == num - 184549368U)
			{
				SendEventToPlugin.SPECIAL_KILL((int)(num ^ 184549383U));
				return;
			}
			SendEventToPlugin.SPECIAL_KILL((int)(num - 184549369U));
		}
	}
}
