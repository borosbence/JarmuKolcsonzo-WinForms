namespace JarmuKolcsonzo.Views
{
    partial class RendelesListaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RendelesListaForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.OsszesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UjtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TorlestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rendelesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelTelefonszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelPontDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmuRendszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarmuFerohelyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendelesVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rendelesVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OsszesLabel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 10;
            // 
            // OsszesLabel
            // 
            this.OsszesLabel.AutoSize = true;
            this.OsszesLabel.Location = new System.Drawing.Point(12, 12);
            this.OsszesLabel.Name = "OsszesLabel";
            this.OsszesLabel.Size = new System.Drawing.Size(59, 13);
            this.OsszesLabel.TabIndex = 3;
            this.OsszesLabel.Text = "Összesen: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 42);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(86, 9);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(58, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(9, 9);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(58, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(318, 9);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(58, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(240, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(58, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0/0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UjtoolStripButton,
            this.TorlestoolStripButton,
            this.mentestoolStripButton,
            this.toolStripSeparator1,
            this.keresestoolStripTextBox,
            this.KeresestoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rendelesIdDataGridViewTextBoxColumn,
            this.ugyfelIdDataGridViewTextBoxColumn,
            this.ugyfelNevDataGridViewTextBoxColumn,
            this.ugyfelTelefonszamDataGridViewTextBoxColumn,
            this.ugyfelEmailDataGridViewTextBoxColumn,
            this.ugyfelPontDataGridViewTextBoxColumn,
            this.jarmuIdDataGridViewTextBoxColumn,
            this.jarmuRendszamDataGridViewTextBoxColumn,
            this.jarmuFerohelyDataGridViewTextBoxColumn,
            this.rendelesDatumDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.rendelesVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 376);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztesToolStripMenuItem,
            this.torlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // szerkesztesToolStripMenuItem
            // 
            this.szerkesztesToolStripMenuItem.Name = "szerkesztesToolStripMenuItem";
            this.szerkesztesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztesToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztesToolStripMenuItem.Click += new System.EventHandler(this.szerkesztesToolStripMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.torlesToolStripMenuItem.Text = "Törlés";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.torlesToolStripMenuItem_Click);
            // 
            // mentestoolStripButton
            // 
            this.mentestoolStripButton.Image = global::JarmuKolcsonzo.Properties.Resources.saveToolStripButton;
            this.mentestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mentestoolStripButton.Name = "mentestoolStripButton";
            this.mentestoolStripButton.Size = new System.Drawing.Size(66, 22);
            this.mentestoolStripButton.Text = "Mentés";
            this.mentestoolStripButton.Click += new System.EventHandler(this.mentestoolStripButton_Click);
            // 
            // rendelesIdDataGridViewTextBoxColumn
            // 
            this.rendelesIdDataGridViewTextBoxColumn.DataPropertyName = "rendelesId";
            this.rendelesIdDataGridViewTextBoxColumn.HeaderText = "rendelesId";
            this.rendelesIdDataGridViewTextBoxColumn.Name = "rendelesIdDataGridViewTextBoxColumn";
            this.rendelesIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugyfelIdDataGridViewTextBoxColumn
            // 
            this.ugyfelIdDataGridViewTextBoxColumn.DataPropertyName = "ugyfelId";
            this.ugyfelIdDataGridViewTextBoxColumn.HeaderText = "ugyfelId";
            this.ugyfelIdDataGridViewTextBoxColumn.Name = "ugyfelIdDataGridViewTextBoxColumn";
            this.ugyfelIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ugyfelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ugyfelNevDataGridViewTextBoxColumn
            // 
            this.ugyfelNevDataGridViewTextBoxColumn.DataPropertyName = "ugyfelNev";
            this.ugyfelNevDataGridViewTextBoxColumn.HeaderText = "ugyfelNev";
            this.ugyfelNevDataGridViewTextBoxColumn.Name = "ugyfelNevDataGridViewTextBoxColumn";
            this.ugyfelNevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugyfelTelefonszamDataGridViewTextBoxColumn
            // 
            this.ugyfelTelefonszamDataGridViewTextBoxColumn.DataPropertyName = "ugyfelTelefonszam";
            this.ugyfelTelefonszamDataGridViewTextBoxColumn.HeaderText = "ugyfelTelefonszam";
            this.ugyfelTelefonszamDataGridViewTextBoxColumn.Name = "ugyfelTelefonszamDataGridViewTextBoxColumn";
            this.ugyfelTelefonszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugyfelEmailDataGridViewTextBoxColumn
            // 
            this.ugyfelEmailDataGridViewTextBoxColumn.DataPropertyName = "ugyfelEmail";
            this.ugyfelEmailDataGridViewTextBoxColumn.HeaderText = "ugyfelEmail";
            this.ugyfelEmailDataGridViewTextBoxColumn.Name = "ugyfelEmailDataGridViewTextBoxColumn";
            this.ugyfelEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugyfelPontDataGridViewTextBoxColumn
            // 
            this.ugyfelPontDataGridViewTextBoxColumn.DataPropertyName = "ugyfelPont";
            this.ugyfelPontDataGridViewTextBoxColumn.HeaderText = "ugyfelPont";
            this.ugyfelPontDataGridViewTextBoxColumn.Name = "ugyfelPontDataGridViewTextBoxColumn";
            this.ugyfelPontDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jarmuIdDataGridViewTextBoxColumn
            // 
            this.jarmuIdDataGridViewTextBoxColumn.DataPropertyName = "jarmuId";
            this.jarmuIdDataGridViewTextBoxColumn.HeaderText = "jarmuId";
            this.jarmuIdDataGridViewTextBoxColumn.Name = "jarmuIdDataGridViewTextBoxColumn";
            this.jarmuIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.jarmuIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // jarmuRendszamDataGridViewTextBoxColumn
            // 
            this.jarmuRendszamDataGridViewTextBoxColumn.DataPropertyName = "jarmuRendszam";
            this.jarmuRendszamDataGridViewTextBoxColumn.HeaderText = "jarmuRendszam";
            this.jarmuRendszamDataGridViewTextBoxColumn.Name = "jarmuRendszamDataGridViewTextBoxColumn";
            this.jarmuRendszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jarmuFerohelyDataGridViewTextBoxColumn
            // 
            this.jarmuFerohelyDataGridViewTextBoxColumn.DataPropertyName = "jarmuFerohely";
            this.jarmuFerohelyDataGridViewTextBoxColumn.HeaderText = "jarmuFerohely";
            this.jarmuFerohelyDataGridViewTextBoxColumn.Name = "jarmuFerohelyDataGridViewTextBoxColumn";
            this.jarmuFerohelyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesDatumDataGridViewTextBoxColumn
            // 
            this.rendelesDatumDataGridViewTextBoxColumn.DataPropertyName = "rendelesDatum";
            this.rendelesDatumDataGridViewTextBoxColumn.HeaderText = "rendelesDatum";
            this.rendelesDatumDataGridViewTextBoxColumn.Name = "rendelesDatumDataGridViewTextBoxColumn";
            this.rendelesDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendelesVMBindingSource
            // 
            this.rendelesVMBindingSource.DataSource = typeof(JarmuKolcsonzo.ViewModels.rendelesVM);
            // 
            // RendelesListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RendelesListaForm";
            this.Text = "RendelesListaForm";
            this.Load += new System.EventHandler(this.RendelesListaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rendelesVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OsszesLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UjtoolStripButton;
        private System.Windows.Forms.ToolStripButton TorlestoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresestoolStripTextBox;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelTelefonszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugyfelPontDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarmuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarmuRendszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarmuFerohelyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendelesDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rendelesVMBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton mentestoolStripButton;
    }
}