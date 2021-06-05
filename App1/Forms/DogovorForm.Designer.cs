
namespace App1.Forms
{
    partial class DogovorForm
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
            this.kursNameLabel = new System.Windows.Forms.Label();
            this.kursNameText = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kursNameLabel
            // 
            this.kursNameLabel.AutoSize = true;
            this.kursNameLabel.Location = new System.Drawing.Point(13, 13);
            this.kursNameLabel.Name = "kursNameLabel";
            this.kursNameLabel.Size = new System.Drawing.Size(113, 17);
            this.kursNameLabel.TabIndex = 0;
            this.kursNameLabel.Text = "Название курса";
            // 
            // kursNameText
            // 
            this.kursNameText.AutoSize = true;
            this.kursNameText.Location = new System.Drawing.Point(16, 34);
            this.kursNameText.Name = "kursNameText";
            this.kursNameText.Size = new System.Drawing.Size(69, 17);
            this.kursNameText.TabIndex = 1;
            this.kursNameText.Text = "testestest";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(51, 392);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 2;
            this.acceptBtn.Text = "button1";
            this.acceptBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(231, 392);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "button2";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // DogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.kursNameText);
            this.Controls.Add(this.kursNameLabel);
            this.Name = "DogovorForm";
            this.Text = "DogovorForm";
            this.Load += new System.EventHandler(this.DogovorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kursNameLabel;
        private System.Windows.Forms.Label kursNameText;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}