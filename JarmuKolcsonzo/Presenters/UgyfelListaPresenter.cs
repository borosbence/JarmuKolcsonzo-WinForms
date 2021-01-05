using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    class UgyfelListaPresenter
    {
        private IDataGridList<ugyfel> view;
        private UgyfelRepository repo;

        public UgyfelListaPresenter(IDataGridList<ugyfel> param)
        {
            view = param;
            repo = new UgyfelRepository();
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAll(
                view.page, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.TotalItems;
        }

        public void Add(ugyfel uf)
        {
            view.bindingList.Insert(0, uf);
            repo.Insert(uf);
            view.totalItems++;
        }

        public void Modify(ugyfel uf)
        {
            repo.Update(uf);
        }

        public void Remove(int index)
        {
            var uf = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (uf.id > 0)
            {
                repo.Delete(uf.id);
                view.totalItems--;
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
