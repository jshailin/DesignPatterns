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
    /// 建立时间：17/12/28 周四 下午 02:24:24 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// Rectangle说明：本代码版权归海陵所有 
    /// 唯一标识：b786aa32-d310-4790-a270-1854ffc0a8ff 
    /// </summary> 
    public class Rectangle
    {
        protected int _x, _y, _w, _h;
        protected Pen rPen;
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public Rectangle(int x, int y, int w, int h)
        {
            _x = x;
            _y = y;
            _w = w;
            _h = h;
            rPen=new Pen(Color.Black);
        }

        public virtual void Draw(Graphics g)
        {
            g.DrawRectangle(rPen,_x,_y,_w,_h);
        }
    }
}
