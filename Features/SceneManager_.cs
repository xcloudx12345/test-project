using System;
using HarmonyLib;
using MelonLoader;
using UnityEngine.SceneManagement;

namespace GGD_Hack.Features
{
	// Token: 0x0200003E RID: 62
	[HarmonyPatch(typeof(SceneManager), "Internal_SceneLoaded")]
	internal class SceneManager_
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00056FD0 File Offset: 0x000545D0
		private static void Postfix(Scene scene)
		{
			uint num = 1645155991U;
			if (num * 1921077378U != 0U)
			{
				goto IL_12;
			}
			do
			{
				IL_4E:
				MelonLogger.Msg("场景MenuScene已加载");
				num = 897585765U % num;
				if (1885217960U + num == 0U)
				{
					goto IL_12;
				}
				bool flag = RandomJoinRoom.CreateRandomJoinButton();
				num /= 1784481333U;
				if (!flag)
				{
					goto IL_95;
				}
				MelonLogger.Msg("已成功添加随机加入房间的按钮!");
			}
			while (523205782U - num == 0U);
			return;
			IL_95:
			string text = "添加随机加入房间的按钮失败!";
			num = (497878069U | num);
			MelonLogger.Warning(text);
			num += 305404748U;
			return;
			IL_12:
			num = 150231256U - num;
			string name = scene.name;
			num &= 214833122U;
			bool flag2 = name == "MenuScene";
			num = 803282817U << (int)num;
			if (flag2)
			{
				num = 1080034598U - num;
				goto IL_4E;
			}
		}
	}
}
