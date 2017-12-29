using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namer
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/29 周五 上午 09:51:32 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// FirstLast说明：本代码版权归海陵所有 
    /// 唯一标识：6e96d667-ecda-4423-b5df-83dd7abe9c46 
    /// </summary> 
    public class FirstLast:NamerBase
    {
        public FirstLast(string name)
        {
            int i = name.Trim().IndexOf(" ");
            if (i>0)
            {
                frName = name.Substring(0, i).Trim();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}
