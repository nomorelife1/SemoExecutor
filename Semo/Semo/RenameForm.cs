using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Semo_Beta
{
	// Token: 0x02000005 RID: 5
	public partial class RenameForm : Form
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002134 File Offset: 0x00000334
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000213C File Offset: 0x0000033C
		public string NewName { get; private set; }

		// Token: 0x06000012 RID: 18 RVA: 0x00002145 File Offset: 0x00000345
		public RenameForm(string currentName)
		{
			this.InitializeComponent();
			this.textBox1.Text = currentName;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000216C File Offset: 0x0000036C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrWhiteSpace(this.textBox1.Text);
			if (flag)
			{
				MessageBox.Show("Please enter a name for the button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.NewName = this.textBox1.Text;
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021C5 File Offset: 0x000003C5
		private void RenameForm_Load(object sender, EventArgs e)
		{
		}
	}
}
