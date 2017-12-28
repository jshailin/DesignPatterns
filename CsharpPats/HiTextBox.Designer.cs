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
    partial class HiTextBox
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HiTextBox
            // 
            this.Enter += new System.EventHandler(this.HiTextBox_Enter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
