using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarmuKolcsonzo.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tipusokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JarmuTipusListaForm childForm = new JarmuTipusListaForm();
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void jarmulistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new JarmuListaForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ugyfellistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new UgyfelListaForm();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void rendelesekToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form childForm = new RendelesListaForm();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
