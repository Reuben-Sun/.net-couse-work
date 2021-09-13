namespace ATM9_13
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.saveMoney = new System.Windows.Forms.Button();
            this.withdrawMoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "银行管理系统";
            // 
            // saveMoney
            // 
            this.saveMoney.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.saveMoney.Location = new System.Drawing.Point(22, 214);
            this.saveMoney.Name = "saveMoney";
            this.saveMoney.Size = new System.Drawing.Size(148, 64);
            this.saveMoney.TabIndex = 1;
            this.saveMoney.Text = "存钱";
            this.saveMoney.UseVisualStyleBackColor = true;
            this.saveMoney.Click += new System.EventHandler(this.saveMoney_Click);
            // 
            // withdrawMoney
            // 
            this.withdrawMoney.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.withdrawMoney.Location = new System.Drawing.Point(249, 214);
            this.withdrawMoney.Name = "withdrawMoney";
            this.withdrawMoney.Size = new System.Drawing.Size(148, 64);
            this.withdrawMoney.TabIndex = 2;
            this.withdrawMoney.Text = "取钱";
            this.withdrawMoney.UseVisualStyleBackColor = true;
            this.withdrawMoney.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(44, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "余额";
            // 
            // moneyText
            // 
            this.moneyText.AutoSize = true;
            this.moneyText.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moneyText.Location = new System.Drawing.Point(156, 120);
            this.moneyText.Name = "moneyText";
            this.moneyText.Size = new System.Drawing.Size(28, 30);
            this.moneyText.TabIndex = 4;
            this.moneyText.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 314);
            this.Controls.Add(this.moneyText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveMoney);
            this.Controls.Add(this.withdrawMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "银行管理系统Alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveMoney;
        private System.Windows.Forms.Button withdrawMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyText;
        private System.Windows.Forms.Timer timer1;
    }
}

