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
            view.errorMessage = null;

            if (repo.Exists(jarmu))
            {
                try
                {
                    repo.Update(jarmu);
                }
                catch (Exception ex)
                {
                    view.errorMessage = ex.Message;
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
                    view.errorMessage = ex.Message;
                }
            }
        }
    }
}
