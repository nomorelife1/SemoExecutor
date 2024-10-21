namespace Semo_Beta
{
	// Token: 0x02000008 RID: 8
	public partial class Setting : global::System.Windows.Forms.Form
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000054A4 File Offset: 0x000036A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000054DC File Offset: 0x000036DC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Semo_Beta.Setting));
			this.SemoIcon = new global::System.Windows.Forms.PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.SaveFile = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.SemoIcon).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.SemoIcon.Cursor = global::System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.SemoIcon, "SemoIcon");
			this.SemoIcon.Name = "SemoIcon";
			this.SemoIcon.TabStop = false;
			this.SemoIcon.Click += new global::System.EventHandler(this.SemoIcon_Click);
			this.pictureBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			resources.ApplyResources(this.pictureBox2, "pictureBox2");
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new global::System.EventHandler(this.pictureBox2_Click);
			this.SaveFile.BackColor = global::System.Drawing.Color.Transparent;
			this.SaveFile.FlatAppearance.BorderSize = 2;
			this.SaveFile.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.SaveFile.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			resources.ApplyResources(this.SaveFile, "SaveFile");
			this.SaveFile.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.SaveFile.Name = "SaveFile";
			this.SaveFile.UseVisualStyleBackColor = false;
			this.SaveFile.Click += new global::System.EventHandler(this.SaveFile_Click);
			resources.ApplyResources(this.checkBox1, "checkBox1");
			this.checkBox1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			resources.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.SaveFile);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.SemoIcon);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Name = "Setting";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Setting_FormClosed);
			base.Load += new global::System.EventHandler(this.Setting_Load);
			((global::System.ComponentModel.ISupportInitialize)this.SemoIcon).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.PictureBox SemoIcon;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button SaveFile;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.CheckBox checkBox1;
	}
}
