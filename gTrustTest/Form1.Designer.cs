namespace gTrustTest
{
    partial class Form1
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
            this.FileText = new System.Windows.Forms.TextBox();
            this.ShowBox = new System.Windows.Forms.RichTextBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.FileName = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileText
            // 
            this.FileText.Location = new System.Drawing.Point(77, 240);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(286, 20);
            this.FileText.TabIndex = 0;
            // 
            // ShowBox
            // 
            this.ShowBox.Location = new System.Drawing.Point(13, 12);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Size = new System.Drawing.Size(619, 206);
            this.ShowBox.TabIndex = 2;
            this.ShowBox.Text = "";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(369, 240);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 3;
            this.LoadBtn.Text = "Load Button";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(17, 243);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(57, 13);
            this.FileName.TabIndex = 4;
            this.FileName.Text = "File Name:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(369, 290);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "Save Button";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.FileText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileText;
        private System.Windows.Forms.RichTextBox ShowBox;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button SaveBtn;
    }
}

