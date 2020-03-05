using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Presenters;
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
    public partial class JarmuKategoriaForm : Form, IJarmuKategoriaView
    {
        private int Id;
        JarmuKategoriaPresenter presenter;
        public JarmuKategoriaForm()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
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

        public string errorMessage
        {
            get => errorProvider1.GetError(textBox1);
            set => errorProvider1.SetError(textBox1, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Save(this.jarmukategoria);
            if (string.IsNullOrEmpty(errorMessage))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
