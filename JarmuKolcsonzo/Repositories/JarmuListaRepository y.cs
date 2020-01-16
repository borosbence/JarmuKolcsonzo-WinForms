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
    public class JarmuListaRepository : IDisposable
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
            var query = db.jarmu.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.rendszam.Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                query = query.OrderBy(x => x.rendszam);
            }
            if (!ascending)
            {
                query.Reverse();
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

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
