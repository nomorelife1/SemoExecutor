namespace Semo_Beta
{
	// Token: 0x02000005 RID: 5
	public partial class RenameForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000021C8 File Offset: 0x000003C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002200 File Offset: 0x00000400
		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(12, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(260, 20);
			this.textBox1.TabIndex = 0;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(197, 56);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Rename";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(239, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter Your New Name For Tap";
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 91);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RenameForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rename Tap";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label1;
	}
}
