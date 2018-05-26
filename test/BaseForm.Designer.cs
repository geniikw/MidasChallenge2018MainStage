namespace MidasMain
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonObject = new MetroFramework.Controls.MetroTile();
            this.metroButtonRoom = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.canvas1 = new MidasMain.Canvas.Canvas();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.creaditPanel1 = new MidasMain.Creadit.CreaditPanel();
            this.MainTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.metroTabPage1);
            this.MainTab.Controls.Add(this.metroTabPage3);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(23, 75);
            this.MainTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(868, 462);
            this.MainTab.TabIndex = 0;
            this.MainTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.canvas1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(860, 420);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Main";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 11;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.metroPanel1.Controls.Add(this.metroButtonObject);
            this.metroPanel1.Controls.Add(this.metroButtonRoom);
            this.metroPanel1.Controls.Add(this.metroTile4);
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(198, 420);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButtonObject
            // 
            this.metroButtonObject.ActiveControl = null;
            this.metroButtonObject.Location = new System.Drawing.Point(21, 268);
            this.metroButtonObject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButtonObject.Name = "metroButtonObject";
            this.metroButtonObject.Size = new System.Drawing.Size(155, 45);
            this.metroButtonObject.TabIndex = 7;
            this.metroButtonObject.Text = "Object";
            this.metroButtonObject.UseSelectable = true;
            this.metroButtonObject.Click += new System.EventHandler(this.metroButtonObject_Click);
            // 
            // metroButtonRoom
            // 
            this.metroButtonRoom.ActiveControl = null;
            this.metroButtonRoom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButtonRoom.Location = new System.Drawing.Point(21, 215);
            this.metroButtonRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButtonRoom.Name = "metroButtonRoom";
            this.metroButtonRoom.Size = new System.Drawing.Size(155, 45);
            this.metroButtonRoom.TabIndex = 6;
            this.metroButtonRoom.Text = "Room";
            this.metroButtonRoom.UseSelectable = true;
            this.metroButtonRoom.Click += new System.EventHandler(this.metroButtonRoom_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(101, 106);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(75, 76);
            this.metroTile4.TabIndex = 5;
            this.metroTile4.Text = "Test";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.MakeTestDataButton);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(21, 106);
            this.metroTile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(75, 76);
            this.metroTile3.TabIndex = 4;
            this.metroTile3.Text = "Load";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.LoadButton);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(101, 24);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 76);
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Save";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.SaveButton);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(21, 24);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 76);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "New";
            this.metroTile1.UseSelectable = true;
            // 
            // canvas1
            // 
            this.canvas1.AutoScroll = true;
            this.canvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas1.Location = new System.Drawing.Point(0, 0);
            this.canvas1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(860, 420);
            this.canvas1.TabIndex = 2;
            this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.creaditPanel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(861, 420);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Creadit";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 11;
            // 
            // creaditPanel1
            // 
            this.creaditPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creaditPanel1.Location = new System.Drawing.Point(0, 0);
            this.creaditPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.creaditPanel1.Name = "creaditPanel1";
            this.creaditPanel1.Padding = new System.Windows.Forms.Padding(23, 25, 23, 25);
            this.creaditPanel1.Size = new System.Drawing.Size(861, 420);
            this.creaditPanel1.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.MainTab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(23, 75, 23, 25);
            this.Text = "MIDAS2018";
            this.MainTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Creadit.CreaditPanel creaditPanel1;
        private Canvas.Canvas canvas1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroButtonObject;
		private MetroFramework.Controls.MetroTile metroButtonRoom;
	}
}