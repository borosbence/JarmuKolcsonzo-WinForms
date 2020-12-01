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
    public class JarmuTipusRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu_tipus> GetAllJarmuTipus(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.jarmu_tipus.OrderBy(x => x.megnevezes).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.megnevezes.Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.megnevezes) : query.OrderByDescending(x => x.megnevezes);
                        break;
                    case "megnevezes":
                        query = ascending ? query.OrderBy(x => x.megnevezes) : query.OrderByDescending(x => x.megnevezes);
                        break;
                    case "ferohely":
                        query = ascending ? query.OrderBy(x => x.ferohely) : query.OrderByDescending(x => x.ferohely);
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

            return new BindingList<jarmu_tipus>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(jarmu_tipus tipus)
        {
            if (db.jarmu_tipus.Any(x => x.megnevezes == tipus.megnevezes))
            {
                throw new Exception("Már létezik ilyen névvel kategória!");
            }
            db.jarmu_tipus.Add(tipus);
        }

        public void Delete(int id)
        {
            var tipus = db.jarmu_tipus.Find(id);
            db.jarmu_tipus.Remove(tipus);
        }

        public void Update(jarmu_tipus param)
        {
            var tipus = db.jarmu_tipus.Find(param.id);
            if (tipus != null)
            {
                db.Entry(tipus).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(jarmu_tipus tipus)
        {
            return db.jarmu_tipus.Any(x => x.id == tipus.id);
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
