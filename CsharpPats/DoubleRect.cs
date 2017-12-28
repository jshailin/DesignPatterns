using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPats
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/28 周四 下午 03:42:37 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// DoubleRect说明：本代码版权归海陵所有 
    /// 唯一标识：b3c6cfa4-5b12-4cc2-9235-6fc79d308a7d 
    /// </summary> 
    public class DoubleRect : Rectangle
    {
        private Pen rdPen;
        public DoubleRect(int x, int y, int w, int h)
            : base(x, y, w, h)
        {
            rdPen = new Pen(Color.Red, 2);
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            g.DrawRectangle(rdPen, _x + 5, _y + 5, _w, _h);
        }
    }
}
