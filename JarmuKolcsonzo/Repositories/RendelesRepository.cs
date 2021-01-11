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

        public BindingList<rendelesVM> GetAll(
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
                int.TryParse(search, out int ar);
                DateTime.TryParse(search, out DateTime datum);

                query = query.Where(x => 
                    x.ugyfel.vezeteknev.Contains(search) ||
                    x.ugyfel.keresztnev.Contains(search) ||
                    x.jarmu.rendszam.Contains(search) ||
                    x.ar.Equals(ar) ||
                    x.datum.Equals(datum));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "id":
                        query = ascending ? query.OrderBy(x => x.id) : query.OrderByDescending(x => x.id);
                        break;
                    case "ugyfelnev":
                        query = ascending ? 
                            query.OrderBy(x => x.ugyfel.vezeteknev).ThenBy(x => x.ugyfel.keresztnev) :
                            query.OrderByDescending(x => x.ugyfel.vezeteknev).ThenBy(x => x.ugyfel.keresztnev);
                        break;
                    case "pont":
                        query = ascending ? query.OrderBy(x => x.ugyfel.pont) : query.OrderByDescending(x => x.ugyfel.pont);
                        break;
                    case "rendszam":
                        query = ascending ? query.OrderBy(x => x.jarmu.rendszam) : query.OrderByDescending(x => x.jarmu.rendszam);
                        break;
                    case "datum":
                        query = ascending ? query.OrderBy(x => x.datum) : query.OrderByDescending(x => x.datum);
                        break;
                    case "ar":
                        query = ascending ? query.OrderBy(x => x.jarmu.dij) : query.OrderByDescending(x => x.jarmu.dij);
                        break;
                    default:
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
                var rendelesVM = new rendelesVM(
                    rendeles.id, rendeles.datum, 
                    rendeles.napok_szama, rendeles.ar,
                    rendeles.ugyfel_id,
                    rendeles.ugyfel.TeljesNev, rendeles.ugyfel.pont,
                    rendeles.jarmu_id, rendeles.jarmu.rendszam);
                rendelesVMList.Add(rendelesVM);
            }

            return new BindingList<rendelesVM>(rendelesVMList);
        }

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public void Insert(rendelesVM rendelesVM)
        {
            var rendeles = new rendeles(
                rendelesVM.ugyfelId,rendelesVM.jarmuId,
                rendelesVM.rendelesDatum,rendelesVM.rendelesNapok,
                rendelesVM.rendelesAr);
            db.rendeles.Add(rendeles);
        }

        public void Delete(int id)
        {
            var rendeles = db.rendeles.Find(id);
            if (rendeles != null)
            {
                db.rendeles.Remove(rendeles);
            }
        }

        public void Update(rendelesVM rendelesVM)
        {
            var rendeles = db.rendeles.Find(rendelesVM.rendelesId);
            if (rendeles != null)
            {
                rendeles.datum = rendelesVM.rendelesDatum;
                rendeles.napok_szama = rendelesVM.rendelesNapok;
                rendeles.ar = rendelesVM.rendelesAr;
                rendeles.jarmu_id = rendelesVM.jarmuId;
                rendeles.ugyfel_id = rendelesVM.ugyfelId;
                db.Entry(rendeles).State = EntityState.Modified;
            }
        }

        public void Save()
        {
            db.SaveChanges();
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
