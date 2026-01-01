namespace Bai_02
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
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click
            // 
            this.btn_click.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_click.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_click.ForeColor = System.Drawing.Color.Red;
            this.btn_click.Location = new System.Drawing.Point(249, 160);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(180, 62);
            this.btn_click.TabIndex = 0;
            this.btn_click.Text = "Click Me";
            this.btn_click.UseVisualStyleBackColor = false;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btn_click);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_click;
    }
}

