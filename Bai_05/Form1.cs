using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic_small.Visible = false;
            pic_big.Visible = true;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbl_Mess.Text = txt_name.Text + ":"
                + txt_Message.Text;
        }
        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbl_Mess.Text = txt_name.Text + ":"
                    + txt_Message.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(Form1_keydown);
            this.KeyPreview = true;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            txt_name.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_Message.Clear();
        }

        private void Rad_red_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Mess.ForeColor = Color.Red;
        }

        private void rad_green_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Mess.ForeColor = Color.Green;
        }

        private void rad_blue_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Mess.ForeColor = Color.Blue;
        }

        private void rad_black_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Mess.ForeColor = Color.Black;
        }

        private void chk_visible_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Mess.Visible = chk_visible.Checked;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_big_Click(object sender, EventArgs e)
        {
            pic_big.Visible = false;
            pic_small.Visible = true;
        }
    }
}
