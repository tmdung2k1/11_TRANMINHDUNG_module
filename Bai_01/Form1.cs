using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            txt_hienthi.Text = txt_nhappwd.Text;
        }

        private void btn_tiep_Click(object sender, EventArgs e)
        {
            txt_hienthi.Clear();
            txt_nhappwd.Clear();
            txt_nhappwd.Focus();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
