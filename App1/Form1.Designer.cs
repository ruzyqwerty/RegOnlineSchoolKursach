
namespace App1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tablesList = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addRowToolboxButton = new System.Windows.Forms.ToolStripButton();
            this.deleteRowToolboxButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 544);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 555);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(46, 17);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1039, 458);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // tablesList
            // 
            this.tablesList.FormattingEnabled = true;
            this.tablesList.Location = new System.Drawing.Point(15, 40);
            this.tablesList.Name = "tablesList";
            this.tablesList.Size = new System.Drawing.Size(208, 24);
            this.tablesList.TabIndex = 3;
            this.tablesList.SelectedIndexChanged += new System.EventHandler(this.TablesList_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolboxButton,
            this.deleteRowToolboxButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addRowToolboxButton
            // 
            this.addRowToolboxButton.Image = ((System.Drawing.Image)(resources.GetObject("addRowToolboxButton.Image")));
            this.addRowToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRowToolboxButton.Name = "addRowToolboxButton";
            this.addRowToolboxButton.Size = new System.Drawing.Size(88, 24);
            this.addRowToolboxButton.Text = "add row";
            this.addRowToolboxButton.Click += new System.EventHandler(this.AddRowToolboxButton_Click);
            // 
            // deleteRowToolboxButton
            // 
            this.deleteRowToolboxButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteRowToolboxButton.Image")));
            this.deleteRowToolboxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteRowToolboxButton.Name = "deleteRowToolboxButton";
            this.deleteRowToolboxButton.Size = new System.Drawing.Size(104, 24);
            this.deleteRowToolboxButton.Text = "delete row";
            this.deleteRowToolboxButton.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 581);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tablesList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Окно администратора";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tablesList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deleteRowToolboxButton;
        private System.Windows.Forms.ToolStripButton addRowToolboxButton;
    }
}

