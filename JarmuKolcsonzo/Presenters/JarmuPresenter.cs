using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class JarmuPresenter
    {
        private IJarmuView view;
        private JarmuRepository repo;
        private JarmuTipusRepository tipusRepo;
        public JarmuPresenter(IJarmuView param)
        {
            view = param;
            repo = new JarmuRepository();
            tipusRepo = new JarmuTipusRepository();
        }

        public void LoadData()
        {
            view.tipusList = tipusRepo.GetAll();
        }

        public bool ValidateData()
        {
            var valid = true;
            view.errorRendszam = null;
            // Ha már van ilyen nevű rendszám létrehozva
            if (repo.Exists(view.jarmu.rendszam) &&
                // Ha új elem, akkor az id úgyis 0
                view.jarmu.id == 0)
            {
                valid = false;
                view.errorRendszam = "Már van ilyen rendszámú jármű létrehozva.";
            }
            return valid;
        }
    }
}