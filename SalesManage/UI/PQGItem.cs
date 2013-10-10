using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SalesManage.UI
{
    public partial class PQGItem : UserControl,IPQGItem
    {
        public PQGItem()
        {
            InitializeComponent();
        }


        public void bindData(ArrayList al)
        {
            Label tb = new Label();
            tb.Text = al[0].ToString();
            tb.BringToFront();
            this.Controls.Add(tb);
        }
    }
}
