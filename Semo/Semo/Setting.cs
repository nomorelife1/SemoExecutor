using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ForlornApi;
using Semo_Beta.Properties;

namespace Semo_Beta
{
	// Token: 0x02000008 RID: 8
	public partial class Setting : Form
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000052D8 File Offset: 0x000034D8
		public static Setting Instance
		{
			get
			{
				object @lock = Setting._lock;
				Setting instance;
				lock (@lock)
				{
					bool flag2 = Setting._instance == null || Setting._instance.IsDisposed;
					if (flag2)
					{
						Setting._instance = new Setting();
					}
					instance = Setting._instance;
				}
				return instance;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005340 File Offset: 0x00003540
		public Setting()
		{
			this.InitializeComponent();
			base.FormClosed += this.Setting_FormClosed;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000536B File Offset: 0x0000356B
		private void Setting_Load(object sender, EventArgs e)
		{
			this.checkBox1.Checked = Settings.Default.CheckBox1State;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005384 File Offset: 0x00003584
		private void Setting_FormClosed(object sender, FormClosedEventArgs e)
		{
			Setting._instance = null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00005390 File Offset: 0x00003590
		public static void ShowSettings()
		{
			Setting form = Setting.Instance;
			form.Show();
			form.BringToFront();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000053B2 File Offset: 0x000035B2
		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000053BD File Offset: 0x000035BD
		private void SemoIcon_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/@SphinxR7");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000053CB File Offset: 0x000035CB
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/48R7T9PX7C");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000053D9 File Offset: 0x000035D9
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/SPscript1");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000053E8 File Offset: 0x000035E8
		private void SaveFile_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are You Sure Do You Want To Close Roblox?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			bool flag = result == DialogResult.Yes;
			if (flag)
			{
				foreach (Process process in Process.GetProcessesByName("RobloxPlayerBeta"))
				{
					process.Kill();
				}
				MessageBox.Show("Roblox has been closed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Operation canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005466 File Offset: 0x00003666
		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005469 File Offset: 0x00003669
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000546C File Offset: 0x0000366C
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.CheckBox1State = this.checkBox1.Checked;
			Settings.Default.Save();
			Api.SetAutoInject(this.checkBox1.Checked);
		}

		// Token: 0x0400002A RID: 42
		private static Setting _instance = null;

		// Token: 0x0400002B RID: 43
		private static readonly object _lock = new object();
	}
}
