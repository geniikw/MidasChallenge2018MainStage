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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.Tab1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.NoneRadio = new MetroFramework.Controls.MetroRadioButton();
            this.PenRadio = new MetroFramework.Controls.MetroRadioButton();
            this.FillRadio = new MetroFramework.Controls.MetroRadioButton();
            this.RectRadio = new MetroFramework.Controls.MetroRadioButton();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.LoadButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.Tab1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer100ms
            // 
            this.timer100ms.Enabled = true;
            this.timer100ms.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(407, 297);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(16, 16);
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.metroTabPage2);
            this.Tab1.Controls.Add(this.metroTabPage1);
            this.Tab1.Controls.Add(this.metroTabPage3);
            this.Tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab1.Location = new System.Drawing.Point(10, 30);
            this.Tab1.Name = "Tab1";
            this.Tab1.SelectedIndex = 0;
            this.Tab1.Size = new System.Drawing.Size(580, 399);
            this.Tab1.TabIndex = 0;
            this.Tab1.UseCustomBackColor = true;
            this.Tab1.UseCustomForeColor = true;
            this.Tab1.UseSelectable = true;
            this.Tab1.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.NoneRadio);
            this.metroTabPage2.Controls.Add(this.PenRadio);
            this.metroTabPage2.Controls.Add(this.FillRadio);
            this.metroTabPage2.Controls.Add(this.RectRadio);
            this.metroTabPage2.Controls.Add(this.SaveButton);
            this.metroTabPage2.Controls.Add(this.LoadButton);
            this.metroTabPage2.Controls.Add(this.pictureBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(572, 357);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Paint";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // NoneRadio
            // 
            this.NoneRadio.AutoSize = true;
            this.NoneRadio.Checked = true;
            this.NoneRadio.Location = new System.Drawing.Point(22, 256);
            this.NoneRadio.Name = "NoneRadio";
            this.NoneRadio.Size = new System.Drawing.Size(52, 15);
            this.NoneRadio.TabIndex = 8;
            this.NoneRadio.TabStop = true;
            this.NoneRadio.Text = "None";
            this.NoneRadio.UseSelectable = true;
            this.NoneRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // PenRadio
            // 
            this.PenRadio.AutoSize = true;
            this.PenRadio.Location = new System.Drawing.Point(22, 277);
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
            this.FillRadio.Location = new System.Drawing.Point(22, 298);
            this.FillRadio.Name = "FillRadio";
            this.FillRadio.Size = new System.Drawing.Size(38, 15);
            this.FillRadio.TabIndex = 6;
            this.FillRadio.Text = "Fill";
            this.FillRadio.UseSelectable = true;
            this.FillRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // RectRadio
            // 
            this.RectRadio.AutoSize = true;
            this.RectRadio.Location = new System.Drawing.Point(22, 319);
            this.RectRadio.Name = "RectRadio";
            this.RectRadio.Size = new System.Drawing.Size(46, 15);
            this.RectRadio.TabIndex = 7;
            this.RectRadio.Text = "Rect";
            this.RectRadio.UseSelectable = true;
            this.RectRadio.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 32);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(113, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(119, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 357);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.metroTabPage1.Size = new System.Drawing.Size(572, 357);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "UML";
            this.metroTabPage1.UseCustomBackColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.metroTabPage3.Size = new System.Drawing.Size(572, 357);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Credit";
            this.metroTabPage3.VerticalScrollbarBarColor = false;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(532, 18);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.htmlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.htmlPanel1.Location = new System.Drawing.Point(20, 20);
            this.htmlPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.htmlPanel1.Size = new System.Drawing.Size(532, 317);
            this.htmlPanel1.TabIndex = 2;
            this.htmlPanel1.Text = "nothing";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(600, 439);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.metroProgressSpinner1);
            this.DisplayHeader = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BaseForm";
            this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Practice";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Tab1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer100ms;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroTabControl Tab1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;

        //Creadit
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;

        //paint
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroButton LoadButton;
        private MetroFramework.Controls.MetroRadioButton RectRadio;
        private MetroFramework.Controls.MetroRadioButton FillRadio;
        private MetroFramework.Controls.MetroRadioButton PenRadio;
        private MetroFramework.Controls.MetroRadioButton NoneRadio;
    }
}

