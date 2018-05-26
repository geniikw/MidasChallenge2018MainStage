﻿namespace MidasMain.Canvas
{
    partial class Canvas
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
            this.ucRoom1 = new MidasMain.Canvas.UCRoom();
            this.SuspendLayout();
            // 
            // ucRoom1
            // 
            this.ucRoom1.BackColor = System.Drawing.Color.Red;
            this.ucRoom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucRoom1.CausesValidation = false;
            this.ucRoom1.Location = new System.Drawing.Point(365, 255);
            this.ucRoom1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.roomData = null;
            this.ucRoom1.Size = new System.Drawing.Size(124, 124);
            this.ucRoom1.TabIndex = 0;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucRoom1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Canvas";
            this.Size = new System.Drawing.Size(745, 652);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownReceiver);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseDragReceiver);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpReceiver);
            this.ResumeLayout(false);
        }

        #endregion

        private UCRoom ucRoom1;
    }
}
