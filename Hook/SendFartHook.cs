using System;
using System.Collections.Generic;
using System.Threading;
using Handlers.GameHandlers.PlayerHandlers;
using HarmonyLib;
using MelonLoader;

namespace GGD_Hack.Hook
{
	// Token: 0x02000025 RID: 37
	[HarmonyPatch(typeof(LocalPlayer), "SendFart")]
	internal class SendFartHook
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00051BFC File Offset: 0x0004F1FC
		private static void Prefix()
		{
			uint num = 481298344U;
			do
			{
				MelonLogger.Msg("正在放屁...");
			}
			while (num % 239672320U == 0U);
			Queue<Action> queue = SendFartHook.executionQueue;
			num = (2005037500U ^ num);
			int count = queue.Count;
			num ^= 388569727U;
			uint num2 = num ^ 2082172011U;
			num |= 826109903U;
			if (count > num2)
			{
				num *= 1263171977U;
				using (Queue<Action>.Enumerator enumerator = SendFartHook.executionQueue.GetEnumerator())
				{
					while ((num ^ 152069173U) != 0U && enumerator.MoveNext())
					{
						num = 2139429785U;
						if (num > 1252076622U)
						{
							num += 956136915U;
							Action action = enumerator.Current;
							num = 567607595U + num;
							string text = "正在执行放屁绑定的所有action";
							num = 264307210U - num;
							MelonLogger.Msg(text);
							num ^= 2039954030U;
							action();
							num ^= 772702458U;
						}
					}
				}
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00051D08 File Offset: 0x0004F308
		public static void bindAction(Action action)
		{
			uint num = 946945197U;
			Queue<Action> queue;
			if (num >> 14 != 0U)
			{
				queue = SendFartHook.executionQueue;
			}
			num = 9840245U - num;
			bool flag = (num ^ 3357862344U) != 0U;
			num ^= 865547573U;
			bool flag2 = flag;
			try
			{
				num = (335952620U ^ num);
				if ((1590560816U ^ num) != 0U)
				{
					do
					{
						Monitor.Enter(queue, ref flag2);
						num &= 1049035645U;
						if ((num ^ 112724377U) != 0U)
						{
							num >>= 21;
							if (action == null)
							{
								if (1597194273U + num != 0U)
								{
									break;
								}
								continue;
							}
							else
							{
								num = 1133578812U / num;
								SendFartHook.executionQueue.Clear();
								if (num * 1666015379U == 0U)
								{
									continue;
								}
							}
						}
						Queue<Action> queue2 = SendFartHook.executionQueue;
						num = 560027015U % num;
						queue2.Enqueue(action);
					}
					while (1055261087U / num == 0U);
				}
			}
			finally
			{
				num = 174461524U;
				if (1099581623U >= num)
				{
					bool flag3 = flag2;
					num |= 1829179356U;
					if (!flag3)
					{
						goto IL_FE;
					}
					num = 608505577U % num;
				}
				object obj = queue;
				num = 472646060U + num;
				Monitor.Exit(obj);
				num ^= 789974857U;
				IL_FE:;
			}
		}

		// Token: 0x04000031 RID: 49
		private static readonly Queue<Action> executionQueue = new Queue<Action>();
	}
}
