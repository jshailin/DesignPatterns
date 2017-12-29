using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namer
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/29 周五 上午 10:05:47 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// NameFactory说明：本代码版权归海陵所有 
    /// 唯一标识：4cb5bf3a-651e-469d-b38a-ff70491b59ed 
    /// </summary> 
    public class NameFactory
    {
        public static NamerBase GetNamer(string name)
        {
            int i = name.IndexOf(",");
            if (i>0)
            {
                return new LastFirst(name);
            }
            else
            {
                return new FirstLast(name);
            }
        }
    }
}
