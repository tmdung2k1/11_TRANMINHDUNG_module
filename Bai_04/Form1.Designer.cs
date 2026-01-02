namespace Bai_04
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
            this.lbl_nhapten = new System.Windows.Forms.Label();
            this.txt_nhapten = new System.Windows.Forms.TextBox();
            this.GB_color = new System.Windows.Forms.GroupBox();
            this.GB_Font = new System.Windows.Forms.GroupBox();
            this.lbl_ltboi = new System.Windows.Forms.Label();
            this.txt_laptrinh = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lbl_latrinh = new System.Windows.Forms.Label();
            this.Rad_red = new System.Windows.Forms.RadioButton();
            this.rad_green = new System.Windows.Forms.RadioButton();
            this.rad_blue = new System.Windows.Forms.RadioButton();
            this.rad_black = new System.Windows.Forms.RadioButton();
            this.chk_Bold = new System.Windows.Forms.CheckBox();
            this.chk_italic = new System.Windows.Forms.CheckBox();
            this.chk_under = new System.Windows.Forms.CheckBox();
            this.GB_color.SuspendLayout();
            this.GB_Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nhapten
            // 
            this.lbl_nhapten.AutoSize = true;
            this.lbl_nhapten.Location = new System.Drawing.Point(40, 49);
            this.lbl_nhapten.Name = "lbl_nhapten";
            this.lbl_nhapten.Size = new System.Drawing.Size(61, 16);
            this.lbl_nhapten.TabIndex = 0;
            this.lbl_nhapten.Text = "Nhập tên";
            this.lbl_nhapten.Click += new System.EventHandler(this.lbl_nhapten_Click);
            // 
            // txt_nhapten
            // 
            this.txt_nhapten.Location = new System.Drawing.Point(139, 43);
            this.txt_nhapten.Name = "txt_nhapten";
            this.txt_nhapten.Size = new System.Drawing.Size(416, 22);
            this.txt_nhapten.TabIndex = 1;
            this.txt_nhapten.TextChanged += new System.EventHandler(this.txt_nhapten_TextChanged);
            // 
            // GB_color
            // 
            this.GB_color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_color.Controls.Add(this.rad_black);
            this.GB_color.Controls.Add(this.rad_blue);
            this.GB_color.Controls.Add(this.rad_green);
            this.GB_color.Controls.Add(this.Rad_red);
            this.GB_color.Location = new System.Drawing.Point(43, 90);
            this.GB_color.Name = "GB_color";
            this.GB_color.Size = new System.Drawing.Size(226, 272);
            this.GB_color.TabIndex = 2;
            this.GB_color.TabStop = false;
            this.GB_color.Text = "Color";
            // 
            // GB_Font
            // 
            this.GB_Font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GB_Font.Controls.Add(this.chk_under);
            this.GB_Font.Controls.Add(this.chk_italic);
            this.GB_Font.Controls.Add(this.chk_Bold);
            this.GB_Font.Location = new System.Drawing.Point(329, 90);
            this.GB_Font.Name = "GB_Font";
            this.GB_Font.Size = new System.Drawing.Size(226, 272);
            this.GB_Font.TabIndex = 3;
            this.GB_Font.TabStop = false;
            this.GB_Font.Text = "Font";
            // 
            // lbl_ltboi
            // 
            this.lbl_ltboi.AutoSize = true;
            this.lbl_ltboi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ltboi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ltboi.Location = new System.Drawing.Point(39, 397);
            this.lbl_ltboi.Name = "lbl_ltboi";
            this.lbl_ltboi.Size = new System.Drawing.Size(123, 20);
            this.lbl_ltboi.TabIndex = 4;
            this.lbl_ltboi.Text = "Lập Trình Bởi";
            // 
            // txt_laptrinh
            // 
            this.txt_laptrinh.AutoSize = true;
            this.txt_laptrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_laptrinh.ForeColor = System.Drawing.Color.Lime;
            this.txt_laptrinh.Location = new System.Drawing.Point(185, 397);
            this.txt_laptrinh.Name = "txt_laptrinh";
            this.txt_laptrinh.Size = new System.Drawing.Size(0, 20);
            this.txt_laptrinh.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(456, 386);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(99, 45);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lbl_latrinh
            // 
            this.lbl_latrinh.BackColor = System.Drawing.Color.LightGray;
            this.lbl_latrinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_latrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_latrinh.ForeColor = System.Drawing.Color.Red;
            this.lbl_latrinh.Location = new System.Drawing.Point(189, 386);
            this.lbl_latrinh.Name = "lbl_latrinh";
            this.lbl_latrinh.Size = new System.Drawing.Size(229, 45);
            this.lbl_latrinh.TabIndex = 7;
            this.lbl_latrinh.Click += new System.EventHandler(this.lbl_latrinh_Click);
            // 
            // Rad_red
            // 
            this.Rad_red.AutoSize = true;
            this.Rad_red.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Rad_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_red.ForeColor = System.Drawing.Color.Red;
            this.Rad_red.Location = new System.Drawing.Point(39, 39);
            this.Rad_red.Name = "Rad_red";
            this.Rad_red.Size = new System.Drawing.Size(63, 24);
            this.Rad_red.TabIndex = 0;
            this.Rad_red.TabStop = true;
            this.Rad_red.Text = "Red";
            this.Rad_red.UseVisualStyleBackColor = true;
            this.Rad_red.CheckedChanged += new System.EventHandler(this.Rad_red_CheckedChanged);
            // 
            // rad_green
            // 
            this.rad_green.AutoSize = true;
            this.rad_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_green.ForeColor = System.Drawing.Color.Lime;
            this.rad_green.Location = new System.Drawing.Point(39, 92);
            this.rad_green.Name = "rad_green";
            this.rad_green.Size = new System.Drawing.Size(81, 24);
            this.rad_green.TabIndex = 1;
            this.rad_green.TabStop = true;
            this.rad_green.Text = "Green";
            this.rad_green.UseVisualStyleBackColor = true;
            this.rad_green.CheckedChanged += new System.EventHandler(this.rad_green_CheckedChanged);
            // 
            // rad_blue
            // 
            this.rad_blue.AutoSize = true;
            this.rad_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_blue.ForeColor = System.Drawing.Color.Blue;
            this.rad_blue.Location = new System.Drawing.Point(39, 150);
            this.rad_blue.Name = "rad_blue";
            this.rad_blue.Size = new System.Drawing.Size(68, 24);
            this.rad_blue.TabIndex = 2;
            this.rad_blue.TabStop = true;
            this.rad_blue.Text = "Blue";
            this.rad_blue.UseVisualStyleBackColor = true;
            this.rad_blue.CheckedChanged += new System.EventHandler(this.rad_blue_CheckedChanged);
            // 
            // rad_black
            // 
            this.rad_black.AutoSize = true;
            this.rad_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_black.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rad_black.Location = new System.Drawing.Point(39, 205);
            this.rad_black.Name = "rad_black";
            this.rad_black.Size = new System.Drawing.Size(77, 24);
            this.rad_black.TabIndex = 3;
            this.rad_black.TabStop = true;
            this.rad_black.Text = "Black";
            this.rad_black.UseVisualStyleBackColor = true;
            this.rad_black.CheckedChanged += new System.EventHandler(this.rad_black_CheckedChanged);
            // 
            // chk_Bold
            // 
            this.chk_Bold.AutoSize = true;
            this.chk_Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Bold.ForeColor = System.Drawing.Color.Blue;
            this.chk_Bold.Location = new System.Drawing.Point(66, 73);
            this.chk_Bold.Name = "chk_Bold";
            this.chk_Bold.Size = new System.Drawing.Size(69, 24);
            this.chk_Bold.TabIndex = 0;
            this.chk_Bold.Text = "Bold";
            this.chk_Bold.UseVisualStyleBackColor = true;
            this.chk_Bold.CheckedChanged += new System.EventHandler(this.chk_Bold_CheckedChanged);
            // 
            // chk_italic
            // 
            this.chk_italic.AutoSize = true;
            this.chk_italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_italic.ForeColor = System.Drawing.Color.Blue;
            this.chk_italic.Location = new System.Drawing.Point(66, 126);
            this.chk_italic.Name = "chk_italic";
            this.chk_italic.Size = new System.Drawing.Size(66, 24);
            this.chk_italic.TabIndex = 1;
            this.chk_italic.Text = "Italic";
            this.chk_italic.UseVisualStyleBackColor = true;
            this.chk_italic.CheckedChanged += new System.EventHandler(this.chk_italic_CheckedChanged);
            // 
            // chk_under
            // 
            this.chk_under.AutoSize = true;
            this.chk_under.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_under.ForeColor = System.Drawing.Color.Blue;
            this.chk_under.Location = new System.Drawing.Point(66, 181);
            this.chk_under.Name = "chk_under";
            this.chk_under.Size = new System.Drawing.Size(102, 24);
            this.chk_under.TabIndex = 2;
            this.chk_under.Text = "Underline";
            this.chk_under.UseVisualStyleBackColor = true;
            this.chk_under.CheckedChanged += new System.EventHandler(this.chk_under_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lbl_latrinh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txt_laptrinh);
            this.Controls.Add(this.lbl_ltboi);
            this.Controls.Add(this.GB_Font);
            this.Controls.Add(this.GB_color);
            this.Controls.Add(this.txt_nhapten);
            this.Controls.Add(this.lbl_nhapten);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_color.ResumeLayout(false);
            this.GB_color.PerformLayout();
            this.GB_Font.ResumeLayout(false);
            this.GB_Font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nhapten;
        private System.Windows.Forms.TextBox txt_nhapten;
        private System.Windows.Forms.GroupBox GB_color;
        private System.Windows.Forms.GroupBox GB_Font;
        private System.Windows.Forms.Label lbl_ltboi;
        private System.Windows.Forms.Label txt_laptrinh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label lbl_latrinh;
        private System.Windows.Forms.RadioButton rad_black;
        private System.Windows.Forms.RadioButton rad_blue;
        private System.Windows.Forms.RadioButton rad_green;
        private System.Windows.Forms.RadioButton Rad_red;
        private System.Windows.Forms.CheckBox chk_under;
        private System.Windows.Forms.CheckBox chk_italic;
        private System.Windows.Forms.CheckBox chk_Bold;
    }
}

