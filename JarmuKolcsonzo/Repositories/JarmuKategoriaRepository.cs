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
    public class JarmuKategoriaRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmukategoria> GetAllJarmuKategoria(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.jarmukategoria.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.kategoriaNev.Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {

                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
                        break;
                    case "kategoriaNev":
                        query = ascending ? query.OrderBy(x => x.kategoriaNev) : query.OrderByDescending(x => x.kategoriaNev);
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

            return new BindingList<jarmukategoria>(query.ToList());
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
