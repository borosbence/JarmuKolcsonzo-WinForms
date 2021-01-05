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

        public BindingList<ugyfel> GetAll(
            int page = 1,
            int itemsPerPage = 20,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.ugyfel.OrderBy(x => x.id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                int irszam;
                int.TryParse(search, out irszam);

                query = query.Where(x => x.vezeteknev.Contains(search) ||
                                        x.keresztnev.Contains(search) ||
                                        x.varos.Contains(search) ||
                                        x.cim.Contains(search) ||
                                        x.iranyitoszam.Equals(irszam) ||
                                        x.telefonszam.Contains(search) ||
                                        x.email.Contains(search) ||
                                        x.iranyitoszam.Equals(irszam));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
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
                    case "iranyitoszam":
                        query = ascending ? query.OrderBy(x => x.iranyitoszam) : query.OrderByDescending(x => x.iranyitoszam);
                        break;
                    case "telefonszam":
                        query = ascending ? query.OrderBy(x => x.telefonszam) : query.OrderByDescending(x => x.telefonszam);
                        break;
                    case "email":
                        query = ascending ? query.OrderBy(x => x.email) : query.OrderByDescending(x => x.email);
                        break;
                    case "pont":
                        query = ascending ? query.OrderBy(x => x.email) : query.OrderByDescending(x => x.email);
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

            return new BindingList<ugyfel>(query.ToList());
        }

        public int TotalItems
        {
            get { return _totalItems; }
        }

        public ugyfel GetUgyfel(string nev)
        {
            return db.ugyfel.AsNoTracking().SingleOrDefault(x => (x.vezeteknev + " " + x.keresztnev) == nev);
        }

        public bool Exists(ugyfel uf)
        {
            return db.ugyfel.Any(x => x.id == uf.id);
        }

        public void Insert(ugyfel ugyfel)
        {
            db.ugyfel.Add(ugyfel);
        }

        public void Delete(int id)
        {
            var ugyfel = db.ugyfel.Find(id);
            db.ugyfel.Remove(ugyfel);
        }

        public void Update(ugyfel param)
        {
            var uf = db.ugyfel.Find(param.id);
            if (uf != null)
            {
                db.Entry(uf).CurrentValues.SetValues(param);
            }
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
