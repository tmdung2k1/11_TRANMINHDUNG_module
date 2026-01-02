using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(Form1_keydown);
            this.KeyPreview = true;
        }

        private void lbl_nhapten_Click(object sender, EventArgs e)
        {

        }

        private void txt_nhapten_TextChanged(object sender, EventArgs e)
        {
            lbl_latrinh.Text = txt_nhapten.Text;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co chac muon thoat!", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void Form1_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)//neu nhan phim esc thi thoat
            {
                DialogResult result = MessageBox.Show("ban co chac muon thoat!", "thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Rad_red_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.ForeColor = Color.Red;
            txt_nhapten.ForeColor = Color.Red;
            
        }

        private void rad_green_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.ForeColor = Color.Green;
            txt_nhapten.ForeColor = Color.Green;
        }

        private void rad_blue_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.ForeColor = Color.Blue;
            txt_nhapten.ForeColor = Color.Blue;
        }

        private void rad_black_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.ForeColor = Color.Black;
            txt_nhapten.ForeColor = Color.Black;
        }

        private void chk_Bold_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.Font = new Font
                (lbl_latrinh.Font.Name, lbl_latrinh.Font.Size, lbl_latrinh.Font.Style
                ^ FontStyle.Bold);
        }

        private void chk_italic_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.Font = new Font
                (lbl_latrinh.Font.Name, lbl_latrinh.Font.Size, lbl_latrinh.Font.Style
                ^ FontStyle.Italic);
        }

        private void chk_under_CheckedChanged(object sender, EventArgs e)
        {
            lbl_latrinh.Font = new Font 
                (lbl_latrinh.Font.Name, lbl_latrinh.Font.Size, lbl_latrinh.Font.Style
                ^ FontStyle.Underline);
        }

        private void lbl_latrinh_Click(object sender, EventArgs e)
        {

        }
    }
}
