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
    public class UgyfelRepository : IDisposable
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<ugyfel> GetAllUgyfel(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.ugyfel.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                int irszam;
                int.TryParse(search, out irszam);

                query = query.Where(x => x.vezeteknev.ToLower().Contains(search) ||
                                        x.keresztnev.ToLower().Contains(search) ||
                                        x.varos.ToLower().Contains(search) ||
                                        x.cim.ToLower().Contains(search) ||
                                        x.irszam.Equals(irszam) ||
                                        x.telefonszam.ToLower().Contains(search) ||
                                        x.email.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
                        break;
                    case "vezeteknev":
                        query = ascending ? query.OrderBy(x => x.vezeteknev) : query.OrderByDescending(x => x.vezeteknev);
                        break;
                    case "keresztnev":
                        query = ascending ? query.OrderBy(x => x.keresztnev) : query.OrderByDescending(x => x.keresztnev);
                        break;
                    case "varos":
                        query = ascending ? query.OrderBy(x => x.varos) : query.OrderByDescending(x => x.varos);
                        break;
                    case "cim":
                        query = ascending ? query.OrderBy(x => x.cim) : query.OrderByDescending(x => x.cim);
                        break;
                    case "irszam":
                        query = ascending ? query.OrderBy(x => x.irszam) : query.OrderByDescending(x => x.irszam);
                        break;
                    case "telefonszam":
                        query = ascending ? query.OrderBy(x => x.telefonszam) : query.OrderByDescending(x => x.telefonszam);
                        break;
                    case "email":
                        query = ascending ? query.OrderBy(x => x.email) : query.OrderByDescending(x => x.email);
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

            return new BindingList<ugyfel>(query.ToList());
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
