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
    public partial class JarmuKategoria : Form, IDataGridList<jarmukategoria>
    {
        private JarmuKategoriaPresenter presenter;
        // Oldaltördelés
        private int perPage = 1;
        private int page = 1;
        private int total = 0;

        public JarmuKategoria()
        {
            InitializeComponent();
            presenter = new JarmuKategoriaPresenter(this);
        }

        public BindingList<jarmukategoria> bindingList 
        {
            get => (BindingList<jarmukategoria>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value; 
        }

        public int pageNumber => page;
        public int itemsPerPage => perPage;
        public string search => keresestoolStripTextBox.Text;
        public string sortBy => throw new NotImplementedException();
        public bool ascending => throw new NotImplementedException();
        public int totalItems
        {
            set
            {
                total = value;
                label1.Text = page.ToString() + "/" + total.ToString();
            }
        }

        private void JarmuKategoria_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void mentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
            // presenter.LoadData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var maxPage = total / perPage;
            if (page < maxPage)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            page = total / perPage;
            presenter.LoadData();
        }
    }
}
