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
    public partial class PQGrid : UserControl
    {
        public int _rowNum;
        public int _columnNum;
        public string _direction = "v";
        private int _columnWidth;
        private int _rowHeight;
        private int _spaceV=5;
        private int _spaceH=5;
        private ArrayList _item = new ArrayList();
        private Point point = new Point();
        public PQGrid(int rowNum,int columnNum,int columnWidth, int rowHeight)
        {
            InitializeComponent();
            _rowNum = rowNum;
            _columnNum = columnNum;
            _columnWidth = columnWidth;
            _rowHeight = rowHeight;
            Size s=new Size();
            s.Width=columnNum*columnWidth;
            s.Height=rowNum*rowHeight;
            this.Size = s;
        }
        public PQGrid(int rowNum,int columnNum,int cw, int rh,int spaceV,int spaceH)
        {
            InitializeComponent();
            _rowNum = rowNum;
            _columnNum = columnNum;
            _columnWidth = cw;
            _rowHeight = rh;
            _spaceH = spaceH;
            _spaceV = spaceV;
        }
        public void bindData(ArrayList al,string item)
        {
            int n = al.Count;
			if(n<1)return;
			int pNum = Convert.ToInt32(Math.Round(n / (_rowNum * _columnNum)+0.5));
			int itemNum = 0;
            Type type = Type.GetType(item);
			for (int p = 0; p < pNum;p++){
				for (int i = 0; i < _rowNum; i++) {
					for (int j = 0; j < _columnNum;j++){
                        Object obj=Activator.CreateInstance(type);
						point.X = j % _columnNum * (_columnWidth + _spaceH) + _spaceH;
						point.Y = i * (_rowHeight + _spaceV) + _spaceV;
						if (_direction == "v")point.Y += p * (_rowNum * (_rowHeight + _spaceV) + _spaceV);
						else point.X += p * (_columnNum * (_columnWidth + _spaceH) + _spaceH);
                        ((Control)obj).Location=point;
                        ((IPQGItem)obj).bindData((ArrayList)al[itemNum]);
                        this.Controls.Add((Control)obj);
						itemNum++;
						if (itemNum > n - 1)return;
					}
				}
			}
        }
    }
}
