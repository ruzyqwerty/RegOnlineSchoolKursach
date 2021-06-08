
namespace App1.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addClientToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteClientToolButton = new System.Windows.Forms.ToolStripButton();
            this.clientsTable = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Организации = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addOrgToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteOrgToolButton = new System.Windows.Forms.ToolStripButton();
            this.orgsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Преподаватели = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.addPrepodToolButton = new System.Windows.Forms.ToolStripButton();
            this.deletePrepodToolButton = new System.Windows.Forms.ToolStripButton();
            this.prepodsTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).BeginInit();
            this.Организации.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgsTable)).BeginInit();
            this.Преподаватели.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.Организации);
            this.tabControl1.Controls.Add(this.Преподаватели);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.clientsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolButton,
            this.deleteClientToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addClientToolButton
            // 
            this.addClientToolButton.Image = ((System.Drawing.Image)(resources.GetObject("addClientToolButton.Image")));
            this.addClientToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addClientToolButton.Name = "addClientToolButton";
            this.addClientToolButton.Size = new System.Drawing.Size(159, 24);
            this.addClientToolButton.Text = "Добавить клиента";
            this.addClientToolButton.Click += new System.EventHandler(this.addClientToolButton_Click);
            // 
            // deleteClientToolButton
            // 
            this.deleteClientToolButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteClientToolButton.Image")));
            this.deleteClientToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteClientToolButton.Name = "deleteClientToolButton";
            this.deleteClientToolButton.Size = new System.Drawing.Size(148, 24);
            this.deleteClientToolButton.Text = "Удалить клиента";
            this.deleteClientToolButton.Click += new System.EventHandler(this.deleteClientToolButton_Click);
            // 
            // clientsTable
            // 
            this.clientsTable.AllowUserToDeleteRows = false;
            this.clientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.clientsTable.Location = new System.Drawing.Point(8, 40);
            this.clientsTable.Name = "clientsTable";
            this.clientsTable.RowHeadersWidth = 51;
            this.clientsTable.RowTemplate.Height = 24;
            this.clientsTable.Size = new System.Drawing.Size(767, 347);
            this.clientsTable.TabIndex = 0;
            this.clientsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsTable_CellEndEdit);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 64;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Телефон";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 97;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Номер паспорта";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 134;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Организации
            // 
            this.Организации.Controls.Add(this.toolStrip2);
            this.Организации.Controls.Add(this.orgsTable);
            this.Организации.Location = new System.Drawing.Point(4, 25);
            this.Организации.Name = "Организации";
            this.Организации.Size = new System.Drawing.Size(792, 421);
            this.Организации.TabIndex = 3;
            this.Организации.Text = "Организации";
            this.Организации.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrgToolButton,
            this.deleteOrgToolButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(792, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addOrgToolButton
            // 
            this.addOrgToolButton.Image = ((System.Drawing.Image)(resources.GetObject("addOrgToolButton.Image")));
            this.addOrgToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addOrgToolButton.Name = "addOrgToolButton";
            this.addOrgToolButton.Size = new System.Drawing.Size(199, 24);
            this.addOrgToolButton.Text = "Добавить организацию";
            this.addOrgToolButton.Click += new System.EventHandler(this.addOrgToolButton_Click);
            // 
            // deleteOrgToolButton
            // 
            this.deleteOrgToolButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteOrgToolButton.Image")));
            this.deleteOrgToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteOrgToolButton.Name = "deleteOrgToolButton";
            this.deleteOrgToolButton.Size = new System.Drawing.Size(188, 24);
            this.deleteOrgToolButton.Text = "Удалить организацию";
            this.deleteOrgToolButton.Click += new System.EventHandler(this.deleteOrgToolButton_Click);
            // 
            // orgsTable
            // 
            this.orgsTable.AllowUserToDeleteRows = false;
            this.orgsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.orgsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orgsTable.Location = new System.Drawing.Point(8, 30);
            this.orgsTable.Name = "orgsTable";
            this.orgsTable.RowHeadersWidth = 51;
            this.orgsTable.RowTemplate.Height = 24;
            this.orgsTable.Size = new System.Drawing.Size(767, 347);
            this.orgsTable.TabIndex = 2;
            this.orgsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.orgsTable_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 101;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Руководитель";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 129;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 97;
            // 
            // Преподаватели
            // 
            this.Преподаватели.Controls.Add(this.toolStrip3);
            this.Преподаватели.Controls.Add(this.prepodsTable);
            this.Преподаватели.Location = new System.Drawing.Point(4, 25);
            this.Преподаватели.Name = "Преподаватели";
            this.Преподаватели.Size = new System.Drawing.Size(792, 421);
            this.Преподаватели.TabIndex = 4;
            this.Преподаватели.Text = "Преподаватели";
            this.Преподаватели.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPrepodToolButton,
            this.deletePrepodToolButton});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(792, 27);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // addPrepodToolButton
            // 
            this.addPrepodToolButton.Image = ((System.Drawing.Image)(resources.GetObject("addPrepodToolButton.Image")));
            this.addPrepodToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPrepodToolButton.Name = "addPrepodToolButton";
            this.addPrepodToolButton.Size = new System.Drawing.Size(210, 24);
            this.addPrepodToolButton.Text = "Добавить преподавателя";
            this.addPrepodToolButton.Click += new System.EventHandler(this.addPrepodToolButton_Click);
            // 
            // deletePrepodToolButton
            // 
            this.deletePrepodToolButton.Image = ((System.Drawing.Image)(resources.GetObject("deletePrepodToolButton.Image")));
            this.deletePrepodToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePrepodToolButton.Name = "deletePrepodToolButton";
            this.deletePrepodToolButton.Size = new System.Drawing.Size(199, 24);
            this.deletePrepodToolButton.Text = "Удалить преподавателя";
            this.deletePrepodToolButton.Click += new System.EventHandler(this.deletePrepodToolButton_Click);
            // 
            // prepodsTable
            // 
            this.prepodsTable.AllowUserToDeleteRows = false;
            this.prepodsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.prepodsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prepodsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column7,
            this.Column8});
            this.prepodsTable.Location = new System.Drawing.Point(8, 52);
            this.prepodsTable.Name = "prepodsTable";
            this.prepodsTable.RowHeadersWidth = 51;
            this.prepodsTable.RowTemplate.Height = 24;
            this.prepodsTable.Size = new System.Drawing.Size(767, 347);
            this.prepodsTable.TabIndex = 4;
            this.prepodsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.prepodsTable_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 64;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 99;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Стаж";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Телефон";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 97;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Номер паспорта";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 134;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForm";
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsTable)).EndInit();
            this.Организации.ResumeLayout(false);
            this.Организации.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgsTable)).EndInit();
            this.Преподаватели.ResumeLayout(false);
            this.Преподаватели.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView clientsTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addClientToolButton;
        private System.Windows.Forms.ToolStripButton deleteClientToolButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage Организации;
        private System.Windows.Forms.TabPage Преподаватели;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton addOrgToolButton;
        private System.Windows.Forms.ToolStripButton deleteOrgToolButton;
        private System.Windows.Forms.DataGridView orgsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton addPrepodToolButton;
        private System.Windows.Forms.ToolStripButton deletePrepodToolButton;
        private System.Windows.Forms.DataGridView prepodsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}