
namespace App1.Forms
{
    partial class EditDogovorForm
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
            this.clientNameComboBox = new System.Windows.Forms.ComboBox();
            this.kursNameComboBox = new System.Windows.Forms.ComboBox();
            this.orgNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataCreateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientNameComboBox
            // 
            this.clientNameComboBox.FormattingEnabled = true;
            this.clientNameComboBox.Location = new System.Drawing.Point(12, 29);
            this.clientNameComboBox.Name = "clientNameComboBox";
            this.clientNameComboBox.Size = new System.Drawing.Size(269, 24);
            this.clientNameComboBox.TabIndex = 0;
            // 
            // kursNameComboBox
            // 
            this.kursNameComboBox.FormattingEnabled = true;
            this.kursNameComboBox.Location = new System.Drawing.Point(12, 85);
            this.kursNameComboBox.Name = "kursNameComboBox";
            this.kursNameComboBox.Size = new System.Drawing.Size(269, 24);
            this.kursNameComboBox.TabIndex = 1;
            // 
            // orgNameComboBox
            // 
            this.orgNameComboBox.FormattingEnabled = true;
            this.orgNameComboBox.Location = new System.Drawing.Point(12, 146);
            this.orgNameComboBox.Name = "orgNameComboBox";
            this.orgNameComboBox.Size = new System.Drawing.Size(269, 24);
            this.orgNameComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название курса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Организация";
            // 
            // dataCreateCalendar
            // 
            this.dataCreateCalendar.Location = new System.Drawing.Point(12, 209);
            this.dataCreateCalendar.MaxSelectionCount = 1;
            this.dataCreateCalendar.Name = "dataCreateCalendar";
            this.dataCreateCalendar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата создания";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(12, 428);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(115, 34);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(169, 428);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(115, 34);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EditDogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 474);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataCreateCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgNameComboBox);
            this.Controls.Add(this.kursNameComboBox);
            this.Controls.Add(this.clientNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDogovorForm";
            this.Text = "Изменение договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientNameComboBox;
        private System.Windows.Forms.ComboBox kursNameComboBox;
        private System.Windows.Forms.ComboBox orgNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar dataCreateCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}