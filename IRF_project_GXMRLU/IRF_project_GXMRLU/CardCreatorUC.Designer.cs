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
            // CardCreatorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeBtn);
            this.Name = "CardCreatorUC";
            this.Size = new System.Drawing.Size(822, 375);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button treeBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}
