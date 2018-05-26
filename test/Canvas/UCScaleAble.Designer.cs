namespace MidasMain.Canvas
{
	partial class UCScaleAble
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
			this.scalerLeftTop = new MidasMain.Canvas.UCScaler();
			this.scalerLeftBottom = new MidasMain.Canvas.UCScaler();
			this.scalerRightTop = new MidasMain.Canvas.UCScaler();
			this.scalerRightBottom = new MidasMain.Canvas.UCScaler();
			this.SuspendLayout();
			// 
			// scalerLeftTop
			// 
			this.scalerLeftTop.BackColor = System.Drawing.Color.Black;
			this.scalerLeftTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scalerLeftTop.CausesValidation = false;
			this.scalerLeftTop.Location = new System.Drawing.Point(-1, -1);
			this.scalerLeftTop.Name = "scalerLeftTop";
			this.scalerLeftTop.Size = new System.Drawing.Size(10, 10);
			this.scalerLeftTop.TabIndex = 0;
			// 
			// scalerLeftBottom
			// 
			this.scalerLeftBottom.BackColor = System.Drawing.Color.Black;
			this.scalerLeftBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scalerLeftBottom.CausesValidation = false;
			this.scalerLeftBottom.Location = new System.Drawing.Point(-1, 89);
			this.scalerLeftBottom.Name = "scalerLeftBottom";
			this.scalerLeftBottom.Size = new System.Drawing.Size(10, 10);
			this.scalerLeftBottom.TabIndex = 1;
			// 
			// scalerRightTop
			// 
			this.scalerRightTop.BackColor = System.Drawing.Color.Black;
			this.scalerRightTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scalerRightTop.CausesValidation = false;
			this.scalerRightTop.Location = new System.Drawing.Point(98, -1);
			this.scalerRightTop.Name = "scalerRightTop";
			this.scalerRightTop.Size = new System.Drawing.Size(10, 10);
			this.scalerRightTop.TabIndex = 2;
			// 
			// scalerRightBottom
			// 
			this.scalerRightBottom.BackColor = System.Drawing.Color.Black;
			this.scalerRightBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scalerRightBottom.CausesValidation = false;
			this.scalerRightBottom.Location = new System.Drawing.Point(98, 89);
			this.scalerRightBottom.Name = "scalerRightBottom";
			this.scalerRightBottom.Size = new System.Drawing.Size(10, 10);
			this.scalerRightBottom.TabIndex = 3;
			// 
			// UCRoom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.Controls.Add(this.scalerRightBottom);
			this.Controls.Add(this.scalerRightTop);
			this.Controls.Add(this.scalerLeftBottom);
			this.Controls.Add(this.scalerLeftTop);
			this.Name = "UCRoom";
			this.ResumeLayout(false);

		}

		#endregion

		private UCScaler scalerLeftTop;
		private UCScaler scalerLeftBottom;
		private UCScaler scalerRightTop;
		private UCScaler scalerRightBottom;
	}
}
