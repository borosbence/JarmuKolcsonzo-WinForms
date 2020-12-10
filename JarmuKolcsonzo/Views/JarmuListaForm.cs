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
        private DataGridViewComboBoxColumn tipusCol;
        // Oldaltördelés
        private int pageCount;
        private int sortIndex;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            tipusCol = new DataGridViewComboBoxColumn();
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<jarmu> bindingList
        {
            get => (BindingList<jarmu>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public BindingList<jarmu_tipus> jarmuTipusList
        {
            get => (BindingList<jarmu_tipus>)tipusCol.DataSource;
            set
            {
                tipusCol.DataSource = value;
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
            tipusCol.DataPropertyName = "tipus_id";
            tipusCol.DisplayMember = "megnevezes";
            tipusCol.Name = "Típus";
            tipusCol.HeaderText = "Típus";
            tipusCol.ValueMember = "id";
            //tipusCol.ValueType = typeof(jarmukategoria);

            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Insert(1, tipusCol);
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
                case 0:
                    sortBy = "rendszam";
                    break;
                case 1:
                    sortBy = "tipus";
                    break;
                case 2:
                    sortBy = "dij";
                    break;
                case 3:
                    sortBy = "elerheto";
                    break;
                case 4:
                    sortBy = "szervizDatum";
                    break;
                default:
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

        private void NewDGRow()
        {
            using (var szerkForm = new JarmuForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(szerkForm.jarmu);
                    szerkForm.Close();
                }
            }
        }
        private void EditDGRow(int index)
        {
            var jk = (jarmu)dataGridView1.Rows[index].DataBoundItem;

            if (jk != null)
            {
                using (var modForm = new JarmuForm())
                {
                    modForm.jarmu = jk;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(modForm.jarmu);
                        modForm.Close();
                    }
                }
            }
        }
        private void DelDGRow()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void UjtoolStripButton_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void SzerkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
            }
            EditDGRow(dataGridView1.SelectedRows[0].Index);
        }

        private void TorlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void refKatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JarmuLista_Load(null, null);
        }
    }
}
