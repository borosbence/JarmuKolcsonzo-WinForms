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
        private int Id;
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
                var tipusId = Convert.ToInt32(TipusComboBox.SelectedValue);
                var dij = Convert.ToInt32(DijNumericUpDown.Value);
                var jarmu = new jarmu(
                    RendszamtextBox.Text,
                    tipusId,
                    dij,
                    ElerhetocheckBox.Checked,
                    SzervizdateTimePicker.Value.Date);
                jarmu.id = Id > 0 ? Id : 0;
                return jarmu;
            }
            set
            {
                Id = value.id;
                RendszamtextBox.Text = value.rendszam;
                TipusComboBox.SelectedValue = value.tipus_id;
                DijNumericUpDown.Value = value.dij;
                ElerhetocheckBox.Checked = value.elerheto;
                SzervizdateTimePicker.Value = value.szerviz_datum.Value > new DateTime(0001, 01, 01) ?
                    value.szerviz_datum.Value : new DateTime(1900, 1, 1);
            }
        }

        public BindingList<jarmu_tipus> tipusList
        {
            get => (BindingList<jarmu_tipus>)TipusComboBox.DataSource;
            set
            {
                TipusComboBox.DataSource = value;
                TipusComboBox.DisplayMember = "megnevezes";
                TipusComboBox.ValueMember = "id";
                TipusComboBox.Name = "Típus";
            }
        }

        public string errorRendszam
        {
            get => errorP_Rendszam.GetError(RendszamtextBox);
            set => errorP_Rendszam.SetError(RendszamtextBox, value);
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
