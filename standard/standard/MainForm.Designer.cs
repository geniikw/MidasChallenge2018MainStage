namespace standard
{
	partial class MainForm
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
			this.mainTabs = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.firstPageMainLayout = new System.Windows.Forms.TableLayoutPanel();
			this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
			this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
			this.firsPageMenuLayout = new System.Windows.Forms.TableLayoutPanel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.mainTabs.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			this.firstPageMainLayout.SuspendLayout();
			this.firsPageMenuLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainTabs
			// 
			this.mainTabs.Controls.Add(this.metroTabPage1);
			this.mainTabs.Controls.Add(this.metroTabPage2);
			this.mainTabs.Controls.Add(this.metroTabPage3);
			this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabs.Location = new System.Drawing.Point(10, 30);
			this.mainTabs.Margin = new System.Windows.Forms.Padding(0);
			this.mainTabs.Name = "mainTabs";
			this.mainTabs.SelectedIndex = 0;
			this.mainTabs.Size = new System.Drawing.Size(709, 448);
			this.mainTabs.TabIndex = 0;
			this.mainTabs.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.metroTabPage1.Controls.Add(this.firstPageMainLayout);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(701, 406);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "first page";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// firstPageMainLayout
			// 
			this.firstPageMainLayout.ColumnCount = 2;
			this.firstPageMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.firstPageMainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
			this.firstPageMainLayout.Controls.Add(this.firsPageMenuLayout, 0, 0);
			this.firstPageMainLayout.Controls.Add(this.metroLabel1, 0, 1);
			this.firstPageMainLayout.Controls.Add(this.metroLabel2, 0, 2);
			this.firstPageMainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firstPageMainLayout.Location = new System.Drawing.Point(0, 0);
			this.firstPageMainLayout.Name = "firstPageMainLayout";
			this.firstPageMainLayout.RowCount = 3;
			this.firstPageMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.firstPageMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.firstPageMainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.firstPageMainLayout.Size = new System.Drawing.Size(701, 406);
			this.firstPageMainLayout.TabIndex = 2;
			// 
			// metroTabPage2
			// 
			this.metroTabPage2.HorizontalScrollbarBarColor = true;
			this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.HorizontalScrollbarSize = 10;
			this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage2.Name = "metroTabPage2";
			this.metroTabPage2.Size = new System.Drawing.Size(701, 406);
			this.metroTabPage2.TabIndex = 1;
			this.metroTabPage2.Text = "second page";
			this.metroTabPage2.VerticalScrollbarBarColor = true;
			this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage2.VerticalScrollbarSize = 10;
			// 
			// metroTabPage3
			// 
			this.metroTabPage3.HorizontalScrollbarBarColor = true;
			this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.HorizontalScrollbarSize = 10;
			this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage3.Name = "metroTabPage3";
			this.metroTabPage3.Size = new System.Drawing.Size(701, 406);
			this.metroTabPage3.TabIndex = 2;
			this.metroTabPage3.Text = "third page";
			this.metroTabPage3.VerticalScrollbarBarColor = true;
			this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage3.VerticalScrollbarSize = 10;
			// 
			// firsPageMenuLayout
			// 
			this.firsPageMenuLayout.ColumnCount = 1;
			this.firsPageMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.firsPageMenuLayout.Controls.Add(this.metroButton1, 0, 0);
			this.firsPageMenuLayout.Controls.Add(this.metroButton2, 0, 1);
			this.firsPageMenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.firsPageMenuLayout.Location = new System.Drawing.Point(0, 0);
			this.firsPageMenuLayout.Margin = new System.Windows.Forms.Padding(0);
			this.firsPageMenuLayout.Name = "firsPageMenuLayout";
			this.firsPageMenuLayout.RowCount = 2;
			this.firsPageMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.firsPageMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.firsPageMenuLayout.Size = new System.Drawing.Size(105, 81);
			this.firsPageMenuLayout.TabIndex = 0;
			// 
			// metroButton1
			// 
			this.metroButton1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroButton1.Location = new System.Drawing.Point(3, 3);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(99, 34);
			this.metroButton1.TabIndex = 0;
			this.metroButton1.Text = "metroButton1";
			this.metroButton1.UseSelectable = true;
			// 
			// metroButton2
			// 
			this.metroButton2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroButton2.Location = new System.Drawing.Point(3, 43);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(99, 35);
			this.metroButton2.TabIndex = 1;
			this.metroButton2.Text = "metroButton2";
			this.metroButton2.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroLabel1.Location = new System.Drawing.Point(3, 81);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(99, 162);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "메뉴셋1";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.metroLabel2.Location = new System.Drawing.Point(3, 243);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(99, 163);
			this.metroLabel2.TabIndex = 2;
			this.metroLabel2.Text = "메뉴셋2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			this.ClientSize = new System.Drawing.Size(729, 488);
			this.Controls.Add(this.mainTabs);
			this.DisplayHeader = false;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			this.Text = "Form1";
			this.mainTabs.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			this.firstPageMainLayout.ResumeLayout(false);
			this.firstPageMainLayout.PerformLayout();
			this.firsPageMenuLayout.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTabControl mainTabs;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private MetroFramework.Controls.MetroTabPage metroTabPage2;
		private MetroFramework.Controls.MetroTabPage metroTabPage3;
		private System.Windows.Forms.TableLayoutPanel firstPageMainLayout;
		private System.Windows.Forms.TableLayoutPanel firsPageMenuLayout;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}

