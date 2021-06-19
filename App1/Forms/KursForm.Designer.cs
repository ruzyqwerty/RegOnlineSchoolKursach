
namespace App1.Forms
{
    partial class KursForm
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
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.kursNameTextBox = new System.Windows.Forms.TextBox();
            this.chasovNumUD = new System.Windows.Forms.NumericUpDown();
            this.priceNumUD = new System.Windows.Forms.NumericUpDown();
            this.prepodNameComboBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chasovNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(13, 78);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(325, 24);
            this.orgNameComboBox.TabIndex = 0;
            // 
            // kursNameTextBox
            // 
            this.kursNameTextBox.Location = new System.Drawing.Point(13, 33);
            this.kursNameTextBox.Name = "kursNameTextBox";
            this.kursNameTextBox.Size = new System.Drawing.Size(325, 22);
            this.kursNameTextBox.TabIndex = 1;
            // 
            // chasovNumUD
            // 
            this.chasovNumUD.Location = new System.Drawing.Point(116, 155);
            this.chasovNumUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.chasovNumUD.Name = "chasovNumUD";
            this.chasovNumUD.Size = new System.Drawing.Size(221, 22);
            this.chasovNumUD.TabIndex = 2;
            // 
            // priceNumUD
            // 
            this.priceNumUD.Location = new System.Drawing.Point(116, 183);
            this.priceNumUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNumUD.Name = "priceNumUD";
            this.priceNumUD.Size = new System.Drawing.Size(221, 22);
            this.priceNumUD.TabIndex = 3;
            // 
            // prepodNameComboBox
            // 
            this.prepodNameComboBox.FormattingEnabled = true;
            this.prepodNameComboBox.Location = new System.Drawing.Point(12, 125);
            this.prepodNameComboBox.Name = "prepodNameComboBox";
            this.prepodNameComboBox.Size = new System.Drawing.Size(324, 24);
            this.prepodNameComboBox.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(215, 232);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 38);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(44, 232);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(97, 38);
            this.AcceptBtn.TabIndex = 7;
            this.AcceptBtn.Text = "Изменить";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Преподаватель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во часов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.prepodNameComboBox);
            this.Controls.Add(this.priceNumUD);
            this.Controls.Add(this.chasovNumUD);
            this.Controls.Add(this.kursNameTextBox);
            this.Controls.Add(this.orgNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KursForm";
            this.Text = "Окно курса";
            this.Load += new System.EventHandler(this.KursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chasovNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.TextBox kursNameTextBox;
        private System.Windows.Forms.NumericUpDown chasovNumUD;
        private System.Windows.Forms.NumericUpDown priceNumUD;
        private System.Windows.Forms.ComboBox prepodNameComboBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}