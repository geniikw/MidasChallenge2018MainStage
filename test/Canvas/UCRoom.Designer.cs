namespace MidasMain.CanvasSpace
{
	partial class UCRoom
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
			this.setColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tile0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tile1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tile2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tile3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.metroContextMenu1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setColorToolStripMenuItem,
            this.setTileToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(153, 70);
			// 
			// setColorToolStripMenuItem
			// 
			this.setColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.whiteToolStripMenuItem});
			this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
			this.setColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.setColorToolStripMenuItem.Text = "SetColor";
			// 
			// redToolStripMenuItem
			// 
			this.redToolStripMenuItem.Name = "redToolStripMenuItem";
			this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.redToolStripMenuItem.Text = "Red";
			this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
			// 
			// blueToolStripMenuItem
			// 
			this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
			this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.blueToolStripMenuItem.Text = "Blue";
			this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
			// 
			// greenToolStripMenuItem
			// 
			this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
			this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.greenToolStripMenuItem.Text = "Green";
			this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
			// 
			// whiteToolStripMenuItem
			// 
			this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
			this.whiteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
			this.whiteToolStripMenuItem.Text = "White";
			this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
			// 
			// setTileToolStripMenuItem
			// 
			this.setTileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tile0ToolStripMenuItem,
            this.tile1ToolStripMenuItem,
            this.tile2ToolStripMenuItem,
            this.tile3ToolStripMenuItem});
			this.setTileToolStripMenuItem.Name = "setTileToolStripMenuItem";
			this.setTileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.setTileToolStripMenuItem.Text = "SetTile";
			// 
			// tile0ToolStripMenuItem
			// 
			this.tile0ToolStripMenuItem.Name = "tile0ToolStripMenuItem";
			this.tile0ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tile0ToolStripMenuItem.Text = "tile0";
			this.tile0ToolStripMenuItem.Click += new System.EventHandler(this.tile0ToolStripMenuItem_Click);
			// 
			// tile1ToolStripMenuItem
			// 
			this.tile1ToolStripMenuItem.Name = "tile1ToolStripMenuItem";
			this.tile1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tile1ToolStripMenuItem.Text = "tile1";
			this.tile1ToolStripMenuItem.Click += new System.EventHandler(this.tile1ToolStripMenuItem_Click);
			// 
			// tile2ToolStripMenuItem
			// 
			this.tile2ToolStripMenuItem.Name = "tile2ToolStripMenuItem";
			this.tile2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tile2ToolStripMenuItem.Text = "tile2";
			this.tile2ToolStripMenuItem.Click += new System.EventHandler(this.tile2ToolStripMenuItem_Click);
			// 
			// tile3ToolStripMenuItem
			// 
			this.tile3ToolStripMenuItem.Name = "tile3ToolStripMenuItem";
			this.tile3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tile3ToolStripMenuItem.Text = "tile3";
			this.tile3ToolStripMenuItem.Click += new System.EventHandler(this.tile3ToolStripMenuItem_Click);
			// 
			// UCRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ContextMenuStrip = this.metroContextMenu1;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "UCRoom";
			this.metroContextMenu1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setTileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tile0ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tile1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tile2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tile3ToolStripMenuItem;
	}
}
