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
    public partial class JarmuForm : Form, IJarmuView
    {
        private int formId;
        private JarmuPresenter presenter;
        public JarmuForm()
        {
            InitializeComponent();
            presenter = new JarmuPresenter(this);
            presenter.LoadData();
        }

        public jarmu jarmu
        {
            get
            {
                var kategoria = (jarmu_tipus)KategoriacomboBox1.SelectedItem;
                var kategoriaId = kategoria.id;
                var ferohely = Convert.ToInt32(DijnumericUpDown.Value);
                var fogyasztas = Convert.ToDouble(FogyasztasnumericUpDown.Value);
                var jarmu = new jarmu(
                    RendszamtextBox.Text,
                    kategoriaId,
                    ferohely,
                    ElerhetocheckBox.Checked,
                    SzervizdateTimePicker.Value);
                if (formId > 0)
                {
                    jarmu.id = formId;
                }
                //jarmu.jarmukategoria = kategoria;
                return jarmu;
            }
            set
            {
                formId = value.id;
                RendszamtextBox.Text = value.rendszam;
                KategoriacomboBox1.SelectedValue = value.tipus_id;
                DijnumericUpDown.Value = value.dij;
                ElerhetocheckBox.Checked = value.elerheto;
                SzervizdateTimePicker.Value = value.szerviz_datum.Value > new DateTime(0001, 01, 01, 0, 00, 00) ?
                    value.szerviz_datum.Value : new DateTime(1900, 1, 1);
            }
        }

        public BindingList<jarmu_tipus> jarmuTipusList
        {
            get => (BindingList<jarmu_tipus>)KategoriacomboBox1.DataSource;
            set
            {
                KategoriacomboBox1.DataSource = value;
                KategoriacomboBox1.DisplayMember = "megnevezes";
                KategoriacomboBox1.Name = "tipus_id";
                KategoriacomboBox1.ValueMember = "id";
            }
        }

        public string errorRendszam
        {
            get => errorP_Rendszam.GetError(RendszamtextBox);
            set => errorP_Rendszam.SetError(RendszamtextBox, value);
        }
        public string errorFerohely
        {
            get => errorP_Ferohely.GetError(DijnumericUpDown);
            set => errorP_Ferohely.SetError(DijnumericUpDown, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Save(this.jarmu);
            if (string.IsNullOrEmpty(errorRendszam) && string.IsNullOrEmpty(errorFerohely))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
