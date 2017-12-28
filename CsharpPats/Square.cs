using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPats
{
    /// <inheritdoc />
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/28 周四 下午 03:24:45 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// Square说明：本代码版权归海陵所有 
    /// 唯一标识：0576aaab-d7fd-4905-97f3-2acb70fb0b23 
    /// </summary> 
    public class Square : Rectangle
    {
        public Square(int x, int y, int w) : base(x, y, w, w)
        {
        }
    }
}
