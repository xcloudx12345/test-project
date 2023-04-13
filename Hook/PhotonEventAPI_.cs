using System;
using APIs.Photon;
using ExitGames.Client.Photon;
using HarmonyLib;
using MelonLoader;

namespace GGD_Hack.Hook
{
	// Token: 0x02000020 RID: 32
	public class PhotonEventAPI_
	{
		// Token: 0x02000081 RID: 129
		[HarmonyPatch(typeof(PhotonEventAPI), "OnEvent", new Type[]
		{
			typeof(EventData)
		})]
		private class OnEvent_
		{
			// Token: 0x060001E7 RID: 487 RVA: 0x00063294 File Offset: 0x00060894
			private static bool Prefix(EventData __0)
			{
				bool result;
				try
				{
					result = true;
				}
				catch (Exception ex)
				{
					string text = ex.ToString();
					uint num = 1822973229U;
					MelonLogger.Error(text);
					num %= 480777016U;
					bool flag = num + 3914325116U != 0U;
					num += 2036936353U;
					result = flag;
				}
				return result;
			}
		}
	}
}
