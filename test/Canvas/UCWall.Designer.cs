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
            this.makeDoorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDoorUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDoorLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeDoorRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeWindowDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeWindowUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeWindowLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeWindowRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeDoorToolStripMenuItem,
            this.makeDoorUpToolStripMenuItem,
            this.makeDoorLeftToolStripMenuItem,
            this.makeDoorRightToolStripMenuItem,
            this.makeWindowDownToolStripMenuItem,
            this.makeWindowUpToolStripMenuItem,
            this.makeWindowLeftToolStripMenuItem,
            this.makeWindowRightToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(218, 196);
            // 
            // makeDoorToolStripMenuItem
            // 
            this.makeDoorToolStripMenuItem.Name = "makeDoorToolStripMenuItem";
            this.makeDoorToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeDoorToolStripMenuItem.Text = "Make door down";
            this.makeDoorToolStripMenuItem.Click += new System.EventHandler(this.makeDoorToolStripMenuItem_Click);
            // 
            // makeDoorUpToolStripMenuItem
            // 
            this.makeDoorUpToolStripMenuItem.Name = "makeDoorUpToolStripMenuItem";
            this.makeDoorUpToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeDoorUpToolStripMenuItem.Text = "Make door up";
            this.makeDoorUpToolStripMenuItem.Click += new System.EventHandler(this.makeDoorUpToolStripMenuItem_Click);
            // 
            // makeDoorLeftToolStripMenuItem
            // 
            this.makeDoorLeftToolStripMenuItem.Name = "makeDoorLeftToolStripMenuItem";
            this.makeDoorLeftToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeDoorLeftToolStripMenuItem.Text = "Make door left";
            this.makeDoorLeftToolStripMenuItem.Click += new System.EventHandler(this.makeDoorLeftToolStripMenuItem_Click);
            // 
            // makeDoorRightToolStripMenuItem
            // 
            this.makeDoorRightToolStripMenuItem.Name = "makeDoorRightToolStripMenuItem";
            this.makeDoorRightToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeDoorRightToolStripMenuItem.Text = "Make door right";
            this.makeDoorRightToolStripMenuItem.Click += new System.EventHandler(this.makeDoorRightToolStripMenuItem_Click);
            // 
            // makeWindowDownToolStripMenuItem
            // 
            this.makeWindowDownToolStripMenuItem.Name = "makeWindowDownToolStripMenuItem";
            this.makeWindowDownToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeWindowDownToolStripMenuItem.Text = "Make window down";
            this.makeWindowDownToolStripMenuItem.Click += new System.EventHandler(this.makeWindowDownToolStripMenuItem_Click);
            // 
            // makeWindowUpToolStripMenuItem
            // 
            this.makeWindowUpToolStripMenuItem.Name = "makeWindowUpToolStripMenuItem";
            this.makeWindowUpToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeWindowUpToolStripMenuItem.Text = "Make window up";
            this.makeWindowUpToolStripMenuItem.Click += new System.EventHandler(this.makeWindowUpToolStripMenuItem_Click);
            // 
            // makeWindowLeftToolStripMenuItem
            // 
            this.makeWindowLeftToolStripMenuItem.Name = "makeWindowLeftToolStripMenuItem";
            this.makeWindowLeftToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeWindowLeftToolStripMenuItem.Text = "Make window left";
            this.makeWindowLeftToolStripMenuItem.Click += new System.EventHandler(this.makeWindowLeftToolStripMenuItem_Click);
            // 
            // makeWindowRightToolStripMenuItem
            // 
            this.makeWindowRightToolStripMenuItem.Name = "makeWindowRightToolStripMenuItem";
            this.makeWindowRightToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.makeWindowRightToolStripMenuItem.Text = "Make window Right";
            this.makeWindowRightToolStripMenuItem.Click += new System.EventHandler(this.makeWindowRightToolStripMenuItem_Click);
            // 
            // UCWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCWall";
            this.Size = new System.Drawing.Size(0, 0);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UCWall_MouseDown);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem makeDoorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeDoorUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeDoorLeftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeDoorRightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeWindowDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeWindowUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeWindowLeftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem makeWindowRightToolStripMenuItem;
	}
}
