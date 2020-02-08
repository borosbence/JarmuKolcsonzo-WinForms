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
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(jarmukategoria jk)
        {
            view.bindingList.Add(jk);
            repo.Insert(jk);
        }

        public void Remove(int index)
        {
            var jk = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            repo.Delete(jk);
        }

        public void Modify(jarmukategoria jk)
        {
            repo.Update(jk);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
