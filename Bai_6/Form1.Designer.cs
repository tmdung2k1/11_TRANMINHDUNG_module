namespace Bai_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_hienthi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.pic_off = new System.Windows.Forms.PictureBox();
            this.pic_on = new System.Windows.Forms.PictureBox();
            this.lbl_line = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_on)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(101, 64);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(347, 26);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_hienthi
            // 
            this.lbl_hienthi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hienthi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hienthi.Location = new System.Drawing.Point(12, 320);
            this.lbl_hienthi.Name = "lbl_hienthi";
            this.lbl_hienthi.Size = new System.Drawing.Size(465, 42);
            this.lbl_hienthi.TabIndex = 3;
            this.lbl_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Designed by: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_thoat.Location = new System.Drawing.Point(389, 371);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(88, 47);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.Text = "Exit";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // pic_off
            // 
            this.pic_off.Image = global::Bai_6.Properties.Resources.light_6496009;
            this.pic_off.Location = new System.Drawing.Point(156, 122);
            this.pic_off.Name = "pic_off";
            this.pic_off.Size = new System.Drawing.Size(161, 152);
            this.pic_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_off.TabIndex = 6;
            this.pic_off.TabStop = false;
            this.pic_off.Click += new System.EventHandler(this.pic_off_Click);
            // 
            // pic_on
            // 
            this.pic_on.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_on.Image = global::Bai_6.Properties.Resources.light_bulb_12332322;
            this.pic_on.Location = new System.Drawing.Point(156, 122);
            this.pic_on.Name = "pic_on";
            this.pic_on.Size = new System.Drawing.Size(161, 152);
            this.pic_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_on.TabIndex = 2;
            this.pic_on.TabStop = false;
            this.pic_on.Visible = false;
            this.pic_on.Click += new System.EventHandler(this.pic_on_Click);
            // 
            // lbl_line
            // 
            this.lbl_line.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.Location = new System.Drawing.Point(152, 389);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(241, 29);
            this.lbl_line.TabIndex = 7;
            this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_line.Click += new System.EventHandler(this.lbl_line_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 444);
            this.Controls.Add(this.lbl_line);
            this.Controls.Add(this.pic_off);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_hienthi);
            this.Controls.Add(this.pic_on);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_on)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.PictureBox pic_on;
        private System.Windows.Forms.Label lbl_hienthi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.PictureBox pic_off;
        private System.Windows.Forms.Label lbl_line;
    }
}

