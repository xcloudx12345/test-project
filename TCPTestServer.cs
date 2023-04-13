using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using MelonLoader;

namespace GGD_Hack
{
	// Token: 0x02000009 RID: 9
	public class TCPTestServer
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0004EB84 File Offset: 0x0004C184
		public TCPTestServer(int port)
		{
			for (;;)
			{
				uint num = 508437284U;
				base..ctor();
				num %= 1558734174U;
				for (;;)
				{
					string ipString = "127.0.0.1";
					num = 641432773U << (int)num;
					IPAddress ipaddress = IPAddress.Parse(ipString);
					num /= 1138951988U;
					IPAddress localaddr = ipaddress;
					num >>= 19;
					if (num - 1940994208U == 0U)
					{
						break;
					}
					TcpListener tcpListener = new TcpListener(localaddr, port);
					num >>= 30;
					this.listener = tcpListener;
					num >>= 13;
					if ((num & 259458183U) != 0U)
					{
						return;
					}
					string str = "TCP服务器监听端口为: ";
					num /= 1566848225U;
					num &= 1452234467U;
					string text = str + port.ToString();
					num = 1704526545U * num;
					MelonLogger.Msg(text);
					if (num < 782005846U)
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0004EC3C File Offset: 0x0004C23C
		public void Start()
		{
			uint num;
			do
			{
				num = 809045537U;
				Thread thread = new Thread(new ThreadStart(this.StartServer));
				num |= 2016549492U;
				thread.Start();
			}
			while (1433870038U > num);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0004EC78 File Offset: 0x0004C278
		private void StartServer()
		{
			uint num = 1264069835U;
			if (num > 112226103U)
			{
				goto IL_11;
			}
			for (;;)
			{
				IL_2E:
				if (294663967U <= num)
				{
					goto IL_F3;
				}
				num &= 2134471130U;
				TcpClient tcpClient = this.listener.AcceptTcpClient();
				num |= 1875270793U;
				TcpClient tcpClient2 = tcpClient;
				if (1852768454U + num == 0U)
				{
					goto IL_24;
				}
				string format = "[{0}]";
				num = 376247807U << (int)num;
				num = 271283820U << (int)num;
				object arg = this.clientsDisconnectedNum.ToString();
				num *= 1680496258U;
				string text = string.Format(format, arg) + "New client connected.";
				num = (274950076U | num);
				MelonLogger.Msg(text);
				num *= 907243978U;
				if (1291256670U > num)
				{
					break;
				}
				num = 891767896U / num;
				bool flag = this.client != null;
				num = 1280201414U - num;
				if (flag)
				{
					num &= 1527060745U;
					if (423128542U / num == 0U)
					{
						goto IL_F3;
					}
					break;
				}
				IL_157:
				if (num + 1893406829U == 0U)
				{
					break;
				}
				num <<= 8;
				TcpClient tcpClient3 = tcpClient2;
				num = 2014471368U >> (int)num;
				this.client = tcpClient3;
				if (510672004U != num)
				{
					num = 516882983U + num;
					num = (1695553357U | num);
					TcpClient tcpClient4 = this.client;
					num *= 1780892502U;
					this.HandleClient(tcpClient4);
					num += 3204721424U;
					continue;
				}
				break;
				IL_F3:
				num = 4204912U * num;
				this.client.Close();
				MelonLogger.Msg("Previous client disconnected.");
				if (1020270992U != num)
				{
					num >>= 3;
					num = 1577071457U - num;
					int num2 = this.clientsDisconnectedNum;
					num %= 1212902019U;
					int num3 = num2 + (int)(num - 279570653U);
					num = 1572669063U + num;
					this.clientsDisconnectedNum = num3;
					num ^= 573095331U;
					goto IL_157;
				}
				break;
			}
			IL_11:
			num >>= 21;
			this.listener.Start();
			IL_24:
			MelonLogger.Msg("Server started. Waiting for a connection...");
			goto IL_2E;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0004EE40 File Offset: 0x0004C440
		private void HandleClient(TcpClient client)
		{
			uint num = 154144345U;
			TcpClient tcpClient = client;
			num = (1295535697U ^ num);
			NetworkStream stream = tcpClient.GetStream();
			num += 31721829U;
			NetworkStream networkStream = stream;
			byte[] array = new byte[num ^ 1173114221U];
			for (;;)
			{
				int num2 = 0;
				num = 599355439U;
				int num3 = num2;
				try
				{
					if (1238054528U >= num)
					{
						Stream stream2 = networkStream;
						num /= 316867878U;
						byte[] buffer = array;
						int offset = (int)(num + uint.MaxValue);
						int count = array.Length;
						num = 1261708665U - num;
						num3 = stream2.Read(buffer, offset, count);
					}
				}
				catch (object obj)
				{
					break;
				}
				string text3;
				for (;;)
				{
					IL_72:
					num = 1914467260U;
					if (2145735530U <= num)
					{
						goto IL_9D;
					}
					if (num3 == 0)
					{
						num >>= 31;
						if (1418535172U > num)
						{
							goto IL_9D;
						}
						goto IL_B2;
					}
					for (;;)
					{
						IL_B7:
						num ^= 1435705824U;
						Encoding utf = Encoding.UTF8;
						byte[] bytes = array;
						num = 564017258U * num;
						int index = (int)(num ^ 1814313496U);
						num |= 639982849U;
						string @string = utf.GetString(bytes, index, num3);
						num = 222898169U / num;
						string text = @string;
						num *= 232461768U;
						string text2 = "Received: {0}";
						num = 982008684U * num;
						object[] array2 = new object[num + 1U];
						num = (123615872U | num);
						array2[(int)(num ^ 123615872U)] = text;
						num = 517170929U * num;
						MelonLogger.Msg(text2, array2);
						num /= 1920884012U;
						bool flag = CommandHandler.HandleMessage(text);
						num = 1237978848U - num;
						num -= 1910902569U;
						if (!flag)
						{
							break;
						}
						num = 54661347U + num;
						if (num <= 1757951533U)
						{
							goto IL_72;
						}
						text3 = "success";
						if ((num & 359483214U) != 0U)
						{
							goto Block_6;
						}
					}
					num %= 1052734827U;
					if (1766340617U > num)
					{
						goto Block_7;
					}
					continue;
					IL_9D:
					MelonLogger.Msg("Client disconnected.");
					if (num != 1037051296U)
					{
						goto IL_B2;
					}
					goto IL_B7;
				}
				IL_1A7:
				num = 16056409U / num;
				if ((1444160018U & num) == 0U)
				{
					Encoding utf2 = Encoding.UTF8;
					string s = text3;
					num <<= 18;
					byte[] bytes2 = utf2.GetBytes(s);
					num = 2094101642U * num;
					byte[] array3 = bytes2;
					try
					{
						num = 1383604458U * num;
						Stream stream3 = networkStream;
						num *= 336478113U;
						byte[] buffer2 = array3;
						int offset2 = (int)(num + 0U);
						num = 1925345342U + num;
						byte[] array4 = array3;
						num = 2026531257U >> (int)num;
						int num4 = array4.Length;
						num <<= 20;
						stream3.Write(buffer2, offset2, num4);
						continue;
					}
					catch
					{
					}
					break;
				}
				break;
				Block_6:
				goto IL_1A7;
				Block_7:
				string text4 = "error";
				num = (930708582U | num);
				text3 = text4;
				num += 2603094306U;
				goto IL_1A7;
			}
			do
			{
				IL_225:
				client.Close();
				num = 1125858748U;
			}
			while (num == 640506626U);
			TcpClient tcpClient2 = null;
			num &= 222572689U;
			client = tcpClient2;
			return;
			IL_B2:
			goto IL_225;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0004F0C8 File Offset: 0x0004C6C8
		public void Stop()
		{
			uint num;
			do
			{
				num = 662118865U;
				this.listener.Stop();
				num = 637494998U >> (int)num;
			}
			while (num << 1 == 0U);
			do
			{
				num ^= 1423460709U;
				bool flag = this.client != null;
				num = 714610214U >> (int)num;
				if (flag)
				{
					TcpClient tcpClient = this.client;
					num %= 564075763U;
					tcpClient.Close();
					if (303196002U < num)
					{
						continue;
					}
					this.client = null;
					num += 0U;
				}
			}
			while ((num & 1619858559U) == 0U);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0004F15C File Offset: 0x0004C75C
		public static bool IsPortAvailable(int port)
		{
			bool result;
			try
			{
				uint num = 366741988U;
				TcpClient tcpClient = new TcpClient();
				num = 796989966U + num;
				TcpClient tcpClient2 = tcpClient;
				try
				{
					TcpClient tcpClient3 = tcpClient2;
					num += 486028313U;
					tcpClient3.Connect(IPAddress.Loopback, port);
					do
					{
						result = ((num ^ 1649760267U) != 0U);
					}
					while (num + 998786680U == 0U);
				}
				finally
				{
					do
					{
						bool flag = tcpClient2 != null;
						num = 988831456U;
						if (!flag)
						{
							goto IL_75;
						}
					}
					while (2000377787 << (int)num == 0);
					IL_5F:
					IDisposable disposable = tcpClient2;
					num <<= 27;
					disposable.Dispose();
					num ^= 988831456U;
					IL_75:
					if ((1704987239U & num) == 0U)
					{
						goto IL_5F;
					}
				}
			}
			catch (SocketException ex)
			{
				uint num = 1143222867U;
				num -= 333787927U;
				bool flag2 = num - 809434939U != 0U;
				num = 1537482573U % num;
				result = flag2;
			}
			return result;
		}

		// Token: 0x0400000A RID: 10
		private TcpListener listener;

		// Token: 0x0400000B RID: 11
		private TcpClient client;

		// Token: 0x0400000C RID: 12
		private int clientsDisconnectedNum;
	}
}
