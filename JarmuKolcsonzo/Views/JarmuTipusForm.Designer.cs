namespace JarmuKolcsonzo.Views
{
    partial class JarmuTipusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MegnevezesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorPMegnevezes = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.FerohelyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorPMegnevezes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerohelyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Megnevezés";
            // 
            // MegnevezesTextBox
            // 
            this.MegnevezesTextBox.Location = new System.Drawing.Point(43, 35);
            this.MegnevezesTextBox.Name = "MegnevezesTextBox";
            this.MegnevezesTextBox.Size = new System.Drawing.Size(250, 20);
            this.MegnevezesTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(43, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mégse";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorPMegnevezes
            // 
            this.errorPMegnevezes.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Férőhely";
            // 
            // FerohelyNumericUpDown
            // 
            this.FerohelyNumericUpDown.Location = new System.Drawing.Point(43, 96);
            this.FerohelyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FerohelyNumericUpDown.Name = "FerohelyNumericUpDown";
            this.FerohelyNumericUpDown.Size = new System.Drawing.Size(250, 20);
            this.FerohelyNumericUpDown.TabIndex = 6;
            this.FerohelyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JarmuTipusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 186);
            this.Controls.Add(this.FerohelyNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MegnevezesTextBox);
            this.Controls.Add(this.label1);
            this.Name = "JarmuTipusForm";
            this.Text = "Jármű típus";
            ((System.ComponentModel.ISupportInitialize)(this.errorPMegnevezes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FerohelyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MegnevezesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorPMegnevezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown FerohelyNumericUpDown;
    }
}