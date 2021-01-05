﻿using JarmuKolcsonzo.Presenters;
using JarmuKolcsonzo.ViewInterfaces;
using JarmuKolcsonzo.ViewModels;
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
    public partial class RendelesListaForm : Form, IDataGridList<rendelesVM>
    {
        private RendelesListaPresenter presenter;
        // Oldaltördelés
        private int sortIndex; // melyik oszlop szerint van rendezve
        private int pageCount; // összesen hány oldal van
        private int _totalItems; // összes db
        public RendelesListaForm()
        {
            InitializeComponent();
            presenter = new RendelesListaPresenter(this);
            Init();
        }

        public void Init()
        {
            page = 1;
            itemsPerPage = 20;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<rendelesVM> bindingList
        {
            get => (BindingList<rendelesVM>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public int page { get; set; }
        public int itemsPerPage { get; set; }
        public string search { get => keresestoolStripTextBox.Text; }
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            get { return _totalItems; }
            set
            {
                _totalItems = value;
                pageCount = (value - 1) / itemsPerPage + 1;
                //PageLabel.Text = page + "/" + pageCount;
                // TotalItemsLabel.Text = "Összesen: " + value;
            }
        }

        private void RendelesListaForm_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }
            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "ugyfelnev";
                    break;
                case 3:
                    sortBy = "telefonszam";
                    break;
                case 4:
                    sortBy = "email";
                    break;
                case 5:
                    sortBy = "pont";
                    break;
                case 7:
                    sortBy = "rendszam";
                    break;
                case 8:
                    sortBy = "ferohely";
                    break;
                case 9:
                    sortBy = "datum";
                    break;
                default:
                    break;
            }

            sortIndex = e.ColumnIndex;


            presenter.LoadData();
        }

        private void KeresestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void NewDGRow()
        {
            using (var szerkForm = new RendelesForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(szerkForm.rendelesVM);
                    szerkForm.Close();
                }
            }
        }
        private void EditDGRow(int index)
        {
            var rendelesVM = (rendelesVM)dataGridView1.Rows[index].DataBoundItem;
            if (rendelesVM != null)
            {
                using (var modForm = new RendelesForm())
                {
                    modForm.rendelesVM = rendelesVM;
                    DialogResult dr = modForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(index, modForm.rendelesVM);
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

        private void UjtoolStripButton_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void TorlestoolStripButton_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void szerkesztesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
            }
            EditDGRow(dataGridView1.SelectedRows[0].Index);

        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }

        private void mentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }
    }
}
