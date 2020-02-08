using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Presenters;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarmuKolcsonzo.Views
{
    public partial class JarmuListaForm : Form, IJarmuListaView
    {
        private JarmuListaPresenter presenter;
        // Combobox létrehozása
        private DataGridViewComboBoxColumn jkCol;
        // Oldaltördelés
        private int pageCount;
        private int sortIndex;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            jkCol = new DataGridViewComboBoxColumn();
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<jarmu> bindingList
        {
            get => (BindingList<jarmu>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public BindingList<jarmukategoria> jarmukategoriaList
        {
            get => (BindingList<jarmukategoria>)jkCol.DataSource;
            set
            {
                value.Insert(0, new jarmukategoria() { Id = 0 });
                jkCol.DataSource = value;
            }
        }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search => keresestoolStripTextBox.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems 
        {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                label1.Text = pageNumber.ToString() + "/" + pageCount.ToString();
            }
        }

        private void JarmuLista_Load(object sender, EventArgs e)
        {
            presenter.LoadData();

            // Kategória colbox feltöltése
            jkCol.DataPropertyName = "kategoriaId";
            jkCol.DisplayMember = "kategoriaNev";
            jkCol.Name = "kategoriaId";
            jkCol.HeaderText = "Kategória";
            jkCol.ValueMember = "Id";
            //jkCol.ValueType = typeof(jarmukategoria);

            dataGridView1.Columns.RemoveAt(2);
            dataGridView1.Columns.Insert(2, jkCol);
        }

        private void mentestoolStripButton1_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (pageNumber != 1)
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber != pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void KategoriaFrissittoolStripButton_Click(object sender, EventArgs e)
        {
            JarmuLista_Load(null, null);
        }

        private void KeresestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }
            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "rendszam";
                    break;
                case 2:
                    sortBy = "kategoriaId";
                    break;
                case 4:
                    sortBy = "tipus";
                    break;
                case 5:
                    sortBy = "modell";
                    break;
                default:
                    sortBy = "Id";
                    break;
            }

            sortIndex = e.ColumnIndex;

            presenter.LoadData();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null && e.ColumnIndex == 6)
            {
                MessageBox.Show("Kérem az egész szám után vesszővel válassza el a tört értéket.", "Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(e.Exception.Message);
            }
            
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void UjtoolStripButton_Click(object sender, EventArgs e)
        {
            var addForm = new JarmuSzerkForm();
            DialogResult dr = addForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                addForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                presenter.Add(addForm.jarmu);
                addForm.Close();
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var jk = (jarmu)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                if (jk != null)
                {
                    var modForm = new JarmuSzerkForm();
                    modForm.jarmu = jk;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        modForm.Close();
                    }
                    else if (dr == DialogResult.OK)
                    {
                        presenter.Modify(modForm.jarmu);
                        modForm.Close();
                    }
                }
            }
        }
    }
}
