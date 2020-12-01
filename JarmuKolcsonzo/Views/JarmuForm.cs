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
                var tipus = (jarmu_tipus)TipuscomboBox1.SelectedItem;
                var tipusId = tipus.id;
                var dij = Convert.ToInt32(DijmaskedTextBox.Text);
                var jarmu = new jarmu(
                    RendszamtextBox.Text,
                    tipusId,
                    dij,
                    ElerhetocheckBox.Checked,
                    SzervizdateTimePicker.Value);
                if (formId > 0)
                {
                    jarmu.id = formId;
                }
                return jarmu;
            }
            set
            {
                formId = value.id;
                RendszamtextBox.Text = value.rendszam;
                TipuscomboBox1.SelectedValue = value.tipus_id;
                DijmaskedTextBox.Text = value.dij.ToString();
                ElerhetocheckBox.Checked = value.elerheto;
                SzervizdateTimePicker.Value = value.szerviz_datum.Value > new DateTime(0001, 01, 01, 0, 00, 00) ?
                    value.szerviz_datum.Value : new DateTime(1900, 1, 1);
            }
        }

        public BindingList<jarmu_tipus> jarmuTipusList
        {
            get => (BindingList<jarmu_tipus>)TipuscomboBox1.DataSource;
            set
            {
                TipuscomboBox1.DataSource = value;
                TipuscomboBox1.DisplayMember = "megnevezes";
                TipuscomboBox1.Name = "tipus_id";
                TipuscomboBox1.ValueMember = "id";
            }
        }

        public string errorRendszam
        {
            get => errorP_Rendszam.GetError(RendszamtextBox);
            set => errorP_Rendszam.SetError(RendszamtextBox, value);
        }
        public string errorDij
        {
            get => errorP_Ferohely.GetError(DijmaskedTextBox);
            set => errorP_Ferohely.SetError(DijmaskedTextBox, value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Save(this.jarmu);
            if (string.IsNullOrEmpty(errorRendszam) && string.IsNullOrEmpty(errorDij))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
