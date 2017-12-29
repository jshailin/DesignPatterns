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
    partial class DEMO
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.lbFirst = new System.Windows.Forms.Label();
            this.lbLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入全名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 29);
            this.txtName.TabIndex = 1;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(237, 70);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(53, 32);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "拆分";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbFirst.Location = new System.Drawing.Point(20, 76);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(0, 21);
            this.lbFirst.TabIndex = 3;
            // 
            // lbLast
            // 
            this.lbLast.AutoSize = true;
            this.lbLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbLast.Location = new System.Drawing.Point(20, 117);
            this.lbLast.Name = "lbLast";
            this.lbLast.Size = new System.Drawing.Size(0, 21);
            this.lbLast.TabIndex = 4;
            // 
            // DEMO
            // 
            this.AcceptButton = this.btnAction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 173);
            this.Controls.Add(this.lbLast);
            this.Controls.Add(this.lbFirst);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "DEMO";
            this.Text = "Demo Namer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lbFirst;
        private System.Windows.Forms.Label lbLast;
    }
}

