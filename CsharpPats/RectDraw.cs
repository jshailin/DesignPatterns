﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPats
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/28 周四 下午 01:58:46 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// CsharpPats说明：本代码版权归海陵所有 
    /// 唯一标识：c19277e8-7031-494d-bdca-4dc8106812d4 
    /// </summary>


    public partial class RectDraw : Form
    {
        private DoubleRect rec;
        private Square sq;
        public RectDraw()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            rec=new DoubleRect(10,20,70,100);
            sq=new Square(150,100,70);
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Pen rPen=new Pen(Color.Black);
            //g.DrawLine(rPen,10,20,70,80);
            rec.Draw(g);
            sq.Draw(g);
        }
    }
}
