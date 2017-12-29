using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namer
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/29 周五 上午 10:02:29 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// LastFirst说明：本代码版权归海陵所有 
    /// 唯一标识：594370e8-0817-48b7-a579-3c3d31f5096e 
    /// </summary> 
    public class LastFirst:NamerBase
    {
        public LastFirst(string name)
        {
            int i = name.Trim().IndexOf(",");
            if (i > 0)
            {
                lName = name.Substring(0, i).Trim();
                frName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}
