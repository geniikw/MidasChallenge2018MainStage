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
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.canvas1 = new MidasMain.Canvas.Canvas();
			this.creaditPanel1 = new MidasMain.Creadit.CreaditPanel();
			this.ucRoom1 = new MidasMain.Canvas.UCScaleAble();
			this.MainTab.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.metroTabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainTab
			// 
			this.MainTab.Controls.Add(this.metroTabPage1);
			this.MainTab.Controls.Add(this.metroTabPage2);
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
			// metroTabPage2
			// 
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(752, 328);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "Setting";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
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
			// creaditPanel1
			// 
			this.creaditPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.creaditPanel1.Location = new System.Drawing.Point(0, 0);
			this.creaditPanel1.Name = "creaditPanel1";
			this.creaditPanel1.Padding = new System.Windows.Forms.Padding(20);
			this.creaditPanel1.Size = new System.Drawing.Size(752, 328);
			this.creaditPanel1.TabIndex = 2;
			// 
			// ucRoom1
			// 
			this.ucRoom1.BackColor = System.Drawing.Color.Red;
			this.ucRoom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ucRoom1.CausesValidation = false;
			this.ucRoom1.Location = new System.Drawing.Point(108, 149);
			this.ucRoom1.Name = "ucRoom1";
			this.ucRoom1.Size = new System.Drawing.Size(109, 100);
			this.ucRoom1.TabIndex = 3;
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
			this.metroTabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Creadit.CreaditPanel creaditPanel1;
        private Canvas.Canvas canvas1;
		private Canvas.UCScaleAble ucRoom1;
	}
}