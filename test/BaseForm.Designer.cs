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
			this.components = new System.ComponentModel.Container();
			this.MainTab = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.canvas1 = new MidasMain.Canvas.Canvas();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.creaditPanel1 = new MidasMain.Creadit.CreaditPanel();
			this.ucObject1 = new MidasMain.Canvas.UCObject();
			this.ucRoom1 = new MidasMain.Canvas.UCRoom();
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
			this.MainTab.Location = new System.Drawing.Point(20, 60);
			this.MainTab.Name = "MainTab";
			this.MainTab.SelectedIndex = 0;
			this.MainTab.Size = new System.Drawing.Size(760, 370);
			this.MainTab.TabIndex = 0;
			this.MainTab.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.ucRoom1);
			this.metroTabPage1.Controls.Add(this.ucObject1);
			this.metroTabPage1.Controls.Add(this.metroPanel1);
			this.metroTabPage1.Controls.Add(this.canvas1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(752, 328);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Main";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.metroPanel1.Controls.Add(this.metroTile4);
			this.metroPanel1.Controls.Add(this.metroTile3);
			this.metroPanel1.Controls.Add(this.metroTile2);
			this.metroPanel1.Controls.Add(this.metroTile1);
			this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 8;
			this.metroPanel1.Location = new System.Drawing.Point(0, 0);
			this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(173, 328);
			this.metroPanel1.TabIndex = 4;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 9;
			// 
			// metroTile4
			// 
			this.metroTile4.ActiveControl = null;
			this.metroTile4.Location = new System.Drawing.Point(88, 85);
			this.metroTile4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(66, 61);
			this.metroTile4.TabIndex = 5;
			this.metroTile4.Text = "Test";
			this.metroTile4.UseSelectable = true;
			this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
			// 
			// metroTile3
			// 
			this.metroTile3.ActiveControl = null;
			this.metroTile3.Location = new System.Drawing.Point(18, 85);
			this.metroTile3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(66, 61);
			this.metroTile3.TabIndex = 4;
			this.metroTile3.Text = "Load";
			this.metroTile3.UseSelectable = true;
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.Location = new System.Drawing.Point(88, 19);
			this.metroTile2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(66, 61);
			this.metroTile2.TabIndex = 3;
			this.metroTile2.Text = "Save";
			this.metroTile2.UseSelectable = true;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.Location = new System.Drawing.Point(18, 19);
			this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(66, 61);
			this.metroTile1.TabIndex = 2;
			this.metroTile1.Text = "New";
			this.metroTile1.UseSelectable = true;
			// 
			// canvas1
			// 
			this.canvas1.AutoScroll = true;
			this.canvas1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvas1.Location = new System.Drawing.Point(0, 0);
			this.canvas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.canvas1.Name = "canvas1";
			this.canvas1.Size = new System.Drawing.Size(752, 328);
			this.canvas1.TabIndex = 2;
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.Controls.Add(this.creaditPanel1);
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(752, 328);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "Creadit";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 10;
			// 
			// creaditPanel1
			// 
			this.creaditPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.creaditPanel1.Location = new System.Drawing.Point(0, 0);
			this.creaditPanel1.Name = "creaditPanel1";
			this.creaditPanel1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
			this.creaditPanel1.Size = new System.Drawing.Size(752, 328);
			this.creaditPanel1.TabIndex = 2;
			// 
			// ucObject1
			// 
			this.ucObject1.BackColor = System.Drawing.Color.Blue;
			this.ucObject1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucObject1.CausesValidation = false;
			this.ucObject1.Location = new System.Drawing.Point(307, 104);
			this.ucObject1.Name = "ucObject1";
			this.ucObject1.Size = new System.Drawing.Size(109, 100);
			this.ucObject1.TabIndex = 5;
			// 
			// ucRoom1
			// 
			this.ucRoom1.BackColor = System.Drawing.Color.Red;
			this.ucRoom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRoom1.CausesValidation = false;
			this.ucRoom1.Location = new System.Drawing.Point(478, 59);
			this.ucRoom1.Name = "ucRoom1";
			this.ucRoom1.Size = new System.Drawing.Size(206, 199);
			this.ucRoom1.TabIndex = 6;
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MainTab);
			this.Name = "BaseForm";
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
		private Canvas.UCRoom ucRoom1;
		private Canvas.UCObject ucObject1;
	}
}