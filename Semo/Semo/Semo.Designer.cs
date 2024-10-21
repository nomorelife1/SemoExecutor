namespace Semo_Beta
{
	// Token: 0x02000006 RID: 6
	public partial class Semo : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004F RID: 79 RVA: 0x00003A18 File Offset: 0x00001C18
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003A50 File Offset: 0x00001C50
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Semo_Beta.Semo));
			this.OpenFile = new global::System.Windows.Forms.Button();
			this.SaveFile = new global::System.Windows.Forms.Button();
			this.InjectButton = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.CheckInject = new global::System.Windows.Forms.Label();
			this.SemoBeta = new global::System.Windows.Forms.Label();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.SemoIcon = new global::System.Windows.Forms.PictureBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.Refresh = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.SphinxR7 = new global::System.Windows.Forms.Label();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.button1 = new global::System.Windows.Forms.Button();
			this.NewTapButton = new global::System.Windows.Forms.Button();
			this.PanelE = new global::System.Windows.Forms.FlowLayoutPanel();
			this.contextap = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.removeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.Execute = new global::System.Windows.Forms.Button();
			this.Clear = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SemoIcon).BeginInit();
			this.panel2.SuspendLayout();
			this.PanelE.SuspendLayout();
			this.contextap.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.OpenFile.BackColor = global::System.Drawing.Color.Purple;
			this.OpenFile.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.OpenFile.FlatAppearance.BorderSize = 2;
			this.OpenFile.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.OpenFile.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.OpenFile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OpenFile.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.OpenFile.ForeColor = global::System.Drawing.Color.Black;
			this.OpenFile.Location = new global::System.Drawing.Point(185, 414);
			this.OpenFile.Name = "OpenFile";
			this.OpenFile.Size = new global::System.Drawing.Size(76, 35);
			this.OpenFile.TabIndex = 2;
			this.OpenFile.Text = "\ud83d\udcc2";
			this.OpenFile.UseVisualStyleBackColor = false;
			this.OpenFile.Click += new global::System.EventHandler(this.button3_Click);
			this.SaveFile.BackColor = global::System.Drawing.Color.Purple;
			this.SaveFile.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.SaveFile.FlatAppearance.BorderSize = 2;
			this.SaveFile.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.SaveFile.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.SaveFile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SaveFile.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SaveFile.ForeColor = global::System.Drawing.Color.Black;
			this.SaveFile.Location = new global::System.Drawing.Point(267, 414);
			this.SaveFile.Name = "SaveFile";
			this.SaveFile.Size = new global::System.Drawing.Size(76, 35);
			this.SaveFile.TabIndex = 3;
			this.SaveFile.Text = "\ud83d\udcbe";
			this.SaveFile.UseVisualStyleBackColor = false;
			this.SaveFile.Click += new global::System.EventHandler(this.button4_Click);
			this.InjectButton.BackColor = global::System.Drawing.Color.Purple;
			this.InjectButton.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.InjectButton.FlatAppearance.BorderSize = 2;
			this.InjectButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.InjectButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.InjectButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.InjectButton.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.InjectButton.ForeColor = global::System.Drawing.Color.Black;
			this.InjectButton.Location = new global::System.Drawing.Point(780, 411);
			this.InjectButton.Name = "InjectButton";
			this.InjectButton.Size = new global::System.Drawing.Size(76, 35);
			this.InjectButton.TabIndex = 4;
			this.InjectButton.Text = "\ud83d\udc89";
			this.InjectButton.UseVisualStyleBackColor = false;
			this.InjectButton.Click += new global::System.EventHandler(this.button5_Click);
			this.panel1.BackColor = global::System.Drawing.Color.Black;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.CheckInject);
			this.panel1.Controls.Add(this.SemoBeta);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.SemoIcon);
			this.panel1.Location = new global::System.Drawing.Point(0, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(1004, 41);
			this.panel1.TabIndex = 6;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.CheckInject.AutoSize = true;
			this.CheckInject.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckInject.Location = new global::System.Drawing.Point(57, 7);
			this.CheckInject.Name = "CheckInject";
			this.CheckInject.Size = new global::System.Drawing.Size(86, 25);
			this.CheckInject.TabIndex = 13;
			this.CheckInject.Text = "Statue: ";
			this.CheckInject.Click += new global::System.EventHandler(this.label1_Click_1);
			this.SemoBeta.AutoSize = true;
			this.SemoBeta.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.SemoBeta.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SemoBeta.Font = new global::System.Drawing.Font("BatmanForeverAlternate", 21.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SemoBeta.Location = new global::System.Drawing.Point(452, 7);
			this.SemoBeta.Name = "SemoBeta";
			this.SemoBeta.Size = new global::System.Drawing.Size(118, 27);
			this.SemoBeta.TabIndex = 12;
			this.SemoBeta.Text = "Semo";
			this.SemoBeta.Click += new global::System.EventHandler(this.label1_Click);
			this.button7.BackColor = global::System.Drawing.Color.Black;
			this.button7.FlatAppearance.BorderColor = global::System.Drawing.SystemColors.MenuText;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.button7.FlatAppearance.MouseOverBackColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.button7.Location = new global::System.Drawing.Point(907, 0);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(49, 41);
			this.button7.TabIndex = 11;
			this.button7.Text = "-";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button8.BackColor = global::System.Drawing.Color.Black;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.button8.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.Red;
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button8.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.button8.Location = new global::System.Drawing.Point(956, -1);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(46, 42);
			this.button8.TabIndex = 10;
			this.button8.Text = "X";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.SemoIcon.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.SemoIcon.Image = (global::System.Drawing.Image)resources.GetObject("SemoIcon.Image");
			this.SemoIcon.Location = new global::System.Drawing.Point(0, 0);
			this.SemoIcon.Name = "SemoIcon";
			this.SemoIcon.Size = new global::System.Drawing.Size(51, 40);
			this.SemoIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SemoIcon.TabIndex = 0;
			this.SemoIcon.TabStop = false;
			this.SemoIcon.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.listBox1.BackColor = global::System.Drawing.Color.Black;
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBox1.Font = new global::System.Drawing.Font("Microsoft Tai Le", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = global::System.Drawing.Color.DarkOrchid;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new global::System.Drawing.Point(857, 97);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(147, 306);
			this.listBox1.TabIndex = 7;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.Refresh.BackColor = global::System.Drawing.Color.Purple;
			this.Refresh.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.Refresh.FlatAppearance.BorderSize = 2;
			this.Refresh.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Refresh.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Refresh.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Refresh.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Refresh.ForeColor = global::System.Drawing.Color.Black;
			this.Refresh.Location = new global::System.Drawing.Point(893, 411);
			this.Refresh.Name = "Refresh";
			this.Refresh.Size = new global::System.Drawing.Size(76, 35);
			this.Refresh.TabIndex = 8;
			this.Refresh.Text = "\ud83d\udd04";
			this.Refresh.UseVisualStyleBackColor = false;
			this.Refresh.Click += new global::System.EventHandler(this.button6_Click);
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.SphinxR7);
			this.panel2.ForeColor = global::System.Drawing.Color.White;
			this.panel2.Location = new global::System.Drawing.Point(0, 457);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(1004, 19);
			this.panel2.TabIndex = 9;
			this.panel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.SphinxR7.AutoSize = true;
			this.SphinxR7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.SphinxR7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SphinxR7.Location = new global::System.Drawing.Point(6, 2);
			this.SphinxR7.Name = "SphinxR7";
			this.SphinxR7.Size = new global::System.Drawing.Size(61, 13);
			this.SphinxR7.TabIndex = 0;
			this.SphinxR7.Text = "SphinxR7";
			this.SphinxR7.Click += new global::System.EventHandler(this.SphinxR7_Click);
			this.backgroundWorker1.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.button1.BackColor = global::System.Drawing.Color.Purple;
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(349, 414);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(76, 35);
			this.button1.TabIndex = 10;
			this.button1.Text = "⚙";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.NewTapButton.BackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.NewTapButton.FlatAppearance.BorderSize = 0;
			this.NewTapButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.NewTapButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.NewTapButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.NewTapButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.NewTapButton.Location = new global::System.Drawing.Point(3, 3);
			this.NewTapButton.Name = "NewTapButton";
			this.NewTapButton.Size = new global::System.Drawing.Size(119, 23);
			this.NewTapButton.TabIndex = 11;
			this.NewTapButton.Text = "New Tap";
			this.NewTapButton.UseVisualStyleBackColor = false;
			this.NewTapButton.Click += new global::System.EventHandler(this.NewTap_Click);
			this.PanelE.AutoScroll = true;
			this.PanelE.BackColor = global::System.Drawing.Color.Black;
			this.PanelE.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PanelE.Controls.Add(this.NewTapButton);
			this.PanelE.Location = new global::System.Drawing.Point(0, 44);
			this.PanelE.Name = "PanelE";
			this.PanelE.Size = new global::System.Drawing.Size(1004, 52);
			this.PanelE.TabIndex = 12;
			this.PanelE.WrapContents = false;
			this.PanelE.Paint += new global::System.Windows.Forms.PaintEventHandler(this.PanelE_Paint);
			this.contextap.BackColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.contextap.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.contextap.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.removeToolStripMenuItem,
				this.renameToolStripMenuItem
			});
			this.contextap.Name = "contextap";
			this.contextap.Size = new global::System.Drawing.Size(128, 52);
			this.contextap.Text = "Editor";
			this.removeToolStripMenuItem.BackColor = global::System.Drawing.SystemColors.ButtonShadow;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new global::System.Drawing.Size(127, 24);
			this.removeToolStripMenuItem.Text = "Remove";
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(127, 24);
			this.renameToolStripMenuItem.Text = "Rename";
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);";
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(27, 14);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = global::System.Drawing.Color.Black;
			this.fastColoredTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DefaultMarkerSize = 8;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f);
			this.fastColoredTextBox1.IndentBackColor = global::System.Drawing.Color.Black;
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(0, 97);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(856, 306);
			this.fastColoredTextBox1.TabIndex = 13;
			this.fastColoredTextBox1.Zoom = 100;
			this.fastColoredTextBox1.Load += new global::System.EventHandler(this.fastColoredTextBox1_Load);
			this.Execute.BackColor = global::System.Drawing.Color.Purple;
			this.Execute.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.Execute.FlatAppearance.BorderSize = 2;
			this.Execute.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Execute.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Execute.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Execute.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Execute.ForeColor = global::System.Drawing.Color.Black;
			this.Execute.Location = new global::System.Drawing.Point(21, 414);
			this.Execute.Name = "Execute";
			this.Execute.Size = new global::System.Drawing.Size(76, 35);
			this.Execute.TabIndex = 0;
			this.Execute.Text = "▶";
			this.Execute.UseVisualStyleBackColor = false;
			this.Execute.Click += new global::System.EventHandler(this.button1_Click);
			this.Clear.BackColor = global::System.Drawing.Color.Purple;
			this.Clear.FlatAppearance.BorderColor = global::System.Drawing.Color.WhiteSmoke;
			this.Clear.FlatAppearance.BorderSize = 2;
			this.Clear.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(18, 18, 18);
			this.Clear.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.Clear.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Clear.Font = new global::System.Drawing.Font("Microsoft YaHei", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Clear.ForeColor = global::System.Drawing.Color.Black;
			this.Clear.ImageAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.Clear.Location = new global::System.Drawing.Point(103, 414);
			this.Clear.Name = "Clear";
			this.Clear.Size = new global::System.Drawing.Size(76, 35);
			this.Clear.TabIndex = 1;
			this.Clear.Text = "\ud83e\uddfd";
			this.Clear.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Clear.UseVisualStyleBackColor = false;
			this.Clear.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(1004, 476);
			base.Controls.Add(this.fastColoredTextBox1);
			base.Controls.Add(this.PanelE);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.Refresh);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.InjectButton);
			base.Controls.Add(this.SaveFile);
			base.Controls.Add(this.OpenFile);
			base.Controls.Add(this.Clear);
			base.Controls.Add(this.Execute);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Semo";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Semo";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Semo_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.Semo_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SemoIcon).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.PanelE.ResumeLayout(false);
			this.contextap.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000012 RID: 18
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button Clear;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button OpenFile;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button SaveFile;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button InjectButton;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.PictureBox SemoIcon;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400001A RID: 26
		private new global::System.Windows.Forms.Button Refresh;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label SemoBeta;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label SphinxR7;

		// Token: 0x04000020 RID: 32
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Button NewTapButton;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.FlowLayoutPanel PanelE;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.ContextMenuStrip contextap;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x04000027 RID: 39
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button Execute;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label CheckInject;
	}
}
