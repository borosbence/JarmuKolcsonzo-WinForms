using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.ViewInterfaces;
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
    public partial class JarmuKategoriaSzerkForm : Form, IJarmuKategoriaView
    {
        private int Id;
        public JarmuKategoriaSzerkForm()
        {
            InitializeComponent();
        }

        public jarmukategoria jarmukategoria {
            get
            {
                var jk = new jarmukategoria(textBox1.Text);
                if (Id > 0)
                {
                    jk.Id = Id;
                }
                return jk;
            }
            set
            {
                textBox1.Text = value.kategoriaNev;
                Id = value.Id;
            }
        }
    }
}
