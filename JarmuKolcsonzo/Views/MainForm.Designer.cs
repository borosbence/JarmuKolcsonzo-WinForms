namespace JarmuKolcsonzo.Views
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarmuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jarmulistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfeltoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ügyféllistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendelesekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.jarmuToolStripMenuItem,
            this.ugyfeltoolStripMenuItem,
            this.rendelesToolStripMenuItem,
            this.windowsMenu,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Fájl";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Kilépés";
            // 
            // jarmuToolStripMenuItem
            // 
            this.jarmuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriakToolStripMenuItem,
            this.jarmulistaToolStripMenuItem});
            this.jarmuToolStripMenuItem.Name = "jarmuToolStripMenuItem";
            this.jarmuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.jarmuToolStripMenuItem.Text = "Jármű";
            // 
            // kategoriakToolStripMenuItem
            // 
            this.kategoriakToolStripMenuItem.Name = "kategoriakToolStripMenuItem";
            this.kategoriakToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.kategoriakToolStripMenuItem.Text = "Típusok";
            this.kategoriakToolStripMenuItem.Click += new System.EventHandler(this.tipusokToolStripMenuItem_Click);
            // 
            // jarmulistaToolStripMenuItem
            // 
            this.jarmulistaToolStripMenuItem.Name = "jarmulistaToolStripMenuItem";
            this.jarmulistaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.jarmulistaToolStripMenuItem.Text = "Járműlista";
            this.jarmulistaToolStripMenuItem.Click += new System.EventHandler(this.jarmulistaToolStripMenuItem_Click);
            // 
            // ugyfeltoolStripMenuItem
            // 
            this.ugyfeltoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ügyféllistaToolStripMenuItem});
            this.ugyfeltoolStripMenuItem.Name = "ugyfeltoolStripMenuItem";
            this.ugyfeltoolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ugyfeltoolStripMenuItem.Text = "Ügyfelek";
            // 
            // ügyféllistaToolStripMenuItem
            // 
            this.ügyféllistaToolStripMenuItem.Name = "ügyféllistaToolStripMenuItem";
            this.ügyféllistaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ügyféllistaToolStripMenuItem.Text = "Ügyféllista";
            this.ügyféllistaToolStripMenuItem.Click += new System.EventHandler(this.ugyfellistaToolStripMenuItem_Click);
            // 
            // rendelesToolStripMenuItem
            // 
            this.rendelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendelesekToolStripMenuItem});
            this.rendelesToolStripMenuItem.Name = "rendelesToolStripMenuItem";
            this.rendelesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.rendelesToolStripMenuItem.Text = "Rendelés";
            // 
            // rendelesekToolStripMenuItem
            // 
            this.rendelesekToolStripMenuItem.Name = "rendelesekToolStripMenuItem";
            this.rendelesekToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.rendelesekToolStripMenuItem.Text = "Rendelések";
            this.rendelesekToolStripMenuItem.Click += new System.EventHandler(this.rendelesekToolStripMenuItem_Click_1);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(49, 20);
            this.windowsMenu.Text = "Nézet";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Súgó";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.aboutToolStripMenuItem.Text = "Névjegy";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "JárműKölcsönző";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem jarmuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jarmulistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfeltoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ügyféllistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendelesekToolStripMenuItem;
    }
}



