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
        private int sortIndex;
        // Oldaltördelés
        private int pageCount;
        private int _totalItems;
        // Combobox létrehozása
        private DataGridViewComboBoxColumn tipusCol;

        public JarmuListaForm()
        {
            InitializeComponent();
            presenter = new JarmuListaPresenter(this);
            tipusCol = new DataGridViewComboBoxColumn();
            Init();
        }

        public void Init()
        {
            page = 1;
            itemsPerPage = 20;
            sortIndex = 0;
            ascending = true;

            // Típus combobox feltöltése
            tipusCol.DataPropertyName = "tipus_id";
            tipusCol.DisplayMember = "megnevezes";
            tipusCol.ValueMember = "id";
            tipusCol.Name = "Típus";
            tipusCol.HeaderText = "Típus";

            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Insert(1, tipusCol);
        }

        public BindingList<jarmu> bindingList
        {
            get => (BindingList<jarmu>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public BindingList<jarmu_tipus> tipusList
        {
            get => (BindingList<jarmu_tipus>)tipusCol.DataSource;
            set => tipusCol.DataSource = value;
        }

        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public string search => keresestoolStripTextBox.Text;
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems 
        {
            get
            {
                return _totalItems;
            }
            set
            {
                _totalItems = value;
                pageCount = (value - 1) / itemsPerPage + 1;
                PageLabel.Text = page + "/" + pageCount;
                TotalItemsLabel.Text = "Összesen: " + value;
            }
        }

        private void JarmuLista_Load(object sender, EventArgs e)
        {
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
                    sortBy = "szerviz_datum";
                    break;
                default:
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (page != 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (page != pageCount)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            page = pageCount;
            presenter.LoadData();
        }

        private void UjtoolStripButton_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void MentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void SzerkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lekérdezi a kijelölt cella sor helyértékét
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                // Törli a kijelölést a DGV
                dataGridView1.ClearSelection();
                // Az egész sort jelölje ki a cella helyett
                dataGridView1.Rows[sorIndex].Selected = true;
                EditDGRow(sorIndex);
            }
        }

        private void TorlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
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
            var jarmu = (jarmu)dataGridView1.Rows[index].DataBoundItem;
            using (var szerkForm = new JarmuForm())
            {
                szerkForm.jarmu = jarmu;
                DialogResult dr = szerkForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    presenter.Modify(szerkForm.jarmu);
                    szerkForm.Close();
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
    }
}
