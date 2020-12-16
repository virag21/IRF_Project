namespace IRF_project_GXMRLU
{
    partial class CardCreatorUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeBtn
            // 
            this.treeBtn.Location = new System.Drawing.Point(611, 100);
            this.treeBtn.Name = "treeBtn";
            this.treeBtn.Size = new System.Drawing.Size(146, 36);
            this.treeBtn.TabIndex = 0;
            this.treeBtn.Text = "Christmas Tree";
            this.treeBtn.UseVisualStyleBackColor = true;
            this.treeBtn.Click += new System.EventHandler(this.treeBtn_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 154);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Dear Santa!";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(611, 270);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(146, 36);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(3, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(65, 34);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CardCreatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeBtn);
            this.Name = "CardCreatorUC";
            this.Size = new System.Drawing.Size(825, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button treeBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button backBtn;
    }
}
