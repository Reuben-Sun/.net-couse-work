namespace ATM9_13.Properties
{
    partial class InputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputText = new System.Windows.Forms.TextBox();
            this.click_Cancel = new System.Windows.Forms.Button();
            this.click_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputText.Location = new System.Drawing.Point(21, 12);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(314, 42);
            this.inputText.TabIndex = 0;
            // 
            // click_Cancel
            // 
            this.click_Cancel.Location = new System.Drawing.Point(162, 69);
            this.click_Cancel.Name = "click_Cancel";
            this.click_Cancel.Size = new System.Drawing.Size(75, 38);
            this.click_Cancel.TabIndex = 1;
            this.click_Cancel.Text = "取消";
            this.click_Cancel.UseVisualStyleBackColor = true;
            this.click_Cancel.Click += new System.EventHandler(this.click_Cancel_Click);
            // 
            // click_OK
            // 
            this.click_OK.Location = new System.Drawing.Point(260, 69);
            this.click_OK.Name = "click_OK";
            this.click_OK.Size = new System.Drawing.Size(75, 38);
            this.click_OK.TabIndex = 2;
            this.click_OK.Text = "确认";
            this.click_OK.UseVisualStyleBackColor = true;
            this.click_OK.Click += new System.EventHandler(this.click_OK_Click);
            // 
            // InputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 123);
            this.Controls.Add(this.click_OK);
            this.Controls.Add(this.click_Cancel);
            this.Controls.Add(this.inputText);
            this.Name = "InputDialog";
            this.Text = "InputDialog";
            this.Load += new System.EventHandler(this.InputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button click_Cancel;
        private System.Windows.Forms.Button click_OK;
    }
}