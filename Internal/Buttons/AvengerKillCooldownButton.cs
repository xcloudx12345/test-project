using System;

namespace GGD_Hack.Internal.Buttons
{
	// Token: 0x02000015 RID: 21
	public class AvengerKillCooldownButton
	{
		// Token: 0x06000084 RID: 132 RVA: 0x000518DC File Offset: 0x0004EEDC
		public AvengerKillCooldownButton()
		{
			uint num = 99427014U;
			do
			{
				num |= 1350191337U;
				base..ctor();
			}
			while (num >= 1591362487U);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00051908 File Offset: 0x0004EF08
		// Note: this type is marked as 'beforefieldinit'.
		static AvengerKillCooldownButton()
		{
			uint num = 456349292U;
			do
			{
				UICooldownButton uicooldownButton = null;
				num >>= 30;
				AvengerKillCooldownButton.avengerKill = uicooldownButton;
				ButtonType buttonType = (ButtonType)(num - 4294967292U);
				num -= 1266232465U;
				AvengerKillCooldownButton.type = buttonType;
			}
			while (1579894323U / num != 0U);
		}

		// Token: 0x04000018 RID: 24
		public static UICooldownButton avengerKill;

		// Token: 0x04000019 RID: 25
		public static ButtonType type;
	}
}
