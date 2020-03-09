using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Repositories
{
    public class RendelesRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;
        private UgyfelRepository ugyfelRepo;
        private JarmuRepository jarmuRepo;

        public BindingList<rendelesVM> GetAllRendelesVM(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.rendeles.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                int ferohely;
                int.TryParse(search, out ferohely);

                query = query.Where(x => x.ugyfel.vezeteknev.ToLower().Contains(search) ||
                                        x.ugyfel.keresztnev.ToLower().Contains(search) ||
                                        x.ugyfel.telefonszam.ToLower().Contains(search) ||
                                        x.ugyfel.email.ToLower().Contains(search) ||
                                        x.jarmu.rendszam.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "ugyfelnev":
                        query = ascending ? 
                            query.OrderBy(x => x.ugyfel.vezeteknev).ThenBy(x => x.ugyfel.keresztnev) :
                            query.OrderByDescending(x => x.ugyfel.vezeteknev).ThenBy(x => x.ugyfel.keresztnev);
                        break;
                    case "telefonszam":
                        query = ascending ? query.OrderBy(x => x.ugyfel.telefonszam) : query.OrderByDescending(x => x.ugyfel.telefonszam);
                        break;
                    case "email":
                        query = ascending ? query.OrderBy(x => x.ugyfel.email) : query.OrderByDescending(x => x.ugyfel.email);
                        break;
                    case "rendszam":
                        query = ascending ? query.OrderBy(x => x.jarmu.rendszam) : query.OrderByDescending(x => x.jarmu.rendszam);
                        break;
                    case "ferohely":
                        query = ascending ? query.OrderBy(x => x.jarmu.ferohely) : query.OrderByDescending(x => x.jarmu.ferohely);
                        break;
                    case "datum":
                        query = ascending ? query.OrderBy(x => x.datum) : query.OrderByDescending(x => x.datum);
                        break;
                }
            }


            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            var dblist = query.ToList();

            var rendelesVMList = new List<rendelesVM>();
            foreach (var rendeles in dblist)
            {
                var teljesnev = rendeles.ugyfel.vezeteknev + " " + rendeles.ugyfel.keresztnev;
                var rendelesVM = new rendelesVM(
                    rendeles.id,
                    rendeles.ugyfel_id,
                    teljesnev, rendeles.ugyfel.telefonszam,
                    rendeles.ugyfel.email, rendeles.ugyfel.pont,
                    rendeles.jarmu_id,
                    rendeles.jarmu.rendszam, rendeles.jarmu.ferohely,
                    rendeles.datum);
                rendelesVMList.Add(rendelesVM);
            }

            return new BindingList<rendelesVM>(rendelesVMList);
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(rendelesVM rendelesVM)
        {
            var rendeles = new rendeles(rendelesVM.rendelesDatum);

            using (ugyfelRepo = new UgyfelRepository())
            {
                var ugyfel = ugyfelRepo.GetUgyfelByName(rendelesVM.ugyfelNev);
                //rendeles.ugyfel = ugyfel;
                rendeles.ugyfel_id = ugyfel.id;
            }
            using(jarmuRepo = new JarmuRepository())
            {
                var jarmu = jarmuRepo.GetJarmuByLicensePlate(rendelesVM.jarmuRendszam);
                //rendeles.jarmu = jarmu;
                rendeles.jarmu_id = jarmu.Id;
            }

            db.rendeles.Add(rendeles);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var rendeles = db.rendeles.Find(id);
            db.rendeles.Remove(rendeles);
            db.SaveChanges();
        }

        public void Update(rendelesVM rendelesVM)
        {
            var rendeles = db.rendeles.Find(rendelesVM.rendelesId);
            if (rendeles != null)
            {
                rendeles.jarmu_id = rendelesVM.jarmuId;
                rendeles.ugyfel_id = rendelesVM.ugyfelId;
                rendeles.datum = rendelesVM.rendelesDatum;
                db.Entry(rendeles).State = EntityState.Modified;
            }
        }

        public bool Exists(rendelesVM rendelesVM)
        {
            return db.rendeles.Any(x => x.id == rendelesVM.rendelesId);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
