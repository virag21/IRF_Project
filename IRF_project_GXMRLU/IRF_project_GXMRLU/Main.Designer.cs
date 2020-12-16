namespace IRF_project_GXMRLU
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sendLetterBtn = new System.Windows.Forms.Button();
            this.uploadData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sendGifts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendLetterBtn
            // 
            this.sendLetterBtn.BackColor = System.Drawing.Color.LightGray;
            this.sendLetterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendLetterBtn.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendLetterBtn.Location = new System.Drawing.Point(393, 258);
            this.sendLetterBtn.Name = "sendLetterBtn";
            this.sendLetterBtn.Size = new System.Drawing.Size(249, 35);
            this.sendLetterBtn.TabIndex = 13;
            this.sendLetterBtn.Text = "Write a letter to Santa!";
            this.sendLetterBtn.UseVisualStyleBackColor = false;
            this.sendLetterBtn.Click += new System.EventHandler(this.sendLetterBtn_Click_1);
            // 
            // uploadData
            // 
            this.uploadData.BackColor = System.Drawing.Color.LightGray;
            this.uploadData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadData.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uploadData.Location = new System.Drawing.Point(393, 205);
            this.uploadData.Name = "uploadData";
            this.uploadData.Size = new System.Drawing.Size(249, 35);
            this.uploadData.TabIndex = 10;
            this.uploadData.Text = "Upload Order Data";
            this.uploadData.UseVisualStyleBackColor = false;
            this.uploadData.Click += new System.EventHandler(this.uploadData_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(379, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Welcome to The North Pole!";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(273, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(489, 56);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "We are working here at The North Pole so that everyone around the world can have " +
    "a holly jolly Christmas every year! ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendGifts
            // 
            this.sendGifts.BackColor = System.Drawing.Color.LightGray;
            this.sendGifts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendGifts.Font = new System.Drawing.Font("Bookman Old Style", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendGifts.Location = new System.Drawing.Point(393, 151);
            this.sendGifts.Name = "sendGifts";
            this.sendGifts.Size = new System.Drawing.Size(249, 35);
            this.sendGifts.TabIndex = 9;
            this.sendGifts.Text = "Send Gifts";
            this.sendGifts.UseVisualStyleBackColor = false;
            this.sendGifts.Click += new System.EventHandler(this.sendGifts_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.sendLetterBtn);
            this.Controls.Add(this.uploadData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sendGifts);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(825, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendLetterBtn;
        private System.Windows.Forms.Button uploadData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button sendGifts;
    }
}
