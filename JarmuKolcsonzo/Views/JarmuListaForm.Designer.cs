namespace JarmuKolcsonzo.Views
{
    partial class JarmuListaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarmuListaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UjtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mentestoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TorlestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SzerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TorlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rendszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elerhetoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.szervizdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UjtoolStripButton,
            this.mentestoolStripButton1,
            this.TorlestoolStripButton,
            this.toolStripSeparator1,
            this.keresestoolStripTextBox,
            this.KeresestoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
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
            // mentestoolStripButton1
            // 
            this.mentestoolStripButton1.Image = global::JarmuKolcsonzo.Properties.Resources.saveToolStripButton;
            this.mentestoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentestoolStripButton1.Name = "mentestoolStripButton1";
            this.mentestoolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.mentestoolStripButton1.Text = "Mentés";
            this.mentestoolStripButton1.Click += new System.EventHandler(this.MentestoolStripButton_Click);
            // 
            // TorlestoolStripButton
            // 
            this.TorlestoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("TorlestoolStripButton.Image")));
            this.TorlestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TorlestoolStripButton.Name = "TorlestoolStripButton";
            this.TorlestoolStripButton.Size = new System.Drawing.Size(57, 22);
            this.TorlestoolStripButton.Text = "Törlés";
            this.TorlestoolStripButton.Click += new System.EventHandler(this.TorlestoolStripButton_Click);
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
            this.KeresestoolStripButton.Image = global::JarmuKolcsonzo.Properties.Resources.searchToolStripMenuItem;
            this.KeresestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KeresestoolStripButton.Name = "KeresestoolStripButton";
            this.KeresestoolStripButton.Size = new System.Drawing.Size(66, 22);
            this.KeresestoolStripButton.Text = "Keresés";
            this.KeresestoolStripButton.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.35483F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.12903F));
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
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(485, 11);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(74, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(393, 11);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(70, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(325, 16);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(24, 13);
            this.PageLabel.TabIndex = 4;
            this.PageLabel.Text = "1/1";
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(211, 11);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(70, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(120, 11);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(70, 23);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendszamDataGridViewTextBoxColumn,
            this.tipusidDataGridViewTextBoxColumn,
            this.dijDataGridViewTextBoxColumn,
            this.elerhetoDataGridViewCheckBoxColumn,
            this.szervizdatumDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.jarmuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 371);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // rendszamDataGridViewTextBoxColumn
            // 
            this.rendszamDataGridViewTextBoxColumn.DataPropertyName = "rendszam";
            this.rendszamDataGridViewTextBoxColumn.HeaderText = "Rendszám";
            this.rendszamDataGridViewTextBoxColumn.Name = "rendszamDataGridViewTextBoxColumn";
            // 
            // tipusidDataGridViewTextBoxColumn
            // 
            this.tipusidDataGridViewTextBoxColumn.DataPropertyName = "tipus_id";
            this.tipusidDataGridViewTextBoxColumn.HeaderText = "tipus_id";
            this.tipusidDataGridViewTextBoxColumn.Name = "tipusidDataGridViewTextBoxColumn";
            // 
            // dijDataGridViewTextBoxColumn
            // 
            this.dijDataGridViewTextBoxColumn.DataPropertyName = "dij";
            this.dijDataGridViewTextBoxColumn.HeaderText = "Díj";
            this.dijDataGridViewTextBoxColumn.Name = "dijDataGridViewTextBoxColumn";
            // 
            // elerhetoDataGridViewCheckBoxColumn
            // 
            this.elerhetoDataGridViewCheckBoxColumn.DataPropertyName = "elerheto";
            this.elerhetoDataGridViewCheckBoxColumn.HeaderText = "Elérhető";
            this.elerhetoDataGridViewCheckBoxColumn.Name = "elerhetoDataGridViewCheckBoxColumn";
            // 
            // szervizdatumDataGridViewTextBoxColumn
            // 
            this.szervizdatumDataGridViewTextBoxColumn.DataPropertyName = "szerviz_datum";
            this.szervizdatumDataGridViewTextBoxColumn.HeaderText = "Szervíz Dátum";
            this.szervizdatumDataGridViewTextBoxColumn.Name = "szervizdatumDataGridViewTextBoxColumn";
            // 
            // jarmuBindingSource
            // 
            this.jarmuBindingSource.DataSource = typeof(JarmuKolcsonzo.Models.jarmu);
            // 
            // JarmuListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JarmuListaForm";
            this.Text = "Járműlista";
            this.Load += new System.EventHandler(this.JarmuLista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jarmuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mentestoolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresestoolStripTextBox;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton;
        private System.Windows.Forms.ToolStripButton UjtoolStripButton;
        private System.Windows.Forms.ToolStripButton TorlestoolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SzerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TorlesToolStripMenuItem;
        private System.Windows.Forms.BindingSource jarmuBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn elerhetoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szervizdatumDataGridViewTextBoxColumn;
    }
}