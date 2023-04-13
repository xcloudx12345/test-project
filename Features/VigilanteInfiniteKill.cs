using System;
using MelonLoader;
using MelonLoader.Preferences;

namespace GGD_Hack.Features
{
	// Token: 0x02000058 RID: 88
	public class VigilanteInfiniteKill
	{
		// Token: 0x06000166 RID: 358 RVA: 0x0005D1E0 File Offset: 0x0005A7E0
		public VigilanteInfiniteKill()
		{
			uint num;
			do
			{
				num = 365842097U;
				base..ctor();
			}
			while (776675840U == num);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0005D204 File Offset: 0x0005A804
		// Note: this type is marked as 'beforefieldinit'.
		static VigilanteInfiniteKill()
		{
			uint num = 1873694825U;
			if (num * 2048224455U != 0U)
			{
				string text = "GGDH";
				num /= 2078540020U;
				string text2 = "Enable_VigilanteInfiniteKill";
				bool flag = (num ^ 1U) != 0U;
				string text3 = null;
				string text4 = null;
				bool flag2 = (num ^ 0U) != 0U;
				bool flag3 = num - 0U != 0U;
				ValueValidator valueValidator = null;
				num = 299985745U + num;
				VigilanteInfiniteKill.Enabled = MelonPreferences.CreateEntry<bool>(text, text2, flag, text3, text4, flag2, flag3, valueValidator);
			}
		}

		// Token: 0x0400019E RID: 414
		public static MelonPreferences_Entry<bool> Enabled;
	}
}
