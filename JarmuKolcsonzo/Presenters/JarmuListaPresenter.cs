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
    class JarmuListaPresenter
    {
        private IJarmuListaView view;
        private JarmuRepository repo;
        private JarmuTipusRepository tipusrepo;

        public JarmuListaPresenter(IJarmuListaView param)
        {
            view = param;
            repo = new JarmuRepository();
            tipusrepo = new JarmuTipusRepository();
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAll(
                    view.page, view.itemsPerPage, view.search,view.sortBy,view.ascending);
            view.totalItems = repo.TotalItems;
            view.tipusList = tipusrepo.GetAll(itemsPerPage: int.MaxValue);
        }

        public void Add(jarmu jarmu)
        {
            view.bindingList.Insert(0, jarmu);
            repo.Insert(jarmu);
            view.totalItems++;
        }

        public void Modify(jarmu jarmu)
        {
            repo.Update(jarmu);
        }

        public void Remove(int index)
        {
            var jarmu = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (jarmu.id > 0)
            {
                repo.Delete(jarmu.id);
                view.totalItems--;
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
