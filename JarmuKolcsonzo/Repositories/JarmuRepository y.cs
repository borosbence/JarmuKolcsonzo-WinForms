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
            var query = db.jarmu.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                double fogyasztas;
                double.TryParse(search, out fogyasztas);
                if (fogyasztas > 0)
                {
                    query = query.Where(x => x.fogyasztas.Value.Equals(fogyasztas));
                }
                else
                {
                    query = query.Where(x => x.rendszam.ToLower().Contains(search) ||
                                         x.tipus.ToLower().Contains(search) ||
                                         x.modell.ToLower().Contains(search));
                }
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
                        break;
                    case "kategoriaId":
                        query = ascending ? query.OrderBy(x => x.kategoriaId) : query.OrderByDescending(x => x.kategoriaId);
                        break;
                    case "rendszam":
                        query = ascending ? query.OrderBy(x => x.rendszam) : query.OrderByDescending(x => x.rendszam);
                        break;
                    case "tipus":
                        query = ascending ? query.OrderBy(x => x.tipus) : query.OrderByDescending(x => x.tipus);
                        break;
                    case "modell":
                        query = ascending ? query.OrderBy(x => x.modell) : query.OrderByDescending(x => x.modell);
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
            var jarmu = db.jarmu.Find(param.Id);
            if (jarmu != null)
            {
                db.Entry(jarmu).CurrentValues.SetValues(param);
            }
        }

        public bool Exists(jarmu jarmu)
        {
            return db.jarmu.Any(x => x.Id == jarmu.Id);
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
