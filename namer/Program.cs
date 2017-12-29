using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namer
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/29 周五 上午 09:29:07 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// namer说明：本代码版权归海陵所有 
    /// 唯一标识：1e4a3d18-efb5-4bdc-b772-0a2544f44cb8 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DEMO());
        }
    }
}
