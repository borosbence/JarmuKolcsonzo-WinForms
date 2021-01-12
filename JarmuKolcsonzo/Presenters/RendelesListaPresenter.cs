using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Properties;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using JarmuKolcsonzo.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    class RendelesListaPresenter
    {
        private IDataGridList<rendelesVM> view;
        private RendelesRepository repo;
        public RendelesListaPresenter(IDataGridList<rendelesVM> param)
        {
            view = param;
            repo = new RendelesRepository();
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAll(
                view.page, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.TotalItems;
        }

        public void Add(rendelesVM rendelesVM)
        {
            view.bindingList.Insert(0, rendelesVM);
            repo.Insert(rendelesVM);
            view.totalItems++;
            repo.Save();
        }

        public void Modify(int index, rendelesVM rendelesVM)
        {
            if (rendelesVM.jarmuId != 0 && rendelesVM.ugyfelId != 0)
            {
                view.bindingList[index] = rendelesVM;
                repo.Update(rendelesVM);
            }
            repo.Save();
        }

        public void Remove(int index)
        {
            var rendeles = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (rendeles.rendelesId > 0)
            {
                repo.Delete(rendeles.rendelesId);
                view.totalItems--;
            }
            repo.Save();
        }
    }
}
