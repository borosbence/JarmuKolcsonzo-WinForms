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
    public partial class JarmuTipusForm : Form, IJarmuTipusView
    {
        private int Id;
        private JarmuTipusPresenter presenter;
        public JarmuTipusForm()
        {
            InitializeComponent();
            presenter = new JarmuTipusPresenter(this);
        }

        public string errorMessage
        {
            get => errorPMegnevezes.GetError(MegnevezesTextBox);
            set => errorPMegnevezes.SetError(MegnevezesTextBox, value);
        }

        public jarmu_tipus tipus {
            get
            {
                int ferohely = Convert.ToInt32(FerohelyNumericUpDown.Value);
                var tipus = new jarmu_tipus(MegnevezesTextBox.Text, ferohely);
                // Ha nem új elem, hanem módosítás történik
                tipus.id = Id > 0 ? Id : 0;
                return tipus;
            }
            set
            {
                MegnevezesTextBox.Text = value.megnevezes;
                FerohelyNumericUpDown.Value = value.ferohely;
                Id = value.id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
