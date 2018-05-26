namespace MidasMain.CanvasSpace
{
	partial class UCObject
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
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sofaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tolietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.metroContextMenu1.Size = new System.Drawing.Size(137, 52);
            // 
            // setColorToolStripMenuItem
            // 
            this.setColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.redToolStripMenuItem});
            this.setColorToolStripMenuItem.Name = "setColorToolStripMenuItem";
            this.setColorToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.setColorToolStripMenuItem.Text = "SetColor";
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.blackToolStripMenuItem.Text = "Black";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // setTileToolStripMenuItem
            // 
            this.setTileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sofaToolStripMenuItem,
            this.tolietToolStripMenuItem});
            this.setTileToolStripMenuItem.Name = "setTileToolStripMenuItem";
            this.setTileToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.setTileToolStripMenuItem.Text = "SetTile";
            // 
            // sofaToolStripMenuItem
            // 
            this.sofaToolStripMenuItem.Name = "sofaToolStripMenuItem";
            this.sofaToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.sofaToolStripMenuItem.Text = "Sofa";
            this.sofaToolStripMenuItem.Click += new System.EventHandler(this.sofaToolStripMenuItem_Click);
            // 
            // tolietToolStripMenuItem
            // 
            this.tolietToolStripMenuItem.Name = "tolietToolStripMenuItem";
            this.tolietToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.tolietToolStripMenuItem.Text = "Toliet";
            this.tolietToolStripMenuItem.Click += new System.EventHandler(this.tolietToolStripMenuItem_Click);
            // 
            // UCObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UCObject";
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem setColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setTileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sofaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tolietToolStripMenuItem;
    }
}
