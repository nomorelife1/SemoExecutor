using System;
using System.IO;
using System.Windows.Forms;

namespace Semo_Beta
{
	// Token: 0x02000007 RID: 7
	internal class Functions
	{
		// Token: 0x06000051 RID: 81 RVA: 0x0000524C File Offset: 0x0000344C
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			try
			{
				DirectoryInfo dinfo = new DirectoryInfo(Folder);
				FileInfo[] Files = dinfo.GetFiles(FileType);
				foreach (FileInfo file in Files)
				{
					lsb.Items.Add(file.Name);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading files: " + ex.Message, "Error");
			}
		}
	}
}
