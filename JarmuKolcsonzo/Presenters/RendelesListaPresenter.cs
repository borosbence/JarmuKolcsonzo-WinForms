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
        private RendelesRepository repo = new RendelesRepository();
        private UgyfelRepository ugyfelRepo;
        private JarmuRepository jarmuRepo;

        public RendelesListaPresenter(IDataGridList<rendelesVM> param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.bindingList = repo.GetAllRendelesVM(
                view.page, view.itemsPerPage, view.search, view.sortBy, view.ascending);
            view.totalItems = repo.Count();
        }

        public void Add(rendelesVM rendelesVM)
        {
            using (ugyfelRepo = new UgyfelRepository())
            {
                var ugyfel = ugyfelRepo.GetUgyfel(rendelesVM.ugyfelNev);
                rendelesVM.ugyfelId = ugyfel.id;
                rendelesVM.ugyfelEmail = ugyfel.email;
                rendelesVM.ugyfelTelefonszam = ugyfel.telefonszam;
                rendelesVM.ugyfelPont = ugyfel.pont;
            }
            using (jarmuRepo = new JarmuRepository())
            {
                var jarmu = jarmuRepo.GetJarmu(rendelesVM.jarmuRendszam);
                rendelesVM.jarmuId = jarmu.id;
                rendelesVM.jarmuDij = jarmu.dij;
            }

            view.bindingList.Add(rendelesVM);
            // hozzáadás ehhez a contexthez is
            repo.Insert(rendelesVM);
        }

        public void Remove(int index)
        {
            var rendeles = view.bindingList.ElementAt(index);
            view.bindingList.RemoveAt(index);
            if (rendeles.rendelesId > 0)
            {
                repo.Delete(rendeles.rendelesId);
            }
        }

        public void Modify(int index, rendelesVM rendelesVM)
        {
            using (ugyfelRepo = new UgyfelRepository())
            {
                var ugyfel = ugyfelRepo.GetUgyfel(rendelesVM.ugyfelNev);
                if (ugyfel != null)
                {
                    rendelesVM.ugyfelId = ugyfel.id;
                    // rendelesVM.ugyfelNev = ugyfel.vezeteknev + " " + ugyfel.keresztnev;
                    rendelesVM.ugyfelEmail = ugyfel.email;
                    rendelesVM.ugyfelTelefonszam = ugyfel.telefonszam;
                    rendelesVM.ugyfelPont = ugyfel.pont;
                }
                else
                {
                    throw new Exception(Resources.NemUgyfel);
                }
            }

            using (jarmuRepo = new JarmuRepository())
            {
                var jarmu = jarmuRepo.GetJarmu(rendelesVM.jarmuRendszam);
                if (jarmu != null)
                {
                    rendelesVM.jarmuId = jarmu.id;
                    rendelesVM.jarmuDij = jarmu.dij;
                }
                else
                {
                    throw new Exception(Resources.NemJarmu);
                }
            }

            if (rendelesVM.jarmuId != 0 && rendelesVM.ugyfelId != 0)
            {
                view.bindingList[index] = rendelesVM;
                repo.Update(rendelesVM);
            }
        }

        public void Save()
        {
            repo.Save();
        }
    }
}
