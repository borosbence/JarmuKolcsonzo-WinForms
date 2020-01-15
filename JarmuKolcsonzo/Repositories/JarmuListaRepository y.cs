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
    public class JarmuListaRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmu> GetAllJarmu(
            int page = 0,
            int itemsPerPage = 25,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            db.jarmu.Local.Clear();
            db.jarmu
                .OrderBy(x => x.Id)
                // Oldaltördelés
                .Skip(page -1).Take(itemsPerPage).Load();
            var query = db.jarmu.Local.ToBindingList();

            // Összes adat kiszámítása
            _totalItems = db.jarmu.Count();

            return query;
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
