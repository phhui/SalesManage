using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesManage
{
    public partial class main : Form
    {
        private NumberInput ni = new NumberInput();
        private Point p = new Point();
        private fertilizerType f = new fertilizerType();
        public main()
        {
            InitializeComponent();
        }

        private void txt_num0_Click(object sender, EventArgs e)
        {
            TextBox tb=(TextBox)sender;
            ni.setText(tb);
            p.X = 200;
            p.Y = 150;
            ni.Show();
            ni.Location = p;
            this.Controls.Add(ni);
            ni.BringToFront();
            f.Show();
            f.BringToFront();
        }
    }
}
