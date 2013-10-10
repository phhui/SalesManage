using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SalesManage
{
    public partial class NumberInput : UserControl
    {
        public Double n = 0;
        private TextBox txt;
        public NumberInput()
        {
            InitializeComponent();
        }
        public void setText(TextBox t)
        {
            txt = t;
        }
        private void btnClick(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            txt_num.Text += b.Name.Replace("btn_n","");
            txt.Text = txt_num.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (txt_num.Text.Length > 0)
            {
                n = Convert.ToDouble(txt_num.Text);
                txt.Text = n.ToString();
            }
            this.Hide();
            txt_num.Text = "";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txt_num.Text += ".";
        }
    }
}
