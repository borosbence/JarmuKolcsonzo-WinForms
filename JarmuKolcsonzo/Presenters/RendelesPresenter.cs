using JarmuKolcsonzo.Properties;
using JarmuKolcsonzo.Repositories;
using JarmuKolcsonzo.ViewInterfaces;
using JarmuKolcsonzo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JarmuKolcsonzo.Presenters
{
    public class RendelesPresenter
    {
        private IRendelesView view;
        private UgyfelRepository ugyfelRepo = new UgyfelRepository();
        private JarmuRepository jarmuRepo = new JarmuRepository();

        public RendelesPresenter(IRendelesView param)
        {
            view = param;
        }

        public void LoadData()
        {
            view.ugyfelList = ugyfelRepo.GetAll().Select(x => x.TeljesNev).ToArray();
            view.jarmuList = jarmuRepo.GetAll().Where(x => x.elerheto == true).Select(x => x.rendszam).ToArray();
        }

        public bool ValidateData()
        {
            view.errorUgyfelNev = null;
            view.errorJarmuRendszam = null;
            bool valid = true;

            if (string.IsNullOrEmpty(view.rendelesVM.ugyfelNev))
            {
                view.errorUgyfelNev = Resources.KotelezoMezo;
                valid = false;
            }
            else if (ugyfelRepo.GetUgyfel(view.rendelesVM.ugyfelNev) == null)
            {
                view.errorUgyfelNev = Resources.NemUgyfel;
                valid = false;
            }

            if (string.IsNullOrEmpty(view.rendelesVM.jarmuRendszam))
            {
                view.errorJarmuRendszam = Resources.KotelezoMezo;
                valid = false;
            }
            else if (jarmuRepo.GetJarmu(view.rendelesVM.jarmuRendszam) == null)
            {
                view.errorJarmuRendszam = Resources.NemJarmu;
                valid = false;
            }

            return valid;
        }
    }
}
