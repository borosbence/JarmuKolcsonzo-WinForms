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
            this.errorP_Ferohely = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipuscomboBox1 = new System.Windows.Forms.ComboBox();
            this.SzervizdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ElerhetocheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DijmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RendszamtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Rendszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Ferohely)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(271, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorP_Rendszam
            // 
            this.errorP_Rendszam.ContainerControl = this;
            // 
            // errorP_Ferohely
            // 
            this.errorP_Ferohely.ContainerControl = this;
            // 
            // TipuscomboBox1
            // 
            this.TipuscomboBox1.FormattingEnabled = true;
            this.TipuscomboBox1.Location = new System.Drawing.Point(175, 40);
            this.TipuscomboBox1.Name = "TipuscomboBox1";
            this.TipuscomboBox1.Size = new System.Drawing.Size(200, 21);
            this.TipuscomboBox1.TabIndex = 6;
            // 
            // SzervizdateTimePicker
            // 
            this.SzervizdateTimePicker.Location = new System.Drawing.Point(175, 151);
            this.SzervizdateTimePicker.Name = "SzervizdateTimePicker";
            this.SzervizdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.SzervizdateTimePicker.TabIndex = 3;
            // 
            // ElerhetocheckBox
            // 
            this.ElerhetocheckBox.AutoSize = true;
            this.ElerhetocheckBox.Location = new System.Drawing.Point(175, 114);
            this.ElerhetocheckBox.Name = "ElerhetocheckBox";
            this.ElerhetocheckBox.Size = new System.Drawing.Size(15, 14);
            this.ElerhetocheckBox.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.TipuscomboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ElerhetocheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SzervizdateTimePicker, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DijmaskedTextBox, 1, 2);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Díj";
            // 
            // DijmaskedTextBox
            // 
            this.DijmaskedTextBox.Location = new System.Drawing.Point(175, 77);
            this.DijmaskedTextBox.Mask = "00 000 Ft";
            this.DijmaskedTextBox.Name = "DijmaskedTextBox";
            this.DijmaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.DijmaskedTextBox.TabIndex = 2;
            // 
            // RendszamtextBox
            // 
            this.RendszamtextBox.Location = new System.Drawing.Point(175, 3);
            this.RendszamtextBox.MaxLength = 6;
            this.RendszamtextBox.Name = "RendszamtextBox";
            this.RendszamtextBox.Size = new System.Drawing.Size(200, 20);
            this.RendszamtextBox.TabIndex = 1;
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
            this.Text = "JarmuSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Rendszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP_Ferohely)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorP_Rendszam;
        private System.Windows.Forms.ErrorProvider errorP_Ferohely;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TipuscomboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ElerhetocheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker SzervizdateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DijmaskedTextBox;
        private System.Windows.Forms.TextBox RendszamtextBox;
    }
}