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
    public partial class UjJarmuForm : Form, IJarmuView
    {
        private UjJarmuPresenter presenter;
        public UjJarmuForm()
        {
            InitializeComponent();
            presenter = new UjJarmuPresenter(this);
        }

        public jarmu jarmu 
        {
            get
            {
                var kategoriaId = (jarmukategoria)KategoriacomboBox1.SelectedItem;
                var ferohely = Convert.ToInt32(FerohelynumericUpDown.Value);
                var fogyasztas = Convert.ToDouble(FogyasztasnumericUpDown.Value);
                return new jarmu(
                    RendszamtextBox.Text,
                    kategoriaId.Id,
                    TipustextBox.Text,
                    ModelltextBox.Text,
                    ferohely,
                    fogyasztas,
                    ElerhetocheckBox.Checked,
                    SzervizcheckBox.Checked,
                    SzervizdateTimePicker.Value,
                    MuszakidateTimePicker.Value,
                    BeszerzesdateTimePicker.Value);
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

        private void UjJarmuForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }
    }
}
