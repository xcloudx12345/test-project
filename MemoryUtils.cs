using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
public static class MemoryUtils
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	public static void WriteBytes(IntPtr address, byte[] bytes)
	{
		IntPtr handle = Process.GetCurrentProcess().Handle;
		uint flNewProtect;
		MemoryUtils.VirtualProtectEx(handle, address, (UIntPtr)((ulong)((long)bytes.Length)), 64U, out flNewProtect);
		Marshal.Copy(bytes, 0, address, bytes.Length);
		uint num;
		MemoryUtils.VirtualProtectEx(handle, address, (UIntPtr)((ulong)((long)bytes.Length)), flNewProtect, out num);
	}

	// Token: 0x06000002 RID: 2
	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	// Token: 0x04000001 RID: 1
	private const uint PAGE_EXECUTE_READWRITE = 64U;
}
