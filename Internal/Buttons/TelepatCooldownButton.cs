using System;

namespace GGD_Hack.Internal.Buttons
{
	// Token: 0x02000018 RID: 24
	public class TelepatCooldownButton
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00051A18 File Offset: 0x0004F018
		public static void Telepat()
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00051A44 File Offset: 0x0004F044
		// Note: this type is marked as 'beforefieldinit'.
		static TelepatCooldownButton()
		{
			uint num = 1726493213U;
			TelepatCooldownButton.telepat = null;
			do
			{
				num = 851199665U - num;
				TelepatCooldownButton.type = (ButtonType)(num - 3419673744U);
			}
			while ((num ^ 1266887365U) == 0U);
		}

		// Token: 0x0400001E RID: 30
		public static UICooldownButton telepat;

		// Token: 0x0400001F RID: 31
		public static ButtonType type;
	}
}
