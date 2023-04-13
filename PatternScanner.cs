using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x02000003 RID: 3
public static class PatternScanner
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
	private static bool MaskCheck(byte[] mem, int nOffset, string pattern)
	{
		for (int i = 0; i < pattern.Length / 2; i++)
		{
			string text = pattern.Substring(i * 2, 2);
			if (!(text == "??") && byte.Parse(text, NumberStyles.HexNumber) != mem[nOffset + i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x000020E4 File Offset: 0x000002E4
	public static IntPtr Scan(string module, string pattern, int offset = 0)
	{
		Process currentProcess = Process.GetCurrentProcess();
		IntPtr moduleHandle = PatternScanner.GetModuleHandle(module);
		PatternScanner.MODULEINFO moduleinfo;
		if (!PatternScanner.GetModuleInformation(currentProcess.Handle, moduleHandle, out moduleinfo, 24U))
		{
			return IntPtr.Zero;
		}
		int sizeOfImage = (int)moduleinfo.SizeOfImage;
		pattern = pattern.Replace(" ", "");
		IntPtr zero;
		try
		{
			if (moduleHandle == IntPtr.Zero)
			{
				zero = IntPtr.Zero;
			}
			else if (sizeOfImage == 0)
			{
				zero = IntPtr.Zero;
			}
			else
			{
				byte[] array = new byte[sizeOfImage];
				int num;
				if (!PatternScanner.ReadProcessMemory(currentProcess.Handle, moduleHandle, array, sizeOfImage, out num) || num != sizeOfImage)
				{
					zero = IntPtr.Zero;
				}
				else
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (PatternScanner.MaskCheck(array, i, pattern))
						{
							return new IntPtr(moduleHandle.ToInt64() + (long)i + (long)offset);
						}
					}
					zero = IntPtr.Zero;
				}
			}
		}
		catch
		{
			zero = IntPtr.Zero;
		}
		return zero;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x000021D8 File Offset: 0x000003D8
	public static IntPtr OffsetToModule(string module, int offset = 0)
	{
		Process.GetCurrentProcess();
		return PatternScanner.GetModuleHandle(module) + offset;
	}

	// Token: 0x06000006 RID: 6
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

	// Token: 0x06000007 RID: 7
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	// Token: 0x06000008 RID: 8
	[DllImport("psapi.dll", SetLastError = true)]
	private static extern bool GetModuleInformation(IntPtr hProcess, IntPtr hModule, out PatternScanner.MODULEINFO lpmodinfo, uint cb);

	// Token: 0x02000073 RID: 115
	public struct MODULEINFO
	{
		// Token: 0x040001B4 RID: 436
		public IntPtr lpBaseOfDll;

		// Token: 0x040001B5 RID: 437
		public uint SizeOfImage;

		// Token: 0x040001B6 RID: 438
		public IntPtr EntryPoint;
	}
}
