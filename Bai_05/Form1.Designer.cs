namespace Bai_05
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
            this.components = new System.ComponentModel.Container();
            this.gb_inputname = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.gb_Color = new System.Windows.Forms.GroupBox();
            this.gb_action = new System.Windows.Forms.GroupBox();
            this.chk_visible = new System.Windows.Forms.CheckBox();
            this.pic_small = new System.Windows.Forms.PictureBox();
            this.pic_big = new System.Windows.Forms.PictureBox();
            this.lbl_Mess = new System.Windows.Forms.Label();
            this.rad_black = new System.Windows.Forms.RadioButton();
            this.rad_blue = new System.Windows.Forms.RadioButton();
            this.rad_green = new System.Windows.Forms.RadioButton();
            this.Rad_red = new System.Windows.Forms.RadioButton();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.gb_inputname.SuspendLayout();
            this.gb_Color.SuspendLayout();
            this.gb_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_inputname
            // 
            this.gb_inputname.BackColor = System.Drawing.Color.White;
            this.gb_inputname.Controls.Add(this.txt_Message);
            this.gb_inputname.Controls.Add(this.lbl_message);
            this.gb_inputname.Controls.Add(this.txt_name);
            this.gb_inputname.Controls.Add(this.lbl_name);
            this.gb_inputname.Location = new System.Drawing.Point(12, 12);
            this.gb_inputname.Name = "gb_inputname";
            this.gb_inputname.Size = new System.Drawing.Size(621, 132);
            this.gb_inputname.TabIndex = 0;
            this.gb_inputname.TabStop = false;
            this.gb_inputname.Text = "Input name & Message";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(48, 47);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name\r\n";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_name.Location = new System.Drawing.Point(133, 41);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(447, 22);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(48, 91);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(64, 16);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Message";
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_Message.Location = new System.Drawing.Point(133, 85);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(447, 22);
            this.txt_Message.TabIndex = 3;
            // 
            // gb_Color
            // 
            this.gb_Color.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Color.Controls.Add(this.rad_black);
            this.gb_Color.Controls.Add(this.rad_blue);
            this.gb_Color.Controls.Add(this.rad_green);
            this.gb_Color.Controls.Add(this.Rad_red);
            this.gb_Color.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_Color.Location = new System.Drawing.Point(12, 158);
            this.gb_Color.Name = "gb_Color";
            this.gb_Color.Size = new System.Drawing.Size(214, 225);
            this.gb_Color.TabIndex = 4;
            this.gb_Color.TabStop = false;
            this.gb_Color.Text = "Color";
            // 
            // gb_action
            // 
            this.gb_action.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_action.Controls.Add(this.btn_exit);
            this.gb_action.Controls.Add(this.btn_clear);
            this.gb_action.Controls.Add(this.btn_display);
            this.gb_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_action.Location = new System.Drawing.Point(412, 158);
            this.gb_action.Name = "gb_action";
            this.gb_action.Size = new System.Drawing.Size(221, 225);
            this.gb_action.TabIndex = 5;
            this.gb_action.TabStop = false;
            this.gb_action.Text = "Action";
            // 
            // chk_visible
            // 
            this.chk_visible.AutoSize = true;
            this.chk_visible.Location = new System.Drawing.Point(257, 158);
            this.chk_visible.Name = "chk_visible";
            this.chk_visible.Size = new System.Drawing.Size(130, 20);
            this.chk_visible.TabIndex = 6;
            this.chk_visible.Text = "Message Visible";
            this.chk_visible.UseVisualStyleBackColor = true;
            this.chk_visible.CheckedChanged += new System.EventHandler(this.chk_visible_CheckedChanged);
            // 
            // pic_small
            // 
            this.pic_small.Image = global::Bai_05.Properties.Resources.light_bulb_12332322;
            this.pic_small.Location = new System.Drawing.Point(286, 203);
            this.pic_small.Name = "pic_small";
            this.pic_small.Size = new System.Drawing.Size(82, 77);
            this.pic_small.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_small.TabIndex = 7;
            this.pic_small.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_small, "Click Me");
            this.pic_small.Visible = false;
            this.pic_small.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_big
            // 
            this.pic_big.Image = global::Bai_05.Properties.Resources.light_bulb_12332322;
            this.pic_big.Location = new System.Drawing.Point(232, 184);
            this.pic_big.Name = "pic_big";
            this.pic_big.Size = new System.Drawing.Size(174, 159);
            this.pic_big.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_big.TabIndex = 8;
            this.pic_big.TabStop = false;
            this.toolTip2.SetToolTip(this.pic_big, "Click Me");
            this.pic_big.Click += new System.EventHandler(this.pic_big_Click);
            // 
            // lbl_Mess
            // 
            this.lbl_Mess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Mess.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Mess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Mess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mess.Location = new System.Drawing.Point(0, 397);
            this.lbl_Mess.Name = "lbl_Mess";
            this.lbl_Mess.Size = new System.Drawing.Size(645, 53);
            this.lbl_Mess.TabIndex = 9;
            // 
            // rad_black
            // 
            this.rad_black.AutoSize = true;
            this.rad_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_black.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rad_black.Location = new System.Drawing.Point(29, 181);
            this.rad_black.Name = "rad_black";
            this.rad_black.Size = new System.Drawing.Size(77, 24);
            this.rad_black.TabIndex = 7;
            this.rad_black.TabStop = true;
            this.rad_black.Text = "Black";
            this.rad_black.UseVisualStyleBackColor = true;
            this.rad_black.CheckedChanged += new System.EventHandler(this.rad_black_CheckedChanged);
            // 
            // rad_blue
            // 
            this.rad_blue.AutoSize = true;
            this.rad_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_blue.ForeColor = System.Drawing.Color.Blue;
            this.rad_blue.Location = new System.Drawing.Point(29, 132);
            this.rad_blue.Name = "rad_blue";
            this.rad_blue.Size = new System.Drawing.Size(68, 24);
            this.rad_blue.TabIndex = 6;
            this.rad_blue.TabStop = true;
            this.rad_blue.Text = "Blue";
            this.rad_blue.UseVisualStyleBackColor = true;
            this.rad_blue.CheckedChanged += new System.EventHandler(this.rad_blue_CheckedChanged);
            // 
            // rad_green
            // 
            this.rad_green.AutoSize = true;
            this.rad_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_green.ForeColor = System.Drawing.Color.Lime;
            this.rad_green.Location = new System.Drawing.Point(29, 74);
            this.rad_green.Name = "rad_green";
            this.rad_green.Size = new System.Drawing.Size(81, 24);
            this.rad_green.TabIndex = 5;
            this.rad_green.TabStop = true;
            this.rad_green.Text = "Green";
            this.rad_green.UseVisualStyleBackColor = true;
            this.rad_green.CheckedChanged += new System.EventHandler(this.rad_green_CheckedChanged);
            // 
            // Rad_red
            // 
            this.Rad_red.AutoSize = true;
            this.Rad_red.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Rad_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_red.ForeColor = System.Drawing.Color.Red;
            this.Rad_red.Location = new System.Drawing.Point(29, 21);
            this.Rad_red.Name = "Rad_red";
            this.Rad_red.Size = new System.Drawing.Size(63, 24);
            this.Rad_red.TabIndex = 4;
            this.Rad_red.TabStop = true;
            this.Rad_red.Text = "Red";
            this.Rad_red.UseVisualStyleBackColor = true;
            this.Rad_red.CheckedChanged += new System.EventHandler(this.Rad_red_CheckedChanged);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(68, 26);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(100, 47);
            this.btn_display.TabIndex = 0;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(68, 87);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 47);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(68, 149);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 47);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.lbl_Mess);
            this.Controls.Add(this.pic_big);
            this.Controls.Add(this.pic_small);
            this.Controls.Add(this.chk_visible);
            this.Controls.Add(this.gb_action);
            this.Controls.Add(this.gb_Color);
            this.Controls.Add(this.gb_inputname);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_inputname.ResumeLayout(false);
            this.gb_inputname.PerformLayout();
            this.gb_Color.ResumeLayout(false);
            this.gb_Color.PerformLayout();
            this.gb_action.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_small)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_big)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_inputname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.GroupBox gb_Color;
        private System.Windows.Forms.GroupBox gb_action;
        private System.Windows.Forms.CheckBox chk_visible;
        private System.Windows.Forms.PictureBox pic_small;
        private System.Windows.Forms.PictureBox pic_big;
        private System.Windows.Forms.Label lbl_Mess;
        private System.Windows.Forms.RadioButton rad_black;
        private System.Windows.Forms.RadioButton rad_blue;
        private System.Windows.Forms.RadioButton rad_green;
        private System.Windows.Forms.RadioButton Rad_red;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

