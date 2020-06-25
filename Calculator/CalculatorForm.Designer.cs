namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbNR = new System.Windows.Forms.TextBox();
            this.labJG = new System.Windows.Forms.TextBox();
            this.btnJS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbNR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labJG);
            this.splitContainer1.Panel2.Controls.Add(this.btnJS);
            this.splitContainer1.Size = new System.Drawing.Size(747, 466);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbNR
            // 
            this.tbNR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNR.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNR.Location = new System.Drawing.Point(0, 0);
            this.tbNR.Multiline = true;
            this.tbNR.Name = "tbNR";
            this.tbNR.Size = new System.Drawing.Size(494, 466);
            this.tbNR.TabIndex = 0;
            // 
            // labJG
            // 
            this.labJG.BackColor = System.Drawing.SystemColors.Control;
            this.labJG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labJG.Dock = System.Windows.Forms.DockStyle.Top;
            this.labJG.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labJG.Location = new System.Drawing.Point(0, 0);
            this.labJG.Name = "labJG";
            this.labJG.Size = new System.Drawing.Size(249, 22);
            this.labJG.TabIndex = 1;
            this.labJG.Text = "计算结果";
            // 
            // btnJS
            // 
            this.btnJS.Location = new System.Drawing.Point(54, 407);
            this.btnJS.Name = "btnJS";
            this.btnJS.Size = new System.Drawing.Size(119, 37);
            this.btnJS.TabIndex = 0;
            this.btnJS.Text = "计算";
            this.btnJS.UseVisualStyleBackColor = true;
            this.btnJS.Click += new System.EventHandler(this.btnJS_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 466);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "超级计算器";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbNR;
        private System.Windows.Forms.TextBox labJG;
        private System.Windows.Forms.Button btnJS;
    }
}

