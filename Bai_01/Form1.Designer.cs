namespace Bai_01
{
    partial class Form1
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
            this.lbl_ = new System.Windows.Forms.Label();
            this.txt_nhappwd = new System.Windows.Forms.TextBox();
            this.lbl_hienthi = new System.Windows.Forms.Label();
            this.txt_hienthi = new System.Windows.Forms.TextBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.btn_tiep = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(81, 97);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(96, 16);
            this.lbl_.TabIndex = 0;
            this.lbl_.Text = "Nhập Pasword";
            // 
            // txt_nhappwd
            // 
            this.txt_nhappwd.Location = new System.Drawing.Point(197, 97);
            this.txt_nhappwd.Name = "txt_nhappwd";
            this.txt_nhappwd.PasswordChar = '#';
            this.txt_nhappwd.Size = new System.Drawing.Size(277, 22);
            this.txt_nhappwd.TabIndex = 1;
            // 
            // lbl_hienthi
            // 
            this.lbl_hienthi.AutoSize = true;
            this.lbl_hienthi.Location = new System.Drawing.Point(126, 187);
            this.lbl_hienthi.Name = "lbl_hienthi";
            this.lbl_hienthi.Size = new System.Drawing.Size(51, 16);
            this.lbl_hienthi.TabIndex = 2;
            this.lbl_hienthi.Text = "Hiển thị";
            // 
            // txt_hienthi
            // 
            this.txt_hienthi.Location = new System.Drawing.Point(197, 181);
            this.txt_hienthi.Name = "txt_hienthi";
            this.txt_hienthi.ReadOnly = true;
            this.txt_hienthi.Size = new System.Drawing.Size(277, 22);
            this.txt_hienthi.TabIndex = 3;
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.Location = new System.Drawing.Point(103, 283);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi.TabIndex = 4;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.UseVisualStyleBackColor = true;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // btn_tiep
            // 
            this.btn_tiep.Location = new System.Drawing.Point(271, 283);
            this.btn_tiep.Name = "btn_tiep";
            this.btn_tiep.Size = new System.Drawing.Size(75, 23);
            this.btn_tiep.TabIndex = 5;
            this.btn_tiep.Text = "Tiếp";
            this.btn_tiep.UseVisualStyleBackColor = true;
            this.btn_tiep.Click += new System.EventHandler(this.btn_tiep_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(437, 283);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 6;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 363);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_tiep);
            this.Controls.Add(this.btn_hienthi);
            this.Controls.Add(this.txt_hienthi);
            this.Controls.Add(this.lbl_hienthi);
            this.Controls.Add(this.txt_nhappwd);
            this.Controls.Add(this.lbl_);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.TextBox txt_nhappwd;
        private System.Windows.Forms.Label lbl_hienthi;
        private System.Windows.Forms.TextBox txt_hienthi;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button btn_tiep;
        private System.Windows.Forms.Button btn_dong;
    }
}

