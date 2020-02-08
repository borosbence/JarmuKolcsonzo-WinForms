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
    public partial class JarmuSzerkForm : Form, IJarmuView
    {
        private int Id;
        private JarmuPresenter presenter;
        public JarmuSzerkForm()
        {
            InitializeComponent();
            presenter = new JarmuPresenter(this);
            presenter.LoadData();
        }

        public jarmu jarmu 
        {
            get
            {
                var kategoria = (jarmukategoria)KategoriacomboBox1.SelectedItem;
                var kategoriaId = kategoria.Id;
                var ferohely = Convert.ToInt32(FerohelynumericUpDown.Value);
                var fogyasztas = Convert.ToDouble(FogyasztasnumericUpDown.Value);
                var jarmu = new jarmu(
                    RendszamtextBox.Text,
                    kategoriaId,
                    TipustextBox.Text,
                    ModelltextBox.Text,
                    ferohely,
                    fogyasztas,
                    ElerhetocheckBox.Checked,
                    SzervizcheckBox.Checked,
                    SzervizdateTimePicker.Value,
                    MuszakidateTimePicker.Value,
                    BeszerzesdateTimePicker.Value);
                if (Id > 0)
                {
                    jarmu.Id = Id;
                }
                jarmu.jarmukategoria = kategoria;
                return jarmu;
            }
            set
            {
                Id = value.Id;
                RendszamtextBox.Text = value.rendszam;
                KategoriacomboBox1.SelectedValue = value.kategoriaId;
                TipustextBox.Text = value.tipus;
                ModelltextBox.Text = value.modell;
                FerohelynumericUpDown.Value = value.ferohely.Value;
                FogyasztasnumericUpDown.Value = Convert.ToDecimal(value.fogyasztas.Value);
                ElerhetocheckBox.Checked = value.elerheto;
                SzervizcheckBox.Checked = value.szervizben;
                SzervizdateTimePicker.Value = value.szervizDatum.Value > new DateTime(0001, 01, 01, 0, 00, 00) ?
                    value.szervizDatum.Value : new DateTime(1900, 1, 1);
                MuszakidateTimePicker.Value = value.muszakiDatum.Value > new DateTime(0001, 01, 01, 0, 00, 00) ?
                    value.szervizDatum.Value : new DateTime(1900, 1, 1);
                BeszerzesdateTimePicker.Value = value.beszerzesDatum.Value > new DateTime(0001, 01, 01, 0, 00, 00) ?
                    value.szervizDatum.Value : new DateTime(1900, 1, 1);
            }
        }

        public BindingList<jarmukategoria> jarmukategoriaList
        {
            get => (BindingList<jarmukategoria>)KategoriacomboBox1.DataSource;
            set
            {
                value.Insert(0, new jarmukategoria() { Id = 0 });
                KategoriacomboBox1.DataSource = value;
                KategoriacomboBox1.DisplayMember = "kategoriaNev";
                KategoriacomboBox1.Name = "kategoriaId";
                KategoriacomboBox1.ValueMember = "Id";
            }
        }
    }
}
