﻿namespace MidasMain
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
			this.AlarmLabel = new MetroFramework.Controls.MetroLabel();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroTile5 = new MetroFramework.Controls.MetroTile();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButtonObject = new MetroFramework.Controls.MetroTile();
			this.metroButtonRoom = new MetroFramework.Controls.MetroTile();
			this.metroTile4 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.canvas1 = new MidasMain.CanvasSpace.Canvas();
			this.creditPanel1 = new MidasMain.Creadit.CreditPanel();
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
			this.MainTab.Size = new System.Drawing.Size(1400, 820);
			this.MainTab.TabIndex = 0;
			this.MainTab.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.AlarmLabel);
			this.metroTabPage1.Controls.Add(this.metroButton2);
			this.metroTabPage1.Controls.Add(this.metroPanel1);
			this.metroTabPage1.Controls.Add(this.canvas1);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(1392, 778);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "Main";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// AlarmLabel
			// 
			this.AlarmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AlarmLabel.AutoSize = true;
			this.AlarmLabel.BackColor = System.Drawing.Color.White;
			this.AlarmLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.AlarmLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.AlarmLabel.ForeColor = System.Drawing.Color.PowderBlue;
			this.AlarmLabel.Location = new System.Drawing.Point(1134, 752);
			this.AlarmLabel.Name = "AlarmLabel";
			this.AlarmLabel.Size = new System.Drawing.Size(0, 0);
			this.AlarmLabel.TabIndex = 9;
			this.AlarmLabel.UseCustomBackColor = true;
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(7, 6);
			this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(46, 18);
			this.metroButton2.TabIndex = 8;
			this.metroButton2.Text = "Open";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Visible = false;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.metroPanel1.Controls.Add(this.metroTile5);
			this.metroPanel1.Controls.Add(this.metroButton1);
			this.metroPanel1.Controls.Add(this.metroButtonObject);
			this.metroPanel1.Controls.Add(this.metroButtonRoom);
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
			this.metroPanel1.Size = new System.Drawing.Size(172, 778);
			this.metroPanel1.TabIndex = 4;
			this.metroPanel1.UseCustomBackColor = true;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 9;
			// 
			// metroTile5
			// 
			this.metroTile5.ActiveControl = null;
			this.metroTile5.Location = new System.Drawing.Point(18, 257);
			this.metroTile5.Name = "metroTile5";
			this.metroTile5.Size = new System.Drawing.Size(136, 36);
			this.metroTile5.TabIndex = 8;
			this.metroTile5.Text = "Validation";
			this.metroTile5.UseSelectable = true;
			this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
			// 
			// metroButton1
			// 
			this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.metroButton1.Location = new System.Drawing.Point(123, 758);
			this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(46, 18);
			this.metroButton1.TabIndex = 5;
			this.metroButton1.Text = "Close";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroButtonObject
			// 
			this.metroButtonObject.ActiveControl = null;
			this.metroButtonObject.Location = new System.Drawing.Point(18, 214);
			this.metroButtonObject.Name = "metroButtonObject";
			this.metroButtonObject.Size = new System.Drawing.Size(136, 36);
			this.metroButtonObject.TabIndex = 7;
			this.metroButtonObject.Text = "Object";
			this.metroButtonObject.UseSelectable = true;
			this.metroButtonObject.Click += new System.EventHandler(this.SelectRoomButton);
			// 
			// metroButtonRoom
			// 
			this.metroButtonRoom.ActiveControl = null;
			this.metroButtonRoom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.metroButtonRoom.Location = new System.Drawing.Point(18, 172);
			this.metroButtonRoom.Name = "metroButtonRoom";
			this.metroButtonRoom.Size = new System.Drawing.Size(136, 36);
			this.metroButtonRoom.TabIndex = 6;
			this.metroButtonRoom.Text = "Room";
			this.metroButtonRoom.UseSelectable = true;
			this.metroButtonRoom.Click += new System.EventHandler(this.SelectObjectButton);
			// 
			// metroTile4
			// 
			this.metroTile4.ActiveControl = null;
			this.metroTile4.Location = new System.Drawing.Point(88, 85);
			this.metroTile4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.metroTile4.Name = "metroTile4";
			this.metroTile4.Size = new System.Drawing.Size(66, 61);
			this.metroTile4.TabIndex = 5;
			this.metroTile4.Text = "Export";
			this.metroTile4.UseSelectable = true;
			this.metroTile4.Click += new System.EventHandler(this.CaputreScreen);
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
			this.metroTile3.Click += new System.EventHandler(this.LoadButton);
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
			this.metroTile2.Click += new System.EventHandler(this.SaveButton);
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
			this.metroTile1.Click += new System.EventHandler(this.NewButton);
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.Controls.Add(this.creditPanel1);
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(1392, 898);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "Credit";
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
			this.canvas1.Size = new System.Drawing.Size(1392, 778);
			this.canvas1.TabIndex = 2;
			this.canvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas1_MouseDown);
			// 
			// creditPanel1
			// 
			this.creditPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.creditPanel1.Location = new System.Drawing.Point(0, 0);
			this.creditPanel1.Name = "creditPanel1";
			this.creditPanel1.Padding = new System.Windows.Forms.Padding(20);
			this.creditPanel1.Size = new System.Drawing.Size(1392, 898);
			this.creditPanel1.TabIndex = 2;
			// 
			// BaseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1440, 900);
			this.Controls.Add(this.MainTab);
			this.Name = "BaseForm";
			this.ShowIcon = false;
			this.Text = "MIDAS2018";
			this.TransparencyKey = System.Drawing.Color.Magenta;
			this.Load += new System.EventHandler(this.BaseForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownHandler);
			this.MainTab.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.metroTabPage1.PerformLayout();
			this.metroPanel1.ResumeLayout(false);
			this.metroTabPage3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private Creadit.CreditPanel creditPanel1;
        private CanvasSpace.Canvas canvas1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroButtonObject;
		private MetroFramework.Controls.MetroTile metroButtonRoom;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroLabel AlarmLabel;
        private MetroFramework.Controls.MetroTile metroTile5;
    }
}