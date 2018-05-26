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
            this.metroLink3 = new MetroFramework.Controls.MetroLink();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.furnitureView1 = new MidasMain.Canvas.FurnitureView();
            this.dragItem4 = new MidasMain.Canvas.DragItem();
            this.dragItem3 = new MidasMain.Canvas.DragItem();
            this.dragItem2 = new MidasMain.Canvas.DragItem();
            this.dragItem1 = new MidasMain.Canvas.DragItem();
            this.canvas1 = new MidasMain.Canvas.Canvas();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.creaditPanel1 = new MidasMain.Creadit.CreaditPanel();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
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
            this.metroTabPage1.Controls.Add(this.furnitureView1);
            this.metroTabPage1.Controls.Add(this.dragItem4);
            this.metroTabPage1.Controls.Add(this.dragItem3);
            this.metroTabPage1.Controls.Add(this.dragItem2);
            this.metroTabPage1.Controls.Add(this.dragItem1);
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
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLink3);
            this.metroPanel1.Controls.Add(this.metroLink2);
            this.metroPanel1.Controls.Add(this.metroLink1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(160, 420);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLink3
            // 
            this.metroLink3.Location = new System.Drawing.Point(19, 131);
            this.metroLink3.Name = "metroLink3";
            this.metroLink3.Size = new System.Drawing.Size(114, 40);
            this.metroLink3.TabIndex = 11;
            this.metroLink3.Text = "Load";
            this.metroLink3.UseSelectable = true;
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(19, 85);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(114, 40);
            this.metroLink2.TabIndex = 10;
            this.metroLink2.Text = "Save";
            this.metroLink2.UseSelectable = true;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(19, 39);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(114, 40);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.Tag = "";
            this.metroLink1.Text = "New";
            this.metroLink1.UseSelectable = true;
            // 
            // furnitureView1
            // 
            this.furnitureView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.furnitureView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.furnitureView1.CausesValidation = false;
            this.furnitureView1.Coordinate = new System.Drawing.Point(417, 211);
            this.furnitureView1.Location = new System.Drawing.Point(417, 211);
            this.furnitureView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.furnitureView1.Name = "furnitureView1";
            this.furnitureView1.Size = new System.Drawing.Size(51, 50);
            this.furnitureView1.TabIndex = 7;
            // 
            // dragItem4
            // 
            this.dragItem4.BackColor = System.Drawing.SystemColors.Control;
            this.dragItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragItem4.CausesValidation = false;
            this.dragItem4.Location = new System.Drawing.Point(619, 214);
            this.dragItem4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dragItem4.Name = "dragItem4";
            this.dragItem4.Size = new System.Drawing.Size(42, 47);
            this.dragItem4.TabIndex = 6;
            // 
            // dragItem3
            // 
            this.dragItem3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dragItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragItem3.CausesValidation = false;
            this.dragItem3.Location = new System.Drawing.Point(284, 282);
            this.dragItem3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dragItem3.Name = "dragItem3";
            this.dragItem3.Size = new System.Drawing.Size(170, 124);
            this.dragItem3.TabIndex = 5;
            // 
            // dragItem2
            // 
            this.dragItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dragItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragItem2.CausesValidation = false;
            this.dragItem2.Location = new System.Drawing.Point(406, 191);
            this.dragItem2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dragItem2.Name = "dragItem2";
            this.dragItem2.Size = new System.Drawing.Size(181, 124);
            this.dragItem2.TabIndex = 4;
            // 
            // dragItem1
            // 
            this.dragItem1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dragItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragItem1.CausesValidation = false;
            this.dragItem1.Location = new System.Drawing.Point(241, 191);
            this.dragItem1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dragItem1.Name = "dragItem1";
            this.dragItem1.Size = new System.Drawing.Size(170, 124);
            this.dragItem1.TabIndex = 3;
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
            this.metroTabPage3.Size = new System.Drawing.Size(860, 420);
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
            this.creaditPanel1.Size = new System.Drawing.Size(860, 420);
            this.creaditPanel1.TabIndex = 2;
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(19, 214);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(116, 55);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "TestDataLoad";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
        private Canvas.DragItem dragItem1;
        private Canvas.DragItem dragItem3;
        private Canvas.DragItem dragItem2;
        private Canvas.DragItem dragItem4;
        private Canvas.FurnitureView furnitureView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink metroLink3;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}