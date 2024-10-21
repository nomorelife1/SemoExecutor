using System;
using System.Drawing;

// Token: 0x02000002 RID: 2
public class ButtonData
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
	// (set) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	public string Name { get; set; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002059 File Offset: 0x00000259
	// (set) Token: 0x06000004 RID: 4 RVA: 0x00002061 File Offset: 0x00000261
	public string Text { get; set; }

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206A File Offset: 0x0000026A
	// (set) Token: 0x06000006 RID: 6 RVA: 0x00002072 File Offset: 0x00000272
	public Point Location { get; set; }
}
