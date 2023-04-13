using System;

namespace GGD_Hack.Internal.Buttons
{
	// Token: 0x02000017 RID: 23
	public class InvestigateCooldownButton
	{
		// Token: 0x06000089 RID: 137 RVA: 0x000519A4 File Offset: 0x0004EFA4
		public static void Investigate()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000519B4 File Offset: 0x0004EFB4
		public InvestigateCooldownButton()
		{
			uint num = 1628974216U;
			do
			{
				num = 1411594751U / num;
				base..ctor();
			}
			while (302007950U < num);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000519E0 File Offset: 0x0004EFE0
		// Note: this type is marked as 'beforefieldinit'.
		static InvestigateCooldownButton()
		{
			uint num = 78714177U;
			InvestigateCooldownButton.investigate = null;
			num *= 743907508U;
			ButtonType buttonType = (ButtonType)(num ^ 3561099696U);
			num &= 1797593661U;
			InvestigateCooldownButton.type = buttonType;
		}

		// Token: 0x0400001C RID: 28
		public static UICooldownButton investigate;

		// Token: 0x0400001D RID: 29
		public static ButtonType type;
	}
}
