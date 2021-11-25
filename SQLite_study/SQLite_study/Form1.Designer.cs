namespace SQLite_study
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
            this.createTableButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.classText = new System.Windows.Forms.TextBox();
            this.schoolText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTableButton
            // 
            this.createTableButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.createTableButton.Location = new System.Drawing.Point(58, 342);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(131, 72);
            this.createTableButton.TabIndex = 2;
            this.createTableButton.Text = "建表";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.insertButton.Location = new System.Drawing.Point(239, 342);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(131, 72);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "插入";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.readButton.Location = new System.Drawing.Point(426, 342);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(131, 72);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "读表";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deleteButton.Location = new System.Drawing.Point(627, 342);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(131, 72);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "删除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameText.Location = new System.Drawing.Point(58, 237);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(151, 53);
            this.nameText.TabIndex = 7;
            this.nameText.Text = "孙政";
            // 
            // classText
            // 
            this.classText.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.classText.Location = new System.Drawing.Point(313, 237);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(151, 53);
            this.classText.TabIndex = 8;
            this.classText.Text = "3班";
            // 
            // schoolText
            // 
            this.schoolText.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.schoolText.Location = new System.Drawing.Point(569, 237);
            this.schoolText.Name = "schoolText";
            this.schoolText.Size = new System.Drawing.Size(189, 53);
            this.schoolText.TabIndex = 9;
            this.schoolText.Text = "武汉大学";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(303, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(559, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "学校";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(48, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(565, 60);
            this.label4.TabIndex = 13;
            this.label4.Text = "大量信息在命令行中";
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logButton.Location = new System.Drawing.Point(627, 14);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(131, 72);
            this.logButton.TabIndex = 14;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.schoolText);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.createTableButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.TextBox schoolText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logButton;
    }
}

