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
    class JarmuRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu> GetAll(
            int page = 1,
            int itemsPerPage = 20,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.jarmu.OrderBy(x => x.rendszam).AsQueryable();
            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                // Ha a keresési kulcsszó szám
                if (int.TryParse(search, out int dij))
                {
                    query = query.Where(x => x.dij == dij);
                }
                // TODO: ezt még javítani
                else if (DateTime.TryParse(search, out DateTime datum))
                {
                    query = query.Where(x => x.szerviz_datum.Value.ToString("yyyy. MM. dd.") == search);
                }
                // Szöveges keresés
                else
                {
                    query = query.Where(x =>
                        x.rendszam.Contains(search) ||
                        x.jarmu_tipus.megnevezes.Contains(search));
                }
            }
            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "rendszam":
                        query = ascending ? query.OrderBy(x => x.rendszam) : query.OrderByDescending(x => x.rendszam);
                        break;
                    case "tipus":
                        query = ascending ? query.OrderBy(x => x.jarmu_tipus.megnevezes) : query.OrderByDescending(x => x.jarmu_tipus.megnevezes);
                        break;
                    case "dij":
                        query = ascending ? query.OrderBy(x => x.dij) : query.OrderByDescending(x => x.dij);
                        break;
                    case "elerheto":
                        query = ascending ? query.OrderBy(x => x.elerheto) : query.OrderByDescending(x => x.elerheto);
                        break;
                    case "szerviz_datum":
                        query = ascending ? query.OrderBy(x => x.szerviz_datum) : query.OrderByDescending(x => x.szerviz_datum);
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

            return new BindingList<jarmu>(query.ToList());
        }

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public bool Exists(string rendszam)
        {
            return db.jarmu.Any(x => x.rendszam.Equals(rendszam));
        }

        public jarmu GetJarmu(string rendszam)
        {
            return db.jarmu.AsNoTracking().SingleOrDefault(x => x.rendszam == rendszam);
        }

        public void Insert(jarmu jarmu)
        {
            db.jarmu.Add(jarmu);
        }

        public void Update(jarmu param)
        {
            var jarmu = db.jarmu.Find(param.id);
            if (jarmu != null)
            {
                db.Entry(jarmu).CurrentValues.SetValues(param);
            }
        }

        public void Delete(int id)
        {
            var jarmu = db.jarmu.Find(id);
            db.jarmu.Remove(jarmu);
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
