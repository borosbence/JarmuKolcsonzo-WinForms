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
    public partial class UgyfelListaForm : Form, IDataGridList<ugyfel>
    {
        private UgyfelListaPresenter presenter;
        private int sortIndex;
        private int pageCount;
        private int _totalItems;

        public UgyfelListaForm()
        {
            InitializeComponent();
            presenter = new UgyfelListaPresenter(this);
            Init();
        }

        public void Init()
        {
            page = 1;
            itemsPerPage = 20;
            sortBy = "vezeteknev";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<ugyfel> bindingList
        {
            get => (BindingList<ugyfel>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public string search { get => keresestoolStripTextBox.Text; }
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

        private void UgyfelekForm_Load(object sender, EventArgs e)
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
                    sortBy = "vezeteknev";
                    break;
                case 1:
                    sortBy = "keresztnev";
                    break;
                case 2:
                    sortBy = "varos";
                    break;
                case 3:
                    sortBy = "iranyitoszam";
                    break;
                case 4:
                    sortBy = "cim";
                    break;
                case 5:
                    sortBy = "telefonszam";
                    break;
                case 6:
                    sortBy = "email";
                    break;
                case 7:
                    sortBy = "pont";
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

        private void mentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void szerkesztesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void NewDGRow()
        {
            using (var szerkForm = new UgyfelForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(szerkForm.ugyfel);
                    szerkForm.Close();
                }
            }
        }

        private void EditDGRow(int index)
        {
            var uf = (ugyfel)dataGridView1.Rows[index].DataBoundItem;
            using (var szerkForm = new UgyfelForm())
            {
                szerkForm.ugyfel = uf;
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Modify(szerkForm.ugyfel);
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
