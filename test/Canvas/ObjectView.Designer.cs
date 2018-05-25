namespace MidasMain.UML
{
    partial class ObjectView
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.oolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ClassName";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oolStripMenuItem,
            this.renameToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(142, 48);
            // 
            // oolStripMenuItem
            // 
            this.oolStripMenuItem.Name = "oolStripMenuItem";
            this.oolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oolStripMenuItem.Text = "AddMember";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // ObjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CausesValidation = false;
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Controls.Add(this.metroLabel1);
            this.DoubleBuffered = true;
            this.Name = "ObjectView";
            this.Size = new System.Drawing.Size(109, 100);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintObjectView);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PointerDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PointerMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PointerUp);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem oolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
    }
}
