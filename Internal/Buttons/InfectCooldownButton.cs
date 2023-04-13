using System;

namespace GGD_Hack.Internal.Buttons
{
	// Token: 0x02000016 RID: 22
	public class InfectCooldownButton
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0005194C File Offset: 0x0004EF4C
		public static void Infect()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00051970 File Offset: 0x0004EF70
		// Note: this type is marked as 'beforefieldinit'.
		static InfectCooldownButton()
		{
			uint num = 662071365U;
			UICooldownButton uicooldownButton = null;
			num = 460328146U >> (int)num;
			InfectCooldownButton.infect = uicooldownButton;
			InfectCooldownButton.type = (int)num + (ButtonType)(-14385250);
		}

		// Token: 0x0400001A RID: 26
		public static UICooldownButton infect;

		// Token: 0x0400001B RID: 27
		public static ButtonType type;
	}
}
