using System;
using System.Drawing;
using System.Windows.Forms;

namespace GGD_Hack.MyForms
{
	// Token: 0x02000013 RID: 19
	public partial class MyMessageBox : Form
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00051088 File Offset: 0x0004E688
		public MyMessageBox(string message)
		{
			uint num;
			for (;;)
			{
				IL_00:
				num = 1621651808U;
				base..ctor();
				if (1871524654U > num)
				{
					goto IL_17;
				}
				for (;;)
				{
					IL_24:
					num %= 1868967645U;
					bool maximizeBox = num + 2673315489U != 0U;
					num = 509312122U + num;
					base.MaximizeBox = maximizeBox;
					for (;;)
					{
						num *= 680798887U;
						bool minimizeBox = (num ^ 312339766U) != 0U;
						num = (862342472U & num);
						base.MinimizeBox = minimizeBox;
						num ^= 261949917U;
						num >>= 9;
						base.StartPosition = (int)num + (FormStartPosition)(-969889);
						num = (509875752U ^ num);
						num = (361896105U | num);
						this.messageLabel = new Label();
						num = 650013309U >> (int)num;
						if (1342050026U == num)
						{
							goto IL_00;
						}
						Control control = this.messageLabel;
						num = 1529903723U + num;
						control.AutoSize = ((num ^ 1530221113U) != 0U);
						num = 1586056882U >> (int)num;
						if (num >> 19 != 0U)
						{
							goto IL_00;
						}
						Control control2 = this.messageLabel;
						num *= 1154888900U;
						control2.Text = message;
						Control control3 = this.messageLabel;
						Point location = new Point((int)(num ^ 1185374142U), (int)(num + 3109593116U));
						num = 1749816620U << (int)num;
						control3.Location = location;
						num *= 701659520U;
						if (896936541U == num)
						{
							break;
						}
						num >>= 12;
						Control control4 = this.messageLabel;
						int width = (int)(num + 5000U);
						int height = (int)(num - 4294962296U);
						num = 2094992282U - num;
						Size maximumSize = new Size(width, height);
						num = 159067406U * num;
						control4.MaximumSize = maximumSize;
						num = 123349331U - num;
						base.Controls.Add(this.messageLabel);
						num <<= 31;
						if (37424750U == num)
						{
							goto IL_00;
						}
						PictureBox pictureBox = new PictureBox();
						num = 2032277007U + num;
						PictureBox pictureBox2 = pictureBox;
						if (num / 259408955U == 0U)
						{
							goto IL_17;
						}
						pictureBox2.Image = SystemIcons.Error.ToBitmap();
						num = 1164987849U >> (int)num;
						PictureBox pictureBox3 = pictureBox2;
						num |= 557460792U;
						PictureBoxSizeMode sizeMode = (int)num + (PictureBoxSizeMode)(-557494261);
						num += 1751131064U;
						pictureBox3.SizeMode = sizeMode;
						Control control5 = pictureBox2;
						int x = (int)(num + 1986341988U);
						num &= 281837443U;
						int y = (int)(num ^ 8934292U);
						num -= 120392953U;
						Point location2 = new Point(x, y);
						num = (1804958557U ^ num);
						control5.Location = location2;
						Control control6 = pictureBox2;
						Size size = new Size((int)(num ^ 2462989810U), (int)(num + 1831977550U));
						num = (664349588U ^ num);
						control6.Size = size;
						num = 2085447633U % num;
						num = 1491272367U + num;
						Control.ControlCollection controls = base.Controls;
						num /= 625627867U;
						controls.Add(pictureBox2);
						num = (1384797512U ^ num);
						if ((1473519530U ^ num) == 0U)
						{
							goto IL_00;
						}
						Button button = new Button();
						num = (480248052U ^ num);
						this.okButton = button;
						Control control7 = this.okButton;
						num >>= 25;
						string text = "确定";
						num -= 1715485645U;
						control7.Text = text;
						if (num < 2140691998U)
						{
							goto IL_17;
						}
						Button button2 = this.okButton;
						num = 866529731U + num;
						DialogResult dialogResult = (DialogResult)(num - 3446011420U);
						num = 1686839228U % num;
						button2.DialogResult = dialogResult;
						if (1942489104U / num == 0U)
						{
							break;
						}
						num = (1232296389U & num);
						Control control8 = this.okButton;
						AnchorStyles anchor = (AnchorStyles)(num ^ 1073944966U);
						num += 1896183177U;
						control8.Anchor = anchor;
						num = 586044298U * num;
						this.okButton.Dock = (DockStyle)(num ^ 3977532416U);
						Control control9 = this.okButton;
						num = 896696104U % num;
						int height2 = (int)(num - 896696054U);
						num = 595605243U * num;
						control9.Height = height2;
						num = 1732000584U % num;
						num = (183059398U | num);
						int width2 = (int)(num + 2416084518U);
						num = 1638874494U << (int)num;
						Size clientSize = new Size(width2, (int)(num - 3479142100U));
						num = 1235045790U + num;
						base.ClientSize = clientSize;
						num /= 756043142U;
						if ((1423187760U ^ num) != 0U)
						{
							goto Block_8;
						}
					}
				}
				IL_17:
				base.FormBorderStyle = (FormBorderStyle)(num ^ 1621651812U);
				goto IL_24;
			}
			Block_8:
			num *= 1699546514U;
			Control.ControlCollection controls2 = base.Controls;
			num <<= 30;
			num += 772940838U;
			controls2.Add(this.okButton);
			int preferredWidth = this.messageLabel.PreferredWidth;
			int num2 = (int)(num ^ 772940964U);
			num <<= 24;
			int num3 = preferredWidth + num2;
			int height3 = this.messageLabel.Height;
			num = (443093134U ^ num);
			num = 238428648U + num;
			int num4 = height3 + this.okButton.Height;
			num = (426073927U | num);
			int num5 = (int)(num - 1543470917U);
			num ^= 1813386258U;
			int num6 = num4 + num5;
			num -= 1037920330U;
			int height4 = num6;
			num = 1576301258U - num;
			num = 1948586161U * num;
			int width3 = num3;
			num %= 1364095969U;
			base.ClientSize = new Size(width3, height4);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000514DC File Offset: 0x0004EADC
		public static void Show(string message)
		{
			uint num = 74203258U;
			if (1186540001 << (int)num != 0)
			{
				do
				{
					new MyMessageBox(message).ShowDialog();
				}
				while (num == 790844590U);
			}
		}

		// Token: 0x04000014 RID: 20
		private Label messageLabel;

		// Token: 0x04000015 RID: 21
		private Button okButton;
	}
}
