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
        private int rendelesId, ugyfelId, jarmuId;
        private string[] _ugyfelList, _jarmuList;
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
            if (rendelesId > 0)
            {
                TelefonszamLabel.Text = null;
                EmailLabel.Text = null;
                TipusLabel.Text = null;
                FerohelyLabel.Text = null;
            }
        }

        public rendelesVM rendelesVM 
        {
            get
            {
                int.TryParse(NapokNumericUpDown.Value.ToString(), out int rendelesNapok);
                decimal.TryParse(ArLabel.Text, out decimal rendelesAr);
                decimal.TryParse(PontokLabel.Text, out decimal ugyfelPont);
                var rendelesVM = new rendelesVM(rendelesId,
                    dateTimePicker1.Value.Date, rendelesNapok, rendelesAr,
                    ugyfelId, NevTextBox.Text, ugyfelPont,
                    jarmuId, RendszamTextBox.Text);
                return rendelesVM;

            }
            set
            {
                rendelesId = value.rendelesId;
                dateTimePicker1.Value = value.rendelesDatum;
                NapokNumericUpDown.Value = value.rendelesNapok;
                ArLabel.Text = value.rendelesAr.ToString();

                NevTextBox.Text = value.ugyfelNev;
                PontokLabel.Text = value.ugyfelPont.ToString();
                ugyfelId = presenter.GetUgyfelId(value.ugyfelNev);

                RendszamTextBox.Text = value.jarmuRendszam;
                jarmuId = presenter.GetJarmuId(value.jarmuRendszam);
            }
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
            get
            {
                return _ugyfelList;
            }
            set
            {
                _ugyfelList = value;
                var src = new AutoCompleteStringCollection();
                src.AddRange(value);
                NevTextBox.AutoCompleteCustomSource = src;
            }
        }

        public string[] jarmuList
        {
            get
            {
                return _jarmuList;
            }
            set
            {
                _jarmuList = value;
                var src = new AutoCompleteStringCollection();
                src.AddRange(value);
                RendszamTextBox.AutoCompleteCustomSource = src;
            }
        }

        private void NevTextBox_Leave(object sender, EventArgs e)
        {
            var ugyfelnev = NevTextBox.Text;
            if (ugyfelList.Contains(ugyfelnev))
            {
                ugyfelId = presenter.GetUgyfelId(ugyfelnev);
            }
        }

        private void RendszamTextBox_Leave(object sender, EventArgs e)
        {
            var rendszam = RendszamTextBox.Text;
            if (jarmuList.Contains(rendszam))
            {
                jarmuId = presenter.GetJarmuId(rendszam);
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
