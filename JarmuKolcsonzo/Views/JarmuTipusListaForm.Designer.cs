namespace JarmuKolcsonzo.Views
{
    partial class JarmuTipusListaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarmuTipusListaForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SzerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TorlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarmutipusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mentestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UjtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TorlesoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.megnevezesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ferohelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jarmutipusBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SzerkToolStripMenuItem,
            this.TorlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // SzerkToolStripMenuItem
            // 
            this.SzerkToolStripMenuItem.Name = "SzerkToolStripMenuItem";
            this.SzerkToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.SzerkToolStripMenuItem.Text = "Szerkesztés";
            this.SzerkToolStripMenuItem.Click += new System.EventHandler(this.SzerkToolStripMenuItem_Click);
            // 
            // TorlesToolStripMenuItem
            // 
            this.TorlesToolStripMenuItem.Name = "TorlesToolStripMenuItem";
            this.TorlesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.TorlesToolStripMenuItem.Text = "Törlés";
            this.TorlesToolStripMenuItem.Click += new System.EventHandler(this.TorlesToolStripMenuItem_Click);
            // 
            // jarmutipusBindingSource
            // 
            this.jarmutipusBindingSource.DataSource = typeof(JarmuKolcsonzo.Models.jarmu_tipus);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentestoolStripButton,
            this.UjtoolStripButton,
            this.TorlesoolStripButton1,
            this.toolStripSeparator1,
            this.keresestoolStripTextBox,
            this.KeresestoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mentestoolStripButton
            // 
            this.mentestoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("mentestoolStripButton.Image")));
            this.mentestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentestoolStripButton.Name = "mentestoolStripButton";
            this.mentestoolStripButton.Size = new System.Drawing.Size(66, 22);
            this.mentestoolStripButton.Text = "Mentés";
            this.mentestoolStripButton.Click += new System.EventHandler(this.MentestoolStripButton_Click);
            // 
            // UjtoolStripButton
            // 
            this.UjtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UjtoolStripButton.Image")));
            this.UjtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UjtoolStripButton.Name = "UjtoolStripButton";
            this.UjtoolStripButton.Size = new System.Drawing.Size(38, 22);
            this.UjtoolStripButton.Text = "Új";
            this.UjtoolStripButton.Click += new System.EventHandler(this.UjtoolStripButton_Click);
            // 
            // TorlesoolStripButton1
            // 
            this.TorlesoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("TorlesoolStripButton1.Image")));
            this.TorlesoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TorlesoolStripButton1.Name = "TorlesoolStripButton1";
            this.TorlesoolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.TorlesoolStripButton1.Text = "Törlés";
            this.TorlesoolStripButton1.Click += new System.EventHandler(this.TorlestoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // keresestoolStripTextBox
            // 
            this.keresestoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keresestoolStripTextBox.Name = "keresestoolStripTextBox";
            this.keresestoolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // KeresestoolStripButton
            // 
            this.KeresestoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("KeresestoolStripButton.Image")));
            this.KeresestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KeresestoolStripButton.Name = "KeresestoolStripButton";
            this.KeresestoolStripButton.Size = new System.Drawing.Size(66, 22);
            this.KeresestoolStripButton.Text = "Keresés";
            this.KeresestoolStripButton.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.PageLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotalItemsLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(65, 405);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 45);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(482, 11);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(386, 11);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(73, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(317, 16);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(24, 13);
            this.PageLabel.TabIndex = 4;
            this.PageLabel.Text = "1/1";
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(198, 11);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(73, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(104, 11);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(73, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.Location = new System.Drawing.Point(3, 16);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(56, 13);
            this.TotalItemsLabel.TabIndex = 5;
            this.TotalItemsLabel.Text = "Összesen:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.megnevezesDataGridViewTextBoxColumn,
            this.ferohelyDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.jarmutipusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 371);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // megnevezesDataGridViewTextBoxColumn
            // 
            this.megnevezesDataGridViewTextBoxColumn.DataPropertyName = "megnevezes";
            this.megnevezesDataGridViewTextBoxColumn.FillWeight = 100.1364F;
            this.megnevezesDataGridViewTextBoxColumn.HeaderText = "Megnevezés";
            this.megnevezesDataGridViewTextBoxColumn.Name = "megnevezesDataGridViewTextBoxColumn";
            this.megnevezesDataGridViewTextBoxColumn.Width = 93;
            // 
            // ferohelyDataGridViewTextBoxColumn
            // 
            this.ferohelyDataGridViewTextBoxColumn.DataPropertyName = "ferohely";
            this.ferohelyDataGridViewTextBoxColumn.FillWeight = 99.86359F;
            this.ferohelyDataGridViewTextBoxColumn.HeaderText = "Férőhely";
            this.ferohelyDataGridViewTextBoxColumn.Name = "ferohelyDataGridViewTextBoxColumn";
            this.ferohelyDataGridViewTextBoxColumn.Width = 72;
            // 
            // JarmuTipusListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JarmuTipusListaForm";
            this.Text = "Jármű Típusok";
            this.Load += new System.EventHandler(this.JarmuTipusListaForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jarmutipusBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mentestoolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresestoolStripTextBox;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton;
        private System.Windows.Forms.ToolStripButton UjtoolStripButton;
        private System.Windows.Forms.ToolStripButton TorlesoolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SzerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TorlesToolStripMenuItem;
        private System.Windows.Forms.BindingSource jarmutipusBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn megnevezesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ferohelyDataGridViewTextBoxColumn;
    }
}