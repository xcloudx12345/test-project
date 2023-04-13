using System;
using GGD_Hack.Utils;
using Handlers.CommonHandlers.UIHandlers;
using UnityEngine;
using UnityEngine.Events;

namespace GGD_Hack.Features.Test
{
	// Token: 0x0200005D RID: 93
	public class ShowImage
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0005E7FC File Offset: 0x0005BDFC
		public static void ShowImagePopup()
		{
			Object @object = ShowImage.chocolateSprite;
			uint num = 268722051U;
			if (@object == null)
			{
				string imageName = ShowImage.chocolateImg;
				num = 2092531341U % num;
				ShowImage.chocolateSprite = SpriteUtil.GetSpriteFromImageName(imageName);
				num ^= 480165499U;
			}
			GlobalPanelsHandler instance = GlobalPanelsHandler.Instance;
			num = 726951648U - num;
			string text = "Title";
			string text2 = "Content";
			num /= 626662947U;
			Sprite sprite = ShowImage.chocolateSprite;
			num += 1764891296U;
			string text3 = "ButtonText";
			num |= 624363802U;
			Action action;
			bool flag = (action = ShowImage.<>c.<>9__2_0) != null;
			num = 385692802U - num;
			if (!flag)
			{
				num -= 999241612U;
				action = (ShowImage.<>c.<>9__2_0 = delegate()
				{
					uint num2 = 1129600254U;
					do
					{
						GlobalPanelsHandler.Instance.ClosePanels();
					}
					while (num2 % 800739733U == 0U);
				});
				num ^= 3354458612U;
			}
			num <<= 4;
			UnityAction unityAction = action;
			num = 179526116U / num;
			string text4 = "5";
			UnityAction unityAction2 = null;
			num = 264926393U * num;
			instance.OpenErrorPanelWithImage(text, text2, sprite, text3, unityAction, text4, unityAction2, num + 1U != 0U);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0005E8E0 File Offset: 0x0005BEE0
		public ShowImage()
		{
			uint num;
			do
			{
				num = 2077577441U;
				base..ctor();
			}
			while ((num ^ 975468631U) == 0U);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0005E908 File Offset: 0x0005BF08
		// Note: this type is marked as 'beforefieldinit'.
		static ShowImage()
		{
			uint num = 262937798U;
			string text = "chocolate.jpg";
			num = 623069684U << (int)num;
			ShowImage.chocolateImg = text;
			do
			{
				ShowImage.chocolateSprite = null;
			}
			while (num << 28 != 0U);
		}

		// Token: 0x040001A6 RID: 422
		public static string chocolateImg;

		// Token: 0x040001A7 RID: 423
		public static Sprite chocolateSprite;
	}
}
