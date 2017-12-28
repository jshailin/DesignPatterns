using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPats
{
    /// <summary> 
    /// 作者：jshailin 
    /// 建立时间：17/12/28 周四 下午 04:10:24 
    /// 版权：2017-2036 
    /// CLR版本：4.0.30319.42000 
    /// 修改说明：
    /// HiTextBox说明：本代码版权归海陵所有 
    /// 唯一标识：264cb139-6a51-4eb6-b5ec-3bf9e79971c9 
    /// </summary> 
    public partial class HiTextBox : TextBox
    {
        public HiTextBox()
        {
            InitializeComponent();
        }

        private void HiTextBox_Enter(object sender, EventArgs e)
        {
            this.SelectionStart = 0;
            this.SelectionLength = this.Text.Length;
        }
    }
}
