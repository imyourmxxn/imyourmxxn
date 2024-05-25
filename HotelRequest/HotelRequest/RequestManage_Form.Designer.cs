namespace HotelRequest
{
    partial class RequestManage_Form
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
            this.RequestManageAnswer_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RequestManageBack_gtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RequestManageAnswer_btn
            // 
            this.RequestManageAnswer_btn.Location = new System.Drawing.Point(1127, 476);
            this.RequestManageAnswer_btn.Name = "RequestManageAnswer_btn";
            this.RequestManageAnswer_btn.Size = new System.Drawing.Size(132, 43);
            this.RequestManageAnswer_btn.TabIndex = 1;
            this.RequestManageAnswer_btn.Text = "답변하기";
            this.RequestManageAnswer_btn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1042, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 22);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "답변 전";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1153, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 22);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "답변완료";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // RequestManageBack_gtn
            // 
            this.RequestManageBack_gtn.Location = new System.Drawing.Point(978, 476);
            this.RequestManageBack_gtn.Name = "RequestManageBack_gtn";
            this.RequestManageBack_gtn.Size = new System.Drawing.Size(132, 43);
            this.RequestManageBack_gtn.TabIndex = 4;
            this.RequestManageBack_gtn.Text = "뒤로가기";
            this.RequestManageBack_gtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1236, 412);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "작성자 ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이름";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "객실번호";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "작성시간";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "요청 종류";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "요청내용";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "답변내용";
            // 
            // RequestManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 531);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RequestManageBack_gtn);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RequestManageAnswer_btn);
            this.Name = "RequestManage_Form";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RequestManageAnswer_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button RequestManageBack_gtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}