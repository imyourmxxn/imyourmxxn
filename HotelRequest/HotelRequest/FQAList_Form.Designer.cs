﻿namespace HotelRequest
{
    partial class FQAList_Form
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
            this.FAQ_listview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FAQQuestion_lbl = new System.Windows.Forms.Label();
            this.FAQQuestionContent_txt = new System.Windows.Forms.TextBox();
            this.FAQAnswer_lbl = new System.Windows.Forms.Label();
            this.FAQAnswerContent_txt = new System.Windows.Forms.TextBox();
            this.FAQEnroll_btn = new System.Windows.Forms.Button();
            this.FAQFix_btn = new System.Windows.Forms.Button();
            this.FAQDel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FAQ_listview
            // 
            this.FAQ_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.FAQ_listview.HideSelection = false;
            this.FAQ_listview.Location = new System.Drawing.Point(385, 52);
            this.FAQ_listview.Name = "FAQ_listview";
            this.FAQ_listview.Size = new System.Drawing.Size(500, 489);
            this.FAQ_listview.TabIndex = 0;
            this.FAQ_listview.UseCompatibleStateImageBehavior = false;
            this.FAQ_listview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "자주하는질문";
            this.columnHeader2.Width = 255;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "답변";
            this.columnHeader3.Width = 209;
            // 
            // FAQQuestion_lbl
            // 
            this.FAQQuestion_lbl.AutoSize = true;
            this.FAQQuestion_lbl.Location = new System.Drawing.Point(28, 52);
            this.FAQQuestion_lbl.Name = "FAQQuestion_lbl";
            this.FAQQuestion_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FAQQuestion_lbl.Size = new System.Drawing.Size(86, 18);
            this.FAQQuestion_lbl.TabIndex = 1;
            this.FAQQuestion_lbl.Text = "질문 내용";
            this.FAQQuestion_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FAQQuestionContent_txt
            // 
            this.FAQQuestionContent_txt.Location = new System.Drawing.Point(28, 82);
            this.FAQQuestionContent_txt.Multiline = true;
            this.FAQQuestionContent_txt.Name = "FAQQuestionContent_txt";
            this.FAQQuestionContent_txt.Size = new System.Drawing.Size(277, 90);
            this.FAQQuestionContent_txt.TabIndex = 2;
            // 
            // FAQAnswer_lbl
            // 
            this.FAQAnswer_lbl.AutoSize = true;
            this.FAQAnswer_lbl.Location = new System.Drawing.Point(28, 202);
            this.FAQAnswer_lbl.Name = "FAQAnswer_lbl";
            this.FAQAnswer_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FAQAnswer_lbl.Size = new System.Drawing.Size(86, 18);
            this.FAQAnswer_lbl.TabIndex = 3;
            this.FAQAnswer_lbl.Text = "답변 내용";
            this.FAQAnswer_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // FAQAnswerContent_txt
            // 
            this.FAQAnswerContent_txt.Location = new System.Drawing.Point(28, 232);
            this.FAQAnswerContent_txt.Multiline = true;
            this.FAQAnswerContent_txt.Name = "FAQAnswerContent_txt";
            this.FAQAnswerContent_txt.Size = new System.Drawing.Size(277, 208);
            this.FAQAnswerContent_txt.TabIndex = 4;
            // 
            // FAQEnroll_btn
            // 
            this.FAQEnroll_btn.Location = new System.Drawing.Point(36, 473);
            this.FAQEnroll_btn.Name = "FAQEnroll_btn";
            this.FAQEnroll_btn.Size = new System.Drawing.Size(75, 49);
            this.FAQEnroll_btn.TabIndex = 5;
            this.FAQEnroll_btn.Text = "등록";
            this.FAQEnroll_btn.UseVisualStyleBackColor = true;
            // 
            // FAQFix_btn
            // 
            this.FAQFix_btn.Location = new System.Drawing.Point(130, 473);
            this.FAQFix_btn.Name = "FAQFix_btn";
            this.FAQFix_btn.Size = new System.Drawing.Size(75, 49);
            this.FAQFix_btn.TabIndex = 6;
            this.FAQFix_btn.Text = "수정";
            this.FAQFix_btn.UseVisualStyleBackColor = true;
            // 
            // FAQDel_btn
            // 
            this.FAQDel_btn.Location = new System.Drawing.Point(230, 473);
            this.FAQDel_btn.Name = "FAQDel_btn";
            this.FAQDel_btn.Size = new System.Drawing.Size(75, 49);
            this.FAQDel_btn.TabIndex = 7;
            this.FAQDel_btn.Text = "삭제";
            this.FAQDel_btn.UseVisualStyleBackColor = true;
            // 
            // FQAEnroll_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 587);
            this.Controls.Add(this.FAQDel_btn);
            this.Controls.Add(this.FAQFix_btn);
            this.Controls.Add(this.FAQEnroll_btn);
            this.Controls.Add(this.FAQAnswerContent_txt);
            this.Controls.Add(this.FAQAnswer_lbl);
            this.Controls.Add(this.FAQQuestionContent_txt);
            this.Controls.Add(this.FAQQuestion_lbl);
            this.Controls.Add(this.FAQ_listview);
            this.Name = "FQAEnroll_Form";
            this.Text = "FQAEnroll_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView FAQ_listview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label FAQQuestion_lbl;
        private System.Windows.Forms.TextBox FAQQuestionContent_txt;
        private System.Windows.Forms.Label FAQAnswer_lbl;
        private System.Windows.Forms.TextBox FAQAnswerContent_txt;
        private System.Windows.Forms.Button FAQEnroll_btn;
        private System.Windows.Forms.Button FAQFix_btn;
        private System.Windows.Forms.Button FAQDel_btn;
    }
}