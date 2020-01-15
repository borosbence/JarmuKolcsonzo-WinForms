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
        private JarmuListaRepository repo = new JarmuListaRepository();
        private JarmuKategoriaRepository jkrepo = new JarmuKategoriaRepository();

        public JarmuListaPresenter(IJarmuListaView param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllJarmu(
                view.pageNumber, view.itemsPerPage);
            view.jarmukategoriaList = jkrepo.GetAllJarmuKategoria();

            view.totalItems = repo.Count();
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
