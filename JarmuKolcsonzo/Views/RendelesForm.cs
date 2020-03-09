using JarmuKolcsonzo.Presenters;
using JarmuKolcsonzo.ViewInterfaces;
using JarmuKolcsonzo.ViewModels;
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
    public partial class RendelesForm : Form, IRendelesView
    {
        private int formId;
        private RendelesPresenter presenter;
        public RendelesForm()
        {
            InitializeComponent();
            presenter = new RendelesPresenter(this);
        }

        public rendelesVM rendelesVM 
        {
            get
            {
                var rendelesVM = new rendelesVM(
                    UgyfelNevTextBox.Text,
                    JarmuRendszamTextBox.Text,
                    RendelesDatumdateTimePicker.Value);
                if (formId > 0)
                {
                    rendelesVM.rendelesId = formId;
                }
                return rendelesVM;
            }
            set
            {
                formId = value.rendelesId;
                UgyfelNevTextBox.Text = value.ugyfelNev;
                TelefonLabel.Text = value.ugyfelTelefonszam;
                EmailLabel.Text = value.ugyfelEmail;
                PontLabel.Text = value.ugyfelPont.ToString();
                JarmuRendszamTextBox.Text = value.jarmuRendszam;
                LabelFerohely.Text = value.jarmuFerohely.ToString();
                RendelesDatumdateTimePicker.Value = rendelesVM.rendelesDatum;
            }
        }
        public string errorUgyfelNev
        {
            get => errorP_Nev.GetError(UgyfelNevTextBox);
            set => errorP_Nev.SetError(UgyfelNevTextBox, value);
        }
        public string errorJarmuRendszam 
        {
            get => errorP_Rendszam.GetError(JarmuRendszamTextBox);
            set => errorP_Rendszam.SetError(JarmuRendszamTextBox, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Save(this.rendelesVM);
            if (string.IsNullOrEmpty(errorJarmuRendszam) &&
                string.IsNullOrEmpty(errorUgyfelNev))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
