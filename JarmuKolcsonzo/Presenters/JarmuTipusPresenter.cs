using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class JarmuTipusPresenter
    {
        private IJarmuTipusView view;
        private JarmuTipusRepository repo = new JarmuTipusRepository();

        public JarmuTipusPresenter(IJarmuTipusView param)
        {
            view = param;
            repo = new JarmuTipusRepository();
        }

        public bool ValidateData()
        {
            var valid = true;
            view.errorMessage = null;
            // Ha már van ilyen nevű típus létrehozva
            if (repo.Exists(view.tipus.megnevezes) &&
                // Ha új elem, akkor az id úgyis 0
                view.tipus.id == 0)
            {
                valid = false;
                view.errorMessage = "Már van ilyen típus létrehozva.";
            }
            return valid;
        }
    }
}
