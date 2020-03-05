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
    class UgyfelListaPresenter
    {
        private IDataGridList<ugyfel> view;
        private UgyfelRepository repo = new UgyfelRepository();
        public UgyfelListaPresenter(IDataGridList<ugyfel> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllUgyfel(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(ugyfel uf)
        {
            view.bindingList.Add(uf);
            // hozzáadás ehhez a contexthez is
            repo.Insert(uf);
        }

        public void Remove(int index)
        {
            var uf = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (uf.id > 0)
            {
                repo.Delete(uf.id);
            }
        }

        public void Modify(ugyfel uf)
        {
            repo.Update(uf);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
