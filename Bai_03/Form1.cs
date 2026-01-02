using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_holot_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_holot.Text;
        }

        private void lbl_hoten_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_hoten_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_holot.Text + " " + txt_ten.Text;
        }

        private void btn_ten_Click(object sender, EventArgs e)
        {
            lbl_hoten.Text = txt_ten.Text;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ban co chac muon thoat!", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
