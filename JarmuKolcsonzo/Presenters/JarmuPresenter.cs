using JarmuKolcsonzo.Models;
using JarmuKolcsonzo.Properties;
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
        IJarmuView view;
        JarmuRepository repo = new JarmuRepository();

        public JarmuPresenter(IJarmuView param)
        {
            view = param;
        }

        public void LoadData()
        {
            using (var jkRepo = new JarmuKategoriaRepository())
            {
                view.jarmukategoriaList = jkRepo.GetAllJarmuKategoria();
            }
        }

        public void Save(jarmu jarmu)
        {
            view.errorRendszam = null;
            view.errorFerohely = null;

            bool helyes = true;
            if (string.IsNullOrEmpty(jarmu.rendszam))
            {
                view.errorRendszam = Resources.KotelezoMezo;
                helyes = false;
            }
            if (jarmu.ferohely < 1)
            {
                view.errorFerohely = Resources.KotelezoMezo;
                helyes = false;
            }

            // Repo ellenőrzés
            if (helyes)
            {
                if (repo.Exists(jarmu))
                {
                    try
                    {
                        repo.Update(jarmu);
                    }
                    catch (Exception ex)
                    {
                        view.errorRendszam = ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        repo.Insert(jarmu);
                    }
                    catch (Exception ex)
                    {
                        view.errorRendszam = ex.Message;
                    }
                }
            }
        }
    }
}
