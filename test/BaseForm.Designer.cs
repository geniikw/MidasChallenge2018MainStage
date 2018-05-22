using Markdig;
using System.IO;
using Zenject;

namespace MidasMain
{
    partial class BaseForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer100ms = new System.Windows.Forms.Timer(this.components);
            this.Tab1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LoadButton = new MetroFramework.Controls.MetroButton();
            this.RectRadio = new MetroFramework.Controls.MetroRadioButton();
            this.PenRadio = new MetroFramework.Controls.MetroRadioButton();
            this.FillRadio = new MetroFramework.Controls.MetroRadioButton();
            this.NoneRadio = new MetroFramework.Controls.MetroRadioButton();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.UMLTitle = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.objectView1 = new MidasMain.UML.ObjectView();
            this.Tab1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer100ms
            // 
            this.timer100ms.Enabled = true;
            this.timer100ms.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.metroTabPage2);
            this.Tab1.Controls.Add(this.metroTabPage1);
            this.Tab1.Controls.Add(this.metroTabPage3);
            this.Tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab1.Location = new System.Drawing.Point(10, 60);
            this.Tab1.Name = "Tab1";
            this.Tab1.SelectedIndex = 1;
            this.Tab1.Size = new System.Drawing.Size(653, 443);
            this.Tab1.TabIndex = 0;
            this.Tab1.UseCustomBackColor = true;
            this.Tab1.UseCustomForeColor = true;
            this.Tab1.UseSelectable = true;
            this.Tab1.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel1);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(645, 401);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Paint";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LoadButton);
            this.metroPanel1.Controls.Add(this.RectRadio);
            this.metroPanel1.Controls.Add(this.PenRadio);
            this.metroPanel1.Controls.Add(this.FillRadio);
            this.metroPanel1.Controls.Add(this.NoneRadio);
            this.metroPanel1.Controls.Add(this.SaveButton);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(116, 123);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(52, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseSelectable = true;
            // 
            // RectRadio
            // 
            this.RectRadio.AutoSize = true;
            this.RectRadio.Location = new System.Drawing.Point(12, 74);
            this.RectRadio.Name = "RectRadio";
            this.RectRadio.Size = new System.Drawing.Size(46, 15);
            this.RectRadio.TabIndex = 7;
            this.RectRadio.Text = "Rect";
            this.RectRadio.UseSelectable = true;
            this.RectRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // PenRadio
            // 
            this.PenRadio.AutoSize = true;
            this.PenRadio.Location = new System.Drawing.Point(12, 53);
            this.PenRadio.Name = "PenRadio";
            this.PenRadio.Size = new System.Drawing.Size(43, 15);
            this.PenRadio.TabIndex = 5;
            this.PenRadio.Text = "Pen";
            this.PenRadio.UseSelectable = true;
            this.PenRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // FillRadio
            // 
            this.FillRadio.AutoSize = true;
            this.FillRadio.Location = new System.Drawing.Point(12, 95);
            this.FillRadio.Name = "FillRadio";
            this.FillRadio.Size = new System.Drawing.Size(38, 15);
            this.FillRadio.TabIndex = 6;
            this.FillRadio.Text = "Fill";
            this.FillRadio.UseSelectable = true;
            this.FillRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // NoneRadio
            // 
            this.NoneRadio.AutoSize = true;
            this.NoneRadio.Checked = true;
            this.NoneRadio.Location = new System.Drawing.Point(12, 32);
            this.NoneRadio.Name = "NoneRadio";
            this.NoneRadio.Size = new System.Drawing.Size(52, 15);
            this.NoneRadio.TabIndex = 8;
            this.NoneRadio.TabStop = true;
            this.NoneRadio.Text = "None";
            this.NoneRadio.UseSelectable = true;
            this.NoneRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(61, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(51, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 401);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.objectView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(645, 401);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "UML";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel2.Controls.Add(this.metroTile2);
            this.metroPanel2.Controls.Add(this.metroTile1);
            this.metroPanel2.Controls.Add(this.UMLTitle);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(194, 401);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(99, 52);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(74, 65);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Clear";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(19, 52);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(74, 65);
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Add";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // UMLTitle
            // 
            this.UMLTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UMLTitle.Location = new System.Drawing.Point(19, 17);
            this.UMLTitle.Name = "UMLTitle";
            this.UMLTitle.Size = new System.Drawing.Size(74, 32);
            this.UMLTitle.TabIndex = 2;
            this.UMLTitle.Text = "Menu";
            this.UMLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage3.Controls.Add(this.htmlPanel1);
            this.metroTabPage3.HorizontalScrollbarBarColor = false;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Padding = new System.Windows.Forms.Padding(20);
            this.metroTabPage3.Size = new System.Drawing.Size(645, 401);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Credit";
            this.metroTabPage3.VerticalScrollbarBarColor = false;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(605, 18);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.htmlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.htmlPanel1.Location = new System.Drawing.Point(20, 20);
            this.htmlPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.htmlPanel1.Size = new System.Drawing.Size(605, 361);
            this.htmlPanel1.TabIndex = 2;
            this.htmlPanel1.Text = "nothing";
            // 
            // objectView1
            // 
            this.objectView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.objectView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectView1.CausesValidation = false;
            this.objectView1.Location = new System.Drawing.Point(332, 103);
            this.objectView1.Name = "objectView1";
            this.objectView1.Size = new System.Drawing.Size(95, 77);
            this.objectView1.TabIndex = 3;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(673, 513);
            this.Controls.Add(this.Tab1);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Practice";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Tab1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer100ms;

        private MetroFramework.Controls.MetroTabControl Tab1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;

        //Creadit
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton LoadButton;
        private MetroFramework.Controls.MetroRadioButton RectRadio;
        private MetroFramework.Controls.MetroRadioButton FillRadio;
        private MetroFramework.Controls.MetroRadioButton PenRadio;
        private MetroFramework.Controls.MetroRadioButton NoneRadio;

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel UMLTitle;
        private UML.ObjectView objectView1;
    }
}

