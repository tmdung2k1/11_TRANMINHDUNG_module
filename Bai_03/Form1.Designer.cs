namespace Bai_03
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
            this.lbl_holot = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            this.txt_holot = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.btn_holot = new System.Windows.Forms.Button();
            this.btn_ten = new System.Windows.Forms.Button();
            this.btn_hoten = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_holot
            // 
            this.lbl_holot.AutoSize = true;
            this.lbl_holot.Location = new System.Drawing.Point(87, 138);
            this.lbl_holot.Name = "lbl_holot";
            this.lbl_holot.Size = new System.Drawing.Size(42, 16);
            this.lbl_holot.TabIndex = 1;
            this.lbl_holot.Text = "Họ lót";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Location = new System.Drawing.Point(87, 200);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(31, 16);
            this.lbl_ten.TabIndex = 2;
            this.lbl_ten.Text = "Tên";
            // 
            // txt_holot
            // 
            this.txt_holot.Location = new System.Drawing.Point(197, 132);
            this.txt_holot.Name = "txt_holot";
            this.txt_holot.Size = new System.Drawing.Size(401, 22);
            this.txt_holot.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ten.ForeColor = System.Drawing.Color.Black;
            this.txt_ten.Location = new System.Drawing.Point(197, 200);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(401, 22);
            this.txt_ten.TabIndex = 4;
            // 
            // btn_holot
            // 
            this.btn_holot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_holot.Location = new System.Drawing.Point(90, 315);
            this.btn_holot.Name = "btn_holot";
            this.btn_holot.Size = new System.Drawing.Size(111, 40);
            this.btn_holot.TabIndex = 5;
            this.btn_holot.Text = "Họ lót";
            this.btn_holot.UseVisualStyleBackColor = false;
            this.btn_holot.Click += new System.EventHandler(this.btn_holot_Click);
            // 
            // btn_ten
            // 
            this.btn_ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ten.Location = new System.Drawing.Point(301, 315);
            this.btn_ten.Name = "btn_ten";
            this.btn_ten.Size = new System.Drawing.Size(111, 40);
            this.btn_ten.TabIndex = 6;
            this.btn_ten.Text = "Tên";
            this.btn_ten.UseVisualStyleBackColor = false;
            this.btn_ten.Click += new System.EventHandler(this.btn_ten_Click);
            // 
            // btn_hoten
            // 
            this.btn_hoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_hoten.Location = new System.Drawing.Point(487, 315);
            this.btn_hoten.Name = "btn_hoten";
            this.btn_hoten.Size = new System.Drawing.Size(111, 40);
            this.btn_hoten.TabIndex = 7;
            this.btn_hoten.Text = "Họ và tên";
            this.btn_hoten.UseVisualStyleBackColor = false;
            this.btn_hoten.Click += new System.EventHandler(this.btn_hoten_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_thoat.Location = new System.Drawing.Point(270, 385);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(168, 40);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_hoten.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(0, 0);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(655, 79);
            this.lbl_hoten.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.lbl_hoten);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_hoten);
            this.Controls.Add(this.btn_ten);
            this.Controls.Add(this.btn_holot);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_holot);
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_holot);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_holot;
        private System.Windows.Forms.Label lbl_ten;
        private System.Windows.Forms.TextBox txt_holot;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button btn_holot;
        private System.Windows.Forms.Button btn_ten;
        private System.Windows.Forms.Button btn_hoten;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_hoten;
    }
}

