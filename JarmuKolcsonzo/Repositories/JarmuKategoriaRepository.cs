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
    public class JarmuKategoriaRepository
    {
        private JKContext db = new JKContext();
        private int _totalItems;

        public BindingList<jarmukategoria> GetAllJarmuKategoria(
            int page = 1,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            db.jarmukategoria.Local.Clear();
            db.jarmukategoria
                .OrderBy(x => x.Id)
                // Oldaltördelés
                .Skip(page - 1).Take(itemsPerPage).Load();
            var query = db.jarmukategoria.Local.ToBindingList();

            // Összes adat kiszámítása
            _totalItems = db.jarmukategoria.Count();

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
