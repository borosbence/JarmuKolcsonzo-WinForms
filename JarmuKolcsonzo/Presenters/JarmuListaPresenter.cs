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
            view.totalItems = repo.Count();

            using (var jkrepo = new JarmuKategoriaRepository())
            {
                view.jarmukategoriaList = jkrepo.GetAllJarmuKategoria();
            }
        }

        public void Add(jarmu jarmu)
        {
            view.bindingList.Add(jarmu);
            // hozzáadás ehhez a contexthez is
            repo.Insert(jarmu);
        }

        public void Remove(int index)
        {
            var jk = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (jk.Id > 0)
            {
                repo.Delete(jk.Id);
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
