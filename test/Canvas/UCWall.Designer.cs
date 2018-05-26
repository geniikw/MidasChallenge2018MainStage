namespace MidasMain.CanvasSpace
{
	partial class UCWall
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tttt3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.test1ToolStripMenuItem,
            this.tttt3ToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(153, 92);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.testToolStripMenuItem.Text = "test";
			// 
			// test1ToolStripMenuItem
			// 
			this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
			this.test1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.test1ToolStripMenuItem.Text = "test1";
			// 
			// tttt3ToolStripMenuItem
			// 
			this.tttt3ToolStripMenuItem.Name = "tttt3ToolStripMenuItem";
			this.tttt3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tttt3ToolStripMenuItem.Text = "tttt3";
			// 
			// UCWall
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.Name = "UCWall";
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tttt3ToolStripMenuItem;
	}
}
