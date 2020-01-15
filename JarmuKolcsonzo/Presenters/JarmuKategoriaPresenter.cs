using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    class JarmuKategoriaPresenter
    {
        private IDataGridList<jarmukategoria> view;
        private JarmuKategoriaRepository repo = new JarmuKategoriaRepository();
        public JarmuKategoriaPresenter(IDataGridList<jarmukategoria> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllJarmuKategoria(
                view.pageNumber, view.itemsPerPage);
            view.totalItems = repo.Count();
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
