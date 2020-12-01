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
    class JarmuTipusListaPresenter
    {
        private IDataGridList<jarmu_tipus> view;
        private JarmuTipusRepository repo;
        public JarmuTipusListaPresenter(IDataGridList<jarmu_tipus> param)
        {
            view = param;
            repo = new JarmuTipusRepository();
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllJarmuTipus(
                view.pageNumber, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(jarmu_tipus tipus)
        {
            if (view.bindingList.Any(x => x.megnevezes == tipus.megnevezes))
            {
                //throw new Exception("Már létezik ilyen névvel kategória!");
            }
            else
            {
                view.bindingList.Add(tipus);
                repo.Insert(tipus);
            }
        }

        public void Remove(int index)
        {
            var tipus = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (tipus.id > 0)
            {
                repo.Delete(tipus.id);
            }
        }

        public void Modify(jarmu_tipus tipus)
        {
            repo.Update(tipus);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
