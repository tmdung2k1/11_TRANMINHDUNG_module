using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_line.Height = 2;
            lbl_line.BackColor = Color.Black;
            lbl_line.Text = string.Empty;
            lbl_line.BorderStyle = BorderStyle.None;

            
            lbl_line.Top = btn_thoat.Bottom - lbl_line.Height;

            
            lbl_line.Left = label2.Right + 6;
            lbl_line.Width = Math.Max(10, btn_thoat.Left - lbl_line.Left - 6);

           
            lbl_line.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            
            lbl_line.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lbl_line_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pic_off_Click(object sender, EventArgs e)
        {
            pic_off.Visible = false;
            pic_on.Visible = true;
            lbl_hienthi.Text = txt_name.Text + " .Turn off the light, Please!";
        }

        private void pic_on_Click(object sender, EventArgs e)
        {
            pic_on.Visible = false;
            pic_off.Visible = true;
            lbl_hienthi.Text = txt_name.Text + " .Turn on the light, Please!";
        }
    }
}
