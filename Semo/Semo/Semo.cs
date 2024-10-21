using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using ForlornApi;
using Newtonsoft.Json;
using Semo_Beta.Properties;

namespace Semo_Beta
{
	// Token: 0x02000006 RID: 6
	public partial class Semo : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002464 File Offset: 0x00000664
		public Semo()
		{
			this.InitializeComponent();
			base.FormClosing += this.Semo_FormClosing;
			base.KeyPreview = true;
			Button openRobloxButton = new Button
			{
				Text = "Open Roblox",
				Location = new Point(10, 10)
			};
			openRobloxButton.Click += this.OpenRobloxButton_Click;
			base.Controls.Add(openRobloxButton);
			List<global::ButtonState> buttonStates = this.LoadButtonStates();
			this.CreateButtonsFromStates(buttonStates);
			bool isCheckBox1Enabled = Settings.Default.CheckBox1State;
			Api.SetAutoInject(isCheckBox1Enabled);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002554 File Offset: 0x00000754
		private void OpenRobloxButton_Click(object sender, EventArgs e)
		{
			Process[] robloxProcesses = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = robloxProcesses.Length == 0;
			if (flag)
			{
				string robloxPath = this.GetRobloxPath();
				bool flag2 = robloxPath != null;
				if (flag2)
				{
					try
					{
						Process.Start(robloxPath);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed to open Roblox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Roblox is not installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("Roblox is already running.", "Information", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025F8 File Offset: 0x000007F8
		private string GetRobloxPath()
		{
			string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string robloxPath = Path.Combine(new string[]
			{
				userProfile,
				"AppData",
				"Local",
				"Roblox",
				"Versions"
			});
			string[] directories = Directory.GetDirectories(robloxPath);
			bool flag = directories.Length != 0;
			if (flag)
			{
				Array.Sort<string>(directories);
				string latestVersion = directories[directories.Length - 1];
				string robloxPlayerPath = Path.Combine(latestVersion, "RobloxPlayerBeta.exe");
				bool flag2 = File.Exists(robloxPlayerPath);
				if (flag2)
				{
					return robloxPlayerPath;
				}
			}
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000268C File Offset: 0x0000088C
		private void SaveButtonStates(List<global::ButtonState> buttonStates)
		{
			string json = JsonConvert.SerializeObject(buttonStates, Formatting.Indented);
			File.WriteAllText("buttonStates.json", json);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026B0 File Offset: 0x000008B0
		private List<global::ButtonState> LoadButtonStates()
		{
			bool flag = File.Exists("buttonStates.json");
			List<global::ButtonState> result;
			if (flag)
			{
				string json = File.ReadAllText("buttonStates.json");
				result = JsonConvert.DeserializeObject<List<global::ButtonState>>(json);
			}
			else
			{
				result = new List<global::ButtonState>();
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000026EC File Offset: 0x000008EC
		private void CreateButtonsFromStates(List<global::ButtonState> buttonStates)
		{
			foreach (global::ButtonState state in buttonStates)
			{
				Button button = new Button
				{
					Text = state.Text,
					Location = new Point(state.X, state.Y)
				};
				base.Controls.Add(button);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002770 File Offset: 0x00000970
		private void addIntel(string label, string kind, string detail, string insertText)
		{
			new List<AutocompleteItem>().Add(new AutocompleteItem(label));
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'[',
				']',
				'{',
				'}'
			};
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027B0 File Offset: 0x000009B0
		private void LoadCustomFont()
		{
			PrivateFontCollection privateFonts = new PrivateFontCollection();
			string fontPath = Path.Combine(Application.StartupPath, "Fonts", "batmfa_");
			byte[] fontData = File.ReadAllBytes(fontPath);
			IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
			Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
			privateFonts.AddMemoryFont(fontPtr, fontData.Length);
			Marshal.FreeCoTaskMem(fontPtr);
			this.SemoBeta.Font = new Font(privateFonts.Families[0], 12f);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002825 File Offset: 0x00000A25
		private void Form1_Load(object sender, EventArgs e)
		{
			this.LoadCustomFont();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002830 File Offset: 0x00000A30
		private static int GetProcessIdByName(string processName)
		{
			Process[] processes = Process.GetProcessesByName(processName);
			bool flag = processes.Length != 0;
			int result;
			if (flag)
			{
				result = processes[0].Id;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002860 File Offset: 0x00000A60
		private void addGlobalF()
		{
			string globalFilePath = Path.Combine(this.defPath, "globalf.txt");
			bool flag = File.Exists(globalFilePath);
			if (flag)
			{
				string[] array = File.ReadAllLines(globalFilePath);
				foreach (string text in array)
				{
					bool flag2 = text.Contains(':');
					if (flag2)
					{
						this.addIntel(text, "Function", text, text.Substring(text.IndexOf(':') + 1));
					}
					else
					{
						this.addIntel(text, "Function", text, text);
					}
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000028F8 File Offset: 0x00000AF8
		private void addGlobalV()
		{
			string globalFilePath = Path.Combine(this.defPath, "globalv.txt");
			bool flag = File.Exists(globalFilePath);
			if (flag)
			{
				foreach (string text in File.ReadLines(globalFilePath))
				{
					this.addIntel(text, "Variable", text, text);
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002970 File Offset: 0x00000B70
		private void addGlobalNS()
		{
			string globalFilePath = Path.Combine(this.defPath, "globalns.txt");
			bool flag = File.Exists(globalFilePath);
			if (flag)
			{
				foreach (string text in File.ReadLines(globalFilePath))
				{
					this.addIntel(text, "Class", text, text);
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000029E8 File Offset: 0x00000BE8
		private void addMath()
		{
			string globalFilePath = Path.Combine(this.defPath, "classfunc.txt");
			bool flag = File.Exists(globalFilePath);
			if (flag)
			{
				foreach (string text in File.ReadLines(globalFilePath))
				{
					this.addIntel(text, "Method", text, text);
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A60 File Offset: 0x00000C60
		private void addBase()
		{
			string globalFilePath = Path.Combine(this.defPath, "base.txt");
			bool flag = File.Exists(globalFilePath);
			if (flag)
			{
				foreach (string text in File.ReadLines(globalFilePath))
				{
					this.addIntel(text, "Keyword", text, text);
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[DebuggerStepThrough]
		private Task UpdateInjectionContinuously()
		{
			Semo.<UpdateInjectionContinuously>d__19 <UpdateInjectionContinuously>d__ = new Semo.<UpdateInjectionContinuously>d__19();
			<UpdateInjectionContinuously>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateInjectionContinuously>d__.<>4__this = this;
			<UpdateInjectionContinuously>d__.<>1__state = -1;
			<UpdateInjectionContinuously>d__.<>t__builder.Start<Semo.<UpdateInjectionContinuously>d__19>(ref <UpdateInjectionContinuously>d__);
			return <UpdateInjectionContinuously>d__.<>t__builder.Task;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002B1C File Offset: 0x00000D1C
		[DebuggerStepThrough]
		private void Semo_Load(object sender, EventArgs e)
		{
			Semo.<Semo_Load>d__20 <Semo_Load>d__ = new Semo.<Semo_Load>d__20();
			<Semo_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Semo_Load>d__.<>4__this = this;
			<Semo_Load>d__.sender = sender;
			<Semo_Load>d__.e = e;
			<Semo_Load>d__.<>1__state = -1;
			<Semo_Load>d__.<>t__builder.Start<Semo.<Semo_Load>d__20>(ref <Semo_Load>d__);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002B64 File Offset: 0x00000D64
		private void UpdateInjectionStatus()
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				this.CheckInject.Text = "Statue: Injected";
				this.CheckInject.ForeColor = Color.Green;
			}
			else
			{
				this.CheckInject.Text = "Statue: Not Injected!";
				this.CheckInject.ForeColor = Color.Red;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private void Semo_FormClosing(object sender, FormClosingEventArgs e)
		{
			string currentText = this.fastColoredTextBox1.Text;
			bool flag = !string.IsNullOrEmpty(this.lastTextFilePath);
			if (flag)
			{
				try
				{
					File.WriteAllText(this.lastTextFilePath, currentText);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not save file. Original error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			this.SaveButtonsState();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002C44 File Offset: 0x00000E44
		private void button8_Click(object sender, EventArgs e)
		{
			bool flag = MessageBox.Show("Are you sure you want to close the executor? Click Yes to close it.", "Semo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (flag)
			{
				Application.Exit();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002C73 File Offset: 0x00000E73
		private void label1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/48R7T9PX7C");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002C84 File Offset: 0x00000E84
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listBox1.SelectedIndex != -1;
			if (flag)
			{
				string filePath = Path.Combine("scripts", this.listBox1.SelectedItem.ToString());
				try
				{
					bool flag2 = File.Exists(filePath);
					if (flag2)
					{
						string fileContent = File.ReadAllText(filePath);
						this.fastColoredTextBox1.Text = fileContent;
					}
					else
					{
						MessageBox.Show("Selected script file does not exist.", "Error");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("An error occurred while loading the file: " + ex.Message, "Error");
				}
			}
			else
			{
				MessageBox.Show("Please select a script from the list before trying to load it.", "Semo");
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002D44 File Offset: 0x00000F44
		private void button6_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002D84 File Offset: 0x00000F84
		private void button7_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002D90 File Offset: 0x00000F90
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				Api.ExecuteScript(this.fastColoredTextBox1.Text);
			}
			else
			{
				MessageBox.Show("Not Injected!", "Injection", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002DD0 File Offset: 0x00000FD0
		private void button3_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Saves");
				openFileDialog.Filter = "All Files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
				openFileDialog.RestoreDirectory = true;
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						string filePath = openFileDialog.FileName;
						bool flag2 = File.Exists(filePath);
						if (flag2)
						{
							string fileContent = File.ReadAllText(filePath);
							this.fastColoredTextBox1.Text = fileContent;
						}
						else
						{
							MessageBox.Show("The selected file does not exist.", "Error");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
					}
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002EB0 File Offset: 0x000010B0
		private void button4_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Saves");
				saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
				saveFileDialog.FilterIndex = 1;
				saveFileDialog.RestoreDirectory = true;
				bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						string textToSave = this.fastColoredTextBox1.Text;
						using (Stream s = File.Open(saveFileDialog.FileName, FileMode.Create))
						{
							using (StreamWriter sw = new StreamWriter(s))
							{
								sw.Write(textToSave);
							}
						}
						MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Error: Could not write to file. Original error: " + ex.Message);
					}
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002FC4 File Offset: 0x000011C4
		private void button5_Click(object sender, EventArgs e)
		{
			Process[] robloxProcesses = Process.GetProcessesByName("RobloxPlayerBeta");
			bool flag = robloxProcesses.Length == 0;
			if (flag)
			{
				MessageBox.Show("You Haven't Opened Roblox, Do You Want Open Roblox? Prees OK For Open Roblox", "Roblox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				string robloxPath = this.GetRobloxPath();
				bool flag2 = robloxPath != null;
				if (flag2)
				{
					try
					{
						Process.Start(robloxPath);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Failed to open Roblox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Roblox is not installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				bool flag3 = !Api.IsInjected();
				if (flag3)
				{
					Api.Inject();
				}
				else
				{
					MessageBox.Show("Already Injected!", "Injection", MessageBoxButtons.OK);
				}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003090 File Offset: 0x00001290
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.fastColoredTextBox1.Text);
			if (flag)
			{
				this.fastColoredTextBox1.Text = string.Empty;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030C8 File Offset: 0x000012C8
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000030CB File Offset: 0x000012CB
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000030E8 File Offset: 0x000012E8
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003149 File Offset: 0x00001349
		private void SphinxR7_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/SPscript1");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003157 File Offset: 0x00001357
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000315A File Offset: 0x0000135A
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000315D File Offset: 0x0000135D
		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003160 File Offset: 0x00001360
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003164 File Offset: 0x00001364
		private void TapButton_Click(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			bool flag = clickedButton != null && this.buttonTexts.ContainsKey(clickedButton.Name);
			if (flag)
			{
				string textToDisplay = this.buttonTexts[clickedButton.Name];
				this.fastColoredTextBox1.Text = textToDisplay;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000031B8 File Offset: 0x000013B8
		private void NewTap_Click(object sender, EventArgs e)
		{
			RenameForm renameForm = new RenameForm("Tap" + (this.tapCounter + 1).ToString());
			bool flag = renameForm.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string newName = renameForm.NewName;
				Button newTap = new Button();
				newTap.BackColor = Color.FromArgb(40, 40, 40);
				newTap.FlatAppearance.BorderSize = 0;
				newTap.FlatStyle = FlatStyle.Flat;
				newTap.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
				newTap.Location = new Point(12 + 140 * this.tapCounter, 45);
				newTap.Name = newName;
				newTap.Size = new Size(119, 23);
				newTap.TabIndex = 12 + this.tapCounter;
				newTap.Text = newName;
				newTap.UseVisualStyleBackColor = false;
				Button deleteButton = new Button();
				deleteButton.BackColor = Color.Transparent;
				deleteButton.FlatStyle = FlatStyle.Flat;
				deleteButton.FlatAppearance.BorderSize = 0;
				deleteButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
				deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0, 0);
				deleteButton.Size = new Size(20, 20);
				deleteButton.Location = new Point(newTap.Width - 25, 3);
				deleteButton.Text = "X";
				deleteButton.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
				deleteButton.ForeColor = Color.White;
				deleteButton.Click += delegate(object s, EventArgs ev)
				{
					this.PanelE.Controls.Remove(newTap);
				};
				newTap.Controls.Add(deleteButton);
				this.PanelE.Controls.Add(newTap);
				string tapsFolderPath = "C:\\Taps";
				bool flag2 = !Directory.Exists(tapsFolderPath);
				if (flag2)
				{
					Directory.CreateDirectory(tapsFolderPath);
				}
				string filePath = Path.Combine(tapsFolderPath, newName + ".txt");
				File.WriteAllText(filePath, this.fastColoredTextBox1.Text);
				this.tapCounter++;
				this.NewTapButton.Location = new Point(12 + 140 * this.tapCounter, 45);
				newTap.Click += delegate(object s, EventArgs ev)
				{
					bool flag3 = File.Exists(filePath);
					if (flag3)
					{
						this.fastColoredTextBox1.Text = File.ReadAllText(filePath);
					}
				};
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003470 File Offset: 0x00001670
		private void SaveButtonsState()
		{
			string tapsFolderPath = "C:\\Taps";
			bool flag = !Directory.Exists(tapsFolderPath);
			if (flag)
			{
				Directory.CreateDirectory(tapsFolderPath);
			}
			string jsonFilePath = Path.Combine(tapsFolderPath, "buttonsState.json");
			List<ButtonData> buttonsData = new List<ButtonData>();
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				Button button = control as Button;
				bool flag2 = button != null && button.Name.StartsWith("Tap");
				if (flag2)
				{
					buttonsData.Add(new ButtonData
					{
						Name = button.Name,
						Text = button.Text,
						Location = button.Location
					});
				}
			}
			string json = JsonConvert.SerializeObject(buttonsData, Formatting.Indented);
			File.WriteAllText(jsonFilePath, json);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003570 File Offset: 0x00001770
		private void Tap_Click(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			bool flag = clickedButton != null && this.buttonTexts.ContainsKey(clickedButton.Name);
			if (flag)
			{
				string textToDisplay = this.buttonTexts[clickedButton.Name];
				this.fastColoredTextBox1.Text = textToDisplay;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000035C1 File Offset: 0x000017C1
		private void Tap1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000035C4 File Offset: 0x000017C4
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000035C7 File Offset: 0x000017C7
		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000035CA File Offset: 0x000017CA
		private void button1_Click_1(object sender, EventArgs e)
		{
			Setting.ShowSettings();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000035D3 File Offset: 0x000017D3
		private void PanelE_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000035D6 File Offset: 0x000017D6
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000035DC File Offset: 0x000017DC
		private void InjectButton_Click(object sender, EventArgs e)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/c your_inject_command";
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.CreateNoWindow = true;
			using (Process process = new Process())
			{
				process.StartInfo = processStartInfo;
				process.Start();
				string output = process.StandardOutput.ReadToEnd();
				string error = process.StandardError.ReadToEnd();
				process.WaitForExit();
				bool flag = !string.IsNullOrEmpty(error);
				if (flag)
				{
					MessageBox.Show("Error: " + error);
				}
				else
				{
					MessageBox.Show("Output: " + output);
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000036B4 File Offset: 0x000018B4
		private void SetButtonProperties(Button button)
		{
			button.BackColor = Color.FromArgb(40, 40, 40);
			button.FlatAppearance.BorderSize = 0;
			button.FlatStyle = FlatStyle.Flat;
			button.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0);
			button.Size = new Size(119, 23);
			button.UseVisualStyleBackColor = false;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000371C File Offset: 0x0000191C
		private void SetDeleteButtonProperties(Button deleteButton)
		{
			deleteButton.BackColor = Color.Transparent;
			deleteButton.FlatStyle = FlatStyle.Flat;
			deleteButton.FlatAppearance.BorderSize = 0;
			deleteButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
			deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0, 0);
			deleteButton.Size = new Size(20, 20);
			deleteButton.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			deleteButton.ForeColor = Color.White;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000037A8 File Offset: 0x000019A8
		private void LoadButtonsState()
		{
			string tapsFolderPath = "C:\\Taps";
			string jsonFilePath = Path.Combine(tapsFolderPath, "buttonsState.json");
			bool flag = File.Exists(jsonFilePath);
			if (flag)
			{
				string json = File.ReadAllText(jsonFilePath);
				List<ButtonData> buttonsData = JsonConvert.DeserializeObject<List<ButtonData>>(json);
				foreach (ButtonData data in buttonsData)
				{
					Button newTap = new Button
					{
						Name = data.Name,
						Text = data.Text,
						Location = data.Location,
						BackColor = Color.FromArgb(40, 40, 40),
						FlatAppearance = 
						{
							BorderSize = 0
						},
						FlatStyle = FlatStyle.Flat,
						Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 0),
						Size = new Size(119, 23),
						UseVisualStyleBackColor = false
					};
					base.Controls.Add(newTap);
				}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000038C4 File Offset: 0x00001AC4
		private void EnsureTapsDirectoryExists()
		{
			string tapsDirectory = Path.Combine(Application.StartupPath, "Taps");
			bool flag = !Directory.Exists(tapsDirectory);
			if (flag)
			{
				Directory.CreateDirectory(tapsDirectory);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000038F8 File Offset: 0x00001AF8
		private void SaveTextToFiles()
		{
			string filePath = Path.Combine(Application.StartupPath, "Taps", "savedText.txt");
			string textToSave = "النصوص التي تريد حفظها";
			File.WriteAllText(filePath, textToSave);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000392C File Offset: 0x00001B2C
		private Point GetDeleteButtonLocation(Button button)
		{
			Control deleteButton = button.Controls.OfType<Button>().FirstOrDefault((Button btn) => btn.Text == "X");
			bool flag = deleteButton != null;
			Point result;
			if (flag)
			{
				result = deleteButton.Location;
			}
			else
			{
				result = new Point(-1, -1);
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003988 File Offset: 0x00001B88
		private void Semo_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F4;
			if (flag)
			{
				Process.Start("cmd.exe");
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000039B4 File Offset: 0x00001BB4
		private void label1_Click_1(object sender, EventArgs e)
		{
			bool flag = Api.IsInjected();
			if (flag)
			{
				this.CheckInject.Text = "Statue: Injected";
				this.CheckInject.ForeColor = Color.Green;
			}
			else
			{
				this.CheckInject.Text = "Statue: Injected!";
				this.CheckInject.ForeColor = Color.Red;
			}
		}

		// Token: 0x0400000C RID: 12
		private WebClient wc = new WebClient();

		// Token: 0x0400000D RID: 13
		private string defPath = Path.Combine(Application.StartupPath, "Monaco");

		// Token: 0x0400000E RID: 14
		private Point lastPoint;

		// Token: 0x0400000F RID: 15
		private string lastTextFilePath = Path.Combine(Application.StartupPath, "LastText", "LastText.txt");

		// Token: 0x04000010 RID: 16
		private int tapCounter = 0;

		// Token: 0x04000011 RID: 17
		private Dictionary<string, string> buttonTexts = new Dictionary<string, string>();
	}
}
