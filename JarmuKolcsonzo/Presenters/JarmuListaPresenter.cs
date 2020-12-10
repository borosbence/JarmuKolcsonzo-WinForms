﻿using JarmuKolcsonzo.Models;
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
        private JarmuRepository repo = new JarmuRepository();
        // private JarmuKategoriaRepository jkrepo = new JarmuKategoriaRepository();

        public JarmuListaPresenter(IJarmuListaView param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllJarmu(
                    view.pageNumber, view.itemsPerPage, view.search,view.sortBy,view.ascending);
            //view.jarmukategoriaList = jkrepo.GetAllJarmuKategoria();
            view.totalItems = repo.TotalItems;

            using (var jkrepo = new JarmuTipusRepository())
            {
                view.jarmuTipusList = jkrepo.GetAllJarmuTipus(itemsPerPage: int.MaxValue);
            }
        }

        public void Add(jarmu jarmu)
        {
            if (repo.ExistsRendszam(jarmu.rendszam))
            {
                throw new Exception("Már létezik ilyen rendszámmal jármű!");
                return;
            }
            view.bindingList.Add(jarmu);
            repo.Insert(jarmu);
        }

        public void Remove(int index)
        {
            var jk = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (jk.id > 0)
            {
                repo.Delete(jk.id);
            }
        }

        public void Modify(jarmu jarmu)
        {
            repo.Update(jarmu);
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
