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
    public partial class UgyfelForm : Form, IUgyfelView
    {
        private int Id;
        private UgyfelPresenter presenter;
        public UgyfelForm()
        {
            InitializeComponent();
            presenter = new UgyfelPresenter(this);
        }

        public ugyfel ugyfel 
        {
            get
            {
                var irszam = Convert.ToInt32(IrszamnumericUpDown.Value);
                var pont = Convert.ToDecimal(PontnumericUpDown.Value);
                var ugyfel = new ugyfel(
                    VnevtextBox.Text,
                    KnevtextBox.Text,
                    VarostextBox.Text,
                    irszam,
                    CimtextBox.Text,
                    TelefonMaskedTextBox.Text,
                    EmailtextBox.Text,
                    pont);
                if (Id > 0)
                {
                    ugyfel.id = Id;
                }
                return ugyfel;
            }
            set
            {
                Id = value.id;
                VnevtextBox.Text = value.vezeteknev;
                KnevtextBox.Text = value.keresztnev;
                VarostextBox.Text = value.varos;
                IrszamnumericUpDown.Value = value.iranyitoszam;
                CimtextBox.Text = value.cim;
                TelefonMaskedTextBox.Text = value.telefonszam;
                EmailtextBox.Text = value.email;
                PontnumericUpDown.Value = value.pont;
            }
        }
        public string errorVnev 
        {
            get => errorP_Vnev.GetError(VnevtextBox);
            set => errorP_Vnev.SetError(VnevtextBox, value);
        }
        public string errorKnev 
        {
            get => errorP_Knev.GetError(KnevtextBox);
            set => errorP_Knev.SetError(KnevtextBox, value);
        }
        public string errorVaros
        {
            get => errorP_Knev.GetError(VarostextBox);
            set => errorP_Knev.SetError(VarostextBox, value);
        }
        public string errorIrszam
        {
            get => errorP_Knev.GetError(IrszamnumericUpDown);
            set => errorP_Knev.SetError(IrszamnumericUpDown, value);
        }
        public string errorCim
        {
            get => errorP_Knev.GetError(CimtextBox);
            set => errorP_Knev.SetError(CimtextBox, value);
        }
        public string errorTelefon
        {
            get => errorP_Knev.GetError(TelefonMaskedTextBox);
            set => errorP_Knev.SetError(TelefonMaskedTextBox, value);
        }
        public string errorEmail
        {
            get => errorP_Knev.GetError(EmailtextBox);
            set => errorP_Knev.SetError(EmailtextBox, value);
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
