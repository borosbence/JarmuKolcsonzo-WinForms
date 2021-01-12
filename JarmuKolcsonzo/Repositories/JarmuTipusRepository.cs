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
    class JarmuTipusRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu_tipus> GetAll(
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
                query = query.Where(x => x.megnevezes.Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "megnevezes":
                        query = ascending ? query.OrderBy(x => x.megnevezes) : query.OrderByDescending(x => x.megnevezes);
                        break;
                    case "ferohely":
                        query = ascending ? query.OrderBy(x => x.ferohely) : query.OrderByDescending(x => x.ferohely);
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

            return new BindingList<jarmu_tipus>(query.ToList());
        }

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public bool Exists(string megnevezes)
        {
            return db.jarmu_tipus.Any(x => x.megnevezes.Equals(megnevezes));
        }

        public void Insert(jarmu_tipus tipus)
        {
            db.jarmu_tipus.Add(tipus);
        }

        public void Update(jarmu_tipus param)
        {
            var tipus = db.jarmu_tipus.Find(param.id);
            if (tipus != null)
            {
                db.Entry(tipus).CurrentValues.SetValues(param);
            }
        }

        public void Delete(int id)
        {
            var tipus = db.jarmu_tipus.Find(id);
            if (tipus != null)
            {
                db.jarmu_tipus.Remove(tipus);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
