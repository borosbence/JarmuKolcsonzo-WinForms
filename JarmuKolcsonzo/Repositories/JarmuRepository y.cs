using JarmuKolcsonzo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Repositories
{
    public class JarmuRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu> GetAllJarmu(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.jarmu.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                query = query.Where(x => x.rendszam.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.rendszam) : query.OrderByDescending(x => x.rendszam);
                        break;
                    case "tipus":
                        query = ascending ? query.OrderBy(x => x.jarmu_tipus.megnevezes) : query.OrderByDescending(x => x.jarmu_tipus);
                        break;
                    case "dij":
                        query = ascending ? query.OrderBy(x => x.dij) : query.OrderByDescending(x => x.dij);
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

            return new BindingList<jarmu>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(jarmu jarmu)
        {
            if (db.jarmu.Any(x => x.rendszam == jarmu.rendszam))
            {
                throw new Exception("Már létezik ilyen rendszámmal jármű!");
            }
            db.jarmu.Add(jarmu);
        }

        public void Delete(int id)
        {
            var jarmu = db.jarmu.Find(id);
            db.jarmu.Remove(jarmu);
        }

        public void Update(jarmu param)
        {
            var jarmu = db.jarmu.Find(param.id);
            if (jarmu != null)
            {
                db.Entry(jarmu).CurrentValues.SetValues(param);
            }
        }

        public jarmu GetJarmuByLicensePlate(string rendszam)
        {
            return db.jarmu.AsNoTracking().SingleOrDefault(x => x.rendszam == rendszam);
        }

        public bool Exists(jarmu jarmu)
        {
            return db.jarmu.Any(x => x.id == jarmu.id);
        }

        public void Save()
        {
            db.SaveChanges();
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
