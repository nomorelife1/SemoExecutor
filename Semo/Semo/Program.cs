using System;
using System.Threading;
using System.Windows.Forms;
using Semo_Beta;

// Token: 0x02000004 RID: 4
internal static class Program
{
	// Token: 0x0600000F RID: 15 RVA: 0x000020C0 File Offset: 0x000002C0
	[STAThread]
	private static void Main()
	{
		bool createdNew;
		using (new Mutex(true, "SemoAppMutex", ref createdNew))
		{
			bool flag = !createdNew;
			if (flag)
			{
				MessageBox.Show("You are currently opening Semo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Semo());
			}
		}
	}
}
