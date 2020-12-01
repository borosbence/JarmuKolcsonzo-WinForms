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
        JarmuTipusPresenter presenter;
        public JarmuTipusForm()
        {
            InitializeComponent();
            presenter = new JarmuTipusPresenter(this);
        }

        public jarmu_tipus jarmuTipus {
            get
            {
                var tipus = new jarmu_tipus(MegnevezesTextBox.Text, (int)FerohelyNumericUpDown.Value);
                if (Id > 0)
                {
                    tipus.id = Id;
                }
                return tipus;
            }
            set
            {
                MegnevezesTextBox.Text = value.megnevezes;
                FerohelyNumericUpDown.Value = value.ferohely;
                Id = value.id;
            }
        }

        public string errorMessage
        {
            get => errorProvider1.GetError(MegnevezesTextBox);
            set => errorProvider1.SetError(MegnevezesTextBox, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Save(this.jarmuTipus);
            if (string.IsNullOrEmpty(errorMessage))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
