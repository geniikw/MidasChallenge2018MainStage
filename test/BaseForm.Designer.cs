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
            this.dragItem4 = new MidasMain.Canvas.DragItem();
            this.dragItem3 = new MidasMain.Canvas.DragItem();
            this.dragItem2 = new MidasMain.Canvas.DragItem();
            this.dragItem1 = new MidasMain.Canvas.DragItem();
            this.canvas1 = new MidasMain.Canvas.Canvas();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.creaditPanel1 = new MidasMain.Creadit.CreaditPanel();
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
            // dragItem4
            // 
            this.dragItem4.BackColor = System.Drawing.SystemColors.Control;
            this.dragItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragItem4.CausesValidation = false;
            this.dragItem4.Location = new System.Drawing.Point(508, 205);
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
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(860, 420);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Setting";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 11;
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
        private Canvas.DragItem dragItem1;
        private Canvas.DragItem dragItem3;
        private Canvas.DragItem dragItem2;
        private Canvas.DragItem dragItem4;
    }
}