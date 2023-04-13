using System;
using System.Collections.Generic;
using System.Threading;
using MelonLoader;
using UnhollowerRuntimeLib;
using UnityEngine;

namespace GGD_Hack
{
	// Token: 0x0200000A RID: 10
	[RegisterTypeInIl2Cpp]
	public class UnityMainThreadDispatcher : MonoBehaviour
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0004F24C File Offset: 0x0004C84C
		public UnityMainThreadDispatcher(IntPtr ptr) : base(ptr)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0004F260 File Offset: 0x0004C860
		public UnityMainThreadDispatcher()
		{
			uint num;
			do
			{
				num = 1752368204U;
				IntPtr intPtr = ClassInjector.DerivedConstructorPointer<UnityMainThreadDispatcher>();
				num = 1074809682U / num;
				base..ctor(intPtr);
				num = (1152738334U | num);
			}
			while (147154783U * num == 0U);
			ClassInjector.DerivedConstructorBody(this);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0004F2A0 File Offset: 0x0004C8A0
		public static void Init()
		{
			GameObject gameObject;
			uint num;
			for (;;)
			{
				gameObject = GameObject.Find("ML_Manager");
				num = 297625090U;
				if (1415980942 << (int)num != 0)
				{
					bool flag = gameObject == null;
					num = (1688810107U ^ num);
					if (flag)
					{
						goto IL_37;
					}
					IL_68:
					num >>= 1;
					if (num < 1857437460U)
					{
						bool flag2 = gameObject.GetComponent<UnityMainThreadDispatcher>() == null;
						num ^= 882194953U;
						if (!flag2)
						{
							return;
						}
						num %= 1782010679U;
						if (723722809U >= num)
						{
							break;
						}
						continue;
					}
					IL_37:
					GameObject gameObject2 = new GameObject("ML_Manager");
					num &= 949960609U;
					gameObject = gameObject2;
					num |= 1839098856U;
					Object @object = gameObject;
					num *= 2080970751U;
					Object.DontDestroyOnLoad(@object);
					num += 3145989218U;
					goto IL_68;
				}
			}
			GameObject gameObject3 = gameObject;
			num = 1071451157U + num;
			UnityMainThreadDispatcher.instance = gameObject3.AddComponent<UnityMainThreadDispatcher>();
			num ^= 1138953343U;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0004F370 File Offset: 0x0004C970
		public static UnityMainThreadDispatcher Instance()
		{
			uint num;
			do
			{
				Object @object = UnityMainThreadDispatcher.instance;
				num = 1304832189U;
				Object object2 = null;
				num %= 397934665U;
				bool flag = @object == object2;
				num = 1638205687U / num;
				if (!flag)
				{
					goto IL_3F;
				}
			}
			while (num % 632776482U == 0U);
			UnityMainThreadDispatcher.Init();
			num += 0U;
			IL_3F:
			return UnityMainThreadDispatcher.instance;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0004F3C4 File Offset: 0x0004C9C4
		private void Update()
		{
			Queue<Action> queue = UnityMainThreadDispatcher.executionQueue;
			uint num = 1416376601U;
			Queue<Action> obj = queue;
			bool flag = (num ^ 1416376601U) != 0U;
			try
			{
				if (2074629948U != num)
				{
					Monitor.Enter(obj, ref flag);
				}
				for (;;)
				{
					while ((num ^ 366770300U) != 0U)
					{
						Queue<Action> queue2 = UnityMainThreadDispatcher.executionQueue;
						num >>= 1;
						if (queue2.Count <= (int)(num ^ 708188300U))
						{
							if (154760621U != num)
							{
								goto Block_6;
							}
						}
						else
						{
							Queue<Action> queue3 = UnityMainThreadDispatcher.executionQueue;
							num = 1219656419U;
							queue3.Dequeue()();
							num ^= 484330490U;
						}
					}
				}
				Block_6:;
			}
			finally
			{
				bool flag2 = flag;
				num = 1125261074U;
				if (flag2)
				{
					num = (1775915312U & num);
					Monitor.Exit(obj);
					num ^= 33558018U;
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0004F494 File Offset: 0x0004CA94
		public void Enqueue(Action action)
		{
			Queue<Action> queue = UnityMainThreadDispatcher.executionQueue;
			uint num = 1846433145U;
			Queue<Action> queue2 = queue;
			num /= 1863855527U;
			bool flag = num - 0U != 0U;
			try
			{
				do
				{
					object obj = queue2;
					num ^= 1184979798U;
					Monitor.Enter(obj, ref flag);
					Queue<Action> queue3 = UnityMainThreadDispatcher.executionQueue;
					num -= 772421125U;
					num *= 1586172853U;
					queue3.Enqueue(action);
				}
				while ((num ^ 2035491907U) == 0U);
			}
			finally
			{
				num = 697128688U;
				if (1264407196U * num != 0U && flag)
				{
					num = (1657349450U ^ num);
					if (806321063U * num != 0U)
					{
						Monitor.Exit(queue2);
						num += 3729318710U;
					}
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0004F550 File Offset: 0x0004CB50
		// Note: this type is marked as 'beforefieldinit'.
		static UnityMainThreadDispatcher()
		{
			uint num = 609829632U;
			if (2037127874U >= num)
			{
				UnityMainThreadDispatcher unityMainThreadDispatcher = null;
				num = (367865404U & num);
				UnityMainThreadDispatcher.instance = unityMainThreadDispatcher;
				if (num < 50270897U)
				{
					return;
				}
			}
			do
			{
				UnityMainThreadDispatcher.executionQueue = new Queue<Action>();
			}
			while (1029508065U < num);
		}

		// Token: 0x0400000D RID: 13
		private static UnityMainThreadDispatcher instance;

		// Token: 0x0400000E RID: 14
		private static readonly Queue<Action> executionQueue;
	}
}
