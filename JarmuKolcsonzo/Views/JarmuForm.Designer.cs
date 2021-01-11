namespace JarmuKolcsonzo.Views
{
    partial class JarmuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorP_Rendszam = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipusComboBox = new System.Windows.Forms.ComboBox();
            this.SzervizdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ElerhetocheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RendszamtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DijNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Rendszam)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DijNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(22, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorP_Rendszam
            // 
            this.errorP_Rendszam.ContainerControl = this;
            // 
            // TipusComboBox
            // 
            this.TipusComboBox.FormattingEnabled = true;
            this.TipusComboBox.Location = new System.Drawing.Point(175, 40);
            this.TipusComboBox.Name = "TipusComboBox";
            this.TipusComboBox.Size = new System.Drawing.Size(200, 21);
            this.TipusComboBox.TabIndex = 2;
            // 
            // SzervizdateTimePicker
            // 
            this.SzervizdateTimePicker.Location = new System.Drawing.Point(175, 151);
            this.SzervizdateTimePicker.Name = "SzervizdateTimePicker";
            this.SzervizdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.SzervizdateTimePicker.TabIndex = 5;
            // 
            // ElerhetocheckBox
            // 
            this.ElerhetocheckBox.AutoSize = true;
            this.ElerhetocheckBox.Location = new System.Drawing.Point(175, 114);
            this.ElerhetocheckBox.Name = "ElerhetocheckBox";
            this.ElerhetocheckBox.Size = new System.Drawing.Size(15, 14);
            this.ElerhetocheckBox.TabIndex = 4;
            this.ElerhetocheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Szervíz Dátum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Elérhető";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Típus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RendszamtextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TipusComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ElerhetocheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SzervizdateTimePicker, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DijNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RendszamtextBox
            // 
            this.RendszamtextBox.Location = new System.Drawing.Point(175, 3);
            this.RendszamtextBox.MaxLength = 7;
            this.RendszamtextBox.Name = "RendszamtextBox";
            this.RendszamtextBox.Size = new System.Drawing.Size(200, 20);
            this.RendszamtextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Díj";
            // 
            // DijNumericUpDown
            // 
            this.DijNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DijNumericUpDown.Location = new System.Drawing.Point(175, 77);
            this.DijNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DijNumericUpDown.Name = "DijNumericUpDown";
            this.DijNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.DijNumericUpDown.TabIndex = 3;
            this.DijNumericUpDown.ThousandsSeparator = true;
            // 
            // JarmuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JarmuForm";
            this.Text = "Jármű";
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Rendszam)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DijNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorP_Rendszam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipusComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ElerhetocheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker SzervizdateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RendszamtextBox;
        private System.Windows.Forms.NumericUpDown DijNumericUpDown;
    }
}