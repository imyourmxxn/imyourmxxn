﻿namespace HotelRequest
{
    partial class RequestAnswer_Form
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
            this.RequestAnswer_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestAnswerEnroll_btn = new System.Windows.Forms.Button();
            this.RequestContentReadOnly_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RequestAnswerBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestAnswer_txt
            // 
            this.RequestAnswer_txt.Location = new System.Drawing.Point(33, 320);
            this.RequestAnswer_txt.Multiline = true;
            this.RequestAnswer_txt.Name = "RequestAnswer_txt";
            this.RequestAnswer_txt.Size = new System.Drawing.Size(543, 159);
            this.RequestAnswer_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "요청사항에 대한 답변을 작성하세요. (필수)";
            // 
            // RequestAnswerEnroll_btn
            // 
            this.RequestAnswerEnroll_btn.Location = new System.Drawing.Point(481, 499);
            this.RequestAnswerEnroll_btn.Name = "RequestAnswerEnroll_btn";
            this.RequestAnswerEnroll_btn.Size = new System.Drawing.Size(95, 43);
            this.RequestAnswerEnroll_btn.TabIndex = 2;
            this.RequestAnswerEnroll_btn.Text = "답변등록";
            this.RequestAnswerEnroll_btn.UseVisualStyleBackColor = true;
            // 
            // RequestContentReadOnly_txt
            // 
            this.RequestContentReadOnly_txt.Location = new System.Drawing.Point(33, 66);
            this.RequestContentReadOnly_txt.Multiline = true;
            this.RequestContentReadOnly_txt.Name = "RequestContentReadOnly_txt";
            this.RequestContentReadOnly_txt.Size = new System.Drawing.Size(543, 182);
            this.RequestContentReadOnly_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "요청사항 내용";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RequestAnswerBack_btn
            // 
            this.RequestAnswerBack_btn.Location = new System.Drawing.Point(380, 499);
            this.RequestAnswerBack_btn.Name = "RequestAnswerBack_btn";
            this.RequestAnswerBack_btn.Size = new System.Drawing.Size(95, 43);
            this.RequestAnswerBack_btn.TabIndex = 5;
            this.RequestAnswerBack_btn.Text = "뒤로가기";
            this.RequestAnswerBack_btn.UseVisualStyleBackColor = true;
            // 
            // RequestAnswer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 604);
            this.Controls.Add(this.RequestAnswerBack_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RequestContentReadOnly_txt);
            this.Controls.Add(this.RequestAnswerEnroll_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestAnswer_txt);
            this.Name = "RequestAnswer_Form";
            this.Text = "RequestAnswer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RequestAnswer_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RequestAnswerEnroll_btn;
        private System.Windows.Forms.TextBox RequestContentReadOnly_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RequestAnswerBack_btn;
    }
}