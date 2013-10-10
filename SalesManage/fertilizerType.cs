using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesManage.UI;
using System.Collections;

namespace SalesManage
{
    public partial class fertilizerType : Form
    {
        public fertilizerType()
        {
            InitializeComponent();
        }

        private void fertilizerType_Load(object sender, EventArgs e)
        {
            PQGrid g = new PQGrid(4,4,30, 30);
            ArrayList al = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                ArrayList a = new ArrayList();
                a.Add("aa"+i.ToString());
                a.Add("ab" + i.ToString());
                a.Add("ac" + i.ToString());
                a.Add("ad" + i.ToString());
                al.Add(a);
            }
            g.bindData(al, "SalesManage.UI.PQGItem");
            this.Controls.Add(g);
        }
    }
}
