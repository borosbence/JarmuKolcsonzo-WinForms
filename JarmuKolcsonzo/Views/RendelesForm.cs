using JarmuKolcsonzo.Models;
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
        private int Id;
        private RendelesPresenter presenter;

        public RendelesForm()
        {
            InitializeComponent();
            presenter = new RendelesPresenter(this);
            presenter.LoadData();
            Init();
        }

        private void Init()
        {
            if (Id > 0)
            {
                TelefonszamLabel.Text = null;
                EmailLabel.Text = null;
                TipusLabel.Text = null;
                FerohelyLabel.Text = null;
            }
        }

        public rendelesVM rendelesVM 
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public string errorUgyfelNev {  set => errorPUgyfel.SetError(NevTextBox,value); }
        public string errorJarmuRendszam { set => errorPJarmu.SetError(RendszamTextBox, value); }
        public string ugyfelTelefonszam { set => TelefonszamLabel.Text = value; }
        public string ugyfelEmail { set => EmailLabel.Text = value; }
        public string jarmuTipus { set => TipusLabel.Text = value; }
        public int jarmuFerohely { set => FerohelyLabel.Text = value.ToString(); }
        public int jarmuDij { set => DijLabel.Text = value.ToString(); }

        public string[] ugyfelList
        {
            set
            {
                var src = new AutoCompleteStringCollection();
                src.AddRange(value);
                NevTextBox.AutoCompleteCustomSource = src;
            }
        }

        public string[] jarmuList
        {
            set
            {
                var src = new AutoCompleteStringCollection();
                src.AddRange(value);
                RendszamTextBox.AutoCompleteCustomSource = src;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (presenter.ValidateData())
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
