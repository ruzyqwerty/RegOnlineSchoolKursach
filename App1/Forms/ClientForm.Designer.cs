
namespace App1.Forms
{
    partial class ClientForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chasovSortBox = new System.Windows.Forms.TextBox();
            this.priceSortBox = new System.Windows.Forms.TextBox();
            this.oformitDogovor = new System.Windows.Forms.Button();
            this.kursTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dogovorTable = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogovorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 469);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.chasovSortBox);
            this.tabPage1.Controls.Add(this.priceSortBox);
            this.tabPage1.Controls.Add(this.oformitDogovor);
            this.tabPage1.Controls.Add(this.kursTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Курсы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фильтр по часам (часы меньше n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтр по цене (цена меньше n)";
            // 
            // chasovSortBox
            // 
            this.chasovSortBox.Location = new System.Drawing.Point(274, 410);
            this.chasovSortBox.Name = "chasovSortBox";
            this.chasovSortBox.Size = new System.Drawing.Size(234, 22);
            this.chasovSortBox.TabIndex = 3;
            this.chasovSortBox.TextChanged += new System.EventHandler(this.chasovSortBox_TextChanged);
            // 
            // priceSortBox
            // 
            this.priceSortBox.Location = new System.Drawing.Point(6, 410);
            this.priceSortBox.Name = "priceSortBox";
            this.priceSortBox.Size = new System.Drawing.Size(228, 22);
            this.priceSortBox.TabIndex = 2;
            this.priceSortBox.TextChanged += new System.EventHandler(this.priceSortBox_TextChanged);
            // 
            // oformitDogovor
            // 
            this.oformitDogovor.Location = new System.Drawing.Point(612, 397);
            this.oformitDogovor.Name = "oformitDogovor";
            this.oformitDogovor.Size = new System.Drawing.Size(170, 35);
            this.oformitDogovor.TabIndex = 1;
            this.oformitDogovor.Text = "Оформить договор";
            this.oformitDogovor.UseVisualStyleBackColor = true;
            this.oformitDogovor.Click += new System.EventHandler(this.oformitDogovor_Click);
            // 
            // kursTable
            // 
            this.kursTable.AllowUserToAddRows = false;
            this.kursTable.AllowUserToDeleteRows = false;
            this.kursTable.AllowUserToOrderColumns = true;
            this.kursTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kursTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kursTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.kursTable.Location = new System.Drawing.Point(6, 6);
            this.kursTable.Name = "kursTable";
            this.kursTable.RowHeadersWidth = 51;
            this.kursTable.RowTemplate.Height = 24;
            this.kursTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kursTable.Size = new System.Drawing.Size(776, 378);
            this.kursTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название курса";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Преподаватель";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Организация";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во часов";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 114;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цена";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 72;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dogovorTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Договоры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dogovorTable
            // 
            this.dogovorTable.AllowUserToAddRows = false;
            this.dogovorTable.AllowUserToDeleteRows = false;
            this.dogovorTable.AllowUserToOrderColumns = true;
            this.dogovorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dogovorTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dogovorTable.Location = new System.Drawing.Point(8, 6);
            this.dogovorTable.Name = "dogovorTable";
            this.dogovorTable.RowHeadersWidth = 51;
            this.dogovorTable.RowTemplate.Height = 24;
            this.dogovorTable.Size = new System.Drawing.Size(776, 398);
            this.dogovorTable.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название курса";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Организация";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Цена";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Дата оформления";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kursTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dogovorTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView kursTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button oformitDogovor;
        private System.Windows.Forms.DataGridView dogovorTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox chasovSortBox;
        private System.Windows.Forms.TextBox priceSortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}